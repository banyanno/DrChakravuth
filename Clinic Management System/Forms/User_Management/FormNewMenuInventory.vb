Public Class FormNewMenuInventory
    Dim DA_Menu As New DSUserManagermentTableAdapters.USER_MENUSTableAdapter
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtMenuDisplay, "", ErrMenu) = False Then Exit Sub
        If ValidateTextField(TxtMenuKey, "", ErrMenu) = False Then Exit Sub

        If LblSaveOption.Text = "0" Then

            If MessageBox.Show("Do you want to save new permistion?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                If DA_Menu.InsertNewMenu(TxtMenuKey.Text, TxtMenuDisplay.Text) = 1 Then
                    MessageBox.Show("Save new permistion successful.", "Permistion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error save new permistion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            If MessageBox.Show("Do you want update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
             
                If DA_Menu.UpdateMenu(TxtMenuKey.Text, TxtMenuDisplay.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error update permistion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub


End Class