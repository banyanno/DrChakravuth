Public Class Edit_Patient_Symptom
    Dim DA_Symptom As New DSPAtientTableAdapters.SymptomsTableAdapter
    Dim DA_SymptomDetail As New DSPAtientTableAdapters.Patient_Symptom_DetailsTableAdapter
    Dim PatientInfo As PatientInformation
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        LoadSymptom()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Sub New(ByVal PatientPanel As PatientInformation)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.PatientInfo = PatientPanel
        LoadSymptom()
    End Sub
    Private Sub Edit_Patient_Symptom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub LoadSymptom()
        Me.cbosymptom.DataSource = DA_Symptom.GetData
        Me.cbosymptom.ValueMember = DA_Symptom.GetData.Columns("Symptom_ID").ColumnName
        Me.cbosymptom.DisplayMember = DA_Symptom.GetData.Columns("Symptom_Name").ColumnName
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        'If MsgBox("Are you sure you want to save changes?", MsgBoxStyle.YesNo, "Confirm Update") = MsgBoxResult.Yes Then
        '    DA_SymptomDetail.UpdateSymptom(CInt(Me.cbosymptom.SelectedValue), Me.txtdesc.Text.Replace("'", "''").ToString, PatientInfo.SymptomList.CurrentRow.Cells("Symptom_No").Value, PatientInfo.SymptomList.CurrentRow.Cells("Symptom_ID").Value)
        '    PatientInfo.RefreshSymptom()
        '    Me.Close()
        'End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class