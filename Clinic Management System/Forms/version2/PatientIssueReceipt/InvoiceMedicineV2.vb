Public Class InvoiceMedicineV2

    Dim DAListItem As New DSInventoryClinicTableAdapters.tblItemTableAdapter
    Dim DAListItemPrice As New DSInventoryClinicTableAdapters.tblItemPriceTableAdapter
    Dim DACentralQty As New DSInventoryClinicTableAdapters.tblCentralInventoryTableAdapter
    Dim Invoice As UPatientIssueReceipt
    Public Sub New(ByVal Invoice As UPatientIssueReceipt)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Invoice = Invoice
        With cboItem
            .DataSource = DAListItem.GetData
            .ValueMember = "ItemID"
            .DisplayMember = "ItemName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub CboItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboItem.SelectedIndexChanged
        Try
            Dim tblItemDetial As DataTable = DAListItem.SelectByItem(cboItem.SelectedValue)
            For Each rows As DataRow In tblItemDetial.Rows
                TxtBarCode.Text = rows("Barcode")
                TxtCurrentQTY.Text = rows("UnitPrice")
                LblMainUnitQTY.Text = rows("mainunit_qty")
                LblSubUnitQTY.Text = rows("subunit_qty")
            Next
            TxtCurrentQTY.Text = DACentralQty.SelectLastQTYItemByDept(cboItem.SelectedValue, MAIN_STOCK_DEPART_ID)
            TxtMainStockUnit.Text = (CDbl(TxtCurrentQTY.Text) / CDbl(LblSubUnitQTY.Text))

            TxtPrice.Text = CDbl(DAListItemPrice.SelectLastItemPriceByItemID(CInt(cboItem.SelectedValue)))
            TxtSaleQty.Focus()
            TxtSaleQty.Select()
            TxtSaleQty.SelectAll()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            TxtBarCode.Text = ""
            txtUnitName.Text = ""
            TxtCurrentQTY.Text = ""
            LblMainUnitQTY.Text = ""
            LblSubUnitQTY.Text = ""
            TxtCurrentQTY.Text = ""
            TxtMainStockUnit.Text = ""

            TxtPrice.Text = ""
            'TxtSaleQty.Focus()
            'TxtSaleQty.Select()
            'TxtSaleQty.SelectAll()
            cboItem.Focus()
            cboItem.Select()
            cboItem.SelectAll()
        End Try
    End Sub

    Private Sub TxtSaleQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSaleQty.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub InvoiceMedicineV2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            If ValidateCombobox(cboItem, "", ErrCheckItem) = False Then Exit Sub
            If ValidateTextField(TxtBarCode, "", ErrCheckItem) = False Then Exit Sub
            If ValidateTextField(TxtCurrentQTY, "", ErrCheckItem) = False Then Exit Sub
            If ValidateTextField(TxtPrice, "", ErrCheckItem) = False Then Exit Sub
           
            If ValidateTextField(TxtSaleQty, "", ErrCheckItem) = False Then Exit Sub
            If ValidateTextField(txtUnitName, "", ErrCheckItem) = False Then
                txtUnitName.Select()
                txtUnitName.SelectAll()
                txtUnitName.Focus()
                Exit Sub
            End If
            If TxtSaleQty.Text = "0" Then
                MessageBox.Show("Can not sale qty 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtSaleQty.Focus()
                TxtSaleQty.Select()
                TxtSaleQty.SelectAll()
                Exit Sub
            End If
            If CInt(EmptyString(Me.TxtSaleQty.Text)) > CInt(EmptyString(Me.TxtCurrentQTY.Text)) Then
                MessageBox.Show("The order quantity can not be greater than the current quantity", "Insufficent Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtSaleQty.Focus()
                TxtSaleQty.Select()
                TxtSaleQty.SelectAll()
                Exit Sub
            End If
            Dim DA_OrderMedicine As New DSInvoiceTableAdapters.tbl_preinvoice_medicineTableAdapter
            DA_OrderMedicine.InsertMedicine(CLng(Me.Invoice.InvoiceList.CurrentRow.Cells("patientno").Value), CInt(Me.cboItem.SelectedValue), txtUnitName.Text, EmptyString(TxtSaleQty.Text), CDbl(TxtPrice.Text), cboItem.Text, CDbl(EmptyString(TxtPrice.Text)) * CDbl(EmptyString(TxtSaleQty.Text)))
            'MsgBox("One medicine order was added", MsgBoxStyle.Information, "Successfully Added")
            TxtSaleQty.Text = ""
            Me.cboItem.SelectedIndex = -1

            Invoice.RefreshOrderList()
            Invoice.CalculateTotal()
            CleanInverface()
        End If
    End Sub
    Private Sub CleanInverface()
        cboItem.SelectedIndex = -1
        TxtBarCode.Text = ""
        txtUnitName.Text = ""
        TxtCurrentQTY.Text = "0"
        TxtPrice.Text = "0"
        TxtSaleQty.Text = "0"
        LblMainUnitQTY.Text = "0"
        LblSubUnitQTY.Text = "0"
        cboItem.Focus()
        cboItem.Select()
        cboItem.SelectAll()
    End Sub

    Dim DA_Unite As New DSItemUnitTableAdapters.tblItemUnitTableAdapter
    Private Sub InvoiceMedicineV2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tblUnit As DataTable = DA_Unite.GetData
        For Each rows In tblUnit.Rows
            txtUnitName.AutoCompleteCustomSource.Add(rows("ItemUnitName"))
        Next
        cboItem.Select()
        cboItem.Focus()
    End Sub
End Class