Imports System.Windows.Forms

Public Class edituser
    Dim originalusername As String = String.Empty

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        For Each user As String In My.Settings.Users
            If user.Contains(TBSteam.Text) Then
                Dim newstring As String = TBUsername.Text & "," & TBSteam.Text & "," & DTPin.Value.ToString("yyyy/MM/dd hh:mm:ss tt") & "," & DTPout.Value.ToString("yyyy/MM/dd hh:mm:ss tt")
                My.Settings.Users.Remove(user)
                My.Settings.Users.Add(newstring)
                Exit For
            End If
        Next

        For Each item As ListViewItem In Form1.LSTVUserEvents.Items
            If item.SubItems(1).Text = originalusername Then
                item.SubItems(1).Text = TBUsername.Text
            End If
        Next
        For Each item As ListViewItem In Form1.LSTVUsersOnline.Items
            If item.Text = originalusername Then
                item.Text = TBUsername.Text
            End If
        Next
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
skipline:

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Sub New(ByVal listviewitem As ListViewItem)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        originalusername = listviewitem.Text
        TBUsername.Text = listviewitem.Text
        TBSteam.Text = listviewitem.SubItems(1).Text
        DTPin.Value = listviewitem.SubItems(2).Text
        DTPout.Value = listviewitem.SubItems(3).Text
    End Sub
End Class
