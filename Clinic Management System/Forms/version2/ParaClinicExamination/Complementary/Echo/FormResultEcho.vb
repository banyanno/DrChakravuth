Public Class FormResultEcho
    Dim DA_Conclusion As New DSExaminationTableAdapters.tblconclusionTableAdapter
    Dim DA_EchoConclusion As New DSExaminationTableAdapters.tblechoconclusionTableAdapter
    Dim DA_Echo As New DSExaminationTableAdapters.tblechoTableAdapter
    Dim DA_Doctor As New DSPAtientTableAdapters.DoctorsTableAdapter
    Dim DA_DOCTOR_FEE As New DSConsultationTableAdapters.DOCTOR_FEETableAdapter
    Dim RequestPanel As DashbordDotorRequestExamination
    Dim DA_EchoImg As New DSEchoTableAdapters.tblechoImageTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal PanelRequest As DashbordDotorRequestExamination)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.RequestPanel = PanelRequest
    End Sub
    Private Sub FormResultEcho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboEchoDemander.DataSource = DA_Doctor.SelectDoctor
        Me.cboEchoDemander.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        Me.cboEchoDemander.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        cboEchoDemander.SelectedIndex = -1

        Me.CboDoctorExam.DataSource = DA_Doctor.SelectDoctor
        Me.CboDoctorExam.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        Me.CboDoctorExam.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        CboDoctorExam.SelectedIndex = -1

        Me.cboEchoConclusion.DataSource = DA_Conclusion.SelectConclusion
        Me.cboEchoConclusion.ValueMember = DA_Conclusion.SelectConclusion.Columns("conclusion_id").ColumnName
        Me.cboEchoConclusion.DisplayMember = DA_Conclusion.SelectConclusion.Columns("conclusion_name").ColumnName
        cboEchoConclusion.SelectedIndex = -1
        LoadEchoData()

    End Sub
    Sub LoadEchoData()
        If DA_Echo.SelectEchoByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
            Dim EchoTable As New DataTable
            EchoTable = DA_Echo.SelectEchoByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value))
            Me.cboEchoDemander.SelectedValue = EchoTable.Rows(0).Item("demander")
            Me.CboDoctorExam.Text = EchoTable.Rows(0).Item("ExamBy")
            Me.txtEchoIndication.Text = EchoTable.Rows(0).Item("indication")
            Me.txtEchoLaProstate.Text = EchoTable.Rows(0).Item("la_prostate")
            Me.txtEchoLaRate.Text = EchoTable.Rows(0).Item("la_rate")
            Me.txtEchoLaVeine.Text = EchoTable.Rows(0).Item("la_veine")
            Me.txtEchoLaVesicule.Text = EchoTable.Rows(0).Item("la_vesicule")
            Me.txtEchoLaVessie.Text = EchoTable.Rows(0).Item("la_vessie")
            Me.txtEchoLeFoie.Text = EchoTable.Rows(0).Item("le_foie")
            Me.txtEchoLePancreas.Text = EchoTable.Rows(0).Item("le_pancreas")
            Me.txtEchoLesReins.Text = EchoTable.Rows(0).Item("les_reins")
            Me.txtEchoLesVoies.Text = EchoTable.Rows(0).Item("les_voies")
            Me.txtechomoreinfo.Text = EchoTable.Rows(0).Item("more_info")
            If TypeOf EchoTable.Rows(0).Item("ResultOfEcho") Is DBNull Then
            Else
                Me.TxtResult.Text = EchoTable.Rows(0).Item("ResultOfEcho")
            End If
            ''Load Conclusion Data
            Me.ConclusionList.DataSource = DA_EchoConclusion.SelectConclusionByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value))
            RefreshImage(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value))
        End If
    End Sub
    Sub RefreshConclusionList()
        Me.ConclusionList.DataSource = DA_EchoConclusion.SelectConclusionByRequestID(CInt(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value))
    End Sub

    Private Sub BtnAddConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddConclusion.Click
        If DA_EchoConclusion.SelectConclusion(CInt(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value), CInt(Me.cboEchoConclusion.SelectedValue)).Rows.Count > 0 Then
            MsgBox("The conclusion was added already", MsgBoxStyle.OkOnly, "Existing Conclusion")
        Else
            DA_EchoConclusion.Insert(CInt(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value), CInt(Me.cboEchoConclusion.SelectedValue))
            RefreshConclusionList()
            cboEchoConclusion.SelectedIndex = -1
        End If

    End Sub

    Private Sub BtnRemoveConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveConclusion.Click
        If Me.ConclusionList.RowCount >= 1 Then
            DA_EchoConclusion.DeleteConclusion(CInt(Me.ConclusionList.CurrentRow.Cells("request_id").Value), CInt(Me.ConclusionList.CurrentRow.Cells("conclusion_id").Value))
            RefreshConclusionList()
        End If
    End Sub



    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If DA_Echo.SelectEchoByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows.Count <= 0 Then
            DA_EchoConclusion.DeleteConclusionByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value))
        End If
        Me.Close()
    End Sub


    Private Sub BtnAddImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddImg.Click
        Dim Img As New ImageEcho(Me)
        Img.LblRequesID.Text = CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)
        Img.Show()
    End Sub

    Private Sub BtnSaveEcho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveEcho.Click
        If ValidateCombobox(cboEchoDemander, "", ErrAlert) = False Then Exit Sub
        If ValidateCombobox(CboDoctorExam, "", ErrAlert) = False Then Exit Sub
        If MessageBox.Show("Do you want save Echo?", "Echo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_Echo.SelectEchoByRequestID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)).Rows.Count >= 1 Then
                '' Update
                If DA_Echo.UpdateEchoByRequestID(Me.cboEchoDemander.SelectedValue.ToString, Me.txtEchoIndication.Text, Me.txtEchoLeFoie.Text, Me.txtEchoLaVeine.Text, Me.txtEchoLaVesicule.Text, Me.txtEchoLesVoies.Text, Me.txtEchoLePancreas.Text, Me.txtEchoLaRate.Text, Me.txtEchoLesReins.Text, Me.txtEchoLaProstate.Text, Me.txtEchoLaVessie.Text, Me.txtechomoreinfo.Text.ToString, TxtResult.Text, DateResultExam.Value.Date, USER_ID, SHOW_NAME, CboDoctorExam.Text, CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value)) = 1 Then
                    MsgBox("The echo has been saved successfully", MsgBoxStyle.OkOnly, "Saved Echo")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            Else
                '' Add New
                If DA_Echo.InsertEcho(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value), CLng(LblPatientNo.Text), Me.cboEchoDemander.SelectedValue.ToString, Me.txtEchoIndication.Text, Me.txtEchoLeFoie.Text, Me.txtEchoLaVeine.Text, Me.txtEchoLaVesicule.Text, Me.txtEchoLesVoies.Text, Me.txtEchoLePancreas.Text, Me.txtEchoLaRate.Text, Me.txtEchoLesReins.Text, Me.txtEchoLaProstate.Text, Me.txtEchoLaVessie.Text, Me.txtechomoreinfo.Text, TxtResult.Text, DateResultExam.Value.Date, USER_ID, USER_NAME, CboDoctorExam.Text) = 1 Then
                    MsgBox("An echo has been saved successfully", MsgBoxStyle.OkOnly, "Saved Echo")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    DA_DOCTOR_FEE.InsertNewDoctorFee(USER_ID, SHOW_NAME, "Echo", DateResultExam.Value.Date, 0, LblPatientNo.Text, lblPatientName.Text, txtechomoreinfo.Text)
                    DA_EchoConclusion.InsertNewEchoConclustion(CInt(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value), txtechomoreinfo.Text)
                End If
            End If
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Public Sub RefreshImage(ByVal RequestID As Double)
        GridImage.DataSource = DA_EchoImg.SelectImageByEchoID(RequestID)
    End Sub

    Private Sub BtnRemoveImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveImg.Click
        If GridImage.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to remove image?", "Echo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_EchoImg.DeleteImage(GridImage.GetRow.Cells("IMG_ECHO_ID").Value) = 1 Then
                RefreshImage(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value))
            End If
        End If
    End Sub
End Class