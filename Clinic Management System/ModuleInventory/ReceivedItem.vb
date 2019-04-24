Public Class ReceivedItem
    Dim DAReceiveMaster As New DSInventoryClinicTableAdapters.ITEM_RECIEVE_MASTERTableAdapter
    Dim DAReceiveDetail As New DSInventoryClinicTableAdapters.ITEM_RECIEVE_DETIALTableAdapter
    Dim DASupplier As New DSInventoryClinicTableAdapters.tblVenderTableAdapter
    Dim DAExpendDetail As New DSInventoryClinicTableAdapters.tbl_invoiceTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboSupplier
            .DataSource = DASupplier.GetData
            .ValueMember = "VenderID"
            .DisplayMember = "VenderName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim FReceiveMedicine As New ForReceiveOrder
        FReceiveMedicine.ShowDialog()
    End Sub



    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        GridEXReceive.DataSource = DAReceiveMaster.SelectMedicineDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
    End Sub

   

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        GridEXReceive.DataSource = DAReceiveMaster.SelectSupplierDateToDate(DateFrom.Value.Date, DateTo.Value.Date, CInt(CboSupplier.SelectedValue))
    End Sub

    Private Sub BtnFindRefer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindRefer.Click
        GridEXReceive.DataSource = DAReceiveMaster.SelectByReferrentNo(TxtReferentNo.Text)
    End Sub

    Private Sub BtnExpend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExpend.Click
        If GridEXReceive.SelectedItems.Count = 0 Then Exit Sub
        Dim NExpend As New NewExpend
        NExpend.TxtReferNo.Text = Me.GridEXReceive.GetRow.Cells("REFERAN_INVOICE_NO").Value
        NExpend.TxtNote.Text = Me.GridEXReceive.GetRow.Cells("SUPPLY_NAME").Value
        If NExpend.ShowDialog() = DialogResult.OK Then
            GridExpend.DataSource = DAExpendDetail.SelectExpend(NExpend.TxtReferNo.Text)
        End If
    End Sub

    Private Sub GridEXReceive_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridEXReceive.SelectionChanged
        If GridEXReceive.SelectedItems.Count = 0 Then
            GridEXReceiveDetail.DataSource = Nothing
            GridExpend.DataSource = Nothing
        Else
            GridExpend.DataSource = DAExpendDetail.SelectExpend(GridEXReceive.GetRow.Cells("REFERAN_INVOICE_NO").Value)
            GridEXReceiveDetail.DataSource = DAReceiveDetail.SelectReceiveDetail(GridEXReceive.GetRow.Cells("RECEIVE_ID").Value)
        End If
    End Sub
End Class
