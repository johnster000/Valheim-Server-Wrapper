Public Class adduser

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If TBUsername.Text = String.Empty Then MessageBox.Show(Me, "Please enter a Username") : Exit Sub
        If TBSteamid.Text = String.Empty Then MessageBox.Show(Me, "Please enter a Steam ID") : Exit Sub

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
