Public Class FrmFindParaHistory
    Dim DA_ExamHistory As New DSExaminationTableAdapters.tblrequestTableAdapter

   
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        Dim tblExamHistory As DataTable = DA_ExamHistory.GetDataByParaOutSite(EmptyString(TxtPatientNo.Text))
        GridParaExam.DataSource = tblExamHistory
    End Sub

    Private Sub BtnParaExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnParaExam.Click
        If GridParaExam.SelectedItems.Count = 0 Then Exit Sub
        Dim FParaExamHistory As New FormParaExamHistory
        FParaExamHistory.LblRequestID.Text = Me.GridParaExam.GetRow.Cells("request_id").Value
        FParaExamHistory.GetRefreshBloodCheckItem(Me.GridParaExam.GetRow.Cells("request_id").Value)
        FParaExamHistory.GetFibroConclusion(Me.GridParaExam.GetRow.Cells("request_id").Value)
        FParaExamHistory.GetNasoConclustion(Me.GridParaExam.GetRow.Cells("request_id").Value)
        FParaExamHistory.GetColoConclusion(Me.GridParaExam.GetRow.Cells("request_id").Value)
        FParaExamHistory.GetConclustionEcho(Me.GridParaExam.GetRow.Cells("request_id").Value)
        FParaExamHistory.GetScan(Me.GridParaExam.GetRow.Cells("request_id").Value)
        FParaExamHistory.GetMRI(Me.GridParaExam.GetRow.Cells("request_id").Value)
        FParaExamHistory.GetFibroScan(Me.GridParaExam.GetRow.Cells("request_id").Value)
        FParaExamHistory.GetCFAnapath(Me.GridParaExam.GetRow.Cells("request_id").Value)
        FParaExamHistory.ShowDialog()
    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class