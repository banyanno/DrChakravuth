Public Class History
    Dim DA_History As New DSPAtientTableAdapters.tblhistoryTableAdapter
    Dim DA_HistoryDetail As New DSMedicalHistoryTableAdapters.tblhistorydetailTableAdapter
    Dim Prescription As NewPrescription
    Dim PreHistory As New PrescriptionHistory
    Sub New(ByVal FrmPreHistory As PrescriptionHistory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.PreHistory = FrmPreHistory
        LoadHistory()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadHistory()
    End Sub
    Sub New(ByVal PreFrm As NewPrescription)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Prescription = PreFrm
        ' Add any initialization after the InitializeComponent() call.
        LoadHistory()
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Sub LoadHistory()
        Dim HistoryList As New DataTable
        HistoryList = DA_History.SelectHistory
        Me.cbohistory.DataSource = HistoryList
        Me.cbohistory.DisplayMember = HistoryList.Columns("history").ColumnName
        Me.cbohistory.ValueMember = HistoryList.Columns("Historyid").ColumnName
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        'If lbloldprescription.Text = 0 Then
        '    If lblaction.Text = 0 Then
        '        DA_PreHistory.InsertHistory(Prescription.lblpatientId.Text, CInt(Me.cbohistory.SelectedValue.ToString), Me.txtdesc.Text.ToString.Replace("'", "''"))
        '        MsgBox("One medical history was added", MsgBoxStyle.Information, "Successfully Added")
        '        Me.txtdesc.Text = ""
        '        Me.cbohistory.SelectedIndex = 0
        '        Prescription.RefreshHistory()
        '    Else
        '        If MsgBox("Are you sure you want to update this medical history?", MsgBoxStyle.YesNo, "Confirm Update") = MsgBoxResult.Yes Then
        '            DA_PreHistory.UpdateHistory(Prescription.lblpatientId.Text, CInt(Me.cbohistory.SelectedValue.ToString), Me.txtdesc.Text.ToString.Replace("'", "''"), Prescription.HistoryList.CurrentRow.Cells("preid").Value)
        '            MsgBox("The medical history was updated", MsgBoxStyle.Information, "Successfully Updated")
        '            Prescription.RefreshHistory()
        '            Me.Close()
        '        End If
        '    End If
        'Else
        '    If lblaction.Text = 0 Then
        '        DA_HistoryDetail.InsertHistory(CInt(Me.cbohistory.SelectedValue.ToString), PreHistory.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value, Me.txtdesc.Text.ToString.Replace("'", "''"))
        '        MsgBox("One medical history was added", MsgBoxStyle.Information, "Successfully Added")
        '        Me.txtdesc.Text = ""
        '        Me.cbohistory.SelectedIndex = 0
        '        PreHistory.RefreshHistory()
        '    Else
        '        If MsgBox("Are you sure you want to update this medical history?", MsgBoxStyle.YesNo, "Confirm Update") = MsgBoxResult.Yes Then
        '            DA_HistoryDetail.UpdateHistory(CInt(Me.cbohistory.SelectedValue.ToString), PreHistory.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value, Me.txtdesc.Text.ToString.Replace("'", "''"), PreHistory.HistoryList.CurrentRow.Cells("historydetailid").Value)
        '            MsgBox("The medical history was updated", MsgBoxStyle.Information, "Successfully Updated")
        '            PreHistory.RefreshHistory()
        '            Me.Close()
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub History_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class