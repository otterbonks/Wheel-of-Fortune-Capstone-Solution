<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.WheelImages = New System.Windows.Forms.ImageList(Me.components)
        Me.picWheel = New System.Windows.Forms.PictureBox()
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtPlay1Guess = New System.Windows.Forms.TextBox()
        Me.lblRandWord = New System.Windows.Forms.Label()
        Me.lstRandWords = New System.Windows.Forms.ListBox()
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLoad = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnU = New System.Windows.Forms.Button()
        Me.btnT = New System.Windows.Forms.Button()
        Me.btnS = New System.Windows.Forms.Button()
        Me.btnR = New System.Windows.Forms.Button()
        Me.btnQ = New System.Windows.Forms.Button()
        Me.btnP = New System.Windows.Forms.Button()
        Me.btnO = New System.Windows.Forms.Button()
        Me.btnN = New System.Windows.Forms.Button()
        Me.btnM = New System.Windows.Forms.Button()
        Me.btnL = New System.Windows.Forms.Button()
        Me.btnK = New System.Windows.Forms.Button()
        Me.btnJ = New System.Windows.Forms.Button()
        Me.btnI = New System.Windows.Forms.Button()
        Me.btnH = New System.Windows.Forms.Button()
        Me.btnG = New System.Windows.Forms.Button()
        Me.btnF = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnX = New System.Windows.Forms.Button()
        Me.btnW = New System.Windows.Forms.Button()
        Me.btnV = New System.Windows.Forms.Button()
        Me.btnZ = New System.Windows.Forms.Button()
        Me.btnY = New System.Windows.Forms.Button()
        Me.grpLetters = New System.Windows.Forms.GroupBox()
        CType(Me.picWheel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.grpLetters.SuspendLayout()
        Me.SuspendLayout()
        '
        'WheelImages
        '
        Me.WheelImages.ImageStream = CType(resources.GetObject("WheelImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.WheelImages.TransparentColor = System.Drawing.Color.Transparent
        Me.WheelImages.Images.SetKeyName(0, "wheel1.png")
        Me.WheelImages.Images.SetKeyName(1, "wheel2.png")
        Me.WheelImages.Images.SetKeyName(2, "wheel3.png")
        Me.WheelImages.Images.SetKeyName(3, "wheel4.png")
        Me.WheelImages.Images.SetKeyName(4, "wheel5.png")
        Me.WheelImages.Images.SetKeyName(5, "wheel6.png")
        Me.WheelImages.Images.SetKeyName(6, "wheel7.png")
        Me.WheelImages.Images.SetKeyName(7, "wheel8.png")
        Me.WheelImages.Images.SetKeyName(8, "wheel9.png")
        Me.WheelImages.Images.SetKeyName(9, "wheel10.png")
        Me.WheelImages.Images.SetKeyName(10, "wheel11.png")
        Me.WheelImages.Images.SetKeyName(11, "wheel12.png")
        Me.WheelImages.Images.SetKeyName(12, "wheel13.png")
        Me.WheelImages.Images.SetKeyName(13, "wheel14.png")
        Me.WheelImages.Images.SetKeyName(14, "wheel15.png")
        Me.WheelImages.Images.SetKeyName(15, "wheel16.png")
        Me.WheelImages.Images.SetKeyName(16, "wheel17.png")
        Me.WheelImages.Images.SetKeyName(17, "wheel18.png")
        Me.WheelImages.Images.SetKeyName(18, "wheel19.png")
        Me.WheelImages.Images.SetKeyName(19, "wheel20.png")
        Me.WheelImages.Images.SetKeyName(20, "wheel21.png")
        Me.WheelImages.Images.SetKeyName(21, "wheel22.png")
        Me.WheelImages.Images.SetKeyName(22, "wheel23.png")
        Me.WheelImages.Images.SetKeyName(23, "wheel24.png")
        Me.WheelImages.Images.SetKeyName(24, "Wheel25.png")
        '
        'picWheel
        '
        Me.picWheel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picWheel.Image = Global.Wheel_of_Fortune_Capstone_Project.My.Resources.Resources.wheel1
        Me.picWheel.Location = New System.Drawing.Point(12, 42)
        Me.picWheel.Name = "picWheel"
        Me.picWheel.Size = New System.Drawing.Size(599, 582)
        Me.picWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWheel.TabIndex = 0
        Me.picWheel.TabStop = False
        '
        'btnSpin
        '
        Me.btnSpin.Location = New System.Drawing.Point(858, 240)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(75, 23)
        Me.btnSpin.TabIndex = 1
        Me.btnSpin.Text = "&Spin"
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label1.Location = New System.Drawing.Point(258, 61)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "10K"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label2.Location = New System.Drawing.Point(314, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "BANKRUPT"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label3.Location = New System.Drawing.Point(174, 90)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "BANKRUPT"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label4.Location = New System.Drawing.Point(41, 283)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "2K"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label5.Location = New System.Drawing.Point(392, 83)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "1K"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label6.Location = New System.Drawing.Point(448, 114)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "1K"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label7.Location = New System.Drawing.Point(496, 169)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "2K"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label8.Location = New System.Drawing.Point(533, 223)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "1K"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label9.Location = New System.Drawing.Point(99, 169)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 20)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "1K"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label10.Location = New System.Drawing.Point(141, 114)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 20)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "1K"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label11.Location = New System.Drawing.Point(60, 223)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 20)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "2K"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label12.Location = New System.Drawing.Point(41, 347)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 20)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "1K"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label13.Location = New System.Drawing.Point(86, 462)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 20)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "5K"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label14.Location = New System.Drawing.Point(41, 406)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 20)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "SKIP"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label15.Location = New System.Drawing.Point(122, 508)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 20)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "SKIP"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label16.Location = New System.Drawing.Point(300, 588)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 20)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "1K"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label17.Location = New System.Drawing.Point(173, 553)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 20)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "1K"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label18.Location = New System.Drawing.Point(242, 575)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 20)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "2K"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label19.Location = New System.Drawing.Point(360, 575)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 20)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "SKIP"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label20.Location = New System.Drawing.Point(418, 553)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(30, 20)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "2K"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label21.Location = New System.Drawing.Point(511, 477)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(30, 20)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "1K"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label22.Location = New System.Drawing.Point(469, 525)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(30, 20)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "1K"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label23.Location = New System.Drawing.Point(533, 406)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(49, 20)
        Me.Label23.TabIndex = 24
        Me.Label23.Text = "SKIP"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label24.Location = New System.Drawing.Point(533, 283)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(49, 20)
        Me.Label24.TabIndex = 25
        Me.Label24.Text = "SKIP"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label25.Location = New System.Drawing.Point(552, 347)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(30, 20)
        Me.Label25.TabIndex = 26
        Me.Label25.Text = "5K"
        '
        'txtPlay1Guess
        '
        Me.txtPlay1Guess.Location = New System.Drawing.Point(617, 464)
        Me.txtPlay1Guess.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPlay1Guess.MaxLength = 1
        Me.txtPlay1Guess.Name = "txtPlay1Guess"
        Me.txtPlay1Guess.Size = New System.Drawing.Size(76, 20)
        Me.txtPlay1Guess.TabIndex = 27
        Me.txtPlay1Guess.Visible = False
        '
        'lblRandWord
        '
        Me.lblRandWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRandWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRandWord.Location = New System.Drawing.Point(763, 42)
        Me.lblRandWord.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRandWord.Name = "lblRandWord"
        Me.lblRandWord.Size = New System.Drawing.Size(310, 105)
        Me.lblRandWord.TabIndex = 29
        Me.lblRandWord.Text = "Random Word"
        Me.lblRandWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstRandWords
        '
        Me.lstRandWords.FormattingEnabled = True
        Me.lstRandWords.Location = New System.Drawing.Point(617, 529)
        Me.lstRandWords.Name = "lstRandWords"
        Me.lstRandWords.Size = New System.Drawing.Size(120, 95)
        Me.lstRandWords.TabIndex = 30
        Me.lstRandWords.Visible = False
        '
        'btnGuess
        '
        Me.btnGuess.Location = New System.Drawing.Point(620, 488)
        Me.btnGuess.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(56, 19)
        Me.btnGuess.TabIndex = 31
        Me.btnGuess.Text = "&Guess"
        Me.btnGuess.UseVisualStyleBackColor = True
        Me.btnGuess.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1453, 24)
        Me.MenuStrip1.TabIndex = 32
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuLoad})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'menuLoad
        '
        Me.menuLoad.Name = "menuLoad"
        Me.menuLoad.Size = New System.Drawing.Size(100, 22)
        Me.menuLoad.Text = "Load"
        '
        'btnA
        '
        Me.btnA.Enabled = False
        Me.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnA.Location = New System.Drawing.Point(7, 26)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(27, 23)
        Me.btnA.TabIndex = 33
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnU
        '
        Me.btnU.Enabled = False
        Me.btnU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnU.Location = New System.Drawing.Point(74, 85)
        Me.btnU.Name = "btnU"
        Me.btnU.Size = New System.Drawing.Size(27, 23)
        Me.btnU.TabIndex = 34
        Me.btnU.Text = "U"
        Me.btnU.UseVisualStyleBackColor = True
        '
        'btnT
        '
        Me.btnT.Enabled = False
        Me.btnT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnT.Location = New System.Drawing.Point(41, 85)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(27, 23)
        Me.btnT.TabIndex = 35
        Me.btnT.Text = "T"
        Me.btnT.UseVisualStyleBackColor = True
        '
        'btnS
        '
        Me.btnS.Enabled = False
        Me.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnS.Location = New System.Drawing.Point(8, 85)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(27, 23)
        Me.btnS.TabIndex = 36
        Me.btnS.Text = "S"
        Me.btnS.UseVisualStyleBackColor = True
        '
        'btnR
        '
        Me.btnR.Enabled = False
        Me.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnR.Location = New System.Drawing.Point(272, 55)
        Me.btnR.Name = "btnR"
        Me.btnR.Size = New System.Drawing.Size(27, 23)
        Me.btnR.TabIndex = 37
        Me.btnR.Text = "R"
        Me.btnR.UseVisualStyleBackColor = True
        '
        'btnQ
        '
        Me.btnQ.Enabled = False
        Me.btnQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQ.Location = New System.Drawing.Point(239, 55)
        Me.btnQ.Name = "btnQ"
        Me.btnQ.Size = New System.Drawing.Size(27, 23)
        Me.btnQ.TabIndex = 38
        Me.btnQ.Text = "Q"
        Me.btnQ.UseVisualStyleBackColor = True
        '
        'btnP
        '
        Me.btnP.Enabled = False
        Me.btnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnP.Location = New System.Drawing.Point(206, 55)
        Me.btnP.Name = "btnP"
        Me.btnP.Size = New System.Drawing.Size(27, 23)
        Me.btnP.TabIndex = 39
        Me.btnP.Text = "P"
        Me.btnP.UseVisualStyleBackColor = True
        '
        'btnO
        '
        Me.btnO.Enabled = False
        Me.btnO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnO.Location = New System.Drawing.Point(173, 55)
        Me.btnO.Name = "btnO"
        Me.btnO.Size = New System.Drawing.Size(27, 23)
        Me.btnO.TabIndex = 40
        Me.btnO.Text = "O"
        Me.btnO.UseVisualStyleBackColor = True
        '
        'btnN
        '
        Me.btnN.Enabled = False
        Me.btnN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnN.Location = New System.Drawing.Point(140, 55)
        Me.btnN.Name = "btnN"
        Me.btnN.Size = New System.Drawing.Size(27, 23)
        Me.btnN.TabIndex = 41
        Me.btnN.Text = "N"
        Me.btnN.UseVisualStyleBackColor = True
        '
        'btnM
        '
        Me.btnM.Enabled = False
        Me.btnM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnM.Location = New System.Drawing.Point(107, 55)
        Me.btnM.Name = "btnM"
        Me.btnM.Size = New System.Drawing.Size(27, 23)
        Me.btnM.TabIndex = 42
        Me.btnM.Text = "M"
        Me.btnM.UseVisualStyleBackColor = True
        '
        'btnL
        '
        Me.btnL.Enabled = False
        Me.btnL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnL.Location = New System.Drawing.Point(74, 55)
        Me.btnL.Name = "btnL"
        Me.btnL.Size = New System.Drawing.Size(27, 23)
        Me.btnL.TabIndex = 43
        Me.btnL.Text = "L"
        Me.btnL.UseVisualStyleBackColor = True
        '
        'btnK
        '
        Me.btnK.Enabled = False
        Me.btnK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnK.Location = New System.Drawing.Point(41, 55)
        Me.btnK.Name = "btnK"
        Me.btnK.Size = New System.Drawing.Size(27, 23)
        Me.btnK.TabIndex = 44
        Me.btnK.Text = "K"
        Me.btnK.UseVisualStyleBackColor = True
        '
        'btnJ
        '
        Me.btnJ.Enabled = False
        Me.btnJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJ.Location = New System.Drawing.Point(8, 55)
        Me.btnJ.Name = "btnJ"
        Me.btnJ.Size = New System.Drawing.Size(27, 23)
        Me.btnJ.TabIndex = 45
        Me.btnJ.Text = "J"
        Me.btnJ.UseVisualStyleBackColor = True
        '
        'btnI
        '
        Me.btnI.Enabled = False
        Me.btnI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnI.Location = New System.Drawing.Point(272, 26)
        Me.btnI.Name = "btnI"
        Me.btnI.Size = New System.Drawing.Size(27, 23)
        Me.btnI.TabIndex = 46
        Me.btnI.Text = "I"
        Me.btnI.UseVisualStyleBackColor = True
        '
        'btnH
        '
        Me.btnH.Enabled = False
        Me.btnH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnH.Location = New System.Drawing.Point(239, 26)
        Me.btnH.Name = "btnH"
        Me.btnH.Size = New System.Drawing.Size(27, 23)
        Me.btnH.TabIndex = 47
        Me.btnH.Text = "H"
        Me.btnH.UseVisualStyleBackColor = True
        '
        'btnG
        '
        Me.btnG.Enabled = False
        Me.btnG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnG.Location = New System.Drawing.Point(206, 26)
        Me.btnG.Name = "btnG"
        Me.btnG.Size = New System.Drawing.Size(27, 23)
        Me.btnG.TabIndex = 48
        Me.btnG.Text = "G"
        Me.btnG.UseVisualStyleBackColor = True
        '
        'btnF
        '
        Me.btnF.Enabled = False
        Me.btnF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF.Location = New System.Drawing.Point(173, 26)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(27, 23)
        Me.btnF.TabIndex = 49
        Me.btnF.Text = "F"
        Me.btnF.UseVisualStyleBackColor = True
        '
        'btnE
        '
        Me.btnE.Enabled = False
        Me.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnE.Location = New System.Drawing.Point(140, 26)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(27, 23)
        Me.btnE.TabIndex = 50
        Me.btnE.Text = "E"
        Me.btnE.UseVisualStyleBackColor = True
        '
        'btnD
        '
        Me.btnD.Enabled = False
        Me.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnD.Location = New System.Drawing.Point(107, 26)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(27, 23)
        Me.btnD.TabIndex = 51
        Me.btnD.Text = "D"
        Me.btnD.UseVisualStyleBackColor = True
        '
        'btnC
        '
        Me.btnC.Enabled = False
        Me.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnC.Location = New System.Drawing.Point(74, 26)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(27, 23)
        Me.btnC.TabIndex = 52
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.Enabled = False
        Me.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnB.Location = New System.Drawing.Point(41, 26)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(27, 23)
        Me.btnB.TabIndex = 53
        Me.btnB.Text = "B"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'btnX
        '
        Me.btnX.Enabled = False
        Me.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnX.Location = New System.Drawing.Point(173, 85)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(27, 23)
        Me.btnX.TabIndex = 54
        Me.btnX.Text = "X"
        Me.btnX.UseVisualStyleBackColor = True
        '
        'btnW
        '
        Me.btnW.Enabled = False
        Me.btnW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnW.Location = New System.Drawing.Point(140, 85)
        Me.btnW.Name = "btnW"
        Me.btnW.Size = New System.Drawing.Size(27, 23)
        Me.btnW.TabIndex = 55
        Me.btnW.Text = "W"
        Me.btnW.UseVisualStyleBackColor = True
        '
        'btnV
        '
        Me.btnV.Enabled = False
        Me.btnV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnV.Location = New System.Drawing.Point(107, 85)
        Me.btnV.Name = "btnV"
        Me.btnV.Size = New System.Drawing.Size(27, 23)
        Me.btnV.TabIndex = 56
        Me.btnV.Text = "V"
        Me.btnV.UseVisualStyleBackColor = True
        '
        'btnZ
        '
        Me.btnZ.Enabled = False
        Me.btnZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZ.Location = New System.Drawing.Point(239, 85)
        Me.btnZ.Name = "btnZ"
        Me.btnZ.Size = New System.Drawing.Size(27, 23)
        Me.btnZ.TabIndex = 57
        Me.btnZ.Text = "Z"
        Me.btnZ.UseVisualStyleBackColor = True
        '
        'btnY
        '
        Me.btnY.Enabled = False
        Me.btnY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnY.Location = New System.Drawing.Point(206, 85)
        Me.btnY.Name = "btnY"
        Me.btnY.Size = New System.Drawing.Size(27, 23)
        Me.btnY.TabIndex = 58
        Me.btnY.Text = "Y"
        Me.btnY.UseVisualStyleBackColor = True
        '
        'grpLetters
        '
        Me.grpLetters.Controls.Add(Me.btnR)
        Me.grpLetters.Controls.Add(Me.btnY)
        Me.grpLetters.Controls.Add(Me.btnA)
        Me.grpLetters.Controls.Add(Me.btnZ)
        Me.grpLetters.Controls.Add(Me.btnU)
        Me.grpLetters.Controls.Add(Me.btnV)
        Me.grpLetters.Controls.Add(Me.btnT)
        Me.grpLetters.Controls.Add(Me.btnW)
        Me.grpLetters.Controls.Add(Me.btnS)
        Me.grpLetters.Controls.Add(Me.btnX)
        Me.grpLetters.Controls.Add(Me.btnQ)
        Me.grpLetters.Controls.Add(Me.btnB)
        Me.grpLetters.Controls.Add(Me.btnP)
        Me.grpLetters.Controls.Add(Me.btnC)
        Me.grpLetters.Controls.Add(Me.btnO)
        Me.grpLetters.Controls.Add(Me.btnD)
        Me.grpLetters.Controls.Add(Me.btnN)
        Me.grpLetters.Controls.Add(Me.btnE)
        Me.grpLetters.Controls.Add(Me.btnM)
        Me.grpLetters.Controls.Add(Me.btnF)
        Me.grpLetters.Controls.Add(Me.btnL)
        Me.grpLetters.Controls.Add(Me.btnG)
        Me.grpLetters.Controls.Add(Me.btnK)
        Me.grpLetters.Controls.Add(Me.btnH)
        Me.grpLetters.Controls.Add(Me.btnJ)
        Me.grpLetters.Controls.Add(Me.btnI)
        Me.grpLetters.Location = New System.Drawing.Point(784, 317)
        Me.grpLetters.Name = "grpLetters"
        Me.grpLetters.Size = New System.Drawing.Size(309, 121)
        Me.grpLetters.TabIndex = 59
        Me.grpLetters.TabStop = False
        Me.grpLetters.Text = "Guess a Letter"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1453, 689)
        Me.Controls.Add(Me.grpLetters)
        Me.Controls.Add(Me.btnGuess)
        Me.Controls.Add(Me.lstRandWords)
        Me.Controls.Add(Me.lblRandWord)
        Me.Controls.Add(Me.txtPlay1Guess)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSpin)
        Me.Controls.Add(Me.picWheel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Wheel of Fortune"
        CType(Me.picWheel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpLetters.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WheelImages As ImageList
    Friend WithEvents picWheel As PictureBox
    Friend WithEvents btnSpin As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtPlay1Guess As TextBox
    Friend WithEvents lblRandWord As Label
    Friend WithEvents lstRandWords As ListBox
    Friend WithEvents btnGuess As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuLoad As ToolStripMenuItem
    Friend WithEvents btnA As Button
    Friend WithEvents btnU As Button
    Friend WithEvents btnT As Button
    Friend WithEvents btnS As Button
    Friend WithEvents btnR As Button
    Friend WithEvents btnQ As Button
    Friend WithEvents btnP As Button
    Friend WithEvents btnO As Button
    Friend WithEvents btnN As Button
    Friend WithEvents btnM As Button
    Friend WithEvents btnL As Button
    Friend WithEvents btnK As Button
    Friend WithEvents btnJ As Button
    Friend WithEvents btnI As Button
    Friend WithEvents btnH As Button
    Friend WithEvents btnG As Button
    Friend WithEvents btnF As Button
    Friend WithEvents btnE As Button
    Friend WithEvents btnD As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnX As Button
    Friend WithEvents btnW As Button
    Friend WithEvents btnV As Button
    Friend WithEvents btnZ As Button
    Friend WithEvents btnY As Button
    Friend WithEvents grpLetters As GroupBox
End Class
