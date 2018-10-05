Imports System.Text.RegularExpressions
Imports EO.WebBrowser
Imports System.Web



Public Class Form1


    Const quote = """"

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim = "" Then
            MsgBox("No ha Ingresado la URL del Video / You have not weitten anything to Ofuscate", MessageBoxButtons.OK, "Atencion")
        Else
            html()
        End If
    End Sub

#Region "API"

    Private Sub html()
        WebView1.Url = "https://youtube7.download/mini.php?id=" & getID(TextBox1.Text).ToString
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

    Private Sub WebView1_BeforeDownload(ByVal sender As Object, ByVal e As BeforeDownloadEventArgs) Handles WebView1.BeforeDownload

        e.ShowDialog = False

        ' Obtener url de descarga.
        Dim uri As New Uri(e.Item.Url)

        TextBox2.Text = uri.ToString

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If TextBox2.Text.Trim = "" Then
            MsgBox("No Posee ninguna URL MP3 / You have not weitten anything to Ofuscate", MessageBoxButtons.OK, "Atencion")
        Else
            AxWindowsMediaPlayer1.URL = TextBox2.Text
        End If
    End Sub
End Class
