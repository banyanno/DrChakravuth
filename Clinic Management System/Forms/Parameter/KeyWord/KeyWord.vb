Public Class KeyWord
    Dim DA_KeyWord As New DS_ParameterTableAdapters.KEY_WORDTableAdapter
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ValidateTextField(TxtKeyWord, "", ErrKeyWord) = False Then Exit Sub
        If lblSave.Text = "0" Then
            If MessageBox.Show("Do you want to save new key word?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_KeyWord.InsertNewKeyWord(TxtKeyWord.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update key word?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_KeyWord.UpdateKeyWord(TxtKeyWord.Text, lblSave.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub
End Class