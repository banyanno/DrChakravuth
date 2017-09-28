Public Class FormCFAnaPath
    Dim DA_CFAnapath As New DSExaminationTableAdapters.tblCFAnaPathTableAdapter
    Dim RequestPanel As DashbordDotorRequestExamination
    Sub New(ByVal PanelRequest As DashbordDotorRequestExamination)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        RequestPanel = PanelRequest
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If DA_CFAnapath.GetDataByRequest_id(CLng(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
            If MessageBox.Show("Do you want to update C.F Ana-path?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                DA_CFAnapath.UpdateCFAnapath(TxtCFAnapath.Text.Replace("'", "''"), CLng(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value))
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Else
            If MessageBox.Show("Do you want to save C.F Ana-path?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                DA_CFAnapath.InsertCFAnapath(CLng(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value), Me.TxtCFAnapath.Text.Replace("'", "''"))
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
        
    End Sub

    Private Sub FormCFAnaPath_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If DA_CFAnapath.GetDataByRequest_id(CLng(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
            TxtCFAnapath.Text = DA_CFAnapath.GetDataByRequest_id(CLng(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value)).Rows(0).Item(1)
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class