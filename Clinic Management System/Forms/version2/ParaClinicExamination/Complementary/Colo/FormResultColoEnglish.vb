Public Class FormResultColoEnglish
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
    Sub New(ByVal PanelRequest As DashbordDotorRequestExamination)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.RequestPanel = PanelRequest
    End Sub
    Private Sub FormResultColoEnglish_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            If DA_Colo.SelectColoByRequestID(CLng(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
                Dim ColoTable As New DataTable
                ColoTable = DA_Colo.SelectColoByRequestID(CLng(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value))
                Me.txtColoDuree.Text = ColoTable.Rows(0).Item("duree")
                Me.txtColoEva.Text = ColoTable.Rows(0).Item("eva")
                Me.cboColoPreparation.SelectedValue = ColoTable.Rows(0).Item("preparation")
                Me.cboColoDemander.SelectedValue = ColoTable.Rows(0).Item("demander")
                Me.txtColoTolerance.Text = ColoTable.Rows(0).Item("tolerance")
                Me.chkColoAnesthegiste.Checked = ColoTable.Rows(0).Item("is_anethegiste")
                Me.cboColoAnesthegiste.SelectedValue = ColoTable.Rows(0).Item("anethegiste")
                TxtIntroduction.Text = ColoTable.Rows(0).Item("Introduction")
                TxtIndication.Text = ColoTable.Rows(0).Item("Indication")
                txtFentanyL.Text = ColoTable.Rows(0).Item("Fentanyl")
                TxtPropofol.Text = ColoTable.Rows(0).Item("Propofol")
                TxtXylocainegel.Text = ColoTable.Rows(0).Item("Xylocainegel")
                TxtRecalExam.Text = ColoTable.Rows(0).Item("Rectalexam")
                TxtFinding.Text = ColoTable.Rows(0).Item("Finding")
                TxtImpression.Text = ColoTable.Rows(0).Item("Impression")
                txtcolomoreinfo.Text = ColoTable.Rows(0).Item("more_info")
                'Me.cboColoDocteur.SelectedValue = ColoTable.Rows(0).Item("docteur")
               
                ''Load Conclusion Data
                Me.ConclusionList.DataSource = DA_ColoConclusion.SelectConclusionByRequestID(CInt(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value))
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub chkColoAnesthegiste_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkColoAnesthegiste.CheckedChanged
        If chkColoAnesthegiste.Checked = True Then
            Me.cboColoAnesthegiste.Enabled = True
        Else
            Me.cboColoAnesthegiste.Enabled = False
        End If
    End Sub

    Private Sub BtnAddConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddConclusion.Click
        If DA_ColoConclusion.SelectConclusion(CInt(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value), CInt(Me.cboColoConclusion.SelectedValue)).Rows.Count > 0 Then
            MsgBox("The conclusion was added already", MsgBoxStyle.OkOnly, "Existing Conclusion")
        Else
            DA_ColoConclusion.Insert(CInt(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value), CInt(Me.cboColoConclusion.SelectedValue))
            RefreshConclusionList()
            cboColoConclusion.SelectedIndex = -1
        End If
    End Sub

    Private Sub BtnRemoveConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveConclusion.Click
        If Me.ConclusionList.RowCount >= 1 Then
            DA_ColoConclusion.DeleteConclusion(CInt(Me.ConclusionList.CurrentRow.Cells("request_id").Value), CInt(Me.ConclusionList.CurrentRow.Cells("conclusion_id").Value))
            RefreshConclusionList()
        End If
    End Sub
    Sub RefreshConclusionList()
        Me.ConclusionList.DataSource = DA_ColoConclusion.SelectConclusionByRequestID(CInt(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value))
    End Sub

  
    Function GetValueConclustion() As String
        Dim ConValue As String = ""
        For i As Integer = 0 To conclusionlist.RowCount - 1
            ConValue = ConValue & "" & ConclusionList.GetRow(i).Cells("Conclusion").Value & ", "
        Next
        Return ConValue
    End Function

   

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateCombobox(cboColoDemander, "", ErrAlert) = False Then Exit Sub
        If ValidateCombobox(cboColoPreparation, "", ErrAlert) = False Then Exit Sub
        If ValidateCombobox(cboColoDocteur, "", ErrAlert) = False Then Exit Sub
        Dim ColoAnes As String = ""
        If Me.chkColoAnesthegiste.Checked = True Then
            If ValidateCombobox(cboColoAnesthegiste, "", ErrAlert) = False Then Exit Sub
            ColoAnes = Me.cboColoAnesthegiste.SelectedValue
        End If

        If DA_Colo.SelectColoByRequestID(CLng(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
            Dim RequestIDVal As Double = CLng(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value)
            If MessageBox.Show("Do you want to update colo result?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If (DA_Colo.UpdateColoEnglish(RequestIDVal, txtColoDuree.Text, txtColoEva.Text, cboColoPreparation.SelectedValue.ToString, _
                  cboColoDemander.SelectedValue.ToString, txtColoTolerance.Text, chkColoAnesthegiste.Checked, ColoAnes, cboColoDocteur.Text, _
                  DateResultExam.Value.Date, GetValueConclustion, TxtIntroduction.Text, TxtIndication.Text, txtFentanyL.Text, _
                  TxtPropofol.Text, TxtXylocainegel.Text, TxtRecalExam.Text, TxtFinding.Text, TxtImpression.Text, CInt(cboColoDocteur.SelectedValue), txtcolomoreinfo.Text, TxtProcedure.Text, RequestIDVal)) = 1 Then
                    MsgBox("The coloscopy has been saved successfully", MsgBoxStyle.OkOnly, "Saved Coloscopy")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If

        Else
            '' Add New
            If MessageBox.Show("Do you want to insert new Colo?", "Insert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim RequestIDVal As Double = (Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value)
                Dim PatientVal As Double = CLng(Me.RequestPanel.RequestList.CurrentRow.Cells("ppatientid").Value)
                If DA_Colo.InsertEnglishReport(RequestIDVal, PatientVal, Me.txtColoDuree.Text, txtColoEva.Text, cboColoPreparation.SelectedValue.ToString, _
                                                cboColoDemander.SelectedValue.ToString, txtColoTolerance.Text, chkColoAnesthegiste.Checked, ColoAnes, _
                                                DateResultExam.Value.Date, TxtIntroduction.Text, TxtIndication.Text, txtFentanyL.Text, TxtPropofol.Text, TxtXylocainegel.Text, TxtRecalExam.Text, TxtFinding.Text, TxtImpression.Text, GetValueConclustion, CInt(cboColoDocteur.SelectedValue), cboColoDocteur.Text, txtcolomoreinfo.Text, TxtProcedure.Text) = 1 Then
                    MsgBox("A coloscopy has been saved successfully", MsgBoxStyle.OkOnly, "Saved Coloscopy")
                    DA_DOCTOR_FEE.InsertNewDoctorFee(CInt(cboColoDocteur.SelectedValue), cboColoDocteur.Text, "Coloscopy", DateResultExam.Value.Date, LblPatientNo.Text, 0, lblPatientName.Text, GetValueConclustion)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End If


        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        If DA_Colo.SelectColoByRequestID(CLng(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value)).Rows.Count <= 0 Then
            DA_ColoConclusion.DeleteConclusionByRequestID(CLng(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value))
        End If
        Me.Close()
    End Sub
End Class