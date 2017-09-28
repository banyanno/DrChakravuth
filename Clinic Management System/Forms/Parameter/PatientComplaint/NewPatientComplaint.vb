Public Class NewPatientComplaint
    Dim DA_Complaint As New DSPAtientTableAdapters.tblcomplaintTableAdapter
    Dim Complaint As MainParameter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal ComplaintPanel As MainParameter)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Complaint = ComplaintPanel
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub NewPatientComplaint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub ClearData()
        Me.TxtComplaintName.Text = ""
        Me.TxtComplaintName.Focus()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateTextField(Me.TxtComplaintName, "", Err) = False Then Exit Sub
        If Me.LblSaveOption.Text = 0 Then
            DA_Complaint.InsertComplaint(Me.TxtComplaintName.Text.Replace("'", "''"))
            MsgBox("One patient complaint was added", MsgBoxStyle.Information, "Successfully Added")
            Complaint.RefreshDataPatientComplaints()
            ClearData()
        Else
            If MsgBox("Are you sure you want to update this patient complaint?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DA_Complaint.UpdateComplaint(Me.TxtComplaintName.Text.Replace("'", "''"), Complaint.ComplaintList.CurrentRow.Cells("complaintid").Value)
                MsgBox("The patient complaint was updated", MsgBoxStyle.Information, "Successfully Updated")
                Complaint.RefreshDataPatientComplaints()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class