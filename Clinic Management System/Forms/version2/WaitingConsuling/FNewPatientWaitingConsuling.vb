Public Class FNewPatientWaitingConsuling
    Dim DA_Patient As New DSPAtientTableAdapters.tblpatientTableAdapter
    Dim DA_Waiting As New DSPAtientTableAdapters.tblwaitingTableAdapter
    Dim UPatientInfo As PatientInformation
    Dim Appoint As Appointment
    Dim ppatientid As Integer
    ' Complaint Data.........................
    Dim DA_Complaint As New DSComplaintTableAdapters.tblcomplaintTableAdapter
    Dim DA_PreComplaintDetail As New DSComplaintTableAdapters.tblprecomplaintdetailTableAdapter
    ''Dim DA_V_ComplaintDetail As New DSComplaintTableAdapters.V_PATIENT_COMPLAINTTableAdapter
    ' -------------------------- Medical History -------------------------------------
    Dim DA_Medical As New DSMedicalHistoryTableAdapters.tblhistoryTableAdapter
    Dim DA_PreMedicalDetail As New DSMedicalHistoryTableAdapters.tblprehistorydetailTableAdapter
    ''Dim DA_V_MedicalHisDetail As New DSMedicalHistoryTableAdapters.V_MEDICAL_HISTORYTableAdapter

    '==================== Physical Examination ================================
    Dim DA_Physical As New DSPhysicalExamTableAdapters.tblPhysicalCheckTableAdapter
    Dim DA_PrePhysicalDetail As New DSPhysicalExamTableAdapters.tblprephysicalcheckdetailTableAdapter
    ''Dim DA_V_PhysicalDetail As New DSPhysicalExamTableAdapters.V_PHYSICAL_EXAMTableAdapter




    Dim DA_PrescriptionRemark As New DSInvoiceTableAdapters.PrescriptionRemarkTableAdapter
    Dim DA_Complaint1 As New DSInvoiceTableAdapters.ComplaintTableAdapter
    Dim DA_History1 As New DSInvoiceTableAdapters.HistoryTableAdapter
    Dim DA_Prescription1 As New DSInvoiceTableAdapters.PrescriptionDetailTableAdapter
    Dim DA_Biology1 As New DSInvoiceTableAdapters.BloodTableAdapter
    Dim DA_Fibroscopy1 As New DSInvoiceTableAdapters.FibroTableAdapter
    Dim DA_Coloscopy1 As New DSInvoiceTableAdapters.ColoTableAdapter
    Dim DA_Nasogastro1 As New DSInvoiceTableAdapters.NasoTableAdapter
    Dim DA_Echo1 As New DSInvoiceTableAdapters.EchoTableAdapter
    Dim DA_MRI1 As New DSInvoiceTableAdapters.MRITableAdapter
    Dim DA_Physical1 As New DSInvoiceTableAdapters.PhysicalExamTableAdapter
    Dim DA_CFAnaPath1 As New DSExaminationTableAdapters.CFAnaPathTableAdapter

    Dim DAPatient As New DSPAtientTableAdapters.tblpatientTableAdapter

    Dim DA_Scan1 As New DSInvoiceTableAdapters.ScanTableAdapter
    Dim DA_FibroScan1 As New DSInvoiceTableAdapters.FibroScan1TableAdapter
    Dim DoctorExam As DashbordDotorRequestExamination
    Dim DA_BreathTest As New DSExaminationTableAdapters.TblBreathTestTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal Appoint As Appointment)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Appoint = Appoint
        ' Add any initialization after the InitializeComponent() call.
        ppatientid = Appoint.AppointmentList.GetRow.Cells("ppatientid").Value
        SetPatientData(ppatientid)
    End Sub
    Sub New(ByVal PatientInforPanel As PatientInformation)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.UPatientInfo = PatientInforPanel
        ' Add any initialization after the InitializeComponent() call.
        ppatientid = UPatientInfo.GridPatientInfo.CurrentRow.Cells("ppatientid").Value
        SetPatientData(ppatientid)
    End Sub

    Sub New(ByVal DoctorExam As DashbordDotorRequestExamination)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.DoctorExam = DoctorExam
        ' Add any initialization after the InitializeComponent() call.
        ppatientid = DoctorExam.RequestList.GetRow.Cells("ppatientid").Value
        SetPatientData(ppatientid)
    End Sub
    Sub SetPatientData(ByVal patientID As Integer)
        'Try
        Dim Patient As New DataTable

        Patient = DA_Patient.SelectPatientByPID(patientID) '(UPatientInfo.GridPatientInfo.CurrentRow.Cells("ppatientid").Value)
        'MsgBox(Patient.Rows.Count & "    " & UPatientInfo.GridPatientInfo.CurrentRow.Cells("ppatientid").Value)
        Me.txtno.Text = Patient.Rows(0).Item("patientid")
        Me.txtname.Text = Patient.Rows(0).Item("pname")
        Me.txtsex.Text = Patient.Rows(0).Item("pgender")
        Me.txtdatebirth.Text = Format(Patient.Rows(0).Item("pAge"), "dd/MM/yyyy")
        Me.txtaddress.Text = Patient.Rows(0).Item("pcontactaddress")
        'Catch ex As Exception

        'End Try

    End Sub
    Dim DA_KeyWord As New DS_ParameterTableAdapters.KEY_WORDTableAdapter
    Private Sub FNewPatientWaitingConsuling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With CboComplaint
            .DataSource = DA_Complaint.GetData
            .ValueMember = DA_Complaint.GetData.Columns("complaintid").ColumnName
            .DisplayMember = DA_Complaint.GetData.Columns("complaint").ColumnName
            .SelectedIndex = -1
        End With
        With CboMedical
            .DataSource = DA_Medical.GetData
            .ValueMember = DA_Medical.GetData.Columns("historyid").ColumnName
            .DisplayMember = DA_Medical.GetData.Columns("history").ColumnName
            .SelectedIndex = -1
        End With
        With CboPhysicalExam
            .DataSource = DA_Physical.GetData
            .ValueMember = DA_Physical.GetData.Columns("physicalcheckid").ColumnName
            .DisplayMember = DA_Physical.GetData.Columns("physicalcheck").ColumnName
            .SelectedIndex = -1
        End With
        Dim tblKeywork As DataTable = DA_KeyWord.GetData

        For Each row As DataRow In tblKeywork.Rows
            AutocompleteMenu1.AddItem(row("KEY_VALUES"))
        Next
        txtwaitno.Select()
        txtwaitno.Focus()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateDateField(dtwaiting, "", Err) = False Then Exit Sub
        If ValidateTextField(txtwaitno, "", Err) = False Then Exit Sub
        If MessageBox.Show("Do you want to send this patient to the waiting list for doctor consultation?", "Send to doctor consultation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_Waiting.InsertWaiting(ppatientid, Me.txtwaitno.Text, Me.txtdesc.Text, FormatDateTime(Me.dtwaiting.Value, DateFormat.ShortDate), 1) = 1 Then
                deletePreTable()
                'If Me.CboComplaint.Text <> "" Then
                If GridPreComplaint.RowCount > 0 Then
                    For i As Int16 = 0 To GridPreComplaint.RowCount - 1
                        DA_PreComplaintDetail.InsertComplaint(txtno.Text, GridPreComplaint.GetRow(i).Cells("complaintid").Value, Me.TxtComplainDescription.Text)
                    Next
                End If

                'End If

                'If Me.CboMedical.Text <> "" Then
                If GridPreMedicalHistory.RowCount > 0 Then
                    For i As Int16 = 0 To GridPreMedicalHistory.RowCount - 1
                        DA_PreMedicalDetail.InsertHistory(txtno.Text, GridPreMedicalHistory.GetRow(i).Cells("historyid").Value, Me.TxtMedicalNote.Text)
                    Next
                End If

                'End If

                'If Me.CboPhysicalExam.Text <> "" Then
                If GridPrePhysical.RowCount > 0 Then
                    For i As Int16 = 0 To GridPrePhysical.RowCount - 1
                        DA_PrePhysicalDetail.InsertExam(txtno.Text, GridPrePhysical.GetRow(i).Cells("physicalcheckid").Value, Me.TxtPhysicalNote.Text)
                    Next
                End If

                'End If
                MsgBox("One patient has been sent successfully.", MsgBoxStyle.OkOnly, "Sent Successfully")
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Error sent patient to waiting list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        deletePreTable()
        Me.Close()
    End Sub

    Sub deletePreTable()
        DA_PreComplaintDetail.DeleteComplaint(CLng(Me.txtno.Text))
        DA_PreMedicalDetail.DeleteAllMedicince(CLng(Me.txtno.Text))
        DA_PrePhysicalDetail.DeleteExam(CLng(Me.txtno.Text))
    End Sub

    'Private Sub CboComplaint_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboComplaint.SelectionChangeCommitted
    '    'If Me.CboComplaint.Text <> "" Then
    '    '    Me.TxtComplainDescription.ReadOnly = False
    '    'Else
    '    '    Me.TxtComplainDescription.ReadOnly = True
    '    'End If
    'End Sub

    'Private Sub CboMedical_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboMedical.SelectionChangeCommitted
    '    'If Me.CboMedical.Text <> "" Then
    '    '    Me.TxtMedicalNote.ReadOnly = False
    '    'Else
    '    '    Me.TxtMedicalNote.ReadOnly = True
    '    'End If
    'End Sub

    'Private Sub CboPhysicalExam_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboPhysicalExam.SelectionChangeCommitted
    '    'If Me.CboPhysicalExam.Text <> "" Then
    '    '    Me.TxtPhysicalNote.ReadOnly = False
    '    'Else
    '    '    Me.TxtPhysicalNote.ReadOnly = True
    '    'End If
    'End Sub

    Private Sub BtnMedical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMedical.Click

        ''Show Report
        MainApplicationForm.StatusLoading(True)
        BgLoadingPatient.RunWorkerAsync()
    End Sub

    Private Sub BgLoadingPatient_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadingPatient.DoWork
        PreviewReport()
    End Sub
    Sub PreviewReport()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf PreviewReport))
        Else
            Dim PatientTable As DataTable
            Dim PatientID As Long
            PatientTable = DAPatient.SelectPatientByPID(ppatientid)
            PatientID = PatientTable.Rows(0).Item("ppatientid")

            Dim RptRecord As New RptPatientRecord
            ' Dim RptViewer As New FormReportViewer

            Dim PresRemark As DataTable = DA_PrescriptionRemark.SelectPrescriptionByPatientID(PatientID)
            Dim ComplaintTable As DataTable = DA_Complaint1.SelectByPatientID(PatientID)
            Dim HistoryTable As DataTable = DA_History1.SelectByPatientID(PatientID)
            Dim PrescriptionTable As DataTable = DA_Prescription1.SelectByPatientID(PatientID)

            Dim BiologyTable As DataTable = DA_Biology1.SelectByPatientID(PatientID)
            Dim FibroTable As DataTable = DA_Fibroscopy1.SelectByPatientID(PatientID)
            Dim ColoTable As DataTable = DA_Coloscopy1.SelectByPatientID(PatientID)

            Dim NasoTable As DataTable = DA_Nasogastro1.SelectByPatientID(PatientID)

            Dim EchoTable As DataTable = DA_Echo1.SelectByPatientID(PatientID)

            Dim ScanTable As DataTable = DA_Scan1.SelectByPatientID(PatientID)

            Dim FibroScan As DataTable = DA_FibroScan1.GetDataByPatientID(PatientID) 'SelectByPatientID(PatientID)

            Dim MRITable As DataTable = DA_MRI1.SelectByPatientID(PatientID)

            Dim CAAnaPath As DataTable = DA_CFAnaPath1.GetData(PatientID)

            Dim PhysicalTable As DataTable = DA_Physical1.SelectByPatientID(PatientID)
            Dim BreatTestTable As DataTable = DA_BreathTest.SelectBreathTestByPatientNo(CDbl(txtno.Text))

            RptRecord.Database.Tables("Patient").SetDataSource(PatientTable)
            RptRecord.Subreports("PrescriptionRemark").SetDataSource(PresRemark)
            RptRecord.Subreports("Complaint").Database.Tables("Complaint").SetDataSource(ComplaintTable)
            RptRecord.Subreports("History").Database.Tables("History").SetDataSource(HistoryTable)
            RptRecord.Subreports("Prescription").Database.Tables("PrescriptionDetail").SetDataSource(PrescriptionTable)
            RptRecord.Subreports("Biology").Database.Tables("Blood").SetDataSource(BiologyTable)
            RptRecord.Subreports("Fibroscopy").Database.Tables("Fibro").SetDataSource(FibroTable)
            RptRecord.Subreports("Coloscopy").Database.Tables("Colo").SetDataSource(ColoTable)
            RptRecord.Subreports("Nasogastro").Database.Tables("Naso").SetDataSource(NasoTable)
            RptRecord.Subreports("Echo").Database.Tables("Echo").SetDataSource(EchoTable)
            RptRecord.Subreports("FibroScan").Database.Tables("FibroScan1").SetDataSource(FibroScan)
            RptRecord.Subreports("Scan").Database.Tables("Scan").SetDataSource(ScanTable)
            RptRecord.Subreports("MRI").Database.Tables("MRI").SetDataSource(MRITable)
            RptRecord.Subreports("Physical").Database.Tables("PhysicalExam").SetDataSource(PhysicalTable)
            RptRecord.Subreports("ACAnaPath").Database.Tables("CFAnaPath").SetDataSource(CAAnaPath)
            RptRecord.Subreports("UreaBreathTest").Database.Tables("TblBreathTest").SetDataSource(BreatTestTable)
            Me.CRPatientDocViewer.ReportSource = RptRecord

        End If

    End Sub

    Private Sub BgLoadingPatient_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadingPatient.RunWorkerCompleted
        MainApplicationForm.StatusLoading(False)
    End Sub

    Private Sub BtnExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExam.Click
        Dim DocRequestExam As New MainDocRequestExam(Me)
        DocRequestExam.BtnFindPatient.Visible = True
        DocRequestExam.ShowDialog()
    End Sub

    Private Sub BtnParaExamHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnParaExamHistory.Click
        Dim FParaExam As New FormParaExamHistory
        FParaExam.LoadPatientInfo(Me.txtno.Text)
        FParaExam.ShowDialog()
    End Sub



    Private Sub BtnAddPreComplaint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddPreComplaint.Click
        If ValidateCombobox(CboComplaint, "", Err) = False Then Exit Sub
        If DA_PreComplaintDetail.ScalarPreComplaint(txtno.Text, CboComplaint.SelectedValue) > 0 Then
            MessageBox.Show("Complaint have been add to list already.", "Complaint", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboComplaint.Select()
            CboComplaint.Focus()
            CboComplaint.SelectAll()
        Else
            DA_PreComplaintDetail.InsertComplaint(txtno.Text, CboComplaint.SelectedValue, TxtComplainDescription.Text)
            GridPreComplaint.DataSource = DA_PreComplaintDetail.SelectByPPatientID(txtno.Text)
            CboComplaint.SelectedIndex = -1
        End If
        
    End Sub

    Private Sub BtnRemovePreComplaint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemovePreComplaint.Click
        If GridPreComplaint.SelectedItems.Count = 0 Then Exit Sub
        DA_PreComplaintDetail.DeleteBuyPre(GridPreComplaint.GetRow.Cells("preid").Value)
        GridPreComplaint.DataSource = DA_PreComplaintDetail.SelectByPPatientID(txtno.Text)
    End Sub

    Private Sub BtnAddMedicalHistor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddMedicalHistor.Click
        If ValidateCombobox(CboMedical, "", Err) = False Then Exit Sub
        If DA_PreMedicalDetail.ScalarMedicalHistory(txtno.Text, CboMedical.SelectedValue) > 0 Then
            MessageBox.Show("Medical History have been add to list already.", "Medical history", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboMedical.Select()
            CboMedical.SelectAll()
        Else
            DA_PreMedicalDetail.InsertHistory(txtno.Text, CboMedical.SelectedValue, TxtMedicalNote.Text)
            GridPreMedicalHistory.DataSource = DA_PreMedicalDetail.SelectByPPatientID(txtno.Text)
            CboMedical.SelectedIndex = -1
        End If
       
    End Sub

    Private Sub BtnRemoveMedicalHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveMedicalHistory.Click
        If GridPreMedicalHistory.SelectedItems.Count = 0 Then Exit Sub
        DA_PreMedicalDetail.DeleteHistory(GridPreMedicalHistory.GetRow.Cells("preid").Value)
        GridPreMedicalHistory.DataSource = DA_PreMedicalDetail.SelectByPPatientID(txtno.Text)
    End Sub

    Private Sub BtnAddPrePhysical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddPrePhysical.Click
        If ValidateCombobox(CboPhysicalExam, "", Err) = False Then Exit Sub
        If DA_PrePhysicalDetail.ScalarPhysicalCheck(txtno.Text, CboPhysicalExam.SelectedValue) > 0 Then
            MessageBox.Show("Physical exam have been add to list already.", "Physical Exam", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboPhysicalExam.Select()
            CboPhysicalExam.SelectAll()
        Else
            DA_PrePhysicalDetail.InsertExam(txtno.Text, CboPhysicalExam.SelectedValue, TxtPhysicalNote.Text)
            GridPrePhysical.DataSource = DA_PrePhysicalDetail.SelectByPPatientID(txtno.Text)
            CboPhysicalExam.SelectedIndex = -1
        End If
        
    End Sub

    Private Sub BtnRemovePrePhysical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemovePrePhysical.Click
        If GridPrePhysical.SelectedItems.Count = 0 Then Exit Sub
        DA_PrePhysicalDetail.DeleteByPrePhysical(GridPrePhysical.GetRow.Cells("preid").Value)
        GridPrePhysical.DataSource = DA_PrePhysicalDetail.SelectByPPatientID(txtno.Text)
    End Sub
End Class