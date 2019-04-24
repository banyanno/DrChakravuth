Public Class UPatientIssueReceipt
    Dim DA_Issue As New DSStoreTableAdapters.tblissueTableAdapter
    Dim DA_Transaction As New DSStoreTableAdapters.tbltransactionTableAdapter
    Dim DA_Store As New DSStoreTableAdapters.tblmedicinestoreTableAdapter
    Dim DA_PreInvoice As New DSInvoiceTableAdapters.tbl_preinvoiceTableAdapter
    Dim DA_Prescription As New DSInvoiceTableAdapters.tblprescriptionTableAdapter
    Dim DA_PreConsultation As New DSConsultationTableAdapters.tbl_preinvoice_consultationTableAdapter
    Dim DA_Consultation As New DSConsultationTableAdapters.tbl_invoice_consultationTableAdapter
    Dim DA_PrePara As New DSInvoiceTableAdapters.tbl_preinvoice_paraexamTableAdapter
    Dim DA_PreMedicineOrder As New DSInvoiceTableAdapters.tbl_preinvoice_medicineTableAdapter


    Sub RefreshInvoice()
        Me.InvoiceList.DataSource = DA_PreInvoice.SelectAllInvoice
    End Sub
    Sub RefreshConsultation()
        If Me.InvoiceList.RowCount >= 1 Then
            Me.ConsultationList.DataSource = DA_PreConsultation.SelectByPatientID(CLng(Me.InvoiceList.CurrentRow.Cells("patientid").Value))
        End If
    End Sub
    Private Sub BtnRefreshIssueReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshIssueReceipt.Click
        RefreshInvoice()
    End Sub

    Private Sub UPatientIssueReceipt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        MessageBox.Show("544erwe")
    End Sub
    Private Sub UPatientIssueReceipt_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RefreshInvoice()
        RefreshPara()
    End Sub
    Sub RefreshPara()
        If Me.InvoiceList.RowCount >= 1 Then
            Me.ParaList.DataSource = DA_PrePara.SelectParaByPatientID(Me.InvoiceList.CurrentRow.Cells("patientid").Value)
        End If
    End Sub
    Sub RefreshOrderList()
        If Me.InvoiceList.RowCount >= 1 Then
            Me.OrderList.DataSource = DA_PreMedicineOrder.SelectMedicineByPatientID(Me.InvoiceList.CurrentRow.Cells("patientid").Value)
        End If
    End Sub
    Private Sub InvoiceList_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles InvoiceList.SelectionChanged
        RefreshConsultation()
        RefreshPara()
        RefreshOrderList()
        CalculateTotal()
    End Sub

   

  

    Sub CalculateTotal()
        If Me.InvoiceList.RowCount >= 1 Then

            Dim TblConsult As New DataTable
            Dim TblPara As New DataTable
            Dim TblMedicine As New DataTable
            Dim ConsultAmount As Decimal = 0
            Dim ParaAmount As Decimal = 0
            Dim MedicineAmount As Decimal = 0
            Dim TotalAmount As Decimal = 0

            TblConsult = DA_PreConsultation.SelectByPatientID(CLng(Me.InvoiceList.CurrentRow.Cells("patientid").Value))
            TblPara = DA_PrePara.SelectParaByPatientID(Me.InvoiceList.CurrentRow.Cells("patientid").Value)
            TblMedicine = DA_PreMedicineOrder.SelectMedicineByPatientID(Me.InvoiceList.CurrentRow.Cells("patientid").Value)

            For i As Integer = 0 To TblConsult.Rows.Count - 1
                ConsultAmount = ConsultAmount + CDec(TblConsult.Rows(i).Item("consultprice"))
            Next
            For x As Integer = 0 To TblPara.Rows.Count - 1
                ParaAmount = ParaAmount + CDec(TblPara.Rows(x).Item("servicecharge"))
            Next
            For y As Integer = 0 To TblMedicine.Rows.Count - 1
                MedicineAmount = MedicineAmount + CDec(IIf(TypeOf TblMedicine.Rows(y).Item("totalamount") Is DBNull, "0", TblMedicine.Rows(y).Item("totalamount")))
            Next

            TotalAmount = ConsultAmount + MedicineAmount + ParaAmount
            Me.txttotalusd.Text = FormatCurrency(TotalAmount, 2)
            Me.txtsubtotalusd.Text = FormatCurrency(TotalAmount, 2)
            Me.txtSubtotalriel.Text = TotalAmount * CDbl(Me.txtexchangerate.Text)
        End If
    End Sub

    Private Sub BtnIssueReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIssueReceipt.Click
        If InvoiceList.SelectedItems.Count = 0 Then Exit Sub
        Dim FIssueReceipt As New FormIssueReceipt(Me)
        FIssueReceipt.txtno.Text = InvoiceList.GetRow.Cells("patientno").Value
        FIssueReceipt.txtname.Text = InvoiceList.GetRow.Cells("pname").Value
        FIssueReceipt.txtsex.Text = InvoiceList.GetRow.Cells("pgender").Value
        FIssueReceipt.txtdatebirth.Text = Format(InvoiceList.GetRow.Cells("pAge").Value, "dd/MM/yyyy")
        If FIssueReceipt.ShowDialog() = DialogResult.OK Then
            RefreshInvoice()
        End If

    End Sub
    Public Sub FireButtonEventIssueReceipt()
        Me.BtnIssueReceipt_Click(Nothing, EventArgs.Empty)
    End Sub
    Public Sub FireButtonEventRefresh()
        Me.BtnRefreshIssueReceipt_Click(Nothing, EventArgs.Empty)
    End Sub
    Public Sub FireButtonEventMedicince()
        Me.BtnAddMedicince_Click(Nothing, EventArgs.Empty)
    End Sub
    Public Sub FireButtonEventExam()
        Me.BtnAddParaExam_Click(Nothing, EventArgs.Empty)
    End Sub
    Private Sub txtcash_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcash.GotFocus
        Me.txtcash.SelectAll()
        Me.txtcash.Focus()
    End Sub

    Private Sub txtcash_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcash.LostFocus
        If IsNumeric(Me.txtcash.Text) = False Then
            Me.txtcash.Text = 0
        End If
        Me.txtchange.Text = FormatCurrency(CDbl(Me.txtcash.Text) - CDbl(Me.txttotalusd.Text) + CDbl(Me.txtdiscount.Text), 2)
        Me.txtsubtotalusd.Text = FormatCurrency(CDbl(Me.txttotalusd.Text) - CDbl(Me.txtdiscount.Text), 2)
        Me.txtSubtotalriel.Text = CDbl(Me.txtsubtotalusd.Text) * CDbl(Me.txtexchangerate.Text)
        'Me.txttotalriel.Text = Format(CDbl(Me.txtsubtotalusd.Text) * CDbl(Me.txtexchangerate.Text), "#,###.00 R")
        Me.txtcash.Text = FormatCurrency(CDbl(Me.txtcash.Text), 2)
    End Sub

    Private Sub txtcash_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcash.TextChanged

    End Sub

    Private Sub txtdiscount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdiscount.GotFocus
        Me.txtdiscount.SelectAll()
    End Sub

    Private Sub txtdiscount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdiscount.LostFocus
        If IsNumeric(Me.txtdiscount.Text) = False Then
            Me.txtdiscount.Text = 0
        End If
        Me.txtchange.Text = FormatCurrency(CDbl(Me.txtcash.Text) - CDbl(Me.txttotalusd.Text) + CDbl(Me.txtdiscount.Text), 2)
        Me.txtsubtotalusd.Text = FormatCurrency(CDbl(Me.txttotalusd.Text) - CDbl(Me.txtdiscount.Text), 2)
        Me.txtSubtotalriel.Text = CDbl(Me.txtsubtotalusd.Text) * CDbl(Me.txtexchangerate.Text)
        'Me.txttotalriel.Text = Format(CDbl(Me.txtsubtotalusd.Text) * CDbl(Me.txtexchangerate.Text), "#,###.00 R")
        Me.txtdiscount.Text = FormatCurrency(CDbl(Me.txtdiscount.Text), 2)
    End Sub

    Private Sub txtdiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdiscount.TextChanged

    End Sub

    Private Sub txtexchangerate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtexchangerate.LostFocus
        If IsNumeric(Me.txtexchangerate.Text) = False Then
            Me.txtexchangerate.Text = 4000
        End If
        Me.txtchange.Text = FormatCurrency(CDbl(Me.txtcash.Text) - CDbl(Me.txttotalusd.Text) + CDbl(Me.txtdiscount.Text), 2)
        Me.txtsubtotalusd.Text = FormatCurrency(CDbl(Me.txttotalusd.Text) - CDbl(Me.txtdiscount.Text), 2)
        Me.txtSubtotalriel.Text = CDbl(Me.txtsubtotalusd.Text) * CDbl(Me.txtexchangerate.Text)
        'Me.txttotalriel.Text = Format(CDbl(Me.txtsubtotalusd.Text) * CDbl(Me.txtexchangerate.Text), "#,###.00 R")
        Me.txtexchangerate.Text = CDbl(Me.txtexchangerate.Text)
        'Me.txtexchangerate.Text = Format(CDbl(Me.txtexchangerate.Text), "#,###.00 R")
    End Sub

   

  

    Private Sub UPatientIssueReceipt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        'If e.KeyCode = Keys.F1 Then
        MessageBox.Show("Para")
        'ElseIf e.KeyCode = Keys.F2 Then
        '    MessageBox.Show("Medicine")
        'End If
    End Sub

    Private Sub BtnDeletePreInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeletePreInvoice.Click
        If InvoiceList.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete this Invoice?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_PreInvoice.DeleteInvoiceByID(InvoiceList.GetRow.Cells("pre_id").Value) = 1 Then
                DA_PreConsultation.DeleteByPatientID(InvoiceList.GetRow.Cells("patientid").Value)
                RefreshConsultation()
                RefreshInvoice()
            End If
        End If
    End Sub

    Private Sub InvoiceList_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles InvoiceList.RowDoubleClick
        If InvoiceList.SelectedItems.Count = 0 Then Exit Sub
        Dim FIssueReceipt As New FormIssueReceipt(Me)
        FIssueReceipt.txtno.Text = InvoiceList.GetRow.Cells("patientno").Value
        FIssueReceipt.txtname.Text = InvoiceList.GetRow.Cells("pname").Value
        FIssueReceipt.txtsex.Text = InvoiceList.GetRow.Cells("pgender").Value
        FIssueReceipt.txtdatebirth.Text = InvoiceList.GetRow.Cells("pAge").Value
        If FIssueReceipt.ShowDialog() = DialogResult.OK Then
            RefreshInvoice()
        End If
    End Sub

    Private Sub BtnEditConsultation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditConsultation.Click
        If ConsultationList.SelectedItems.Count = 0 Then Exit Sub
        Dim EdConsult As New EditeConsultationFee()
        EdConsult.LblConsultID.Text = ConsultationList.GetRow.Cells("pre_id").Value
        EdConsult.CboConsult.Text = ConsultationList.GetRow.Cells("consulttype").Value
        If EdConsult.ShowDialog() = DialogResult.OK Then
            RefreshConsultation()
        End If
    End Sub

    
    Private Sub BtnAddParaExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddParaExam.Click
        If InvoiceList.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select patient before add examination.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim FrmAddPara As New InvoiceParaExam(Me)
            FrmAddPara.ShowDialog()
        End If
    End Sub

    Private Sub BtnDeleteParaExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteParaExam.Click
        If ParaList.SelectedItems.Count = 0 Then Exit Sub
        If MsgBox("Are you sure you want to delete this para examination?", MsgBoxStyle.YesNo, "Comfirm Deletion") = MsgBoxResult.Yes Then
            DA_PrePara.DeleteParaExam(CInt(Me.ParaList.CurrentRow.Cells("pre_id").Value))
            RefreshPara()
        End If
    End Sub

    Private Sub BtnAddMedicince_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddMedicince.Click
        If InvoiceList.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select patient before add medicince", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'Dim FrmOrder As New InvoiceMedicine(Me)
            'FrmOrder.ShowDialog()
            Dim AddMedici As New InvoiceMedicineV2(Me)
            AddMedici.ShowDialog()
        End If
    End Sub

    Private Sub BtnDeleteMedicince_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteMedicince.Click
        If Me.OrderList.RowCount >= 1 Then
            If MsgBox("Are you sure you want to delete this order?", MsgBoxStyle.YesNo, "Confirm Delete") Then
                Try
                    DA_PreMedicineOrder.DeleteMedicine(Me.OrderList.CurrentRow.Cells("pre_id").Value)
                Catch ex As Exception

                End Try

                RefreshOrderList()
            End If
        End If
        CalculateTotal()
    End Sub

    Private Sub BtnNewExpend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewExpend.Click
        Dim NewExpend As New FormNewExpend
        NewExpend.ShowDialog()
    End Sub

    Private Sub BtnSetExchangeRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSetExchangeRate.Click
        Dim FExchangeRate As New FormExchangeRate
        FExchangeRate.ShowDialog()
    End Sub

    
    Private Sub BtnFindingInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindingInvoice.Click
        Dim FFindingInvoice As New FindInvoiceDetial
        FFindingInvoice.ShowDialog()
    End Sub
End Class
