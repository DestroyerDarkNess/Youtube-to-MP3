<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.WebView1 = New EO.WebBrowser.WebView()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FormSkin1 = New WZ_YOUTUBE_CONVERTER.FormSkin()
        Me.FlatProgressBar1 = New WZ_YOUTUBE_CONVERTER.FlatProgressBar()
        Me.FlatClose1 = New WZ_YOUTUBE_CONVERTER.FlatClose()
        Me.FlatMini1 = New WZ_YOUTUBE_CONVERTER.FlatMini()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.FlatButton4 = New WZ_YOUTUBE_CONVERTER.FlatButton()
        Me.FlatButton3 = New WZ_YOUTUBE_CONVERTER.FlatButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.FlatTextBox2 = New WZ_YOUTUBE_CONVERTER.FlatTextBox()
        Me.FlatButton2 = New WZ_YOUTUBE_CONVERTER.FlatButton()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.FlatGroupBox1 = New WZ_YOUTUBE_CONVERTER.FlatGroupBox()
        Me.FlatLabel6 = New WZ_YOUTUBE_CONVERTER.FlatLabel()
        Me.FlatLabel5 = New WZ_YOUTUBE_CONVERTER.FlatLabel()
        Me.FlatLabel4 = New WZ_YOUTUBE_CONVERTER.FlatLabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.FlatLabel3 = New WZ_YOUTUBE_CONVERTER.FlatLabel()
        Me.FlatLabel2 = New WZ_YOUTUBE_CONVERTER.FlatLabel()
        Me.FlatLabel1 = New WZ_YOUTUBE_CONVERTER.FlatLabel()
        Me.FlatButton1 = New WZ_YOUTUBE_CONVERTER.FlatButton()
        Me.WebControl1 = New EO.WinForm.WebControl()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlatTextBox1 = New WZ_YOUTUBE_CONVERTER.FlatTextBox()
        Me.FormSkin1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlatGroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebView1
        '
        Me.WebView1.ObjectForScripting = Nothing
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "MP3 File|*.mp3"
        Me.SaveFileDialog1.Title = "Save File"
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatProgressBar1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Controls.Add(Me.PictureBox5)
        Me.FormSkin1.Controls.Add(Me.FlatButton4)
        Me.FormSkin1.Controls.Add(Me.FlatButton3)
        Me.FormSkin1.Controls.Add(Me.Label3)
        Me.FormSkin1.Controls.Add(Me.PictureBox4)
        Me.FormSkin1.Controls.Add(Me.FlatTextBox2)
        Me.FormSkin1.Controls.Add(Me.FlatButton2)
        Me.FormSkin1.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.FormSkin1.Controls.Add(Me.FlatGroupBox1)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.WebControl1)
        Me.FormSkin1.Controls.Add(Me.PictureBox2)
        Me.FormSkin1.Controls.Add(Me.PictureBox1)
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.FlatTextBox1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(902, 632)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "           Youtbe MP3 Converter"
        '
        'FlatProgressBar1
        '
        Me.FlatProgressBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatProgressBar1.DarkerProgress = System.Drawing.Color.DodgerBlue
        Me.FlatProgressBar1.Location = New System.Drawing.Point(540, 270)
        Me.FlatProgressBar1.Maximum = 100
        Me.FlatProgressBar1.Name = "FlatProgressBar1"
        Me.FlatProgressBar1.ProgressColor = System.Drawing.Color.DodgerBlue
        Me.FlatProgressBar1.Size = New System.Drawing.Size(349, 42)
        Me.FlatProgressBar1.TabIndex = 23
        Me.FlatProgressBar1.Text = "FlatProgressBar1"
        Me.FlatProgressBar1.Value = 0
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(872, 0)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 22
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(844, 0)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 21
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(65, 47)
        Me.PictureBox5.TabIndex = 20
        Me.PictureBox5.TabStop = False
        '
        'FlatButton4
        '
        Me.FlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton4.BaseColor = System.Drawing.Color.DodgerBlue
        Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton4.Location = New System.Drawing.Point(813, 208)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Rounded = False
        Me.FlatButton4.Size = New System.Drawing.Size(86, 29)
        Me.FlatButton4.TabIndex = 19
        Me.FlatButton4.Text = "Copy URL"
        Me.FlatButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.DodgerBlue
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(399, 270)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(135, 44)
        Me.FlatButton3.TabIndex = 18
        Me.FlatButton3.Text = "Download MP3"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(12, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 21)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "MP3 URL"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox4.Location = New System.Drawing.Point(3, 171)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(896, 10)
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'FlatTextBox2
        '
        Me.FlatTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox2.Location = New System.Drawing.Point(93, 208)
        Me.FlatTextBox2.MaxLength = 32767
        Me.FlatTextBox2.Multiline = False
        Me.FlatTextBox2.Name = "FlatTextBox2"
        Me.FlatTextBox2.ReadOnly = True
        Me.FlatTextBox2.Size = New System.Drawing.Size(714, 29)
        Me.FlatTextBox2.TabIndex = 16
        Me.FlatTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox2.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox2.UseSystemPasswordChar = False
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.DodgerBlue
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(244, 270)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(135, 44)
        Me.FlatButton2.TabIndex = 15
        Me.FlatButton2.Text = "Play Streaming"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(16, 270)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(222, 44)
        Me.AxWindowsMediaPlayer1.TabIndex = 14
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.White
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel6)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel5)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel4)
        Me.FlatGroupBox1.Controls.Add(Me.PictureBox3)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel3)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel2)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel1)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox1.Location = New System.Drawing.Point(3, 320)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(896, 141)
        Me.FlatGroupBox1.TabIndex = 13
        Me.FlatGroupBox1.Text = "Instruciones / Instructions "
        '
        'FlatLabel6
        '
        Me.FlatLabel6.AutoSize = True
        Me.FlatLabel6.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel6.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.FlatLabel6.Location = New System.Drawing.Point(465, 84)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New System.Drawing.Size(252, 26)
        Me.FlatLabel6.TabIndex = 6
        Me.FlatLabel6.Text = "3) A URL will appear, that is the one of the MP3." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can Listen to it by pressi" & _
    "ng Play Streaming."
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.FlatLabel5.Location = New System.Drawing.Point(465, 60)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(277, 13)
        Me.FlatLabel5.TabIndex = 5
        Me.FlatLabel5.Text = "2) Wait and press ""Download mp3"" When it appears."
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.FlatLabel4.Location = New System.Drawing.Point(465, 38)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(339, 13)
        Me.FlatLabel4.TabIndex = 4
        Me.FlatLabel4.Text = "1) Copy URL of Youtube video. and Press ""MP4 Converter"" button"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox3.Location = New System.Drawing.Point(444, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(5, 111)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.FlatLabel3.Location = New System.Drawing.Point(19, 84)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(234, 26)
        Me.FlatLabel3.TabIndex = 2
        Me.FlatLabel3.Text = "3) Aparecera una URL , esa es la del MP3. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Puedes Escucharla pulsando Play Strea" & _
    "ming."
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.FlatLabel2.Location = New System.Drawing.Point(19, 60)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(301, 13)
        Me.FlatLabel2.TabIndex = 1
        Me.FlatLabel2.Text = "2) Esperar y Presionar ""Download mp3"" Cuando aparezca."
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.FlatLabel1.Location = New System.Drawing.Point(19, 38)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(371, 13)
        Me.FlatLabel1.TabIndex = 0
        Me.FlatLabel1.Text = "1) Copiar URL del video de Youtube. y Presionar Boton ""Converter MP4"""
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.DodgerBlue
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(16, 98)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(126, 56)
        Me.FlatButton1.TabIndex = 12
        Me.FlatButton1.Text = "Convert to MP3"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'WebControl1
        '
        Me.WebControl1.BackColor = System.Drawing.Color.White
        Me.WebControl1.Location = New System.Drawing.Point(148, 98)
        Me.WebControl1.Name = "WebControl1"
        Me.WebControl1.Size = New System.Drawing.Size(742, 56)
        Me.WebControl1.TabIndex = 11
        Me.WebControl1.Text = "WebControl1"
        Me.WebControl1.WebView = Me.WebView1
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(821, 602)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(81, 30)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 464)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(902, 168)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(12, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Youtube URL"
        '
        'FlatTextBox1
        '
        Me.FlatTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox1.Location = New System.Drawing.Point(119, 63)
        Me.FlatTextBox1.MaxLength = 32767
        Me.FlatTextBox1.Multiline = False
        Me.FlatTextBox1.Name = "FlatTextBox1"
        Me.FlatTextBox1.ReadOnly = False
        Me.FlatTextBox1.Size = New System.Drawing.Size(771, 29)
        Me.FlatTextBox1.TabIndex = 0
        Me.FlatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox1.UseSystemPasswordChar = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 632)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Youtbe MP3 Converter"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.FlatGroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As WZ_YOUTUBE_CONVERTER.FormSkin
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FlatTextBox1 As WZ_YOUTUBE_CONVERTER.FlatTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents WebControl1 As EO.WinForm.WebControl
    Friend WithEvents WebView1 As EO.WebBrowser.WebView
    Friend WithEvents FlatGroupBox1 As WZ_YOUTUBE_CONVERTER.FlatGroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents FlatLabel3 As WZ_YOUTUBE_CONVERTER.FlatLabel
    Friend WithEvents FlatLabel2 As WZ_YOUTUBE_CONVERTER.FlatLabel
    Friend WithEvents FlatLabel1 As WZ_YOUTUBE_CONVERTER.FlatLabel
    Friend WithEvents FlatButton1 As WZ_YOUTUBE_CONVERTER.FlatButton
    Friend WithEvents FlatLabel6 As WZ_YOUTUBE_CONVERTER.FlatLabel
    Friend WithEvents FlatLabel5 As WZ_YOUTUBE_CONVERTER.FlatLabel
    Friend WithEvents FlatLabel4 As WZ_YOUTUBE_CONVERTER.FlatLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents FlatTextBox2 As WZ_YOUTUBE_CONVERTER.FlatTextBox
    Friend WithEvents FlatButton2 As WZ_YOUTUBE_CONVERTER.FlatButton
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents FlatButton4 As WZ_YOUTUBE_CONVERTER.FlatButton
    Friend WithEvents FlatButton3 As WZ_YOUTUBE_CONVERTER.FlatButton
    Friend WithEvents FlatClose1 As WZ_YOUTUBE_CONVERTER.FlatClose
    Friend WithEvents FlatMini1 As WZ_YOUTUBE_CONVERTER.FlatMini
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents FlatProgressBar1 As WZ_YOUTUBE_CONVERTER.FlatProgressBar
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
