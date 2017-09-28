Public Class UCPateintComplaint
    Dim DA_Complaint As New DSPAtientTableAdapters.tblcomplaintTableAdapter
    Private Sub ConsultTypeList_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles ComplaintList.FormattingRow

    End Sub
    Sub RefreshData()
        Me.ComplaintList.DataSource = DA_Complaint.SelectComplaints
    End Sub

    Private Sub UCPateintComplaint_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RefreshData()
    End Sub

    Private Sub BtnNewConsultation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewConsultation.Click
        'Dim ComplaintForm As New NewPatientComplaint(Me)
        'ComplaintForm.LblSaveOption.Text = 0
        'ComplaintForm.ShowDialog()
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        'Dim ComplaintForm As New NewPatientComplaint(Me)
        'ComplaintForm.LblSaveOption.Text = 1
        'ComplaintForm.TxtComplaintName.Text = Me.ComplaintList.CurrentRow.Cells("complaint").Value
        'ComplaintForm.ShowDialog()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Are you sure you want to delete this patient complaint?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DA_Complaint.DeleteComplaint(Me.ComplaintList.CurrentRow.Cells("complaintid").Value)
            RefreshData()
        End If
    End Sub
End Class
