Imports Janus.Windows.GridEX

Public Class UCDepartment
    Dim DA_Department As New DSUserManagermentTableAdapters.USER_OF_DEPARTMENTTableAdapter
    Dim DA_Menu As New DSUserManagermentTableAdapters.USER_MENUSTableAdapter
    Dim DA_USystem As New DSUserManagermentTableAdapters.USERS_SYSTEMTableAdapter
    Dim DA_GPermision As New DSUserManagermentTableAdapters.V_USER_PERMISTIONTableAdapter
    '' User Management user
    Public Sub InitDepartment()
        Dim TblDepTem As DataTable = DA_Department.GetData
        Dim Index1 As Integer
        Dim DRow1 As DataRow
        Dim LVITem As ListViewItem
        LsDepartment.Items.Clear()
        If TblDepTem Is Nothing Then
            Exit Sub
        End If
        For Index1 = 0 To TblDepTem.Rows.Count - 1
            DRow1 = TblDepTem.Rows(Index1)
            LVITem = LsDepartment.Items.Add(DRow1(1).ToString)
            LVITem.ImageIndex = 0
            'LsDepartment.Items(Index1).SubItems.Add(DRow1(0).ToString)
            LVITem.SubItems.Add(DRow1(0).ToString)
        Next
        Me.LsDepartment.Items(0).Selected = True
    End Sub
    Public Sub InitMenu()
        Dim TblMenu As DataTable = DA_Menu.GetData
        Dim DRow As DataRow
        Dim LVItem As ListViewItem
        LsPermistion.Items.Clear()
        If TblMenu Is Nothing Then
            Exit Sub
        End If
        For index As Integer = 0 To TblMenu.Rows.Count - 1
            DRow = TblMenu.Rows(index)
            LVItem = LsPermistion.Items.Add(DRow("MenuDisplay").ToString)
            LVItem.ImageIndex = 1
            LVItem.SubItems.Add(DRow("MenuNo").ToString).Tag = DRow("MenuNo")
            LVItem.Tag = DRow("MenuNo")
        Next
        Try
            LsPermistion.Items(0).Selected = True
        Catch ex As Exception

        End Try

    End Sub
    Public Sub LoadPermissionByGroup(ByVal GID As Integer)
        Dim TblPermission As DataTable = DA_GPermision.GetDataByGroupNo(GID)
        Dim DRow As DataRow
        Dim LVItem As ListViewItem
        LsPermistion.Items.Clear()
        If TblPermission Is Nothing Then
            Exit Sub
        End If
        For index As Integer = 0 To TblPermission.Rows.Count - 1
            DRow = TblPermission.Rows(index)
            LVItem = LsPermistion.Items.Add(DRow("MenuDisplay").ToString)
            LVItem.ImageIndex = 1
            LVItem.SubItems.Add(DRow("MenuNo").ToString).Tag = DRow("MenuNo")
            LVItem.Tag = DRow("MenuNo")
        Next
        Try
            LsPermistion.Items(0).Selected = True
        Catch ex As Exception

        End Try
    End Sub
    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Dim FDep As New frmDepartment()
        If FDep.ShowDialog() = DialogResult.OK Then
            InitDepartment()
        End If
        
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        InitDepartment()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If LsDepartment.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select department name to edit.", "Edit", MessageBoxButtons.OK)
        Else
            Dim FDep As New frmDepartment()
            FDep.lblSaveOption.Text = LsDepartment.SelectedItems(0).SubItems(1).Text ' "1"
            FDep.departID = LsDepartment.SelectedItems(0).SubItems(1).Text
            FDep.txtDepartName.Text = LsDepartment.SelectedItems(0).Text
            FDep.ShowDialog()
            'If FDep.ShowDialog() = DialogResult.OK Then
            '    InitDepartment()
            'End If
            FDep.Close()
            FDep.Dispose()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim FrmNewMenu As New FormNewMenuInventory
        If FrmNewMenu.ShowDialog = DialogResult.OK Then
            InitMenu()
        End If
        FrmNewMenu.Dispose()
        FrmNewMenu.Close()
    End Sub

    Private Sub BtnViewAllPermission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewAllPermission.Click
        InitMenu()
    End Sub

    Private Sub BtnMenuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMenuEdit.Click
        If LsPermistion.SelectedItems.Count = 0 Then
            MsgBox("Please selected permission to edit.", MsgBoxStyle.Information, "Info")
        Else


            Dim NewMenu As New FormNewMenuInventory
            'NewMenu.LblSaveOption.Text = LsPermistion.SelectedItems(0).Tag
            NewMenu.LblSaveOption.Text = LsPermistion.SelectedItems(0).SubItems(1).Tag
            NewMenu.TxtMenuDisplay.Text = LsPermistion.SelectedItems(0).Text
            'NewMenu.TxtMenuKey.Text = LsPermistion.SelectedItems(0).SubItems(1).Tag

            If NewMenu.ShowDialog = DialogResult.OK Then
                Try
                    LoadPermissionByGroup(LsDepartment.SelectedItems(0).SubItems(1).Text)
                Catch ex As Exception

                End Try

            End If
        End If
    End Sub

    Private Sub BtnNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewUser.Click

        

        Dim FrmNewUser As New FRMNewUser
        If FrmNewUser.ShowDialog = DialogResult.OK Then
            'LoadUserByGroup(LsDepartment.SelectedItems(0).Tag)
        End If
        FrmNewUser.Dispose()
        FrmNewUser.Close()
    End Sub

    Private Sub LsDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LsDepartment.SelectedIndexChanged
        If LsDepartment.SelectedItems.Count = 0 Then
            LsUser.Items.Clear()
            LsPermistion.Items.Clear()
        Else
            Dim GroupID As String = LsDepartment.SelectedItems(0).SubItems(1).Text
            LoadUserByGroup(GroupID)
            LoadPermissionByGroup(GroupID)
        End If
    End Sub
    Public Sub LoadUserByGroup(ByVal GID As Integer)

        Dim TblUser As DataTable = DA_USystem.GetDataByDepartmentID(GID) ' UserDataAdapter.GetDataUserByGroup(GID)
        Dim DRow As DataRow
        Dim LVItem As ListViewItem
        LsPermistion.Items.Clear()
        If TblUser Is Nothing Then
            Exit Sub
        End If
        LsUser.Items.Clear()
        For index As Integer = 0 To TblUser.Rows.Count - 1
            DRow = TblUser.Rows(index)
            LVItem = LsUser.Items.Add(DRow("UserName").ToString)
            LVItem.ImageIndex = 2
            ' LsUser.Items(index).SubItems.Add(DRow("UserID").ToString)
            LVItem.SubItems.Add(DRow("UserID").ToString)
        Next
    End Sub

    Private Sub BtnChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChangePassword.Click
        If LsUser.SelectedItems.Count = 0 Then
            MsgBox("Please select user to change password.", MsgBoxStyle.Information)
        Else
            Dim FChangePwd As New FrmChangeUserPWD
            FChangePwd.LblUserID.Text = LsUser.SelectedItems(0).SubItems(1).Text
            FChangePwd.TxtUserName.Text = LsUser.SelectedItems(0).Text
            FChangePwd.ShowDialog()
        End If
    End Sub

    Private Sub BtnEditUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditUser.Click

        If LsUser.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select user to edit.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim FrmNewUser As New FRMNewUser
            FrmNewUser.LblSaveOption.Text = LsUser.SelectedItems(0).SubItems(1).Text
            Dim TblUserTem As DataTable = DA_USystem.GetDataByUserID(FrmNewUser.LblSaveOption.Text)
            For Each row In TblUserTem.Rows
                FrmNewUser.TxtLoginName.Text = row("EmployeeName")
                FrmNewUser.TxtUserName.Text = row("UserName")
                FrmNewUser.TxtPwd.Text = row("NewPassword")
                FrmNewUser.TxtVerifyPwd.Text = row("NewPassword")
                FrmNewUser.CboDepartment.DropDownStyle = ComboBoxStyle.DropDown
                FrmNewUser.CboDepartment.SelectedValue = row("GroupNo")
                If TypeOf row("Is_Doctor") Is DBNull Then
                Else
                    FrmNewUser.chIsDoctor.Checked = row("Is_Doctor")
                End If
                If TypeOf row("ShowName") Is DBNull Then
                Else
                    FrmNewUser.txtDoctorname.Text = row("ShowName")
                End If
                If TypeOf row("PhoneNumber") Is DBNull Then
                Else
                    FrmNewUser.txtphone.Text = row("PhoneNumber")
                End If
                If TypeOf row("Other") Is DBNull Then
                Else
                    FrmNewUser.txtdesc.Text = row("Other")
                End If

                If TypeOf row("Signe") Is DBNull Then

                Else
                    FrmNewUser.PictDoctorSigne.Image = New Bitmap(New System.IO.MemoryStream(DirectCast(row("Signe"), Byte())))
                End If

            Next
            FrmNewUser.TxtPwd.ReadOnly = True
            FrmNewUser.TxtVerifyPwd.ReadOnly = True
            If FrmNewUser.ShowDialog = DialogResult.OK Then
                LoadUserByGroup(LsDepartment.SelectedItems(0).SubItems(1).Text)
            End If
            FrmNewUser.Dispose()
            FrmNewUser.Close()
        End If
    End Sub

    Private Sub BtnPermission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPermission.Click
        Try
            'If LsDepartment.SelectedItems(0).SubItems(0).Text = "Administrator" Then
            '    MsgBox("You can't look properties of this department.", MsgBoxStyle.Information, "Info")
            '    Exit Sub
            'Else
            Dim GroupName As String = LsDepartment.SelectedItems(0).SubItems(0).Text
            Dim GroupID As String = LsDepartment.SelectedItems(0).SubItems(1).Text
            Dim FGroupProperties As New FRMGroupProperties
            FGroupProperties.TxtGroupName.Text = GroupName
            FGroupProperties.LblGroupID.Text = GroupID
            If FGroupProperties.ShowDialog = DialogResult.OK Then
                LsDepartment_SelectedIndexChanged(sender, e)
            End If
            'End If
        Catch ex As Exception
            MsgBox("Please select department name." & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

  

  
    

    Private Sub BtnDeleteUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteUser.Click
        If LsUser.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select user to edit.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If MessageBox.Show("Do you want to delete user?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_USystem.DeleteUserSystem(LsUser.SelectedItems(0).SubItems(1).Text) = 1 Then
                Try
                    LoadUserByGroup(LsDepartment.SelectedItems(0).SubItems(1).Text)
                Catch ex As Exception

                End Try

            End If
        End If
    End Sub

    Private Sub BtnViewAllUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewAllUser.Click
        Try
            LoadUserByGroup(LsDepartment.SelectedItems(0).SubItems(1).Text)
        Catch ex As Exception

        End Try

    End Sub
End Class
