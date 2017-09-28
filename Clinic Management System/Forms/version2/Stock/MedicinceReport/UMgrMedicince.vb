Public Class UMgrMedicince
    Dim DA_MedicalReceive As New DSMedicalReceiveTableAdapters.MEDICAL_RECEIVEDTableAdapter
    Dim DA_Product As New DSMedicalReceiveTableAdapters.tblmedicineTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboProduct
            .DataSource = DA_MedicalReceive.GroupByProName
            '.ValueMember = "medicineid"
            .DisplayMember = "PRODUCT_NAME"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.
        GridMedicalReceive.Dock = DockStyle.Fill
    End Sub
    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Dim FMedicalReceive As New FMedicalReceived(Me)
        FMedicalReceive.MaxRecord.Text = DA_MedicalReceive.SelectMaxRecord
        If FMedicalReceive.ShowDialog() = DialogResult.OK Then
            GridMedicalReceive.DataSource = DA_MedicalReceive.SelectRefNo(FMedicalReceive.TxtReferNo.Text)
        End If
    End Sub
    Public Sub ViewProductReceived(ByVal DateFrom As Date, ByVal dateTo As Date)
        GridMedicalReceive.DataSource = DA_MedicalReceive.SelectProductReceiveDTD(DateFrom.Date, dateTo.Date, False)
    End Sub
    Public Sub ViewProductUpdate(ByVal ReceiveID As Integer)
        GridMedicalReceive.DataSource = DA_MedicalReceive.SelectByReceiveID(ReceiveID)
    End Sub

    Private Sub GridMedicalReceive_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridMedicalReceive.RowDoubleClick
        If GridMedicalReceive.SelectedItems.Count = 0 Then Exit Sub
        If CStr(GridMedicalReceive.GetRow.Cells("RECEIVE_ID").Value) = "" Then Exit Sub
        Dim FMedicalReceive As New FMedicalReceived(Me)

        FMedicalReceive.LblSaveOption.Text = IIf(TypeOf (GridMedicalReceive.GetRow.Cells("UNIC_NUMBER").Value) Is DBNull, "", GridMedicalReceive.GetRow.Cells("UNIC_NUMBER").Value)
        Dim tblTem As DataTable = DA_MedicalReceive.SelectReferentNo(IIf(TypeOf (GridMedicalReceive.GetRow.Cells("UNIC_NUMBER").Value) Is DBNull, "", GridMedicalReceive.GetRow.Cells("UNIC_NUMBER").Value), False)
        FMedicalReceive.MaxRecord.Text = IIf(TypeOf (GridMedicalReceive.GetRow.Cells("UNIC_NUMBER").Value) Is DBNull, "", GridMedicalReceive.GetRow.Cells("UNIC_NUMBER").Value)
        FMedicalReceive.GridMedicalReceive.DataSource = tblTem 'DA_MedicalReceive.SelectRefNo(GridMedicalReceive.GetRow.Cells("REFERENT_NO").Value)
        FMedicalReceive.TxtReferNo.Text = GridMedicalReceive.GetRow.Cells("REFERENT_NO").Value
        FMedicalReceive.TxtNote.Text = GridMedicalReceive.GetRow.Cells("NOTE").Value
        FMedicalReceive.TxtReferNo.Enabled = False
        FMedicalReceive.CalSubTotal(tblTem)

        If FMedicalReceive.ShowDialog() = DialogResult.OK Then

            GridMedicalReceive.DataSource = DA_MedicalReceive.SelectRefNo(FMedicalReceive.TxtReferNo.Text)
        End If

     
    End Sub

    Private Sub UMgrMedicince_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridMedicalReceive.Visible = True
        GridMedicalReceive.Dock = DockStyle.Fill
        CrystalReportViewer1.Visible = False
        CrystalReportViewer1.Dock = DockStyle.Fill
        FinInformation()
    End Sub

    Private Sub BtnBupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBupdate.Click
        If GridMedicalReceive.SelectedItems.Count = 0 Then Exit Sub
        If CStr(GridMedicalReceive.GetRow.Cells("RECEIVE_ID").Value) = "" Then Exit Sub
        Dim FMedicalReceive As New FMedicalReceived(Me)

        FMedicalReceive.LblSaveOption.Text = IIf(TypeOf (GridMedicalReceive.GetRow.Cells("UNIC_NUMBER").Value) Is DBNull, "", GridMedicalReceive.GetRow.Cells("UNIC_NUMBER").Value)
        Dim tblTem As DataTable = DA_MedicalReceive.SelectReferentNo(IIf(TypeOf (GridMedicalReceive.GetRow.Cells("UNIC_NUMBER").Value) Is DBNull, "", GridMedicalReceive.GetRow.Cells("UNIC_NUMBER").Value), False)
        FMedicalReceive.MaxRecord.Text = IIf(TypeOf (GridMedicalReceive.GetRow.Cells("UNIC_NUMBER").Value) Is DBNull, "", GridMedicalReceive.GetRow.Cells("UNIC_NUMBER").Value)
        FMedicalReceive.GridMedicalReceive.DataSource = tblTem 'DA_MedicalReceive.SelectRefNo(GridMedicalReceive.GetRow.Cells("REFERENT_NO").Value)
        FMedicalReceive.TxtReferNo.Text = GridMedicalReceive.GetRow.Cells("REFERENT_NO").Value
        FMedicalReceive.TxtNote.Text = GridMedicalReceive.GetRow.Cells("NOTE").Value
        FMedicalReceive.TxtReferNo.Enabled = False
        FMedicalReceive.CalSubTotal(tblTem)

        If FMedicalReceive.ShowDialog() = DialogResult.OK Then

            GridMedicalReceive.DataSource = DA_MedicalReceive.SelectRefNo(FMedicalReceive.TxtReferNo.Text)
        End If


    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If GridMedicalReceive.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_MedicalReceive.DeleteByReceiveID(GridMedicalReceive.GetRow.Cells("RECEIVE_ID").Value) = 1 Then
                ViewProductUpdate(GridMedicalReceive.GetRow.Cells("RECEIVE_ID").Value)
            End If
        End If
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        GridMedicalReceive.Visible = True
        GridMedicalReceive.Dock = DockStyle.Fill
        CrystalReportViewer1.Visible = False
        CrystalReportViewer1.Dock = DockStyle.Fill
        FinInformation()
    End Sub
    Private Sub FinInformation()
        If RadAllProduct.Checked = True Then
            GridMedicalReceive.DataSource = DA_MedicalReceive.SelectProductReceiveDTD(DateFrom.Value.Date, DateTo.Value, False)
        ElseIf RadProductName.Checked = True Then
            GridMedicalReceive.DataSource = DA_MedicalReceive.SelectByProductName(CboProduct.Text, False, DateFrom.Value.Date, DateTo.Value.Date)
        ElseIf RadReferenceNO.Checked = True Then
            GridMedicalReceive.DataSource = DA_MedicalReceive.SelectByReferenceNo(TxtReferenceNo.Text, DateFrom.Value.Date, DateTo.Value.Date, False)
        End If
    End Sub

    Private Sub RadProductName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadProductName.CheckedChanged
        CboProduct.Enabled = True
        CboProduct.Focus()
        TxtReferenceNo.Enabled = False
    End Sub

    Private Sub RadReferenceNO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadReferenceNO.CheckedChanged
        CboProduct.Enabled = False
        TxtReferenceNo.Enabled = True
        TxtReferenceNo.Focus()
        TxtReferenceNo.Select()
    End Sub

    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        GridMedicalReceive.Visible = False
        CrystalReportViewer1.Visible = True
        CrystalReportViewer1.Dock = DockStyle.Fill
        Dim tblMedicinceReceive As DataTable
        Dim VReportMedicince As New CryMedicinceReport
        If RadAllProduct.Checked = True Then
            tblMedicinceReceive = DA_MedicalReceive.SelectProductReceiveDTD(DateFrom.Value.Date, DateTo.Value, False)
        ElseIf RadProductName.Checked = True Then
            tblMedicinceReceive = DA_MedicalReceive.SelectByProductName(CboProduct.Text, False, DateFrom.Value.Date, DateTo.Value.Date)
        ElseIf RadReferenceNO.Checked = True Then
            tblMedicinceReceive = DA_MedicalReceive.SelectByReferenceNo(TxtReferenceNo.Text, DateFrom.Value.Date, DateTo.Value.Date, False)
        End If
        VReportMedicince.SetDataSource(tblMedicinceReceive)
        VReportMedicince.SetParameterValue("title", "From:" & DateFrom.Text.Trim & " To:" & DateTo.Text.Trim)
        CrystalReportViewer1.ReportSource = VReportMedicince

    End Sub

   
    Private Sub RadAllProduct_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadAllProduct.CheckedChanged
        CboProduct.SelectedIndex = -1
        TxtReferenceNo.Text = ""
        CboProduct.Enabled = False
        TxtReferenceNo.Enabled = False

    End Sub
End Class
