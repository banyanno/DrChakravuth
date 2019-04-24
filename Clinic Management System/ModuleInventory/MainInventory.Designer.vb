<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainInventory))
        Me.PanelDedail = New System.Windows.Forms.Panel
        Me.ContainerPicloading = New Janus.Windows.Ribbon.ContainerControlCommand
        Me.PanelHeader = New System.Windows.Forms.Panel
        Me.BtnHome = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.LabelDepartment = New Janus.Windows.Ribbon.LabelCommand
        Me.DropDownCommand3 = New Janus.Windows.Ribbon.DropDownCommand
        Me.SeparatorCommand2 = New Janus.Windows.Ribbon.SeparatorCommand
        Me.SeparatorCommand1 = New Janus.Windows.Ribbon.SeparatorCommand
        Me.DBtnChangePassword = New Janus.Windows.Ribbon.DropDownCommand
        Me.BtnDateTimeServer = New Janus.Windows.Ribbon.LabelCommand
        Me.DBtnSwitchUser = New Janus.Windows.Ribbon.DropDownCommand
        Me.DropDownCommand1 = New Janus.Windows.Ribbon.DropDownCommand
        Me.PanelHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelDedail
        '
        Me.PanelDedail.BackColor = System.Drawing.Color.White
        Me.PanelDedail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDedail.Location = New System.Drawing.Point(0, 98)
        Me.PanelDedail.Name = "PanelDedail"
        Me.PanelDedail.Size = New System.Drawing.Size(1155, 421)
        Me.PanelDedail.TabIndex = 21
        '
        'ContainerPicloading
        '
        Me.ContainerPicloading.ControlWidth = 180
        Me.ContainerPicloading.ForegroundStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ContainerPicloading.Key = "ContainerControlCommand1"
        Me.ContainerPicloading.Name = "ContainerPicloading"
        Me.ContainerPicloading.Text = "Loading"
        Me.ContainerPicloading.Visible = False
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.LightGray
        Me.PanelHeader.Controls.Add(Me.BtnHome)
        Me.PanelHeader.Controls.Add(Me.BtnExit)
        Me.PanelHeader.Controls.Add(Me.Label2)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1155, 98)
        Me.PanelHeader.TabIndex = 20
        '
        'BtnHome
        '
        Me.BtnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHome.FlatAppearance.BorderSize = 0
        Me.BtnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHome.ForeColor = System.Drawing.Color.White
        Me.BtnHome.Image = CType(resources.GetObject("BtnHome.Image"), System.Drawing.Image)
        Me.BtnHome.Location = New System.Drawing.Point(10, 54)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(51, 46)
        Me.BtnHome.TabIndex = 16
        Me.BtnHome.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.White
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.Location = New System.Drawing.Point(1116, 64)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(41, 36)
        Me.BtnExit.TabIndex = 15
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Battambang", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1155, 34)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Inventory Management System"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelDepartment
        '
        Me.LabelDepartment.Key = "LabelDepartment"
        Me.LabelDepartment.Name = "LabelDepartment"
        Me.LabelDepartment.Text = ""
        '
        'DropDownCommand3
        '
        Me.DropDownCommand3.ForegroundStyle.ForeColor = System.Drawing.Color.Blue
        Me.DropDownCommand3.Image = CType(resources.GetObject("DropDownCommand3.Image"), System.Drawing.Image)
        Me.DropDownCommand3.Key = "DropDownCommand3"
        Me.DropDownCommand3.Name = "DropDownCommand3"
        Me.DropDownCommand3.Text = "Lock System"
        '
        'SeparatorCommand2
        '
        Me.SeparatorCommand2.Key = "SeparatorCommand2"
        Me.SeparatorCommand2.Name = "SeparatorCommand2"
        '
        'SeparatorCommand1
        '
        Me.SeparatorCommand1.Key = "SeparatorCommand1"
        Me.SeparatorCommand1.Name = "SeparatorCommand1"
        '
        'DBtnChangePassword
        '
        Me.DBtnChangePassword.ForegroundStyle.ForeColor = System.Drawing.Color.Blue
        Me.DBtnChangePassword.Image = CType(resources.GetObject("DBtnChangePassword.Image"), System.Drawing.Image)
        Me.DBtnChangePassword.Key = "DropDownCommand4"
        Me.DBtnChangePassword.Name = "DBtnChangePassword"
        Me.DBtnChangePassword.Text = "Change Password"
        '
        'BtnDateTimeServer
        '
        Me.BtnDateTimeServer.ForegroundStyle.ForeColor = System.Drawing.Color.Blue
        Me.BtnDateTimeServer.Image = CType(resources.GetObject("BtnDateTimeServer.Image"), System.Drawing.Image)
        Me.BtnDateTimeServer.Key = "LabelCommand1"
        Me.BtnDateTimeServer.Name = "BtnDateTimeServer"
        Me.BtnDateTimeServer.Text = " Date Server:   "
        '
        'DBtnSwitchUser
        '
        Me.DBtnSwitchUser.ForegroundStyle.ForeColor = System.Drawing.Color.Blue
        Me.DBtnSwitchUser.Image = CType(resources.GetObject("DBtnSwitchUser.Image"), System.Drawing.Image)
        Me.DBtnSwitchUser.Key = "DropDownCommand2"
        Me.DBtnSwitchUser.Name = "DBtnSwitchUser"
        Me.DBtnSwitchUser.Text = "Switch User:"
        '
        'DropDownCommand1
        '
        Me.DropDownCommand1.Commands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.DBtnSwitchUser, Me.SeparatorCommand1, Me.DropDownCommand3, Me.SeparatorCommand2, Me.DBtnChangePassword})
        Me.DropDownCommand1.ForegroundStyle.ForeColor = System.Drawing.Color.Blue
        Me.DropDownCommand1.Image = CType(resources.GetObject("DropDownCommand1.Image"), System.Drawing.Image)
        Me.DropDownCommand1.Key = "DropDownCommand1"
        Me.DropDownCommand1.Name = "DropDownCommand1"
        Me.DropDownCommand1.SizeStyle = Janus.Windows.Ribbon.CommandSizeStyle.Small
        Me.DropDownCommand1.Text = " User Utility   "
        '
        'MainInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 519)
        Me.Controls.Add(Me.PanelDedail)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainInventory"
        Me.Text = "Inventory System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DropDownCommand3 As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents PanelDedail As System.Windows.Forms.Panel
    Friend WithEvents SeparatorCommand2 As Janus.Windows.Ribbon.SeparatorCommand
    Friend WithEvents SeparatorCommand1 As Janus.Windows.Ribbon.SeparatorCommand
    Friend WithEvents DBtnChangePassword As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents BtnDateTimeServer As Janus.Windows.Ribbon.LabelCommand
    Friend WithEvents DBtnSwitchUser As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents ContainerPicloading As Janus.Windows.Ribbon.ContainerControlCommand
    Friend WithEvents DropDownCommand1 As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents BtnHome As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelDepartment As Janus.Windows.Ribbon.LabelCommand
End Class
