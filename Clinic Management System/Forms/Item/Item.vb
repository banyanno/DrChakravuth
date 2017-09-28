Public Class Item
    Dim DA_Item As New DSPAtientTableAdapters.MedicinesTableAdapter
    Dim DA_ItemCat As New DSPAtientTableAdapters.Medicine_CategoriesTableAdapter
    Dim PMedicine As Medicine
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal PMedicine As Medicine)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.PMedicine = PMedicine
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub ClearData()
        Me.txtname.Text = ""
        Me.txtprice.Text = ""
        Me.txtname.Focus()
    End Sub
    Private Sub Item_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim CategoryTable As New DataTable
        CategoryTable = DA_ItemCat.SelectCategory
        Me.cbotype.DataSource = CategoryTable
        Me.cbotype.DisplayMember = CategoryTable.Columns("Category_Name").ColumnName
        Me.cbotype.ValueMember = CategoryTable.Columns("Category_ID").ColumnName

        If Me.lblaction.Text = 1 Then
            ''Load Data to be edited

            Me.txtname.Text = PMedicine.MedicineList.CurrentRow.Cells("Medicine_Name").Value
            Me.cbotype.SelectedValue = PMedicine.MedicineList.CurrentRow.Cells("Category_ID").Value
            Me.txtprice.Text = PMedicine.MedicineList.CurrentRow.Cells("Price").Value




        End If


    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(txtname, "", ErrValidate) = False Then Exit Sub
        If ValidateCombobox(cbotype, "", ErrValidate) = False Then Exit Sub
        If ValidateTextField(txtprice, "", ErrValidate) = False Then Exit Sub
        Dim Item_Name As String = Me.txtname.Text.Trim.Replace("'", "''")
        If IsNumeric(Me.txtprice.Text) = False Then
            MsgBox("Please enter price as number only", MsgBoxStyle.Exclamation, "Invalid Value")
            Me.txtprice.SelectAll()
            Me.txtprice.Focus()
            Exit Sub
        End If
        Dim ItemTable As New DataTable
        ItemTable = DA_Item.SelectByMedicineName(Item_Name)
        If lblaction.Text = 0 Then
            '' Check If Existing Name While Adding
            If (ItemTable.Rows.Count > 0) Then
                MsgBox("This medicine name already exists", MsgBoxStyle.Exclamation, "Duplicate Data")
                Me.txtname.SelectAll()
                Me.txtname.Focus()
            Else
                DA_Item.InsertMedicine(Me.cbotype.SelectedValue, Item_Name, Me.txtprice.Text)
                MsgBox("One medicine was added", MsgBoxStyle.Information, "Successfully added")
                ClearData()
                PMedicine.RefreshData()
            End If
        Else
            Dim ItemID As String = Me.PMedicine.MedicineList.CurrentRow.Cells("Medicine_ID").Value
            '' Check If Existing Name While Updating
            If ItemTable.Rows.Count > 0 Then
                If ItemID <> ItemTable.Rows(0).Item("Medicine_ID") Then
                    MsgBox("This medicine name already exists", MsgBoxStyle.Exclamation, "Duplicate Data")
                    Me.txtname.SelectAll()
                    Me.txtname.Focus()
                Else
                    If MsgBox("Are you sure you want to update this medicine?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        DA_Item.UpdateMedicine(Me.cbotype.SelectedValue, Me.txtname.Text, Me.txtprice.Text, ItemID)
                        MsgBox("The category was updated", MsgBoxStyle.Information, "Successfully updated")
                        PMedicine.RefreshData()
                        Me.Close()
                    End If
                End If
            Else
                If MsgBox("Are you sure you want to update this medicine?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    DA_Item.UpdateMedicine(Me.cbotype.SelectedValue, Me.txtname.Text, Me.txtprice.Text, ItemID)
                    MsgBox("The category was updated", MsgBoxStyle.Information, "Successfully updated")
                    PMedicine.RefreshData()
                    Me.Close()
                End If
            End If
        End If
    End Sub
End Class