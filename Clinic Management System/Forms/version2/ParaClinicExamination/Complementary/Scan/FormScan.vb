Public Class FormScan
    Dim RequestPanel As DashbordDotorRequestExamination
    Dim DA_Scan As New DSExaminationTableAdapters.tblscanTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal PanelRequest As DashbordDotorRequestExamination)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.RequestPanel = PanelRequest
    End Sub
    Private Sub FormScan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If DA_Scan.SelectScanByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
            Me.txtscan.Text = DA_Scan.SelectScanByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows(0).Item("scan")
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If DA_Scan.SelectScanByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
            ''Update
            DA_Scan.UpdateScan(Me.txtscan.Text.Replace("'", "''"), CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value))
            MsgBox("The scan has been saved sucessfully", MsgBoxStyle.OkOnly, "Saved Scan")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            ''Add New
            DA_Scan.InsertScan(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value), Me.txtscan.Text.Replace("'", "''"))
            MsgBox("The scan has been saved sucessfully", MsgBoxStyle.OkOnly, "Saved Scan")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class