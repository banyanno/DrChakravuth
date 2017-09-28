Public Class DoctorInformation
    Dim DA_Doctor As New DSPAtientTableAdapters.DoctorsTableAdapter
    Private Sub DoctorInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoctorList.DataSource = DA_Doctor.GetData
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        'Dim Doc As New NewDoctor(Me)
        'Doc.lblaction.Text = 0
        'Doc.lblaction.Text = 0
        'Doc.ShowDialog()
    End Sub
    Sub RefreshData()
        Me.DoctorList.DataSource = DA_Doctor.SelectDoctor
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Are you sure you want to delete this doctor?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DA_Doctor.DeleteDoctor(DoctorList.CurrentRow.Cells("Doctor_ID").Value)
            RefreshData()
        End If
    End Sub

    Private Sub BtnDelete_DisplayStyleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDelete.DisplayStyleChanged

    End Sub

    Private Sub BtnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        'Dim Doc As New NewDoctor(Me)
        'Doc.lblaction.Text = 1
        'Doc.txtname.Text = DoctorList.CurrentRow.Cells("Doctor_Name").Value
        'Doc.txtphone.Text = DoctorList.CurrentRow.Cells("Phone").Value
        'Doc.txtdesc.Text = DoctorList.CurrentRow.Cells("Other_Info").Value
        'Doc.ShowDialog()
    End Sub

    Private Sub DoctorList_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles DoctorList.FormattingRow

    End Sub
End Class
