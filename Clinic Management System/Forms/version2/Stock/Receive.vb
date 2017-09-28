Public Class Receive
    Dim StockPanel As UCStock
    Dim DA_Receive As New DSStoreTableAdapters.tblreceiveTableAdapter
    Dim DA_Medicine As New DSPAtientTableAdapters.tblmedicineTableAdapter
    Dim DA_Store As New DSStoreTableAdapters.tblmedicinestoreTableAdapter
    Dim DA_Transaction As New DSStoreTableAdapters.tbltransactionTableAdapter

    Sub New(ByVal UStock As UCStock)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        StockPanel = UStock
        ' Add any initialization after the InitializeComponent() call.
        Me.cbomedicine.DataSource = DA_Medicine.SelectMedicine
        Me.cbomedicine.ValueMember = DA_Medicine.SelectMedicine.Columns("medicineid").ColumnName
        Me.cbomedicine.DisplayMember = DA_Medicine.SelectMedicine.Columns("medicinename").ColumnName
        Me.cbomedicine.SelectedIndex = -1
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnReceive_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnReceive.Click
        If ValidateCombobox(cbomedicine, "", ErrMenu) = False Then Exit Sub
        If ValidateTextField(txtreceivedqty, "", ErrMenu) = False Then Exit Sub

        If IsNumeric(Me.txtreceivedqty.Text) = False Then
            MsgBox("Please input received quantity as number only", MsgBoxStyle.Exclamation, "Invalid Number")
            Me.txtreceivedqty.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Do you want to received Item?", "Received", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Dim MainStoreTable As New DataTable
                Dim SubStoreTable As New DataTable
                MainStoreTable = DA_Store.SelectByMedicineIDAndUnitType(CInt(Me.cbomedicine.SelectedValue), "Main unit")
                SubStoreTable = DA_Store.SelectByMedicineIDAndUnitType(CInt(Me.cbomedicine.SelectedValue), "Sub unit")

                ' Main unit 
                DA_Receive.InsertReceive(CInt(MainStoreTable.Rows(0).Item("store_id")), "Receive", FormatDateTime(Now, DateFormat.ShortDate), CDec(Me.txtreceivedqty.Text))
                DA_Store.UpdateQuantity(CDec(MainStoreTable.Rows(0).Item("qty")) + CDec(Me.txtreceivedqty.Text), CInt(MainStoreTable.Rows(0).Item("store_id")))
                DA_Transaction.InsertTransaction(CLng(MainStoreTable.Rows(0).Item("store_id")), 2, FormatDateTime(Now, DateFormat.ShortDate), CDec(MainStoreTable.Rows(0).Item("qty")), CDec(Me.txtreceivedqty.Text), CDec(MainStoreTable.Rows(0).Item("qty")) + CDec(Me.txtreceivedqty.Text))

                ' Sub unit 
                Dim SubRecQty As Decimal
                For i = 0 To SubStoreTable.Rows.Count - 1
                    SubRecQty = CDec(Me.txtreceivedqty.Text) * CDec(SubStoreTable.Rows(i).Item("ratioqty"))
                    DA_Receive.InsertReceive(CInt(SubStoreTable.Rows(i).Item("store_id")), "Receive", FormatDateTime(Now, DateFormat.ShortDate), SubRecQty)
                    DA_Store.UpdateQuantity(CDec(SubStoreTable.Rows(i).Item("qty")) + SubRecQty, CInt(SubStoreTable.Rows(i).Item("store_id")))
                    DA_Transaction.InsertTransaction(CLng(SubStoreTable.Rows(i).Item("store_id")), 2, FormatDateTime(Now, DateFormat.ShortDate), CDec(SubStoreTable.Rows(i).Item("qty")), SubRecQty, CDec(SubStoreTable.Rows(i).Item("qty")) + SubRecQty)
                Next
                MsgBox("The store has been received successfully", MsgBoxStyle.Information, "Receipt Made")
                Me.StoreList.DataSource = DA_Store.SelectStoreByMedicineID(CInt(Me.cbomedicine.SelectedValue))
                StockPanel.FilByName(cbomedicine.Text)
            End If

        End If
    End Sub

    Private Sub cbomedicine_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbomedicine.SelectedIndexChanged
        Try
            Me.StoreList.DataSource = DA_Store.SelectStoreByMedicineID(CInt(Me.cbomedicine.SelectedValue))
        Catch ex As Exception

        End Try
    End Sub

   
End Class