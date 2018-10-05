Imports System.Text.RegularExpressions
Imports System.Net
Imports EO.WebBrowser
Imports System.IO

Public Class Form2

    Private Sub FlatButton1_Click(sender As System.Object, e As System.EventArgs) Handles FlatButton1.Click
        If FlatTextBox1.Text.Trim = "" Then
            MsgBox("No ha Ingresado la URL del Video / You have not entered the Video URL", MessageBoxButtons.OK, "Attention")
        Else
            html()
        End If
    End Sub

    Private Sub FlatButton2_Click(sender As System.Object, e As System.EventArgs) Handles FlatButton2.Click
        If FlatTextBox2.Text.Trim = "" Then
            MsgBox("No Posee ninguna URL MP3 / It does not have any MP3 URL", MessageBoxButtons.OK, "Attention")
        Else
            AxWindowsMediaPlayer1.URL = FlatTextBox2.Text
        End If
    End Sub

    Private Sub FlatButton4_Click(sender As System.Object, e As System.EventArgs) Handles FlatButton4.Click
        If FlatTextBox2.Text.Trim = "" Then
            MsgBox("No Posee ninguna URL MP3 / It does not have any MP3 URL", MessageBoxButtons.OK, "Attention")
        Else
            Clipboard.Clear()
            Clipboard.SetText(FlatTextBox2.Text)
        End If
    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Actualizer()
    End Sub

#Region "API"

    Private Sub html()
        WebView1.Url = "https://youtube7.download/mini.php?id=" & getID(FlatTextBox1.Text).ToString
    End Sub

    Private Sub WebView1_BeforeDownload(ByVal sender As Object, ByVal e As BeforeDownloadEventArgs) Handles WebView1.BeforeDownload

        e.ShowDialog = False

        ' Obtener url de descarga.
        Dim uri As New Uri(e.Item.Url)

        FlatTextBox2.Text = uri.ToString

    End Sub

    Private Function getID(url As String) As String
        Try
            Dim myMatches As System.Text.RegularExpressions.Match 'Varible to hold the match
            Dim MyRegEx As New System.Text.RegularExpressions.Regex("youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)", RegexOptions.IgnoreCase) 'This is where the magic happens/SHOULD work on all normal youtube links including youtu.be
            myMatches = MyRegEx.Match(url)
            If myMatches.Success = True Then
                Return myMatches.Groups(1).Value
            Else
                Return "" 'Didn't match something went wrong
            End If
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function

#End Region

#Region "Descargar MP3"

    Dim WithEvents CLIENTE As New WebClient

    Private Sub FlatButton3_Click(sender As System.Object, e As System.EventArgs) Handles FlatButton3.Click
        If FlatTextBox2.Text.Trim = "" Then
            MsgBox("No Posee ninguna URL MP3 / It does not have any MP3 URL", MessageBoxButtons.OK, "Attention")
        Else
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    CLIENTE.DownloadFileAsync(New Uri(FlatTextBox2.Text), SaveFileDialog1.FileName)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub CLIENTE_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles CLIENTE.DownloadProgressChanged
        FlatProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub CLIENTE_DownloadFileCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles CLIENTE.DownloadFileCompleted
        MsgBox("Descarga Finalizada / Finalized Download", MessageBoxButtons.OK, "Attention")
    End Sub

#End Region

#Region "ads"

#Region "Obtener INFO"

    Dim client As New WebClient
    Dim WithEvents CLIEN As New WebClient
    Dim temp As String = Path.GetTempPath()
    Private Sub Actualizer()
        Try
            Dim Url As String = client.DownloadString("https://pastebin.com/raw/0grFk6xQ")

            Try
                CLIEN.DownloadFileAsync(New Uri(Url), temp & "a1a.jpg")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CLIEN_DownloadFileCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles CLIEN.DownloadFileCompleted
        Try
            PictureBox1.BackgroundImage = System.Drawing.Image.FromFile(temp & "a1a.jpg")
        Catch ex As Exception

        End Try

    End Sub

#End Region

#End Region


End Class