Public Class FormMotifOfColoscopy
    Dim DA_Motif_Colo As New DS_ParameterTableAdapters.tblMotiveOfColoscopyTableAdapter
    
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtMotifOfColoscopy, "", ErrMotifColos) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new Motif Coloscopy?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Motif_Colo.InsertNewMotifColo(TxtMotifOfColoscopy.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to save new Motif Coloscopy?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Motif_Colo.UpdateMotifColo(TxtMotifOfColoscopy.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub
End Class