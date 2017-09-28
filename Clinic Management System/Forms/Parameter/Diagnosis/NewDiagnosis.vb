Public Class NewDiagnosis
    Dim DA_Diagnosis As New DSPAtientTableAdapters.tbldiagnosisTableAdapter
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateTextField(txtDiagnosis, "", ErrDiagnosis) = False Then Exit Sub
        If lblSaveOption.Text = "0" Then
            If DA_Diagnosis.InsertNewDiagnosis(txtDiagnosis.Text) = 1 Then
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        Else
            If DA_Diagnosis.UpdateDiagnosis(txtDiagnosis.Text, lblSaveOption.Text) = 1 Then
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class