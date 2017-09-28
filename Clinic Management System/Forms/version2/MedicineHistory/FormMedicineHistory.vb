Public Class FormMedicineHistory
    Dim Patient As New SymptomInformation
    Dim DA_Medicine As New DSPAtientTableAdapters.tblmedicineTableAdapter
    Dim DA_MedicineHistory As New DSPAtientTableAdapters.tblmedicinehistoryTableAdapter
    Dim UPatientInfo As PatientInformation
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        LoadMedicine()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal PatientInforPanel As PatientInformation)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.UPatientInfo = PatientInforPanel
        LoadMedicine()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub LoadMedicine()
        Me.cbomedicine.DataSource = DA_Medicine.SelectMedicine
        Me.cbomedicine.ValueMember = DA_Medicine.SelectMedicine.Columns("medicineid").ColumnName
        Me.cbomedicine.DisplayMember = DA_Medicine.SelectMedicine.Columns("medicinename").ColumnName
    End Sub
    Private Sub FormMedicineHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        'If Me.lblaction.Text = 0 Then
        '    ''Add New
        '    If DA_MedicineHistory.InsertHistory(CLng(Me.UPatientInfo.GridPatientInfo.CurrentRow.Cells("ppatientid").Value), CInt(Me.cbomedicine.SelectedValue), Me.txtdesc.Text.Replace("'", "''").ToString) = 1 Then
        '        MsgBox("One medicine history was added", MsgBoxStyle.OkOnly, "History Added")
        '    End If
        'Else
        '    ''Update
        '    If DA_MedicineHistory.UpdateHistory(CLng(Me.UPatientInfo.GridPatientInfo.CurrentRow.Cells("ppatientid").Value), CInt(Me.cbomedicine.SelectedValue), Me.txtdesc.Text.Replace("'", "''").ToString, CLng(Me.UPatientInfo.GridHistoryList.CurrentRow.Cells("history_id").Value)) = 1 Then
        '        MsgBox("The medicine history was updated", MsgBoxStyle.OkOnly, "History Updated")
        '    End If
        'End If
        'Me.Close()
        'Me.UPatientInfo.RefreshHistory()
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class