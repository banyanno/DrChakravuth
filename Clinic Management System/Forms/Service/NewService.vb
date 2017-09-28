Public Class NewService
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
    Private Sub NewService_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbotype.DataSource = DA_ServiceType.GetData
        Me.cbotype.ValueMember = DA_ServiceType.GetData.Columns("Type_ID").ColumnName
        Me.cbotype.DisplayMember = DA_ServiceType.GetData.Columns("Type_Name").ColumnName
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
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
            DA_Service.InsertService(Me.cbotype.SelectedValue, Me.txtname.Text.Trim, Me.txtprice.Text)
            Me.Service.LoadDataToGrid()
            Me.txtname.Text = ""
            Me.txtprice.Text = ""
        End If
    End Sub
End Class