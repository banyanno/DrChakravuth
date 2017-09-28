Public Class NewReferTo
    Dim DA_Hospital As New DSReferalTableAdapters.HOSPITALTableAdapter
    Dim DA_Hospital_Referal As New DSReferalTableAdapters.HOSPITAL_REFERALTableAdapter
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        InitParameter()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub InitParameter()
        With CboRefferendTo
            .DataSource = DA_Hospital.GetData
            .ValueMember = "HOSPITAL_NO"
            .DisplayMember = "HOSPITAL_NAME"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub NewReferTo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateCombobox(CboRefferendTo, "", ErroReferto) = False Then Exit Sub
        If ValidateDateTimePicker(DateRefer, "", ErroReferto) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want create new referal?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Hospital_Referal.InsertNewHospitalReferal(LblPatientNo.Text, CboRefferendTo.SelectedValue, DateRefer.Value.Date, txtDescription.Text) = 1 Then
                    MessageBox.Show("Save new referal successful.", "save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error save new referal.", "save", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            If MessageBox.Show("Do you want update referal?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Hospital_Referal.UpdateHospitalReferal(LblPatientNo.Text, CboRefferendTo.SelectedValue, DateRefer.Value.Date, txtDescription.Text, LblSaveOption.Text) = 1 Then
                    MessageBox.Show("Update referal successful.", "save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error update referal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub
End Class