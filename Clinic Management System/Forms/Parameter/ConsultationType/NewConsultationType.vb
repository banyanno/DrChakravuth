Public Class NewConsultationType
    Dim DA_ConsultType As New DSPAtientTableAdapters.tblConsultTypeTableAdapter
    Dim ConsultType As MainParameter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal ConsultTypePanel As MainParameter)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.ConsultType = ConsultTypePanel
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub NewConsultationType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub ClearData()
        Me.TxtConsultName.Text = ""
        Me.TxtConsultPrice.Text = ""
        Me.TxtConsultName.Focus()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateTextField(Me.TxtConsultName, "", Err) = False Then Exit Sub
        If ValidateTextField(Me.TxtConsultPrice, "", Err) = False Then Exit Sub
        If IsNumeric(Me.TxtConsultPrice.Text) = False Then
            MsgBox("Price must be number only", MsgBoxStyle.Exclamation, "Invalid Data")
            Me.TxtConsultPrice.SelectAll()
            Me.TxtConsultPrice.Focus()
            Exit Sub
        End If
        If Me.LblSaveOption.Text = 0 Then
            DA_ConsultType.InsertConsultType(Me.TxtConsultName.Text.Replace("'", "''"), Me.TxtConsultPrice.Text)
            MsgBox("One consultation type was added", MsgBoxStyle.Information, "Successfully Added")
            ConsultType.RefreshConsultType()
            ClearData()
        Else
            If MsgBox("Are you sure you want to update this consutation type?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DA_ConsultType.UpdateConsultType(Me.TxtConsultName.Text.Replace("'", "''"), Me.TxtConsultPrice.Text, ConsultType.ConsultTypeList.CurrentRow.Cells("consulttypeid").Value)
                MsgBox("The consultation type was updated", MsgBoxStyle.Information, "Successfully Updated")
                ConsultType.RefreshConsultType()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class