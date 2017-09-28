Public Class NewSymptom
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
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If Me.txtname.Text.Trim = "" Then
            MsgBox("Please enter symptom")
            Me.txtname.Focus()
        Else
            DA_Symptom.InsertSymptom(Me.txtname.Text.Replace("'", "''"))
            MsgBox("One symptom was added", MsgBoxStyle.Information)
            Me.txtname.Text = ""
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub NewSymptom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class