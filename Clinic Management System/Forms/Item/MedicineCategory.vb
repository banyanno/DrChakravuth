Public Class MedicineCategory
    Dim DA_Category As New DSPAtientTableAdapters.Medicine_CategoriesTableAdapter
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim ItemCat As New ItemCategory(Me)
        ItemCat.lblaction.Text = 0
        ItemCat.ShowDialog()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Dim ItemCat As New ItemCategory(Me)
        ItemCat.txtname.Text = Me.CategoryList.CurrentRow.Cells("Category_Name").Value
        ItemCat.lblaction.Text = 1
        ItemCat.ShowDialog()
    End Sub
    Sub RefreshData()
        Me.CategoryList.DataSource = DA_Category.SelectCategory
    End Sub
    Private Sub MedicineCategory_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RefreshData()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Are you sure you want to delete this category", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DA_Category.DeleteCategory(Me.CategoryList.CurrentRow.Cells("Category_ID").Value)
            RefreshData()
        End If
    End Sub
End Class
