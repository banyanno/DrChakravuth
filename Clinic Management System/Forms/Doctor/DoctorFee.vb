Public Class DoctorFee
    Dim DR_ConsultFee As New DSConsultationTableAdapters.DOCTOR_FEETableAdapter
    Dim DA_User As New DSUserManagermentTableAdapters.USERS_SYSTEMTableAdapter

    Private Sub DoctorFee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With cboDoctor
            .DataSource = DA_User.GetDoctorInfomation
            .ValueMember = "UserID"
            .DisplayMember = "ShowName"
            .SelectedIndex = -1
        End With
        If UserGlobleVariable.DEPART_ID = 1 Then
            GridDoctorFee.DataSource = DR_ConsultFee.SelectDoctorFee(DateConsultFrom.Value.Date, DateConsultTo.Value.Date)
        Else
            RadByDoctor.Checked = True
            cboDoctor.SelectedValue = USER_ID
            GridDoctorFee.DataSource = DR_ConsultFee.SelectByDoctor(CInt(cboDoctor.SelectedValue), DateConsultFrom.Value.Date, DateConsultTo.Value.Date)
            RadAllDoctor.Enabled = False
            cboDoctor.Enabled = False
        End If

    End Sub

    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnView.Click
        If RadByDoctor.Checked = True Then
            If ValidateCombobox(cboDoctor, "", ErrDoctorInfo) = False Then Exit Sub
            GridDoctorFee.DataSource = DR_ConsultFee.SelectByDoctor(CInt(cboDoctor.SelectedValue), DateConsultFrom.Value.Date, DateConsultTo.Value.Date)
        End If
        If RadAllDoctor.Checked = True Then
            GridDoctorFee.DataSource = DR_ConsultFee.SelectDoctorFee(DateConsultFrom.Value.Date, DateConsultTo.Value.Date)
        End If

    End Sub

    Private Sub RadByDoctor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByDoctor.CheckedChanged
        cboDoctor.Enabled = RadByDoctor.Checked
        cboDoctor.SelectedIndex = -1
    End Sub

    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        Dim TblDoctorFee As DataTable
        If RadAllDoctor.Checked = True Then
            TblDoctorFee = DR_ConsultFee.SelectDoctorFee(DateConsultFrom.Value.Date, DateConsultTo.Value.Date)
        Else
            TblDoctorFee = DR_ConsultFee.SelectByDoctor(CInt(cboDoctor.SelectedValue), DateConsultFrom.Value.Date, DateConsultTo.Value.Date)
        End If
        Dim RDoctor As New ReportDoctorFee
        RDoctor.SetDataSource(TblDoctorFee)
        RDoctor.SetParameterValue("DateFrom", Format(DateConsultFrom.Value.Date, "dd-MM-yyyy"))
        RDoctor.SetParameterValue("DateTo", Format(DateConsultTo.Value.Date, "dd-MM-yyyy"))
        CrystalReportViewer1.ReportSource = RDoctor
    End Sub
End Class
