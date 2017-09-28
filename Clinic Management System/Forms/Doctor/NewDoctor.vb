Public Class NewDoctor
    Dim DA_Doctor As New DSPAtientTableAdapters.DoctorsTableAdapter
    Dim Doctor As MainParameter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal DoctorPanel As MainParameter)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Doctor = DoctorPanel
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub NewDoctor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub ClearData()
        Me.txtname.Text = ""
        Me.txtphone.Text = ""
        Me.txtdesc.Text = ""
        Me.txtname.Focus()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(txtname, "", ErrValidate) = False Then Exit Sub
        If ValidateTextField(txtphone, "", ErrValidate) = False Then Exit Sub
        Dim Doc_Name As String = Me.txtname.Text.Trim.Replace("'", "''")
        Dim Doc_Phone As String = Me.txtphone.Text.Trim.Replace("'", "''")
        Dim ItemTable As New DataTable
        If lblaction.Text = 0 Then
            DA_Doctor.InsertDoctor(Doc_Name, Doc_Phone, Me.txtdesc.Text.ToString.Replace("'", "''"))
            MsgBox("One doctor information was added", MsgBoxStyle.Information, "Successfully added")
            ClearData()
            Doctor.RefreshDoctorInfo()
        Else
            Dim DoctorID As String = Doctor.DoctorList.CurrentRow.Cells("Doctor_ID").Value
            If MsgBox("Are you sure you want to update this doctor information?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DA_Doctor.UpdateDoctor(Doc_Name, Doc_Phone, Me.txtdesc.Text.ToString.Replace("'", "''"), DoctorID)
                MsgBox("The doctor information was updated", MsgBoxStyle.Information, "Successfully updated")
                Doctor.RefreshDoctorInfo()
                Me.Close()
            End If
        End If
    End Sub
End Class