Public Class InvoiceParaExam
    Dim DA_PrePara As New DSInvoiceTableAdapters.tbl_preinvoice_paraexamTableAdapter
    Dim DA_Para As New DSPAtientTableAdapters.tblparacheckTableAdapter
    Dim Invoice As UPatientIssueReceipt
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadPara()
    End Sub
    Sub New(ByVal InvoicePanel As UPatientIssueReceipt)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Invoice = InvoicePanel
        ' Add any initialization after the InitializeComponent() call.
        LoadPara()
    End Sub
    Sub LoadPara()
        Dim ParaList As DataTable = DA_Para.SelectPara
        Me.cboexamination.DataSource = ParaList
        Me.cboexamination.DisplayMember = ParaList.Columns("paracheck").ColumnName
        Me.cboexamination.ValueMember = ParaList.Columns("paracheckid").ColumnName
        cboexamination.SelectedIndex = -1
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            Dim ServiceCharge As Double
            Dim ParaType As String
            Dim ParaTable As New DataTable
            ParaTable = DA_Para.SelectParaByID(CInt(Me.cboexamination.SelectedValue.ToString))
            ServiceCharge = CDbl(ParaTable.Rows(0).Item("servicecharge").ToString)
            ParaType = ParaTable.Rows(0).Item("ParaType").ToString
            DA_PrePara.InsertParaExam(CLng(Me.Invoice.InvoiceList.GetRow.Cells("patientno").Value), CInt(Me.cboexamination.SelectedValue), ServiceCharge, ParaType)
            RefreshPara()
            cboexamination.Text = ""
            cboexamination.SelectedIndex = -1
            cboexamination.Focus()
            cboexamination.Select()
        Catch ex As Exception

        End Try
      
    End Sub
    Private Sub RefreshPara()
        Me.Invoice.ParaList.DataSource = DA_PrePara.SelectParaByPatientID(CLng(Me.Invoice.InvoiceList.CurrentRow.Cells("patientno").Value))
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

   
   
 

End Class