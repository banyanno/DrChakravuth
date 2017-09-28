Public Class Prescription
    Dim DA_Medicine As New DSPAtientTableAdapters.tblmedicineTableAdapter
    Dim DA_PrePrescription As New DSPAtientTableAdapters.tblpreprescriptionDetailTableAdapter
    Dim DA_PrescriptionDetail As New DSPAtientTableAdapters.tblprescriptionDetailTableAdapter
    Dim DA_Unit As New DSPAtientTableAdapters.tblunitTableAdapter
    Dim Prescription As NewPrescription
    Dim PreHistory As New PrescriptionHistory
    Sub New(ByVal FrmPreHistory As PrescriptionHistory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.PreHistory = FrmPreHistory
        LoadPrescription()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        LoadPrescription()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal PreFrm As NewPrescription)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Prescription = PreFrm
        ' Add any initialization after the InitializeComponent() call.
        LoadPrescription()
    End Sub
    Sub LoadPrescription()
        Dim MedicineList As New DataTable
        MedicineList = DA_Medicine.SelectMedicine
        Me.cbomedicine.DataSource = MedicineList
        Me.cbomedicine.DisplayMember = MedicineList.Columns("medicinename").ColumnName
        Me.cbomedicine.ValueMember = MedicineList.Columns("medicineid").ColumnName
    End Sub

    Private Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        'Dim Unit As New DataTable
        'Unit = DA_Unit.SelectUnitByMedicineID(CInt(Me.cbomedicine.SelectedValue.ToString))
        'Dim unitid As Integer = Unit.Rows(0).Item("unitId")
        'If Me.lbloldprescription.Text = 0 Then
        '    If lblaction.Text = 0 Then
        '        DA_PrePrescription.InsertPrescription(Prescription.lblpatientId.Text, CInt(Me.cbomedicine.SelectedValue.ToString), Me.txtdosage.Text.ToString.Replace("'", "''"), Me.txtduration.Text.ToString.Replace("'", "''"))
        '        MsgBox("One prescription was added", MsgBoxStyle.Information, "Successfully Added")
        '        Me.txtdosage.Text = ""
        '        Me.txtduration.Text = ""
        '        Me.cbomedicine.SelectedIndex = 0
        '        Prescription.RefreshPrescription()
        '    Else
        '        If MsgBox("Are you sure you want to update this prescription?", MsgBoxStyle.YesNo, "Confirm Update") = MsgBoxResult.Yes Then
        '            DA_PrePrescription.UpdatePrescription(Prescription.lblpatientId.Text, CInt(Me.cbomedicine.SelectedValue.ToString), Me.txtdosage.Text.ToString.Replace("'", "''"), Me.txtduration.Text.ToString.Replace("'", "''"), Prescription.PrescriptionList.CurrentRow.Cells("preid").Value)
        '            MsgBox("The prescription was updated", MsgBoxStyle.Information, "Successfully Updated")
        '            Prescription.RefreshPrescription()
        '            Me.Close()
        '        End If
        '    End If
        'Else
        '    If lblaction.Text = 0 Then
        '        DA_PrescriptionDetail.InsertPrescription(PreHistory.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value, CInt(Me.cbomedicine.SelectedValue.ToString), Me.txtdosage.Text.ToString.Replace("'", "''"), Me.txtduration.Text.ToString.Replace("'", "''"))
        '        MsgBox("One prescription was added", MsgBoxStyle.Information, "Successfully Added")
        '        Me.txtdosage.Text = ""
        '        Me.txtduration.Text = ""
        '        Me.cbomedicine.SelectedIndex = 0
        '        PreHistory.RefreshPrescription()
        '    Else
        '        If MsgBox("Are you sure you want to update this prescription?", MsgBoxStyle.YesNo, "Confirm Update") = MsgBoxResult.Yes Then
        '            DA_PrescriptionDetail.UpdatePrescription(PreHistory.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value, CInt(Me.cbomedicine.SelectedValue.ToString), Me.txtdosage.Text.ToString.Replace("'", "''"), Me.txtduration.Text.ToString.Replace("'", "''"), PreHistory.PrescriptionList.CurrentRow.Cells("prescriptiondetailid").Value)
        '            MsgBox("The prescription was updated", MsgBoxStyle.Information, "Successfully Updated")
        '            PreHistory.RefreshPrescription()
        '            Me.Close()
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class