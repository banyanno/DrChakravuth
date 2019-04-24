Public Class NewParaClinicExam
    Dim DA_Para As New DSPAtientTableAdapters.tblparacheckTableAdapter
    Dim Para As MainParameter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal ParaPanel As MainParameter)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Para = ParaPanel
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub ClearData()
        Me.TxtParaName.Text = ""
        Me.TxtParaPrice.Text = ""
        Me.TxtParaName.Focus()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateTextField(Me.TxtParaName, "", Err) = False Then Exit Sub
        If ValidateTextField(Me.TxtParaPrice, "", Err) = False Then Exit Sub
        If ValidateCombobox(CboParaType, "", Err) = False Then Exit Sub
        If IsNumeric(Me.TxtParaPrice.Text) = False Then
            MsgBox("Service charge must be number only", MsgBoxStyle.Exclamation, "Invalid Data")
            Me.TxtParaPrice.SelectAll()
            Me.TxtParaPrice.Focus()
            Exit Sub
        End If
        If Me.LblSaveOption.Text = 0 Then
            DA_Para.InsertPara(Me.TxtParaName.Text.Replace("'", "''"), Me.TxtParaPrice.Text, CboParaType.Text)
            MsgBox("One para clinic examination was added", MsgBoxStyle.Information, "Successfully Added")
            Para.RefreshDataParaExam()
            ClearData()
        Else
            If MsgBox("Are you sure you want to update this para clinic examination?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DA_Para.UpdatePara(Me.TxtParaName.Text.Replace("'", "''"), Me.TxtParaPrice.Text, CboParaType.Text, Para.ParaList.CurrentRow.Cells("paracheckid").Value)
                MsgBox("The para clinic examination was updated", MsgBoxStyle.Information, "Successfully Updated")
                Para.RefreshDataParaExam()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub NewParaClinicExam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class