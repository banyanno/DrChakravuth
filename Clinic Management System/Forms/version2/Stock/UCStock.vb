Public Class UCStock
    Dim DA_Store As New DSStoreTableAdapters.tblmedicinestoreTableAdapter
    Private Sub UCStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshStore()
    End Sub

    Sub RefreshStore()
        Me.StoreList.DataSource = DA_Store.SelectAllStore
    End Sub
    Sub FilByName(ByVal Name As String)
        Me.StoreList.DataSource = DA_Store.SelectByMedicinceName(Name)
    End Sub
    Private Sub BtnIssue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIssue.Click
        Dim FrmIssue As New Issue(Me)
        FrmIssue.ShowDialog()
    End Sub

    Private Sub BtnAdjustment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdjustment.Click
        If StoreList.RowCount >= 1 Then
            Dim FrmAdjustment As New Adjustment(Me)
            FrmAdjustment.txtmedicine.Text = StoreList.CurrentRow.Cells("medicinename").Value
            FrmAdjustment.txtunit.Text = StoreList.CurrentRow.Cells("unitname").Value
            FrmAdjustment.txtunittype.Text = StoreList.CurrentRow.Cells("unittype").Value
            FrmAdjustment.txtratioqty.Text = StoreList.CurrentRow.Cells("ratioqty").Value
            FrmAdjustment.txtcurrentqty.Text = StoreList.CurrentRow.Cells("qty").Value
            FrmAdjustment.txtadjustedqty.Focus()
            FrmAdjustment.ShowDialog()
        End If
    End Sub

    Private Sub BtnReceive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReceive.Click
        Dim FrmReceive As New Receive(Me)
        FrmReceive.ShowDialog()
    End Sub

    Private Sub BtnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTransfer.Click
        Dim FrmTransfer As New Transfer(Me)
        FrmTransfer.ShowDialog()
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        RefreshStore()
    End Sub

   
End Class
