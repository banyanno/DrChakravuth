Public Class FormFibroEnglish
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
  

    Private Sub BtnAddConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddConclusion.Click
        If DA_FibroConclusion.SelectConclusion(CInt(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value), CInt(Me.cboFibroConclusion.SelectedValue)).Rows.Count > 0 Then
            MsgBox("The conclusion was added already", MsgBoxStyle.OkOnly, "Existing Conclusion")
        Else
            If DA_FibroConclusion.Insert(CInt(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value), CInt(Me.cboFibroConclusion.SelectedValue)) = 1 Then
                RefreshConclusionList()
                cboFibroConclusion.SelectedIndex = -1
            End If

        End If
    End Sub
    Sub RefreshConclusionList()
        Me.conclusionlist.DataSource = DA_FibroConclusion.SelectConclusionByRequestID(CInt(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value))
    End Sub

    Private Sub FormFibroEnglish_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboFibroDemander.DataSource = DA_Doctor.SelectDoctor
        Me.cboFibroDemander.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        Me.cboFibroDemander.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        cboFibroDemander.SelectedIndex = -1

        Me.cboFibroAnesthegiste.DataSource = DA_Doctor.SelectDoctor
        Me.cboFibroAnesthegiste.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        Me.cboFibroAnesthegiste.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        cboFibroAnesthegiste.SelectedIndex = -1



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
        Dim RequestIDVal As Double = CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)
        If DA_Fibro.SelectFibroByRequestID(RequestIDVal).Rows.Count >= 1 Then
            ''Get Fibro
            Dim FibroTable As New DataTable
            FibroTable = DA_Fibro.SelectFibroByRequestID(RequestIDVal)
            Me.cboFibroDemander.SelectedValue = FibroTable.Rows(0).Item("demander")
            Me.txtFibroTolerance.Text = FibroTable.Rows(0).Item("tolerance")
            Me.chkFibroAnesthegiste.Checked = FibroTable.Rows(0).Item("is_anesthegiste")
            Me.cboFibroAnesthegiste.SelectedValue = FibroTable.Rows(0).Item("anesthegiste")
            TxtIntroduction.Text = IIf(TypeOf FibroTable.Rows(0).Item("Introduction") Is DBNull, "", FibroTable.Rows(0).Item("Introduction"))
            TxtIndication.Text = IIf(TypeOf FibroTable.Rows(0).Item("Indication") Is DBNull, "", FibroTable.Rows(0).Item("Indication"))
            TxtMedication.Text = IIf(TypeOf FibroTable.Rows(0).Item("Medication") Is DBNull, "", FibroTable.Rows(0).Item("Medication"))
            TxtFentanyl.Text = IIf(TypeOf FibroTable.Rows(0).Item("Fentanyl") Is DBNull, "", FibroTable.Rows(0).Item("Fentanyl"))
            TxtPropofol.Text = IIf(TypeOf FibroTable.Rows(0).Item("Propofol") Is DBNull, "", FibroTable.Rows(0).Item("Propofol"))
            TxtXylocainegel.Text = IIf(TypeOf FibroTable.Rows(0).Item("Xylocainegel") Is DBNull, "", FibroTable.Rows(0).Item("Xylocainegel"))
            TxtEsophagus.Text = IIf(TypeOf FibroTable.Rows(0).Item("Esophagus") Is DBNull, "", FibroTable.Rows(0).Item("Esophagus"))
            TxtStomach.Text = IIf(TypeOf FibroTable.Rows(0).Item("StomachandDuodenum") Is DBNull, "", FibroTable.Rows(0).Item("StomachandDuodenum"))
            TxtAssessment.Text = IIf(TypeOf FibroTable.Rows(0).Item("Assessment") Is DBNull, "", FibroTable.Rows(0).Item("Assessment"))

            'Me.cboFibroMotify.SelectedValue = FibroTable.Rows(0).Item("motify")
            'Me.txtFibroOeso.Text = FibroTable.Rows(0).Item("oesophage")
            'Me.txtFibroEsto.Text = FibroTable.Rows(0).Item("estomac")
            'Me.txtFibroLac.Text = FibroTable.Rows(0).Item("lac_muqueux")
            'Me.txtFibroGrosse.Text = FibroTable.Rows(0).Item("grosse_tub")
            'Me.txtFibroD1.Text = FibroTable.Rows(0).Item("d1_de_d2")
            'Me.txtFibroPylore.Text = FibroTable.Rows(0).Item("pylore")
            'Me.txtFibroFundus.Text = FibroTable.Rows(0).Item("fundus")
            'Me.txtFibroAntre.Text = FibroTable.Rows(0).Item("antre")
            'Me.txtFibroBulbe.Text = FibroTable.Rows(0).Item("bulbe")
            'If FibroTable.Rows(0).Item("cf") = "" Then
            '    ChAnaPath.Checked = False
            'Else
            '    ChAnaPath.Checked = True
            'End If
            'IIf(FibroTable.Rows(0).Item("cf") = "", ChAnaPath.Checked = False, ChAnaPath.Checked = True)
            'Me.txtFibroCF.Text = FibroTable.Rows(0).Item("cf")
            Me.cboFibroDocteur.SelectedValue = FibroTable.Rows(0).Item("Doctor_ID")
            Try
                Me.TxtOther.Text = FibroTable.Rows(0).Item("more_info")
            Catch ex As Exception
                Me.TxtOther.Text = ""
            End Try


            ''Load Conclusion Data
            Me.conclusionlist.DataSource = DA_FibroConclusion.SelectConclusionByRequestID(CInt(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value))

        End If
    End Sub

    Private Sub chkFibroAnesthegiste_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFibroAnesthegiste.CheckedChanged
        If chkFibroAnesthegiste.Checked = True Then
            Me.cboFibroAnesthegiste.Enabled = True
        Else
            Me.cboFibroAnesthegiste.Enabled = False
        End If
    End Sub



    Function GetValueConclustion() As String
        Dim ConValue As String = ""
        For i As Integer = 0 To conclusionlist.RowCount - 1
            ConValue = ConValue & "" & conclusionlist.GetRow(i).Cells("conclusion_name").Value
        Next
        Return ConValue
    End Function

    Private Sub BtnRemoveConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveConclusion.Click
        If Me.conclusionlist.RowCount >= 1 Then
            DA_FibroConclusion.DeleteConclusion(CInt(Me.conclusionlist.CurrentRow.Cells("request_id").Value), CInt(Me.conclusionlist.CurrentRow.Cells("conclusion_id").Value))
            RefreshConclusionList()
        End If

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If ValidateCombobox(cboFibroDemander, "", ErrAlert) = False Then Exit Sub
        If ValidateCombobox(cboFibroDocteur, "", ErrAlert) = False Then Exit Sub
        Dim FibroAnes As String = ""
        If Me.chkFibroAnesthegiste.Checked = True Then
            If ValidateCombobox(cboFibroAnesthegiste, "", ErrAlert) = False Then Exit Sub
            FibroAnes = Me.cboFibroAnesthegiste.SelectedValue '.ToString.Replace("'", "''")
        End If
        If MessageBox.Show("Do you want save Fibro scopy?", "Fibro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim RequestIDVal As Double = CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)

            If DA_Fibro.SelectFibroByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
                '' Update
                If DA_Fibro.UpdateFibroscopyEng(cboFibroDemander.SelectedValue.ToString, txtFibroTolerance.Text, chkFibroAnesthegiste.Checked, FibroAnes, cboFibroDocteur.Text, DateResultExam.Value.Date, CInt(cboFibroDocteur.SelectedValue), GetValueConclustion, TxtIntroduction.Text, TxtIndication.Text, TxtMedication.Text, TxtFentanyl.Text, TxtPropofol.Text, TxtXylocainegel.Text, TxtEsophagus.Text, TxtStomach.Text, TxtAssessment.Text, TxtOther.Text, RequestIDVal) = 1 Then
                    MsgBox("The fibroscopy has been saved successfully", MsgBoxStyle.OkOnly, "Saved Fibroscopy")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            Else
                '' Add New
                If DA_Fibro.InsertFibroscopyEng(RequestIDVal, LblPatientNo.Text, cboFibroDemander.Text, txtFibroTolerance.Text, chkFibroAnesthegiste.Checked, FibroAnes, cboFibroDocteur.Text, DateResultExam.Value.Date, CInt(cboFibroDocteur.SelectedValue), GetValueConclustion, TxtIntroduction.Text, TxtIndication.Text, TxtMedication.Text, TxtFentanyl.Text, TxtPropofol.Text, TxtXylocainegel.Text, TxtEsophagus.Text, TxtStomach.Text, TxtAssessment.Text, TxtOther.Text) = 1 Then
                    MsgBox("A fibroscopy has been saved successfully", MsgBoxStyle.OkOnly, "Saved Fibroscopy")
                    DA_DOCTOR_FEE.InsertNewDoctorFee(CInt(cboFibroDocteur.SelectedValue), cboFibroDocteur.Text, "Fibroscopy", DateResultExam.Value.Date, LblPatientNo.Text, 0, lblPatientName.Text, GetValueConclustion)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End If
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If DA_Fibro.SelectFibroByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows.Count <= 0 Then
            DA_FibroConclusion.DeleteConclusionByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value))
        End If
        Me.Close()
    End Sub
End Class