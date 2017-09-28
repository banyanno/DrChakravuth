Public Class NewServiceType
    Dim DA_ServiceType As New DSPAtientTableAdapters.Service_TypesTableAdapter
    Dim ServiceType As ServiceTypes
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal TypePanel As ServiceTypes)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.ServiceType = TypePanel
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub NewServiceType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If Me.txtname.Text.Trim = "" Then
            MsgBox("Please enter service type")
            Me.txtname.Focus()
        Else
            DA_ServiceType.InsertType(Me.txtname.Text.Replace("'", "''"))
            MsgBox("One service type was added", MsgBoxStyle.Information)
            Me.txtname.Text = ""
            ServiceType.LoadDataToGridView()
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class