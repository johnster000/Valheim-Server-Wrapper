<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBScriptPath = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LSTVUsers = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TBServerName = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.NUDPort = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TBWorldName = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TBPassword = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TBServerData = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.CBBackups = New System.Windows.Forms.CheckBox()
        Me.TBBackup = New System.Windows.Forms.TextBox()
        Me.CBAutostart = New System.Windows.Forms.CheckBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.CBCrossplay = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.NUDPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(503, 530)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 36)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(89, 28)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(101, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 28)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TBScriptPath)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(681, 58)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Server Script File (valheim_server.exe)"
        '
        'TBScriptPath
        '
        Me.TBScriptPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBScriptPath.Location = New System.Drawing.Point(8, 23)
        Me.TBScriptPath.Margin = New System.Windows.Forms.Padding(4)
        Me.TBScriptPath.Name = "TBScriptPath"
        Me.TBScriptPath.Size = New System.Drawing.Size(664, 22)
        Me.TBScriptPath.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.LSTVUsers)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 219)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(681, 236)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Users"
        '
        'LSTVUsers
        '
        Me.LSTVUsers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LSTVUsers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LSTVUsers.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LSTVUsers.FullRowSelect = True
        Me.LSTVUsers.GridLines = True
        Me.LSTVUsers.HideSelection = False
        Me.LSTVUsers.Location = New System.Drawing.Point(8, 23)
        Me.LSTVUsers.Margin = New System.Windows.Forms.Padding(4)
        Me.LSTVUsers.MultiSelect = False
        Me.LSTVUsers.Name = "LSTVUsers"
        Me.LSTVUsers.Size = New System.Drawing.Size(664, 205)
        Me.LSTVUsers.TabIndex = 0
        Me.LSTVUsers.UseCompatibleStateImageBehavior = False
        Me.LSTVUsers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Username"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Last ZDOID"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Last Login"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Last Logout"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem, Me.RemoveUserToolStripMenuItem, Me.EditUserToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(166, 76)
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.AddUserToolStripMenuItem.Text = "Add User"
        '
        'RemoveUserToolStripMenuItem
        '
        Me.RemoveUserToolStripMenuItem.Name = "RemoveUserToolStripMenuItem"
        Me.RemoveUserToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.RemoveUserToolStripMenuItem.Text = "Remove User"
        '
        'EditUserToolStripMenuItem
        '
        Me.EditUserToolStripMenuItem.Name = "EditUserToolStripMenuItem"
        Me.EditUserToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.EditUserToolStripMenuItem.Text = "Edit User"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.TBServerName)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 463)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(164, 60)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Server Name"
        '
        'TBServerName
        '
        Me.TBServerName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBServerName.Location = New System.Drawing.Point(8, 23)
        Me.TBServerName.Margin = New System.Windows.Forms.Padding(4)
        Me.TBServerName.Name = "TBServerName"
        Me.TBServerName.Size = New System.Drawing.Size(146, 22)
        Me.TBServerName.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.NUDPort)
        Me.GroupBox4.Location = New System.Drawing.Point(188, 463)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(88, 60)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Port"
        '
        'NUDPort
        '
        Me.NUDPort.Location = New System.Drawing.Point(8, 23)
        Me.NUDPort.Margin = New System.Windows.Forms.Padding(4)
        Me.NUDPort.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NUDPort.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUDPort.Name = "NUDPort"
        Me.NUDPort.Size = New System.Drawing.Size(72, 22)
        Me.NUDPort.TabIndex = 1
        Me.NUDPort.Value = New Decimal(New Integer() {2456, 0, 0, 0})
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.TBWorldName)
        Me.GroupBox5.Location = New System.Drawing.Point(284, 463)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(121, 60)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "World Name"
        '
        'TBWorldName
        '
        Me.TBWorldName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBWorldName.Location = New System.Drawing.Point(8, 23)
        Me.TBWorldName.Margin = New System.Windows.Forms.Padding(4)
        Me.TBWorldName.Name = "TBWorldName"
        Me.TBWorldName.Size = New System.Drawing.Size(104, 22)
        Me.TBWorldName.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.TBPassword)
        Me.GroupBox6.Location = New System.Drawing.Point(413, 463)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(182, 60)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Password"
        '
        'TBPassword
        '
        Me.TBPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBPassword.Location = New System.Drawing.Point(8, 23)
        Me.TBPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TBPassword.Name = "TBPassword"
        Me.TBPassword.Size = New System.Drawing.Size(165, 22)
        Me.TBPassword.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.TBServerData)
        Me.GroupBox7.Location = New System.Drawing.Point(16, 80)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Size = New System.Drawing.Size(681, 58)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Server Data Folder"
        '
        'TBServerData
        '
        Me.TBServerData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBServerData.Location = New System.Drawing.Point(8, 23)
        Me.TBServerData.Margin = New System.Windows.Forms.Padding(4)
        Me.TBServerData.Name = "TBServerData"
        Me.TBServerData.Size = New System.Drawing.Size(664, 22)
        Me.TBServerData.TabIndex = 0
        '
        'GroupBox8
        '
        Me.GroupBox8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox8.Controls.Add(Me.CBBackups)
        Me.GroupBox8.Controls.Add(Me.TBBackup)
        Me.GroupBox8.Location = New System.Drawing.Point(16, 145)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Size = New System.Drawing.Size(681, 58)
        Me.GroupBox8.TabIndex = 3
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Backup Location"
        '
        'CBBackups
        '
        Me.CBBackups.AutoSize = True
        Me.CBBackups.Checked = True
        Me.CBBackups.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBBackups.Location = New System.Drawing.Point(552, 26)
        Me.CBBackups.Margin = New System.Windows.Forms.Padding(4)
        Me.CBBackups.Name = "CBBackups"
        Me.CBBackups.Size = New System.Drawing.Size(110, 20)
        Me.CBBackups.TabIndex = 1
        Me.CBBackups.Text = "Do Backups?"
        Me.CBBackups.UseVisualStyleBackColor = True
        '
        'TBBackup
        '
        Me.TBBackup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBBackup.Location = New System.Drawing.Point(8, 23)
        Me.TBBackup.Margin = New System.Windows.Forms.Padding(4)
        Me.TBBackup.Name = "TBBackup"
        Me.TBBackup.Size = New System.Drawing.Size(535, 22)
        Me.TBBackup.TabIndex = 0
        '
        'CBAutostart
        '
        Me.CBAutostart.AutoSize = True
        Me.CBAutostart.Location = New System.Drawing.Point(16, 539)
        Me.CBAutostart.Margin = New System.Windows.Forms.Padding(4)
        Me.CBAutostart.Name = "CBAutostart"
        Me.CBAutostart.Size = New System.Drawing.Size(231, 20)
        Me.CBAutostart.TabIndex = 7
        Me.CBAutostart.Text = "Auto start server on program open"
        Me.CBAutostart.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.CBCrossplay)
        Me.GroupBox9.Location = New System.Drawing.Point(602, 463)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(95, 60)
        Me.GroupBox9.TabIndex = 8
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "CrossPlay"
        '
        'CBCrossplay
        '
        Me.CBCrossplay.AutoSize = True
        Me.CBCrossplay.Location = New System.Drawing.Point(35, 28)
        Me.CBCrossplay.Name = "CBCrossplay"
        Me.CBCrossplay.Size = New System.Drawing.Size(18, 17)
        Me.CBCrossplay.TabIndex = 0
        Me.CBCrossplay.UseVisualStyleBackColor = True
        '
        'SettingsDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(713, 581)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.CBAutostart)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SettingsDialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.NUDPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TBScriptPath As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LSTVUsers As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AddUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TBServerName As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TBWorldName As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TBPassword As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents TBServerData As TextBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents TBBackup As TextBox
    Friend WithEvents CBBackups As CheckBox
    Friend WithEvents CBAutostart As CheckBox
    Friend WithEvents NUDPort As NumericUpDown
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents CBCrossplay As CheckBox
End Class
