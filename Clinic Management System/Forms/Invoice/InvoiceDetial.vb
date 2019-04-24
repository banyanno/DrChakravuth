Public Class InvoiceDetial
    Dim MainInv As MainInvoice
    Dim DA_InvoiceDetail As New DSInvoiceTableAdapters.RECEIPT_DETAILTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal MainPanel As MainInvoice)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MainInv = MainPanel
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub LoadingReceipt()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadingReceipt))
        Else
            Dim ReportInvoice As New invoice
            Dim ReportInvoiceEng As New invoiceEng
            Dim InvoiceID As Long
            Try
                InvoiceID = CLng(Me.InvoiceList.CurrentRow.Cells("invoice_id").Value)
            Catch ex As Exception
                InvoiceID = CLng(Me.InvoiceList.Tables(0).GridEX.GetRow.Cells("RECEIPT_NO").Value)
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

    Private Sub InvoiceList_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles InvoiceList.SelectionChanged
        'If Me.InvoiceList.RowCount >= 1 Then

        '    Try
        '        MainApplicationForm.StatusLoading(True)

        '        Me.bgloadingReport.RunWorkerAsync()
        '    Catch ex As Exception

        '    End Try
        'End If
       
    End Sub

    Private Sub bgloadingReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgloadingReport.DoWork
        LoadingReceipt()
    End Sub

    Private Sub bgloadingReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgloadingReport.RunWorkerCompleted
        MainApplicationForm.StatusLoading(False)
    End Sub

   

    

    Private Sub BtnUpdateExpend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateExpend.Click
        If GridExpend.SelectedItems.Count = 0 Then Exit Sub
        Dim UpdateExpend As New FormNewExpend
        UpdateExpend.LblSaveOption.Text = GridExpend.GetRow.Cells("invoice_id").Value
        UpdateExpend.DateExpend.Checked = True
        UpdateExpend.DateExpend.Value = GridExpend.GetRow.Cells("invoice_date").Value
        UpdateExpend.TxtExpendNo.Text = GridExpend.GetRow.Cells("Expen_No").Value
        UpdateExpend.TxtTotalExpend.Text = GridExpend.GetRow.Cells("Expend").Value
        UpdateExpend.TxtExpendNote.Text = GridExpend.GetRow.Cells("Expend_Note").Value
        UpdateExpend.ShowDialog()
    End Sub

    Private Sub GridExpend_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridExpend.RowDoubleClick
        Try
            If GridExpend.SelectedItems.Count = 0 Then Exit Sub
            Dim UpdateExpend As New FormNewExpend
            UpdateExpend.LblSaveOption.Text = GridExpend.GetRow.Cells("invoice_id").Value
            UpdateExpend.DateExpend.Checked = True
            UpdateExpend.DateExpend.Value = GridExpend.GetRow.Cells("invoice_date").Value
            UpdateExpend.TxtExpendNo.Text = GridExpend.GetRow.Cells("patientid").Value
            UpdateExpend.TxtTotalExpend.Text = GridExpend.GetRow.Cells("Expend").Value
            UpdateExpend.TxtExpendNote.Text = GridExpend.GetRow.Cells("Expend_Note").Value
            If UpdateExpend.ShowDialog() = DialogResult.OK Then
                MainInv.BtnFilterInvoice_Click(sender, e)
            End If

        Catch ex As Exception

        End Try
      

    End Sub

    Dim Split As Boolean = False
    Private Sub BtnViewListExpend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewListExpend.Click
        If Split = False Then
            SplitInvoiceAndExpend.Panel2Collapsed = False
            Split = True
        Else
            SplitInvoiceAndExpend.Panel2Collapsed = True
            Split = False
        End If

    End Sub
    Dim InvoiceOption As Integer = 0
    Private Sub BtnInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInvoice.Click
        If Me.InvoiceList.SelectedItems.Count = 0 Then Exit Sub
        If InvoiceList.RootTable.Key <> "MainInvoice" Then Exit Sub
        Try
            MainApplicationForm.StatusLoading(True)
            InvoiceOption = 0
            Me.bgloadingReport.RunWorkerAsync()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub InvoiceAsEnglishToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceAsEnglishToolStripMenuItem.Click
        If Me.InvoiceList.SelectedItems.Count = 0 Then Exit Sub
        If InvoiceList.RootTable.Key <> "MainInvoice" Then Exit Sub
        Try
            MainApplicationForm.StatusLoading(True)
            InvoiceOption = 1
            Me.bgloadingReport.RunWorkerAsync()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnFindingInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindingInvoice.Click
        Dim FFindingInvoice As New FindInvoiceDetial
        FFindingInvoice.ShowDialog()
    End Sub
End Class
