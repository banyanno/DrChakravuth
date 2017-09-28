Public Class Issue
    Dim StockPanel As UCStock
    Dim DA_Issue As New DSStoreTableAdapters.tblissueTableAdapter
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

    

  

    Private Sub BtnIssue_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnIssue.Click

        If ValidateTextField(txtissuedqty, "", ErrMenu) = False Then Exit Sub
        If IsNumeric(Me.txtissuedqty.Text) = False Then
            MsgBox("Please input issued quantity as number only", MsgBoxStyle.Exclamation, "Invalid Number")
            Me.txtissuedqty.Focus()
            Exit Sub
        Else
            If CInt(Me.txtissuedqty.Text) > CInt(Me.txtcurrentqty.Text) Then
                MsgBox("The issued quantity can not be greater than the current quantity", MsgBoxStyle.Information, "Duplicate Value")
                Me.txtissuedqty.Focus()
                Exit Sub
            ElseIf Me.txtcurrentqty.Text = "" Then
                MsgBox("Please select unit name", MsgBoxStyle.Information, "Unspecified Unit")
                Me.cbounit.Focus()
                Exit Sub
            End If
            Dim StoreTable As New DataTable
            StoreTable = DA_Store.SelectStoreByMedicineIDAndUnitname(CInt(Me.cbomedicine.SelectedValue), Me.cbounit.SelectedValue.ToString)

            DA_Issue.InsertIssue(CInt(StoreTable.Rows(0).Item("store_id")), Me.txtreason.Text.Replace("'", "''").ToString, FormatDateTime(Now, DateFormat.ShortDate), CDec(Me.txtissuedqty.Text))
            DA_Store.UpdateQuantity(CDec(Me.txtcurrentqty.Text) - CDec(Me.txtissuedqty.Text), CLng(StoreTable.Rows(0).Item("store_id")))
            DA_Transaction.InsertTransaction(CLng(StoreTable.Rows(0).Item("store_id")), 1, FormatDateTime(Now, DateFormat.ShortDate), CDec(Me.txtcurrentqty.Text), CDec(Me.txtissuedqty.Text * -1), CDec(Me.txtcurrentqty.Text) - CDec(Me.txtissuedqty.Text))
            MsgBox("An issue has been made successfully", MsgBoxStyle.Information, "Issue Made")
            StockPanel.FilByName(cbomedicine.Text)
            Me.Close()
        End If
    End Sub

    Private Sub Issue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cbomedicine_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbomedicine.SelectedValueChanged
        Try
            Me.cbounit.DataSource = DA_Store.SelectStoreByMedicineID(CInt(Me.cbomedicine.SelectedValue))
            Me.cbounit.ValueMember = DA_Store.SelectStoreByMedicineID(CInt(Me.cbomedicine.SelectedValue)).Columns("unitname").ColumnName
            Me.cbounit.DisplayMember = DA_Store.SelectStoreByMedicineID(CInt(Me.cbomedicine.SelectedValue)).Columns("unitname").ColumnName
            'Me.cbounit.SelectedIndex = -1
            'Me.txtcurrentqty.Text = ""
            'Me.txtratioqty.Text = ""
            'Me.txtunittype.Text = ""
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub cbounit_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbounit.SelectedValueChanged
        Try
            Dim StoreTable As New DataTable
            StoreTable = DA_Store.SelectStoreByMedicineIDAndUnitname(CInt(Me.cbomedicine.SelectedValue), Me.cbounit.SelectedValue.ToString)
            Me.txtratioqty.Text = StoreTable.Rows(0).Item("ratioqty")
            Me.txtunittype.Text = StoreTable.Rows(0).Item("unittype")
            Me.txtcurrentqty.Text = StoreTable.Rows(0).Item("qty")
            Me.txtissuedqty.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtissuedqty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtissuedqty.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class