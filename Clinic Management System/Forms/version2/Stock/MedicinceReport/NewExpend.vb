Public Class NewExpend
    Dim DA_Expend As New DSMedicalReceiveTableAdapters.tbl_invoiceTableAdapter
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtReferNo, "", ErrExpend) = False Then Exit Sub
        If ValidateDateTimePicker(DateReceived, "", ErrExpend) = False Then Exit Sub
        If ValidateTextField(TxtNote, "", ErrExpend) = False Then Exit Sub
        'If ValidateCombobox(CboProduct, "", ErrReceived) = False Then Exit Sub
        'If ValidateTextField(TxtQty, "", ErrReceived) = False Then Exit Sub
        ' '' If ValidateTextField(TxtBonusQTY, "", ErrReceived) = False Then Exit Sub
        'If ValidateTextField(TxtCost, "", ErrReceived) = False Then Exit Sub
        'If ValidateTextField(TxtTotalCost, "", ErrReceived) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new receive?", "Received Medical", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Expend.InsertExpendMedicine(DateReceived.Value.Date, TxtNote.Text, 1111111111, TxtSubTotal.Text, TxtReferNo.Text, False) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If

        Else
            If MessageBox.Show("Do you want to update receive?", "Received Medical", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                '  MessageBox.Show(DA_Expend.UpdateExpend(DateReceived.Value.Date, EmptyString(TxtSubTotal.Text), TxtNote.Text,  TxtReferNo.Text)
                If DA_Expend.UpdateExpend(DateReceived.Value.Date, EmptyString(TxtSubTotal.Text), TxtNote.Text, TxtReferNo.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub TxtSubTotal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSubTotal.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class