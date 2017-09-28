Public Class InvoiceMedicine
    Dim DA_Medicine As New DSPAtientTableAdapters.tblmedicineTableAdapter
    Dim DA_Patient As New DSPAtientTableAdapters.tblpatientTableAdapter
    Dim DA_Store As New DSStoreTableAdapters.tblmedicinestoreTableAdapter
    Dim DA_Transfer As New DSStoreTableAdapters.tbltransferTableAdapter
    Dim DA_Transaction As New DSStoreTableAdapters.tbltransactionTableAdapter
    Dim DA_OrderMedicine As New DSInvoiceTableAdapters.tbl_preinvoice_medicineTableAdapter
    Dim Invoice As UPatientIssueReceipt
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadMedicineToBox()
    End Sub
    Sub New(ByVal InvoicePanel As UPatientIssueReceipt)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Invoice = InvoicePanel
        ' Add any initialization after the InitializeComponent() call.
        LoadMedicineToBox()
    End Sub
    Sub LoadMedicineToBox()
        Me.cbomedicine.DataSource = DA_Medicine.SelectMedicine()
        Me.cbomedicine.ValueMember = DA_Medicine.SelectMedicine.Columns("medicineid").ColumnName
        Me.cbomedicine.DisplayMember = DA_Medicine.SelectMedicine.Columns("medicinename").ColumnName
    End Sub
    Private Sub InvoiceMedicine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        cbomedicine.SelectedIndex = -1
        txtBarCode.Select()
        txtBarCode.Focus()
    End Sub
   
    Sub LoadDataToUnitBox()
        Try
            Me.CboUnit.DataSource = Nothing
            Dim StoreTable As DataTable
            StoreTable = DA_Store.SelectStoreByMedicineID(CInt(Me.cbomedicine.SelectedValue))
            Me.CboUnit.DataSource = StoreTable
            Me.CboUnit.ValueMember = StoreTable.Columns("unitname").ColumnName
            Me.CboUnit.DisplayMember = StoreTable.Columns("unitname").ColumnName
            'Me.CboUnit.SelectedIndex = -1
            txtorderqty.Text = ""
            txtorderqty.Select()
            txtorderqty.Focus()
        Catch ex As Exception

        End Try
      
    End Sub

    

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub txtqty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtorderqty.KeyPress
        SetDisableKeyString(e)
    End Sub

    
    Private Sub CboUnit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboUnit.SelectedIndexChanged
        Try
            Dim StoreTable As DataTable
            StoreTable = DA_Store.SelectStoreByMedicineIDAndUnitname(CInt(Me.cbomedicine.SelectedValue), Me.CboUnit.SelectedValue.ToString)
            If StoreTable.Rows.Count >= 1 Then
                Me.txtcurrentqty.Text = StoreTable.Rows(0).Item("qty")
                TxtPrice.Text = StoreTable.Rows(0).Item("last_price")
                ' Me.txtorderqty.Focus()
            End If
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub cbomedicine_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbomedicine.SelectedIndexChanged
        LoadDataToUnitBox()
        'Me.txtcurrentqty.Text = ""
    End Sub

    
    Sub SelectItemName(ByVal BarCode As String)
        Dim tblMedicine As DataTable = DA_Medicine.SelectByMedicinceCode(BarCode)
        For Each rows As DataRow In tblMedicine.Rows
            'MessageBox.Show(rows("medicinename"))
            cbomedicine.SelectedValue = rows("medicineid")
        Next

    End Sub

    Private Sub txtBarCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBarCode.GotFocus
        txtBarCode.SelectAll()
    End Sub

    Private Sub txtBarCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            SelectItemName(txtBarCode.Text)
        End If
    End Sub

    Private Sub InvoiceMedicine_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            If ValidateCombobox(cbomedicine, "", ErrValidate) = False Then Exit Sub
            If ValidateCombobox(CboUnit, "", ErrValidate) = False Then Exit Sub
            If ValidateTextField(txtorderqty, "", ErrValidate) = False Then Exit Sub

           
            Dim UnitPrice As Double
            Dim MedicineDataTable As New DataTable
            Dim StoreTable As New DataTable
            StoreTable = DA_Store.SelectStoreByMedicineIDAndUnitname(CInt(Me.cbomedicine.SelectedValue), Me.CboUnit.SelectedValue.ToString)

            ''Check Quantiy In Stock
            ''1. If sell in main unit and the current qty is not enough to sell
            If CInt(Me.txtorderqty.Text) > CInt(Me.txtcurrentqty.Text) Then
                'If Me.CboUnit.Text = "Main unit" Then
                MsgBox("The order quantity can not be greater than the current quantity", MsgBoxStyle.Exclamation, "Insufficent Quantity")
                Me.txtorderqty.SelectAll()
                Me.txtorderqty.Focus()
                Exit Sub
                'Else
                '    Dim ToMain As Double
                '    Dim CurMain As Integer
                '    Dim MainStoreTable As New DataTable
                '    MainStoreTable = DA_Store.SelectByMedicineIDAndUnitType(CInt(Me.cbomedicine.SelectedValue), "Main unit")
                '    Dim OrderQty As Integer = CInt(Me.txtorderqty.Text)
                '    Dim RatioQty As Integer = CInt(StoreTable.Rows(0).Item("ratioqty").ToString)
                '    If OrderQty Mod RatioQty > 0 Then
                '        ToMain = (OrderQty \ RatioQty) + 1
                '    Else
                '        ToMain = OrderQty / RatioQty
                '    End If

                '    CurMain = CInt(MainStoreTable.Rows(0).Item("qty").ToString)
                '    If ToMain > CurMain Then
                '        MsgBox("Insufficent quantity ", MsgBoxStyle.Exclamation, "Insufficent Quantity")
                '        Exit Sub
                '    Else
                '        Dim LastMainQty As Integer
                '        Dim LastSubQty As Integer
                '        LastMainQty = CurMain - ToMain
                '        LastSubQty = CInt(Me.txtcurrentqty.Text) + RatioQty * ToMain
                '        'UPDATE Store
                '        DA_Store.UpdateQuantity(LastMainQty, CInt(MainStoreTable.Rows(0).Item("store_id").ToString))
                '        DA_Store.UpdateQuantity(LastSubQty, CInt(StoreTable.Rows(0).Item("store_id").ToString))
                '        'Record Transfer
                '        DA_Transfer.InsertTransfer(CInt(MainStoreTable.Rows(0).Item("store_id").ToString), CInt(StoreTable.Rows(0).Item("store_id").ToString), CInt(Me.cbomedicine.SelectedValue), FormatDateTime(Now, DateFormat.ShortDate), ToMain)
                '        'Record Transaction
                '        DA_Transaction.InsertTransaction(CInt(MainStoreTable.Rows(0).Item("store_id").ToString), 1, FormatDateTime(Now, DateFormat.ShortDate), CInt(MainStoreTable.Rows(0).Item("qty").ToString), ToMain * -1, LastMainQty)
                '        DA_Transaction.InsertTransaction(CInt(StoreTable.Rows(0).Item("store_id").ToString), 2, FormatDateTime(Now, DateFormat.ShortDate), CInt(Me.txtcurrentqty.Text), RatioQty * ToMain, LastSubQty)
                '    End If
            End If

            UnitPrice = CDbl(StoreTable.Rows(0).Item("last_price"))
            DA_OrderMedicine.InsertMedicine(CLng(Me.Invoice.InvoiceList.CurrentRow.Cells("patientid").Value), CInt(Me.cbomedicine.SelectedValue), Me.CboUnit.SelectedValue.ToString, CInt(Me.txtorderqty.Text), UnitPrice)
            'MsgBox("One medicine order was added", MsgBoxStyle.Information, "Successfully Added")
            Me.txtorderqty.Text = ""
            Me.cbomedicine.SelectedIndex = -1
            Me.CboUnit.SelectedIndex = -1
            Invoice.RefreshOrderList()
            Invoice.CalculateTotal()
            CleanForm()
        End If
    End Sub
    Sub CleanForm()
        
        cbomedicine.SelectedIndex = -1
        CboUnit.SelectedIndex = -1
        TxtPrice.Text = "0"
        txtcurrentqty.Text = "0"
        txtorderqty.Text = ""
        txtBarCode.SelectAll()
        txtBarCode.Text = ""
        txtBarCode.Focus()
    End Sub

    
   
    
End Class