Imports System.Windows.Forms

Public Class SettingsDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        My.Settings.Item("ServerScript") = TBScriptPath.Text
        My.Settings.Item("ServerName") = TBServerName.Text
        My.Settings.Item("Port") = CInt(NUDPort.Value)
        My.Settings.Item("WorldName") = TBWorldName.Text
        My.Settings.Item("Password") = TBPassword.Text
        My.Settings.Item("ServerDataPath") = TBServerData.Text
        My.Settings.Item("Backup") = CBBackups.Checked
        My.Settings.Item("BackupPath") = TBBackup.Text
        My.Settings.Item("Autostart") = CBAutostart.Checked
        My.Settings.Item("CrossPlay") = CBCrossplay.Checked

        My.Settings.Save()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SettingsDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.ServerScript <> "" Then
            TBScriptPath.Text = My.Settings.ServerScript
        Else
            TBScriptPath.Text = My.Settings.PropertyValues("ServerScript").Property.DefaultValue
        End If
        If My.Settings.ServerDataPath <> "" Then
            TBServerData.Text = My.Settings.ServerDataPath
        Else
            TBServerData.Text = My.Settings.PropertyValues("ServerDataPath").Property.DefaultValue
        End If
        If My.Settings.BackupPath <> "" Then
            TBBackup.Text = My.Settings.BackupPath
        Else
            TBBackup.Text = My.Settings.PropertyValues("BackupPath").Property.DefaultValue
        End If

        CBBackups.Checked = My.Settings.Backup
        CBAutostart.Checked = My.Settings.Autostart
        CBCrossplay.Checked = My.Settings.CrossPlay

        TBServerName.Text = My.Settings.ServerName
        TBServerName.Text = My.Settings.ServerName
        NUDPort.Value = My.Settings.Port
        TBWorldName.Text = My.Settings.WorldName
        TBPassword.Text = My.Settings.Password

        loadusers()
    End Sub

    Sub loadusers()
        LSTVUsers.Items.Clear()
        LSTVUsers.BeginUpdate()
        Try
            For Each item As String In My.Settings.Users
                Try
                    Dim line As String() = item.Split(",")
                    If line.Count > 1 Then
                        With LSTVUsers.Items.Add(line(0))
                            For i As Integer = 1 To line.Count
                                .SubItems.Add(line(i))
                            Next
                        End With
                    End If
                Catch ex As Exception
                End Try
            Next
            For Each hdr As ColumnHeader In LSTVUsers.Columns
                hdr.Width = -2
            Next
        Catch ex As Exception
        Finally
            LSTVUsers.EndUpdate()
        End Try
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        Dim newuser As New adduser
        If newuser.ShowDialog = DialogResult.OK Then
            My.Settings.Users.Add(newuser.TBUsername.Text & "," & newuser.TBSteamid.Text & ",1900/01/01 12:00:00 AM" & ",1900/01/01 12:00:00 AM")
            My.Settings.Save()
            With LSTVUsers.Items.Add(newuser.TBUsername.Text)
                .SubItems.Add(newuser.TBSteamid.Text)
                .SubItems.Add("1900/01/01 12:00:00 AM")
                .SubItems.Add("1900/01/01 12:00:00 AM")
            End With
        End If
    End Sub

    Private Sub RemoveUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveUserToolStripMenuItem.Click
        My.Settings.Users.Remove(LSTVUsers.SelectedItems(0).Text & "," & LSTVUsers.SelectedItems(0).SubItems(1).Text & "," & LSTVUsers.SelectedItems(0).SubItems(2).Text & "," & LSTVUsers.SelectedItems(0).SubItems(3).Text)
        LSTVUsers.SelectedItems(0).Remove()
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If LSTVUsers.SelectedItems.Count = 1 Then
            RemoveUserToolStripMenuItem.Enabled = True
            EditUserToolStripMenuItem.Enabled = True
        Else
            RemoveUserToolStripMenuItem.Enabled = False
            EditUserToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub EditUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditUserToolStripMenuItem.Click
        Dim edituser As New edituser(LSTVUsers.SelectedItems(0))
        If edituser.ShowDialog = DialogResult.OK Then
            loadusers()
        End If
    End Sub

End Class
