Public Class FormShowBy
    Dim ReportPanel As UCStoreReport
    Dim DA_Medicine As New DSPAtientTableAdapters.tblmedicineTableAdapter
    Dim DA_Receive As New DSStoreReportTableAdapters.ReceiveTableAdapter
    Dim DA_Issue As New DSStoreReportTableAdapters.IssueTableAdapter
    Dim DA_Transaction As New DSStoreReportTableAdapters.TransactionTableAdapter
    Dim DA_Adjustment As New DSStoreReportTableAdapters.AdjustmentTableAdapter
    Dim DA_Transfer As New DSStoreReportTableAdapters.TransferTableAdapter
    Dim ReportIndex As Integer = 1

    Sub New(ByVal UReport As UCStoreReport, ByVal RptIndex As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ReportPanel = UReport
        ReportIndex = RptIndex
        ' Add any initialization after the InitializeComponent() call.
        Me.cbomedicine.DataSource = DA_Medicine.SelectMedicine
        Me.cbomedicine.ValueMember = DA_Medicine.SelectMedicine.Columns("medicineid").ColumnName
        Me.cbomedicine.DisplayMember = DA_Medicine.SelectMedicine.Columns("medicinename").ColumnName
    End Sub
    Private Sub LoadingReport()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadingReport))
        Else
            If ReportIndex = 1 Then
                '' Receiving Store
                Dim ReceiveReport As New RptReceive
                Dim StoreTable As New DataTable
                If RadByAll.Checked = True Then
                    StoreTable = DA_Receive.SelectReceiveByDate(FormatDateTime(Me.dtfrom.Value, DateFormat.ShortDate), FormatDateTime(Me.dtto.Value, DateFormat.ShortDate))
                Else
                    StoreTable = DA_Receive.SelectByDateAndMedicineID(FormatDateTime(Me.dtfrom.Value, DateFormat.ShortDate), FormatDateTime(Me.dtto.Value, DateFormat.ShortDate), CInt(Me.cbomedicine.SelectedValue))
                End If
                ReceiveReport.SetDataSource(StoreTable)
                ReceiveReport.SetParameterValue("fromdate", Me.dtfrom.Value)
                ReceiveReport.SetParameterValue("todate", Me.dtto.Value)
                ReportPanel.CrystalReportViewer1.ReportSource = ReceiveReport
                ReportPanel.CrystalReportViewer1.Show()
            ElseIf ReportIndex = 2 Then
                '' Issuing Store
                Dim IssueReport As New RptIssue
                Dim StoreTable As New DataTable
                If RadByAll.Checked = True Then
                    StoreTable = DA_Issue.SelectIssueByDate(FormatDateTime(Me.dtfrom.Value, DateFormat.ShortDate), FormatDateTime(Me.dtto.Value, DateFormat.ShortDate))
                Else
                    StoreTable = DA_Issue.SelectIssueByDateAndMedicineID(FormatDateTime(Me.dtfrom.Value, DateFormat.ShortDate), FormatDateTime(Me.dtto.Value, DateFormat.ShortDate), CInt(Me.cbomedicine.SelectedValue))
                End If
                IssueReport.SetDataSource(StoreTable)
                IssueReport.SetParameterValue("fromdate", Me.dtfrom.Value)
                IssueReport.SetParameterValue("todate", Me.dtto.Value)
                ReportPanel.CrystalReportViewer1.ReportSource = IssueReport
                ReportPanel.CrystalReportViewer1.Show()
            ElseIf ReportIndex = 3 Then
                '' Store Transaction
                Dim TransactionReport As New RptTransaction
                Dim StoreTable As New DataTable
                If RadByAll.Checked = True Then
                    StoreTable = DA_Transaction.SelectTransactionByDate(FormatDateTime(Me.dtfrom.Value, DateFormat.ShortDate), FormatDateTime(Me.dtto.Value, DateFormat.ShortDate))
                Else
                    StoreTable = DA_Transaction.SelectTransactionByDateAndMedicineID(FormatDateTime(Me.dtfrom.Value, DateFormat.ShortDate), FormatDateTime(Me.dtto.Value, DateFormat.ShortDate), CInt(Me.cbomedicine.SelectedValue))
                End If
                TransactionReport.SetDataSource(StoreTable)
                TransactionReport.SetParameterValue("fromdate", Me.dtfrom.Value)
                TransactionReport.SetParameterValue("todate", Me.dtto.Value)
                ReportPanel.CrystalReportViewer1.ReportSource = TransactionReport
                ReportPanel.CrystalReportViewer1.Show()
            ElseIf ReportIndex = 4 Then
                '' Store Adjustment
                Dim AdjustReport As New RptAdjustment
                Dim StoreTable As New DataTable
                If RadByAll.Checked = True Then
                    StoreTable = DA_Adjustment.SelectAdjustmentByDate(FormatDateTime(Me.dtfrom.Value, DateFormat.ShortDate), FormatDateTime(Me.dtto.Value, DateFormat.ShortDate))
                Else
                    StoreTable = DA_Adjustment.SelectAdjustmentByDateAndMedicineID(FormatDateTime(Me.dtfrom.Value, DateFormat.ShortDate), FormatDateTime(Me.dtto.Value, DateFormat.ShortDate), CInt(Me.cbomedicine.SelectedValue))
                End If
                AdjustReport.SetDataSource(StoreTable)
                AdjustReport.SetParameterValue("fromdate", Me.dtfrom.Value)
                AdjustReport.SetParameterValue("todate", Me.dtto.Value)
                ReportPanel.CrystalReportViewer1.ReportSource = AdjustReport
                ReportPanel.CrystalReportViewer1.Show()
            ElseIf ReportIndex = 5 Then
                '' Store Transfer
                Dim TransferReport As New RptTransfer
                Dim StoreTable As New DataTable
                If RadByAll.Checked = True Then
                    StoreTable = DA_Transfer.SelectTransaferByDate(FormatDateTime(Me.dtfrom.Value, DateFormat.ShortDate), FormatDateTime(Me.dtto.Value, DateFormat.ShortDate))
                Else
                    StoreTable = DA_Transfer.SelectTransferByDateAndMedicineID(FormatDateTime(Me.dtfrom.Value, DateFormat.ShortDate), FormatDateTime(Me.dtto.Value, DateFormat.ShortDate), CInt(Me.cbomedicine.SelectedValue))
                End If
                TransferReport.SetDataSource(StoreTable)
                TransferReport.SetParameterValue("fromdate", Me.dtfrom.Value)
                TransferReport.SetParameterValue("todate", Me.dtto.Value)
                ReportPanel.CrystalReportViewer1.ReportSource = TransferReport
                ReportPanel.CrystalReportViewer1.Show()
            End If
        End If
    End Sub

    Private Sub BtnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShow.Click
        MainApplicationForm.StatusLoading(True)
        BgLoading.RunWorkerAsync()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    
    Private Sub BgLoading_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoading.DoWork
        LoadingReport()
    End Sub

    Private Sub BgLoading_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoading.RunWorkerCompleted
        MainApplicationForm.StatusLoading(False)
        Me.Close()
    End Sub
End Class