Public Class MainWaitingConsuling
    Dim DA_Waiting As New DSPAtientTableAdapters.tblwaitingTableAdapter
    Dim DA_Result As New DSConsultationTableAdapters.tblcheckresultTableAdapter
    Dim DA_BloodItem As New DSExaminationTableAdapters.tblblooditemTableAdapter
    Dim DA_Patient As New DS_PrescriptionTableAdapters.tblpatientTableAdapter
  
    ' Complaint Data.........................
    Dim DA_ComplaintDetail As New DSInvoiceTableAdapters.ComplaintTableAdapter
    ' -------------------------- Medical History -------------------------------------
    Dim DA_MedicalHisDetail As New DSInvoiceTableAdapters.HistoryTableAdapter
    ' -------------------------- Physical History -------------------------------------
    Dim DA_PhysicalDetail As New DSInvoiceTableAdapters.PhysicalExamTableAdapter
    '--------------Prescription Detail---------------
    Dim DA_PrescriptionDetail As New DSInvoiceTableAdapters.PrescriptionDetailTableAdapter

    Dim consultation As New DSConsultationTableAdapters.V_PRESCRIPTIONTableAdapter

    Private VALUE_LOADING_DATA As Integer

    Dim DA_PrePhysicalDetail As New DSPhysicalExamTableAdapters.tblprephysicalcheckdetailTableAdapter
    Dim DA_PreMedicalDetail As New DSMedicalHistoryTableAdapters.tblprehistorydetailTableAdapter
    Dim DA_PreComplaintDetail As New DSComplaintTableAdapters.tblprecomplaintdetailTableAdapter

    Dim DA_PrescriptionRemark As New DSInvoiceTableAdapters.PrescriptionRemarkTableAdapter
    Dim DA_Complaint As New DSInvoiceTableAdapters.ComplaintTableAdapter
    Dim DA_History As New DSInvoiceTableAdapters.HistoryTableAdapter
    Dim DA_Prescription As New DSInvoiceTableAdapters.PrescriptionDetailTableAdapter
    Dim DA_Biology As New DSInvoiceTableAdapters.BloodTableAdapter
    Dim DA_Fibroscopy As New DSInvoiceTableAdapters.FibroTableAdapter
    Dim DA_Coloscopy As New DSInvoiceTableAdapters.ColoTableAdapter
    Dim DA_Nasogastro As New DSInvoiceTableAdapters.NasoTableAdapter
    Dim DA_Echo As New DSInvoiceTableAdapters.EchoTableAdapter
    Dim DA_Scan As New DSInvoiceTableAdapters.ScanTableAdapter
    Dim DA_FibroScan As New DSInvoiceTableAdapters.FibroScan1TableAdapter
    Dim DA_MRI As New DSInvoiceTableAdapters.MRITableAdapter
    Dim DA_CFAnaPath As New DSExaminationTableAdapters.CFAnaPathTableAdapter
    Dim DA_Physical As New DSInvoiceTableAdapters.PhysicalExamTableAdapter
    Dim DAPatient As New DSPAtientTableAdapters.tblpatientTableAdapter
    Dim DA_BreathTest As New DSExaminationTableAdapters.TblBreathTestTableAdapter

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub UpdateStatusConsult(ByVal status As Integer, ByVal WatitnNo As Integer)
        DA_Waiting.UpdateIStatusConsult(status, WatitnNo)
    End Sub
    Private Sub BtnNewConsult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewConsult.Click
        If WaitingList.SelectedItems.Count = 0 Then Exit Sub
        If DA_Waiting.GetStatusConsult(WaitingList.GetRow.Cells("waiting_id").Value) = 1 Then
            MessageBox.Show("The paiennt is consuling by another doctor. Please check another patient", "Consuling", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LoadHistoryConsult(1)
            Exit Sub
        End If
        UpdateStatusConsult(1, WaitingList.GetRow.Cells("waiting_id").Value)
        Dim FNewConsulting As New NewConsultingForm(Me)
        FNewConsulting.LblWaiting.Text = WaitingList.GetRow.Cells("waiting_id").Value
        FNewConsulting.txtname.Text = WaitingList.GetRow.Cells("pname").Value
        FNewConsulting.TxtPatientNo.Text = WaitingList.GetRow.Cells("patientid").Value
        FNewConsulting.LblPPatintIID.Text = WaitingList.GetRow.Cells("ppatientid").Value
        FNewConsulting.txtsex.Text = WaitingList.GetRow.Cells("pgender").Value
        If TypeOf WaitingList.GetRow.Cells("Age").Value Is DBNull Then
            FNewConsulting.TxtAge.Text = ""
        Else
            FNewConsulting.TxtAge.Text = WaitingList.GetRow.Cells("Age").Value
        End If

        FNewConsulting.Show()

    End Sub
    Sub LoadHistoryConsult(ByVal Status As Integer, Optional ByVal patientID As Integer = 0, Optional ByVal PatientName As String = "")
        If patientID <> 0 Then
            Me.WaitingList.DataSource = DA_Waiting.SelectWaitingByStatusWithPID(Status, patientID)
            'RefreshPrescription()
        Else
            Me.WaitingList.DataSource = DA_Waiting.GetDataByStatusWithPName(Status, "%" & PatientName & "%")
            'RefreshPrescription()
        End If

    End Sub
    Public Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadHistoryConsult(1)
    End Sub
    Private Sub MainWaitingConsuling_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadHistoryConsult(1)
    End Sub

    Private Sub WaitingList_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles WaitingList.SelectionChanged
        If WaitingList.SelectedItems.Count = 0 Then Exit Sub

        Me.GridComplaintList.DataSource = DA_ComplaintDetail.SelectByPatientID(WaitingList.GetRow.Cells("ppatientid").Value)
        Me.GridMedical.DataSource = DA_MedicalHisDetail.SelectByPatientID(WaitingList.GetRow.Cells("ppatientid").Value)
        Me.PhysicalList.DataSource = DA_PhysicalDetail.SelectByPatientID(WaitingList.GetRow.Cells("ppatientid").Value)
        Me.PrescriptionList.DataSource = DA_PrescriptionDetail.SelectByPatientID(WaitingList.GetRow.Cells("ppatientid").Value)




        ItemResultList.DataSource = DA_Biology.SelectByPatientID(WaitingList.GetRow.Cells("ppatientid").Value)
        FibroConclusionList.DataSource = DA_Fibroscopy.SelectByPatientID(WaitingList.GetRow.Cells("ppatientid").Value)
        ColoConclusionList.DataSource = DA_Coloscopy.SelectByPatientID(WaitingList.GetRow.Cells("ppatientid").Value)

        NasoConclusionList.DataSource = DA_Nasogastro.SelectByPatientID(WaitingList.GetRow.Cells("ppatientid").Value)

        EchoConclusionList.DataSource = DA_Echo.SelectByPatientID(WaitingList.GetRow.Cells("ppatientid").Value)


        GridScan.DataSource = DA_Scan.SelectByPatientID(WaitingList.GetRow.Cells("ppatientid").Value)
     

        GridFibroScan.DataSource = DA_FibroScan.GetDataByPatientID(WaitingList.GetRow.Cells("ppatientid").Value) 'SelectByPatientID(PatientID)
        
        GridMRI.DataSource = DA_MRI.SelectByPatientID(WaitingList.GetRow.Cells("ppatientid").Value)
        GridCFAnapat.DataSource = DA_CFAnaPath.GetData(WaitingList.GetRow.Cells("ppatientid").Value)
       

    End Sub

    Private Sub btnCancelWaiting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelWaiting.Click
        If Me.WaitingList.SelectedItems.Count = 0 Then Exit Sub
        If MsgBox("Are you sure you want to cancel this waiting?", MsgBoxStyle.YesNo, "Confirm Cancel") = MsgBoxResult.Yes Then
            DA_Waiting.UpdateStatus(2, CInt(Me.WaitingList.CurrentRow.Cells("waiting_id").Value))
            deletePreTable()
            LoadHistoryConsult(1)
        End If
    End Sub
   
    Sub deletePreTable()
        DA_PreComplaintDetail.DeleteComplaint(CLng(Me.WaitingList.GetRow.Cells("patientid").Value))
        DA_PreMedicalDetail.DeleteAllMedicince(CLng(Me.WaitingList.GetRow.Cells("patientid").Value))
        DA_PrePhysicalDetail.DeleteExam(CLng(Me.WaitingList.GetRow.Cells("patientid").Value))
    End Sub
    Private Sub BtnDoctorRequestExamination_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDoctorRequestExamination.Click
        If WaitingList.SelectedItems.Count = 0 Then
            Exit Sub
        Else
            Dim DocRequestExam As New MainDocRequestExam(Me)
            DocRequestExam.ShowDialog()
        End If

    End Sub

    Private Sub LoadingData_And_Report()
        
    End Sub
    Private Sub BtnSavePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'VALUE_LOADING_DATA = 1
        MainApplicationForm.StatusLoading(True)
        Application.DoEvents()
        bgLoadingData.RunWorkerAsync()
    End Sub
    Public Sub BtnConsultainHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultainHistory.Click
        Try
            UiTab1.TabPages(0).Selected = True
            If Me.WaitingList.SelectedItems.Count = 0 Then Exit Sub
            MainApplicationForm.StatusLoading(True)
            BgLoadingReport.RunWorkerAsync()
        Catch ex As Exception

        End Try
        
    End Sub
    Private Sub bgLoadingData_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgLoadingData.DoWork
        LoadingData_And_Report()
    End Sub

    Private Sub bgLoadingData_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgLoadingData.RunWorkerCompleted
        Application.DoEvents()
        ' CleanNewPrescription()
        MainApplicationForm.StatusLoading(False)
    End Sub

    Private Sub BgLoadingReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadingReport.DoWork
        PreviewReport()
    End Sub
    Sub PreviewReport()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf PreviewReport))
        Else

            Me.CRVMedicalHistoryReport.ReportSource = ViewReportMainHistory.PreviewReport(CDbl(Me.WaitingList.GetRow.Cells("patientid").Value))
            'Dim PatientTable As DataTable
            'Dim PPatientIDAUTO As Long
            'Dim PatientNo As Double
            'PatientTable = DAPatient.SelectPatientByID(CDbl(Me.WaitingList.GetRow.Cells("patientid").Value))
            'PPatientIDAUTO = Me.WaitingList.GetRow.Cells("ppatientid").Value 'PatientTable.Rows(0).Item("ppatientid")
            ''MessageBox.Show(PatientID)
            'PatientNo = CDbl(Me.WaitingList.GetRow.Cells("patientid").Value)
            'Dim RptRecord As New RptPatientRecord
            '' Dim RptViewer As New FormReportViewer


            'Dim ComplaintTable As DataTable = DA_Complaint.SelectByPatientID(PPatientIDAUTO)
            'Dim HistoryTable As DataTable = DA_History.SelectByPatientID(PPatientIDAUTO)
            'Dim PhysicalTable As DataTable = DA_Physical.SelectByPatientID(PPatientIDAUTO)
            'Dim PrescriptionTable As DataTable = DA_Prescription.SelectByPatientID(PPatientIDAUTO)

            'Dim BiologyTable As DataTable = DA_Biology.SelectByPatientID(PPatientIDAUTO)
            'Dim FibroTable As DataTable = DA_Fibroscopy.SelectByPatientID(PPatientIDAUTO)
            'Dim ColoTable As DataTable = DA_Coloscopy.SelectByPatientID(PPatientIDAUTO)

            'Dim NasoTable As DataTable = DA_Nasogastro.SelectByPatientID(PPatientIDAUTO)

            'Dim EchoTable As DataTable = DA_Echo.SelectByPatientID(PPatientIDAUTO)

            'Dim ScanTable As DataTable = DA_Scan.SelectByPatientID(PPatientIDAUTO)

            'Dim FibroScan As DataTable = DA_FibroScan.GetDataByPatientID(PPatientIDAUTO) 'SelectByPatientID(PatientID)

            'Dim MRITable As DataTable = DA_MRI.SelectByPatientID(PPatientIDAUTO)

            'Dim CAAnaPath As DataTable = DA_CFAnaPath.GetData(PPatientIDAUTO)
            'Dim PresRemark As DataTable = DA_PrescriptionRemark.SelectPrescriptionByPatientID(PatientNo)
            'Dim BreatTestTable As DataTable = DA_BreathTest.SelectBreathTestByPatientNo(PatientNo)


            'RptRecord.Database.Tables("Patient").SetDataSource(PatientTable)
            'RptRecord.Subreports("Complaint").Database.Tables("Complaint").SetDataSource(ComplaintTable)
            'RptRecord.Subreports("History").Database.Tables("History").SetDataSource(HistoryTable)
            'RptRecord.Subreports("Prescription").Database.Tables("PrescriptionDetail").SetDataSource(PrescriptionTable)
            'RptRecord.Subreports("Biology").Database.Tables("Blood").SetDataSource(BiologyTable)
            'RptRecord.Subreports("Fibroscopy").Database.Tables("Fibro").SetDataSource(FibroTable)
            'RptRecord.Subreports("Coloscopy").Database.Tables("Colo").SetDataSource(ColoTable)
            'RptRecord.Subreports("Nasogastro").Database.Tables("Naso").SetDataSource(NasoTable)
            'RptRecord.Subreports("Echo").Database.Tables("Echo").SetDataSource(EchoTable)
            'RptRecord.Subreports("FibroScan").Database.Tables("FibroScan1").SetDataSource(FibroScan)
            'RptRecord.Subreports("Scan").Database.Tables("Scan").SetDataSource(ScanTable)
            'RptRecord.Subreports("MRI").Database.Tables("MRI").SetDataSource(MRITable)
            'RptRecord.Subreports("Physical").Database.Tables("PhysicalExam").SetDataSource(PhysicalTable)
            'RptRecord.Subreports("ACAnaPath").Database.Tables("CFAnaPath").SetDataSource(CAAnaPath)
            'RptRecord.Subreports("PrescriptionRemark").SetDataSource(PresRemark)
            'RptRecord.Subreports("UreaBreathTest").Database.Tables("TblBreathTest").SetDataSource(BreatTestTable)
            'Me.CRVMedicalHistoryReport.ReportSource = RptRecord

        End If

    End Sub

    Private Sub BgLoadingReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadingReport.RunWorkerCompleted
        MainApplicationForm.StatusLoading(False)
    End Sub

    Private Sub BtnDeleteComplaint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteComplaint.Click
        If GridComplaintList.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete complaint?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                DA_Complaint.DeleteComplaint(GridComplaintList.GetRow.Cells("complaintdetailid").Value)
                Me.GridComplaintList.DataSource = DA_ComplaintDetail.SelectByPatientID(WaitingList.GetRow.Cells("ppatientid").Value)
            Catch ex As Exception

            End Try
            
        End If

    End Sub

    Private Sub BtnDeleteMedical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteMedical.Click
        If GridMedical.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete medical history?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                DA_MedicalHisDetail.DeleteMedicalHistory(GridMedical.GetRow.Cells("historydetailid").Value)
                Me.GridMedical.DataSource = DA_MedicalHisDetail.SelectByPatientID(WaitingList.GetRow.Cells("ppatientid").Value)
            Catch ex As Exception

            End Try
            
        End If
    End Sub

    

    Private Sub BtnDeletePhysical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeletePhysical.Click
        If PhysicalList.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete medical history?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                DA_PhysicalDetail.DeletePhysical(PhysicalList.GetRow.Cells("physicalcheckdetailid").Value)
                Me.PhysicalList.DataSource = DA_PhysicalDetail.SelectByPatientID(WaitingList.GetRow.Cells("ppatientid").Value)
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub BtnDeletePrescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeletePrescription.Click
        If PrescriptionList.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete prescription?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                DA_PrescriptionDetail.DeletePrescription(PrescriptionList.GetRow.Cells("prescriptiondetailid").Value)
                Me.PrescriptionList.DataSource = DA_PrescriptionDetail.SelectByPatientID(WaitingList.GetRow.Cells("ppatientid").Value)
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub BtnDeleteBlood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteBlood.Click
        If ItemResultList.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete blood result?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                DA_Biology.DeleteBloodResult(ItemResultList.GetRow.Cells("item_id").Value, ItemResultList.GetRow.Cells("request_id").Value)
                ItemResultList.DataSource = DA_Biology.SelectByPatientID(WaitingList.GetRow.Cells("ppatientid").Value)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub BtnFibroscopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFibroscopy.Click
        If FibroConclusionList.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete fibroscopy?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                DA_Fibroscopy.DeleteResultFibro(FibroConclusionList.GetRow.Cells("conclusion_id").Value, FibroConclusionList.GetRow.Cells("request_id").Value)
                FibroConclusionList.DataSource = DA_Fibroscopy.SelectByPatientID(WaitingList.GetRow.Cells("ppatientid").Value)
            Catch ex As Exception

            End Try
        End If
    End Sub

  
    Private Sub BtnNasogastro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNasogastro.Click
        If NasoConclusionList.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete nasogastro?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                DA_Nasogastro.DeleteNaso(NasoConclusionList.GetRow.Cells("conclusion_id").Value, NasoConclusionList.GetRow.Cells("request_id").Value)
                NasoConclusionList.DataSource = DA_Nasogastro.SelectByPatientID(WaitingList.GetRow.Cells("ppatientid").Value)
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub btnColoscopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColoscopy.Click
        If ColoConclusionList.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete coloscopy?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                DA_Coloscopy.DeleteColo(ColoConclusionList.GetRow.Cells("conclusion_id").Value, ColoConclusionList.GetRow.Cells("request_id").Value)
                ColoConclusionList.DataSource = DA_Coloscopy.SelectByPatientID(WaitingList.GetRow.Cells("ppatientid").Value)
            Catch ex As Exception

            End Try
        End If
    End Sub


    Private Sub BtnDeleteEcho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteEcho.Click
        If EchoConclusionList.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete echo?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                DA_Echo.DeleteEchoResult(EchoConclusionList.GetRow.Cells("conclusion_id").Value, EchoConclusionList.GetRow.Cells("request_id").Value)
                EchoConclusionList.DataSource = DA_Echo.SelectByPatientID(WaitingList.GetRow.Cells("ppatientid").Value)
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub BtnDeleteScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteScan.Click
        If GridScan.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete scan?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                DA_Scan.DeleteScan(GridScan.GetRow.Cells("request_id").Value)
                GridScan.DataSource = DA_Scan.SelectByPatientID(WaitingList.GetRow.Cells("ppatientid").Value)
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub BtnMRI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMRI.Click

        If GridMRI.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete M-R-I?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                DA_MRI.DeleteMRIResult(GridMRI.GetRow.Cells("request_id").Value)
                GridMRI.DataSource = DA_MRI.SelectByPatientID(WaitingList.GetRow.Cells("ppatientid").Value)
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub BtnFibroscan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFibroscan.Click
        If GridFibroScan.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete FibroScan?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                DA_FibroScan.DeleteFibroScan(GridFibroScan.GetRow.Cells("request_id").Value)
                GridFibroScan.DataSource = DA_FibroScan.GetDataByPatientID(WaitingList.GetRow.Cells("ppatientid").Value)
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub BtnDeleteAnapath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteAnapath.Click
        If GridCFAnapat.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete Ana-Path?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                DA_CFAnaPath.DeleteCFAnapath(GridCFAnapat.GetRow.Cells("request_id").Value)
                GridCFAnapat.DataSource = DA_CFAnaPath.GetData(WaitingList.GetRow.Cells("ppatientid").Value)
            Catch ex As Exception

            End Try
        End If


    End Sub

    Private Sub BtnAddBlood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddBlood.Click
        Dim Fblood As New Blood
        If Fblood.ShowDialog = DialogResult.OK Then

        End If
    End Sub
End Class
