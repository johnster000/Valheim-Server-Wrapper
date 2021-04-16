<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TBOutput = New System.Windows.Forms.TextBox()
        Me.BTNServer = New System.Windows.Forms.Button()
        Me.BTNSettings = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LSTVUserEvents = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LSTVUsersOnline = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LBLWorldSaved = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LBLBackup = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LBLServerUp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBOutput
        '
        Me.TBOutput.BackColor = System.Drawing.SystemColors.Window
        Me.TBOutput.Location = New System.Drawing.Point(12, 41)
        Me.TBOutput.Multiline = True
        Me.TBOutput.Name = "TBOutput"
        Me.TBOutput.ReadOnly = True
        Me.TBOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TBOutput.Size = New System.Drawing.Size(651, 204)
        Me.TBOutput.TabIndex = 0
        '
        'BTNServer
        '
        Me.BTNServer.Location = New System.Drawing.Point(12, 12)
        Me.BTNServer.Name = "BTNServer"
        Me.BTNServer.Size = New System.Drawing.Size(125, 23)
        Me.BTNServer.TabIndex = 1
        Me.BTNServer.Text = "Start Server"
        Me.BTNServer.UseVisualStyleBackColor = True
        '
        'BTNSettings
        '
        Me.BTNSettings.Location = New System.Drawing.Point(588, 12)
        Me.BTNSettings.Name = "BTNSettings"
        Me.BTNSettings.Size = New System.Drawing.Size(75, 23)
        Me.BTNSettings.TabIndex = 2
        Me.BTNSettings.Text = "Settings"
        Me.BTNSettings.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(143, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(124, 23)
        Me.Panel1.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LSTVUserEvents)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 251)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 185)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Events"
        '
        'LSTVUserEvents
        '
        Me.LSTVUserEvents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LSTVUserEvents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LSTVUserEvents.FullRowSelect = True
        Me.LSTVUserEvents.GridLines = True
        Me.LSTVUserEvents.Location = New System.Drawing.Point(3, 16)
        Me.LSTVUserEvents.MultiSelect = False
        Me.LSTVUserEvents.Name = "LSTVUserEvents"
        Me.LSTVUserEvents.Size = New System.Drawing.Size(332, 166)
        Me.LSTVUserEvents.TabIndex = 4
        Me.LSTVUserEvents.UseCompatibleStateImageBehavior = False
        Me.LSTVUserEvents.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Event"
        Me.ColumnHeader1.Width = 54
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "User"
        Me.ColumnHeader2.Width = 68
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Time"
        Me.ColumnHeader3.Width = 46
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LSTVUsersOnline)
        Me.GroupBox2.Location = New System.Drawing.Point(356, 251)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(307, 185)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Logged in users"
        '
        'LSTVUsersOnline
        '
        Me.LSTVUsersOnline.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader4})
        Me.LSTVUsersOnline.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LSTVUsersOnline.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LSTVUsersOnline.FullRowSelect = True
        Me.LSTVUsersOnline.GridLines = True
        Me.LSTVUsersOnline.Location = New System.Drawing.Point(3, 16)
        Me.LSTVUsersOnline.MultiSelect = False
        Me.LSTVUsersOnline.Name = "LSTVUsersOnline"
        Me.LSTVUsersOnline.Size = New System.Drawing.Size(301, 166)
        Me.LSTVUsersOnline.TabIndex = 5
        Me.LSTVUsersOnline.UseCompatibleStateImageBehavior = False
        Me.LSTVUsersOnline.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "User"
        Me.ColumnHeader5.Width = 96
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Time Online"
        Me.ColumnHeader4.Width = 121
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 26)
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LBLWorldSaved, Me.LBLBackup, Me.LBLServerUp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 439)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(675, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LBLWorldSaved
        '
        Me.LBLWorldSaved.Name = "LBLWorldSaved"
        Me.LBLWorldSaved.Size = New System.Drawing.Size(76, 17)
        Me.LBLWorldSaved.Text = "World Saved:"
        '
        'LBLBackup
        '
        Me.LBLBackup.Name = "LBLBackup"
        Me.LBLBackup.Size = New System.Drawing.Size(66, 17)
        Me.LBLBackup.Text = "Backed Up:"
        '
        'LBLServerUp
        '
        Me.LBLServerUp.Name = "LBLServerUp"
        Me.LBLServerUp.Size = New System.Drawing.Size(518, 17)
        Me.LBLServerUp.Spring = True
        Me.LBLServerUp.Text = "Server Uptime:"
        Me.LBLServerUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LBLServerUp.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 461)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTNSettings)
        Me.Controls.Add(Me.BTNServer)
        Me.Controls.Add(Me.TBOutput)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(691, 500)
        Me.MinimumSize = New System.Drawing.Size(691, 500)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ServerControl"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBOutput As TextBox
    Friend WithEvents BTNServer As Button
    Friend WithEvents BTNSettings As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LSTVUserEvents As ListView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents LSTVUsersOnline As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Timer1 As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents LBLWorldSaved As ToolStripStatusLabel
    Friend WithEvents LBLServerUp As ToolStripStatusLabel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LBLBackup As ToolStripStatusLabel
End Class
