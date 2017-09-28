Public Class UCConsultationType
    Dim DA_ConsultType As New DSPAtientTableAdapters.tblConsultTypeTableAdapter
    Private Sub GridConsultation_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles ConsultTypeList.FormattingRow

    End Sub
    Sub RefreshData()

        ConsultTypeList.DataSource = DA_ConsultType.SelectConsultationTypes
    End Sub

    Private Sub UCConsultationType_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RefreshData()
    End Sub

    Private Sub BtnNewConsultation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewConsultation.Click
        'Dim TypeForm As New NewConsultationType(Me)
        'TypeForm.LblSaveOption.Text = 0
        'TypeForm.ShowDialog()

    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        'Dim TypeForm As New NewConsultationType(Me)
        'TypeForm.LblSaveOption.Text = 1
        'TypeForm.TxtConsultName.Text = Me.ConsultTypeList.CurrentRow.Cells("consulttypename").Value
        'TypeForm.TxtConsultPrice.Text = Me.ConsultTypeList.CurrentRow.Cells("price").Value
        'TypeForm.ShowDialog()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Are you sure you want to delete this consultation type?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DA_ConsultType.DeleteConsultType(Me.ConsultTypeList.CurrentRow.Cells("consulttypeid").Value)
            RefreshData()
        End If
    End Sub
End Class
