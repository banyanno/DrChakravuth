Public Class UAnalysis

    Private Sub BtnAnalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnalysis.Click
        Dim FAnalysis As New FormDataAnalysis(Me)
        FAnalysis.Show()
    End Sub
  
End Class
