Public Class NewHospital
    Dim DA_Hospital As New DSReferalTableAdapters.HOSPITALTableAdapter
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtHospitalName, "", ErrHospital) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want save new hospital?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Hospital.InsertNewHospital(TxtHospitalName.Text.Replace("'", "''"), TxtHospitalDescription.Text.Replace("'", "''")) = 1 Then
                    MessageBox.Show("Successful save new hospital info.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error save new hospital info.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            If MessageBox.Show("Do you want update hospital?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Hospital.UpdateHospitalInfo(TxtHospitalName.Text, TxtHospitalDescription.Text, LblSaveOption.Text) = 1 Then
                    MessageBox.Show("Successful update new hospital info.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error update hospital info.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub
End Class