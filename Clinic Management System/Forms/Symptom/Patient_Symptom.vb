Public Class Patient_Symptom
    Dim DA_Symptom As New DSPAtientTableAdapters.SymptomsTableAdapter
    Dim DA_PreSymptom As New DSPAtientTableAdapters.Pre_Patient_SymptomsTableAdapter
    Dim PatientInfo As PatientInformation
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Sub New(ByVal PatientPanel As PatientInformation)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.PatientInfo = PatientPanel
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        If Me.txtPatientID.Text <> "" Then
            DA_PreSymptom.DeleteSymptomByPatientID(Me.txtPatientID.Text)
        End If
        Me.Close()
    End Sub

    Private Sub Patient_Symptom_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SymptomList.DataSource = DA_PreSymptom.GetDataByPatient(Me.txtPatientID.Text)
        Me.cbosymptom.DataSource = DA_Symptom.GetData
        Me.cbosymptom.ValueMember = DA_Symptom.GetData.Columns("Symptom_ID").ColumnName
        Me.cbosymptom.DisplayMember = DA_Symptom.GetData.Columns("Symptom_Name").ColumnName
        Me.cbosymptom.SelectedIndex = -1
        Me.txtdesc.Text = ""
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If ValidateCombobox(cbosymptom, "", ErrSymptom) = False Then Exit Sub
        If ValidateTextField(txtdesc, "", ErrSymptom) = False Then Exit Sub
        If (DA_PreSymptom.GetDataByPatientAndSymptom(Me.txtPatientID.Text, cbosymptom.SelectedValue).Rows.Count > 0) Then
            MsgBox("This symptom has been added already, please choose another one", MsgBoxStyle.Exclamation)
        Else
            DA_PreSymptom.InsertSymptom(Me.txtPatientID.Text, cbosymptom.SelectedValue.ToString.Replace("'", "''"), Me.txtdesc.Text.Replace("'", "''"))
            SymptomList.DataSource = DA_PreSymptom.GetDataByPatient(Me.txtPatientID.Text)
            Me.txtdesc.Text = ""
        End If
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        DA_PreSymptom.DeleteSymptom(Me.SymptomList.CurrentRow.Cells(0).Value)
        SymptomList.DataSource = DA_PreSymptom.GetDataByPatient(Me.txtPatientID.Text)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If ValidateDateTimePicker(DateSymptom, "", ErrSymptom) = False Then Exit Sub
        Dim DA_PSymptom As New DSPAtientTableAdapters.Patient_SymptomsTableAdapter
        Dim DA_SymptomDetail As New DSPAtientTableAdapters.Patient_Symptom_DetailsTableAdapter
        If (SymptomList.RowCount <= 0) Then
            MsgBox("No symptom records to save,please add symptom first.", MsgBoxStyle.Exclamation)
        Else
            If (MsgBox("Are you sure you want to save the symptom records?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                Dim DA_Consult As New DSPAtientTableAdapters.ConsultationsTableAdapter
                Dim Consult As New DataTable
                Consult = DA_Consult.GetConsultation(Me.txtPatientID.Text)
                'If Consult.Rows.Count > 0 Then
                'MsgBox("This patient was send to consult with doctor already", MsgBoxStyle.Exclamation)
                'Else
                ''INSERT Symptom Info
                DA_PSymptom.InsertSymptom(Me.txtPatientID.Text, DateSymptom.Value)
                ''Get Max SymptomNo
                Dim SymptomNo As Integer = DA_PSymptom.GetMaxNo
                ''INSERT Symptom Details
                Dim PreList As New DataTable
                PreList = DA_PreSymptom.GetDataByPatient(Me.txtPatientID.Text)
                For i = 0 To PreList.Rows.Count - 1
                    DA_SymptomDetail.InsertSymptom(SymptomNo, PreList.Rows(i).Item("Symptom_ID"), PreList.Rows(i).Item("Description").ToString.Replace("'", "''"))
                Next
                DA_PreSymptom.DeleteSymptomByPatientID(Me.txtPatientID.Text)

                'Dim ObjCon As New Consultation
                'Dim PModel As New ModelPatient
                'ObjCon.Patient_ID = Me.txtPatientID.Text
                'ObjCon.Status = 1
                'If PModel.InsertConsultation(ObjCon) = True Then
                '    MsgBox("One patient was sent to consult with doctor", MsgBoxStyle.Information)
                'Else
                '    MsgBox("Failed to send patient to consult with doctor", MsgBoxStyle.Exclamation)
                'End If
                Me.Close()
                'End If
            End If
            'PatientInfo.RefreshSymptom()
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class