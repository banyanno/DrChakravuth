<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transfer
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transfer))
        Me.ErrMenu = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cbomedicine = New System.Windows.Forms.ComboBox
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnTransfer = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtcurrentqty = New System.Windows.Forms.TextBox
        Me.txttransferedqty = New System.Windows.Forms.TextBox
        Me.txtratioqty = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtmainunit = New System.Windows.Forms.TextBox
        Me.cbosubunit = New System.Windows.Forms.ComboBox
        Me.txtmainqty = New System.Windows.Forms.TextBox
        CType(Me.ErrMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrMenu
        '
        Me.ErrMenu.ContainerControl = Me
        '
        'cbomedicine
        '
        Me.cbomedicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomedicine.Font = New System.Drawing.Font("Trebuchet MS", 11.0!)
        Me.cbomedicine.FormattingEnabled = True
        Me.cbomedicine.Location = New System.Drawing.Point(146, 59)
        Me.cbomedicine.Name = "cbomedicine"
        Me.cbomedicine.Size = New System.Drawing.Size(250, 28)
        Me.cbomedicine.TabIndex = 51
        '
        'BtnClose
        '
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnClose.Location = New System.Drawing.Point(317, 267)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(79, 30)
        Me.BtnClose.TabIndex = 49
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnTransfer
        '
        Me.BtnTransfer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTransfer.Enabled = False
        Me.BtnTransfer.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransfer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnTransfer.Location = New System.Drawing.Point(232, 267)
        Me.BtnTransfer.Name = "BtnTransfer"
        Me.BtnTransfer.Size = New System.Drawing.Size(79, 30)
        Me.BtnTransfer.TabIndex = 48
        Me.BtnTransfer.Text = "Transfer"
        Me.BtnTransfer.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(40, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 18)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Current Qty :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(57, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 18)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Ratio Qty :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(18, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 18)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "From Main Unit :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(20, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 18)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Medicine Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(64, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 24)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Transfer Form (Main to Sub Unit)"
        '
        'txtcurrentqty
        '
        Me.txtcurrentqty.BackColor = System.Drawing.Color.White
        Me.txtcurrentqty.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcurrentqty.Location = New System.Drawing.Point(146, 225)
        Me.txtcurrentqty.Name = "txtcurrentqty"
        Me.txtcurrentqty.ReadOnly = True
        Me.txtcurrentqty.Size = New System.Drawing.Size(250, 26)
        Me.txtcurrentqty.TabIndex = 38
        '
        'txttransferedqty
        '
        Me.txttransferedqty.BackColor = System.Drawing.Color.White
        Me.txttransferedqty.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttransferedqty.Location = New System.Drawing.Point(146, 103)
        Me.txttransferedqty.Name = "txttransferedqty"
        Me.txttransferedqty.Size = New System.Drawing.Size(97, 26)
        Me.txttransferedqty.TabIndex = 39
        '
        'txtratioqty
        '
        Me.txtratioqty.BackColor = System.Drawing.Color.White
        Me.txtratioqty.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtratioqty.Location = New System.Drawing.Point(146, 185)
        Me.txtratioqty.Name = "txtratioqty"
        Me.txtratioqty.ReadOnly = True
        Me.txtratioqty.Size = New System.Drawing.Size(250, 26)
        Me.txtratioqty.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(41, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 18)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "To Sub Unit :"
        '
        'txtmainunit
        '
        Me.txtmainunit.BackColor = System.Drawing.Color.White
        Me.txtmainunit.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmainunit.Location = New System.Drawing.Point(249, 103)
        Me.txtmainunit.Name = "txtmainunit"
        Me.txtmainunit.ReadOnly = True
        Me.txtmainunit.Size = New System.Drawing.Size(147, 26)
        Me.txtmainunit.TabIndex = 55
        '
        'cbosubunit
        '
        Me.cbosubunit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosubunit.Font = New System.Drawing.Font("Trebuchet MS", 11.0!)
        Me.cbosubunit.FormattingEnabled = True
        Me.cbosubunit.Location = New System.Drawing.Point(146, 142)
        Me.cbosubunit.Name = "cbosubunit"
        Me.cbosubunit.Size = New System.Drawing.Size(250, 28)
        Me.cbosubunit.TabIndex = 56
        '
        'txtmainqty
        '
        Me.txtmainqty.BackColor = System.Drawing.Color.White
        Me.txtmainqty.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmainqty.Location = New System.Drawing.Point(402, 103)
        Me.txtmainqty.Name = "txtmainqty"
        Me.txtmainqty.Size = New System.Drawing.Size(70, 26)
        Me.txtmainqty.TabIndex = 57
        '
        'Transfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 305)
        Me.Controls.Add(Me.txtmainqty)
        Me.Controls.Add(Me.cbosubunit)
        Me.Controls.Add(Me.txtmainunit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbomedicine)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnTransfer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcurrentqty)
        Me.Controls.Add(Me.txttransferedqty)
        Me.Controls.Add(Me.txtratioqty)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Transfer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer"
        CType(Me.ErrMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrMenu As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbomedicine As System.Windows.Forms.ComboBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnTransfer As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcurrentqty As System.Windows.Forms.TextBox
    Friend WithEvents txttransferedqty As System.Windows.Forms.TextBox
    Friend WithEvents txtratioqty As System.Windows.Forms.TextBox
    Friend WithEvents txtmainunit As System.Windows.Forms.TextBox
    Friend WithEvents cbosubunit As System.Windows.Forms.ComboBox
    Friend WithEvents txtmainqty As System.Windows.Forms.TextBox
End Class
