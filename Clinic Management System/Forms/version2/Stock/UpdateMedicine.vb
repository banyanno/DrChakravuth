Public Class UpdateMedicine
    Dim MedicinePanel As UCMedicine
    Dim DA_Medicine As New DSPAtientTableAdapters.tblmedicineTableAdapter
    Dim DA_Barcode As New DSBarCodeTableAdapters.BARCODETableAdapter
    Sub New(ByVal UMedicine As UCMedicine)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        MedicinePanel = UMedicine
        ' Add any initialization after the InitializeComponent() call.
        InitBarcode()
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Private Sub InitBarcode()
        With TxtItemBarcode
            .DataSource = DA_Barcode.GetData
            .ValueMember = "BarcodeID"
            .DisplayMember = "BarcodeNo"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(Me.txtmedicine, "", ErrMenu) = False Then Exit Sub
        If DA_Medicine.SelectMedicineByName(Me.txtmedicine.Text).Rows.Count >= 1 And Me.txtmedicine.Text <> MedicinePanel.MedicineList.CurrentRow.Cells("medicinename").Value.ToString Then
            MsgBox("This medicine already exists", MsgBoxStyle.Exclamation, "Existing Medicine")
            Me.txtmedicine.SelectAll()
            Me.txtmedicine.Focus()
            Exit Sub
        End If
        If DA_Medicine.UpdateMedicine(Me.txtmedicine.Text, TxtItemBarcode.Text, CInt(MedicinePanel.MedicineList.CurrentRow.Cells("medicineid").Value)) = 1 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
        'MsgBox("One medicine has been updated", MsgBoxStyle.Information, "Medicine Updated")
     
    End Sub
End Class