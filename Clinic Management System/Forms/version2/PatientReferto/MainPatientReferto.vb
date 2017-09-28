Public Class MainPatientReferto
    Dim DA_H_Referal As New DSReferalTableAdapters.V_HOSPITAL_REFERALTableAdapter
    Dim DA_Hospital As New DSReferalTableAdapters.HOSPITAL_REFERALTableAdapter
    Private Sub BtnNewPatientReferance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        If GridPatientHospitalReferal.SelectedItems.Count = 0 Then Exit Sub
        Dim FNewRefer As New NewReferTo
        FNewRefer.LblSaveOption.Text = GridPatientHospitalReferal.GetRow.Cells("REFEREND_NO").Value
        FNewRefer.LblPatientNo.Text = GridPatientHospitalReferal.GetRow.Cells("PATIENT_NO").Value
        FNewRefer.txtno.Text = GridPatientHospitalReferal.GetRow.Cells("patientid").Value
        FNewRefer.txtname.Text = GridPatientHospitalReferal.GetRow.Cells("pname").Value
        FNewRefer.txtsex.Text = GridPatientHospitalReferal.GetRow.Cells("pgender").Value
        FNewRefer.txtdatebirth.Text = GridPatientHospitalReferal.GetRow.Cells("pAge").Value
        FNewRefer.txtaddress.Text = GridPatientHospitalReferal.GetRow.Cells("pcontactaddress").Value
        FNewRefer.CboRefferendTo.SelectedValue = GridPatientHospitalReferal.GetRow.Cells("HOSPITAL_NO").Value
        FNewRefer.DateRefer.Checked = True
        FNewRefer.DateRefer.Value = GridPatientHospitalReferal.GetRow.Cells("DATE_REFER").Value
        If FNewRefer.ShowDialog = DialogResult.OK Then
            RefreshData()
        End If
    End Sub

    Private Sub BtnCreatePlace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreatePlace.Click
        Dim MHospital As New MainHospital
        MHospital.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        RefreshData()
    End Sub
    Private Sub RefreshData()
        GridPatientHospitalReferal.DataSource = DA_H_Referal.GetData
    End Sub

    Private Sub MainPatientReferto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If GridPatientHospitalReferal.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_Hospital.DeletePatientReferal(GridPatientHospitalReferal.GetRow.Cells("REFEREND_NO").Value) = 1 Then
                MessageBox.Show("Delete successful.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshData()
            Else
                MessageBox.Show("Error delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class
