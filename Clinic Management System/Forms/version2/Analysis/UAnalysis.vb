Public Class UAnalysis

    Private Sub BtnAnalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnalysis.Click
        Dim FAnalysis As New FormDataAnalysis(Me)
        FAnalysis.Show()
    End Sub
  
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub
End Class
