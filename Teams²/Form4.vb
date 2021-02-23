Public Class Form4
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PictureBox2.Show()
        PictureBox4.Hide()
        Threading.Thread.Sleep(3000)
        Me.Text = "Repairing..."
        Label3.MaximumSize = New Size(280, 0)
        Label1.Text = "Repairing..."
        Label3.Text = "Now attempting to repair Teams². 
This might take a while. Please do not close this window."
        ProgressBar1.Show()

        Timer1.Start()
        Label2.Show()


    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Hide()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox5_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox5.MouseEnter
        PictureBox4.Show()

    End Sub

    Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form2.Show()
        Form3.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1.3)
        If ProgressBar1.Value = 2 Then Form1.Show()
        Form1.Timer1.Stop()
        Form1.FormBorderStyle = FormBorderStyle.FixedToolWindow
        Form1.ControlBox = False
        Form1.ShowInTaskbar = False
        Form1.Size = New Size(100, 100)
        Form1.Text = "RepairModule"
        If ProgressBar1.Value = 6 Then Label2.Text = "Signing out..."
        If ProgressBar1.Value = 8 Then Form1.WebView1.Navigate("https://login.live.com/logout.srf?ct=1590362567&rver=7.0.6738.0&lc=1033&id=292666&ru=https%3A%2F%2Faccount.microsoft.com%2Fauth%2Fcomplete-signout%3Fru%3Dhttps%253A%252F%252Faccount.microsoft.com%252F%253Flang%253Den-US%2526refd%253Daccount.live.com%2526refp%253Dlanding%2526mkt%253DEN-US")
        If ProgressBar1.Value = 19 Then Label2.Text = "Generating new client ID..."
        If ProgressBar1.Value = 19 Then Form1.WebView1.Refresh()

        If ProgressBar1.Value = 25 Then Label2.Text = "Clearing cache..."
        If ProgressBar1.Value = 25 Then Form1.WebView1.Navigate("https://www.google.com")
        If ProgressBar1.Value = 40 Then Form1.WebView1.Navigate("https://www.microsoft.com")
        If ProgressBar1.Value = 50 Then Form1.WebView1.Navigate("https://www.office.com/estslogout")
        If ProgressBar1.Value = 60 Then Form1.WebView1.Navigate("https://www.youtube.com")
        If ProgressBar1.Value = 80 Then Form1.WebView1.Navigate("https://network.coopydood.com")
        If ProgressBar1.Value = 85 Then Label2.Text = "Resetting..."
        If ProgressBar1.Value = 90 Then Label2.Text = "Finishing..."
        If ProgressBar1.Value = 87 Then Form1.WebView1.Navigate("https://login.microsoftonline.com/federation/oauth2/logout")
        If ProgressBar1.Value = 95 Then Form1.Hide()
        If ProgressBar1.Value = 100 Then Label2.Text = "Operation complete."
        If ProgressBar1.Value = 100 Then Label1.Text = "Repair Complete"
        If ProgressBar1.Value = 100 Then Me.Text = "Repair Complete"
        If ProgressBar1.Value = 100 Then Label3.Text = "The repair process has finished. 
Please relaunch Teams² and try 
using Microsoft Teams again."
        If ProgressBar1.Value = 100 Then PictureBox7.Show()
        If ProgressBar1.Value = 100 Then PictureBox5.Hide()
        If ProgressBar1.Value = 100 Then PictureBox4.Hide()
        If ProgressBar1.Value = 100 Then PictureBox2.Hide()
        If ProgressBar1.Value = 100 Then ProgressBar1.Hide()
        If ProgressBar1.Value = 100 Then Label2.Hide()


    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox7_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox7.MouseEnter
        If PictureBox7.Visible = True Then PictureBox6.Show()
        If PictureBox7.Visible = True Then PictureBox7.Hide()
    End Sub

    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave
        PictureBox6.Hide()
        PictureBox7.Show()

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Timer1.Stop()
        Me.Hide()
        Form1.Show()
        Form1.WebView1.Navigate("https://login.microsoftonline.com/federation/oauth2/logout")

        Form1.FormBorderStyle = FormBorderStyle.Sizable
        Form1.ControlBox = True
        Form1.ShowInTaskbar = True
        Form1.Size = New Size(1139, 761)
        Form1.Text = "Loading..."
        Form1.Timer1.Start()

        'Application.Exit()

    End Sub
End Class