<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class diaOpenManhole
    'Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '<System.Diagnostics.DebuggerNonUserCode()> _
    'Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    '    Try
    '        If disposing AndAlso components IsNot Nothing Then
    '            components.Dispose()
    '        End If
    '    Finally
    '        MyBase.Dispose(disposing)
    '    End Try
    'End Sub

    ''Required by the Windows Form Designer
    'Private components As System.ComponentModel.IContainer

    ''NOTE: The following procedure is required by the Windows Form Designer
    ''It can be modified using the Windows Form Designer.  
    ''Do not modify it using the code editor.
    '<System.Diagnostics.DebuggerStepThrough()> _
    'Private Sub InitializeComponent()
    '    Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
    '    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
    '    Me.OK_Button = New System.Windows.Forms.Button
    '    Me.Cancel_Button = New System.Windows.Forms.Button
    '    Me.lstManoles = New Infragistics.Win.UltraWinListView.UltraListView
    '    Me.TextBox1 = New System.Windows.Forms.TextBox
    '    Me.Label1 = New System.Windows.Forms.Label
    '    Me.Label2 = New System.Windows.Forms.Label
    '    Me.cboMeterBasin = New System.Windows.Forms.ComboBox
    '    Me.btnGetMH = New System.Windows.Forms.Button
    '    Me.TableLayoutPanel1.SuspendLayout()
    '    CType(Me.lstManoles, System.ComponentModel.ISupportInitialize).BeginInit()
    '    Me.SuspendLayout()
    '    '
    '    'TableLayoutPanel1
    '    '
    '    Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    '    Me.TableLayoutPanel1.ColumnCount = 2
    '    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    '    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    '    Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
    '    Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
    '    Me.TableLayoutPanel1.Location = New System.Drawing.Point(199, 222)
    '    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    '    Me.TableLayoutPanel1.RowCount = 1
    '    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    '    Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
    '    Me.TableLayoutPanel1.TabIndex = 0
    '    '
    '    'OK_Button
    '    '
    '    Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    '    Me.OK_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    '    Me.OK_Button.Location = New System.Drawing.Point(3, 3)
    '    Me.OK_Button.Name = "OK_Button"
    '    Me.OK_Button.Size = New System.Drawing.Size(67, 23)
    '    Me.OK_Button.TabIndex = 0
    '    Me.OK_Button.Text = "OK"
    '    '
    '    'Cancel_Button
    '    '
    '    Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    '    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    '    Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
    '    Me.Cancel_Button.Name = "Cancel_Button"
    '    Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
    '    Me.Cancel_Button.TabIndex = 1
    '    Me.Cancel_Button.Text = "Cancel"
    '    '
    '    'lstManoles
    '    '
    '    Me.lstManoles.ItemSettings.AllowEdit = Infragistics.Win.DefaultableBoolean.[False]
    '    Me.lstManoles.Location = New System.Drawing.Point(13, 66)
    '    Me.lstManoles.Name = "lstManoles"
    '    Appearance1.BackColor = System.Drawing.SystemColors.ButtonFace
    '    Me.lstManoles.ScrollBarLook.Appearance = Appearance1
    '    Me.lstManoles.Size = New System.Drawing.Size(329, 139)
    '    Me.lstManoles.TabIndex = 1
    '    Me.lstManoles.View = Infragistics.Win.UltraWinListView.UltraListViewStyle.Details
    '    Me.lstManoles.ViewSettingsDetails.FullRowSelect = True
    '    '
    '    'TextBox1
    '    '
    '    Me.TextBox1.Location = New System.Drawing.Point(118, 37)
    '    Me.TextBox1.Name = "TextBox1"
    '    Me.TextBox1.Size = New System.Drawing.Size(121, 20)
    '    Me.TextBox1.TabIndex = 2
    '    '
    '    'Label1
    '    '
    '    Me.Label1.AutoSize = True
    '    Me.Label1.Location = New System.Drawing.Point(13, 40)
    '    Me.Label1.Name = "Label1"
    '    Me.Label1.Size = New System.Drawing.Size(44, 13)
    '    Me.Label1.TabIndex = 3
    '    Me.Label1.Text = "Search:"
    '    '
    '    'Label2
    '    '
    '    Me.Label2.AutoSize = True
    '    Me.Label2.Location = New System.Drawing.Point(13, 9)
    '    Me.Label2.Name = "Label2"
    '    Me.Label2.Size = New System.Drawing.Size(99, 13)
    '    Me.Label2.TabIndex = 4
    '    Me.Label2.Text = "Select Drainage Area:"
    '    '
    '    'cboMeterBasin
    '    '
    '    Me.cboMeterBasin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
    '    Me.cboMeterBasin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    '    Me.cboMeterBasin.FormattingEnabled = True
    '    Me.cboMeterBasin.Location = New System.Drawing.Point(118, 6)
    '    Me.cboMeterBasin.Name = "cboMeterBasin"
    '    Me.cboMeterBasin.Size = New System.Drawing.Size(121, 21)
    '    Me.cboMeterBasin.TabIndex = 5
    '    '
    '    'btnGetMH
    '    '
    '    Me.btnGetMH.Location = New System.Drawing.Point(254, 4)
    '    Me.btnGetMH.Name = "btnGetMH"
    '    Me.btnGetMH.Size = New System.Drawing.Size(88, 23)
    '    Me.btnGetMH.TabIndex = 6
    '    Me.btnGetMH.Text = "Get Manholes"
    '    Me.btnGetMH.UseVisualStyleBackColor = True
    '    '
    '    'diaOpenManhole
    '    '
    '    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    '    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    '    Me.ClientSize = New System.Drawing.Size(356, 263)
    '    Me.Controls.Add(Me.cboMeterBasin)
    '    Me.Controls.Add(Me.Label2)
    '    Me.Controls.Add(Me.Label1)
    '    Me.Controls.Add(Me.TextBox1)
    '    Me.Controls.Add(Me.lstManoles)
    '    Me.Controls.Add(Me.TableLayoutPanel1)
    '    Me.Controls.Add(Me.btnGetMH)
    '    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    '    Me.MaximizeBox = False
    '    Me.MinimizeBox = False
    '    Me.Name = "diaOpenManhole"
    '    Me.ShowInTaskbar = False
    '    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    '    Me.Text = "Open Manhole"
    '    Me.TableLayoutPanel1.ResumeLayout(False)
    '    CType(Me.lstManoles, System.ComponentModel.ISupportInitialize).EndInit()
    '    Me.ResumeLayout(False)
    '    Me.PerformLayout()

    'End Sub
    'Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    'Friend WithEvents OK_Button As System.Windows.Forms.Button
    'Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    'Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    'Friend WithEvents Label1 As System.Windows.Forms.Label
    'Friend WithEvents Label2 As System.Windows.Forms.Label
    'Friend WithEvents cboMeterBasin As System.Windows.Forms.ComboBox
    'Friend WithEvents btnGetMH As System.Windows.Forms.Button
    'Private WithEvents lstManoles As Infragistics.Win.UltraWinListView.UltraListView

End Class
