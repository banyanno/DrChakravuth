Public Class FormBlood
    Dim DA_Blood As New DSExaminationTableAdapters.tblblooditemTableAdapter
    Private Sub BtnBlood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBlood.Click
        If ValidateTextField(TxtBlood, "", ErrBlood) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want save blood check?", "Blood", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                If DA_Blood.InsertBloodCheck(TxtBlood.Text) = 1 Then
                    MessageBox.Show("Save blood success fully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error save blood.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
        Else
            If MessageBox.Show("Do you want update blood check?", "Blood", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                If DA_Blood.UpdateBloodCheck(TxtBlood.Text, LblSaveOption.Text) = 1 Then
                    MessageBox.Show("Update blood success fully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error update blood.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
        End If
       
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class