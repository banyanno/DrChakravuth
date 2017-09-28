Public Class FormNewExpend
    Dim DA_Invoice As New DSInvoiceTableAdapters.tbl_invoiceTableAdapter
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtExpendNo, "", ErrExpend) = False Then Exit Sub
        If ValidateDateField(DateExpend, "", ErrExpend) = False Then Exit Sub
        If ValidateTextField(TxtTotalExpend, "", ErrExpend) = False Then Exit Sub
        If ValidateTextField(TxtExpendNote, "", ErrExpend) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new your expend?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Invoice.InsertInvoice(TxtExpendNo.Text, FormatDateTime(DateExpend.Value.Date, DateFormat.ShortDate), 0, 0, 0, 0, 0, 0, USER_NAME, 0, TxtTotalExpend.Text, TxtExpendNote.Text, 0, 0, 0, 0, 0, 0) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End If
        Else
            If MessageBox.Show("Do you want to update your expend?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Invoice.UpdateIncome(TxtExpendNo.Text, DateExpend.Value.Date, TxtTotalExpend.Text, TxtExpendNote.Text, USER_NAME, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()

    End Sub

    Private Sub TxtTotalExpend_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTotalExpend.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtExpendNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtExpendNo.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class