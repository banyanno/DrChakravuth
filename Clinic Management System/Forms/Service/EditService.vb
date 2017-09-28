Public Class EditService
    Dim DA_Service As New DSPAtientTableAdapters.ServicesTableAdapter
    Dim DA_ServiceType As New DSPAtientTableAdapters.Service_TypesTableAdapter
    Dim Service As Service
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal ServicePanel As Service)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Service = ServicePanel
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(txtname, "", ErrValidate) = False Then Exit Sub
        If ValidateTextField(txtprice, "", ErrValidate) = False Then Exit Sub
        If IsNumeric(txtprice.Text.Trim) = False Then
            MsgBox("Please enter price as number")
            Me.txtprice.Focus()
            Exit Sub
        Else
            If MsgBox("Are you sure you want to update this service?") = MsgBoxResult.Yes Then
                DA_Service.UpdateService(Me.txtname.Text, Me.cbotype.SelectedValue, Me.txtprice.Text, Me.txtid.Text)
                Me.Close()
                Me.Service.LoadDataToGrid()
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub EditService_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbotype.DataSource = DA_ServiceType.GetData
    End Sub
End Class