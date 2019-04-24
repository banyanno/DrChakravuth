Public Class Physical
    Dim DA_Physical As New DSPAtientTableAdapters.tblPhysicalCheckTableAdapter
    Dim DA_PhysicalExam As New DSExaminationTableAdapters.tblphysicalexamTableAdapter
    Dim Prescription As NewPrescription
    Dim RequestPanel As DashbordDotorRequestExamination
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        LoadPhysical()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal PanelRequest As DashbordDotorRequestExamination)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.RequestPanel = PanelRequest
        LoadPhysical()
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Sub LoadPhysical()
        Dim PhysicalList As New DataTable
        PhysicalList = DA_Physical.SelectPhysical
        Me.cboexamination.DataSource = PhysicalList
        Me.cboexamination.DisplayMember = PhysicalList.Columns("physicalcheck").ColumnName
        Me.cboexamination.ValueMember = PhysicalList.Columns("physicalcheckid").ColumnName
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If lblaction.Text = 0 Then
            If DA_PhysicalExam.SelectExisting(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value), CInt(Me.cboexamination.SelectedValue.ToString)).Rows.Count >= 1 Then
                MsgBox("This physical exam was added already", MsgBoxStyle.Exclamation, "Existing Exam")
            Else
                If DA_PhysicalExam.InsertExam(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("request_id").Value), CInt(Me.cboexamination.SelectedValue.ToString), Me.txtdesc.Text.ToString.Replace("'", "''")) = 1 Then
                    MsgBox("One physical exam was added", MsgBoxStyle.Information, "Physical Exam Added")
                    ' Me.RequestPanel.LoadPhysicalExam()
                    Me.Close()
                End If
            End If
        Else
            If MsgBox("Are you sure you want to update this physical exam?", MsgBoxStyle.YesNo, "Confirm Update") = MsgBoxResult.Yes Then
                'If DA_PhysicalExam.UpdateExam(CLng(Me.RequestPanel.RequestList.CurrentRow.Cells("request_id").Value), CInt(Me.cboexamination.SelectedValue.ToString), Me.txtdesc.Text.ToString.Replace("'", "''"), CLng(Me.RequestPanel.PhysicalList.CurrentRow.Cells("exam_id").Value)) = 1 Then
                '    MsgBox("The physical exam was updated", MsgBoxStyle.Information, "Physical Exam Updated")
                '    ' Me.RequestPanel.LoadPhysicalExam()
                '    Me.Close()
                'End If
            End If
        End If
    End Sub
End Class