Public Class UCMedical
    Dim DA_History As New DSPAtientTableAdapters.tblhistoryTableAdapter

    Sub RefreshData()
        Me.HistoryList.DataSource = DA_History.SelectHistory
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Are you sure you want to delete this medical history?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DA_History.DeleteHistory(Me.HistoryList.CurrentRow.Cells("Historyid").Value)
            RefreshData()
        End If
    End Sub

    Private Sub UCMedical_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RefreshData()
    End Sub
End Class
