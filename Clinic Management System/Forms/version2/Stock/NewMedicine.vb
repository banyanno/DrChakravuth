Public Class NewMedicine
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

    Private Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        'If ValidateCombobox(TxtItemBarcode, "", ErrMenu) = False Then Exit Sub
        If ValidateTextField(Me.txtmedicine, "", ErrMenu) = False Then Exit Sub
        If DA_Medicine.SelectMedicineByName(Me.txtmedicine.Text.Replace("'", "''").ToString).Rows.Count >= 1 Then
            MsgBox("This medicine already exists", MsgBoxStyle.Exclamation, "Existing Medicine")
            Me.txtmedicine.SelectAll()
            Me.txtmedicine.Focus()
            Exit Sub
        End If
        If DA_Medicine.InsertMedicine(Me.txtmedicine.Text.Replace("'", "''").ToString, TxtItemBarcode.Text) = 1 Then
            'MsgBox("One medicine has been added", MsgBoxStyle.Information, "Medicine Added")
            
            If LblCodeID.Text <> "" Then
                DA_Barcode.UpadateStatusUsed(True, LblCodeID.Text)
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            'Me.txtmedicine.Text = ""
            'TxtItemBarcode.Text = ""
        End If
      
    End Sub

    Private Sub TxtItemBarcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtmedicine.Focus()
            txtmedicine.SelectAll()
        End If
    End Sub

   
    Private Sub TxtItemBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtItemBarcode.TextChanged
        Try
            LblCodeID.Text = TxtItemBarcode.SelectedValue
        Catch ex As Exception
            LblCodeID.Text = "0"
        End Try
    End Sub

    Private Sub TxtItemBarcode_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtItemBarcode.SelectedValueChanged
        Try
            LblCodeID.Text = TxtItemBarcode.SelectedValue
            CheckCodeID(TxtItemBarcode.SelectedValue)
        Catch ex As Exception
            LblCodeID.Text = "0"
        End Try

    End Sub
    Private Sub CheckCodeID(ByVal ID As Integer)

        Dim tbl As DataTable = DA_Barcode.GetDataByCodeID(ID)
        If tbl.Rows.Count > 0 Then
            For Each row As DataRow In tbl.Rows
                If row("used") = True Then
                    LblUsed.Text = "Already Rigister to Item"
                Else
                    LblUsed.Text = "Item is available"
                End If
            Next

        Else
            LblUsed.Text = "Item is available"
        End If

    End Sub
End Class