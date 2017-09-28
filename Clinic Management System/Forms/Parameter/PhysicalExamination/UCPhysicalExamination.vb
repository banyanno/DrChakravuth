Public Class UCPhysicalExamination
    Dim DA_Physical As New DSPAtientTableAdapters.tblPhysicalCheckTableAdapter
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Are you sure you want to delete this physical examination?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DA_Physical.DeletePhysical(Me.PhysicalList.CurrentRow.Cells("physicalcheckid").Value)
            RefreshData()
        End If
    End Sub
    Sub RefreshData()
        Me.PhysicalList.DataSource = DA_Physical.SelectPhysical
    End Sub
    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        'Dim PhysicalForm As New NewPhysicalExamination(Me)
        'PhysicalForm.LblSaveOption.Text = 1
        'PhysicalForm.TxtExamName.Text = Me.PhysicalList.CurrentRow.Cells("physicalcheck").Value
        'PhysicalForm.ShowDialog()
    End Sub

    Private Sub BtnNewConsultation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewConsultation.Click
        'Dim PhysicalForm As New NewPhysicalExamination(Me)
        'PhysicalForm.LblSaveOption.Text = 0
        'PhysicalForm.ShowDialog()
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub PhysicalList_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles PhysicalList.FormattingRow

    End Sub

    Private Sub UCPhysicalExamination_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RefreshData()
    End Sub
End Class
