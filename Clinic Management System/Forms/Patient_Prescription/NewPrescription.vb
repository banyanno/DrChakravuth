Public Class NewPrescription
    ''Pre-TableAdapter
    Dim DA_PrePara As New DSPAtientTableAdapters.tblpreparacheckdetailTableAdapter
    Dim DA_PrePrescription As New DSPAtientTableAdapters.tblpreprescriptionDetailTableAdapter
    Dim DA_Unit As New DSPAtientTableAdapters.tblunitTableAdapter

    Dim DA_Patient As New DSPAtientTableAdapters.tblpatientTableAdapter
    Dim DA_Doctor As New DSPAtientTableAdapters.DoctorsTableAdapter
    Dim DA_Diagnosis As New DSPAtientTableAdapters.tbldiagnosisTableAdapter
    Dim DA_ConsultType As New DSPAtientTableAdapters.tblConsultTypeTableAdapter

    Dim DA_Prescription As New DSPAtientTableAdapters.tblprescriptionTableAdapter
    Dim DA_PrescriptionDetail As New DSPAtientTableAdapters.tblprescriptionDetailTableAdapter
    Dim DA_ParaDetail As New DSPAtientTableAdapters.tblparacheckdetailTableAdapter
    Dim DA_HistoryDetail As New DSMedicalHistoryTableAdapters.tblhistorydetailTableAdapter
    Dim DA_ComplaintDetail As New DSComplaintTableAdapters.tblcomplaintdetailTableAdapter
    Dim DA_PhysicalDetail As New DSPhysicalExamTableAdapters.tblphysicalcheckdetailTableAdapter

    Dim Consult As DoctorConsultation
    Dim History As PrescriptionHistory


    ' Data Adapter Prescription Delail.............................

    Dim DA_Complaint As New DSPAtientTableAdapters.tblcomplaintTableAdapter
    Dim DA_History As New DSPAtientTableAdapters.tblhistoryTableAdapter
    Dim DA_Physical As New DSPAtientTableAdapters.tblPhysicalCheckTableAdapter
    Dim DA_Para As New DSPAtientTableAdapters.tblparacheckTableAdapter
    Dim DA_Medicine As New DSPAtientTableAdapters.tblmedicineTableAdapter

    'End Data Adapter prescript Detail ---------------------------

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' Initial Prescription Detail.................................
        LoadComplaint()
        LoadHistory()
        LoadPhysical()
        LoadPara()
        LoadPrescription()
    End Sub
    Sub New(ByVal ConsultPanel As DoctorConsultation)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Consult = ConsultPanel
        ' Add any initialization after the InitializeComponent() call.
        LoadComplaint()
        LoadHistory()
        LoadPhysical()
        LoadPara()
        LoadPrescription()
    End Sub
    Sub New(ByVal HistoryPanel As PrescriptionHistory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.History = HistoryPanel
        ' Add any initialization after the InitializeComponent() call.
        ' Initial Prescription Detail.................................
        LoadComplaint()
        LoadHistory()
        LoadPhysical()
        LoadPara()
        LoadPrescription()
    End Sub
    Sub RefreshPara()
        Me.ParaList.DataSource = DA_PrePara.SelectParaByPatientID(lblpatientId.Text)
    End Sub
    Sub RefreshPrescription()
        Me.PrescriptionList.DataSource = DA_PrePrescription.SelectPrescriptionByPatientID(lblpatientId.Text)
    End Sub
    Private Sub ClearDataFromPreTable()
        DA_PrePara.DeleteParaByPatientID(Me.lblpatientId.Text)
        DA_PrePrescription.DeletePrescriptionByPatientID(Me.lblpatientId.Text)
    End Sub
    Private Sub NewPrescription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''Delete uncomplete data in pre table by PatientID
        ClearDataFromPreTable()

        Dim Patient As New DataTable
        Patient = DA_Patient.SelectPatientByPID(Me.lblpatientId.Text)
        Me.txtid.Text = Patient.Rows(0).Item("patientid").ToString
        Me.txtname.Text = Patient.Rows(0).Item("pname").ToString
        Me.txtsex.Text = Patient.Rows(0).Item("pgender").ToString
        Me.txtage.Text = Year(Now) - Year(Patient.Rows(0).Item("pAge")).ToString
        Me.txtaddress.Text = Patient.Rows(0).Item("pcontactaddress").ToString
        Me.txtphone.Text = Patient.Rows(0).Item("pphoneno").ToString

        Me.cboconsulttype.DataSource = DA_ConsultType.SelectConsultationTypes
        Me.cboconsulttype.DisplayMember = DA_ConsultType.SelectConsultationTypes.Columns("consulttypename").ColumnName
        Me.cboconsulttype.ValueMember = DA_ConsultType.SelectConsultationTypes.Columns("consulttypeid").ColumnName
        cboconsulttype.SelectedIndex = -1
        Me.cbodoctor.DataSource = DA_Doctor.SelectDoctor
        Me.cbodoctor.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        Me.cbodoctor.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_ID").ColumnName
        cbodoctor.SelectedIndex = -1
        Me.cbodiagnosis.DataSource = DA_Diagnosis.SelectDiagnosis
        Me.cbodiagnosis.DisplayMember = DA_Diagnosis.SelectDiagnosis.Columns("diagnosis").ColumnName
        Me.cbodiagnosis.ValueMember = DA_Diagnosis.SelectDiagnosis.Columns("diagnosisid").ColumnName
        cbodiagnosis.SelectedIndex = -1

        LoadComplaint()
        LoadPara()
        LoadHistory()
        LoadPhysical()
    End Sub

    Private Sub btnNewComplaint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmComplaint As New Complaint(Me)
        FrmComplaint.ShowDialog()
    End Sub

    Private Sub btnNewHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmHistory As New History(Me)
        FrmHistory.ShowDialog()
    End Sub

    Private Sub btnNewParaClinicExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmPara As New ParaClinic(Me)
        FrmPara.ShowDialog()
    End Sub

    Private Sub ComplaintList_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles ComplaintList.FormattingRow

    End Sub

    Private Sub ComplaintList_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComplaintList.KeyPress
        ''If Asc(e.KeyChar) = Keys.Delete Then
        MsgBox("delete")
        ''End If
    End Sub

    Private Sub ComplaintList_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles ComplaintList.RowDoubleClick
        Dim FrmComplaint As New Complaint(Me)
        FrmComplaint.lblaction.Text = 1
        FrmComplaint.cbocomplaint.SelectedValue = ComplaintList.CurrentRow.Cells("complaintid").Value
        FrmComplaint.txtdesc.Text = ComplaintList.CurrentRow.Cells("note").Value
        FrmComplaint.ShowDialog()
    End Sub

    Private Sub BtnAddNewComplaint_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnAddNewComplaint.Click
        Dim FrmComplaint As New Complaint(Me)
        FrmComplaint.ShowDialog()
    End Sub

    Private Sub BtnAddNewHistory_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnAddNewHistory.Click
        Dim FrmHistory As New History(Me)
        FrmHistory.ShowDialog()
    End Sub

    Private Sub BtnEditHistory_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnEditHistory.Click
        If (Me.HistoryList.RowCount > 0) Then
            Dim FrmHistory As New History(Me)
            FrmHistory.lblaction.Text = 1
            FrmHistory.cbohistory.SelectedValue = HistoryList.CurrentRow.Cells("historyid").Value
            FrmHistory.txtdesc.Text = HistoryList.CurrentRow.Cells("note").Value
            FrmHistory.ShowDialog()
        End If
    End Sub

    Private Sub HistoryList_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles HistoryList.RowDoubleClick
        Dim FrmHistory As New History(Me)
        FrmHistory.lblaction.Text = 1
        FrmHistory.cbohistory.SelectedValue = HistoryList.CurrentRow.Cells("historyid").Value
        FrmHistory.txtdesc.Text = HistoryList.CurrentRow.Cells("note").Value
        FrmHistory.ShowDialog()
    End Sub

    Private Sub BtnDeletePara_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnDeletePara.Click
        If (Me.ParaList.RowCount > 0) Then
            If MsgBox("Are you sure you want to delete this para clinic examination?", MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.Yes Then
                DA_PrePara.DeletePara(Me.ParaList.CurrentRow.Cells("preid").Value)
                RefreshPara()
            End If
        End If
    End Sub

    Private Sub BtnEditPara_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnEditPara.Click
        If (Me.ParaList.RowCount > 0) Then
            Dim FrmPara As New ParaClinic(Me)
            FrmPara.lblaction.Text = 1
            FrmPara.cboexamination.SelectedValue = ParaList.CurrentRow.Cells("paracheckid").Value
            FrmPara.txtdesc.Text = ParaList.CurrentRow.Cells("note").Value
            FrmPara.ShowDialog()
        End If
    End Sub

    Private Sub BtnAddNewPara_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnAddNewPara.Click
        Dim FrmPara As New ParaClinic(Me)
        FrmPara.ShowDialog()
    End Sub

    Private Sub ParaList_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles ParaList.RowDoubleClick
        If (Me.ParaList.RowCount > 0) Then
            Dim FrmPara As New ParaClinic(Me)
            FrmPara.lblaction.Text = 1
            FrmPara.cboexamination.SelectedValue = ParaList.CurrentRow.Cells("paracheckid").Value
            FrmPara.txtdesc.Text = ParaList.CurrentRow.Cells("note").Value
            FrmPara.ShowDialog()
        End If
    End Sub

    Private Sub btnNewPrescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmPrescription As New Prescription(Me)
        FrmPrescription.ShowDialog()
    End Sub

    Private Sub BtnDeletePrescription_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnDeletePrescription.Click
        If (Me.PrescriptionList.RowCount > 0) Then
            If MsgBox("Are you sure you want to delete this prescription?", MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.Yes Then
                DA_PrePrescription.DeletePrescription(Me.PrescriptionList.CurrentRow.Cells("preid").Value)
                RefreshPrescription()
            End If
        End If
    End Sub

    Private Sub BtnEditPrescription_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnEditPrescription.Click
        If (Me.PrescriptionList.RowCount > 0) Then
            Dim FrmPrescription As New Prescription(Me)
            FrmPrescription.lblaction.Text = 1
            FrmPrescription.cbomedicine.SelectedValue = PrescriptionList.CurrentRow.Cells("medicineid").Value
            FrmPrescription.txtdosage.Text = PrescriptionList.CurrentRow.Cells("dosage").Value
            FrmPrescription.txtduration.Text = PrescriptionList.CurrentRow.Cells("duration").Value
            FrmPrescription.ShowDialog()
        End If
    End Sub

    Private Sub BtnAddNewPrescription_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnAddNewPrescription.Click
        Dim FrmPrescription As New Prescription(Me)
        FrmPrescription.ShowDialog()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Dim ParaList As New DataTable
        'Dim PhysicalList As New DataTable
        'Dim ComplaintList As New DataTable
        'Dim HistoryList As New DataTable
        'Dim PrescriptionList As New DataTable

        'ParaList = DA_PrePara.SelectParaByPatientID(Me.lblpatientId.Text)
        'PhysicalList = DA_PrePhysical.SelectPhysicalByPatientID(Me.lblpatientId.Text)
        'ComplaintList = DA_PreComplaint.SelectComplaintByPatientID(Me.lblpatientId.Text)
        'HistoryList = DA_PreHistory.SelectHistoryByPatientID(Me.lblpatientId.Text)
        'PrescriptionList = DA_PrePrescription.SelectPrescriptionByPatientID(Me.lblpatientId.Text)


        'If ValidateDateTimePicker(dtprescription, "", ErrPrescription) = False Then Exit Sub
        'If ValidateCombobox(cboconsulttype, "", ErrPrescription) = False Then Exit Sub
        'If ValidateCombobox(cbodiagnosis, "", ErrPrescription) = False Then Exit Sub
        'If ValidateCombobox(cbodoctor, "", ErrPrescription) = False Then Exit Sub
        'Dim ConsultPrice As Double
        'ConsultPrice = DA_ConsultType.SelectConsultByID(CInt(Me.cboconsulttype.SelectedValue)).Rows(0).Item("price")
        ' ''Insert Prescription (Primary Table)
        'DA_Prescription.InsertPrescription(Me.lblpatientId.Text, CInt(Me.cbodoctor.SelectedValue.ToString), Me.cbodiagnosis.Text, FormatDateTime(dtprescription.Value, DateFormat.ShortDate), cboconsulttype.Text, ConsultPrice, Me.txtremark.Text, 1)


        ' ''Get Data From PreDetailTable and Insert Into the real Detail Table (Foreign Tables)
        'Dim PrescriptionID As Long
        'If DA_Prescription.SelectMaxID.ToString = "" Then
        '    PrescriptionID = 1
        'Else
        '    PrescriptionID = DA_Prescription.SelectMaxID
        'End If


        'For i = 0 To ParaList.Rows.Count - 1
        '    DA_ParaDetail.InsertPara(ParaList.Rows(i).Item("paracheckid"), PrescriptionID, ParaList.Rows(i).Item("servicecharge"), ParaList.Rows(i).Item("note"))
        'Next

        'For j = 0 To ComplaintList.Rows.Count - 1
        '    DA_ComplaintDetail.InsertComplaint(ComplaintList.Rows(j).Item("complaintid"), PrescriptionID, ComplaintList.Rows(j).Item("note"))
        'Next

        'For k = 0 To HistoryList.Rows.Count - 1
        '    DA_HistoryDetail.InsertHistory(HistoryList.Rows(k).Item("historyid"), PrescriptionID, HistoryList.Rows(k).Item("note"))
        'Next

        'For l = 0 To PhysicalList.Rows.Count - 1
        '    DA_PhysicalDetail.InsertPhysical(PhysicalList.Rows(l).Item("physicalcheckid"), PrescriptionID, PhysicalList.Rows(l).Item("note"))
        'Next

        'For m = 0 To PrescriptionList.Rows.Count - 1
        '    DA_PrescriptionDetail.InsertPrescription(PrescriptionID, PrescriptionList.Rows(m).Item("medicineid"), PrescriptionList.Rows(m).Item("dosage"), PrescriptionList.Rows(m).Item("duration"))
        'Next

        ' ''Delete From Pre Table
        'ClearDataFromPreTable()
        'If MsgBox("The prescription has been made successfully. Do you want to preview it?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

        'End If

    End Sub

    Private Sub BtnEditComplaint_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnEditComplaint.Click
        If (Me.ComplaintList.RowCount > 0) Then
            Dim FrmComplaint As New Complaint(Me)
            FrmComplaint.lblaction.Text = 1
            FrmComplaint.cbocomplaint.SelectedValue = ComplaintList.CurrentRow.Cells("complaintid").Value
            FrmComplaint.txtdesc.Text = ComplaintList.CurrentRow.Cells("note").Value
            FrmComplaint.ShowDialog()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    'Load static data
    'Complaint in Prescription.
    Sub LoadComplaint()
        Dim ComplaintList As New DataTable
        ComplaintList = DA_Complaint.SelectComplaints
        Me.cbocomplaint.DataSource = ComplaintList
        Me.cbocomplaint.DisplayMember = ComplaintList.Columns("complaint").ColumnName
        Me.cbocomplaint.ValueMember = ComplaintList.Columns("complaintid").ColumnName
        Me.cbocomplaint.SelectedIndex = -1
    End Sub
    Sub LoadHistory()
        Dim HistoryList As New DataTable
        HistoryList = DA_History.SelectHistory
        Me.cbohistory.DataSource = HistoryList
        Me.cbohistory.DisplayMember = HistoryList.Columns("history").ColumnName
        Me.cbohistory.ValueMember = HistoryList.Columns("Historyid").ColumnName
        Me.cbohistory.SelectedIndex = -1
    End Sub
    Sub LoadPhysical()
        Dim PhysicalList As New DataTable
        PhysicalList = DA_Physical.SelectPhysical
        Me.cboexamination.DataSource = PhysicalList
        Me.cboexamination.DisplayMember = PhysicalList.Columns("physicalcheck").ColumnName
        Me.cboexamination.ValueMember = PhysicalList.Columns("physicalcheckid").ColumnName
        Me.cboexamination.SelectedIndex = -1
    End Sub
    Sub LoadPara()
        Dim ParaList As New DataTable
        ParaList = DA_Para.SelectPara
        Me.CboParaClinic.DataSource = ParaList
        Me.CboParaClinic.DisplayMember = ParaList.Columns("paracheck").ColumnName
        Me.CboParaClinic.ValueMember = ParaList.Columns("paracheckid").ColumnName
        Me.CboParaClinic.SelectedIndex = -1
    End Sub
    Sub LoadPrescription()
        Dim MedicineList As New DataTable
        MedicineList = DA_Medicine.SelectMedicine
        Me.cbomedicine.DataSource = MedicineList
        Me.cbomedicine.DisplayMember = MedicineList.Columns("medicinename").ColumnName
        Me.cbomedicine.ValueMember = MedicineList.Columns("medicineid").ColumnName
        Me.cbomedicine.SelectedIndex = -1
    End Sub

    Private Sub BtnAddPara_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAddPara.Click
        Dim ServiceCharge As Double
        Dim ParaTable As New DataTable
        ParaTable = DA_Para.SelectParaByID(CInt(Me.CboParaClinic.SelectedValue.ToString))
        ServiceCharge = CDbl(ParaTable.Rows(0).Item("servicecharge").ToString)
        DA_PrePara.InsertPara(Me.lblpatientId.Text, CInt(Me.CboParaClinic.SelectedValue.ToString), ServiceCharge, Me.txtparadesc.Text.ToString.Replace("'", "''"))
        MsgBox("One para clinic examination was added", MsgBoxStyle.Information, "Successfully Added")
        Me.txtparadesc.Text = ""
        Me.CboParaClinic.SelectedIndex = 0
        Me.RefreshPara()
    End Sub

    Private Sub BtnAddPrescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddPrescription.Click
        'DA_PrePrescription.InsertPrescription(Me.lblpatientId.Text, CInt(Me.cbomedicine.SelectedValue.ToString), Me.txtdosage.Text.ToString.Replace("'", "''"), Me.txtduration.Text.ToString.Replace("'", "''"))
        'MsgBox("One prescription was added", MsgBoxStyle.Information, "Successfully Added")
        'Me.txtdosage.Text = ""
        'Me.txtduration.Text = ""
        'Me.cbomedicine.SelectedIndex = 0
        'Me.RefreshPrescription()
    End Sub
End Class