Public Class FormNasogastro
    Dim DA_Conclusion As New DSExaminationTableAdapters.tblconclusionTableAdapter
    Dim DA_NasoConclusion As New DSExaminationTableAdapters.tblnasoconclusionTableAdapter

    Dim DA_Doctor As New DSPAtientTableAdapters.DoctorsTableAdapter

    Dim DA_Naso As New DSExaminationTableAdapters.tblnasogastroTableAdapter
    Dim DA_MotifFibroNaso As New DS_ParameterTableAdapters.tblMotiveOfFibroAnaNasoTableAdapter
    Dim DA_DOCTOR_FEE As New DSConsultationTableAdapters.DOCTOR_FEETableAdapter
    Dim RequestPanel As DashbordDotorRequestExamination
    Dim DA_User As New DSUserManagermentTableAdapters.USERS_SYSTEMTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal PanelRequest As DashbordDotorRequestExamination)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.RequestPanel = PanelRequest
    End Sub
    Private Sub FormNasogastro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '' Load Naso Combox DataSource
        Me.cboNasoDemander.DataSource = DA_Doctor.SelectDoctor
        Me.cboNasoDemander.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        Me.cboNasoDemander.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        cboNasoDemander.SelectedIndex = -1

        'Me.cboNasoDocteur.DataSource = DA_Doctor.SelectDoctor
        'Me.cboNasoDocteur.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        'Me.cboNasoDocteur.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        'cboNasoDocteur.SelectedIndex = -1

        Me.cboNasoMotify.DataSource = DA_MotifFibroNaso.GetData
        Me.cboNasoMotify.ValueMember = DA_MotifFibroNaso.GetData.Columns("Motive").ColumnName
        Me.cboNasoMotify.DisplayMember = DA_MotifFibroNaso.GetData.Columns("Motive").ColumnName
        cboNasoMotify.SelectedIndex = -1

        Me.cboNasoConclusion.DataSource = DA_Conclusion.SelectConclusion
        Me.cboNasoConclusion.ValueMember = DA_Conclusion.SelectConclusion.Columns("conclusion_id").ColumnName
        Me.cboNasoConclusion.DisplayMember = DA_Conclusion.SelectConclusion.Columns("conclusion_name").ColumnName
        cboNasoConclusion.SelectedIndex = -1
        With cboNasoDocteur
            .DataSource = DA_User.GetDoctorInfomation
            .ValueMember = "UserID"
            .DisplayMember = "ShowName"
            .SelectedIndex = -1
        End With
        LoadNasoData()
        cboNasoDocteur.SelectedValue = USER_ID
    End Sub
    Sub LoadNasoData()
        If DA_Naso.SelectNasoByRequestID(CLng(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
            Dim NasoTable As New DataTable
            NasoTable = DA_Naso.SelectNasoByRequestID(CLng(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value))
            Me.cboNasoDemander.SelectedValue = NasoTable.Rows(0).Item("demander")
            Me.txtNasoTolerance.Text = NasoTable.Rows(0).Item("tolerance")
            Me.cboNasoMotify.SelectedValue = NasoTable.Rows(0).Item("motify")
            Me.txtNasoOeso.Text = NasoTable.Rows(0).Item("oesophage")
            Me.txtNasoEsto.Text = NasoTable.Rows(0).Item("estomac")
            Me.txtNasoPylore.Text = NasoTable.Rows(0).Item("pylore")
            Me.txtNasoBulbe.Text = NasoTable.Rows(0).Item("bulbe")
            Me.txtNasoD1.Text = NasoTable.Rows(0).Item("d1_de_d2")
            Me.TxtFundus.Text = NasoTable.Rows(0).Item("Fundus")
            Me.TxtAntre.Text = NasoTable.Rows(0).Item("Antre")
            If NasoTable.Rows(0).Item("cf") = "" Then
                ChAnaPath.Checked = False
            Else
                ChAnaPath.Checked = True
            End If

            'Me.txtNasoCF.Text = NasoTable.Rows(0).Item("cf")
            'Me.cboNasoDocteur.SelectedValue = NasoTable.Rows(0).Item("docteur")
            Me.txtnasomoreinfo.Text = NasoTable.Rows(0).Item("more_info")

            ''Load Conclusion Data
            Me.conclusionlist.DataSource = DA_NasoConclusion.SelectConclusionByRequestID(CInt(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value))
        End If
    End Sub
    Sub RefreshConclusionList()
        Me.conclusionlist.DataSource = DA_NasoConclusion.SelectConclusionByRequestID(CInt(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value))
    End Sub

    Private Sub BtnAddConclusion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAddConclusion.Click
        If DA_NasoConclusion.SelectConclusion(CInt(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value), CInt(Me.cboNasoConclusion.SelectedValue)).Rows.Count > 0 Then
            MsgBox("The conclusion was added already", MsgBoxStyle.OkOnly, "Existing Conclusion")
        Else
            DA_NasoConclusion.Insert(CInt(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value), CInt(Me.cboNasoConclusion.SelectedValue))
            RefreshConclusionList()
            cboNasoConclusion.SelectedIndex = -1
        End If
    End Sub

    Private Sub BtnRemoveConclusion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnRemoveConclusion.Click
        If Me.conclusionlist.RowCount >= 1 Then
            DA_NasoConclusion.DeleteConclusion(CInt(Me.conclusionlist.CurrentRow.Cells("request_id").Value), CInt(Me.conclusionlist.CurrentRow.Cells("conclusion_id").Value))
            RefreshConclusionList()
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        If DA_Naso.SelectNasoByRequestID(CLng(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value)).Rows.Count <= 0 Then
            DA_NasoConclusion.DeleteConclusionByRequestID(CLng(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value))
        End If
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateCombobox(cboNasoDemander, "", ErrAlert) = False Then Exit Sub
        If ValidateCombobox(cboNasoMotify, "", ErrAlert) = False Then Exit Sub
        If ValidateCombobox(cboNasoDocteur, "", ErrAlert) = False Then Exit Sub

        If DA_Naso.SelectNasoByRequestID(CLng(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
            '' Update
            If DA_Naso.UpdateNasoByRequestID(Me.cboNasoDemander.SelectedValue.ToString, Me.txtNasoTolerance.Text, Me.cboNasoMotify.SelectedValue.ToString, Me.txtNasoOeso.Text, Me.txtNasoEsto.Text, Me.txtNasoPylore.Text, Me.txtNasoBulbe.Text, Me.txtNasoD1.Text, IIf(ChAnaPath.Checked, ChAnaPath.Text, ""), Me.cboNasoDocteur.Text, Me.txtnasomoreinfo.Text.ToString, TxtLacMuquex.Text, TxtGrosseTuberose.Text, TxtFundus.Text, TxtAntre.Text, DateResultExam.Value.Date, CInt(cboNasoDocteur.SelectedValue), GetValueConclustion, CLng(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value)) = 1 Then
                MsgBox("The nasogastro has been saved successfully", MsgBoxStyle.OkOnly, "Saved Nasogastro")
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Else
            If DA_Naso.InsertNaso(CInt(Me.RequestPanel.RequestList.CurrentRow.Cells("ppatientid").Value), CLng(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value), Me.cboNasoDemander.SelectedValue.ToString, Me.txtNasoTolerance.Text, Me.cboNasoMotify.SelectedValue.ToString, Me.txtNasoOeso.Text, Me.txtNasoEsto.Text, Me.txtNasoPylore.Text, Me.txtNasoBulbe.Text, Me.txtNasoD1.Text, IIf(ChAnaPath.Checked, ChAnaPath.Text, ""), Me.cboNasoDocteur.Text, Me.txtnasomoreinfo.Text.ToString, TxtLacMuquex.Text, TxtGrosseTuberose.Text, TxtFundus.Text, TxtAntre.Text, DateResultExam.Value.Date, CInt(cboNasoDocteur.SelectedValue), GetValueConclustion) = 1 Then
                MsgBox("A nasogastro has been saved successfully", MsgBoxStyle.OkOnly, "Saved Nasogastro")
                DA_DOCTOR_FEE.InsertNewDoctorFee(CInt(cboNasoDocteur.SelectedValue), cboNasoDocteur.Text, "Nasogastro", DateResultExam.Value.Date, LblPatientNo.Text, 0, lblPatientName.Text, GetValueConclustion)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub
    Function GetValueConclustion() As String
        Dim ConValue As String = ""
        For i As Integer = 0 To conclusionlist.RowCount - 1
            ConValue = ConValue & "" & conclusionlist.GetRow(i).Cells("conclusion_name").Value & ", "
        Next
        Return ConValue
    End Function
End Class