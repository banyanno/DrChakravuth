Public Class MainHospital
    Dim DA_Hospital_Info As New DSReferalTableAdapters.HOSPITALTableAdapter
    Private Sub BtnNewHospital_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewHospital.Click
        Dim NHospital As New NewHospital
        If NHospital.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Show_Hospital()
        End If
    End Sub
    Sub Show_Hospital()
        GridHospital.DataSource = DA_Hospital_Info.GetData
    End Sub

    Private Sub MainHospital_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Show_Hospital()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If GridHospital.SelectedItems.Count = 0 Then
        Else
            Dim NHospital As New NewHospital
            NHospital.LblSaveOption.Text = GridHospital.GetRow.Cells("HOSPITAL_NO").Value
            NHospital.TxtHospitalName.Text = GridHospital.GetRow.Cells("HOSPITAL_NAME").Value
            NHospital.TxtHospitalDescription.Text = GridHospital.GetRow.Cells("HOSPITAL_NOTE").Value
            If NHospital.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Show_Hospital()
            End If
        End If
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If GridHospital.SelectedItems.Count = 0 Then
        Else
            If MessageBox.Show("Do you want delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Hospital_Info.DeleteHospitalInfo(GridHospital.GetRow.Cells("HOSPITAL_NO").Value) = 1 Then
                    MessageBox.Show("Delete successfull.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Show_Hospital()
                End If
            End If
        End If
    End Sub
End Class