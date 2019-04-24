Imports CrystalDecisions.Shared

Public Class EditConsultation
    Dim DA_Waiting As New DSPAtientTableAdapters.tblwaitingTableAdapter
    Dim DA_Result As New DSConsultationTableAdapters.tblcheckresultTableAdapter
    Dim DA_BloodItem As New DSExaminationTableAdapters.tblblooditemTableAdapter
    Dim DA_Doctor As New DSPAtientTableAdapters.DoctorsTableAdapter
    Dim DA_Diagnosis As New DSPAtientTableAdapters.tbldiagnosisTableAdapter
    Dim DA_ConsultType As New DSPAtientTableAdapters.tblConsultTypeTableAdapter
    Dim DA_Medicine As New DSPAtientTableAdapters.tblmedicineTableAdapter
    Dim DA_Unit As New DSPAtientTableAdapters.tblunitTableAdapter
    Dim DA_Prescription As New DSPAtientTableAdapters.tblprescriptionTableAdapter
    Dim DA_PrescriptionDetail As New DSPAtientTableAdapters.tblprescriptionDetailTableAdapter
    Dim DA_Patient As New DS_PrescriptionTableAdapters.tblpatientTableAdapter
    Dim DA_PreInvoice As New DSInvoiceTableAdapters.tbl_preinvoiceTableAdapter
    ' Pre Consultation '
    Dim DA_PreConsultation As New DSConsultationTableAdapters.tbl_preinvoice_consultationTableAdapter
    ' Complaint Data.........................
    Dim DA_Complaint As New DSComplaintTableAdapters.tblcomplaintTableAdapter
    Dim DA_ComplaintDetail As New DSComplaintTableAdapters.tblcomplaintdetailTableAdapter
    ''Dim DA_V_ComplaintDetail As New DSComplaintTableAdapters.V_PATIENT_COMPLAINTTableAdapter
    ' -------------------------- Medical History -------------------------------------
    Dim DA_Medical As New DSMedicalHistoryTableAdapters.tblhistoryTableAdapter
    Dim DA_MedicalDetail As New DSMedicalHistoryTableAdapters.tblhistorydetailTableAdapter
    ''Dim DA_V_MedicalHisDetail As New DSMedicalHistoryTableAdapters.V_MEDICAL_HISTORYTableAdapter

    '==================== Physical Examination ================================
    Dim DA_Physical As New DSPhysicalExamTableAdapters.tblPhysicalCheckTableAdapter
    Dim DA_PhysicalDetail As New DSPhysicalExamTableAdapters.tblphysicalcheckdetailTableAdapter
    ''Dim DA_V_PhysicalDetail As New DSPhysicalExamTableAdapters.V_PHYSICAL_EXAMTableAdapter
    ' Usage 
    Dim DA_Usage As New DS_PrescriptionTableAdapters.PRESCRIPTION_USAGETableAdapter

    Private VALUE_LOADING_DATA As Integer
    Dim ConsultList As ConsultationList
    Dim HistoryConsult As UPatientMedicalReport
    Dim DAItem As New DSPAtientTableAdapters.tblItemTableAdapter
    Dim PpatientidAuto As Long
    Dim PatientNo As Long
    Dim prescriptionid As Long


    Sub New(ByVal Consult As ConsultationList)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.ConsultList = Consult
        PatientNo = CLng(ConsultList.Prescription_List.CurrentRow.Cells("patientid").Value)
        PpatientidAuto = CLng(ConsultList.Prescription_List.CurrentRow.Cells("ppatientid").Value)
        prescriptionid = CLng(ConsultList.Prescription_List.CurrentRow.Cells("prescriptionid").Value)
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal HistoryConsult As UPatientMedicalReport)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.HistoryConsult = HistoryConsult
        PatientNo = CLng(HistoryConsult.GridPatientConsult.CurrentRow.Cells("patientid").Value)
        PpatientidAuto = CLng(HistoryConsult.GridPatientConsult.CurrentRow.Cells("ppatientid").Value)
        prescriptionid = CInt(HistoryConsult.GridPatientConsult.GetRow.Cells("prescriptionid").Value)

        lblPrintPrescription.Text = CInt(HistoryConsult.GridPatientConsult.GetRow.Cells("prescriptionid").Value)
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        'If MsgBox("Are you sure you want to cancel this consulation?", MsgBoxStyle.YesNo, "Confirm Concellation") = MsgBoxResult.Yes Then
        Me.Close()
        'End If
    End Sub

    Private Sub LoadingData_And_Report()
        If ValidateDateTimePicker(dtprescription, "", ErrPrescription) = False Then Exit Sub
        If ValidateCombobox(cboconsulttype, "", ErrPrescription) = False Then Exit Sub
        If ValidateCombobox(cbodiagnosis, "", ErrPrescription) = False Then Exit Sub
        'If ValidateCombobox(cbodoc, "", ErrPrescription) = False Then Exit Sub


        Dim PatientTable As New DataTable

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadingData_And_Report))
        Else
            If MessageBox.Show("Do you want to update this consultation?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                MainApplicationForm.StatusLoading(True)
                Dim ParaList As New DataTable
                Dim PhysicalList As New DataTable
                Dim ComplaintList As New DataTable
                Dim HistoryList As New DataTable
                Dim PrescriptionList As New DataTable

                Dim ConsultPrice As Double = DA_ConsultType.SelectConsultByID(CInt(Me.cboconsulttype.SelectedValue)).Rows(0).Item("price")
                'Update Table Presription (Primary Table)
                DA_Prescription.UpdatePrescription(PpatientidAuto, CInt(lblUserID.Text), Me.cbodiagnosis.Text, cboconsulttype.Text, ConsultPrice, Me.txtremark.Text, prescriptionid)


                '-------Update Complaint --------
                'If DA_ComplaintDetail.SelectComplaintByPrescriptionID(prescriptionid).Rows.Count > 0 Then
                DA_ComplaintDetail.UpdateComplainNote(Me.TxtComplainDescription.Text, prescriptionid)
                'Else
                '    DA_ComplaintDetail.InsertComplaint(CInt(Me.CboComplaint.SelectedValue), prescriptionid, Me.TxtComplainDescription.Text)
                'End If
                '-------Update Medical History --------
                'If DA_MedicalDetail.SelectHistoryByPrescriptionID(prescriptionid).Rows.Count > 0 Then
                DA_MedicalDetail.UpdateMedicalNote(Me.TxtMedicalNote.Text, prescriptionid)
                'Else
                '    DA_MedicalDetail.InsertHistory(CInt(Me.CboMedical.SelectedValue), prescriptionid, Me.TxtMedicalNote.Text)
                'End If
                '-------Update Physicl Exam--------
                'If DA_PhysicalDetail.SelectPhysicalByPrescriptionID(prescriptionid).Rows.Count > 0 Then
                DA_PhysicalDetail.UpdatePhysicalNote(Me.TxtPhysicalNote.Text, prescriptionid)
                'Else
                '    DA_PhysicalDetail.InsertPhysical(CInt(Me.CboPhysicalExam.SelectedValue), prescriptionid, Me.TxtPhysicalNote.Text)
                'End If

                MsgBox("Consultation was updated successfully", MsgBoxStyle.Information, "Consultation Updated")

                ' Print Ordinance
                Dim RptOrdinance As New RptOrdinance
                Dim OrdinanceViewer As New FormReportViewer
                Dim PatientInfo As New DataTable
                PatientInfo = DA_Patient.GetDataByPatientUse(PatientNo)
                'RptPatientTable = DA_Patient.GetDataByPatientUse(PpatientidAuto)
                If Me.PrescriptionList.RowCount > 0 Then
                    Dim RptOrdinanceTable As New DataTable
                    Dim DA_Ordinance As New DS_InvoiceTableAdapters.tblPrescriptionTableAdapter
                    RptOrdinanceTable = DA_Ordinance.SelectPrescriptionByID(prescriptionid)
                    RptOrdinance.Database.Tables("tblPrescription").SetDataSource(RptOrdinanceTable)
                    RptOrdinance.Database.Tables("tblpatient").SetDataSource(PatientInfo)
                    RptOrdinance.SetParameterValue("Doctor", Me.txtDoctor.Text)
                    RptOrdinance.SetParameterValue("Diagnosis", Me.cbodiagnosis.Text)
                    RptOrdinance.SetParameterValue("DatePrescription", Format(Me.dtprescription.Value, "dd-MMM-yyyy"))
                    Try
                        Dim CrExportOptions As ExportOptions
                        Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
                        Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
                        CrDiskFileDestinationOptions.DiskFileName = My.Application.Info.DirectoryPath & "\crystalExport.pdf"
                        CrExportOptions = RptOrdinance.ExportOptions
                        With CrExportOptions
                            .ExportDestinationType = ExportDestinationType.DiskFile
                            .ExportFormatType = ExportFormatType.PortableDocFormat
                            .DestinationOptions = CrDiskFileDestinationOptions
                            .FormatOptions = CrFormatTypeOptions
                        End With
                        RptOrdinance.Export()

                        OrdinanceViewer.AxAcroPDF1.src = My.Application.Info.DirectoryPath & "\crystalExport.pdf"
                        OrdinanceViewer.AxAcroPDF1.setZoom(100)

                        'MyProcess.StartInfo.FileName = "C:\crystalExport.pdf"
                        'MyProcess.StartInfo.CreateNoWindow = True
                        'MyProcess.Start()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        'MyProcess.Kill()
                    End Try
                    OrdinanceViewer.SplitContainer1.Panel2Collapsed = True
                    OrdinanceViewer.ShowDialog()
                End If
                MainApplicationForm.StatusLoading(False)
                OrdinanceViewer.Dispose()
            End If
        End If
    End Sub
    Public Is_Success As Boolean = False
    Private Sub BtnSavePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSavePrint.Click
        LoadingData_And_Report()
        Me.Close()
    End Sub

    Private Sub BtnAddPrescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddPrescription.Click
        If ValidateCombobox(cbomedicine, "", ErrPrescription) = False Then Exit Sub
        DA_PrescriptionDetail.InsertPrescription(prescriptionid, CInt(Me.cbomedicine.SelectedValue.ToString), Me.txtdosage.Text, Me.txtduration.Text.ToString, cboUsage.Text, TxtTotalUse.Text)
        Me.txtdosage.Text = ""
        Me.txtduration.Text = ""
        Me.cbomedicine.SelectedIndex = -1
        Me.cboUsage.SelectedIndex = -1
        RefreshPrescriptionList()
    End Sub
    Dim DA_KeyWord As New DS_ParameterTableAdapters.KEY_WORDTableAdapter
    Dim DAComplainDetail As New DSInvoiceTableAdapters.ComplaintTableAdapter
    Dim DAMedicalHistory As New DSInvoiceTableAdapters.HistoryTableAdapter
    Dim DAPhyis As New DSInvoiceTableAdapters.PhysicalExamTableAdapter
    Private Sub EditConsultation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '' Load Patient
        ' If ConsultList.Prescription_List.SelectedItems.Count = 0 Then Exit Sub

        Dim PatientTable As New DataTable
        PatientTable = DA_Patient.GetDataByPatientUse(PatientNo)
        'TxtPatientNoV1.Text = PatientTable.Rows(0).Item("ppatientid").ToString
        Me.TxtPatientNo.Text = PatientTable.Rows(0).Item("patientid").ToString
        Me.txtname.Text = PatientTable.Rows(0).Item("pname").ToString
        Me.txtsex.Text = PatientTable.Rows(0).Item("pgender").ToString

        ''Load Consultation Type
        Me.cboconsulttype.DataSource = DA_ConsultType.SelectConsultationTypes
        Me.cboconsulttype.DisplayMember = DA_ConsultType.SelectConsultationTypes.Columns("consulttypename").ColumnName
        Me.cboconsulttype.ValueMember = DA_ConsultType.SelectConsultationTypes.Columns("consulttypeid").ColumnName
        Me.cboconsulttype.SelectedIndex = -1

        ''Load Diagnosis
        Me.cbodiagnosis.DataSource = DA_Diagnosis.SelectDiagnosis
        Me.cbodiagnosis.DisplayMember = DA_Diagnosis.SelectDiagnosis.Columns("diagnosis").ColumnName
        Me.cbodiagnosis.ValueMember = DA_Diagnosis.SelectDiagnosis.Columns("diagnosisid").ColumnName
        Me.cbodiagnosis.SelectedIndex = -1
        ''Load Doctor
        'Me.cbodoc.DataSource = DA_Doctor.SelectDoctor
        'Me.cbodoc.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        'Me.cbodoc.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_ID").ColumnName
        'cbodoc.SelectedIndex = -1
        txtDoctor.Text = SHOW_NAME
        lblUserID.Text = USER_ID
        ''Load Medicine
        'Dim MedicineList As DataTable = DA_Medicine.SelectMedicine
        'Me.cbomedicine.DataSource = DA_Medicine.SelectMedicine
        'Me.cbomedicine.DisplayMember = MedicineList.Columns("medicinename").ColumnName
        'Me.cbomedicine.ValueMember = MedicineList.Columns("medicineid").ColumnName
        'Me.cbomedicine.SelectedIndex = -1
        With cbomedicine
            .DataSource = DAItem.GetData
            .ValueMember = "ItemID"
            .DisplayMember = "ItemName"
            .SelectedIndex = -1
        End With
        '=================================== Loading Complian
        With CboComplaint
            .DataSource = DA_Complaint.GetData
            .ValueMember = DA_Complaint.GetData.Columns("complaintid").ColumnName
            .DisplayMember = DA_Complaint.GetData.Columns("complaint").ColumnName
            .SelectedIndex = -1
        End With
        GridPreComplaint.DataSource = DAComplainDetail.SelectByPrescrition(prescriptionid)
        '=============== Load medicalhistory ==============
        With CboMedical
            .DataSource = DA_Medical.GetData
            .ValueMember = DA_Medical.GetData.Columns("historyid").ColumnName
            .DisplayMember = DA_Medical.GetData.Columns("history").ColumnName
            .SelectedIndex = -1
        End With
        GridPreMedicalHistory.DataSource = DAMedicalHistory.SelectMedicalByPrescription(prescriptionid)

        '==================== load Phyis ============
        With CboPhysicalExam
            .DataSource = DA_Physical.GetData
            .ValueMember = DA_Physical.GetData.Columns("physicalcheckid").ColumnName
            .DisplayMember = DA_Physical.GetData.Columns("physicalcheck").ColumnName
            .SelectedIndex = -1
        End With
        GridPrePhysical.DataSource = DAPhyis.SelectByPatientPrescription(prescriptionid)

        With cboUsage
            .DataSource = DA_Usage.GetData
            .ValueMember = "USAGE_ID"
            .DisplayMember = "USAGE"
            .SelectedIndex = -1
        End With

        Dim PrescriptionTable As DataTable = DA_Prescription.SelectPrescription(prescriptionid)
        Me.cboconsulttype.Text = PrescriptionTable.Rows(0).Item("consulttype")
        Me.cbodiagnosis.Text = PrescriptionTable.Rows(0).Item("diagnosis")
        'Me.cbodoc.SelectedValue = PrescriptionTable.Rows(0).Item("doctorid")
        lblUserID.Text = PrescriptionTable.Rows(0).Item("doctorid")
        Me.dtprescription.Value = PrescriptionTable.Rows(0).Item("Checkdate")

        Dim ComplaintTable As DataTable = DA_ComplaintDetail.SelectComplaintByPrescriptionID(prescriptionid)
        If ComplaintTable.Rows.Count > 0 Then
            Me.CboComplaint.SelectedValue = CInt(ComplaintTable.Rows(0).Item("complaintid"))
            Me.TxtComplainDescription.Text = ComplaintTable.Rows(0).Item("note").ToString
        End If

        Dim MedicalTable As DataTable = DA_MedicalDetail.SelectHistoryByPrescriptionID(prescriptionid)
        If MedicalTable.Rows.Count > 0 Then
            Me.CboMedical.SelectedValue = CInt(MedicalTable.Rows(0).Item("historyid"))
            Me.TxtMedicalNote.Text = MedicalTable.Rows(0).Item("note").ToString
        End If

        Dim PhysicalTable As DataTable = DA_PhysicalDetail.SelectPhysicalByPrescriptionID(prescriptionid)
        If PhysicalTable.Rows.Count > 0 Then
            Me.CboPhysicalExam.SelectedValue = CInt(PhysicalTable.Rows(0).Item("physicalcheckid"))
            Me.TxtPhysicalNote.Text = PhysicalTable.Rows(0).Item("note").ToString
        End If

        RefreshPrescriptionList()

        Dim tblKeywork As DataTable = DA_KeyWord.GetData

        For Each row As DataRow In tblKeywork.Rows
            AutocompleteMenu1.AddItem(row("KEY_VALUES"))
        Next
    End Sub
    Sub RefreshPrescriptionList()
        'MsgBox(prescriptionid)
        Dim PrescriptionDetailTable As DataTable = DA_PrescriptionDetail.SelectPrescriptionByPrescriptionID(prescriptionid)
        Me.PrescriptionList.DataSource = PrescriptionDetailTable
    End Sub


    Private Sub BtnRemovePrescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemovePrescription.Click
        Dim PPatientID As Long = CLng(PpatientidAuto)
        Dim PrescriptionID As Long = CLng(PrescriptionID)
        DA_PrescriptionDetail.DeletePrescription(CLng(Me.PrescriptionList.CurrentRow.Cells("prescriptiondetailid").Value))
        RefreshPrescriptionList()
    End Sub

    Private Sub BtnParaExamHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnParaExamHistory.Click
        Dim FParaExam As New FormParaExamHistory
        FParaExam.LoadPatientInfo(Me.TxtPatientNo.Text)
        FParaExam.ShowDialog()
    End Sub

    Private Sub BtnRequestExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRequestExam.Click
        Dim DocRequestExam As New MainDocRequestExam(Me)
        DocRequestExam.ShowDialog()

    End Sub

    
    Dim DAComDetail As New DSComplaintTableAdapters.tblcomplaintdetailTableAdapter
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If CboComplaint.SelectedIndex = -1 Then Exit Sub
        DAComDetail.InsertComplaint(CboComplaint.SelectedValue, prescriptionid, "")
        RefresComplain()
    End Sub
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If GridPreComplaint.SelectedItems.Count = 0 Then Exit Sub
        DAComDetail.DeleteComplaint(GridPreComplaint.GetRow.Cells("complaintdetailid").Value)
        RefresComplain()
    End Sub
    Private Sub RefresComplain()
        GridPreComplaint.DataSource = DAComDetail.SelectComplaintByPrescriptionID(prescriptionid)
    End Sub


    Private Sub BtnAddMedicalHistor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddMedicalHistor.Click
        If CboMedical.SelectedIndex = -1 Then Exit Sub
        DA_MedicalDetail.InsertHistory(CboMedical.SelectedValue, prescriptionid, "")
        refreshMedical()
    End Sub
    Private Sub refreshMedical()
        GridPreMedicalHistory.DataSource = DA_MedicalDetail.SelectHistoryByPrescriptionID(prescriptionid)
    End Sub

    Private Sub BtnRemoveMedicalHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveMedicalHistory.Click
        If GridPreMedicalHistory.SelectedItems.Count = 0 Then Exit Sub
        DA_MedicalDetail.DeleteHistory(GridPreMedicalHistory.GetRow.Cells("historydetailid").Value)
        refreshMedical()
    End Sub

    Private Sub BtnAddPrePhysical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddPrePhysical.Click
        If CboPhysicalExam.SelectedIndex = -1 Then Exit Sub
        DA_PhysicalDetail.Insert(CboPhysicalExam.SelectedValue, prescriptionid, "")
        RefreshPhysical()
    End Sub

    Private Sub BtnRemovePrePhysical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemovePrePhysical.Click
        If GridPrePhysical.SelectedItems.Count = 0 Then Exit Sub
        DA_PhysicalDetail.DeletePhysical(GridPrePhysical.GetRow.Cells("physicalcheckdetailid").Value)
        RefreshPhysical()
    End Sub
    Private Sub RefreshPhysical()
        GridPrePhysical.DataSource = DAPhyis.SelectByPatientPrescription(prescriptionid)
    End Sub
End Class