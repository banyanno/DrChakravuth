Public Class NewStore
    Dim StockPanel As StoreManagement
    Dim DA_Medicine As New DSPAtientTableAdapters.tblmedicineTableAdapter
    Dim DA_Unit As New DSStoreTableAdapters.tblunitTableAdapter
    Dim DA_Store As New DSStoreTableAdapters.tblmedicinestoreTableAdapter
    Dim DA_Receive As New DSStoreTableAdapters.tblreceiveTableAdapter
    Dim DA_Transaction As New DSStoreTableAdapters.tbltransactionTableAdapter


    Sub New(ByVal UStock As StoreManagement)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        StockPanel = UStock
        ' Add any initialization after the InitializeComponent() call.
        Me.cbomedicine.DataSource = DA_Medicine.SelectMedicine
        Me.cbomedicine.ValueMember = DA_Medicine.SelectMedicine.Columns("medicineid").ColumnName
        Me.cbomedicine.DisplayMember = DA_Medicine.SelectMedicine.Columns("medicinename").ColumnName
        Me.cbomedicine.SelectedIndex = -1

        Me.cbounit.DataSource = DA_Unit.SelectUnit
        Me.cbounit.ValueMember = DA_Unit.SelectUnit.Columns("unit_name").ColumnName
        Me.cbounit.DisplayMember = DA_Unit.SelectUnit.Columns("unit_name").ColumnName
        Me.cbounit.SelectedIndex = -1

    End Sub
  

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

   
    Private Sub BtnAddUnit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddUnit.Click
        Dim StoreTable As New DataTable
        StoreTable = DA_Store.SelectStoreByMedicineIDAndUnitname(CInt(Me.cbomedicine.SelectedValue), Me.cbounit.Text)
        If StoreTable.Rows.Count >= 1 Then
            MsgBox("This store has been added already", MsgBoxStyle.Exclamation, "Existing Store")
            Me.cbounit.Focus()
            Exit Sub
        End If

        If ValidateCombobox(Me.cbounittype, "", ErrMenu) = False Then Exit Sub
        If ValidateTextField(Me.txtratioqty, "", ErrMenu) = False Then Exit Sub
        If IsNumeric(Me.txtratioqty.Text) = False Then
            MsgBox("Please enter ratio quantity as number only", MsgBoxStyle.Exclamation, "Invalid Number")
            Me.txtratioqty.Focus()
            Me.txtratioqty.SelectAll()
            Exit Sub
        End If


        If IsNumeric(Me.txtbeginqty.Text) = False Then
            MsgBox("Please enter beginning quantity as number only", MsgBoxStyle.Exclamation, "Invalid Number")
            Me.txtbeginqty.Focus()
            Me.txtbeginqty.SelectAll()
            Exit Sub
        End If

        If ValidateTextField(Me.txtcost, "", ErrMenu) = False Then Exit Sub
        If IsNumeric(Me.txtcost.Text) = False Then
            MsgBox("Please enter cost as number only", MsgBoxStyle.Exclamation, "Invalid Number")
            Me.txtcost.Focus()
            Me.txtcost.SelectAll()
            Exit Sub
        End If

        If ValidateTextField(Me.txtprice, "", ErrMenu) = False Then Exit Sub
        If IsNumeric(Me.txtprice.Text) = False Then
            MsgBox("Please enter price as number only", MsgBoxStyle.Exclamation, "Invalid Number")
            Me.txtprice.Focus()
            Me.txtprice.SelectAll()
            Exit Sub
        End If

        If MessageBox.Show("Do you want to add unit?", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            DA_Store.InsertStore(CInt(Me.cbomedicine.SelectedValue), Me.cbounit.Text, Me.cbounittype.Text, CInt(Me.txtratioqty.Text), CDec(Me.txtbeginqty.Text), CDec(Me.txtcost.Text), CDec(Me.txtprice.Text))

            Dim LastStoreID As New Integer
            LastStoreID = DA_Store.GetMaxID
            ''Record Receive
            DA_Receive.InsertReceive(LastStoreID, "Receive", FormatDateTime(Now, DateFormat.ShortDate), CDec(Me.txtbeginqty.Text))
            ''Record Transaction
            DA_Transaction.InsertTransaction(LastStoreID, 2, FormatDateTime(Now, DateFormat.ShortDate), 0, CDec(Me.txtbeginqty.Text), CDec(Me.txtbeginqty.Text))
            Me.StoreList.DataSource = DA_Store.SelectStoreByMedicineID(CInt(Me.cbomedicine.SelectedValue))
            'MsgBox("The store has been added successfully", MsgBoxStyle.Information, "Store Added")
            StockPanel.FilByMedicineName(cbomedicine.Text)
            cbounit.SelectedIndex = -1
            cbounittype.SelectedIndex = -1
            Me.txtbeginqty.Text = ""
            Me.txtcost.Text = ""
            Me.txtprice.Text = ""
            Me.txtratioqty.Text = ""
        End If
        
    End Sub
    
    
    Private Sub cbomedicine_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbomedicine.SelectedIndexChanged

    End Sub

    Private Sub cbomedicine_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbomedicine.SelectionChangeCommitted
        Me.StoreList.DataSource = DA_Store.SelectStoreByMedicineID(CInt(Me.cbomedicine.SelectedValue))
    End Sub

    Private Sub BtnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemove.Click
        If StoreList.SelectedItems.Count >= 1 Then
            DA_Store.DeleteStore(CInt(StoreList.CurrentRow.Cells("store_id").Value))
            Me.StoreList.DataSource = DA_Store.SelectStoreByMedicineID(CInt(Me.cbomedicine.SelectedValue))
            StockPanel.FilByMedicineName(cbomedicine.Text)
        End If
    End Sub

    Private Sub txtratioqty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtratioqty.LostFocus
        If Me.cbounittype.Text = "Sub unit" Then
            Dim MainStoreTable As New DataTable
            MainStoreTable = DA_Store.SelectByMedicineIDAndUnitType(CInt(Me.cbomedicine.SelectedValue), "Main unit")
            If MainStoreTable.Rows.Count >= 1 And IsNumeric(Me.txtratioqty.Text) = True Then
                Me.txtbeginqty.Text = FormatNumber(CDec(Me.txtratioqty.Text) * CDec(MainStoreTable.Rows(0).Item("qty")), 2)
                Me.txtprice.Text = FormatNumber(CDec(MainStoreTable.Rows(0).Item("last_price")) / CDec(Me.txtratioqty.Text), 2)
            End If
        End If
    End Sub

    Private Sub txtratioqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtratioqty.TextChanged

    End Sub
End Class