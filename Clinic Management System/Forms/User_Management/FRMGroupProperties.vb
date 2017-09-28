Public Class FRMGroupProperties
    Dim DA_UPermistion As New DSUserManagermentTableAdapters.USER_PERMISTION_MENUTableAdapter
    Dim DA_Menu As New DSUserManagermentTableAdapters.USER_MENUSTableAdapter
    Dim DA_GPermistion As New DSUserManagermentTableAdapters.V_USER_PERMISTIONTableAdapter

    Private Sub FRMGroupProperties_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showdata()
    End Sub
    Sub showdata()
        Dim i As Int16, j As Int16
        'SQL = "SELECT MENUDISPLAY from MENU_INVENTORY order by MENUDISPLAY"
        ShowCheckListBoxPermistionCh1(Ch1)
        'SQL = "SELECT MenuDisplay FROM Menu_INVENTORY,Deppartment_Permistion_Menu,tblDepartment WHERE Menu_INVENTORY.MenuKey=Deppartment_Permistion_Menu.MenuNo AND tblDepartment.DepartName='" & TxtGroupName.Text.Replace("'", "''") & _
        '      "' AND tblDepartment.DepartID = Deppartment_Permistion_Menu.GroupNo "
        ShowCheckListBoxPermistionCh2(Ch2)
        For i = 0 To Ch2.Items.Count - 1
            For j = 0 To Ch1.Items.Count - 1
                If Ch1.Items(j) = Ch2.Items(i) Then
                    Ch1.Items.RemoveAt(j)
                    GoTo bb
                End If
            Next
bb:
        Next
    End Sub
    Sub ShowCheckListBoxPermistionCh1(ByRef Lst As CheckedListBox)
        Dim Tbl As DataTable, i As Int32
        Tbl = DA_Menu.GetDataByMenuDisplay
        Lst.Items.Clear()
        With Lst
            For i = 0 To Tbl.Rows.Count - 1
                .Items.Add(Tbl.Rows(i).Item("MenuDisplay"))
            Next
        End With
    End Sub
    Sub ShowCheckListBoxPermistionCh2(ByRef Lst As CheckedListBox)
        Dim Tbl As DataTable, i As Int32
        Tbl = DA_GPermistion.GetDataByGroupName(TxtGroupName.Text.Trim)
        Lst.Items.Clear()
        With Lst
            For i = 0 To Tbl.Rows.Count - 1
                .Items.Add(Tbl.Rows(i).Item("MenuDisplay"))
            Next
        End With
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim i As Int32, GroupNo As String, MenuNo As String
        If TxtGroupName.Text <> "" Then
            If MessageBox.Show("Do you want save permistion?", "Permistion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                GroupNo = LblGroupID.Text
                DA_UPermistion.DeleteGroupMenu(GroupNo)
                Dim tblMenuKey As DataTable
                For i = 0 To Ch2.Items.Count - 1
                    tblMenuKey = DA_Menu.SelectMenuNo(Ch2.Items.Item(i))
                    For Each DRows As DataRow In tblMenuKey.Rows
                        MenuNo = DRows("MenuKey")
                        DA_UPermistion.InsertGroupPermistion(GroupNo, MenuNo)
                    Next
                Next
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
            

            'MsgBox("Set permistion successfully!", MsgBoxStyle.Information, "Save")
            'Me.Close()
        Else
            MsgBox("Please select group name!", MsgBoxStyle.Question)
        End If
    End Sub

    Private Sub btnMove1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove1.Click
        While Ch1.CheckedItems.Count > 0
            Ch2.Items.Add(Ch1.CheckedItems(0))
            Ch1.Items.Remove(Ch1.CheckedItems(0))
        End While
    End Sub

    Private Sub btnMove2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove2.Click
        While Ch2.CheckedItems.Count > 0
            Ch1.Items.Add(Ch2.CheckedItems(0))
            Ch2.Items.Remove(Ch2.CheckedItems(0))
        End While
    End Sub
End Class