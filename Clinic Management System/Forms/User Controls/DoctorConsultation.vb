Public Class DoctorConsultation
    Dim DA_Consultation As New DSPAtientTableAdapters.ConsultationsTableAdapter
    Dim DA_Symptom As New DSPAtientTableAdapters.Patient_SymptomsTableAdapter
    Dim DA_SymptomDetail As New DSPAtientTableAdapters.Patient_Symptom_DetailsTableAdapter
    Private Sub DoctorConsultation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridWaitingConsultation.DataSource = DA_Consultation.GetConsultationList
    End Sub
    Private Sub ConsultationList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        ''RowChanged()
    End Sub

    Private Sub StomachConsultList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        ''ViewStomachConsultation.txtPConsultNo.Text = StomachConsultList.CurrentRow.Cells("PConsult_No").Value
        ''ViewStomachConsultation.txtPatientID.Text = ConsultationList.CurrentRow.Cells("Patient_ID").Value
        ''ViewStomachConsultation.ShowDialog()

        'Dim FView As New ViewStomachConsultation(Me)
        'FView.txtPConsultNo.Text = StomachConsultList.CurrentRow.Cells(0).Value
        'FView.txtPatientID.Text = GridWaitingConsultation.GetRow.Cells("Patient_ID").Value
        'FView.ShowDialog()
    End Sub

    Private Sub LiverConsultList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        '' ViewLiverConsultation.txtPConsultNo.Text = LiverConsultList.CurrentRow.Cells(0).Value
        '' ViewLiverConsultation.txtPatientID.Text = ConsultationList.CurrentRow.Cells("Patient_ID").Value
        '' ViewLiverConsultation.ShowDialog()

        'Dim FView As New ViewLiverConsultation(Me)
        'FView.txtPConsultNo.Text = LiverConsultList.CurrentRow.Cells(0).Value
        'FView.txtPatientID.Text = GridWaitingConsultation.GetRow.Cells("Patient_ID").Value
        'FView.ShowDialog()
    End Sub

    Private Sub FinalList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        '' ViewFinalConsultation.txtPConsultNo.Text = FinalList.CurrentRow.Cells(0).Value
        ''ViewFinalConsultation.txtPatientID.Text = ConsultationList.CurrentRow.Cells("Patient_ID").Value
        'Dim FView As New ViewFinalConsultation(Me)
        'FView.txtPConsultNo.Text = FinalList.CurrentRow.Cells(0).Value
        'FView.txtPatientID.Text = GridWaitingConsultation.GetRow.Cells("Patient_ID").Value
        'FView.ShowDialog()
        ''ViewFinalConsultation.ShowDialog()
    End Sub


    Private Sub BloodCheckList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Try
            'Dim FrmCheck As New ViewBloodCheck(Me)
            'FrmCheck.txtCheckNo.Text = BloodCheckList.CurrentRow.Cells("Check_No").Value
            'FrmCheck.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnBloodCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BloodCheck.txtPatientID.Text = GridWaitingConsultation.GetRow.Cells("Patient_ID").Value
        BloodCheck.ShowDialog()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (MsgBox("Are you sure you want to delete this consultation?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            DA_Consultation.UpdateConsultation(GridWaitingConsultation.GetRow.Cells(0).Value)
            GridWaitingConsultation.DataSource = DA_Consultation.GetConsultationList
        End If
    End Sub

    Private Sub ConsultationList_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ''RowChanged()
    End Sub

    Private Sub BtnAppointment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHistory.Click
        Dim AppForm As New NewAppointment
        'AppForm.txtid.Text = GridWaitingConsultation.CurrentRow.Cells("Patient_ID").Value
        AppForm.ShowDialog()
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub menuStomach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim StomachForm As New NewStomachConsultation
        StomachForm.txtPatientID.Text = GridWaitingConsultation.CurrentRow.Cells("Patient_ID").Value
        StomachForm.ShowDialog()
    End Sub

    Private Sub menuLiver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim LiverForm As New NewLiverConsultation
        LiverForm.txtPatientID.Text = GridWaitingConsultation.CurrentRow.Cells("Patient_ID").Value
        LiverForm.ShowDialog()
    End Sub

    Private Sub menuFinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FinalForm As New NewFinalConsultation
        FinalForm.txtPatientID.Text = GridWaitingConsultation.CurrentRow.Cells("Patient_ID").Value
        FinalForm.ShowDialog()
    End Sub

    Private Sub menuBlood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim BloodForm As New BloodCheck
        BloodForm.txtPatientID.Text = GridWaitingConsultation.CurrentRow.Cells("Patient_ID").Value
        BloodForm.ShowDialog()
    End Sub
    Private Sub cbodate_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbodate.SelectionChangeCommitted
        GridEXSymptom.DataSource = DA_SymptomDetail.GetDataBySymptomNo(Me.cbodate.SelectedValue)
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        GridWaitingConsultation.DataSource = DA_Consultation.GetConsultationList
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        Dim PTable As New DataTable
        If Me.txtPatientNo.Text.Trim <> "" Then
            If IsNumeric(Me.txtPatientNo.Text) = False Then
                MsgBox("Patient ID must be number only", MsgBoxStyle.Exclamation, "Invalid Data")
                Me.txtPatientNo.SelectAll()
                Me.txtPatientNo.Focus()
                Exit Sub
            End If
            PTable = DA_Consultation.GetFirstPatientRecord(Me.txtPatientNo.Text)
            If PTable.Rows.Count = 1 Then
                Me.GridWaitingConsultation.DataSource = PTable
            Else
                MsgBox("No record was found, please try again", MsgBoxStyle.Exclamation)
                Me.txtPatientNo.SelectAll()
                Me.txtPatientNo.Focus()
            End If
        End If
    End Sub
    Private IsSymptom As Boolean = False
    Private IsConsultation As Boolean = False

   

    Private Sub BtnConsultation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultationService.Click
        If IsConsultation = False Then
            SplitConsultationService.Panel2Collapsed = False
            BtnConsultationService.Image = Global.Clinic_Management_System.My.Resources._1342235074_navigation_down_button_blue
            IsConsultation = True
        Else
            SplitConsultationService.Panel2Collapsed = True
            BtnConsultationService.Image = Global.Clinic_Management_System.My.Resources.Navigation_up
            IsConsultation = False
        End If
    End Sub

    Private Sub btnPrescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrescription.Click
        'Dim FrmHistory As New PrescriptionHistory(Me)
        'FrmHistory.lblpatientId.Text = Me.GridWaitingConsultation.CurrentRow.Cells("Patient_ID").Value
        'FrmHistory.ShowDialog()
    End Sub


    Private Sub GridWaitingConsultation_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridWaitingConsultation.FormattingRow

    End Sub

    Private Sub BloodCheckList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub BtnNewPrescription_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs)
        Dim NewPrescription As New NewPrescription
        NewPrescription.ShowDialog()
    End Sub

    Private Sub BtnAddNewPrescription_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs)
        Dim NPrescription As New NewPrescription(Me)
        NPrescription.lblpatientId.Text = Me.GridWaitingConsultation.CurrentRow.Cells("Patient_ID").Value
        NPrescription.ShowDialog()
    End Sub

    
   
    Private Sub cbodate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbodate.SelectedIndexChanged

    End Sub
End Class
