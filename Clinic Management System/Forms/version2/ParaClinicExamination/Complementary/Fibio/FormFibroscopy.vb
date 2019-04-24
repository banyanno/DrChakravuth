Public Class FormFibroscopy
    Dim DA_Conclusion As New DSExaminationTableAdapters.tblconclusionTableAdapter
    ' Dim DA_Motify As New DSExaminationTableAdapters.tblmotifyTableAdapter
    Dim DA_MotifFibroNaso As New DS_ParameterTableAdapters.tblMotiveOfFibroAnaNasoTableAdapter
    Dim DA_Doctor As New DSPAtientTableAdapters.DoctorsTableAdapter
    Dim DA_FibroConclusion As New DSExaminationTableAdapters.tblfibroconclusionTableAdapter


    Dim DA_Fibro As New DSExaminationTableAdapters.tblfibroscopyTableAdapter
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
    Private Sub FormFibroscopy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.cboFibroDemander.DataSource = DA_Doctor.SelectDoctor
        Me.cboFibroDemander.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        Me.cboFibroDemander.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        cboFibroDemander.SelectedIndex = -1

        Me.cboFibroAnesthegiste.DataSource = DA_Doctor.SelectDoctor
        Me.cboFibroAnesthegiste.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        Me.cboFibroAnesthegiste.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        cboFibroAnesthegiste.SelectedIndex = -1

        Me.cboFibroMotify.DataSource = DA_MotifFibroNaso.GetData
        Me.cboFibroMotify.ValueMember = DA_MotifFibroNaso.GetData.Columns("Motive").ColumnName
        Me.cboFibroMotify.DisplayMember = DA_MotifFibroNaso.GetData.Columns("Motive").ColumnName
        cboFibroMotify.SelectedIndex = -1

        'Me.cboFibroDocteur.DataSource = DA_Doctor.SelectDoctor
        'Me.cboFibroDocteur.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        'Me.cboFibroDocteur.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        'cboFibroDocteur.SelectedIndex = -1

        Me.cboFibroConclusion.DataSource = DA_Conclusion.SelectConclusion
        Me.cboFibroConclusion.ValueMember = DA_Conclusion.SelectConclusion.Columns("conclusion_id").ColumnName
        Me.cboFibroConclusion.DisplayMember = DA_Conclusion.SelectConclusion.Columns("conclusion_name").ColumnName
        cboFibroConclusion.SelectedIndex = -1
        With cboFibroDocteur
            .DataSource = DA_User.GetDoctorInfomation
            .ValueMember = "UserID"
            .DisplayMember = "ShowName"
            .SelectedIndex = -1
        End With
        LoadFibroData()
        cboFibroDocteur.SelectedValue = USER_ID
    End Sub
    Sub LoadFibroData()
        Try
            If DA_Fibro.SelectFibroByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
                ''Get Fibro
                Dim FibroTable As New DataTable
                FibroTable = DA_Fibro.SelectFibroByRequestID(CInt(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value))
                Me.cboFibroDemander.SelectedValue = FibroTable.Rows(0).Item("demander")
                Me.txtFibroTolerance.Text = FibroTable.Rows(0).Item("tolerance")
                Me.chkFibroAnesthegiste.Checked = FibroTable.Rows(0).Item("is_anesthegiste")
                Me.cboFibroAnesthegiste.SelectedValue = FibroTable.Rows(0).Item("anesthegiste")
                Me.cboFibroMotify.SelectedValue = FibroTable.Rows(0).Item("motify")
                Me.txtFibroOeso.Text = FibroTable.Rows(0).Item("oesophage")
                Me.txtFibroEsto.Text = FibroTable.Rows(0).Item("estomac")
                Me.txtFibroLac.Text = FibroTable.Rows(0).Item("lac_muqueux")
                Me.txtFibroGrosse.Text = FibroTable.Rows(0).Item("grosse_tub")
                Me.txtFibroD1.Text = FibroTable.Rows(0).Item("d1_de_d2")
                Me.txtFibroPylore.Text = FibroTable.Rows(0).Item("pylore")
                Me.txtFibroFundus.Text = FibroTable.Rows(0).Item("fundus")
                Me.txtFibroAntre.Text = FibroTable.Rows(0).Item("antre")
                Me.txtFibroBulbe.Text = FibroTable.Rows(0).Item("bulbe")
                If FibroTable.Rows(0).Item("cf") = "" Then
                    ChAnaPath.Checked = False
                Else
                    ChAnaPath.Checked = True
                End If
                'IIf(FibroTable.Rows(0).Item("cf") = "", ChAnaPath.Checked = False, ChAnaPath.Checked = True)
                'Me.txtFibroCF.Text = FibroTable.Rows(0).Item("cf")
                Me.cboFibroDocteur.SelectedValue = FibroTable.Rows(0).Item("Doctor_ID")
                Me.txtfibromoreinfo.Text = FibroTable.Rows(0).Item("more_info")

                ''Load Conclusion Data
                Me.conclusionlist.DataSource = DA_FibroConclusion.SelectConclusionByRequestID(CInt(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value))

            End If
        Catch ex As Exception

        End Try

    End Sub
    Sub RefreshConclusionList()
        Me.conclusionlist.DataSource = DA_FibroConclusion.SelectConclusionByRequestID(CInt(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value))
    End Sub

    Private Sub BtnAddConclusion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAddConclusion.Click
        If DA_FibroConclusion.SelectConclusion(CInt(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value), CInt(Me.cboFibroConclusion.SelectedValue)).Rows.Count > 0 Then
            MsgBox("The conclusion was added already", MsgBoxStyle.OkOnly, "Existing Conclusion")
        Else
            DA_FibroConclusion.Insert(CInt(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value), CInt(Me.cboFibroConclusion.SelectedValue))
            RefreshConclusionList()
            cboFibroConclusion.SelectedIndex = -1
        End If
    End Sub
    Function GetValueConclustion() As String
        Dim ConValue As String = ""
        For i As Integer = 0 To conclusionlist.RowCount - 1
            ConValue = ConValue & "" & conclusionlist.GetRow(i).Cells("conclusion_name").Value & ", "
        Next
        Return ConValue
    End Function

    Private Sub BtnRemoveConclusion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnRemoveConclusion.Click
        If Me.conclusionlist.RowCount >= 1 Then
            DA_FibroConclusion.DeleteConclusion(CInt(Me.conclusionlist.CurrentRow.Cells("request_id").Value), CInt(Me.conclusionlist.CurrentRow.Cells("conclusion_id").Value))
            RefreshConclusionList()
        End If

    End Sub

    Private Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateCombobox(cboFibroDemander, "", ErrAlert) = False Then Exit Sub
        If ValidateCombobox(cboFibroMotify, "", ErrAlert) = False Then Exit Sub
        If ValidateCombobox(cboFibroDocteur, "", ErrAlert) = False Then Exit Sub
        Dim FibroAnes As String = ""
        If Me.chkFibroAnesthegiste.Checked = True Then
            If ValidateCombobox(cboFibroAnesthegiste, "", ErrAlert) = False Then Exit Sub
            FibroAnes = Me.cboFibroAnesthegiste.SelectedValue '.ToString.Replace("'", "''")
        End If
        If MessageBox.Show("Do you want save Fibro scopy?", "Fibro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_Fibro.SelectFibroByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
                '' Update
                If DA_Fibro.UpdateFibroByRequestID(Me.cboFibroDemander.SelectedValue.ToString, Me.txtFibroTolerance.Text, chkFibroAnesthegiste.Checked, FibroAnes, Me.cboFibroMotify.SelectedValue.ToString, Me.txtFibroOeso.Text, Me.txtFibroEsto.Text, Me.txtFibroLac.Text, Me.txtFibroGrosse.Text, Me.txtFibroD1.Text, Me.txtFibroPylore.Text, Me.txtFibroFundus.Text, Me.txtFibroAntre.Text, Me.txtFibroBulbe.Text, IIf(ChAnaPath.Checked, ChAnaPath.Text, ""), Me.cboFibroDocteur.Text, Me.txtfibromoreinfo.Text.ToString, DateResultExam.Value.Date, CInt(cboFibroDocteur.SelectedValue), GetValueConclustion, CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)) = 1 Then
                    MsgBox("The fibroscopy has been saved successfully", MsgBoxStyle.OkOnly, "Saved Fibroscopy")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            Else
                '' Add New
                If DA_Fibro.InsertFibro(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value), CLng(LblPatientNo.Text), Me.cboFibroDemander.SelectedValue.ToString, Me.txtFibroTolerance.Text, chkFibroAnesthegiste.Checked, FibroAnes, Me.cboFibroMotify.SelectedValue.ToString, Me.txtFibroOeso.Text, Me.txtFibroEsto.Text, Me.txtFibroLac.Text, Me.txtFibroGrosse.Text, Me.txtFibroD1.Text, Me.txtFibroPylore.Text, Me.txtFibroFundus.Text, Me.txtFibroAntre.Text, Me.txtFibroBulbe.Text, IIf(ChAnaPath.Checked, ChAnaPath.Text, ""), Me.cboFibroDocteur.Text, Me.txtfibromoreinfo.Text.ToString, DateResultExam.Value.Date, CInt(cboFibroDocteur.SelectedValue), GetValueConclustion) = 1 Then
                    MsgBox("A fibroscopy has been saved successfully", MsgBoxStyle.OkOnly, "Saved Fibroscopy")
                    DA_DOCTOR_FEE.InsertNewDoctorFee(CInt(cboFibroDocteur.SelectedValue), cboFibroDocteur.Text, "Fibroscopy", DateResultExam.Value.Date, LblPatientNo.Text, 0, lblPatientName.Text, GetValueConclustion)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If

    End Sub

    Private Sub chkFibroAnesthegiste_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFibroAnesthegiste.CheckedChanged
        If chkFibroAnesthegiste.Checked = True Then
            Me.cboFibroAnesthegiste.Enabled = True
        Else
            Me.cboFibroAnesthegiste.Enabled = False
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        If DA_Fibro.SelectFibroByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows.Count <= 0 Then
            DA_FibroConclusion.DeleteConclusionByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value))
        End If
        Me.Close()
    End Sub

   


End Class