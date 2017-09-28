Public Class FMedicalReceived
    Dim MainReceive As UMgrMedicince
    Dim DA_MedicalReceive As New DSMedicalReceiveTableAdapters.MEDICAL_RECEIVEDTableAdapter
    Dim DA_Medicince As New DSMedicalReceiveTableAdapters.tblmedicineTableAdapter

    Dim DA_Expend As New DSMedicalReceiveTableAdapters.tbl_invoiceTableAdapter
    Sub New(ByVal MainReceive As UMgrMedicince)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MainReceive = MainReceive
        ' Add any initialization after the InitializeComponent() call.
        With CboProduct
            .DataSource = DA_Medicince.GetData
            .ValueMember = "medicineid"
            .DisplayMember = "medicinename"
            .SelectedIndex = -1
        End With
        TxtReferNo.Focus()
        TxtReferNo.Select()
        TxtReferNo.SelectAll()
    End Sub
   

    Private Sub BtnCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        If LblSaveOption.Text = "0" Then
            DA_MedicalReceive.DeleteReferenceNo(MaxRecord.Text)
        End If
        Me.Close()
    End Sub


    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtReferNo, "", ErrReceived) = False Then Exit Sub
        If ValidateDateTimePicker(DateReceived, "", ErrReceived) = False Then Exit Sub
        If ValidateTextField(TxtNote, "", ErrReceived) = False Then Exit Sub
        'If ValidateCombobox(CboProduct, "", ErrReceived) = False Then Exit Sub
        'If ValidateTextField(TxtQty, "", ErrReceived) = False Then Exit Sub
        ' '' If ValidateTextField(TxtBonusQTY, "", ErrReceived) = False Then Exit Sub
        'If ValidateTextField(TxtCost, "", ErrReceived) = False Then Exit Sub
        'If ValidateTextField(TxtTotalCost, "", ErrReceived) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new receive?", "Received Medical", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Expend.InsertExpendMedicine(DateReceived.Value.Date, TxtNote.Text, TxtReferNo.Text, TxtSubTotal.Text, MaxRecord.Text, False) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
       
        Else
            If MessageBox.Show("Do you want to update receive?", "Received Medical", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                '  MessageBox.Show(DA_Expend.UpdateExpend(DateReceived.Value.Date, EmptyString(TxtSubTotal.Text), TxtNote.Text,  TxtReferNo.Text)
                If DA_Expend.UpdateExpend(DateReceived.Value.Date, EmptyString(TxtSubTotal.Text), TxtNote.Text, MaxRecord.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub
    Private Sub CleanForm()
        CboProduct.SelectedIndex = -1
        CboProduct.Text = ""
        TxtQty.Text = ""
        TxtBonusQTY.Text = ""
        TxtCost.Text = ""
        TxtTotalCost.Text = ""
        'TxtNote.Text = ""
    End Sub
    Private Sub TxtQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtQty.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtBonusQTY_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBonusQTY.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtCost_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCost.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtTotalCost_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTotalCost.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtCost_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCost.KeyUp
        CalculateTotalCost()
    End Sub
    Private Sub TxtQty_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtQty.KeyUp
        CalculateTotalCost()
    End Sub
    Private Sub CalculateTotalCost()
        TxtTotalCost.Text = CDbl(EmptyString(TxtQty.Text)) * CDbl(EmptyString(TxtCost.Text))
    End Sub

   
    Private Sub FMedicalReceived_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If ValidateTextField(TxtReferNo, "", ErrReceived) = False Then Exit Sub
        If ValidateDateTimePicker(DateReceived, "", ErrReceived) = False Then Exit Sub
        If ValidateCombobox(CboProduct, "", ErrReceived) = False Then Exit Sub
        If ValidateTextField(TxtQty, "", ErrReceived) = False Then Exit Sub
        '' If ValidateTextField(TxtBonusQTY, "", ErrReceived) = False Then Exit Sub
        If ValidateTextField(TxtCost, "", ErrReceived) = False Then Exit Sub
        If ValidateTextField(TxtTotalCost, "", ErrReceived) = False Then Exit Sub
        'If LblSaveOption.Text = "0" Then
        If MessageBox.Show("Do you want to add new receive?", "Received Medical", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_MedicalReceive.InsertNewMedicalReceive(TxtReferNo.Text, DateReceived.Value.Date, CInt(CboProduct.SelectedValue), CboProduct.Text, EmptyString(TxtQty.Text), EmptyString(TxtBonusQTY.Text), EmptyString(TxtCost.Text), EmptyString(TxtTotalCost.Text), TxtNote.Text, MaxRecord.Text, False) = 1 Then
                Dim tblTem As DataTable = DA_MedicalReceive.SelectReferentNo(MaxRecord.Text, False)
                GridMedicalReceive.DataSource = tblTem
                CalSubTotal(tblTem)
                CleanForm()
            Else
                MessageBox.Show("Error. Please check data entry again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        If LblSaveOption.Text <> 0 Then
            BtnCancel.Enabled = False
        End If
        'Else
        '    If MessageBox.Show("Do you want to update receive?", "Received Medical", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        '        If DA_MedicalReceive.UpdateMedicalReceive(TxtReferNo.Text, DateReceived.Value.Date, CInt(CboProduct.SelectedValue), CboProduct.Text, EmptyString(TxtQty.Text), EmptyString(TxtBonusQTY.Text), EmptyString(TxtCost.Text), EmptyString(TxtTotalCost.Text), TxtNote.Text, LblSaveOption.Text) = 1 Then
        '            Me.DialogResult = Windows.Forms.DialogResult.OK
        '        Else
        '            MessageBox.Show("Error. Please check data entry again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub BtnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemove.Click
        If GridMedicalReceive.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to remove?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_MedicalReceive.DeleteByReceiveID(GridMedicalReceive.GetRow.Cells("RECEIVE_ID").Value) = 1 Then
                Dim tblTem As DataTable = DA_MedicalReceive.SelectReferentNo(MaxRecord.Text, False)
                GridMedicalReceive.DataSource = tblTem
                CalSubTotal(tblTem)
            End If
        End If
        If LblSaveOption.Text <> 0 Then
            BtnCancel.Enabled = False
        End If
    End Sub
    Public Sub CalSubTotal(ByVal TblTotal As DataTable)
        Dim Total As Double = 0
        TxtSubTotal.Text = 0
        For Each rows As DataRow In TblTotal.Rows
            Total = Total + CDbl(rows("TOTAL_COST"))
        Next
        TxtSubTotal.Text = Total
    End Sub

End Class