Public Class ConsultationList
    Dim DA_Prescription As New DSInvoiceTableAdapters.tblprescriptionTableAdapter
    Dim HistoryPanel As UPatientMedicalReport
    Dim DA_Patient As New DS_PrescriptionTableAdapters.tblpatientTableAdapter
    Dim DA_Doctor As New DSPAtientTableAdapters.DoctorsTableAdapter
    Sub New(ByVal HPanel As UPatientMedicalReport)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.HistoryPanel = HPanel
        ' Add any initialization after the InitializeComponent() call.
        LoadConsultation()
    End Sub

    Sub LoadConsultation()
        If Me.HistoryPanel.GridPatientConsult.SelectedItems.Count = 0 Then Exit Sub
        Me.Prescription_List.DataSource = DA_Prescription.SelectByPatientID(CLng(Me.HistoryPanel.GridPatientConsult.CurrentRow.Cells("ppatientid").Value))
        ''Me.Prescription_List.DataSource = DA_PrescriptionDetail.SelectByPatientID(2)
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Dim FrmEdit As New EditConsultation(Me)
        FrmEdit.ShowDialog()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class