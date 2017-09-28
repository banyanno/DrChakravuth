Public Class FRMNewUser
    Dim DA_Dep As New DSUserManagermentTableAdapters.USER_OF_DEPARTMENTTableAdapter
    Dim DA_USYS As New DSUserManagermentTableAdapters.USERS_SYSTEMTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboDepartment
            .DataSource = DA_Dep.GetData
            .ValueMember = "DepartID"
            .DisplayMember = "DepartName"
            .SelectedValue = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtUserName, "Name", ErrUser) = False Then Exit Sub
        If ValidateTextField(TxtLoginName, "Login name", ErrUser) = False Then Exit Sub
        If TxtPwd.ReadOnly = False Then
            If ValidateTextField(TxtPwd, "password", ErrUser) = False Then Exit Sub
        End If
        If TxtVerifyPwd.ReadOnly = False Then
            If ValidateTextField(TxtVerifyPwd, "verify password", ErrUser) = False Then Exit Sub
        End If

        If ValidateCombobox(CboDepartment, "", ErrUser) = False Then Exit Sub
        If Me.TxtVerifyPwd.Text.ToUpper.Trim <> Me.TxtPwd.Text.ToUpper.Trim Then
            MsgBox("Password does not match verify password. Check your verify password.", MsgBoxStyle.Critical, "Password # Verify Password")
            Me.TxtVerifyPwd.Focus()
            Exit Sub
        End If
        If LblSaveOption.Text = "0" Then
           
            If MsgBox("Do you want to save system user?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Save Record") = MsgBoxResult.Yes Then
                Dim ImageByte As Byte()
                If lblImgURL.Text = "" Then
                    ImageByte = Nothing
                Else
                    ImageByte = IO.File.ReadAllBytes(lblImgURL.Text)
                End If
                If DA_USYS.InsertNewUser(TxtLoginName.Text, TxtUserName.Text, CboDepartment.SelectedValue, TxtVerifyPwd.Text, txtDoctorname.Text, txtphone.Text, txtdesc.Text, ImageByte, chIsDoctor.Checked) = 1 Then
                    MessageBox.Show("User Information has completely saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error save new system user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            If MsgBox("Do you want to update system user?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Save Record") = MsgBoxResult.Yes Then
                Dim ImageByte As Byte()
                If lblImgURL.Text = "" Then
                    If DA_USYS.UpdateNoImage(TxtLoginName.Text, TxtUserName.Text, CboDepartment.SelectedValue, TxtVerifyPwd.Text, txtDoctorname.Text, txtphone.Text, txtdesc.Text, chIsDoctor.Checked, LblSaveOption.Text) = 1 Then
                        MessageBox.Show("User Information has completely update.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    Else
                        MessageBox.Show("Error update system user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    ImageByte = IO.File.ReadAllBytes(lblImgURL.Text)
                    If DA_USYS.UpdateUserSystem(TxtLoginName.Text, TxtUserName.Text, CboDepartment.SelectedValue, TxtVerifyPwd.Text, txtDoctorname.Text, txtphone.Text, txtdesc.Text, chIsDoctor.Checked, ImageByte, LblSaveOption.Text) = 1 Then
                        MessageBox.Show("User Information has completely update.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    Else
                        MessageBox.Show("Error update system user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
                
            End If
        End If
        
    End Sub

   
    Private Function UserInfo_Checking() As Boolean
        If Me.TxtUserName.Text.Trim = "" Then
            MsgBox("Please key in employee name.", MsgBoxStyle.Information, "Employee Name")
            Me.TxtUserName.Focus()
            Exit Function
        End If
        If Me.txtUserName.Text.Trim = "" Then
            MsgBox("Please key in user name.", MsgBoxStyle.Information, "UserName")
            Me.txtUserName.Focus()
            Exit Function
        End If
        If Me.TxtPwd.Text.Trim = "" Then
            MsgBox("Please key in password.", MsgBoxStyle.Information, "Password")
            Me.TxtPwd.Focus()
            Exit Function
        End If
        If Me.TxtVerifyPwd.Text.Trim = "" Then
            MsgBox("Please key in verify password.", MsgBoxStyle.Information, "Verify Password")
            Me.TxtVerifyPwd.Focus()
            Exit Function
        End If
        If Me.TxtPwd.Text.Length <= 5 Then
            MsgBox("Password cannot be less than 6 numbers or characters.", MsgBoxStyle.Critical, "Password Check confirm")
            Me.TxtPwd.Focus()
            Exit Function
        End If
        If Me.TxtVerifyPwd.Text.ToUpper.Trim <> Me.TxtPwd.Text.ToUpper.Trim Then
            MsgBox("Password does not match verify password. Check your verify password.", MsgBoxStyle.Critical, "Password # Verify Password")
            Me.TxtVerifyPwd.Focus()
            Exit Function
        End If
        
        Return True
    End Function


    Private Function Save_SystemUser() As Boolean
        ''On Error GoTo Error_Place
        'Dim CNN As SqlClient.SqlConnection = ModGlobleVariable.GENERAL_DAO.getConnection
        'Dim da As New SqlClient.SqlDataAdapter
        'Dim parm As SqlClient.SqlParameter

        'Dim cmd As New SqlClient.SqlCommand("Insert Into tblUser(EmployeeName,UserName,Password,isActive,GroupNo) " & _
        '                                    " Values(@EmployeeName,@UserName,@Password,@isActive,@GroupNo)", CNN)
        'cmd.Parameters.Add("@EmployeeName", SqlDbType.VarChar, 80, "EmployeeName")
        'cmd.Parameters.Add("@UserName", SqlDbType.VarChar, 50, "UserName")
        'cmd.Parameters.Add("@Password", SqlDbType.VarBinary, 250, "Password")
        'cmd.Parameters.Add("@isActive", SqlDbType.Char, 1, "isActive")
        'cmd.Parameters.Add("@GroupNo", SqlDbType.Int, 4, "GroupNo")
        'da.InsertCommand = cmd

        'cmd = New SqlClient.SqlCommand("Update tblUser Set EmployeeName=@EmployeeName,UserName=@UserName,Password=@Password," _
        '                    & " isActive=@isActive,isBadLogIn=@isBadLogIn,GroupNo=@GroupNo Where SystemUserID = @SystemUserID", CNN)
        'parm = cmd.Parameters.Add("@SystemUserID", SqlDbType.Int, 4, "SystemUserID")
        'cmd.Parameters.Add("@EmployeeName", SqlDbType.VarChar, 80, "EmployeeName")
        'cmd.Parameters.Add("@UserName", SqlDbType.VarChar, 50, "UserName")
        'cmd.Parameters.Add("@Password", SqlDbType.VarBinary, 250, "Password")
        'cmd.Parameters.Add("@isActive", SqlDbType.Char, 1, "isActive")
        'cmd.Parameters.Add("@isBadLogIn", SqlDbType.Char, 1, "isBadLogIn")
        'cmd.Parameters.Add("@GroupNo", SqlDbType.Int, 4, "GroupNo")
        'parm.SourceVersion = DataRowVersion.Original
        'da.UpdateCommand = cmd

        'cmd = New SqlClient.SqlCommand("Delete from  tblUser Where SystemUserID = @SystemUserID", CNN)
        'parm = cmd.Parameters.Add("@SystemUserID", SqlDbType.Int, 4, "SystemUserID")
        'parm.SourceVersion = DataRowVersion.Original
        'da.DeleteCommand = cmd

        'Try
        '    da.Update(Me.Dset, "Table")
        '    Return True
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "System Error")
        '    CNN.Close()
        '    cmd.Dispose()
        '    da.Dispose()
        '    Return False
        'End Try
        'CNN.Close()
        'cmd.Dispose()
        'da.Dispose()
    End Function

    Private Sub FRMNewUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
      

    End Sub
    Private Sub Load_SystemUser()
        'Dim CNN As SqlClient.SqlConnection
        'CNN = ModGlobleVariable.GENERAL_DAO.getConnection
        'If CNN.State = ConnectionState.Closed Then
        '    CNN.Open()
        'End If
        'Dim StrSql As String = "Select U.UserID,U.EmployeeName,U.UserName,U.Password,U.isActive," _
        '                        & " U.GroupNo,D.DepartName,U.isBadLogIn From Department_User U INNER JOIN " _
        '                        & " tblDepartment D ON U.GroupNo=D.DepartID Order By UserName"
        'Dim SqlDa As New SqlClient.SqlDataAdapter(StrSql, CNN)
        'Dset = New DataSet
        'Try
        '    SqlDa.Fill(Dset)
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        'End Try
        'CNN.Close()
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If ValidateCombobox(CbDepartment, "", ErrUser) = False Then
        '    Exit Sub
        'End If
        'Dim obj(1) As Object
        'obj(0) = CbDepartment.SelectedValue
        'obj(1) = CbDepartment.Text

        'With GridEODAccessRight
        '    If .Rows.Count = 0 Then
        '        .Rows.Add(obj)
        '    Else
        '        If IsValidateDupDepart(obj, obj(0)) = True Then
        '            MessageBox.Show("Department already added.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '            Exit Sub
        '        Else
        '            .Rows.Add(obj)
        '        End If
        '    End If
        'End With

    End Sub

    Private Sub BtnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'With GridEODAccessRight
        '    For Each rRow As DataGridViewRow In .SelectedRows
        '        If MessageBox.Show("Do you want delete selected department ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        '            .Rows.Remove(rRow)
        '        End If
        '    Next
        'End With
    End Sub
    Function IsValidateDupDepart(ByVal pObj() As Object, ByVal pDepartID As Integer) As Boolean

        'Dim IsExist As Boolean = False

        'With GridEODAccessRight
        '    For Each rRow As DataGridViewRow In .Rows
        '        If rRow.Cells("cDepartID").Value = pDepartID Then
        '            IsExist = True
        '            Exit For
        '        End If
        '    Next
        'End With

        'Return IsExist


    End Function



  

    Private Sub PictDoctorSigne_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictDoctorSigne.DoubleClick
        'IO.File.ReadAllBytes(a.FileName))

        Dim a As New OpenFileDialog
        a.Filter = ("Image files| *.jpg")

        If a.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictDoctorSigne.ImageLocation = a.FileName
            lblImgURL.Text = a.FileName
        Else
            lblImgURL.Text = ""
        End If

    End Sub

    

    Private Sub chIsDoctor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chIsDoctor.CheckedChanged
        GroupDoctorInfor.Enabled = chIsDoctor.Checked
    End Sub
End Class