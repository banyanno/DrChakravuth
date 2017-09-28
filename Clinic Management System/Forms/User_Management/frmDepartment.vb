Public Class frmDepartment

    Public departID As Integer
    Dim DA_Dep As New DSUserManagermentTableAdapters.USER_OF_DEPARTMENTTableAdapter
   
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Dim depart As New tblDepartment
        'Dim departTransMsgStatus As String

        ' Validation
        If ValidateTextField(txtDepartName, "Department name", ErrorDepartment) = False Then
            Exit Sub
        End If

        'If UCase(txtTempDepartName.Text) <> UCase(txtDepartName.Text) Then
        '    If departRepo.isDepartExistSearchByDepartName(txtDepartName.Text) Then
        '        MsgBox("Department name already exist.")
        '        Exit Sub
        '    End If
        'End If
        ''===

        ' Add new vendor to database        
        If lblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want save new department?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Dep.InsertNewDepartment(txtDepartName.Text) = 1 Then
                    MessageBox.Show("Save new department successful.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error save new department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            End If
        Else ' Update vendor to database
           
            If MessageBox.Show("Do you want update department?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Dep.UpdateDepartment(txtDepartName.Text, lblSaveOption.Text) = 1 Then
                    MessageBox.Show("Update department successful.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error update department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click        
        Me.Close()
    End Sub

    Private Sub frmDepartment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Dim depart As New tblDepartment
        'If lblSaveOption.Text <> "0" Then
        '    txtDepartID.Text = departID
        '    depart = departRepo.GetDepartByID(departID)
        '    txtDepartID.Text = depart.DepartID.ToString
        '    txtDepartName.Text = depart.DepartName
        '    txtTempDepartName.Text = depart.DepartName
        'Else
        '    txtDepartID.Text = departRepo.GenerateDepartmentID
        'End If

    End Sub
End Class