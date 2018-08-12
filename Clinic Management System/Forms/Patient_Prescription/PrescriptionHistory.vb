Public Class PrescriptionHistory
    Dim DA_Patient As New DSPAtientTableAdapters.tblpatientTableAdapter
    Dim DA_Doctor As New DSPAtientTableAdapters.DoctorsTableAdapter
    Dim DA_Diagnosis As New DSPAtientTableAdapters.tbldiagnosisTableAdapter
    Dim DA_ConsultType As New DSPAtientTableAdapters.tblConsultTypeTableAdapter
    Dim DA_ConDetails As New DSPAtientTableAdapters.Consultation_DetailsTableAdapter
    Dim DA_CheckDetails As New DSPAtientTableAdapters.Check_DetailsTableAdapter

    Dim DA_Prescription As New DSPAtientTableAdapters.tblprescriptionTableAdapter
    Dim DA_PrescriptionDetail As New DSPAtientTableAdapters.tblprescriptionDetailTableAdapter
    Dim DA_ParaDetail As New DSPAtientTableAdapters.tblparacheckdetailTableAdapter
    Dim DA_HistoryDetail As New DSMedicalHistoryTableAdapters.tblhistorydetailTableAdapter
    Dim DA_ComplaintDetail As New DSComplaintTableAdapters.tblcomplaintdetailTableAdapter
    Dim DA_PhysicalDetail As New DSPhysicalExamTableAdapters.tblphysicalcheckdetailTableAdapter

    Dim Consult As PatientInformation
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal ConsultPanel As PatientInformation)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Consult = ConsultPanel
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub RowChanged()
        Dim DA_CheckDetails As New DSPAtientTableAdapters.Check_DetailsTableAdapter
        StomachConsultList.DataSource = DA_ConDetails.GetDetailByDisease(PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value, 1)
        LiverConsultList.DataSource = DA_ConDetails.GetDetailByDisease(PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value, 2)
        FinalList.DataSource = DA_ConDetails.GetDetailByDisease(PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value, 3)
        BloodCheckList.DataSource = DA_CheckDetails.GetDataByPrescriptionID(PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
    End Sub
    Private Sub PrescriptionHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Patient As New DataTable
        Patient = DA_Patient.SelectPatientByID(Me.lblpatientId.Text)
        Me.txtid.Text = Patient.Rows(0).Item("patientid").ToString
        Me.txtname.Text = Patient.Rows(0).Item("pname").ToString
        Me.txtsex.Text = Patient.Rows(0).Item("pgender").ToString
        Me.txtage.Text = Year(Now) - Year(Patient.Rows(0).Item("pAge")).ToString
        Me.txtaddress.Text = Patient.Rows(0).Item("pcontactaddress").ToString
        Me.txtphone.Text = Patient.Rows(0).Item("pphoneno").ToString
        RefreshData()
    End Sub
    Sub RefreshData()
        Me.PrescriptionHistoryList.DataSource = DA_Prescription.SelectPrescriptionByPatientID(Me.lblpatientId.Text)
    End Sub
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Are you sure you want to delete this prescription?", MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.Yes Then
            ''Delete Data From Foreign Table
            DA_ComplaintDetail.DeleteComplaintByPrescriptionID(Me.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
            DA_ParaDetail.DeleteParaByPrescriptionID(Me.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
            DA_PhysicalDetail.DeletePhysicalByPrescriptionID(Me.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
            DA_HistoryDetail.DeleteHistoryByPrescriptionID(Me.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
            DA_PrescriptionDetail.DeletePrescriptionByPrescriptionID(Me.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
            ''Delete Data From Primary Table
            DA_Prescription.DeletePrescription(Me.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
            RefreshData()
        End If
    End Sub

    Private Sub BtnNewPrescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewPrescription.Click
        Dim NPrescription As New NewPrescription(Me)
        NPrescription.lblpatientId.Text = Me.lblpatientId.Text
        NPrescription.ShowDialog()
    End Sub

    Private Sub PrescriptionHistoryList_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles PrescriptionHistoryList.FormattingRow

    End Sub
    Private Sub PrescriptionHistoryList_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles PrescriptionHistoryList.RowDoubleClick
        Dim FrmEditPrescription As New Edit_Prescription(Me)
        FrmEditPrescription.cbodoctor.SelectedValue = PrescriptionHistoryList.CurrentRow.Cells("doctorid").Value
        FrmEditPrescription.cboconsulttype.Text = PrescriptionHistoryList.CurrentRow.Cells("consulttype").Value.ToString
        FrmEditPrescription.cbodiagnosis.Text = PrescriptionHistoryList.CurrentRow.Cells("diagnosis").Value.ToString
        FrmEditPrescription.txtremark.Text = PrescriptionHistoryList.CurrentRow.Cells("remark").Value
        FrmEditPrescription.ShowDialog()
    End Sub

    Private Sub PrescriptionHistoryList_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrescriptionHistoryList.SelectionChanged
        RowChanged()
        Me.ComplaintList.DataSource = DA_ComplaintDetail.SelectComplaintByPrescriptionID(Me.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
        Me.HistoryList.DataSource = DA_HistoryDetail.SelectHistoryByPrescriptionID(Me.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
        Me.ParaList.DataSource = DA_ParaDetail.SelectParaByPrescriptionID(Me.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
        Me.PhysicalList.DataSource = DA_PhysicalDetail.SelectPhysicalByPrescriptionID(Me.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
        Me.PrescriptionList.DataSource = DA_PrescriptionDetail.SelectPrescriptionByPrescriptionID(Me.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
        Me.txtremark.Text = PrescriptionHistoryList.CurrentRow.Cells("remark").Value
    End Sub

    Private Sub BtnAddNewComplaint_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnAddNewComplaint.Click
        Dim FrmComplaint As New Complaint(Me)
        FrmComplaint.lbloldprescription.Text = 1
        FrmComplaint.ShowDialog()
    End Sub
    Sub RefreshComplaint()
        Me.ComplaintList.DataSource = DA_ComplaintDetail.SelectComplaintByPrescriptionID(Me.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
    End Sub
    Sub RefreshPara()
        Me.ParaList.DataSource = DA_ParaDetail.SelectParaByPrescriptionID(Me.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
    End Sub
    Sub RefreshPhysical()
        Me.PhysicalList.DataSource = DA_PhysicalDetail.SelectPhysicalByPrescriptionID(Me.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
    End Sub
    Sub RefreshHistory()
        Me.HistoryList.DataSource = DA_HistoryDetail.SelectHistoryByPrescriptionID(Me.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
    End Sub
    Sub RefreshPrescription()
        Me.PrescriptionList.DataSource = DA_PrescriptionDetail.SelectPrescriptionByPrescriptionID(Me.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
    End Sub

    Private Sub BtnAddNewHistory_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnAddNewHistory.Click
        Dim FrmHistor As New History(Me)
        FrmHistor.lbloldprescription.Text = 1
        FrmHistor.ShowDialog()
    End Sub

    Private Sub BtnAddNewPara_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnAddNewPara.Click
        Dim FrmPara As New ParaClinic(Me)
        FrmPara.lbloldprescription.Text = 1
        FrmPara.ShowDialog()
    End Sub

    Private Sub BtnAddNewPrescription_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnAddNewPrescription.Click
        Dim FrmPrescription As New Prescription(Me)
        FrmPrescription.lbloldprescription.Text = 1
        FrmPrescription.ShowDialog()
    End Sub

    Private Sub BtnEditComplaint_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnEditComplaint.Click
        If (Me.ComplaintList.RowCount > 0) Then
            Dim FrmComplaint As New Complaint(Me)
            FrmComplaint.lblaction.Text = 1
            FrmComplaint.lbloldprescription.Text = 1
            FrmComplaint.cbocomplaint.SelectedValue = ComplaintList.CurrentRow.Cells("complaintid").Value
            FrmComplaint.txtdesc.Text = ComplaintList.CurrentRow.Cells("note").Value
            FrmComplaint.ShowDialog()
        End If
    End Sub

    Private Sub BtnEditHistory_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnEditHistory.Click
        If (Me.HistoryList.RowCount > 0) Then
            Dim FrmHistory As New History(Me)
            FrmHistory.lblaction.Text = 1
            FrmHistory.lbloldprescription.Text = 1
            FrmHistory.cbohistory.SelectedValue = HistoryList.CurrentRow.Cells("historyid").Value
            FrmHistory.txtdesc.Text = HistoryList.CurrentRow.Cells("note").Value
            FrmHistory.ShowDialog()
        End If
    End Sub

    Private Sub BtnEditPara_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnEditPara.Click
        If (Me.ParaList.RowCount > 0) Then
            Dim FrmPara As New ParaClinic(Me)
            FrmPara.lblaction.Text = 1
            FrmPara.lbloldprescription.Text = 1
            FrmPara.cboexamination.SelectedValue = ParaList.CurrentRow.Cells("paracheckid").Value
            FrmPara.txtdesc.Text = ParaList.CurrentRow.Cells("note").Value
            FrmPara.ShowDialog()
        End If
    End Sub


    Private Sub BtnDeleteComplaint_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnDeleteComplaint.Click
        If (Me.ComplaintList.RowCount > 0) Then
            If MsgBox("Are you sure you want to delete this patient complaint?", MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.Yes Then
                DA_ComplaintDetail.DeleteComplaint(Me.ComplaintList.CurrentRow.Cells("complaintdetailid").Value)
                RefreshComplaint()
            End If
        End If
    End Sub

    Private Sub BtnDeleteHistory_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnDeleteHistory.Click
        If (Me.HistoryList.RowCount > 0) Then
            If MsgBox("Are you sure you want to delete this medical history?", MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.Yes Then
                DA_HistoryDetail.DeleteHistory(Me.HistoryList.CurrentRow.Cells("historydetailid").Value)
                RefreshHistory()
            End If
        End If
    End Sub

    Private Sub BtnDeletePara_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnDeletePara.Click
        If (Me.ParaList.RowCount > 0) Then
            If MsgBox("Are you sure you want to delete this para clinic examination?", MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.Yes Then
                DA_ParaDetail.DeletePara(Me.ParaList.CurrentRow.Cells("paracheckdetailid").Value)
                RefreshPara()
            End If
        End If
    End Sub

    Private Sub BtnEditPrescription_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnEditPrescription.Click
        If (Me.PrescriptionList.RowCount > 0) Then
            Dim FrmPrescription As New Prescription(Me)
            FrmPrescription.lblaction.Text = 1
            FrmPrescription.lbloldprescription.Text = 1
            FrmPrescription.cbomedicine.SelectedValue = PrescriptionList.CurrentRow.Cells("medicineid").Value
            FrmPrescription.txtdosage.Text = PrescriptionList.CurrentRow.Cells("dosage").Value
            FrmPrescription.txtduration.Text = PrescriptionList.CurrentRow.Cells("duration").Value
            FrmPrescription.ShowDialog()
        End If
    End Sub

    Private Sub BtnDeletePre_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnDeletePre.Click
        If (Me.PrescriptionList.RowCount > 0) Then
            If MsgBox("Are you sure you want to delete this prescription?", MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.Yes Then
                DA_PrescriptionDetail.DeletePrescription(Me.PrescriptionList.CurrentRow.Cells("prescriptiondetailid").Value)
                RefreshPrescription()
            End If
        End If
    End Sub

    Private Sub BtnDeletePreHistory_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnDeletePreHistory.Click
        If MsgBox("Are you sure you want to delete this prescription?", MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.Yes Then
            ''Delete Data From Foreign Table
            DA_ComplaintDetail.DeleteComplaintByPrescriptionID(Me.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
            DA_ParaDetail.DeleteParaByPrescriptionID(Me.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
            DA_PhysicalDetail.DeletePhysicalByPrescriptionID(Me.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
            DA_HistoryDetail.DeleteHistoryByPrescriptionID(Me.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
            DA_PrescriptionDetail.DeletePrescriptionByPrescriptionID(Me.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
            ''Delete Data From Primary Table
            DA_Prescription.DeletePrescription(Me.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
            RefreshData()
        End If
    End Sub

    Private Sub BtnDeletePreHistory_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDeletePreHistory.Disposed

    End Sub

    Private Sub BtnEditPreHistory_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnEditPreHistory.Click
        Dim FrmEditPrescription As New Edit_Prescription(Me)
        FrmEditPrescription.cbodoctor.SelectedValue = PrescriptionHistoryList.CurrentRow.Cells("doctorid").Value
        FrmEditPrescription.cboconsulttype.Text = PrescriptionHistoryList.CurrentRow.Cells("consulttype").Value.ToString
        FrmEditPrescription.cbodiagnosis.Text = PrescriptionHistoryList.CurrentRow.Cells("diagnosis").Value.ToString
        FrmEditPrescription.txtremark.Text = PrescriptionHistoryList.CurrentRow.Cells("remark").Value
        FrmEditPrescription.ShowDialog()
    End Sub

    Private Sub BtnPrintAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintAll.Click

        Dim DA_Patient As New DS_PrescriptionTableAdapters.tblpatientTableAdapter
        Dim DA_Complaint As New DS_PrescriptionTableAdapters.tblcomplaintTableAdapter
        Dim DA_History As New DS_PrescriptionTableAdapters.tblhistoryTableAdapter
        Dim DA_Para As New DS_PrescriptionTableAdapters.tblparaTableAdapter
        Dim DA_Physical As New DS_PrescriptionTableAdapters.tblphysicalTableAdapter
        Dim DA_Prescription As New DS_PrescriptionTableAdapters.tblprescriptionTableAdapter
        Dim DA_PrescriptionDetail As New DS_PrescriptionTableAdapters.tblprescriptiondetailTableAdapter

        Dim RptPrescription As New RptPrescription
        Dim Viewer As New FormReportViewer

        Dim PatientTable As New DataTable
        Dim ComplaintDetailTable As New DataTable
        Dim HistoryDetailTable As New DataTable
        Dim ParaDetailTable As New DataTable
        Dim PhysicalDetailTable As New DataTable
        Dim PrescriptionTable As New DataTable
        Dim PrescriptionDetailTable As New DataTable


        PatientTable = DA_Patient.GetDataByPatientUse(Me.lblpatientId.Text)
        PrescriptionTable = DA_Prescription.SelectPrescriptionByPatientID(Me.lblpatientId.Text)
        ComplaintDetailTable = DA_Complaint.SelectComplaintByPatientID(Me.lblpatientId.Text)
        HistoryDetailTable = DA_History.SelectHistoryByPatientID(Me.lblpatientId.Text)
        PhysicalDetailTable = DA_Physical.SelectPhysicalByPatientID(Me.lblpatientId.Text)
        ParaDetailTable = DA_Para.SelectParaByPatientID(Me.lblpatientId.Text)
        PrescriptionDetailTable = DA_PrescriptionDetail.SelectPrescriptionDetailByPatientID(Me.lblpatientId.Text)

        ''Set Datasourse of Report Tables
        RptPrescription.Database.Tables("tblpatient").SetDataSource(PatientTable)
        RptPrescription.Subreports.Item("ConsultType").SetDataSource(PrescriptionTable)
        RptPrescription.Subreports.Item("Complaint").SetDataSource(ComplaintDetailTable)
        RptPrescription.Subreports.Item("History").SetDataSource(HistoryDetailTable)
        RptPrescription.Subreports.Item("Physical Examination").SetDataSource(PhysicalDetailTable)
        RptPrescription.Subreports.Item("Para Examination").SetDataSource(ParaDetailTable)
        RptPrescription.Subreports.Item("Prescription").SetDataSource(PrescriptionDetailTable)
        RptPrescription.Subreports.Item("Remark").SetDataSource(PrescriptionTable)

        Viewer.CVForm.ReportSource = RptPrescription
        Viewer.ShowDialog()
        Viewer.Close()
        Viewer.Dispose()
    End Sub

    Private Sub BtnPrintCurrent_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPrintCurrent.Click
        Dim DA_Patient As New DS_PrescriptionTableAdapters.tblpatientTableAdapter
        Dim DA_Complaint As New DS_PrescriptionTableAdapters.tblcomplaintTableAdapter
        Dim DA_History As New DS_PrescriptionTableAdapters.tblhistoryTableAdapter
        Dim DA_Para As New DS_PrescriptionTableAdapters.tblparaTableAdapter
        Dim DA_Physical As New DS_PrescriptionTableAdapters.tblphysicalTableAdapter
        Dim DA_Prescription As New DS_PrescriptionTableAdapters.tblprescriptionTableAdapter
        Dim DA_PrescriptionDetail As New DS_PrescriptionTableAdapters.tblprescriptiondetailTableAdapter

        Dim RptPrescription As New RptPrescription
        Dim Viewer As New FormReportViewer

        Dim PatientTable As New DataTable
        Dim ComplaintDetailTable As New DataTable
        Dim HistoryDetailTable As New DataTable
        Dim ParaDetailTable As New DataTable
        Dim PhysicalDetailTable As New DataTable
        Dim PrescriptionTable As New DataTable
        Dim PrescriptionDetailTable As New DataTable

        Dim PrescriptionID As Integer = CInt(Me.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
        PatientTable = DA_Patient.GetDataByPatientUse(Me.lblpatientId.Text)
        PrescriptionTable = DA_Prescription.SelectPrescriptionByID(PrescriptionID)
        ComplaintDetailTable = DA_Complaint.SelectComplaintByPrescriptionID(Me.lblpatientId.Text, PrescriptionID)
        HistoryDetailTable = DA_History.SelectHistoryByPrescriptionID(Me.lblpatientId.Text, PrescriptionID)
        PhysicalDetailTable = DA_Physical.SelectPhysicalByPrescriptionID(Me.lblpatientId.Text, PrescriptionID)
        ParaDetailTable = DA_Para.SelectParaByPrescriptionID(Me.lblpatientId.Text, PrescriptionID)
        PrescriptionDetailTable = DA_PrescriptionDetail.SelectPrescriptionDetailByPrescriptionID(Me.lblpatientId.Text, PrescriptionID)

        ''Set Datasourse of Report Tables
        RptPrescription.Database.Tables("tblpatient").SetDataSource(PatientTable)
        RptPrescription.Subreports.Item("ConsultType").SetDataSource(PrescriptionTable)
        RptPrescription.Subreports.Item("Complaint").SetDataSource(ComplaintDetailTable)
        RptPrescription.Subreports.Item("History").SetDataSource(HistoryDetailTable)
        RptPrescription.Subreports.Item("Physical Examination").SetDataSource(PhysicalDetailTable)
        RptPrescription.Subreports.Item("Para Examination").SetDataSource(ParaDetailTable)
        RptPrescription.Subreports.Item("Prescription").SetDataSource(PrescriptionDetailTable)
        RptPrescription.Subreports.Item("Remark").SetDataSource(PrescriptionTable)

        Viewer.CVForm.ReportSource = RptPrescription
        Viewer.ShowDialog()
        Viewer.Close()
        Viewer.Dispose()
    End Sub

    
    Private Sub BtnNewInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewInvoice.Click

        Dim FNewInvoice As New NewInvoice(Me)
        Dim ParaTable As New DataTable
        ParaTable = DA_ParaDetail.SelectParaByPrescriptionID(Me.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
        Dim ConsultPrice As Double = PrescriptionHistoryList.CurrentRow.Cells("consultprice").Value
        Dim TotalParaCharge As Double = 0
        Dim TotalCharge As Double = 0
        For i = 0 To ParaTable.Rows.Count - 1
            TotalParaCharge = CDbl(TotalParaCharge) + CDbl(ParaTable.Rows(i).Item("servicecharge"))
        Next
        FNewInvoice.txtconsulttype.Text = PrescriptionHistoryList.CurrentRow.Cells("consulttype").Value
        FNewInvoice.txtconsultfee.Text = ConsultPrice
        FNewInvoice.txtparacharge.Text = TotalParaCharge

        TotalCharge = TotalParaCharge + ConsultPrice
        Dim TotalRiels As Double
        Dim ExchangeRate As Double = FNewInvoice.txtexchangerate.Text
        TotalRiels = TotalCharge * ExchangeRate

        FNewInvoice.txtdollar.Text = Format(TotalCharge, "#,###.00")
        FNewInvoice.txtriel.Text = Format(TotalRiels, "#,###.00")

        FNewInvoice.ShowDialog()
        FNewInvoice.Close()
        FNewInvoice.Dispose()

    End Sub

    Private Sub BtnNewStomach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewStomach.Click
        Dim StomachForm As New NewStomachConsultation(Me)
        StomachForm.txtPatientID.Text = Me.lblpatientId.Text
        StomachForm.ShowDialog()
    End Sub

    Private Sub BtnNewLiver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnNewLiver.Click
        Dim LiverForm As New NewLiverConsultation(Me)
        LiverForm.txtPatientID.Text = Me.lblpatientId.Text
        LiverForm.ShowDialog()
    End Sub

    Private Sub BtnNewFinal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnNewFinal.Click
        Dim FinalForm As New NewFinalConsultation(Me)
        FinalForm.txtPatientID.Text = Me.lblpatientId.Text
        FinalForm.ShowDialog()
    End Sub

    Private Sub BtnNewBloodTest_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnNewBloodTest.Click
        Dim BloodForm As New BloodCheck(Me)
        BloodForm.txtPatientID.Text = Me.lblpatientId.Text
        BloodForm.ShowDialog()
    End Sub

    Private Sub StomachConsultList_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles StomachConsultList.RowDoubleClick
        Dim FView As New ViewStomachConsultation(Me)
        FView.txtPConsultNo.Text = StomachConsultList.CurrentRow.Cells("PConsult_No").Value
        FView.txtPatientID.Text = Me.lblpatientId.Text
        FView.ShowDialog()
    End Sub

    Private Sub LiverConsultList_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles LiverConsultList.FormattingRow

    End Sub

    Private Sub StomachConsultList_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles StomachConsultList.FormattingRow

    End Sub

    Private Sub FinalList_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles FinalList.RowDoubleClick
        Dim FView As New ViewFinalConsultation(Me)
        FView.txtPConsultNo.Text = FinalList.CurrentRow.Cells("PConsult_No").Value
        FView.txtPatientID.Text = Me.lblpatientId.Text
        FView.ShowDialog()
    End Sub

    Private Sub LiverConsultList_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles LiverConsultList.RowDoubleClick
        Dim FView As New ViewLiverConsultation(Me)
        FView.txtPConsultNo.Text = LiverConsultList.CurrentRow.Cells("PConsult_No").Value
        FView.txtPatientID.Text = Me.lblpatientId.Text
        FView.ShowDialog()
    End Sub

    Private Sub BloodCheckList_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles BloodCheckList.RowDoubleClick
        'Dim FView As New ViewBloodCheck(Me)
        'FView.txtCheckNo.Text = BloodCheckList.CurrentRow.Cells("Check_No").Value
        'FView.ShowDialog()
    End Sub

    Private Sub BtnAddNewStomachConsult_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnAddNewStomachConsult.Click
        BtnNewStomach_Click(sender, e)
    End Sub

    Private Sub BtnAddNewFinalConsult_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnAddNewFinalConsult.Click
        BtnNewFinal_Click(sender, e)
    End Sub

    Private Sub BtnAddNewBloodTest_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnAddNewBloodTest.Click
        BtnNewBloodTest_Click(sender, e)
    End Sub

    Private Sub BtnEditStomachConsult_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnEditStomachConsult.Click

        Try
            Dim FView As New ViewStomachConsultation(Me)
            FView.txtPConsultNo.Text = StomachConsultList.CurrentRow.Cells("PConsult_No").Value
            FView.txtPatientID.Text = Me.lblpatientId.Text
            FView.ShowDialog()
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub BtnEditFinalConsult_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnEditFinalConsult.Click
        Dim FView As New ViewFinalConsultation(Me)
        FView.txtPConsultNo.Text = FinalList.CurrentRow.Cells("PConsult_No").Value
        FView.txtPatientID.Text = Me.lblpatientId.Text
        FView.ShowDialog()
    End Sub

    Private Sub BtnEditLiverConsult_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnEditLiverConsult.Click
        Dim FView As New ViewLiverConsultation(Me)
        FView.txtPConsultNo.Text = LiverConsultList.CurrentRow.Cells("PConsult_No").Value
        FView.txtPatientID.Text = Me.lblpatientId.Text
        FView.ShowDialog()
    End Sub

    Private Sub BtnEditBloodTest_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnEditBloodTest.Click
        'Dim FView As New ViewBloodCheck(Me)
        'FView.txtCheckNo.Text = BloodCheckList.CurrentRow.Cells("Check_No").Value
        'FView.ShowDialog()
    End Sub

    Private Sub BtnAddNewLiverConsult_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnAddNewLiverConsult.Click
        BtnNewLiver_Click(sender, e)
    End Sub

  

    Private Sub BtnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class