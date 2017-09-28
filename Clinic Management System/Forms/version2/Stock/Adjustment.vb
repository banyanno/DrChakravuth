Public Class Adjustment
    Dim StockPanel As UCStock
    Dim DA_Adjustment As New DSStoreTableAdapters.tbladjustmentTableAdapter
    Dim DA_Issue As New DSStoreTableAdapters.tblissueTableAdapter
    Dim DA_Receive As New DSStoreTableAdapters.tblreceiveTableAdapter
    Dim DA_Store As New DSStoreTableAdapters.tblmedicinestoreTableAdapter
    Dim DA_Transaction As New DSStoreTableAdapters.tbltransactionTableAdapter

    Sub New(ByVal UStock As UCStock)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        StockPanel = UStock
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Adjustment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtadjustedqty.Focus()
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim adjust_type As Integer = 1
        If ValidateTextField(txtadjustedqty, "", ErrMenu) = False Then Exit Sub
        If IsNumeric(Me.txtadjustedqty.Text) = False Then
            MsgBox("Please input adjusted quantity as number only", MsgBoxStyle.Exclamation, "Invalid Number")
            Me.txtadjustedqty.Focus()
            Exit Sub
        Else
            If CDec(Me.txtadjustedqty.Text) < CDec(Me.txtcurrentqty.Text) Then
                adjust_type = 1
                DA_Issue.InsertIssue(CLng(StockPanel.StoreList.CurrentRow.Cells("store_id").Value), "Adjustment", FormatDateTime(Now, DateFormat.ShortDate), (CDec(Me.txtcurrentqty.Text) - CDec(Me.txtadjustedqty.Text)))
            ElseIf CDec(Me.txtadjustedqty.Text) > CDec(Me.txtcurrentqty.Text) Then
                adjust_type = 2
                DA_Receive.InsertReceive(CLng(StockPanel.StoreList.CurrentRow.Cells("store_id").Value), "Adjustment", FormatDateTime(Now, DateFormat.ShortDate), (CDec(Me.txtadjustedqty.Text) - CDec(Me.txtcurrentqty.Text)))
            ElseIf CDec(Me.txtadjustedqty.Text) = CDec(Me.txtcurrentqty.Text) Then
                MsgBox("The current quantity and adjusted quantity can not be the same", MsgBoxStyle.Information, "Duplicate Value")
                Exit Sub
            End If


            DA_Adjustment.InsertAdjustment(CLng(StockPanel.StoreList.CurrentRow.Cells("store_id").Value), adjust_type, Me.txtreason.Text.Replace("'", "''").ToString, FormatDateTime(Now, DateFormat.ShortDate), CDec(Me.txtcurrentqty.Text), CDec(Me.txtadjustedqty.Text))
            DA_Store.UpdateQuantity(CDec(Me.txtadjustedqty.Text), CLng(StockPanel.StoreList.CurrentRow.Cells("store_id").Value))
            DA_Transaction.InsertTransaction(CLng(StockPanel.StoreList.CurrentRow.Cells("store_id").Value), adjust_type, FormatDateTime(Now, DateFormat.ShortDate), CDec(Me.txtcurrentqty.Text), (CDec(Me.txtadjustedqty.Text) - CDec(Me.txtcurrentqty.Text)), CDec(Me.txtadjustedqty.Text))

            MsgBox("An adjsutement has been made successfully", MsgBoxStyle.Information, "Adjustment Made")
            StockPanel.FilByName(txtmedicine.Text)
        End If
    End Sub
End Class