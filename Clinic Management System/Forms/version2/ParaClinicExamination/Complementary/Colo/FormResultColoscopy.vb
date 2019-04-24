Public Class FormResultColoscopy
    'Dim DA_Conclusion As New DSExaminationTableAdapters.tblconclusionTableAdapter
    Dim DA_Colo As New DSExaminationTableAdapters.tblcoloscopyTableAdapter
    Dim DA_ColoConclusion As New DSExaminationTableAdapters.tblcoloconclusionTableAdapter
    'Dim DA_Motify As New DSExaminationTableAdapters.tblmotifyTableAdapter
    Dim DA_Motif_Colo As New DS_ParameterTableAdapters.tblMotiveOfColoscopyTableAdapter
    Dim DA_ConclustionColo As New DS_ParameterTableAdapters.tblConclusionOfColoscopyTableAdapter
    Dim DA_Doctor As New DSPAtientTableAdapters.DoctorsTableAdapter
    Dim DA_Preparation As New DSExaminationTableAdapters.tblpreparationTableAdapter
    Dim RequestPanel As DashbordDotorRequestExamination
    Dim DA_DOCTOR_FEE As New DSConsultationTableAdapters.DOCTOR_FEETableAdapter
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
    Private Sub FormResultColoscopy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '' Load Colo Combox DataSource
        Me.cboColoDemander.DataSource = DA_Doctor.SelectDoctor
        Me.cboColoDemander.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        Me.cboColoDemander.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        cboColoDemander.SelectedIndex = -1

        Me.cboColoAnesthegiste.DataSource = DA_Doctor.SelectDoctor
        Me.cboColoAnesthegiste.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        Me.cboColoAnesthegiste.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        cboColoAnesthegiste.SelectedIndex = -1

        'Me.cboColoDocteur.DataSource = DA_Doctor.SelectDoctor
        'Me.cboColoDocteur.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        'Me.cboColoDocteur.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        'cboColoDocteur.SelectedIndex = -1

        Me.cboColoMotify.DataSource = DA_Motif_Colo.GetData
        Me.cboColoMotify.ValueMember = DA_Motif_Colo.GetData.Columns("Motive").ColumnName
        Me.cboColoMotify.DisplayMember = DA_Motif_Colo.GetData.Columns("Motive").ColumnName
        cboColoMotify.SelectedIndex = -1

        Me.cboColoPreparation.DataSource = DA_Preparation.SelectPreparation
        Me.cboColoPreparation.ValueMember = DA_Preparation.SelectPreparation.Columns("preparation_name").ColumnName
        Me.cboColoPreparation.DisplayMember = DA_Preparation.SelectPreparation.Columns("preparation_name").ColumnName
        cboColoPreparation.SelectedIndex = -1

        Me.cboColoConclusion.DataSource = DA_ConclustionColo.GetData
        Me.cboColoConclusion.ValueMember = DA_ConclustionColo.GetData.Columns("ConclusionID").ColumnName
        Me.cboColoConclusion.DisplayMember = DA_ConclustionColo.GetData.Columns("Conclusion").ColumnName
        cboColoConclusion.SelectedIndex = -1
        With cboColoDocteur
            .DataSource = DA_User.GetDoctorInfomation
            .ValueMember = "UserID"
            .DisplayMember = "ShowName"
            .SelectedIndex = -1
        End With
        LoadColoData()
        cboColoDocteur.SelectedValue = USER_ID
    End Sub
    Sub LoadColoData()
        Try
            If DA_Colo.SelectColoByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
                Dim ColoTable As New DataTable
                ColoTable = DA_Colo.SelectColoByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value))
                Me.txtColoDuree.Text = ColoTable.Rows(0).Item("duree")
                Me.txtColoEva.Text = ColoTable.Rows(0).Item("eva")
                Me.cboColoPreparation.SelectedValue = ColoTable.Rows(0).Item("preparation")
                Me.cboColoDemander.SelectedValue = ColoTable.Rows(0).Item("demander")
                Me.txtColoTolerance.Text = ColoTable.Rows(0).Item("tolerance")
                Me.chkColoAnesthegiste.Checked = ColoTable.Rows(0).Item("is_anethegiste")
                Me.cboColoAnesthegiste.SelectedValue = ColoTable.Rows(0).Item("anethegiste")
                Me.cboColoMotify.SelectedValue = ColoTable.Rows(0).Item("motiy")
                Me.txtColoCaecum.Text = ColoTable.Rows(0).Item("caecum")
                Me.txtColoColonDroit.Text = ColoTable.Rows(0).Item("colon_droit")
                Me.txtColoColonTransverse.Text = ColoTable.Rows(0).Item("colon_transverse")
                Me.txtColonGauche.Text = ColoTable.Rows(0).Item("colon_gauche")
                Me.txtColoSigmoide.Text = ColoTable.Rows(0).Item("sigmoide")
                Me.txtColoRectum.Text = ColoTable.Rows(0).Item("rectum")
                'Me.cboColoDocteur.SelectedValue = ColoTable.Rows(0).Item("docteur")
                Me.txtcolomoreinfo.Text = ColoTable.Rows(0).Item("more_info")
                txtnewfield.Text = ColoTable.Rows(0).Item("new_field")
                ''Load Conclusion Data
                Me.ConclusionList.DataSource = DA_ColoConclusion.SelectConclusionByRequestID(CInt(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value))
            End If
        Catch ex As Exception

        End Try

    End Sub
    Sub RefreshConclusionList()
        Me.ConclusionList.DataSource = DA_ColoConclusion.SelectConclusionByRequestID(CInt(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value))
    End Sub
    Private Sub BtnAddConclusion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAddConclusion.Click
        If DA_ColoConclusion.SelectConclusion(CInt(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value), CInt(Me.cboColoConclusion.SelectedValue)).Rows.Count > 0 Then
            MsgBox("The conclusion was added already", MsgBoxStyle.OkOnly, "Existing Conclusion")
        Else
            DA_ColoConclusion.Insert(CInt(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value), CInt(Me.cboColoConclusion.SelectedValue))
            RefreshConclusionList()
            cboColoConclusion.SelectedIndex = -1
        End If
    End Sub

    Private Sub BtnRemoveConclusion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnRemoveConclusion.Click
        If Me.ConclusionList.RowCount >= 1 Then
            DA_ColoConclusion.DeleteConclusion(CInt(Me.ConclusionList.CurrentRow.Cells("request_id").Value), CInt(Me.ConclusionList.CurrentRow.Cells("conclusion_id").Value))
            RefreshConclusionList()
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateCombobox(cboColoDemander, "", ErrAlert) = False Then Exit Sub
        If ValidateCombobox(cboColoPreparation, "", ErrAlert) = False Then Exit Sub
        If ValidateCombobox(cboColoMotify, "", ErrAlert) = False Then Exit Sub
        If ValidateCombobox(cboColoDocteur, "", ErrAlert) = False Then Exit Sub
        Dim ColoAnes As String = ""
        If Me.chkColoAnesthegiste.Checked = True Then
            If ValidateCombobox(cboColoAnesthegiste, "", ErrAlert) = False Then Exit Sub
            ColoAnes = Me.cboColoAnesthegiste.SelectedValue
        End If

        If DA_Colo.SelectColoByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
            '' Update
            If DA_Colo.UpdateColoByRequestID(Me.txtColoDuree.Text, Me.txtColoEva.Text, Me.cboColoPreparation.SelectedValue.ToString, Me.cboColoDemander.SelectedValue.ToString, Me.txtColoTolerance.Text, Me.chkColoAnesthegiste.Checked, ColoAnes, Me.cboColoMotify.SelectedValue, Me.txtColoCaecum.Text, Me.txtColoColonDroit.Text, Me.txtColoColonTransverse.Text, Me.txtColonGauche.Text, Me.txtColoSigmoide.Text, Me.txtColoRectum.Text, Me.cboColoDocteur.Text, Me.txtcolomoreinfo.Text.ToString, Me.txtnewfield.Text.ToString, DateResultExam.Value.Date, CInt(cboColoDocteur.SelectedValue), GetValueConclustion, CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)) = 1 Then
                MsgBox("The coloscopy has been saved successfully", MsgBoxStyle.OkOnly, "Saved Coloscopy")
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Else
            '' Add New
            If DA_Colo.InsertColo(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value), CLng(LblPatientNo.Text), Me.txtColoDuree.Text, Me.txtColoEva.Text, Me.cboColoPreparation.SelectedValue.ToString, Me.cboColoDemander.SelectedValue.ToString, Me.txtColoTolerance.Text, Me.chkColoAnesthegiste.Checked, ColoAnes, Me.cboColoMotify.SelectedValue.ToString, Me.txtColoCaecum.Text, Me.txtColoColonDroit.Text, Me.txtColoColonTransverse.Text, Me.txtColonGauche.Text, Me.txtColoSigmoide.Text, Me.txtColoRectum.Text, Me.cboColoDocteur.Text, Me.txtcolomoreinfo.Text, Me.txtnewfield.Text.ToString, DateResultExam.Value.Date, CInt(cboColoDocteur.SelectedValue), GetValueConclustion) = 1 Then
                MsgBox("A coloscopy has been saved successfully", MsgBoxStyle.OkOnly, "Saved Coloscopy")
                DA_DOCTOR_FEE.InsertNewDoctorFee(CInt(cboColoDocteur.SelectedValue), cboColoDocteur.Text, "Coloscopy", DateResultExam.Value.Date, LblPatientNo.Text, 0, lblPatientName.Text, GetValueConclustion)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub
    Function GetValueConclustion() As String
        Dim ConValue As String = ""
        For i As Integer = 0 To conclusionlist.RowCount - 1
            ConValue = ConValue & "" & ConclusionList.GetRow(i).Cells("Conclusion").Value & ", "
        Next
        Return ConValue
    End Function
    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        If DA_Colo.SelectColoByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows.Count <= 0 Then
            DA_ColoConclusion.DeleteConclusionByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value))
        End If
        Me.Close()
    End Sub

    Private Sub chkColoAnesthegiste_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkColoAnesthegiste.CheckedChanged
        If chkColoAnesthegiste.Checked = True Then
            Me.cboColoAnesthegiste.Enabled = True
        Else
            Me.cboColoAnesthegiste.Enabled = False
        End If
    End Sub

   
End Class