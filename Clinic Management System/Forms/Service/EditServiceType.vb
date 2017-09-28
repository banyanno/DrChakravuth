Public Class EditServiceType
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
    Private Sub EditServiceType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If (Me.txtname.Text.Trim = "") Then
            MsgBox("Please enter service type")
            Me.txtname.Focus()
        Else
            If (MsgBox("Are you sure you want to update this service type?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                DA_ServiceType.UpdateType(Me.txtname.Text.Replace("'", "''"), Me.txtid.Text)
                Me.txtname.Text = ""
                Me.txtid.Text = ""
                ServiceType.LoadDataToGridView()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class