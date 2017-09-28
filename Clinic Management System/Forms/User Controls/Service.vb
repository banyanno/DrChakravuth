Public Class Service
    Dim DA_Service As New DSPAtientTableAdapters.ServicesTableAdapter

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim FrmService As New NewService(Me)
        FrmService.ShowDialog()
    End Sub

    Sub LoadDataToGrid()
        Me.ServiceList.DataSource = DA_Service.GetData
    End Sub

    Private Sub Service_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDataToGrid()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Are you sure you want to delete this service", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DA_Service.DeleteService(Me.ServiceList.CurrentRow.Cells("Service_ID").Value)
            LoadDataToGrid()
        End If
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Dim EditForm As New EditService(Me)
        EditForm.cbotype.SelectedValue = Me.ServiceList.CurrentRow.Cells("Type_ID").Value
        EditForm.txtname.Text = Me.ServiceList.CurrentRow.Cells("Service_Name").Text
        EditForm.txtprice.Text = Me.ServiceList.CurrentRow.Cells("Price").Value
        EditForm.ShowDialog()
    End Sub
End Class
