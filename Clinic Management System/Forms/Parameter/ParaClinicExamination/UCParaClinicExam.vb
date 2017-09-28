Public Class UCParaClinicExam
    Dim DA_Para As New DSPAtientTableAdapters.tblparacheckTableAdapter
    Private Sub BtnNewConsultation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewConsultation.Click
        'Dim TypeForm As New NewParaClinicExam(Me)
        'TypeForm.LblSaveOption.Text = 0
        'TypeForm.ShowDialog()
    End Sub
    Sub RefreshData()

        ParaList.DataSource = DA_Para.SelectPara
    End Sub
    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        'Dim TypeForm As New NewParaClinicExam(Me)
        'TypeForm.LblSaveOption.Text = 1
        'TypeForm.TxtParaName.Text = Me.ParaList.CurrentRow.Cells("paracheck").Value
        'TypeForm.TxtParaPrice.Text = Me.ParaList.CurrentRow.Cells("servicecharge").Value
        'TypeForm.ShowDialog()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Are you sure you want to delete this para clinic examination?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DA_Para.DeletePara(Me.ParaList.CurrentRow.Cells("paracheckid").Value)
            RefreshData()
        End If
    End Sub

    Private Sub UCParaClinicExam_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RefreshData()
    End Sub
End Class
