Public Class PrescriptionList
    Dim DA_PrescriptionDetail As New DSInvoiceTableAdapters.PrescriptionDetailTableAdapter
    Dim DA_Prescription As New DSInvoiceTableAdapters.tblprescriptionTableAdapter
    Dim HistoryPanel As UPatientMedicalReport
    Dim DA_Patient As New DS_PrescriptionTableAdapters.tblpatientTableAdapter
    Dim DA_Doctor As New DSPAtientTableAdapters.DoctorsTableAdapter
    Sub New(ByVal HPanel As UPatientMedicalReport)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.HistoryPanel = HPanel
        ' Add any initialization after the InitializeComponent() call.
        LoadPrescription()
    End Sub

    Sub LoadPrescription()
        If Me.HistoryPanel.GridPatientConsult.SelectedItems.Count = 0 Then Exit Sub
        Me.Prescription_List.DataSource = DA_PrescriptionDetail.SelectByPatientID(CLng(Me.HistoryPanel.GridPatientConsult.CurrentRow.Cells("ppatientid").Value))
        ''Me.Prescription_List.DataSource = DA_PrescriptionDetail.SelectByPatientID(2)
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub PrescriptionList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        'Try
        If Me.Prescription_List.SelectedItems.Count > 0 Then
            Dim RptOrdinance As New RptOrdinance
            Dim OrdinanceViewer As New FormReportViewer
            Dim RptPatientTable As New DataTable
            Dim RptInfoTable As New DataTable
            RptInfoTable = DA_Prescription.SelectPrescriptionByID(CLng(Me.Prescription_List.CurrentRow.Cells("prescriptionid").Value.ToString))
            Dim DoctorID As Integer = CInt(RptInfoTable.Rows(0).Item("doctorid"))
            RptPatientTable = DA_Patient.GetDataByPatientUse(CLng(Me.HistoryPanel.GridPatientConsult.CurrentRow.Cells("patientid").Value))
            Dim RptOrdinanceTable As New DataTable
            Dim DA_Ordinance As New DS_InvoiceTableAdapters.tblPrescriptionTableAdapter
            'Dim DoctorName As String = DA_Doctor.SelectDoctorByID(DoctorID).Rows(0).Item("Doctor_Name").ToString
            Dim Diagnosis As String = RptInfoTable.Rows(0).Item("diagnosis").ToString
            RptOrdinanceTable = DA_Ordinance.SelectPrescriptionByID(CLng(Me.Prescription_List.CurrentRow.Cells("prescriptionid").Value))
            RptOrdinance.Database.Tables("tblPrescription").SetDataSource(RptOrdinanceTable)
            RptOrdinance.Database.Tables("tblpatient").SetDataSource(RptPatientTable)
            'RptOrdinance.SetParameterValue("Doctor", DoctorName)
            RptOrdinance.SetParameterValue("Diagnosis", Diagnosis)
            RptOrdinance.SetParameterValue("DatePrescription", Format(Prescription_List.GetRow.Cells("Checkdate").Value, "dd-MMM-yyyy"))
            OrdinanceViewer.CVForm.ReportSource = RptOrdinance
            OrdinanceViewer.ShowDialog()
        End If
        'Catch ex As Exception
        '    MsgBox("To view the prescription, please select one row in each date of prescription.", MsgBoxStyle.Information, "Invalid Selection")
        '    Exit Sub
        'End Try
    End Sub
End Class