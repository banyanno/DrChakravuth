Module ViewReportMainHistory

    Dim patientid As Double
    ' Complaint Data.........................
    Dim DA_Complaint As New DSComplaintTableAdapters.tblcomplaintTableAdapter
   
  




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
    Public Function PreviewReport(ByVal PatientNo As Long) As RptPatientRecord
        'If Me.InvokeRequired Then
        '    Me.Invoke(New MethodInvoker(AddressOf PreviewReport))
        'Else
        Dim PatientTable As DataTable
        Dim PatientID As Long
        Dim PPatientIDAuto As Long
        PatientTable = DAPatient.SelectPatientByID(PatientNo)
        PatientID = PatientTable.Rows(0).Item("patientid")
        PPatientIDAuto = PatientTable.Rows(0).Item("ppatientid")

        Dim RptRecord As New RptPatientRecord
        ' Dim RptViewer As New FormReportViewer

        Dim PresRemark As DataTable = DA_PrescriptionRemark.SelectPrescriptionByPatientID(PPatientIDAuto)
        Dim ComplaintTable As DataTable = DA_Complaint1.SelectByPatientID(PPatientIDAuto)
        Dim HistoryTable As DataTable = DA_History1.SelectByPatientID(PPatientIDAuto)
        Dim PrescriptionTable As DataTable = DA_Prescription1.SelectByPatientID(PPatientIDAuto)
        Dim PhysicalTable As DataTable = DA_Physical1.SelectByPatientID(PPatientIDAuto)

        Dim BiologyTable As DataTable = DA_Biology1.SelectByPatientID(PPatientIDAuto)
        Dim FibroTable As DataTable = DA_Fibroscopy1.SelectByPatientID(PPatientIDAuto)
        Dim ColoTable As DataTable = DA_Coloscopy1.SelectByPatientID(PPatientIDAuto)

        Dim NasoTable As DataTable = DA_Nasogastro1.SelectByPatientID(PPatientIDAuto)

        Dim EchoTable As DataTable = DA_Echo1.SelectByPatientID(PPatientIDAuto)

        Dim ScanTable As DataTable = DA_Scan1.SelectByPatientID(PPatientIDAuto)

        Dim FibroScan As DataTable = DA_FibroScan1.GetDataByPatientID(PPatientIDAuto) 'SelectByPatientID(PatientID)

        Dim MRITable As DataTable = DA_MRI1.SelectByPatientID(PPatientIDAuto)

        Dim CAAnaPath As DataTable = DA_CFAnaPath1.GetData(PPatientIDAuto)


        Dim BreatTestTable As DataTable = DA_BreathTest.SelectBreathTestByPatientNo(CDbl(PatientID))

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
        'Crv.ReportSource = RptRecord
        Return RptRecord
        ' End If

    End Function
End Module
