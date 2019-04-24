Public Class FormFibrosScan
    Dim RequestPanel As DashbordDotorRequestExamination
    Dim DA_FibroScan As New DSExaminationTableAdapters.tblfibroscanTableAdapter
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
    Private Sub FormFibrosScan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If DA_FibroScan.SelectFibroScanByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
            Me.txtfibroscan.Text = DA_FibroScan.SelectFibroScanByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows(0).Item("fibroscan")
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If DA_FibroScan.SelectFibroScanByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
            ''Update
            DA_FibroScan.UpdateFibroScan(Me.txtfibroscan.Text.Replace("'", "''"), CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value))
            MsgBox("The fibroscan has been saved sucessfully", MsgBoxStyle.OkOnly, "Saved FibroScan")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            ''Add New
            DA_FibroScan.InsertFibroScan(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value), Me.txtfibroscan.Text.Replace("'", "''"))
            MsgBox("The fibroscan has been saved sucessfully", MsgBoxStyle.OkOnly, "Saved FibroScan")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class