Public Class MainInventory
    'List declearation User Panel
    Dim UIInventory As New MainDashboardInventory
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        UserGlobleVariable.FormMainInventory = Me
        AddUserControl(PanelHeader, PanelDedail, UIInventory, "", True)
        ' Add any initialization after the InitializeComponent() call.

    End Sub

   
    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        AddUserControl(PanelHeader, PanelDedail, UIInventory, "", True)
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class