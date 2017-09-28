Public Class NewInvoice
    Dim DA_Order As New DSPAtientTableAdapters.tblOrderMedicineTableAdapter
    Dim DA_InvoicePara As New DSPAtientTableAdapters.tblInvParaClinicTableAdapter
    Dim DA_InvoicePrescription As New DSPAtientTableAdapters.tblInvPrescriptionTableAdapter
    Dim DA_Invoice As New DSPAtientTableAdapters.tblInvoiceTableAdapter
    Dim DA_MedicineOrder As New DSPAtientTableAdapters.tblOrderMedicineTableAdapter

    Dim DA_Mediciine As New DSPAtientTableAdapters.tblmedicineTableAdapter
    Dim DA_Patient As New DSPAtientTableAdapters.tblpatientTableAdapter
    Dim DA_PrescriptionDetail As New DSPAtientTableAdapters.tblprescriptionDetailTableAdapter
    Dim DA_ParaDetail As New DSPAtientTableAdapters.tblparacheckdetailTableAdapter
    Dim DA_Unit As New DSPAtientTableAdapters.tblunitTableAdapter
    Dim DA_PreOrder As New DSPAtientTableAdapters.tblpreordermedicineTableAdapter
    Dim History As PrescriptionHistory
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Sub New(ByVal HistoryPanel As PrescriptionHistory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.History = HistoryPanel
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Sub RefreshOrderList()
        Me.OrderList.DataSource = DA_PreOrder.SelectOrder
    End Sub
    Private Sub NewInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MaxInvoiceNo As Integer
        Dim MaxTable As New DataTable
        Dim TestTable As New DataTable
        MaxTable = DA_Invoice.SelectMaxInvoiceNo
        If MaxTable.Rows(0).Item("InvoiceNo").ToString = "" Then
            MaxInvoiceNo = 1
        Else
            MaxInvoiceNo = MaxTable.Rows(0).Item("InvoiceNo") + 1
        End If
        Me.txtinvoiceno.Text = Format(MaxInvoiceNo, "000000")

        Dim Patient As New DataTable
        Patient = DA_Patient.SelectPatientByPID(History.lblpatientId.Text)
        Me.txtid.Text = Patient.Rows(0).Item("patientid").ToString
        Me.txtname.Text = Patient.Rows(0).Item("pname").ToString
        Me.txtsex.Text = Patient.Rows(0).Item("pgender").ToString
        Me.txtage.Text = Year(Now) - Year(Patient.Rows(0).Item("pAge")).ToString
        ''RefreshData()
        Me.ParaList.DataSource = DA_ParaDetail.SelectParaByPrescriptionID(History.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
        Me.PrescriptionList.DataSource = DA_PrescriptionDetail.SelectPrescriptionByPrescriptionID(History.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
        DA_PreOrder.DeleteOrder()

    End Sub

    Private Sub BtnAddOrder_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnAddOrder.Click
        Dim Order As New MedicineOrder(Me)
        Order.lblaction.Text = 0
        Order.ShowDialog()
        Order.Dispose()
    End Sub

    Private Sub BtnDeleteOrder_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnDeleteOrder.Click
        If MsgBox("Are you sure you want to delete this order?", MsgBoxStyle.YesNo, "Confirm Delete") Then
            DA_PreOrder.DeleteOrderByID(Me.OrderList.CurrentRow.Cells("preid").Value)
            RefreshOrderList()
        End If
    End Sub

    Private Sub OrderList_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles OrderList.FormattingRow

    End Sub
    Sub CalculateTotal()
        Dim TotalDollar As Double = 0
        Dim TotalRiels As Double = 0
        Dim TotalOrderPrice As Double = 0
        Dim ConsultPrice As Double = CDbl(Me.txtconsultfee.Text)
        Dim TotalParaPrice As Double = CDbl(Me.txtparacharge.Text)
        Dim Discount As Double = CDbl(Me.txtdiscount.Text)
        Dim ExchangeRate As Double = CDbl(Me.txtexchangerate.Text)

        Dim OrderTable As New DataTable
        OrderTable = DA_PreOrder.SelectOrder
        For i = 0 To OrderTable.Rows.Count - 1
            TotalOrderPrice = TotalOrderPrice + CDbl(OrderTable.Rows(i).Item("amount"))
        Next

        TotalDollar = ConsultPrice + TotalParaPrice + TotalOrderPrice - Discount
        TotalRiels = TotalDollar * ExchangeRate
        Me.txtdollar.Text = Format(TotalDollar, "#,###.00")
        Me.txtriel.Text = Format(TotalRiels, "#,###.00")
    End Sub
    Private Sub OrderList_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OrderList.RowCountChanged
        CalculateTotal()
    End Sub

    Private Sub txtdiscount_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdiscount.Leave
        If Me.txtdiscount.Text = "" Then
            Me.txtdiscount.Text = 0
            Me.txtdiscount.Focus()
        End If
        If IsNumeric(Me.txtdiscount.Text) = False Then
            MsgBox("Discount must be number only")
            Me.txtdiscount.Text = 0
            Me.txtdiscount.Focus()
        End If
        CalculateTotal()
    End Sub

    Private Sub txtdiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdiscount.TextChanged

    End Sub

    Private Sub txtexchangerate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtexchangerate.Leave
        If Me.txtexchangerate.Text = "" Then
            Me.txtexchangerate.Text = 0
            Me.txtexchangerate.Focus()
        End If
        If IsNumeric(Me.txtexchangerate.Text) = False Then
            MsgBox("Exchange rate must be number only")
            Me.txtexchangerate.Text = 4000
            Me.txtexchangerate.Focus()
        End If
        CalculateTotal()
    End Sub



   
    Private Sub ToolSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolSave.Click
        If ValidateDateTimePicker(DtInvoiceDate, "", Err) = False Then Exit Sub

        ''INSERT INVOICE
        DA_Invoice.InsertInvoice(History.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value, Me.txtinvoiceno.Text, FormatDateTime(Me.DtInvoiceDate.Value, DateFormat.ShortDate), History.PrescriptionHistoryList.CurrentRow.Cells("doctorid").Value, History.lblpatientId.Text, History.PrescriptionHistoryList.CurrentRow.Cells("Diagnosis").Value.ToString.Replace("'", "''"), Me.txtconsulttype.Text.Replace("'", "''"), Me.txtconsultfee.Text, Me.txtdiscount.Text, Me.txtexchangerate.Text)

        ''INSERT PARA CLINIC EXAM
        Dim InvoiceID As Long
        Dim InvoiceTable As DataTable
        Dim ParaTable As New DataTable

        InvoiceTable = DA_Invoice.SelectInvoiceByNo(Me.txtinvoiceno.Text)
        InvoiceID = InvoiceTable.Rows(0).Item("invoiceid")
        ParaTable = DA_ParaDetail.SelectParaByPrescriptionID(History.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
        For i As Integer = 0 To ParaTable.Rows.Count - 1
            DA_InvoicePara.InsertPara(InvoiceID, ParaTable.Rows(i).Item("paracheckid"), ParaTable.Rows(i).Item("servicecharge"))
        Next

        ''INSERT PRESCRIPTION
        Dim PrescriptionTable As New DataTable
        PrescriptionTable = DA_PrescriptionDetail.SelectPrescriptionByPrescriptionID(History.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
        For j As Integer = 0 To PrescriptionTable.Rows.Count - 1
            DA_InvoicePrescription.InsertPrescription(InvoiceID, PrescriptionTable.Rows(j).Item("medicineid"), PrescriptionTable.Rows(j).Item("dosage"), PrescriptionTable.Rows(j).Item("duration"))
        Next

        ''INSERT MEDICINE ORDER
        Dim PreOrderTable As New DataTable
        PreOrderTable = DA_PreOrder.SelectOrder
        For x As Integer = 0 To PreOrderTable.Rows.Count - 1
            DA_MedicineOrder.InsertOrder(PreOrderTable.Rows(x).Item("medicineid"), PreOrderTable.Rows(x).Item("funitid"), InvoiceID, History.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value, PreOrderTable.Rows(x).Item("orderQty"), PreOrderTable.Rows(x).Item("Unitprice"))
        Next
        ''CLEAR PREORDER TABLE DATA
        DA_PreOrder.DeleteOrder()

        MsgBox("Invoice has been made successfully")

        Dim DA_RptInvoice As New DS_InvoiceTableAdapters.tblInvoiceTableAdapter
        Dim DA_RptPara As New DS_InvoiceTableAdapters.tblInvoiceParaTableAdapter
        Dim DA_RptMedicine As New DS_InvoiceTableAdapters.tblMedicineOrderTableAdapter
        Dim DA_Patient As New DS_PrescriptionTableAdapters.tblpatientTableAdapter
        Dim DA_Doctor As New DSPAtientTableAdapters.DoctorsTableAdapter


        Dim RptOrdinance As New RptOrdinance
        Dim InvoiceViewer As New FormReportViewer
        Dim OrdinanceViewer As New FormReportViewer

        Dim RptPatientTable As New DataTable
        Dim RptInvoiceTable As New DataTable
        Dim RptParaTable As New DataTable
        Dim RptMedicineTable As New DataTable
        Dim RptDoctorTable As New DataTable

        RptPatientTable = DA_Patient.SelectPatient(History.lblpatientId.Text)
        RptInvoiceTable = DA_RptInvoice.SelectInvoiceByID(InvoiceID)
        RptParaTable = DA_RptPara.SelectParaByInvoiceID(InvoiceID)
        RptMedicineTable = DA_RptMedicine.SelectMedicineOrderByInvoiceID(InvoiceID)
        RptDoctorTable = DA_Doctor.SelectDoctorByID(History.PrescriptionHistoryList.CurrentRow.Cells("doctorid").Value)

        
        InvoiceViewer.ShowDialog()

        If Me.PrescriptionList.RowCount > 0 Then
            Dim RptOrdinanceTable As New DataTable
            Dim DA_Ordinance As New DS_InvoiceTableAdapters.tblPrescriptionTableAdapter
            RptOrdinanceTable = DA_Ordinance.SelectPrescriptionByID(History.PrescriptionHistoryList.CurrentRow.Cells("prescriptionid").Value)
            RptOrdinance.Database.Tables("tblPrescription").SetDataSource(RptOrdinanceTable)
            RptOrdinance.Database.Tables("tblpatient").SetDataSource(RptPatientTable)
            RptOrdinance.SetParameterValue("Doctor", RptDoctorTable.Rows(0).Item("Doctor_Name"))
            RptOrdinance.SetParameterValue("Diagnosis", RptInvoiceTable.Rows(0).Item("invDiagnosis"))
            OrdinanceViewer.CVForm.ReportSource = RptOrdinance
            OrdinanceViewer.ShowDialog()
        End If
        OrdinanceViewer.Dispose()
        InvoiceViewer.Dispose()
        Me.Close()
    End Sub

    Private Sub ToolCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolCancel.Click
        Me.Close()
    End Sub
End Class