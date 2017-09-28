Public Class MainInvoice
    Dim Inv_DetialPanel As New InvoiceDetial
    Dim DA_Invoice As New DSInvoiceTableAdapters.InvoiceTableAdapter
    Dim DA_InvoiceDetail As New DSInvoiceTableAdapters.RECEIPT_DETAILTableAdapter
    Dim DS_Invoice As New DSInvoice
    Dim DA_Expend As New DS_InvoiceTableAdapters.IncomeTableAdapter
    Sub AddUserControlToPanel(ByVal Panel As Panel, ByVal UI As UserControl)
        Panel.Controls.Clear()
        Panel.AutoScroll = True
        UI.Dock = DockStyle.Fill
        Panel.Controls.Add(UI)
    End Sub

    Public Sub BtnFilterInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFilterInvoice.Click
        If ValidateDateTimePicker(dtFrom, "", ErrValidate) = False Then Exit Sub
        If ValidateDateTimePicker(dtTo, "", ErrValidate) = False Then Exit Sub

        DA_Invoice.FillByInvoiceDate(DS_Invoice.Invoice, FormatDateTime(Me.dtFrom.Value, DateFormat.ShortDate), FormatDateTime(Me.dtTo.Value, DateFormat.ShortDate))
        DA_InvoiceDetail.FillBy(DS_Invoice.RECEIPT_DETAIL)
        Inv_DetialPanel.InvoiceList.DataSource = DS_Invoice.Invoice
        Inv_DetialPanel.GridExpend.DataSource = DA_Expend.GetDataExpendByDate(FormatDateTime(Me.dtFrom.Value, DateFormat.ShortDate), FormatDateTime(Me.dtTo.Value, DateFormat.ShortDate))

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
                Inv_DetialPanel.InvoiceList.DataSource = DS_Invoice.Invoice ' DA_Invoice.SelectInvoiceByID(CInt(Me.txtinvoiceno.Text))
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
                Inv_DetialPanel.InvoiceList.DataSource = DS_Invoice.Invoice  'DA_Invoice.SelectInvoiceByPatientNo(CInt(Me.txtpatientid.Text))
            End If
        ElseIf Me.RadPatientName.Checked = True Then
            If ValidateTextField(TxtPatientName, "", ErrValidate) = False Then Exit Sub
            DA_Invoice.FillByPatientName(DS_Invoice.Invoice, "%" & TxtPatientName.Text & "%")
            DA_InvoiceDetail.FillBy(DS_Invoice.RECEIPT_DETAIL)
            Inv_DetialPanel.InvoiceList.DataSource = DS_Invoice.Invoice
        End If
    End Sub

    Private Sub RadByPatientID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByPatientID.CheckedChanged
        Me.txtpatientid.Text = ""
        Me.txtpatientid.Focus()
    End Sub

    Private Sub RadByInvoiceNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByInvoiceNo.CheckedChanged
        Me.txtinvoiceno.Text = ""
        Me.txtinvoiceno.Focus()
    End Sub

    Private Sub MainInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If DEPART_NAME = "Admin" Then
            GroupIncome.Enabled = True
        Else
            GroupIncome.Enabled = False
        End If
        AddUserControlToPanel(Panel1, Inv_DetialPanel)
    End Sub


    Private Sub ExplorerBar1_GroupClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ExplorerBar.GroupEventArgs) Handles ExplorerBar1.GroupClick
        If e.Group.Index = 0 Then

        ElseIf e.Group.Index = 1 Then

        End If
    End Sub

    Private Sub BtnIncomeShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIncomeShow.Click

        If ValidateDateTimePicker(dtincomefrom, "", ErrValidate) = False Then Exit Sub
        If ValidateDateTimePicker(dtincometo, "", ErrValidate) = False Then Exit Sub
        MainApplicationForm.StatusLoading(True)
        BgLoading.RunWorkerAsync()
    End Sub
    Private Sub LoadingReportIncome()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadingReportIncome))
        Else
            BtnIncomeShow.Enabled = False
            Dim DA_Income As New DS_InvoiceTableAdapters.IncomeTableAdapter
            Dim DA_Sale As New DS_InvoiceTableAdapters.SaleTableAdapter
            Dim DA_Exam As New DS_InvoiceTableAdapters.ParaExamTableAdapter
            Dim DA_Consultation As New DS_InvoiceTableAdapters.ConsultationTableAdapter
            If Me.RadByAll.Checked = True Then
                '' Total Income
                Dim IncomeReport As New RptIncome
                Dim IncomeTable As New DataTable
                IncomeTable = DA_Income.SelectInvoiceByDate(FormatDateTime(Me.dtincomefrom.Value, DateFormat.ShortDate), FormatDateTime(Me.dtincometo.Value, DateFormat.ShortDate))
                IncomeReport.SetDataSource(IncomeTable)
                IncomeReport.SetParameterValue("fromdate", Me.dtincomefrom.Value)
                IncomeReport.SetParameterValue("todate", Me.dtincometo.Value)
                Inv_DetialPanel.CrystalReportViewer1.ReportSource = IncomeReport
                Inv_DetialPanel.CrystalReportViewer1.Show()
            ElseIf Me.RadByConsulation.Checked = True Then
                '' Consultation Income
                Dim ConsultReport As New RptConsultation
                Dim IncomeTable As New DataTable
                IncomeTable = DA_Consultation.SelectConsultationByDate(FormatDateTime(Me.dtincomefrom.Value, DateFormat.ShortDate), FormatDateTime(Me.dtincometo.Value, DateFormat.ShortDate))
                ConsultReport.SetDataSource(IncomeTable)
                ConsultReport.SetParameterValue("fromdate", Me.dtincomefrom.Value)
                ConsultReport.SetParameterValue("todate", Me.dtincometo.Value)
                Inv_DetialPanel.CrystalReportViewer1.ReportSource = ConsultReport
                Inv_DetialPanel.CrystalReportViewer1.Show()
            ElseIf Me.RadBySale.Checked = True Then
                '' Medicine Sale
                Dim SaleReport As New RptMedicine
                Dim IncomeTable As New DataTable
                IncomeTable = DA_Sale.SelectSaleByDate(FormatDateTime(Me.dtincomefrom.Value, DateFormat.ShortDate), FormatDateTime(Me.dtincometo.Value, DateFormat.ShortDate))
                SaleReport.SetDataSource(IncomeTable)
                SaleReport.SetParameterValue("fromdate", Me.dtincomefrom.Value)
                SaleReport.SetParameterValue("todate", Me.dtincometo.Value)
                Inv_DetialPanel.CrystalReportViewer1.ReportSource = SaleReport
                Inv_DetialPanel.CrystalReportViewer1.Show()
            ElseIf Me.RadByExam.Checked = True Then
                '' Para Examination Income
                Dim ParaReport As New RptParaExam
                Dim IncomeTable As New DataTable
                IncomeTable = DA_Exam.SelectExamByDate(FormatDateTime(Me.dtincomefrom.Value, DateFormat.ShortDate), FormatDateTime(Me.dtincometo.Value, DateFormat.ShortDate))
                ParaReport.SetDataSource(IncomeTable)
                ParaReport.SetParameterValue("fromdate", Me.dtincomefrom.Value)
                ParaReport.SetParameterValue("todate", Me.dtincometo.Value)
                Inv_DetialPanel.CrystalReportViewer1.ReportSource = ParaReport
                Inv_DetialPanel.CrystalReportViewer1.Show()
            End If
        End If
    End Sub

    Private Sub BgLoading_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoading.DoWork
        LoadingReportIncome()
    End Sub

    Private Sub BgLoading_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoading.RunWorkerCompleted
        MainApplicationForm.StatusLoading(False)
        BtnIncomeShow.Enabled = True
    End Sub
End Class
