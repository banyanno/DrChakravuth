Public Class NewPhysicalExamination
    Dim DA_Physical As New DSPAtientTableAdapters.tblPhysicalCheckTableAdapter
    Dim Physical As MainParameter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal PhysicalPanel As MainParameter)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Physical = PhysicalPanel
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub ClearData()
        Me.TxtExamName.Text = ""
        Me.TxtExamName.Focus()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateTextField(Me.TxtExamName, "", Err) = False Then Exit Sub
        If Me.LblSaveOption.Text = 0 Then
            DA_Physical.InsertPhysical(Me.TxtExamName.Text.Replace("'", "''"))
            MsgBox("One physical examination was added", MsgBoxStyle.Information, "Successfully Added")
            Physical.RefreshPhysicalExam()
            ClearData()
        Else
            If MsgBox("Are you sure you want to update this physical examination?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DA_Physical.UpdatePhysical(Me.TxtExamName.Text.Replace("'", "''"), Physical.PhysicalList.CurrentRow.Cells("physicalcheckid").Value)
                MsgBox("The physical examination was updated", MsgBoxStyle.Information, "Successfully Updated")
                Physical.RefreshPhysicalExam()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub NewPhysicalExamination_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class