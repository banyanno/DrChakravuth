Public Class Edit_Prescription
    Dim DA_Prescription As New DSPAtientTableAdapters.tblprescriptionTableAdapter
    Dim DA_Doctor As New DSPAtientTableAdapters.DoctorsTableAdapter
    Dim DA_Diagnosis As New DSPAtientTableAdapters.tbldiagnosisTableAdapter
    Dim DA_ConsultType As New DSPAtientTableAdapters.tblConsultTypeTableAdapter
    Dim History As PrescriptionHistory
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        LoadDataToComboBox()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal HistoryPanel As PrescriptionHistory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.History = HistoryPanel
        LoadDataToComboBox()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub LoadDataToComboBox()
        Me.cboconsulttype.DataSource = DA_ConsultType.SelectConsultationTypes
        Me.cboconsulttype.DisplayMember = DA_ConsultType.SelectConsultationTypes.Columns("consulttypename").ColumnName
        Me.cboconsulttype.ValueMember = DA_ConsultType.SelectConsultationTypes.Columns("consulttypeid").ColumnName

        Me.cbodoctor.DataSource = DA_Doctor.SelectDoctor
        Me.cbodoctor.DisplayMember = DA_Doctor.SelectDoctor.Columns("Doctor_Name").ColumnName
        Me.cbodoctor.ValueMember = DA_Doctor.SelectDoctor.Columns("Doctor_ID").ColumnName

        Me.cbodiagnosis.DataSource = DA_Diagnosis.SelectDiagnosis
        Me.cbodiagnosis.DisplayMember = DA_Diagnosis.SelectDiagnosis.Columns("diagnosis").ColumnName
        Me.cbodiagnosis.ValueMember = DA_Diagnosis.SelectDiagnosis.Columns("diagnosisid").ColumnName
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If MsgBox("Are you sure you want to update this prescription?", MsgBoxStyle.YesNo, "Confirm Update") = MsgBoxResult.Yes Then
            Dim ConsultPrice As Double
            ConsultPrice = DA_ConsultType.SelectConsultByID(CInt(Me.cboconsulttype.SelectedValue)).Rows(0).Item("price")
            DA_Prescription.UpdatePrescription(History.txtid.Text, CInt(Me.cbodoctor.SelectedValue.ToString), Me.cbodiagnosis.Text.Replace("'", "''").ToString, Me.cboconsulttype.Text.Replace("'", "''").ToString, ConsultPrice, Me.txtremark.Text.Replace("'", "''").ToString, History.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
            History.RefreshData()
            Me.Close()
        End If
    End Sub

    Private Sub EditPrescription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class