Public Class FormResultMRI
    Dim RequestPanel As DashbordDotorRequestExamination
    Dim DA_MRI As New DSExaminationTableAdapters.tblmriTableAdapter
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
    Private Sub FormResultMRI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If DA_MRI.SelectMRIByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
            Me.txtmri.Text = DA_MRI.SelectMRIByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows(0).Item("mri")
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If DA_MRI.SelectMRIByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
            ''Update
            DA_MRI.UpdateMRI(Me.txtmri.Text.Replace("'", "''"), CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value))
            MsgBox("The MRI has been saved sucessfully", MsgBoxStyle.OkOnly, "Saved MRI")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            ''Add New
            DA_MRI.InsertMRI(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value), Me.txtmri.Text.Replace("'", "''"))
            MsgBox("The MRI has been saved sucessfully", MsgBoxStyle.OkOnly, "Saved MRI")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class