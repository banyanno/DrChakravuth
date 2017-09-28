Public Class Complaint
    Dim DA_ComplaintDetail As New DSComplaintTableAdapters.tblcomplaintdetailTableAdapter
    Dim DA_Complaint As New DSPAtientTableAdapters.tblcomplaintTableAdapter
    Dim Prescription As NewPrescription
    Dim PreHistory As New PrescriptionHistory
    Sub New(ByVal FrmPreHistory As PrescriptionHistory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.PreHistory = FrmPreHistory
        LoadComplaint()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        LoadComplaint()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal PreFrm As NewPrescription)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Prescription = PreFrm
        LoadComplaint()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub LoadComplaint()
        '    Dim ComplaintList As New DataTable
        '    ComplaintList = DA_Complaint.SelectComplaints
        '    Me.cbocomplaint.DataSource = ComplaintList
        '    Me.cbocomplaint.DisplayMember = ComplaintList.Columns("complaint").ColumnName
        '    Me.cbocomplaint.ValueMember = ComplaintList.Columns("complaintid").ColumnName
        'End Sub
        'Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        '    Me.Close()
    End Sub

    'Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
    '    If Me.lbloldprescription.Text = 0 Then
    '        If lblaction.Text = 0 Then
    '            DA_PreComplaint.InsertComplaint(Prescription.lblpatientId.Text, CInt(Me.cbocomplaint.SelectedValue.ToString), Me.txtdesc.Text.ToString.Replace("'", "''"))
    '            MsgBox("One patient complaint was added", MsgBoxStyle.Information, "Successfully Added")
    '            Me.txtdesc.Text = ""
    '            Me.cbocomplaint.SelectedIndex = 0
    '            Prescription.RefreshComplaint()
    '        Else
    '            If MsgBox("Are you sure you want to update this patient complaint?", MsgBoxStyle.YesNo, "Confirm Update") = MsgBoxResult.Yes Then
    '                DA_PreComplaint.UpdateComplaint(Prescription.lblpatientId.Text, CInt(Me.cbocomplaint.SelectedValue.ToString), Me.txtdesc.Text.ToString.Replace("'", "''"), Prescription.ComplaintList.CurrentRow.Cells("preid").Value)
    '                MsgBox("The patient complaint was updated", MsgBoxStyle.Information, "Successfully Updated")
    '                Prescription.RefreshComplaint()
    '                Me.Close()
    '            End If
    '        End If
    '    Else
    '        If lblaction.Text = 0 Then
    '            DA_ComplaintDetail.InsertComplaint(CInt(Me.cbocomplaint.SelectedValue.ToString), PreHistory.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value, Me.txtdesc.Text.ToString.Replace("'", "''"))
    '            MsgBox("One patient complaint was added", MsgBoxStyle.Information, "Successfully Added")
    '            Me.txtdesc.Text = ""
    '            Me.cbocomplaint.SelectedIndex = 0
    '            PreHistory.RefreshComplaint()
    '        Else
    '            If MsgBox("Are you sure you want to update this patient complaint?", MsgBoxStyle.YesNo, "Confirm Update") = MsgBoxResult.Yes Then
    '                DA_ComplaintDetail.UpdateComplaint(CInt(Me.cbocomplaint.SelectedValue.ToString), PreHistory.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value, Me.txtdesc.Text.ToString.Replace("'", "''"), PreHistory.ComplaintList.CurrentRow.Cells("complaintdetailid").Value)
    '                MsgBox("The patient complaint was updated", MsgBoxStyle.Information, "Successfully Updated")
    '                PreHistory.RefreshComplaint()
    '                Me.Close()
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub Complaint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class