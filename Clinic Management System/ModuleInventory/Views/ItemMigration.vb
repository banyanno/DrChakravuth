Imports Janus.Windows.GridEX

Public Class ItemMigration
    Dim DAListItem As New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
    Dim DAItem As New DSInventoryClinicTableAdapters.tblItemTableAdapter
    Dim DACentralItem As New DSInventoryClinicTableAdapters.tblCentralInventoryTableAdapter
    Dim DAItemPrice As New DSInventoryClinicTableAdapters.tblItemPriceTableAdapter
    Dim DABeginBalance As New DSInventoryClinicTableAdapters.tblBeginBalanceTraceTableAdapter
    Dim DACaVander As New DSInventoryClinicTableAdapters.CARITAS_REQ_ITEM_PROVIDER_INFOTableAdapter
    Dim DADate As New DSInventoryClinicTableAdapters.DateSeverTableAdapter
    Dim DASupplierTracking As New DSInventoryClinicTableAdapters.tblVendorItemSupplyStatusTableAdapter
    Dim DAItemExpire As New DSInventoryClinicTableAdapters.ITEM_EXPIREDATE_DETAILTableAdapter
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        GridItemUsed.DataSource = DAListItem.GetData
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
       
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Dim checkRows() As Janus.Windows.GridEX.GridEXRow
            checkRows = GridItemUsed.GetCheckedRows
            If checkRows.Length = 0 Then
                MessageBox.Show("Please select item in the list used.", "Selected", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                If MessageBox.Show("Do you want add these item to list?", "add", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    For Each row As Janus.Windows.GridEX.GridEXRow In checkRows
                        'Dim row1 As DataRow = TblBarcodePrint.NewRow
                        'row1("BarcodeNo") = row.Cells("BarcodeNo").Value
                        'row1("Column") = 10
                        'row1("Rows") = 5
                        'TblBarcodePrint.Rows.Add(row1)

                        'itemName = row.Cells("ItemName").Value

                        'Dim dataRow As DataRow = ItemRequestDT.NewRow
                        'dataRow("ItemID") = row.Cells("ItemID").Value
                        'dataRow("ItemName") = row.Cells("ItemName").Value
                        'dataRow("CateName") = row.Cells("CateName").Value
                        'dataRow("ItemUnitName") = row.Cells("ItemUnitName").Value
                        'dataRow("ContainerName") = row.Cells("ContainerName").Value
                        'dataRow("cInStock") = 0
                        'dataRow("Quantity") = row.Cells("TotalItemUsed").Value
                        'dataRow("Barcode") = row.Cells("Barcode").Value
                        'ItemRequestDT.Rows.Add(dataRow)
                        ' MessageBox.Show(row.Cells("ItemName").Value & " " & row.Cells("Qty").Value & "  " & row.Cells("Price").Value)
                        Dim ItemID As Double = 0
                        ItemID = row.Cells("ItemID").Value
                        Dim QTY As Double = 0
                        QTY = row.Cells("Qty").Value
                        Dim CostItem As Double = 0
                        CostItem = row.Cells("Price").Value
                        Dim DateExpire As Date = Now.Date
                        DateExpire = Now.Date

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
                        DAItemExpire.InsertNewExpireDate(ItemID, QTY, 0, 0, 0, MAIN_STOCK_DEPART_ID, 1, DateExpire.Date)
                        'Tracking vender receive by item
                        DASupplierTracking.InsertItemVenderSupplier(1, ItemID, CostItem, 1, QTY, Nothing, Nothing)
                        DAItemPrice.InsertNewPrice(ItemID, CostItem, True, False, True, 5, Now.Date)
                    Next
                    MessageBox.Show("Successful migration!")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub UpdateCentralInventory(ByVal ListOfItem As GridEX)
        For Each gdrows As GridEXRow In ListOfItem.GetDataRows
            'Dim ItemID As Double = 0
            'ItemID = gdrows.Cells("ITEM_ID").Value
            'Dim QTY As Double = 0
            'QTY = gdrows.Cells("ITEM_QTY").Value
            'Dim CostItem As Double = 0
            'CostItem = gdrows.Cells("ITEM_PRICE").Value
            'Dim DateExpire As Date = Now.Date
            'DateExpire = gdrows.Cells("ITEM_EXPIRYDATE").Value

            'Dim BeginBalance As Double = 0
            'Dim LastQTY As Double = 0

            ''Update stock in central inventory.
            'LastQTY = CDbl(DACentralItem.SelectLastQtyStock(ItemID))

            'BeginBalance = LastQTY + QTY
            'DACentralItem.UpdateCentralStockByItem(BeginBalance, ItemID)

            ''Update last Cost item of item 
            'DAItem.UpdateCostItem(CostItem, ItemID)

            ''Begin Item qty balance
            'Dim tblbeginQTY As DataTable = DABeginBalance.SelectBeginingBalanceItem(DADate.SelectDateServer().Value.Date, MAIN_STOCK_DEPART_ID, ItemID)
            'If tblbeginQTY.Rows.Count = 0 Then
            '    DABeginBalance.InsertNewBeginingItemBalance(MAIN_STOCK_DEPART_ID, DADate.SelectDateServer.Value.Date, LastQTY, ItemID)
            'End If
            ''Insert tracking item expier date
            'DAItemExpire.InsertNewExpireDate(ItemID, QTY, 0, 0, 0, MAIN_STOCK_DEPART_ID, CInt(CboSupplier.SelectedValue), DateExpire.Date)
            ''Tracking vender receive by item
            'DASupplierTracking.InsertItemVenderSupplier(CboSupplier.SelectedValue, ItemID, CostItem, 1, QTY, Nothing, Nothing)
        Next
    End Sub

    Private Sub GridItemUsed_CellEdited(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridItemUsed.CellEdited
        'MessageBox.Show(e.Column.GridEX.GetRow.Cells("Qty").Value.ToString)
        'If e.Column.Key.ToString = "Check" Then
        '    Exit Sub
        '    'e.Column.GridEX.GetRow.Cells("Qty").Row.BeginEdit()

        'End If
        If e.Column.Key.ToString = "Qty" Then
            If e.Column.GridEX.GetRow.Cells("Qty").Value Is Nothing Then
                Exit Sub
            End If
            If CheckForAlphaCharacters(e.Column.GridEX.GetRow.Cells("Qty").Value.ToString) = True Then
                MessageBox.Show("The qty can not enter charactor.", "Qty", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Column.GridEX.GetRow.BeginEdit()
                e.Column.GridEX.GetRow.Cells("Qty").Value = Nothing
                e.Column.GridEX.GetRow.EndEdit()
            Else

            End If
        End If
        If e.Column.Key.ToString = "Price" Then
            If e.Column.GridEX.GetRow.Cells("Price").Value Is Nothing Then
                Exit Sub
            End If
            If CheckForAlphaCharacters(e.Column.GridEX.GetRow.Cells("Price").Value) = True Then
                MessageBox.Show("The price can not enter charactor.", "Price", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Column.GridEX.GetRow.BeginEdit()
                e.Column.GridEX.GetRow.Cells("Price").Value = Nothing
                e.Column.GridEX.GetRow.EndEdit()
            Else

            End If
        End If
       
        
    End Sub

    Function CheckForAlphaCharacters(ByVal StringToCheck As String) As Boolean
        'If StringToCheck Is Nothing Then
        'Return True
        'Else
        For i = 0 To StringToCheck.Length - 1
            If Char.IsLetter(StringToCheck.Chars(i)) Then
                Return True
            End If
        Next

        Return False
        'End If
        'Return true if all elements are characters
    End Function
End Class
