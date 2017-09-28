Public Class UpdateStore
    Dim StockPanel As StoreManagement
    Dim DA_Medicine As New DSPAtientTableAdapters.tblmedicineTableAdapter
    Dim DA_Unit As New DSStoreTableAdapters.tblunitTableAdapter
    Dim DA_Store As New DSStoreTableAdapters.tblmedicinestoreTableAdapter
    Dim DA_Transaction As New DSStoreTableAdapters.tbltransactionTableAdapter


    Sub New(ByVal UStock As StoreManagement)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        StockPanel = UStock
        ' Add any initialization after the InitializeComponent() call.
        Me.cbounit.DataSource = DA_Unit.SelectUnit
        Me.cbounit.ValueMember = DA_Unit.SelectUnit.Columns("unit_name").ColumnName
        Me.cbounit.DisplayMember = DA_Unit.SelectUnit.Columns("unit_name").ColumnName

    End Sub
    Private Sub UpdateStore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cbounittype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbounittype.SelectedIndexChanged

    End Sub

    Private Sub txtratioqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtratioqty.TextChanged

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim StoreTable As New DataTable
        StoreTable = DA_Store.SelectStoreByMedicineIDAndUnitname(CInt(StockPanel.StoreList.CurrentRow.Cells("medicineid").Value), Me.cbounit.Text)
        If StoreTable.Rows.Count >= 1 And Me.cbounit.Text <> StockPanel.StoreList.CurrentRow.Cells("unitname").Value.ToString Then
            MsgBox("This store already exists", MsgBoxStyle.Exclamation, "Existing Store")
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
        If ValidateTextField(Me.txtlastcost, "", ErrMenu) = False Then Exit Sub
        If IsNumeric(Me.txtlastcost.Text) = False Then
            MsgBox("Please enter last cost as number only", MsgBoxStyle.Exclamation, "Invalid Number")
            Me.txtlastcost.Focus()
            Me.txtlastcost.SelectAll()
            Exit Sub
        End If
        If ValidateTextField(Me.txtlastprice, "", ErrMenu) = False Then Exit Sub
        If IsNumeric(Me.txtlastprice.Text) = False Then
            MsgBox("Please enter last price as number only", MsgBoxStyle.Exclamation, "Invalid Number")
            Me.txtlastprice.Focus()
            Me.txtlastprice.SelectAll()
            Exit Sub
        End If

        If MsgBox("Are you sure you want to update this store", MsgBoxStyle.YesNo, "Confirm Update") = MsgBoxResult.Yes Then
            If DA_Store.UpdateStore(CInt(StockPanel.StoreList.CurrentRow.Cells("medicineid").Value), Me.cbounit.Text, Me.cbounittype.Text, CInt(Me.txtratioqty.Text), CInt(StockPanel.StoreList.CurrentRow.Cells("qty").Value), CDec(Me.txtlastcost.Text), CDec(Me.txtlastprice.Text), CInt(StockPanel.StoreList.CurrentRow.Cells("store_id").Value)) = 1 Then
                MsgBox("The store has been updated successfully", MsgBoxStyle.Information, "Store Updated")
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
           
        End If
    End Sub
End Class