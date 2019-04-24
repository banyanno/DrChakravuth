Public Class ParaExam
    Dim DA_Para As New DSPAtientTableAdapters.tblparacheckTableAdapter
    Dim DA_PrePara As New DSInvoiceTableAdapters.tbl_preinvoice_paraexamTableAdapter
    Dim DA_Request As New DSExaminationTableAdapters.tblrequestTableAdapter
    Dim DA_PreInvoice As New DSInvoiceTableAdapters.tbl_preinvoiceTableAdapter
    Dim RequestPanel As DashbordDotorRequestExamination

    Sub New(ByVal PanelRequest As DashbordDotorRequestExamination)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.RequestPanel = PanelRequest
        LoadPara()
    End Sub
    Sub LoadPara()
        Dim ParaList As New DataTable
        ParaList = DA_Para.SelectPara
        Me.cboexamination.DataSource = ParaList
        Me.cboexamination.DisplayMember = ParaList.Columns("paracheck").ColumnName
        Me.cboexamination.ValueMember = ParaList.Columns("paracheckid").ColumnName
        cboexamination.SelectedIndex = -1
    End Sub
    Private Sub BtnFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFinish.Click
        If RequestPanel.gridRequestList.SelectedItems.Count = 0 Then Exit Sub
        If MsgBox("Are you sure that the para examination was completed?", MsgBoxStyle.YesNo, "Confirm Completion") = MsgBoxResult.Yes Then
            If DA_PreInvoice.SelectByPatientID(CLng(RequestPanel.gridRequestList.GetRow.Cells("ppatientid").Value)).Rows.Count < 1 Then
                DA_PreInvoice.InsertInvoice(CLng(RequestPanel.gridRequestList.GetRow.Cells("ppatientid").Value), USER_ID, SHOW_NAME)
            End If
            DA_Request.UpdateStatus(0, CLng(RequestPanel.gridRequestList.GetRow.Cells("request_id").Value))
            RequestPanel.gridRequestList.DataSource = DA_Request.SelectStatus(1)
            Me.Close()
        End If
    End Sub
    Sub RefreshParaList()
        Me.ParaList.DataSource = DA_PrePara.SelectParaByPatientID(CLng(Me.RequestPanel.gridRequestList.CurrentRow.Cells("ppatientid").Value))

    End Sub
    Private Sub BtnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim ServiceCharge As Double
        Dim ParaType As String
        Dim ParaTable As New DataTable
        ParaTable = DA_Para.SelectParaByID(CInt(Me.cboexamination.SelectedValue.ToString))
        ServiceCharge = CDbl(ParaTable.Rows(0).Item("servicecharge").ToString)
        ParaType = ParaTable.Rows(0).Item("ParaType").ToString
        DA_PrePara.InsertParaExam(CLng(Me.RequestPanel.gridRequestList.GetRow.Cells("ppatientid").Value), CInt(Me.cboexamination.SelectedValue), ServiceCharge, ParaType)
        RefreshParaList()
        cboexamination.SelectedIndex = -1
    End Sub

    Private Sub BtnRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnRemove.Click
        If Me.ParaList.RowCount >= 1 Then
            DA_PrePara.DeleteParaExam(CLng(Me.ParaList.CurrentRow.Cells("pre_id").Value))
            RefreshParaList()
        End If
    End Sub

  
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class