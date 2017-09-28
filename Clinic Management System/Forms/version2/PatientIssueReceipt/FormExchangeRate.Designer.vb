<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExchangeRate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormExchangeRate))
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtExchangeRate = New System.Windows.Forms.TextBox
        Me.BtnSetExchangeRate = New System.Windows.Forms.Button
        Me.ErrExchangeRate = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LblSaveOption = New System.Windows.Forms.Label
        CType(Me.ErrExchangeRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Exchange Rate:"
        '
        'TxtExchangeRate
        '
        Me.TxtExchangeRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtExchangeRate.Location = New System.Drawing.Point(102, 21)
        Me.TxtExchangeRate.Name = "TxtExchangeRate"
        Me.TxtExchangeRate.Size = New System.Drawing.Size(294, 26)
        Me.TxtExchangeRate.TabIndex = 1
        '
        'BtnSetExchangeRate
        '
        Me.BtnSetExchangeRate.Location = New System.Drawing.Point(275, 53)
        Me.BtnSetExchangeRate.Name = "BtnSetExchangeRate"
        Me.BtnSetExchangeRate.Size = New System.Drawing.Size(121, 26)
        Me.BtnSetExchangeRate.TabIndex = 2
        Me.BtnSetExchangeRate.Text = "Set Exchange Rate"
        Me.BtnSetExchangeRate.UseVisualStyleBackColor = True
        '
        'ErrExchangeRate
        '
        Me.ErrExchangeRate.ContainerControl = Me
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(12, 65)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveOption.TabIndex = 3
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'FormExchangeRate
        '
        Me.AcceptButton = Me.BtnSetExchangeRate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 87)
        Me.Controls.Add(Me.LblSaveOption)
        Me.Controls.Add(Me.BtnSetExchangeRate)
        Me.Controls.Add(Me.TxtExchangeRate)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormExchangeRate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exchange Rate"
        CType(Me.ErrExchangeRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtExchangeRate As System.Windows.Forms.TextBox
    Friend WithEvents BtnSetExchangeRate As System.Windows.Forms.Button
    Friend WithEvents ErrExchangeRate As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
End Class
