Public Class FormIssueReceipt
    Dim PatientIssueReceipt As UPatientIssueReceipt
    Dim TblConsult As DataTable
    Dim TblPara As DataTable
    Dim TblMedicine As DataTable
    Dim DA_PreConsultation As New DSConsultationTableAdapters.tbl_preinvoice_consultationTableAdapter
    Dim DA_PrePara As New DSInvoiceTableAdapters.tbl_preinvoice_paraexamTableAdapter
    Dim DA_PreMedicineOrder As New DSInvoiceTableAdapters.tbl_preinvoice_medicineTableAdapter
    Dim DA_Store As New DSStoreTableAdapters.tblmedicinestoreTableAdapter
    Dim DA_PreInvoice As New DSInvoiceTableAdapters.tbl_preinvoiceTableAdapter
    Dim DA_Issue As New DSStoreTableAdapters.tblissueTableAdapter
    Dim DA_Transaction As New DSStoreTableAdapters.tbltransactionTableAdapter
    Dim DA_Rate As New DSInvoiceTableAdapters.EXCHANGE_RATETableAdapter

    Sub New(ByVal PatientIssueReceipt As UPatientIssueReceipt)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.PatientIssueReceipt = PatientIssueReceipt
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FormIssueReceipt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
      

    End Sub

    Private Sub FormIssueReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ValConsult, ValPara, ValMedicine As Double
        txtexchangerate.Text = GetExchangeRate()
        TblConsult = DA_PreConsultation.SelectByPatientID(CLng(PatientIssueReceipt.InvoiceList.CurrentRow.Cells("patientid").Value))
        For Each rows As DataRow In TblConsult.Rows
            ValConsult = ValConsult + CDbl(rows("consultprice"))
        Next
        TblPara = DA_PrePara.SelectParaByPatientID(PatientIssueReceipt.InvoiceList.CurrentRow.Cells("patientid").Value)
        For Each rows As DataRow In TblPara.Rows
            ValPara = ValPara + CDbl(rows("servicecharge"))
        Next
        TblMedicine = DA_PreMedicineOrder.SelectMedicineByPatientID(PatientIssueReceipt.InvoiceList.CurrentRow.Cells("patientid").Value)
        For Each row As DataRow In TblMedicine.Rows
            ValMedicine = ValMedicine + CDbl(row("amount"))
        Next
        LblValConsult.Text = ValConsult
        LblValParaExam.Text = ValPara
        LblValMedicine.Text = ValMedicine

        CalculateTotal()
        txtcash.Select()
        txtcash.SelectAll()
        txtcash.Focus()
    End Sub

    Sub CalculateTotal()


        Dim TblConsult As New DataTable
        Dim TblPara As New DataTable
        Dim TblMedicine As New DataTable
        Dim ConsultAmount As Decimal = 0
        Dim ParaAmount As Decimal = 0
        Dim MedicineAmount As Decimal = 0
        Dim TotalAmount As Decimal = 0

        TblConsult = DA_PreConsultation.SelectByPatientID(CLng(PatientIssueReceipt.InvoiceList.CurrentRow.Cells("patientid").Value))
        TblPara = DA_PrePara.SelectParaByPatientID(PatientIssueReceipt.InvoiceList.CurrentRow.Cells("patientid").Value)
        TblMedicine = DA_PreMedicineOrder.SelectMedicineByPatientID(PatientIssueReceipt.InvoiceList.CurrentRow.Cells("patientid").Value)

        For i As Integer = 0 To TblConsult.Rows.Count - 1
            ConsultAmount = ConsultAmount + CDec(TblConsult.Rows(i).Item("consultprice"))
        Next
        For x As Integer = 0 To TblPara.Rows.Count - 1
            ParaAmount = ParaAmount + CDec(TblPara.Rows(x).Item("servicecharge"))
        Next
        For y As Integer = 0 To TblMedicine.Rows.Count - 1
            MedicineAmount = MedicineAmount + CDec(TblMedicine.Rows(y).Item("amount"))
        Next

        TotalAmount = ConsultAmount + MedicineAmount + ParaAmount
        Me.txttotalusd.Text = TotalAmount 'FormatCurrency(TotalAmount, 2)
        Me.txtsubtotalusd.Text = TotalAmount ' FormatCurrency(TotalAmount, 2)
        Me.txtSubtotalriel.Text = TotalAmount * CDbl(Me.txtexchangerate.Text)

    End Sub
    Dim DA_ReceiptDetail As New DSInvoiceTableAdapters.RECEIPT_DETAILTableAdapter
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ChDisConsult.Checked = True Then
            If ValidateTextField(TxtDisConsult, "", ErrIssueReceipt) = False Then Exit Sub
        End If
        If ChDisPara.Checked = True Then
            If ValidateTextField(TxtDisParaExam, "", ErrIssueReceipt) = False Then Exit Sub
        End If
        If ChDisMedicine.Checked = True Then
            If ValidateTextField(TxtDisMedicine, "", ErrIssueReceipt) = False Then Exit Sub
        End If
        If CDbl(EmptyString(txtdiscount.Text)) > CDbl(EmptyString(txttotalusd.Text)) Then
            MsgBox("Discount is big than total pay", MsgBoxStyle.Exclamation, "Cash received")
            Exit Sub
        End If
        If CDbl(EmptyString(txtdiscount.Text)) = CDbl(EmptyString(txttotalusd.Text)) Then
        Else
            If CDbl(EmptyString(Me.txtcash.Text)) <= 0 Then
                MsgBox("Please enter the cash received", MsgBoxStyle.Exclamation, "No cash received")
                Me.txtcash.SelectAll()
                Me.txtcash.Focus()
                Exit Sub
            End If
            If CDbl(Me.txtcash.Text) < CDbl(Me.txtsubtotalusd.Text) Then
                MsgBox("Th cash received is not enough to pay", MsgBoxStyle.Exclamation, "Not enough payment")
                Me.txtcash.Select()
                Me.txtcash.SelectAll()

                Exit Sub
            End If
        End If

       
        If MessageBox.Show("Do you want this issure invoice to patient?", "Issure Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'Dim TblConsult As New DataTable
            Dim TblPreConsult As DataTable = DA_PreConsultation.SelectByPatientID(CLng(PatientIssueReceipt.InvoiceList.CurrentRow.Cells("patientid").Value))
            Dim TblPrePara As DataTable = DA_PrePara.SelectParaByPatientID(CLng(PatientIssueReceipt.InvoiceList.CurrentRow.Cells("patientid").Value))
            Dim TblPreMedicine As DataTable = DA_PreMedicineOrder.SelectMedicineByPatientID(CLng(PatientIssueReceipt.InvoiceList.CurrentRow.Cells("patientid").Value))
            ''TblConsult = DA_Prescription.SelectPrescriptionByID(Me.InvoiceList.CurrentRow.Cells("prescriptionid").Value)



            Dim DA_Invoice As New DSInvoiceTableAdapters.tbl_invoiceTableAdapter
            Dim DA_ParaExam As New DSInvoiceTableAdapters.tbl_invoice_paraexamTableAdapter
            Dim DA_Medicine As New DSInvoiceTableAdapters.tbl_invoice_medicineorderTableAdapter
            Dim DA_Consultation As New DSInvoiceTableAdapters.tbl_invoice_consultationTableAdapter

            '' INSERT INVOICE
            DA_Invoice.InsertInvoice(CDbl(PatientIssueReceipt.InvoiceList.CurrentRow.Cells("patientid").Value), FormatDateTime(Now, DateFormat.ShortDate), CDec(Me.txttotalusd.Text), CDec(EmptyString(Me.txtdiscount.Text)), CDec(EmptyString(Me.txtexchangerate.Text)), True, CDec(txtcash.Text), CDec(txtchange.Text), USER_NAME, EmptyString(TxtDeposit.Text), 0, "", EmptyString(TxtDisConsult.Text), EmptyString(TxtDisParaExam.Text), EmptyString(TxtDisMedicine.Text), EmptyString(LblValConsult.Text), EmptyString(LblValParaExam.Text), EmptyString(LblValMedicine.Text))
            ''Get Max InvoiceID
            Dim InvoiceID As Long = DA_Invoice.SelectMaxID

            ''Insert Consultation
            For x As Integer = 0 To TblPreConsult.Rows.Count - 1
                DA_Consultation.InsertConsultation(InvoiceID, TblPreConsult.Rows(x).Item("consulttype"), TblPreConsult.Rows(x).Item("consultprice"))
                DA_ReceiptDetail.InsertReceiptDetail(InvoiceID, "Consultation Fee", "", "", TblPreConsult.Rows(x).Item("consultprice"), TblPreConsult.Rows(x).Item("consultprice"))
            Next

            ''Insert ParaCheckID
            For i As Integer = 0 To TblPrePara.Rows.Count - 1
                DA_ParaExam.InsertPara(InvoiceID, TblPrePara.Rows(i).Item("paracheckid"), TblPrePara.Rows(i).Item("servicecharge"))
                DA_ReceiptDetail.InsertReceiptDetail(InvoiceID, TblPrePara.Rows(i).Item("paracheck"), "", "", TblPrePara.Rows(i).Item("servicecharge"), TblPrePara.Rows(i).Item("servicecharge"))
            Next

            ''Insert Medicine And Record Transaction
            Dim OldQty As Decimal
            Dim SubOldQty As Decimal
            Dim StoreID As Long

            Dim StoreSaleTable As New DataTable
            For j As Integer = 0 To TblPreMedicine.Rows.Count - 1
                DA_Medicine.InsertMedicine(InvoiceID, TblPreMedicine.Rows(j).Item("medicineid"), TblPreMedicine.Rows(j).Item("unitname"), TblPreMedicine.Rows(j).Item("qty"), TblPreMedicine.Rows(j).Item("price"))

                StoreSaleTable = DA_Store.SelectStoreByMedicineIDAndUnitname(CInt(TblPreMedicine.Rows(j).Item("medicineid")), TblPreMedicine.Rows(j).Item("unitname").ToString)
                If StoreSaleTable.Rows(0).Item("unittype") = "Main unit" Then
                    ''UPDATE MAIN STORE
                    OldQty = FormatNumber(CDec(StoreSaleTable.Rows(0).Item("qty")), 2)
                    StoreID = CLng(StoreSaleTable.Rows(0).Item("store_id"))
                    DA_Store.UpdateQuantity(OldQty - CDec(TblPreMedicine.Rows(j).Item("qty")), StoreID)
                    ''Add Transaction
                    DA_Transaction.InsertTransaction(StoreID, 1, FormatDateTime(Now.Date, DateFormat.ShortDate), OldQty, CDec(TblPreMedicine.Rows(j).Item("qty")) * -1, FormatNumber(OldQty - CDec(TblPreMedicine.Rows(j).Item("qty")), 2))
                    ''Add Issue
                    DA_Issue.InsertIssue(StoreID, "Sale", FormatDateTime(Now.Date, DateFormat.ShortDate), CDec(TblPreMedicine.Rows(j).Item("qty")))

                    ''UPDATE SUB STORE
                    Dim SubStoreTable As New DataTable
                    Dim SaleSubQty As Decimal
                    SubStoreTable = DA_Store.SelectByMedicineIDAndUnitType(CInt(TblPreMedicine.Rows(j).Item("medicineid")), "Sub unit")
                    For x = 0 To SubStoreTable.Rows.Count - 1
                        SubOldQty = CDec(SubStoreTable.Rows(x).Item("qty"))
                        StoreID = CLng(SubStoreTable.Rows(x).Item("store_id"))
                        SaleSubQty = CDec(TblPreMedicine.Rows(j).Item("qty")) * CInt(SubStoreTable.Rows(x).Item("ratioqty"))
                        DA_Store.UpdateQuantity(SubOldQty - SaleSubQty, StoreID)
                        ''Add Transaction
                        DA_Transaction.InsertTransaction(StoreID, 1, FormatDateTime(Now.Date, DateFormat.ShortDate), SubOldQty, SaleSubQty * -1, SubOldQty - SaleSubQty)
                        ''Add Issue
                        DA_Issue.InsertIssue(StoreID, "Sale", FormatDateTime(Now.Date, DateFormat.ShortDate), SaleSubQty)
                    Next
                Else

                    ''UPDATE MAIN STORE
                    Dim MainStoreTable As New DataTable
                    Dim SaleMainQty As Decimal
                    MainStoreTable = DA_Store.SelectByMedicineIDAndUnitType(CInt(TblPreMedicine.Rows(j).Item("medicineid")), "Main unit")
                    SubOldQty = CDec(MainStoreTable.Rows(0).Item("qty"))
                    StoreID = CLng(MainStoreTable.Rows(0).Item("store_id"))
                    SaleMainQty = FormatNumber(CDec(TblPreMedicine.Rows(j).Item("qty")) / CInt(StoreSaleTable.Rows(0).Item("ratioqty")), 2)
                    DA_Store.UpdateQuantity(SubOldQty - SaleMainQty, StoreID)
                    ''Add Transaction
                    DA_Transaction.InsertTransaction(StoreID, 1, FormatDateTime(Now.Date, DateFormat.ShortDate), SubOldQty, SaleMainQty * -1, SubOldQty - SaleMainQty)
                    ''Add Issue
                    DA_Issue.InsertIssue(StoreID, "Sale", FormatDateTime(Now.Date, DateFormat.ShortDate), SaleMainQty)


                    ''UPDATE SUB STORE
                    Dim SubStoreTable As New DataTable
                    Dim SaleSubQty As Decimal
                    SubStoreTable = DA_Store.SelectByMedicineIDAndUnitType(CInt(TblPreMedicine.Rows(j).Item("medicineid")), "Sub unit")
                    For x = 0 To SubStoreTable.Rows.Count - 1

                        SubOldQty = CDec(SubStoreTable.Rows(x).Item("qty"))
                        StoreID = CLng(SubStoreTable.Rows(x).Item("store_id"))
                        If StoreID = StoreSaleTable.Rows(0).Item("store_id") Then
                            'Update current substore
                            DA_Store.UpdateQuantity(SubOldQty - CDec(TblPreMedicine.Rows(j).Item("qty")), StoreID)
                            ''Add Transaction
                            DA_Transaction.InsertTransaction(StoreID, 1, FormatDateTime(Now.Date, DateFormat.ShortDate), SubOldQty, CDec(TblPreMedicine.Rows(j).Item("qty")) * -1, SubOldQty - CDec(TblPreMedicine.Rows(j).Item("qty")))
                            ''Add Issue
                            DA_Issue.InsertIssue(StoreID, "Sale", FormatDateTime(Now.Date, DateFormat.ShortDate), CDec(TblPreMedicine.Rows(j).Item("qty")))
                        Else
                            'Update other substore
                            SaleSubQty = CDec(SaleMainQty) * CInt(SubStoreTable.Rows(x).Item("ratioqty"))

                            DA_Store.UpdateQuantity(SubOldQty - SaleSubQty, StoreID)
                            ''Add Transaction
                            DA_Transaction.InsertTransaction(StoreID, 1, FormatDateTime(Now.Date, DateFormat.ShortDate), SubOldQty, SaleSubQty * -1, SubOldQty - SaleSubQty)
                            ''Add Issue
                            DA_Issue.InsertIssue(StoreID, "Sale", FormatDateTime(Now.Date, DateFormat.ShortDate), SaleSubQty)
                        End If

                    Next

                End If


                DA_ReceiptDetail.InsertReceiptDetail(InvoiceID, TblPreMedicine.Rows(j).Item("medicinename"), TblPreMedicine.Rows(j).Item("qty"), TblPreMedicine.Rows(j).Item("unitname"), TblPreMedicine.Rows(j).Item("price"), (TblPreMedicine.Rows(j).Item("price") * TblPreMedicine.Rows(j).Item("qty")))
            Next

            Dim PatientID As Long = CLng(PatientIssueReceipt.InvoiceList.GetRow.Cells("patientid").Value)

            ''DELETE From PreConsultation
            DA_PreConsultation.DeleteByPatientID(PatientID)
            '' DELETE From PrePara
            DA_PrePara.DeleteParaByPatientID(PatientID)
            ''DELETE From PreExam
            DA_PreMedicineOrder.DeleteMedicineByPatientID(PatientID)
            ''DELETE From PreInvoice
            DA_PreInvoice.DeleteInvoiceByID(CLng(PatientIssueReceipt.InvoiceList.CurrentRow.Cells("pre_id").Value))

            'Dim ReportInvoice As New invoice
            Dim ReportInvoice As New InvoiceSmalV1
            'Dim Viewer As New FormReportViewer



            Dim DA_InvoiceSmall As New DSInvoiceTableAdapters.V_ReceiptDetailTableAdapter

            Dim InvoiceTable As DataTable = DA_InvoiceSmall.GetData(InvoiceID)

            'Set Datasourse of Report Tables
            ReportInvoice.SetDataSource(InvoiceTable)

            printDocument.PrinterSettings.PrinterName = PrinterReceipt.Trim
            Try
                ReportInvoice.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName
            Catch ex As Exception
                MessageBox.Show("Can not find printer!" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            ReportInvoice.PrintToPrinter(1, False, 1, 1)
            ReportInvoice.Dispose()
            ReportInvoice.Close()
            'Viewer.CVForm.ReportSource = ReportInvoice
            'Viewer.ShowDialog()
            'Viewer.Close()
            'Viewer.Dispose()
            Me.PatientIssueReceipt.ConsultationList.DataSource = Nothing
            Me.PatientIssueReceipt.OrderList.DataSource = Nothing
            Me.PatientIssueReceipt.ParaList.DataSource = Nothing
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub
    Public PrinterReceipt As String = My.Settings.PrinterName
    Public printDocument As New System.Drawing.Printing.PrintDocument

    'Private Sub txtcash_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcash.GotFocus
    '    txtcash.Select()
    '    txtcash.Focus()
    '    txtcash.SelectAll()
    'End Sub
    Private Sub txtcash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcash.KeyPress
        SetDisableKeyString(e)

    End Sub

   
    Private Sub CashChange()
        'Try
        Dim Change As Double = 0
        Change = (CDbl(EmptyString(Me.txtcash.Text))) - (CDbl(EmptyString(Me.txtsubtotalusd.Text)))
        If Change < 0 Then
            Me.txtchange.Text = "0"
        Else
            Me.txtchange.Text = Change
        End If

        Me.txtsubtotalusd.Text = (CDbl(EmptyString(Me.txttotalusd.Text)) - (CDbl(EmptyString(Me.txtdiscount.Text)) + CDbl(EmptyString(TxtDeposit.Text))))
        Me.txtSubtotalriel.Text = (CDbl(EmptyString(Me.txtsubtotalusd.Text)) * CDbl(EmptyString(Me.txtexchangerate.Text)))
        'Me.txttotalriel.Text = Format(CDbl(Me.txtsubtotalusd.Text) * CDbl(Me.txtexchangerate.Text), "#,###.00 R")
        'Me.txtcash.Text = CDbl(EmptyString(Me.txtcash.Text))
        'Catch ex As Exception

        'End Try

    End Sub
    Private Sub TotalDiscount()
        Dim TotalDiscount As Double = 0
        TotalDiscount = CDbl(EmptyString(TxtDisConsult.Text)) + (CDbl(EmptyString(TxtDisParaExam.Text))) + (CDbl(EmptyString(TxtDisMedicine.Text)))
        If TotalDiscount < 0 Then
            txtdiscount.Text = "0"
        Else
            txtdiscount.Text = TotalDiscount
        End If
    End Sub

    Private Sub txtdiscount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdiscount.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub txtexchangerate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtexchangerate.KeyPress
        SetDisableKeyString(e)
    End Sub

 


    Private Sub txtcash_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtcash.MouseClick
        txtcash.Select()
        txtcash.SelectAll()
    End Sub

   
    Private Sub txtcash_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcash.KeyUp
        CashChange()
    End Sub

    Private Sub txtdiscount_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdiscount.KeyUp
        CashChange()
    End Sub

    Private Sub txtexchangerate_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtexchangerate.KeyUp
        CashChange()
    End Sub

    Private Sub txtdiscount_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtdiscount.MouseClick
        txtdiscount.Select()
        txtdiscount.SelectAll()
    End Sub

    Private Sub txtexchangerate_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtexchangerate.MouseClick
        txtexchangerate.Select()
        txtexchangerate.SelectAll()
    End Sub

    Private Sub TxtDeposit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDeposit.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtDeposit_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDeposit.KeyUp
        CashChange()
    End Sub

    Private Sub TxtDeposit_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TxtDeposit.MouseClick
        TxtDeposit.Select()
        TxtDeposit.SelectAll()
    End Sub

   
    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

  
    Private Sub ChDisConsult_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChDisConsult.CheckedChanged
        TxtDisConsult.Enabled = ChDisConsult.Checked
        TxtDisConsult.Select()
        TxtDisConsult.Focus()
        TxtDisConsult.SelectAll()
        TxtDisConsult.Text = ""
    End Sub

    Private Sub ChDisPara_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChDisPara.CheckedChanged
        TxtDisParaExam.Enabled = ChDisPara.Checked
        TxtDisParaExam.Select()
        TxtDisParaExam.Focus()
        TxtDisParaExam.SelectAll()
        TxtDisParaExam.Text = ""
    End Sub

    Private Sub ChDisMedicine_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChDisMedicine.CheckedChanged
        TxtDisMedicine.Enabled = ChDisMedicine.Checked
        TxtDisMedicine.Select()
        TxtDisMedicine.Focus()
        TxtDisMedicine.SelectAll()
        TxtDisMedicine.Text = ""
    End Sub

    Private Sub TxtDisConsult_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDisConsult.KeyUp
        TotalDiscount()
        txtcash.Text = "0"
    End Sub

    Private Sub TxtDisParaExam_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDisParaExam.KeyUp
        TotalDiscount()
        txtcash.Text = "0"
    End Sub

    Private Sub TxtDisMedicine_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDisMedicine.KeyUp
        TotalDiscount()
        txtcash.Text = "0"
    End Sub

    Private Sub txtdiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdiscount.TextChanged
        CashChange()
    End Sub

    Private Sub TxtDisConsult_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDisConsult.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtDisParaExam_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TxtDisParaExam.MouseClick
        TxtDisParaExam.SelectAll()

    End Sub

    Private Sub TxtDisParaExam_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDisParaExam.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtDisConsult_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TxtDisConsult.MouseClick
        TxtDisConsult.SelectAll()
    End Sub

    Private Sub TxtDisMedicine_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDisMedicine.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtDisMedicine_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TxtDisMedicine.MouseClick
        TxtDisMedicine.SelectAll()
    End Sub


    
End Class