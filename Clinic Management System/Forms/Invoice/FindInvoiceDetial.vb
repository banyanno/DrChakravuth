Public Class FindInvoiceDetial
    Dim Inv_DetialPanel As New InvoiceDetial
    Dim DA_Invoice As New DSInvoiceTableAdapters.InvoiceTableAdapter
    Dim DA_InvoiceDetail As New DSInvoiceTableAdapters.RECEIPT_DETAILTableAdapter
    Dim DS_Invoice As New DSInvoice
    Dim DA_Expend As New DS_InvoiceTableAdapters.IncomeTableAdapter
    Dim InvoiceOption As Integer = 0
    Private Sub RadByInvoiceNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByInvoiceNo.CheckedChanged
        txtinvoiceno.Enabled = RadByInvoiceNo.Checked
    End Sub

    Private Sub RadByPatientID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByPatientID.CheckedChanged
        txtpatientid.Enabled = RadByPatientID.Checked
    End Sub

    Private Sub RadPatientName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadPatientName.CheckedChanged
        TxtPatientName.Enabled = RadPatientName.Checked
    End Sub


    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        If Me.RadByInvoiceNo.Checked = True Then
            If ValidateTextField(txtinvoiceno, "", ErrValidate) = False Then Exit Sub
            If IsNumeric(Me.txtinvoiceno.Text) = False Then
                MsgBox("Please enter InvoiceNo as number only", MsgBoxStyle.Exclamation, "Invalid InvoiceNo")
                Me.txtinvoiceno.Select()
                Me.txtinvoiceno.SelectAll()

            Else
                DA_Invoice.FillByInvoiceID(DS_Invoice.Invoice, CLng(Me.txtinvoiceno.Text))
                DA_InvoiceDetail.FillBy(DS_Invoice.RECEIPT_DETAIL)
                InvoiceList.DataSource = DS_Invoice.Invoice ' DA_Invoice.SelectInvoiceByID(CInt(Me.txtinvoiceno.Text))
            End If
        ElseIf Me.RadByPatientID.Checked = True Then
            If ValidateTextField(txtpatientid, "", ErrValidate) = False Then Exit Sub
            If IsNumeric(Me.txtpatientid.Text) = False Then
                MsgBox("Please enter PatientID as number only", MsgBoxStyle.Exclamation, "Invalid InvoiceNo")
                Me.txtpatientid.Select()
                Me.txtpatientid.SelectAll()

            Else
                DA_Invoice.FillByPatientNo(DS_Invoice.Invoice, CInt(Me.txtpatientid.Text))
                DA_InvoiceDetail.FillBy(DS_Invoice.RECEIPT_DETAIL)
                InvoiceList.DataSource = DS_Invoice.Invoice  'DA_Invoice.SelectInvoiceByPatientNo(CInt(Me.txtpatientid.Text))
            End If
        ElseIf Me.RadPatientName.Checked = True Then
            If ValidateTextField(TxtPatientName, "", ErrValidate) = False Then Exit Sub
            DA_Invoice.FillByPatientName(DS_Invoice.Invoice, "%" & TxtPatientName.Text & "%")
            DA_InvoiceDetail.FillBy(DS_Invoice.RECEIPT_DETAIL)
            InvoiceList.DataSource = DS_Invoice.Invoice
        End If
    End Sub

    Private Sub BtnInvoiceKH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInvoiceKH.Click
        If Me.InvoiceList.SelectedItems.Count = 0 Then Exit Sub
        If InvoiceList.RootTable.Key <> "MainInvoice" Then Exit Sub
        Try
            MainApplicationForm.StatusLoading(True)
            InvoiceOption = 0
            Me.bgloadingReport.RunWorkerAsync()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnInvoiceEnglish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInvoiceEnglish.Click
        If Me.InvoiceList.SelectedItems.Count = 0 Then Exit Sub
        If InvoiceList.RootTable.Key <> "MainInvoice" Then Exit Sub
        Try
            MainApplicationForm.StatusLoading(True)
            InvoiceOption = 1
            Me.bgloadingReport.RunWorkerAsync()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bgloadingReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgloadingReport.DoWork
        LoadingReceipt()
    End Sub
    Private Sub LoadingReceipt()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadingReceipt))
        Else
            Dim ReportInvoice As New invoice
            Dim ReportInvoiceEng As New invoiceEng
            Dim InvoiceID As Long
            Try

                InvoiceID = CLng(Me.InvoiceList.Tables(0).GridEX.GetRow.Cells("RECEIPT_NO").Value)
            Catch ex As Exception
                InvoiceID = CLng(Me.InvoiceList.CurrentRow.Cells("invoice_id").Value)
            End Try

            'Dim Viewer As New FormReportViewer
            Dim DA_Invoice As New DSInvoiceTableAdapters.V_ReceiptDetailTableAdapter
            Dim InvoiceTable As DataTable = DA_Invoice.SelectByRECEIPT_NO(InvoiceID)
            'Set Datasourse of Report Tables
            ReportInvoice.SetDataSource(InvoiceTable)
            ReportInvoiceEng.SetDataSource(InvoiceTable)
            If InvoiceOption = 0 Then
                CrystalReportViewer1.ReportSource = ReportInvoice
            ElseIf InvoiceOption = 1 Then
                CrystalReportViewer1.ReportSource = ReportInvoiceEng

            End If


        End If
    End Sub

    Private Sub bgloadingReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgloadingReport.RunWorkerCompleted
        MainApplicationForm.StatusLoading(False)
    End Sub
End Class