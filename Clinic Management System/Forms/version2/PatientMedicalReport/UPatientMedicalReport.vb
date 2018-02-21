Imports CrystalDecisions.Shared

Public Class UPatientMedicalReport

    Dim DA_Complaint As New DSInvoiceTableAdapters.ComplaintTableAdapter
    Dim DA_History As New DSInvoiceTableAdapters.HistoryTableAdapter
    Dim DA_Prescription As New DSInvoiceTableAdapters.PrescriptionDetailTableAdapter
    Dim DA_Biology As New DSInvoiceTableAdapters.BloodTableAdapter
    Dim DA_Fibroscopy As New DSInvoiceTableAdapters.FibroTableAdapter
    Dim DA_Coloscopy As New DSInvoiceTableAdapters.ColoTableAdapter
    Dim DA_Nasogastro As New DSInvoiceTableAdapters.NasoTableAdapter
    Dim DA_Echo As New DSInvoiceTableAdapters.EchoTableAdapter
    Dim DA_MRI As New DSInvoiceTableAdapters.MRITableAdapter
    Dim DA_Physical As New DSInvoiceTableAdapters.PhysicalExamTableAdapter
    Dim DA_CFAnaPath As New DSExaminationTableAdapters.CFAnaPathTableAdapter

    Dim DA_Patient As New DSPAtientTableAdapters.tblpatientTableAdapter

    Dim DA_Scan As New DSInvoiceTableAdapters.ScanTableAdapter
    Dim DA_FibroScan As New DSInvoiceTableAdapters.FibroScan1TableAdapter
    Dim DA_PrescriptionRemark As New DSInvoiceTableAdapters.PrescriptionRemarkTableAdapter

    Dim DA_VeiwPatientConsult As New DSInvoiceTableAdapters.V_DIALYCONSULTTableAdapter

    Dim DA_PrescriptionHistory As New DSInvoiceTableAdapters.tblprescriptionTableAdapter

    Dim DA_PatientHistory As New DS_PrescriptionTableAdapters.tblpatientTableAdapter
    Private Sub UPatientMedicalReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SplitContainer1.SplitterDistance = 164
    End Sub

    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub FindPatient(ByVal Value As Object, ByVal FindType As Integer)
        If FindType = 1 Then
            'Find By Patient Number
            GridPatientConsult.DataSource = DA_Patient.SelectPatientByID(EmptyString(Value))
        ElseIf FindType = 2 Then
            'Find By Name
            GridPatientConsult.DataSource = DA_Patient.SelectPatientByName("%" & Value & "%")
        ElseIf FindType = 3 Then
            'Find By Phone
            GridPatientConsult.DataSource = DA_Patient.SelectPatientByPhone("%" & Value & "%")
        ElseIf FindType = 4 Then
            GridPatientConsult.DataSource = DA_Patient.SelectPatientByAddress("%" & Value & "%")
        End If
    End Sub

    Sub PreviewReport()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf PreviewReport))
        Else
            ' Dim PatientTable As DataTable
            Dim PatientID As Long = Me.GridPatientConsult.GetRow.Cells("patientid").Value
            'PatientTable = DA_Patient.SelectPatientByPID(CInt(Me.GridPatientConsult.GetRow.Cells("ppatientid").Value))
            'PatientID = PatientTable.Rows(0).Item("ppatientid")

            Dim RptRecord As New RptPatientRecord
            ' Dim RptViewer As New FormReportViewer


            Dim ComplaintTable As DataTable = DA_Complaint.SelectByPatientID(PatientID)
            Dim HistoryTable As DataTable = DA_History.SelectByPatientID(PatientID)
            Dim PrescriptionTable As DataTable = DA_Prescription.SelectByPatientID(PatientID)

            Dim BiologyTable As DataTable = DA_Biology.SelectByPatientID(PatientID)
            Dim FibroTable As DataTable = DA_Fibroscopy.SelectByPatientID(PatientID)
            Dim ColoTable As DataTable = DA_Coloscopy.SelectByPatientID(PatientID)

            Dim NasoTable As DataTable = DA_Nasogastro.SelectByPatientID(PatientID)

            Dim EchoTable As DataTable = DA_Echo.SelectByPatientID(PatientID)

            Dim ScanTable As DataTable = DA_Scan.SelectByPatientID(PatientID)

            Dim FibroScan As DataTable = DA_FibroScan.GetDataByPatientID(PatientID) 'SelectByPatientID(PatientID)

            Dim MRITable As DataTable = DA_MRI.SelectByPatientID(PatientID)

            Dim CAAnaPath As DataTable = DA_CFAnaPath.GetData(PatientID)
            Dim PresRemark As DataTable = DA_PrescriptionRemark.SelectPrescriptionByPatientID(PatientID)

            Dim PhysicalTable As DataTable = DA_Physical.SelectByPatientID(PatientID)
            RptRecord.Database.Tables("Patient").SetDataSource(PatientTable)
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
            RptRecord.Subreports("PrescriptionRemark").SetDataSource(PresRemark)
            Me.CRPatientDocViewer.ReportSource = RptRecord

        End If



    End Sub


    Private Sub GbLoadingReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadingReport.DoWork
        PreviewReport()
    End Sub

    Private Sub GbLoadingReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadingReport.RunWorkerCompleted
        MainApplicationForm.StatusLoading(False)
    End Sub

    Private Sub BgLoadingPatient_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadingPatient.DoWork
        LoadDataToDatagrid()
    End Sub
    Private Sub LoadDataToDatagrid()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadDataToDatagrid))
        Else
            GridPatientConsult.DataSource = DA_Patient.GetData
        End If
    End Sub

    Private Sub BgLoadingPatient_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadingPatient.RunWorkerCompleted
        Application.DoEvents()
        MainApplicationForm.StatusLoading(False)
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FPatient As New FindPatient(Me)
        FPatient.ShowDialog()
        'MainApplicationForm.StatusLoading(True)
        'BgLoadingPatient.RunWorkerAsync()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If GridPatientConsult.SelectedItems.Count = 0 Then Exit Sub
        ''Show Report
        MainApplicationForm.StatusLoading(True)
        BgLoadingReport.RunWorkerAsync()

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If GridPatientConsult.SelectedItems.Count = 0 Then Exit Sub
        Dim RptOrdinance As New RptOrdinance
        Dim OrdinanceViewer As New FormReportViewer
        Dim RptPatientTable As New DataTable
        Dim RptInfoTable As New DataTable
        RptInfoTable = DA_PrescriptionHistory.SelectPrescriptionByID(CLng(Me.GridPatientConsult.GetRow.Cells("prescriptionid").Value.ToString))
        Dim DoctorID As Integer = CInt(RptInfoTable.Rows(0).Item("doctorid"))
        RptPatientTable = DA_PatientHistory.SelectPatient(CLng(Me.GridPatientConsult.GetRow.Cells("ppatientid").Value))
        Dim RptOrdinanceTable As New DataTable
        Dim DA_Ordinance As New DS_InvoiceTableAdapters.tblPrescriptionTableAdapter
        'Dim DoctorName As String = DA_Doctor.SelectDoctorByID(DoctorID).Rows(0).Item("Doctor_Name").ToString
        Dim Diagnosis As String = RptInfoTable.Rows(0).Item("diagnosis").ToString
        RptOrdinanceTable = DA_Ordinance.SelectPrescriptionByID(CLng(Me.GridPatientConsult.GetRow.Cells("prescriptionid").Value))
        RptOrdinance.Database.Tables("tblPrescription").SetDataSource(RptOrdinanceTable)
        RptOrdinance.Database.Tables("tblpatient").SetDataSource(RptPatientTable)
        'RptOrdinance.SetParameterValue("Doctor", DoctorName)
        RptOrdinance.SetParameterValue("Diagnosis", Diagnosis)
        RptOrdinance.SetParameterValue("DatePrescription", Format(Me.GridPatientConsult.GetRow.Cells("Checkdate").Value, "dd-MMM-yyyy"))
        'Try
        Dim CrExportOptions As ExportOptions
        Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
        Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
        OrdinanceViewer.SplitContainer1.Panel2Collapsed = True
        CrDiskFileDestinationOptions.DiskFileName = My.Application.Info.DirectoryPath & "\crystalExport.pdf"
        CrExportOptions = RptOrdinance.ExportOptions
        With CrExportOptions
            .ExportDestinationType = ExportDestinationType.DiskFile
            .ExportFormatType = ExportFormatType.PortableDocFormat
            .DestinationOptions = CrDiskFileDestinationOptions
            .FormatOptions = CrFormatTypeOptions
        End With
        RptOrdinance.Export()
        Application.DoEvents()
        Application.DoEvents()
        OrdinanceViewer.AxAcroPDF1.src = My.Application.Info.DirectoryPath & "\crystalExport.pdf"
        OrdinanceViewer.AxAcroPDF1.setZoom(100)

        'MyProcess.StartInfo.FileName = "C:\crystalExport.pdf"
        'MyProcess.StartInfo.CreateNoWindow = True
        'MyProcess.Start()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        'MyProcess.Kill()
        'End Try

        'OrdinanceViewer.CVForm.ReportSource = RptOrdinance
        OrdinanceViewer.ShowDialog()

        'Dim FromPrescription As New PrescriptionList(Me)
        'FromPrescription.ShowDialog()
    End Sub

    Private Sub BtnEditConsultation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditConsultation.Click
        If GridPatientConsult.SelectedItems.Count = 0 Then Exit Sub
        Dim EditConsult As New EditConsultation(Me)
        EditConsult.ShowDialog()
        'If GridPatientConsult.SelectedItems.Count = 0 Then Exit Sub
        'Dim FromConsulation As New ConsultationList(Me)
        'FromConsulation.ShowDialog()
    End Sub

    Private Sub ViewPatientConsultTodayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewPatientConsultTodayToolStripMenuItem.Click
        Dim TblConsultToday As DataTable = DA_VeiwPatientConsult.SelectToday(Now.Date)
        GridPatientConsult.DataSource = TblConsultToday
    End Sub

    Private Sub BtnFindMoreInformation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindMoreInformation.Click
        Dim FConsult As New FindConsult(Me)
        FConsult.Show()
    End Sub
    Public Sub FindPatientNo(ByVal PatientNo As String)
        Dim TblConsultToday As DataTable = DA_VeiwPatientConsult.GetDataByPatientNo(PatientNo)
        GridPatientConsult.DataSource = TblConsultToday
    End Sub
    Public Sub FindByPatientName(ByVal PatientName As String)
        Dim TblConsultToday As DataTable = DA_VeiwPatientConsult.GetDataByPatientName("%" & PatientName & "%")
        GridPatientConsult.DataSource = TblConsultToday
    End Sub

End Class
