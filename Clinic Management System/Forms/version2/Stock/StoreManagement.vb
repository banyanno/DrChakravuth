Public Class StoreManagement
    Dim DA_Store As New DSStoreTableAdapters.tblmedicinestoreTableAdapter
    Sub RefreshStore()
        Me.StoreList.DataSource = DA_Store.SelectAllStore
    End Sub
    Sub FilByMedicineName(ByVal Name As String)
        Me.StoreList.DataSource = DA_Store.SelectByMedicinceName(Name)
    End Sub
    Private Sub StoreManagement_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RefreshStore()
    End Sub

    Private Sub BtnNewStore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewStore.Click
        Dim FrmNewStore As New NewStore(Me)
        FrmNewStore.ShowDialog()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If Me.StoreList.RowCount >= 1 Then
            If MsgBox("Are you sure you want to delete this store?", MsgBoxStyle.YesNo, "Confirm Deletion") = MsgBoxResult.Yes Then
                If DA_Store.DeleteStore(CInt(Me.StoreList.CurrentRow.Cells("store_id").Value)) = 1 Then
                    FilByMedicineName(Me.StoreList.CurrentRow.Cells("medicinename").Value)
                    MsgBox("One store has been deleted", MsgBoxStyle.Information, "Store Deleted")
                Else
                    Me.RefreshStore()
                End If
              
            End If
        End If
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        If Me.StoreList.RowCount >= 1 Then
            Dim FrmUpdate As New UpdateStore(Me)
            FrmUpdate.txtmedicine.Text = Me.StoreList.CurrentRow.Cells("medicinename").Value
            FrmUpdate.txtmedicine.Enabled = False
            FrmUpdate.cbounit.Text = Me.StoreList.CurrentRow.Cells("unitname").Value
            FrmUpdate.cbounit.Enabled = False
            FrmUpdate.cbounittype.Text = Me.StoreList.CurrentRow.Cells("unittype").Value
            FrmUpdate.cbounittype.Enabled = False
            FrmUpdate.txtratioqty.Text = Me.StoreList.CurrentRow.Cells("ratioqty").Value
            FrmUpdate.txtlastcost.Text = Me.StoreList.CurrentRow.Cells("last_cost").Value
            FrmUpdate.txtlastprice.Text = Me.StoreList.CurrentRow.Cells("last_price").Value
            If FrmUpdate.ShowDialog() = DialogResult.OK Then
                FilByMedicineName(Me.StoreList.GetRow.Cells("medicinename").Value)
            End If
        End If
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        RefreshStore()
    End Sub

    Private Sub BtnColspan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnColspan.Click
       
        Me.StoreList.ExpandableCards = False
    End Sub
End Class
