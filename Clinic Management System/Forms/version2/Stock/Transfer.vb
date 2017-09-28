Public Class Transfer
    Dim StockPanel As UCStock
    Dim DA_Transfer As New DSStoreTableAdapters.tbltransferTableAdapter
    Dim DA_Issue As New DSStoreTableAdapters.tblissueTableAdapter
    Dim DA_Receive As New DSStoreTableAdapters.tblreceiveTableAdapter
    Dim DA_Medicine As New DSPAtientTableAdapters.tblmedicineTableAdapter
    Dim DA_Store As New DSStoreTableAdapters.tblmedicinestoreTableAdapter
    Dim DA_Transaction As New DSStoreTableAdapters.tbltransactionTableAdapter
    Dim MainStoreID As Integer
    Dim SubStoreID As Integer

    Sub New(ByVal UStock As UCStock)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        StockPanel = UStock
        ' Add any initialization after the InitializeComponent() call.
        Me.cbomedicine.DataSource = DA_Medicine.SelectMedicine
        Me.cbomedicine.ValueMember = DA_Medicine.SelectMedicine.Columns("medicineid").ColumnName
        Me.cbomedicine.DisplayMember = DA_Medicine.SelectMedicine.Columns("medicinename").ColumnName
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub cbomedicine_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbomedicine.SelectionChangeCommitted
        Dim StoreTable As New DataTable
        StoreTable = DA_Store.SelectStoreByMedicineID(CInt(Me.cbomedicine.SelectedValue))

        ''Clear Boxes
        Me.cbosubunit.Items.Clear()
        Me.txtcurrentqty.Text = ""
        Me.txtratioqty.Text = ""
        Me.txttransferedqty.Text = ""

        If StoreTable.Rows.Count > 1 Then
            For i As Integer = 0 To StoreTable.Rows.Count - 1
                If StoreTable.Rows(i).Item("unittype") = "Main unit" Then
                    Me.txtmainunit.Text = StoreTable.Rows(i).Item("unitname")
                    Me.txtmainqty.Text = StoreTable.Rows(i).Item("qty")
                    MainStoreID = CInt(StoreTable.Rows(i).Item("store_id"))
                Else
                    Me.cbosubunit.Items.Add(StoreTable.Rows(i).Item("unitname"))
                End If
                Me.BtnTransfer.Enabled = True
            Next
        Else
            Me.BtnTransfer.Enabled = False
        End If
        Me.cbosubunit.SelectedIndex = -1
    End Sub
    Private Sub Transfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnTransfer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnTransfer.Click
        If ValidateTextField(Me.txttransferedqty, "", ErrMenu) = False Then Exit Sub
        If ValidateTextField(Me.txtratioqty, "", ErrMenu) = False Then
            MsgBox("Please choose sub unit", MsgBoxStyle.Exclamation, "Unselected Subunit")
            Me.cbosubunit.Focus()
            Exit Sub
        End If
        If IsNumeric(Me.txttransferedqty.Text) = False Then
            MsgBox("Please enter transfered quantity as number only", MsgBoxStyle.Exclamation, "Invalid Quantity")
            Me.txttransferedqty.Focus()
            Exit Sub
        End If
        If CInt(Me.txttransferedqty.Text) > CInt(Me.txtmainqty.Text) Then
            MsgBox("The transfered quantity is greater than the quantity in stock", MsgBoxStyle.Exclamation, "Insufficent Quantity")
            Me.txttransferedqty.Focus()
            Exit Sub
        End If

        If MsgBox("Do you want to transfer this medicine store from main to subunit?", MsgBoxStyle.YesNo, "Confirm Transfer") = MsgBoxResult.Yes Then
            '' Update Store
            '' - Main Unit
            DA_Store.UpdateQuantity(CInt(Me.txtmainqty.Text) - CInt(Me.txttransferedqty.Text), MainStoreID)
            '' - Sub Unit
            DA_Store.UpdateQuantity(CInt(Me.txtcurrentqty.Text) + CInt(Me.txttransferedqty.Text) * CInt(Me.txtratioqty.Text), SubStoreID)

            '' Record Issue and Transaction
            '' - Main Unit
            DA_Issue.InsertIssue(MainStoreID, "Transfer", FormatDateTime(Now, DateFormat.ShortDate), CInt(Me.txttransferedqty.Text))
            DA_Transaction.InsertTransaction(MainStoreID, 1, FormatDateTime(Now, DateFormat.ShortDate), CInt(Me.txtmainqty.Text), CInt(Me.txttransferedqty.Text) * -1, CInt(Me.txtmainqty.Text) - CInt(Me.txttransferedqty.Text))

            '' Record Receive and Transaction
            '' - Sub Unit 
            DA_Receive.InsertReceive(SubStoreID, "Transfer", FormatDateTime(Now, DateFormat.ShortDate), CInt(Me.txttransferedqty.Text) * CInt(Me.txtratioqty.Text))
            DA_Transaction.InsertTransaction(SubStoreID, 2, FormatDateTime(Now, DateFormat.ShortDate), CInt(Me.txtcurrentqty.Text), CInt(Me.txttransferedqty.Text) * CInt(Me.txtratioqty.Text), CInt(Me.txtcurrentqty.Text) + CInt(Me.txttransferedqty.Text) * CInt(Me.txtratioqty.Text))

            '' Record Transfer
            DA_Transfer.InsertTransfer(MainStoreID, SubStoreID, CInt(Me.cbomedicine.SelectedValue), FormatDateTime(Now, DateFormat.ShortDate), CInt(Me.txttransferedqty.Text))

            MsgBox("The medicine store has been transfered successfully", MsgBoxStyle.Information, "Store Transfered")
            StockPanel.RefreshStore()

            Me.cbomedicine.SelectedIndex = -1
            Me.txtmainunit.Text = ""
            Me.cbosubunit.SelectedIndex = -1
            Me.txtcurrentqty.Text = ""
            Me.txtratioqty.Text = ""
            Me.txttransferedqty.Text = ""
            Me.BtnTransfer.Enabled = False
        End If
    End Sub

    Private Sub cbosubunit_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbosubunit.SelectionChangeCommitted
        Dim StoreTable As New DataTable
        StoreTable = DA_Store.SelectStoreByMedicineIDAndUnitname(CInt(Me.cbomedicine.SelectedValue), Me.cbosubunit.Text.ToString)
        Me.txtratioqty.Text = StoreTable.Rows(0).Item("ratioqty")
        Me.txtcurrentqty.Text = StoreTable.Rows(0).Item("qty")
        SubStoreID = CInt(StoreTable.Rows(0).Item("store_id"))
        Me.txttransferedqty.Focus()
    End Sub
End Class