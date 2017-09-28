<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultationList
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
        Dim Prescription_List_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultationList))
        Me.Prescription_List = New Janus.Windows.GridEX.GridEX
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.BtnClose = New System.Windows.Forms.Button
        CType(Me.Prescription_List, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Prescription_List
        '
        Me.Prescription_List.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Prescription_List.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Prescription_List_DesignTimeLayout.LayoutString = resources.GetString("Prescription_List_DesignTimeLayout.LayoutString")
        Me.Prescription_List.DesignTimeLayout = Prescription_List_DesignTimeLayout
        Me.Prescription_List.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Prescription_List.GroupByBoxVisible = False
        Me.Prescription_List.HeaderFormatStyle.Font = New System.Drawing.Font("Khmer OS System", 11.25!)
        Me.Prescription_List.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.Prescription_List.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.Prescription_List.Location = New System.Drawing.Point(0, 0)
        Me.Prescription_List.Name = "Prescription_List"
        Me.Prescription_List.RecordNavigator = True
        Me.Prescription_List.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.Prescription_List.RowHeaderFormatStyle.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.Prescription_List.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.Prescription_List.SelectedInactiveFormatStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.Prescription_List.SelectedInactiveFormatStyle.ForeColor = System.Drawing.SystemColors.Window
        Me.Prescription_List.Size = New System.Drawing.Size(834, 333)
        Me.Prescription_List.TabIndex = 22
        Me.Prescription_List.TableHeaderFormatStyle.Font = New System.Drawing.Font("Khmer OS System", 12.0!)
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Location = New System.Drawing.Point(593, 345)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(116, 36)
        Me.BtnEdit.TabIndex = 26
        Me.BtnEdit.Text = "Edit "
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(715, 345)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(116, 36)
        Me.BtnClose.TabIndex = 25
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'ConsultationList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 387)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.Prescription_List)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConsultationList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultation List"
        CType(Me.Prescription_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Prescription_List As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
End Class
