Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports CrystalDecisions.Shared

Public Class NewConsultingForm
    Dim DA_Waiting As New DSPAtientTableAdapters.tblwaitingTableAdapter
    Dim DA_Result As New DSConsultationTableAdapters.tblcheckresultTableAdapter
    Dim DA_BloodItem As New DSExaminationTableAdapters.tblblooditemTableAdapter
    Dim DA_Doctor As New DSPAtientTableAdapters.DoctorsTableAdapter
    Dim DA_Diagnosis As New DSPAtientTableAdapters.tbldiagnosisTableAdapter
    Dim DA_ConsultType As New DSPAtientTableAdapters.tblConsultTypeTableAdapter
    Dim DA_Medicine As New DSPAtientTableAdapters.tblmedicineTableAdapter
    Dim DA_Unit As New DSPAtientTableAdapters.tblunitTableAdapter
    Dim DA_PrePrescription As New DSPAtientTableAdapters.tblpreprescriptionDetailTableAdapter
    Dim DA_Prescription As New DSPAtientTableAdapters.tblprescriptionTableAdapter
    Dim DA_PrescriptionDetail As New DSPAtientTableAdapters.tblprescriptionDetailTableAdapter
    Dim DA_Patient As New DS_PrescriptionTableAdapters.tblpatientTableAdapter
    Dim DA_Real_Prescription As New DSConsultationTableAdapters.V_PRESCRIPTIONTableAdapter
    Dim DA_Real_PrescriptionDetail As New DSConsultationTableAdapters.V_PRESCRIPTION_DETAILTableAdapter
    Dim DA_PreInvoice As New DSInvoiceTableAdapters.tbl_preinvoiceTableAdapter
    ' Pre Consultation '
    Dim DA_PreConsultation As New DSConsultationTableAdapters.tbl_preinvoice_consultationTableAdapter
    ' Complaint Data.........................
    Dim DA_Complaint As New DSComplaintTableAdapters.tblcomplaintTableAdapter
    Dim DA_ComplaintDetail As New DSComplaintTableAdapters.tblcomplaintdetailTableAdapter
    Dim DA_PreComplaintDetail As New DSComplaintTableAdapters.tblprecomplaintdetailTableAdapter
    ''Dim DA_V_ComplaintDetail As New DSComplaintTableAdapters.V_PATIENT_COMPLAINTTableAdapter
    ' -------------------------- Medical History -------------------------------------
    Dim DA_Medical As New DSMedicalHistoryTableAdapters.tblhistoryTableAdapter
    Dim DA_MedicalDetail As New DSMedicalHistoryTableAdapters.tblhistorydetailTableAdapter
    Dim DA_PreMedicalDetail As New DSMedicalHistoryTableAdapters.tblprehistorydetailTableAdapter
    ''Dim DA_V_MedicalHisDetail As New DSMedicalHistoryTableAdapters.V_MEDICAL_HISTORYTableAdapter

    '==================== Physical Examination ================================
    Dim DA_Physical As New DSPhysicalExamTableAdapters.tblPhysicalCheckTableAdapter
    Dim DA_PhysicalDetail As New DSPhysicalExamTableAdapters.tblphysicalcheckdetailTableAdapter
    Dim DA_PrePhysicalDetail As New DSPhysicalExamTableAdapters.tblprephysicalcheckdetailTableAdapter
    ''Dim DA_V_PhysicalDetail As New DSPhysicalExamTableAdapters.V_PHYSICAL_EXAMTableAdapter
    ' Usage 
    Dim DA_Usage As New DS_PrescriptionTableAdapters.PRESCRIPTION_USAGETableAdapter

    Private VALUE_LOADING_DATA As Integer
    Dim MainWaiting As MainWaitingConsuling

    Dim DA_KeyWord As New DS_ParameterTableAdapters.KEY_WORDTableAdapter
    Dim DA_DOCTOR_FEE As New DSConsultationTableAdapters.DOCTOR_FEETableAdapter

    Sub New(ByVal MainWaiting As MainWaitingConsuling)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MainWaiting = MainWaiting
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        'If MsgBox("Are you sure you want to cancel this consulation?", MsgBoxStyle.YesNo, "Confirm Concellation") = MsgBoxResult.Yes Then
        DA_PrePrescription.DeletePrescriptionByPatientID(CLng(Me.LblAutoNo.Text))
        Me.Close()
        'End If
    End Sub
    Private Sub NewConsultingForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
        Me.cbodoc.DataSource = DA_Doctor.SelectDoctor
        Me.cbodoc.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        Me.cbodoc.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_ID").ColumnName
        cbodoc.SelectedIndex = -1
        TxtDoctor.Text = SHOW_NAME
        lblUserID.Text = USER_ID
        ''Load Medicine
        Dim MedicineList As New DataTable
        MedicineList = DA_Medicine.SelectMedicine

        Me.cbomedicine.DataSource = DA_Medicine.SelectMedicine
        Me.cbomedicine.DisplayMember = MedicineList.Columns("medicinename").ColumnName
        Me.cbomedicine.ValueMember = MedicineList.Columns("medicineid").ColumnName
        Me.cbomedicine.SelectedIndex = -1

        With CboComplaint
            .DataSource = DA_Complaint.GetData
            .ValueMember = DA_Complaint.GetData.Columns("complaintid").ColumnName
            .DisplayMember = DA_Complaint.GetData.Columns("complaint").ColumnName
            .SelectedIndex = -1
        End With
        GridPreComplaint.DataSource = DA_Complaint.GetData
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
        With cboUsage
            .DataSource = DA_Usage.GetData
            .ValueMember = "USAGE_ID"
            .DisplayMember = "USAGE"
            .SelectedIndex = -1
        End With

        Dim PreComTable As New DataTable
        PreComTable = DA_PreComplaintDetail.SelectByPPatientID(CLng(Me.txtno.Text))
        If PreComTable.Rows.Count > 0 Then
            Me.CboComplaint.SelectedValue = CInt(PreComTable.Rows(0).Item("complaintid"))
            Me.TxtComplainDescription.Text = PreComTable.Rows(0).Item("note").ToString
        End If
        GridPreComplaint.DataSource = PreComTable
        Dim PreMedicalTable As New DataTable
        PreMedicalTable = DA_PreMedicalDetail.SelectByPPatientID(CLng(Me.txtno.Text))
        If PreMedicalTable.Rows.Count > 0 Then
            Me.CboMedical.SelectedValue = CInt(PreMedicalTable.Rows(0).Item("historyid"))
            Me.TxtMedicalNote.Text = PreMedicalTable.Rows(0).Item("note").ToString
        End If
        GridPreMedicalHistory.DataSource = PreMedicalTable

        Dim PrePhysicalTable As New DataTable
        PrePhysicalTable = DA_PrePhysicalDetail.SelectByPPatientID(CLng(Me.txtno.Text))
        If PrePhysicalTable.Rows.Count > 0 Then
            Me.CboPhysicalExam.SelectedValue = CInt(PrePhysicalTable.Rows(0).Item("physicalcheckid"))
            Me.TxtPhysicalNote.Text = PrePhysicalTable.Rows(0).Item("note").ToString
        End If
        GridPrePhysical.DataSource = PrePhysicalTable

        RefreshPrescriptionWithWaiting()

        Dim tblKeywork As DataTable = DA_KeyWord.GetData

        For Each row As DataRow In tblKeywork.Rows
            AutocompleteMenu1.AddItem(row("KEY_VALUES"))
        Next
    End Sub


    Sub deletePreTable()
        DA_PreComplaintDetail.DeleteComplaint(CLng(Me.txtno.Text))
        DA_PreMedicalDetail.DeleteAllMedicince(CLng(Me.txtno.Text))
        DA_PrePhysicalDetail.DeleteExam(CLng(Me.txtno.Text))
    End Sub

    Private Sub LoadingData_And_Report()
        If ValidateDateTimePicker(dtprescription, "", ErrPrescription) = False Then Exit Sub
        If ValidateCombobox(cboconsulttype, "", ErrPrescription) = False Then Exit Sub
        If ValidateCombobox(cbodiagnosis, "", ErrPrescription) = False Then Exit Sub
        'If ValidateCombobox(cbodoc, "", ErrPrescription) = False Then Exit Sub
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadingData_And_Report))
        Else
            If MessageBox.Show("Do you want to save new consultation?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                MainApplicationForm.StatusLoading(True)
                Dim ParaList As New DataTable
                Dim PhysicalList As New DataTable
                Dim ComplaintList As New DataTable
                Dim HistoryList As New DataTable
                Dim PrescriptionList As New DataTable
                Dim ReadyDiagnosis As Integer = 0
                'PrescriptionList = DA_PrePrescription.SelectPrescriptionByPatientID(CInt(Me.LblWaiting.CurrentRow.Cells("ppatientid").Value))
                PrescriptionList = DA_PrePrescription.SelectPrescriptionByPatientID(LblAutoNo.Text)


                Dim ConsultPrice As Double
                ConsultPrice = DA_ConsultType.SelectConsultByID(CInt(Me.cboconsulttype.SelectedValue)).Rows(0).Item("price")
                '' Check Diagnosis Exist consult .
                Dim tblCheckDiagnosis As DataTable = DA_Prescription.SelectCheckDiagnosis(LblAutoNo.Text, cbodiagnosis.Text)
                If tblCheckDiagnosis.Rows.Count > 0 Then
                    ReadyDiagnosis = 2
                Else
                    ReadyDiagnosis = 1
                End If
                ''Insert Prescription (Primary Table)
                DA_Prescription.InsertPrescription(CInt(LblAutoNo.Text), CInt(lblUserID.Text), Me.cbodiagnosis.Text, FormatDateTime(dtprescription.Value, DateFormat.ShortDate), cboconsulttype.Text, ConsultPrice, Me.txtremark.Text, ReadyDiagnosis)
                ''Get Data From PreDetailTable and Insert Into the real Detail Table (Foreign Tables)
                Dim PrescriptionID As Long
                If DA_Prescription.SelectMaxID.ToString = "" Then
                    PrescriptionID = 1
                Else
                    PrescriptionID = DA_Prescription.SelectMaxID
                End If

                ''-------Prescription--------
                For m = 0 To PrescriptionList.Rows.Count - 1
                    DA_PrescriptionDetail.InsertPrescription(PrescriptionID, PrescriptionList.Rows(m).Item("medicineid"), PrescriptionList.Rows(m).Item("dosage"), PrescriptionList.Rows(m).Item("duration"), PrescriptionList.Rows(m).Item("TimeUsed"), TxtTotalUse.Text)
                Next
                DA_PrePrescription.DeletePrescriptionByPatientID(CInt(LblAutoNo.Text))

                If DA_PreInvoice.SelectByPatientID(CInt(LblAutoNo.Text)).Rows.Count < 1 Then
                    DA_PreInvoice.InsertInvoice(CInt(LblAutoNo.Text))
                End If
                '-------Pre Invoice Consultation-----------
                DA_PreConsultation.InsertConsultation(CLng(Me.LblAutoNo.Text), Me.cboconsulttype.Text, ConsultPrice)
                '--------Complaint---------
                'If Me.CboComplaint.Text <> "" Then
                If GridPreComplaint.RowCount > 0 Then
                    For i As Int16 = 0 To GridPreComplaint.RowCount - 1
                        'MsgBox(GridPreComplaint.GetRow(i).Cells("complaintid").Value & " " & GridPreComplaint.GetRow(i).Cells("note").Value)
                        DA_ComplaintDetail.InsertComplaint(GridPreComplaint.GetRow(i).Cells("complaintid").Value, PrescriptionID, Me.TxtComplainDescription.Text)
                        'DA_ComplaintDetail.InsertComplaint(CInt(Me.CboComplaint.SelectedValue), PrescriptionID, Me.TxtComplainDescription.Text)
                    Next
                End If

                'Create Doctor Fee
                DA_DOCTOR_FEE.InsertNewDoctorFee(lblUserID.Text, TxtDoctor.Text, cboconsulttype.Text, dtprescription.Value.Date, txtno.Text, ConsultPrice, txtname.Text, "")


                'End If
                '----Medical History----
                'If Me.CboMedical.Text <> "" Then
                If GridPreMedicalHistory.RowCount > 0 Then
                    For i As Int16 = 0 To GridPreMedicalHistory.RowCount - 1
                        DA_MedicalDetail.InsertHistory(GridPreMedicalHistory.GetRow(i).Cells("historyid").Value, PrescriptionID, Me.TxtMedicalNote.Text)
                    Next
                    'DA_MedicalDetail.InsertHistory(CInt(Me.CboMedical.SelectedValue), PrescriptionID, Me.TxtMedicalNote.Text)
                End If

                'End If
                '----Physical Exam----
                'If Me.CboPhysicalExam.Text <> "" Then
                If GridPrePhysical.RowCount > 0 Then
                    For i As Int16 = 0 To GridPrePhysical.RowCount - 1
                        DA_PhysicalDetail.InsertPhysical(GridPrePhysical.GetRow(i).Cells("physicalcheckid").Value, PrescriptionID, Me.TxtPhysicalNote.Text)
                    Next
                    'DA_PhysicalDetail.InsertPhysical(CInt(Me.CboPhysicalExam.SelectedValue), PrescriptionID, Me.TxtPhysicalNote.Text)
                End If

                'End If

                '' Delete PreTable
                deletePreTable()

                '' Print Ordinance
                Dim RptOrdinance As New RptOrdinance
                Dim OrdinanceViewer As New FormReportViewer
                Dim RptPatientTable As New DataTable
                'RptPatientTable = DA_Patient.SelectPatient(CInt(Me.WaitingList.CurrentRow.Cells("ppatientid").Value))
                RptPatientTable = DA_Patient.SelectPatient(CInt(LblAutoNo.Text))
                If Me.PrescriptionList.RowCount > 0 Then
                    Dim MyProcess As New Process
                    Dim RptOrdinanceTable As New DataTable
                    Dim DA_Ordinance As New DS_InvoiceTableAdapters.tblPrescriptionTableAdapter
                    RptOrdinanceTable = DA_Ordinance.SelectPrescriptionByID(PrescriptionID)
                    RptOrdinance.Database.Tables("tblPrescription").SetDataSource(RptOrdinanceTable)
                    RptOrdinance.Database.Tables("tblpatient").SetDataSource(RptPatientTable)
                    RptOrdinance.SetParameterValue("Doctor", Me.TxtDoctor.Text)
                    RptOrdinance.SetParameterValue("Diagnosis", Me.cbodiagnosis.Text)
                    RptOrdinance.SetParameterValue("DatePrescription", Format(Me.dtprescription.Value, "dd-MMM-yyyy"))
                    ' OrdinanceViewer.CVForm.ReportSource = RptOrdinance
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

                      
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally

                    End Try
                   
                    OrdinanceViewer.SplitContainer1.Panel2Collapsed = True
                    OrdinanceViewer.ShowDialog()
                End If

                'Update Consultation success
                DA_Waiting.UpdateStatus(0, LblWaiting.Text)
                OrdinanceViewer.Dispose()
                'LoadHistoryConsult(1)
                'RefreshPrescriptionWithWaiting()
                dtprescription.Checked = False
                cboconsulttype.SelectedIndex = -1
                cbodiagnosis.SelectedIndex = -1
                cbodoc.SelectedIndex = -1
                MainApplicationForm.StatusLoading(False)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Is_Success = True
                MainWaiting.LoadHistoryConsult(1)
                Me.Close()
            End If
        End If
    End Sub
    Public Is_Success As Boolean = False
    Private Sub BtnSavePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSavePrint.Click
        'If MessageBox.Show("Do you want save new consultation?", "Consult", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        LoadingData_And_Report()

        '  MainWaiting.btnRefresh_Click(sender, e)
        ' MainWaiting.BtnConsultainHistory_Click(sender, e)
        ' MainWaiting.btnRefresh_Click(sender, e)
        ' Me.Close()
        'End If

    End Sub



    Private Sub BtnAddPrescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddPrescription.Click

        If ValidateCombobox(cbomedicine, "", ErrPrescription) = False Then Exit Sub

        'If MessageBox.Show("Do you want to add prescription record?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        'Try
        DA_PrePrescription.InsertPrescription(CInt(LblAutoNo.Text), CInt(Me.cbomedicine.SelectedValue.ToString), Me.txtdosage.Text.ToString.Replace("'", "''"), Me.txtduration.Text.ToString.Replace("'", "''"), cboUsage.Text)
        'MsgBox("One prescription was added", MsgBoxStyle.Information, "Successfully Added")
        Me.txtdosage.Text = ""
        Me.txtduration.Text = ""
        cbomedicine.Text = ""
        Me.cbomedicine.SelectedIndex = -1
        cboUsage.Text = ""
        cboUsage.SelectedIndex = -1
        Me.RefreshPrescriptionWithWaiting()
        cbomedicine.Select()
        cbomedicine.Focus()
        'Catch ex As Exception
        '    MessageBox.Show("Please select patient before add prescription!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

        'End If
    End Sub
    Sub RefreshPrescriptionWithWaiting()
        'Try

        Me.PrescriptionList.DataSource = DA_PrePrescription.SelectPrescriptionByPatientID(CInt(LblAutoNo.Text))


    End Sub
    Private Sub BtnRemovePrescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemovePrescription.Click
        'If MsgBox("Are you sure you want to delete this record from prescription?", MsgBoxStyle.YesNo, "Confirm Deletion") = MsgBoxResult.Yes Then
        Try
            DA_PrePrescription.DeletePrescription(CLng(Me.PrescriptionList.CurrentRow.Cells("preid").Value))
            RefreshPrescriptionWithWaiting()
        Catch ex As Exception

        End Try

        'End If
    End Sub


    Private Sub BtnRequestExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRequestExam.Click

        Dim DocRequestExam As New MainDocRequestExam(Me)
        DocRequestExam.ShowDialog()

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BtnParaExamHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnParaExamHistory.Click
        Dim FParaExam As New FormParaExamHistory
        FParaExam.LoadPatientInfo(Me.txtno.Text)
        FParaExam.ShowDialog()
    End Sub

    Private Sub TxtComplainDescription_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtComplainDescription.KeyDown
        'If e.KeyCode = Keys.Escape Then
        '    lv.Hide()
        'End If
        'If (e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down) And lv.Visible Then
        '    lv.Focus()
        '    Exit Sub
        'End If
        'If e.Control Then
        '    If e.KeyCode = Keys.Space Then
        '        e.SuppressKeyPress = True
        '        lv.Location = New Point(Windows.Forms.Cursor.Position.X - Me.Left, Windows.Forms.Cursor.Position.Y - Me.Top)
        '        lv.Height = 100
        '        lv.BringToFront()
        '        lv.Show()
        '        Dim prevtext = TxtComplainDescription.Text.Substring(InStrRev(TxtComplainDescription.Text, " "))
        '        If prevtext = "" Then
        '            TxtComplainDescription.Text.Substring(InStrRev(TxtComplainDescription.Text, vbLf))
        '        End If
        '        If prevtext <> "" Then
        '            lv.SendKeyString(prevtext)
        '        Else
        '            lv.SelectedIndex = 0
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub BtnAddMedicalHistor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddMedicalHistor.Click
        If ValidateCombobox(CboMedical, "", ErrPrescription) = False Then Exit Sub
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
        If ValidateCombobox(CboPhysicalExam, "", ErrPrescription) = False Then Exit Sub
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ValidateCombobox(CboComplaint, "", ErrPrescription) = False Then Exit Sub
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If GridPreComplaint.SelectedItems.Count = 0 Then Exit Sub
        DA_PreComplaintDetail.DeleteBuyPre(GridPreComplaint.GetRow.Cells("preid").Value)
        GridPreComplaint.DataSource = DA_PreComplaintDetail.SelectByPPatientID(txtno.Text)
    End Sub
End Class