Public Class FormResultBlood
    Dim DA_ItemResult As New DSExaminationTableAdapters.tblrequestblooditemTableAdapter
    Dim RequestPanel As DashbordDotorRequestExamination
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

    Private Sub FormResultBlood_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If DA_ItemResult.UpdateResult(Me.TxtResultBlood.Text, CLng(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value), CInt(Me.RequestPanel.ItemResultList.CurrentRow.Cells("item_id").Value)) = 1 Then
            Me.RequestPanel.LoadCheckBloodResult(RequestPanel.RequestList.GetRow.Cells("request_id").Value)
            MsgBox("The result of blood check has been saved", MsgBoxStyle.OkOnly, "Saved Result")
            Me.Close()
        End If
    End Sub
End Class