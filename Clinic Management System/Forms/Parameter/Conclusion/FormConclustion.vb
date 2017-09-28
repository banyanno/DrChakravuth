Public Class FormConclustion
    Dim DA_Conclusion As New DSExaminationTableAdapters.tblconclusionTableAdapter
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtConclusion, "", ErrConclustion) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want save new conclustion?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Conclusion.InsertConclusion(TxtConclusion.Text.Replace("'", "''")) = 1 Then
                    MessageBox.Show("A conclusion has been saved successfully.", "Saved Conclusion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error Save conclustion successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            If MessageBox.Show("Do you want update this conclustion?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Conclusion.UpdateConclusion(TxtConclusion.Text.Replace("'", "''"), CInt(Me.LblSaveOption.Text)) = 1 Then
                    MessageBox.Show("The conclustion has been updated.", "update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Failed to update conclusion", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class