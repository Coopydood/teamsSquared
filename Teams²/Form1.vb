Imports Microsoft.Toolkit.Forms.UI.Controls
Imports Windows.Web.Http.Filters

Public Class Form1
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point





    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Text = WebView1.DocumentTitle & " | Teams²"

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer3.Start()


    End Sub

    Private Sub WebView2_DOMContentLoaded(sender As Object, e As Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlDOMContentLoadedEventArgs) Handles WebView1.DOMContentLoaded

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebView1.Navigate("https://www.office.com/estslogout?ru=%2f%3fref%3dlogout")

        Timer2.Start()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 60 Then WebView1.Refresh()
        If ProgressBar1.Value = 100 Then WebView1.Navigate("https://login.microsoftonline.com")
        If ProgressBar1.Value = 100 Then Timer2.Stop()
        If ProgressBar1.Value = 100 Then Timer3.Start()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Me.Text = "Microsoft account | Home | Teams²" Then WebView1.Navigate("https://teams.microsoft.com")



    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs)
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub WebView1_DOMContentLoaded(sender As Object, e As Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlDOMContentLoadedEventArgs)

    End Sub

    Private Sub WebView1_KeyDown(sender As Object, e As KeyEventArgs) Handles WebView1.KeyDown

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (X)
            newpoint.Y -= (Y)
            Me.Location = newpoint

        End If
    End Sub
End Class
