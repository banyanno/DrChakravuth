Imports System.Data.SqlClient
Imports System.Net
Imports System.Reflection.Assembly
Imports System.Threading

Public Class frmLoginChackTravoth
    Dim MainChackTravoth As main
    Dim DA_User_Login As New DSUserManagermentTableAdapters.V_USER_IN_DEPTableAdapter
    Dim DAParams_Inven As New DSDepartmentTableAdapters.PARAMS_INVENTableAdapter
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click

        If Me.txtUserName.Text.Trim.ToUpper = "" Then
            MsgBox("Please enter your username.", MsgBoxStyle.Information, "Login Confirm")
            Me.txtUserName.Focus()
            Me.txtUserName.SelectAll()
            Exit Sub
        ElseIf Me.txtPassword.Text.Trim.ToUpper = "" Then
            MsgBox("Please enter your password.", MsgBoxStyle.Information, "Login Confirm")
            Me.txtPassword.Focus()
            txtPassword.SelectAll()
            Exit Sub
        Else
            BtnOk.Enabled = False
            BtnExit.Enabled = False
            PictLoading.Visible = True
            'LblConnecting.Visible = True
            'Me.UpdateLabelStatus("Connecting to database...", True)
            'Me.UpdateLoaingPic(True)
            Application.DoEvents()
            Me.Cursor = Cursors.WaitCursor
            BgLogin.RunWorkerAsync()
        End If


        'MainChackTravoth = New main(Me)
        ''SubMain.InitUserControl()
        'Me.Hide()
        'MainChackTravoth.Show()
    End Sub

    Dim MsgLogin As Integer
    Private Sub BgLogin_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLogin.DoWork
        MsgLogin = CheckUseAndPwd(txtUserName.Text, txtPassword.Text)
    End Sub
    Sub IntialPARAMS_INVEN()

        Dim PARAM_INVEN As DataTable = DAParams_Inven.GetData
        '--- Query all parameters
        For Each row As DataRow In PARAM_INVEN.Rows
            Select Case row("ParamName")
                Case "MAIN_STOCK_DEPART_ID"
                    MAIN_STOCK_DEPART_ID = row("Value")
                Case "PHARMACY_DEPART_ID"
                    PHARMACY_DEPART_ID = row("Value")
                Case "OPTICALSHOP_DEPART_ID"
                    OPTICALSHOP_DEPART_ID = row("Value")
                Case "OPEN"
                    OPEN = row("Value")
                Case "SENT"
                    SENT = row("Value")
                Case "RESPONSE"
                    RESPONSE = row("Value")
                Case "RECEIVED"
                    RECEIVED = row("Value")
                Case "APPROVED"
                    APPROVED = row("Value")
            End Select
        Next

    End Sub
    Function CheckUseAndPwd(ByVal UserName As String, ByVal Pwd As String) As Integer
        ' Try
        Dim tblUser As DataTable = DA_User_Login.CheckUserAndPwd(UserName, Pwd)
        If tblUser.Rows.Count > 0 Then
            For Each row As DataRow In tblUser.Rows
                'MsgBox(row("UserName") & " " & row("Password") & "  " & row("DepartName") & " " & row("GroupNo"))
                UserGlobleVariable.USER_ID = row("UserID")
                UserGlobleVariable.USER_PWD = row("NewPassword")
                USER_NAME = row("UserName")
                If TypeOf row("ShowName") Is DBNull Then
                    SHOW_NAME = row("UserName")
                Else
                    SHOW_NAME = row("ShowName")
                End If

                UserGlobleVariable.DEPART_ID = row("GroupNo")
                UserGlobleVariable.DEPART_NAME = row("DepartName")
            Next
            Return 0
        Else
            Return 1
        End If



        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Connection")
        '    Me.UpdateLabelStatus("", False)
        'End Try

    End Function

    Private Sub BgLogin_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLogin.RunWorkerCompleted
        DoLoginComplete()
        BtnOk.Enabled = True
        BtnExit.Enabled = True
        Me.UpdateLabelStatus("", False)
        UpdateLoaingPic(False)
        Me.Cursor = Cursors.Default
    End Sub
    ' ------------------------Show status -------------------------------
    Private Delegate Sub DelShowLabelStatus(ByVal txt As String, ByVal v As Boolean)
    Private Delegate Sub DelegatePicture(ByVal v As Boolean)
    Public Sub UpdateLabelStatus(ByVal txt As String, ByVal v As Boolean)
        If Me.Created Then
            LblStatus.Invoke(New DelShowLabelStatus(AddressOf UpdateStatus), New Object() {txt, v})
        End If
    End Sub
    Public Sub UpdateLoaingPic(ByVal v As Boolean)
        If Me.Created Then
            PictLoading.Invoke(New DelegatePicture(AddressOf UpdateVisiblePicLoading), New Object() {v})
        End If
    End Sub
    Private Sub UpdateStatus(ByVal txt As String, ByVal v As Boolean)
        LblStatus.Visible = v
        LblStatus.Text = txt
    End Sub
    Dim SubMain As main
    Private Sub UpdateVisiblePicLoading(ByVal v As Boolean)
        PictLoading.Visible = v
    End Sub
    Sub DoLoginComplete()

        If MsgLogin = 0 Then   'Successfully login

            '--- Initial inventory parameters
            IntialPARAMS_INVEN()

            Dim StrWelcome As String = ""
            USER_NAME = Me.txtUserName.Text.ToUpper.Trim
            UserGlobleVariable.USER_PWD = Me.txtPassword.Text.ToUpper.Trim
            Me.UpdateLabelStatus("Log in successful.", True)
            Application.DoEvents()
            SubMain = New main(Me)
            'SubMain.InitUserControl()
            Me.Hide()
            SubMain.Show()
            ' Me.PictLoading.Visible = True
            ' Me.UpdateLabelStatus("Connectiong to database...", False)
            'LOG_ON_TIME = Today

        ElseIf MsgLogin = 4 Then
            MsgBox("Sorry, this user name is blocked.", MsgBoxStyle.Critical, "Login Confirm")
        ElseIf MsgLogin = 5 Then
            MsgBox("There has no admin user in system. Do you want to create it?", MsgBoxStyle.Information, "Login Confirm")
            'Me.Hide()
            Dim frmUserNew As New FRMNewUser
            frmUserNew.ShowDialog()
            Exit Sub
            Me.Cursor = Cursors.Default
        ElseIf MsgLogin = 10 Then
            Exit Sub
        Else
            'Dim Num As Integer
            'Num = Convert.ToInt32(Me.txtPassword.Text)
            'MsgBox(Num)
            MsgBox("Sorry, this user name and password is not valid.", MsgBoxStyle.Critical, "Login Confirm")
            Me.txtUserName.Focus()
        End If
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub

    Private Sub txtUserName_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtUserName.MouseClick
        Me.txtUserName.SelectAll()
    End Sub

    Private Sub txtPassword_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPassword.MouseClick
        txtPassword.SelectAll()
    End Sub
End Class
