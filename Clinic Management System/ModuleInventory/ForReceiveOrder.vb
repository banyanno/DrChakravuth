Imports Janus.Windows.GridEX

Public Class ForReceiveOrder
    Dim TableReceiveTem As DataTable = New DSInventoryClinic.ReceiveItemTemDedtailDataTable
    
    Dim DASupplier As New DSInventoryClinicTableAdapters.tblVenderTableAdapter

    Dim DAReceiveMaster As New DSInventoryClinicTableAdapters.ITEM_RECIEVE_MASTERTableAdapter
    Dim DAReceiveDetail As New DSInventoryClinicTableAdapters.ITEM_RECIEVE_DETIALTableAdapter


    ' Update Centrall Inventory system data set
    Dim DAItem As New DSInventoryClinicTableAdapters.tblItemTableAdapter
    Dim DACentralItem As New DSInventoryClinicTableAdapters.tblCentralInventoryTableAdapter
    Dim DABeginBalance As New DSInventoryClinicTableAdapters.tblBeginBalanceTraceTableAdapter
    Dim DACaVander As New DSInventoryClinicTableAdapters.CARITAS_REQ_ITEM_PROVIDER_INFOTableAdapter
    Dim DADate As New DSInventoryClinicTableAdapters.DateSeverTableAdapter
    Dim DASupplierTracking As New DSInventoryClinicTableAdapters.tblVendorItemSupplyStatusTableAdapter
    Dim DAItemExpire As New DSInventoryClinicTableAdapters.ITEM_EXPIREDATE_DETAILTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboItem
            .DataSource = DAItem.GetData
            .ValueMember = "ItemID"
            .DisplayMember = "ItemName"
            .SelectedIndex = -1
        End With
        With CboSupplier
            .DataSource = DASupplier.SelectVender
            .ValueMember = "VenderID"
            .DisplayMember = "VenderName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddItem.Click
        If ValidateCombobox(CboItem, "", ErrReceive) = False Then Exit Sub
        If ValidateTextField(TxtQTYReceive, "", ErrReceive) = False Then Exit Sub
        If ValidateTextField(TxtItemCost, "", ErrReceive) = False Then Exit Sub
        If ValidateDateTimePicker(DateExpiry, "", ErrReceive) = False Then Exit Sub

        AddReceiveTem()
        CalculateTotalReceive(TableReceiveTem, EmptyString(TxtVATPercent.Text), EmptyString(TxtDeposit.Text))
    End Sub
    Function CheckValue(ByVal myTable As DataTable, ByVal columnName As String, ByVal searchValue As String) As Boolean
        For Each row As DataRow In myTable.Rows
            ' MsgBox(row(columnName))
            If row(columnName) = searchValue Then Return True
        Next
        Return False
    End Function
    Private Sub AddReceiveTem()
        If CheckValue(TableReceiveTem, "ITEM_ID", CboItem.SelectedValue) = True Then
            MessageBox.Show("The Item existing in list receive! pls check again.", "Receive", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboItem.Focus()
            CboItem.SelectAll()
            Exit Sub
        End If
        Try
            Dim Dr As DataRow
            Dr = TableReceiveTem.NewRow
            Dr("RECEIVETEM_ID") = CboItem.SelectedValue
            Dr("ITEM_ID") = CboItem.SelectedValue
            Dr("ITEM_NAME") = CboItem.Text

            Dr("ITEM_MEASURE") = txtUnitName.Text  'TxtUnitQTY.Text & " " & lblUnitName.Text
            Dr("UNIT_QTY_UNIT_RECIEVE") = TxtUnitQTYReceive.Text
            Dr("ITEM_QTY") = TxtQTYReceive.Text ' save to corrent database
            Dr("ITEM_PRICE") = TxtItemCost.Text
            'Dr("UNIT_NAME") =    ' save unit name


            Dr("ITEM_EXPIRYDATE") = IIf(DateExpiry.Checked = True, DateExpiry.Value, Nothing)
            Dr("TOTAL_AMOUNT") = CDbl(TxtUnitQTYReceive.Text) * CDbl(TxtItemCost.Text)
            TableReceiveTem.Rows.Add(Dr)
        Catch ex As Exception
            MessageBox.Show("Not correct Item name. Please check item again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboItem.Select()
            CboItem.Focus()
        End Try

        RefreshDGTem()
        CleanItemReceived()
    End Sub
    Private Sub CleanItemReceived()
        CboItem.SelectedIndex = -1
        TxtQTYReceive.Text = ""
        TxtItemCost.Text = ""
        TxtUnitQTY.Text = ""
        TxtUnitQTYReceive.Text = ""
        txtUnitName.Text = ""
        DateExpiry.Checked = False
    End Sub
    Private Sub DeleteRow(ByVal TblTem As DataTable, ByVal filter As String)
        Try
            TableReceiveTem.EndLoadData()
            Dim ndx As Int32
            Dim rows = TableReceiveTem.Select("RECEIVETEM_ID=" & filter)
            If rows.Count > 0 Then
                ndx = TableReceiveTem.Rows.IndexOf(rows(0))
                TableReceiveTem.Rows(ndx).Delete()
                ' TblTem.AcceptChanges()
                ' MsgBox(ndx)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Try
        '    'TblTem.Select("RECEIVETEM_ID=" & filter)
        '    'TblTem.Rows(0).Delete()
        '    'TblTem.Rows.Find(filter).Delete()

        '    TblTem.AcceptChanges()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
    Private Sub RefreshDGTem()
        GridListItemReceive.Refetch()
        GridListItemReceive.Refresh()
        GridListItemReceive.DataSource = TableReceiveTem
    End Sub
    Private Sub CalculateTotalReceive(ByVal tblReceiveTem As DataTable, ByVal Tax As Double, ByVal Diposit As Double)
        Try
            Dim TotalExcludeVAT As Double = 0
            Dim TotalAmountDue As Double = 0
            For Each Row As DataRow In tblReceiveTem.Rows
                TotalExcludeVAT = TotalExcludeVAT + CDbl(Row("TOTAL_AMOUNT"))
            Next
            TxtTotalAmoutExcludVAT.Text = ((TotalExcludeVAT + EmptyString(TxtVAT.Text)) - Diposit)
            TxtVAT.Text = ((Tax / 100) * TotalExcludeVAT)
            TxtTotalAmountIncludVAT.Text = (TotalExcludeVAT + EmptyString(TxtVAT.Text))
            TxtTotalAmounDue.Text = TotalExcludeVAT

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub TxtQTYReceive_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtQTYReceive.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtItemPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtItemCost.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveItem.Click

        If GridListItemReceive.SelectedItems.Count = 0 Then Exit Sub
        DeleteRow(TableReceiveTem, GridListItemReceive.GetRow.Cells("RECEIVETEM_ID").Value.ToString)
        RefreshDGTem()
        CalculateTotalReceive(TableReceiveTem, EmptyString(TxtVATPercent.Text), EmptyString(TxtDeposit.Text))
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub TxtVATPercent_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtVATPercent.KeyUp
        CalculateTotalReceive(TableReceiveTem, EmptyString(TxtVATPercent.Text), EmptyString(TxtDeposit.Text))
    End Sub

    Private Sub TxtDeposit_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDeposit.KeyUp
        CalculateTotalReceive(TableReceiveTem, EmptyString(TxtVATPercent.Text), EmptyString(TxtDeposit.Text))
    End Sub

    Private Sub TxtVATPercent_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtVATPercent.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtDeposit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDeposit.KeyPress
        SetDisableKeyString(e)
    End Sub


    Private Sub BtnAddMoreItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddMoreItem.Click
        Dim FItem As New frmItem
        If FItem.ShowDialog() = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddMoreSupplyer.Click
        Dim FSupplier As New frmVender
        If FSupplier.ShowDialog = Windows.Forms.DialogResult.OK Then
            With CboSupplier
                .DataSource = DASupplier.SelectVender
                .ValueMember = "VenderID"
                .DisplayMember = "VenderName"
                .SelectedIndex = -1
            End With
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateCombobox(CboSupplier, "", ErrReceive) = False Then Exit Sub
        If ValidateTextField(TxtInvoiceReferenceNo, "", ErrReceive) = False Then Exit Sub
        If ValidateDateTimePicker(DateInvoiceReference, "", ErrReceive) = False Then Exit Sub
        If ValidateDateTimePicker(DateInvoiceDueDate, "", ErrReceive) = False Then Exit Sub
        If GridListItemReceive.SelectedItems.Count = 0 Then
            MessageBox.Show("Please add item before save!", "Receive", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new item receive?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DAReceiveMaster.InsertItemReceiveMaster(Now.Date, TxtInvoiceReferenceNo.Text, DateInvoiceReference.Value.Date, DateInvoiceDueDate.Value.Date, TxtTeam.Text, CboSupplier.SelectedValue, CboSupplier.Text, CboSupplier.Text, EmptyString(TxtTotalAmoutExcludVAT.Text), EmptyString(TxtVAT.Text), EmptyString(TxtTotalAmountIncludVAT.Text), EmptyString(TxtDeposit.Text), EmptyString(TxtTotalAmounDue.Text), TxtReceiveNote.Text, USER_NAME, USER_ID) = 1 Then
                    Dim LastInsertMasterID As Double = DAReceiveMaster.GetLastInsert
                    For Each GROWS As Janus.Windows.GridEX.GridEXRow In GridListItemReceive.GetDataRows

                        DAReceiveDetail.InsertNewItemReceiveDetial(LastInsertMasterID, CDbl(GROWS.Cells("ITEM_ID").Value), GROWS.Cells("ITEM_NAME").Value, GROWS.Cells("ITEM_MEASURE").Value, GROWS.Cells("ITEM_EXPIRYDATE").Value, CInt(GROWS.Cells("ITEM_QTY").Value), CDbl(GROWS.Cells("ITEM_PRICE").Value), CDbl(GROWS.Cells("TOTAL_AMOUNT").Value), TxtInvoiceReferenceNo.Text, CDbl(GROWS.Cells("UNIT_QTY_UNIT_RECIEVE").Value))
                    Next
                End If
                UpdateCentralInventory(Me.GridListItemReceive)
                MessageBox.Show("Successfull receive product from supplier!", "Received", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If

    End Sub
    Private Sub UpdateCentralInventory(ByVal ListOfItem As GridEX)
        For Each gdrows As GridEXRow In ListOfItem.GetDataRows
            Dim ItemID As Double = 0
            ItemID = gdrows.Cells("ITEM_ID").Value
            Dim QTY As Double = 0
            QTY = gdrows.Cells("ITEM_QTY").Value
            Dim CostItem As Double = 0
            CostItem = gdrows.Cells("ITEM_PRICE").Value
            Dim DateExpire As Date = Now.Date
            DateExpire = gdrows.Cells("ITEM_EXPIRYDATE").Value

            Dim BeginBalance As Double = 0
            Dim LastQTY As Double = 0

            'Update stock in central inventory.
            LastQTY = CDbl(DACentralItem.SelectLastQtyStock(ItemID))

            BeginBalance = LastQTY + QTY
            DACentralItem.UpdateCentralStockByItem(BeginBalance, ItemID)

            'Update last Cost item of item 
            DAItem.UpdateCostItem(CostItem, ItemID)

            'Begin Item qty balance
            Dim tblbeginQTY As DataTable = DABeginBalance.SelectBeginingBalanceItem(DADate.SelectDateServer().Value.Date, MAIN_STOCK_DEPART_ID, ItemID)
            If tblbeginQTY.Rows.Count = 0 Then
                DABeginBalance.InsertNewBeginingItemBalance(MAIN_STOCK_DEPART_ID, DADate.SelectDateServer.Value.Date, LastQTY, ItemID)
            End If
            'Insert tracking item expier date
            DAItemExpire.InsertNewExpireDate(ItemID, QTY, 0, 0, 0, MAIN_STOCK_DEPART_ID, CInt(CboSupplier.SelectedValue), DateExpire.Date)
            'Tracking vender receive by item
            DASupplierTracking.InsertItemVenderSupplier(CboSupplier.SelectedValue, ItemID, CostItem, 1, QTY, Nothing, Nothing)
        Next
    End Sub

    Private Sub CboItem_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboItem.SelectedValueChanged
        
    End Sub

    Private Sub TxtUnitQTYReceive_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUnitQTYReceive.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtUnitQTYReceive_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtUnitQTYReceive.KeyUp
        TxtQTYReceive.Text = EmptyString(TxtUnitQTY.Text) * EmptyString(TxtUnitQTYReceive.Text)
    End Sub

    Private Sub CboItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboItem.SelectedIndexChanged
        Try

            For Each rows As DataRow In DAItem.SelectByItem(CInt(CboItem.SelectedValue))
                'lblUnitName.Text = rows("itemunitnam")
                TxtUnitQTY.Text = rows("subunit_qty")
                txtUnitName.Text = rows("mainunit_qty") & " " & rows("mainunit") & " " & rows("subunit_qty") & " " & rows("subunit")
            Next

        Catch ex As Exception
            TxtUnitQTY.Text = ""
            txtUnitName.Text = ""
            TxtQTYReceive.Text = ""
            TxtItemCost.Text = 0
            'CleanItemReceived()
        End Try
    End Sub

    Private Sub ForReceiveOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class