Public Class DoctorFee
    Dim DR_ConsultFee As New DSConsultationTableAdapters.DOCTOR_FEETableAdapter
    Dim DA_User As New DSUserManagermentTableAdapters.USERS_SYSTEMTableAdapter
    Dim DA_DoctorByParaExam As New DSDoctorFeeTableAdapters.ViewDoctorParaxamTableAdapter
    Dim DA_DoctorByCounsultation As New DSDoctorFeeTableAdapters.ViewDoctorCounsultationTableAdapter

    Private Sub DoctorFee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With cboDoctor
            .DataSource = DA_User.GetDoctorInfomation
            .ValueMember = "UserID"
            .DisplayMember = "UserName"
            .SelectedIndex = -1
        End With
        'If UserGlobleVariable.DEPART_ID = 1 Then
        '    RadByDoctor.Checked = True
        '    cboDoctor.SelectedValue = USER_ID
        '    GridDoctorFee.DataSource = DR_ConsultFee.SelectDoctorFee(DateConsultFrom.Value.Date, DateConsultTo.Value.Date)
        '    RadAllDoctor.Enabled = False
        '    cboDoctor.Enabled = False
        'Else
        '    RadByDoctor.Checked = True
        '    cboDoctor.SelectedValue = USER_ID
        '    GridDoctorFee.DataSource = DR_ConsultFee.SelectByDoctor(CInt(cboDoctor.SelectedValue), DateConsultFrom.Value.Date, DateConsultTo.Value.Date)
        '    RadAllDoctor.Enabled = False
        '    cboDoctor.Enabled = False
        'End If

    End Sub

    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnView.Click
        If RadByDoctor.Checked = True Then
            If ValidateCombobox(cboDoctor, "", ErrDoctorInfo) = False Then Exit Sub
            GridConsultation.DataSource = DA_DoctorByCounsultation.SelectDoctorFeeByDate(DateConsultFrom.Value.Date, DateConsultTo.Value.Date, cboDoctor.SelectedValue)
            GridParaExam.DataSource = DA_DoctorByParaExam.SelectByDoctor(DateConsultFrom.Value.Date, DateConsultTo.Value.Date, cboDoctor.SelectedValue)
        End If
        If RadAllDoctor.Checked = True Then
            GridConsultation.DataSource = DA_DoctorByCounsultation.SelectDrCounsultByDate(DateConsultFrom.Value.Date, DateConsultTo.Value.Date)
            GridParaExam.DataSource = DA_DoctorByParaExam.SelectAllFree(DateConsultFrom.Value.Date, DateConsultTo.Value.Date)
        End If

    
    End Sub

    Private Sub RadByDoctor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByDoctor.CheckedChanged
        cboDoctor.Enabled = RadByDoctor.Checked
        cboDoctor.SelectedIndex = -1
    End Sub

    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        MainApplicationForm.StatusLoading(True)
        BGLoadingReport.RunWorkerAsync()
   
    End Sub
    Dim ReportConsult As New CRVDoctorFeeForCounsultation
    Dim TblDoctorFee As DataTable
    Dim RPParaTotalExam As New CRVParaExamTotal
    Dim ReportConsultParaFee As New CRVDoctorFeeForParaExam
    Private Sub PrintPreviewReport()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf PrintPreviewReport))
        Else

            If RadByDoctorCounsultation.Checked = True Then
                If RadAllDoctor.Checked = True Then
                    TblDoctorFee = DA_DoctorByCounsultation.SelectDrCounsultByDate(DateConsultFrom.Value.Date, DateConsultTo.Value.Date)
                ElseIf RadByDoctor.Checked = True Then
                    If ValidateCombobox(cboDoctor, "", ErrDoctorInfo) = False Then Exit Sub
                    TblDoctorFee = DA_DoctorByCounsultation.SelectDoctorFeeByDate(DateConsultFrom.Value.Date, DateConsultTo.Value.Date, cboDoctor.SelectedValue)
                End If
            ElseIf RadByDoctorParaExam.Checked = True Then
                If RadAllDoctor.Checked = True Then
                    TblDoctorFee = DA_DoctorByParaExam.SelectAllFree(DateConsultFrom.Value.Date, DateConsultTo.Value.Date)  'DR_ConsultFee.SelectDoctorFee(DateConsultFrom.Value.Date, DateConsultTo.Value.Date)
                ElseIf RadByDoctor.Checked = True Then
                    If ValidateCombobox(cboDoctor, "", ErrDoctorInfo) = False Then Exit Sub
                    TblDoctorFee = DA_DoctorByParaExam.SelectByDoctor(DateConsultFrom.Value.Date, DateConsultTo.Value.Date, cboDoctor.SelectedValue)  ' DR_ConsultFee.SelectByDoctor(CInt(cboDoctor.SelectedValue), DateConsultFrom.Value.Date, DateConsultTo.Value.Date)
                End If
            ElseIf RadAllParaExam.Checked = True Then
                TblDoctorFee = DA_DoctorByParaExam.SelectAllFree(DateConsultFrom.Value.Date, DateConsultTo.Value.Date)
            End If
        End If

    End Sub
    Private Sub PrintReportComplete()
        If RadByDoctorCounsultation.Checked = True Then
            ReportConsult.SetDataSource(TblDoctorFee)
            CrystalReportViewer1.ReportSource = ReportConsult
            If RadAllDoctor.Checked = True Then
                ReportConsult.SetParameterValue("title", "All consultation From: " & Format(DateConsultFrom.Value.Date.Date, "dd-MM-yyyy") & " To: " & Format(DateConsultTo.Value.Date, "dd-MM-yyyy"))
            ElseIf RadByDoctor.Checked = True Then
                ReportConsult.SetParameterValue("title", "By Doctor consultation From: " & Format(DateConsultFrom.Value.Date.Date, "dd-MM-yyyy") & " To: " & Format(DateConsultTo.Value.Date, "dd-MM-yyyy"))
            End If
        ElseIf RadByDoctorParaExam.Checked = True Then
            ReportConsultParaFee.SetDataSource(TblDoctorFee)
            CrystalReportViewer1.ReportSource = ReportConsultParaFee
            If RadAllDoctor.Checked = True Then
                ReportConsultParaFee.SetParameterValue("title", "All para exam From: " & Format(DateConsultFrom.Value.Date.Date, "dd-MM-yyyy") & " To: " & Format(DateConsultTo.Value.Date, "dd-MM-yyyy"))
            ElseIf RadByDoctor.Checked = True Then
                ReportConsultParaFee.SetParameterValue("title", "By Doctor para exam From: " & Format(DateConsultFrom.Value.Date.Date, "dd-MM-yyyy") & " To: " & Format(DateConsultTo.Value.Date, "dd-MM-yyyy"))
            End If
        ElseIf RadAllParaExam.Checked = True Then
            RPParaTotalExam.SetDataSource(TblDoctorFee)
            RPParaTotalExam.SetParameterValue("title", "All para exam From: " & Format(DateConsultFrom.Value.Date.Date, "dd-MM-yyyy") & " To: " & Format(DateConsultTo.Value.Date, "dd-MM-yyyy"))
            CrystalReportViewer1.ReportSource = RPParaTotalExam
        End If
    End Sub

    Private Sub BGLoadingReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGLoadingReport.DoWork
        PrintPreviewReport()
    End Sub

    Private Sub BGLoadingReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGLoadingReport.RunWorkerCompleted
        PrintReportComplete()
        MainApplicationForm.StatusLoading(False)
    End Sub

    Private Sub RadAllParaExam_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadAllParaExam.CheckedChanged
        GSelectDoctor.Enabled = False
    End Sub

    Private Sub RadByDoctorCounsultation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByDoctorCounsultation.CheckedChanged
        GSelectDoctor.Enabled = True
    End Sub

    Private Sub RadByDoctorParaExam_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByDoctorParaExam.CheckedChanged
        GSelectDoctor.Enabled = True
    End Sub
End Class
