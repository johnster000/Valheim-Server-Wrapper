Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form1

    Private psi As ProcessStartInfo
    Private cmd As Process
    Private success As Boolean
    Private Delegate Sub InvokeWithString(ByVal text As String)

    Public userdictionary As New Dictionary(Of String, String)
    Public waitng_on_user_to_connect As String

    Public Declare Function SetForegroundWindow Lib "user32.dll" (ByVal hwnd As Integer) As Integer
    Declare Auto Function SetParent Lib "user32.dll" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Private Const WM_SYSCOMMAND As Integer = 274
    Private Const SC_MAXIMIZE As Integer = 61488

    Dim serverstart As Date

    'Opens up the settings dialog
    Private Sub BTNSettings_Click(sender As Object, e As EventArgs) Handles BTNSettings.Click
        Dim settingswindow As New SettingsDialog
        settingswindow.ShowDialog()
    End Sub

    'Hanldes starting and stopping the server
    Private Sub BTNServer_Click(sender As Object, e As EventArgs) Handles BTNServer.Click
        Select Case BTNServer.Text
            Case "Start Server"
                If My.Settings.ServerName = "" Then MessageBox.Show(Me, "Please specify a Server Name") : Exit Sub
                If My.Settings.WorldName = "" Then MessageBox.Show(Me, "Please specify a World Name") : Exit Sub
                If My.Settings.Password = "" Then MessageBox.Show(Me, "Please specify a Password") : Exit Sub
                If Not Directory.Exists(My.Settings.ServerDataPath) Then MessageBox.Show(Me, "Please select the proper Server Data Path for your World and Character files") : Exit Sub

                Try
                    TBOutput.Clear()
                    LBLServerUp.Text = "Server Uptime: 00:00"
                    LSTVUserEvents.Items.Clear()
                    LSTVUsersOnline.Items.Clear()
                    psi = New ProcessStartInfo(My.Settings.ServerScript)
                    BTNServer.Text = "Starting..."
                    BTNServer.Enabled = False
                    Dim crossplay As String = String.Empty
                    If My.Settings.CrossPlay Then
                        crossplay = " -crossplay"
                    End If
                    Dim arguments As String = "valheim_server -nographics -batchmode -name """ & My.Settings.ServerName & """ -port " & My.Settings.Port & " -world """ & My.Settings.WorldName & """ -password """ & My.Settings.Password & """" & crossplay
                    'MessageBox.Show(Me, arguments)
                    Dim systemencoding As System.Text.Encoding = System.Text.Encoding.GetEncoding(Globalization.CultureInfo.CurrentUICulture.TextInfo.OEMCodePage)
                    With psi
                        .Arguments = arguments
                        .UseShellExecute = False  ' Required for redirection
                        .RedirectStandardError = True
                        .RedirectStandardOutput = True
                        .RedirectStandardInput = True
                        .CreateNoWindow = False
                        .StandardOutputEncoding = systemencoding  ' Use OEM encoding for console applications
                        .StandardErrorEncoding = systemencoding
                        .WorkingDirectory = System.IO.Path.GetDirectoryName(My.Settings.ServerScript)
                    End With

                    ' EnableraisingEvents is required for Exited event
                    cmd = New Process With {.StartInfo = psi, .EnableRaisingEvents = True}
                    AddHandler cmd.ErrorDataReceived, AddressOf Async_Data_Received
                    AddHandler cmd.OutputDataReceived, AddressOf Async_Data_Received
                    AddHandler cmd.Exited, AddressOf CMD_Exited

                    cmd.Start()
                    Do Until cmd.MainWindowHandle <> 0
                    Loop

                    SetParent(cmd.MainWindowHandle, Me.Panel1.Handle)
                    SendMessage(cmd.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0)
                    Me.BringToFront()

                    ' Start async reading of the redirected streams
                    ' Without these calls the events won't fire
                    cmd.BeginOutputReadLine()
                    cmd.BeginErrorReadLine()

                    BTNServer.Text = "Stop Server"
                    BTNServer.Enabled = True
                    serverstart = Now
                    Timer1.Start()
                Catch ex As Exception
                    MessageBox.Show(Me, ex.Message)
                    end_line()
                End Try
            Case "Stop Server"
                If MessageBox.Show(Me, "Are you sure?", "Stop Server", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    If cmd IsNot Nothing Then
                        BTNServer.Text = "Stopping Server..."
                        BTNServer.Enabled = False
                        Dim h As IntPtr = cmd.MainWindowHandle
                        SetForegroundWindow(h)
                        SendKeys.SendWait("^(c)")
                        SetForegroundWindow(Me.Handle)
                    End If
                End If
        End Select

    End Sub

    Private Sub CMD_Exited(ByVal sender As Object, ByVal e As EventArgs)
        Me.Invoke(New MethodInvoker(AddressOf end_line))
    End Sub

    Sub end_line()
        BTNServer.Text = "Start Server"
        BTNServer.Enabled = True
        Timer1.Stop()
    End Sub

    Private Sub Async_Data_Received(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        Me.Invoke(New InvokeWithString(AddressOf Sync_Output), e.Data)
    End Sub

    Private Sub Sync_Output(ByVal text As String)

        If Not IsNothing(text) Then
            Dim linetime As Date

            Try
                linetime = Date.ParseExact(text.Substring(0, 19), "MM/dd/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
            Catch ex As Exception
                GoTo skipline
            End Try

            Select Case True
                'Case text.Contains("Closing socket")
                '    Dim username As String = String.Empty
                '    Dim timed As String = linetime.ToString("yyyy/MM/dd hh:mm:ss tt")
                '    Dim steamid As String = text.Substring(38, text.Length - 38)
                '    For Each user As String In My.Settings.Users
                '        If user.Contains(steamid) Then
                '            Dim split As String() = user.Split(",")
                '            username = split(0)
                '            Dim newstring As String = split(0) & "," & split(1) & "," & split(2) & "," & timed
                '            My.Settings.Users.Remove(user)
                '            My.Settings.Users.Add(newstring)
                '            My.Settings.Save()
                '            Exit For
                '        End If
                '    Next

                '    Dim newlstvitem As New ListViewItem
                '    With newlstvitem
                '        .Text = "OUT"
                '        .SubItems.Add(username)
                '        .SubItems.Add(timed)
                '    End With
                '    LSTVUserEvents.Items.Insert(0, newlstvitem)
                '    For Each hdr As ColumnHeader In LSTVUserEvents.Columns
                '        hdr.Width = -2
                '    Next
                '    For Each item As ListViewItem In LSTVUsersOnline.Items
                '        If item.Text = username Then
                '            item.Remove()
                '        End If
                '    Next
                '    For Each hdr As ColumnHeader In LSTVUsersOnline.Columns
                '        hdr.Width = -2
                '    Next
                'Case text.Contains("Got handshake from client")
                '    Dim founduser As Boolean = False
                '    Dim username As String = String.Empty
                '    Dim timed As String = linetime.ToString("yyyy/MM/dd hh:mm:ss tt")
                '    Dim steamid As String = text.Substring(47, text.Length - 47)
                '    For Each user As String In My.Settings.Users
                '        If user.Contains(steamid) Then
                '            Dim split As String() = user.Split(",")
                '            username = split(0)
                '            Dim newstring As String = split(0) & "," & split(1) & "," & timed & "," & split(3)
                '            My.Settings.Users.Remove(user)
                '            My.Settings.Users.Add(newstring)
                '            My.Settings.Save()
                '            founduser = True
                '            Exit For
                '        End If
                '    Next
                '    If founduser = False Then username = add_unknown_user(steamid, timed)
                '    Dim newlstvitem As New ListViewItem
                '    With newlstvitem
                '        .Text = "IN"
                '        .SubItems.Add(username)
                '        .SubItems.Add(timed)
                '    End With
                '    LSTVUserEvents.Items.Insert(0, newlstvitem)

                '    For Each hdr As ColumnHeader In LSTVUserEvents.Columns
                '        hdr.Width = -2
                '    Next
                '    With LSTVUsersOnline.Items.Add(username)
                '        .SubItems.Add("00:00")
                '        .Tag = linetime
                '    End With
                '    For Each hdr As ColumnHeader In LSTVUsersOnline.Columns
                '        hdr.Width = -2
                '    Next
                Case text.Contains("World saved")
                    My.Settings.Item("WorldSaved") = linetime.ToString("yyyy/MM/dd hh:mm:ss tt")
                    My.Settings.Save()
                    Try
                        If My.Settings.Backup = True Then
                            If My.Settings.ServerDataPath <> "" Then
                                backup_files()
                                LBLBackup.Text = "Backed Up: Success"
                            Else
                                LBLBackup.Text = "Backed Up: Folder not set!"
                            End If
                        Else
                            LBLBackup.Text = "Backed Up: Option turned off"
                        End If


                    Catch ex As Exception
                        LBLBackup.Text = "Backed Up: Failed"
                    End Try

                    LBLWorldSaved.Text = "World Saved: " & linetime.ToString("yyyy/MM/dd hh:mm:ss tt") & " (" & Converttotime(DateDiff(DateInterval.Minute, CDate(My.Settings.WorldSaved), Now)) & ")"
                Case text.Contains("Got character ZDOID from ")
                    Dim founduser As Boolean = False
                    Dim userline As String = text.Substring(46, text.Length - 46)
                    Dim splituser As String() = userline.Split(":")
                    '#Zog : -3847329843:1
                    Dim username As String = splituser(0).Substring(0, splituser(0).Length - 1)
                    Dim steamid As String = splituser(1).Replace(" ", "") & ":" & splituser(2)
                    Dim timed As String = linetime.ToString("yyyy/MM/dd hh:mm:ss tt")


                    For Each user As String In My.Settings.Users
                        Dim split As String() = user.Split(",")
                        If split(0) = username Then
                            Dim newstring As String = username & "," & steamid & "," & timed & "," & split(3)
                            My.Settings.Users.Remove(user)
                            My.Settings.Users.Add(newstring)
                            My.Settings.Save()
                            founduser = True
                            Exit For
                        End If
                    Next
                    If founduser = False Then add_unknown_user(steamid, timed, username)
                    Dim newlstvitem As New ListViewItem
                    With newlstvitem
                        .Text = "IN"
                        .SubItems.Add(username)
                        .SubItems.Add(timed)
                    End With
                    LSTVUserEvents.Items.Insert(0, newlstvitem)

                    For Each hdr As ColumnHeader In LSTVUserEvents.Columns
                        hdr.Width = -2
                    Next

                    Dim login_exists As Boolean = False
                    For Each item As ListViewItem In LSTVUsersOnline.Items
                        If item.Text = username Then login_exists = True : Exit For
                    Next

                    If login_exists = False Then
                        With LSTVUsersOnline.Items.Add(username)
                            .SubItems.Add("00:00")
                            .Tag = linetime
                        End With
                    End If

                    For Each hdr As ColumnHeader In LSTVUsersOnline.Columns
                        hdr.Width = -2
                    Next
                Case text.Contains("Destroying abandoned non persistent zdo ")
                    Dim founduser As Boolean = False
                    Dim userline As String = text.Substring(61, text.Length - 61)
                    Dim splituser As String() = userline.Split(" owner ")
                    Dim username As String = String.Empty
                    Dim timed As String = linetime.ToString("yyyy/MM/dd hh:mm:ss tt")
                    Dim steamid As String = splituser(0)

                    For Each user As String In My.Settings.Users
                        Dim split As String() = user.Split(",")
                        Try
                            If split(1) = steamid Then
                                username = split(0)
                                Dim newstring As String = username & "," & steamid & "," & split(2) & "," & timed
                                My.Settings.Users.Remove(user)
                                My.Settings.Users.Add(newstring)
                                My.Settings.Save()
                                founduser = True
                                Exit For
                            End If
                        Catch
                        End Try
                    Next
                    If founduser = True Then
                        Dim newlstvitem As New ListViewItem
                        With newlstvitem
                            .Text = "OUT"
                            .SubItems.Add(username)
                            .SubItems.Add(timed)
                        End With
                        LSTVUserEvents.Items.Insert(0, newlstvitem)
                        For Each hdr As ColumnHeader In LSTVUserEvents.Columns
                            hdr.Width = -2
                        Next
                        For Each item As ListViewItem In LSTVUsersOnline.Items
                            If item.Text = username Then
                                item.Remove()
                            End If
                        Next
                        For Each hdr As ColumnHeader In LSTVUsersOnline.Columns
                            hdr.Width = -2
                        Next
                    End If

            End Select


            If Not text.Contains("Line: 35)") And Not text = "" And Not text = " " Then
                TBOutput.AppendText(text & Environment.NewLine)
            End If
        End If

        TBOutput.ScrollToCaret()
skipline:
    End Sub

    Sub backup_files()
        Try
            If Not Directory.Exists("C:\Backup") Then
                My.Computer.FileSystem.CreateDirectory("C:\Backup")
            End If

            If Directory.Exists("C:\Backup\Last") Then
                My.Computer.FileSystem.DeleteDirectory("C:\Backup\Last", FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If

            If Directory.Exists("C:\Backup\Newest") Then
                My.Computer.FileSystem.RenameDirectory("C:\Backup\Newest", "Last")
                ' My.Computer.FileSystem.DeleteDirectory("C:\Backup\Newest", FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If

            My.Computer.FileSystem.CopyDirectory(My.Settings.ServerDataPath, "C:\Backup\Newest\" & Format(Now, "yyyy-MM-dd-HH-mm-ss"), True)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Function add_unknown_user(ByVal steamid As String, ByVal timein As String, ByVal newusername As String) As String
        '        Dim count As Integer = 1

        'Try_again:
        '        Dim countedusername As String = newusername & count
        '        Dim userexists As Boolean = False

        '        For Each user As String In My.Settings.Users
        '            Dim split As String() = user.Split(",")
        '            If countedusername = split(0) Then
        '                userexists = True
        '                Exit For
        '            End If
        '        Next
        '        If userexists Then
        '            count += 1
        '            GoTo Try_again
        '        End If

        Dim newstring As String = newusername & "," & steamid & "," & timein & ","
        My.Settings.Users.Add(newstring)
        My.Settings.Save()

        Return newusername
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For Each item In LSTVUsersOnline.Items
            item.subitems(1).text = Converttotime(DateDiff(DateInterval.Minute, item.tag, Now))
        Next
        LBLServerUp.Text = "Server Uptime: " & Converttotime(DateDiff(DateInterval.Minute, serverstart, Now))
        Try
            LBLWorldSaved.Text = "World Saved: " & My.Settings.WorldSaved & " (" & Converttotime(DateDiff(DateInterval.Minute, CDate(My.Settings.WorldSaved), Now)) & ")"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LBLWorldSaved.Text = "World Saved: " & My.Settings.WorldSaved & " (" & Converttotime(DateDiff(DateInterval.Minute, CDate(My.Settings.WorldSaved), Now)) & ")"
        Catch ex As Exception
            LBLWorldSaved.Text = "World Saved: "
        End Try

        If My.Settings.Autostart = True Then
            BTNServer.PerformClick()
        End If

        'Dim args As String = String.Empty
        'For Each ar In Environment.GetCommandLineArgs()
        '    If ar = "-startup" Then
        '        BTNServer.PerformClick()
        '    End If
        'Next
    End Sub

    Function Converttotime(ByVal input As Integer)
        Dim hours As Integer = input \ 60
        Dim minutes As Integer = input - (hours * 60)
        Dim timeelapsed As String = String.Empty

        If hours.ToString.Length >= 2 Then
            If minutes <= 9 Then
                timeelapsed = hours & ":0" & minutes.ToString
            Else
                timeelapsed = hours & ":" & minutes.ToString
            End If
        ElseIf hours.ToString.Length = 1 Then
            If minutes <= 9 Then
                timeelapsed = "0" & hours & ":0" & minutes.ToString
            Else
                timeelapsed = "0" & hours & ":" & minutes.ToString
            End If
        End If

        Return timeelapsed
    End Function

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        LSTVUsersOnline.SelectedItems(0).Remove()
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If LSTVUsersOnline.SelectedItems.Count <> 1 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Select Case BTNServer.Text
            Case "Stop Server"
                If MessageBox.Show(Me, "Server must be stopped before closing, would you like to stop it now? ", "Stop Server", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    If cmd IsNot Nothing Then
                        BTNServer.Text = "Stopping Server..."
                        BTNServer.Enabled = False
                        Dim h As IntPtr = cmd.MainWindowHandle
                        SetForegroundWindow(h)
                        SendKeys.SendWait("^(c)")
                        SetForegroundWindow(Me.Handle)
                    End If
                End If
                e.Cancel = True
            Case "Stopping Server..."
                e.Cancel = True
        End Select
    End Sub

End Class
