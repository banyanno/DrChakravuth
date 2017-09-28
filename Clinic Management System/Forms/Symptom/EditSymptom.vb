Public Class EditSymptom
    Dim DA_Symptom As New DSPAtientTableAdapters.SymptomsTableAdapter
    Dim Symptom As MainParameter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal SymptomPanel As MainParameter)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Symptom = SymptomPanel
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If (Me.txtname.Text.Trim = "") Then
            MsgBox("Please enter symptom")
            Me.txtname.Focus()
        Else
            If (MsgBox("Are you sure you want to update this symptom?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                DA_Symptom.UpdateSymptom(Me.txtname.Text.Replace("'", "''"), Me.txtid.Text)
                Me.txtname.Text = ""
                Me.txtid.Text = ""
                Me.Close()
            End If
        End If
    End Sub
End Class