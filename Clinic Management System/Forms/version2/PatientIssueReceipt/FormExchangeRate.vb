Public Class FormExchangeRate
    Dim DA_Rate As New DSInvoiceTableAdapters.EXCHANGE_RATETableAdapter
    Private Sub BtnSetExchangeRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSetExchangeRate.Click
        If LblSaveOption.Text = 0 Then
            If MessageBox.Show("Do you want to set exchange rate?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Rate.InsertExchangeRate(TxtExchangeRate.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End If
        Else
        
            If MessageBox.Show("Do you want to set exchange rate?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Rate.UpdateExchangeRage(TxtExchangeRate.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End If
        End If
    End Sub

    Private Sub FormExchangeRate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tblRate As DataTable = DA_Rate.GetData
        For Each row As DataRow In tblRate.Rows
            LblSaveOption.Text = row("EXCHANG_RATE_ID")
            TxtExchangeRate.Text = row("RATE")
        Next
    End Sub

    Private Sub TxtExchangeRate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtExchangeRate.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class