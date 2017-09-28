Public Class ServiceTypes
    Dim DA_ServiceType As New DSPAtientTableAdapters.Service_TypesTableAdapter
    Private Sub ServiceTypes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ServiceTypeList.DataSource = DA_ServiceType.GetData
    End Sub
    Sub LoadDataToGridView()
        Me.ServiceTypeList.DataSource = DA_ServiceType.GetData
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim FrmType As New NewServiceType(Me)
        FrmType.ShowDialog()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Dim FrmType As New EditServiceType(Me)
        FrmType.txtid.Text = ServiceTypeList.CurrentRow.Cells("Type_ID").Value
        FrmType.txtname.Text = ServiceTypeList.CurrentRow.Cells("Type_Name").Value
        FrmType.ShowDialog()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Are you sure you want to delete this service type?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DA_ServiceType.DeleteType(ServiceTypeList.CurrentRow.Cells("Type_ID").Value)
            LoadDataToGridView()
        End If
    End Sub
End Class
