Public Class Appointment
    Dim DA_Appointment As New DSPAtientTableAdapters.AppointmentsTableAdapter
    Dim DA_App_List As New DSPAtientTableAdapters.VAppointmentTableAdapter
    Private Sub BtnNewAppointment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewAppointment.Click
        Dim AppForm As New NewAppointment(Me)
        AppForm.txtno.Text = ""
        AppForm.txtname.Text = ""
        AppForm.txtsex.Text = ""
        AppForm.txtdatebirth.Text = ""
        AppForm.txtaddress.Text = ""
        If AppForm.ShowDialog() = DialogResult.OK Then
            LoadDataToGridView()
        End If
    End Sub
    Sub LoadDataToGridView()
        Me.AppointmentList.DataSource = DA_App_List.GetDataByAllDate(Now.Date, Now.Date)
    End Sub
    Public Sub FindingApp(ByVal ValFind As Object, ByVal dateF As Date, ByVal dateT As Date, ByVal Condtion As Integer)
        If Condtion = 1 Then
            AppointmentList.DataSource = DA_App_List.GetDataByPatientIDWithDate(CInt(ValFind), dateF, dateT)
        ElseIf Condtion = 2 Then
            AppointmentList.DataSource = DA_App_List.GetDataByPatientNameWithDate("%" & ValFind & "%", dateF, dateT)
        ElseIf Condtion = 3 Then
            AppointmentList.DataSource = DA_App_List.GetDataByPhoneNoWithDate("%" & ValFind & "%", dateF, dateT)
        ElseIf Condtion = 4 Then
            AppointmentList.DataSource = DA_App_List.GetDataByAllDate(dateF, dateT)
        End If
    End Sub
   
    Private Sub Appointment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadDataToGridView()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If (MsgBox("Are you sure you want to delete this appointment?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            DA_Appointment.DeleteAppointment(Me.AppointmentList.CurrentRow.Cells(0).Value)
            LoadDataToGridView()
        End If
    End Sub


    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        Dim FrmSearch As New SearchAppointment(Me)
        FrmSearch.ShowDialog()
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadDataToGridView()

    End Sub
   
    Private Sub ToolStrip2_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip2.ItemClicked

    End Sub

    Private Sub BtnPatientConsult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPatientConsult.Click
        If AppointmentList.SelectedItems.Count = 0 Then Exit Sub
        Dim PatientWatienting As New FNewPatientWaitingConsuling(Me)
        If PatientWatienting.ShowDialog() = DialogResult.OK Then
            AppointmentList.DataSource = Nothing
        End If
    End Sub

    Private Sub btnUpdateStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateStatus.Click
        If AppointmentList.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to set appointment ready?", "Appoint", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_Appointment.UpdateAppStatus(False, AppointmentList.GetRow.Cells("Appoint_ID").Value) = 1 Then
                LoadDataToGridView()
            End If

        End If
    End Sub

    Private Sub AppointmentList_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles AppointmentList.RowDoubleClick
        Dim AppForm As New NewAppointment(Me)
        AppForm.LblSaveOption.Text = AppointmentList.GetRow.Cells("Appoint_ID").Value
        AppForm.txtno.Text = AppointmentList.GetRow.Cells("Patient_ID").Value
        AppForm.txtname.Text = AppointmentList.GetRow.Cells("pname").Value
        AppForm.txtsex.Text = AppointmentList.GetRow.Cells("pgender").Value
        AppForm.txtdatebirth.Text = AppointmentList.GetRow.Cells("pAge").Value
        AppForm.txtaddress.Text = AppointmentList.GetRow.Cells("pcontactaddress").Value
        AppForm.DtAppointment.Checked = True
        AppForm.DtAppointment.Value = AppointmentList.GetRow.Cells("Appoint_Date").Value
        AppForm.CboDoctor.SelectedValue = AppointmentList.GetRow.Cells("Doctor_ID").Value
        AppForm.txtcomment.Text = AppointmentList.GetRow.Cells("Appoint_Desc").Value
        If AppForm.ShowDialog() = DialogResult.OK Then
            LoadDataToGridView()
        End If
    End Sub

    Private Sub BtnRefresh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        LoadDataToGridView()
    End Sub
End Class
