Public Class BloodCheck
    Dim DA_Patient As New DSPAtientTableAdapters.tblpatientTableAdapter
    Dim DA_Doctor As New DSPAtientTableAdapters.DoctorsTableAdapter
    Dim History As PrescriptionHistory
    Sub New(ByVal FrmPreHistory As PrescriptionHistory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.History = FrmPreHistory
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'If ValidateCombobox(cbodoctor, "", ErrBlood) = False Then Exit Sub
        'If ValidateDateTimePicker(dtdate, "", ErrBlood) = False Then Exit Sub
        'If MessageBox.Show("Do you want save new blood test?", "Blood", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
        '    Dim ObjCheck As New Check_Detail
        '    Dim ObjCheckResult As New Check_Result
        '    Dim ModelCheck As New ModelCheckBlood
        '    ObjCheck.Patient_ID = Me.txtPatientID.Text
        '    ObjCheck.prescriptionid = History.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value
        '    ObjCheck.User_Create = CInt(Me.cbodoctor.SelectedValue)
        '    ObjCheck.Check_Date = Me.dtdate.Value

        '    Dim DA_CheckBlood As New DSPAtientTableAdapters.Check_ItemsTableAdapter
        '    Dim CheckTable As New DataTable
        '    CheckTable = DA_CheckBlood.GetData
        '    If ModelCheck.InsertCheck(ObjCheck) = True Then
        '        Dim DA_Check As New DSPAtientTableAdapters.Check_DetailsTableAdapter
        '        Dim ConsultTable As New DataTable
        '        Dim CheckNo As New Integer
        '        CheckNo = DA_Check.GetMaxID

        '        Dim chkitem As New CheckBox
        '        Dim txtbox As New TextBox
        '        Dim itemname As String
        '        Dim itemID As Integer = 0
        '        For i As Integer = 0 To CheckTable.Rows.Count - 1
        '            itemID = itemID + 1
        '            itemname = "item" & itemID
        '            ObjCheckResult = New Check_Result
        '            ObjCheckResult.Check_No = CheckNo
        '            ObjCheckResult.Item_ID = CInt(CheckTable.Rows(i).Item("Item_ID"))
        '            If TypeOf Me.Controls(itemname) Is CheckBox Then
        '                chkitem = Me.Controls(itemname)
        '                ObjCheckResult.Checked = chkitem.Checked
        '            Else
        '                txtbox = Me.Controls(itemname)
        '                ObjCheckResult.Note = txtbox.Text.ToString.Replace("'", "''")
        '            End If

        '            If ModelCheck.InsertCheckResult(ObjCheckResult) = False Then
        '                MsgBox("Failed to add the record of blood test")
        '            End If
        '        Next
        '        MsgBox("One record of blood test was added")
        '    Else
        '        MsgBox("Fail to add the record of blood test")
        '    End If
        '    History.RowChanged()
        '    Me.Close()
        'End If
        
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BloodCheck_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim PatientData As New DataTable
        PatientData = DA_Patient.SelectPatientByID(Me.txtPatientID.Text)
        Me.lblname.Text = PatientData.Rows(0).Item("pname").ToString
        Me.lblage.Text = Year(Now) - Year(PatientData.Rows(0).Item("pAge"))
        Me.lblsex.Text = PatientData.Rows(0).Item("pgender").ToString
        Me.lblid.Text = PatientData.Rows(0).Item("patientid").ToString
        Me.lbladdress.Text = PatientData.Rows(0).Item("pcontactaddress").ToString
        Me.cbodoctor.DataSource = DA_Doctor.GetData
        Me.cbodoctor.DisplayMember = DA_Doctor.GetData.Columns("Doctor_Name").ColumnName
        Me.cbodoctor.SelectedIndex = -1
    End Sub
End Class