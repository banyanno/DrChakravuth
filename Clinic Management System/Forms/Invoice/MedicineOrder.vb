Public Class MedicineOrder
    Dim DA_Medicine As New DSPAtientTableAdapters.tblmedicineTableAdapter
    Dim DA_Patient As New DSPAtientTableAdapters.tblpatientTableAdapter
    Dim DA_PrescriptionDetail As New DSPAtientTableAdapters.tblprescriptionDetailTableAdapter
    Dim DA_ParaDetail As New DSPAtientTableAdapters.tblparacheckdetailTableAdapter
    Dim DA_Unit As New DSPAtientTableAdapters.tblunitTableAdapter
    Dim DA_PreOrder As New DSPAtientTableAdapters.tblpreordermedicineTableAdapter
    Dim Invoice As NewInvoice
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadMedicineToBox()
    End Sub
    Sub New(ByVal InvoicePanel As NewInvoice)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Invoice = InvoicePanel
        ' Add any initialization after the InitializeComponent() call.
        LoadMedicineToBox()
    End Sub
    Sub LoadMedicineToBox()

        Me.cbomedicine.DataSource = DA_Medicine.SelectMedicine()
        Me.cbomedicine.ValueMember = DA_Medicine.SelectMedicine.Columns("medicineid").ColumnName
        Me.cbomedicine.DisplayMember = DA_Medicine.SelectMedicine.Columns("medicinename").ColumnName
    End Sub
    Private Sub MedicineOrdervb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(txtqty, "", ErrValidate) = False Then Exit Sub
        If IsNumeric(Me.txtqty.Text) = False Then
            MsgBox("Quantity must be number only", MsgBoxStyle.Information, "Invalid Value")
            Me.txtqty.Text = ""
            Me.txtqty.Focus()
            Exit Sub
        End If
        Dim UnitPrice As Double
        Dim MedicineDataTable As New DataTable
        Dim UnitDataTable As New DataTable
        UnitDataTable = DA_Unit.SelectUnitByID(CInt(Me.CboUnit.SelectedValue))
        MedicineDataTable = DA_Medicine.SelectMedicineByID(CInt(Me.cbomedicine.SelectedValue))
        UnitPrice = MedicineDataTable.Rows(0).Item("unitprice") / UnitDataTable.Rows(0).Item("ratioqty")
        UnitPrice = Math.Round(UnitPrice, 2)

        If lblaction.Text = 0 Then

            DA_PreOrder.InsertOrder(CInt(Me.cbomedicine.SelectedValue), CInt(Me.CboUnit.SelectedValue), CInt(Me.txtqty.Text), UnitPrice)
            MsgBox("One order was added", MsgBoxStyle.Information, "Successfully Added")
            Me.txtqty.Text = ""
            Me.cbomedicine.SelectedIndex = 0
            Me.CboUnit.SelectedIndex = 0
            Invoice.RefreshOrderList()
        Else
            If MsgBox("Are you sure you want to update this order?", MsgBoxStyle.YesNo, "Confirm Update") = MsgBoxResult.Yes Then
                DA_PreOrder.UpdateOrder(CInt(Me.cbomedicine.SelectedValue), CInt(Me.CboUnit.SelectedValue), CInt(Me.txtqty.Text), UnitPrice, Invoice.OrderList.CurrentRow.Cells("preid").Value)
                MsgBox("The order was updated", MsgBoxStyle.Information, "Successfully Updated")
                Invoice.RefreshOrderList()
                Me.Close()
            End If
        End If
    End Sub
    Sub LoadDataToUnitBox()
        Me.CboUnit.DataSource = Nothing
        Dim UnitTable As New DataTable
        UnitTable = DA_Unit.SelectUnitByMedicineID(CInt(Me.cbomedicine.SelectedValue))
        Me.CboUnit.DataSource = UnitTable
        Me.CboUnit.ValueMember = UnitTable.Columns("unitId").ColumnName
        Me.CboUnit.DisplayMember = UnitTable.Columns("unitname").ColumnName
    End Sub

    Private Sub cbomedicine_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbomedicine.SelectionChangeCommitted
        LoadDataToUnitBox()
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class