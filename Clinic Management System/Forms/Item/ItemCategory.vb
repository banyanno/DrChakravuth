Public Class ItemCategory
    Dim DA_ItemCategory As New DSPAtientTableAdapters.Medicine_CategoriesTableAdapter
    Dim PMedicineCat As MedicineCategory
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal PMedicineCat As MedicineCategory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.PMedicineCat = PMedicineCat
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(txtname, "", Err) = False Then Exit Sub
        Dim Cat_Name As String = Me.txtname.Text.Trim.Replace("'", "''")
        Dim CategoryTable As New DataTable
        CategoryTable = DA_ItemCategory.SelectCategoryByName(Cat_Name)
        If lblaction.Text = 0 Then
            '' Check If Existing Name While Adding
            If (CategoryTable.Rows.Count > 0) Then
                MsgBox("This category name already exists", MsgBoxStyle.Exclamation, "Duplicate Data")
                Me.txtname.SelectAll()
                Me.txtname.Focus()
            Else
                DA_ItemCategory.InsertCategory(Cat_Name)
                MsgBox("One category was added", MsgBoxStyle.Information, "Successfully added")
                Me.txtname.Text = ""
                Me.txtname.Focus()
                PMedicineCat.RefreshData()
            End If
        Else
            Dim CatID As String = Me.PMedicineCat.CategoryList.CurrentRow.Cells("Category_ID").Value
            '' Check If Existing Name While Updating
            If CategoryTable.Rows.Count > 0 Then
                If CatID <> CategoryTable.Rows(0).Item("Category_ID") Then
                    MsgBox("This category name already exists", MsgBoxStyle.Exclamation, "Duplicate Data")
                    Me.txtname.SelectAll()
                    Me.txtname.Focus()
                Else
                    Me.Close()
                End If
            Else
                If MsgBox("Are you sure you want to update this category?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    DA_ItemCategory.UpdateCategory(Cat_Name, CatID)
                    MsgBox("The category was updated", MsgBoxStyle.Information, "Successfully updated")
                    PMedicineCat.RefreshData()
                    Me.Close()
                End If
            End If
        End If

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class