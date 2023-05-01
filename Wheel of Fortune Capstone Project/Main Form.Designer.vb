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
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.lblRandWord = New System.Windows.Forms.Label()
        CType(Me.picWheel, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.picWheel.Location = New System.Drawing.Point(352, 5)
        Me.picWheel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picWheel.Name = "picWheel"
        Me.picWheel.Size = New System.Drawing.Size(800, 738)
        Me.picWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWheel.TabIndex = 0
        Me.picWheel.TabStop = False
        '
        'btnSpin
        '
        Me.btnSpin.Location = New System.Drawing.Point(165, 268)
        Me.btnSpin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(100, 28)
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
        Me.Label1.Location = New System.Drawing.Point(681, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "10K"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label2.Location = New System.Drawing.Point(756, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "BANKRUPT"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label3.Location = New System.Drawing.Point(569, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "BANKRUPT"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label4.Location = New System.Drawing.Point(392, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "2K"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label5.Location = New System.Drawing.Point(860, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "1K"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label6.Location = New System.Drawing.Point(935, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "1K"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label7.Location = New System.Drawing.Point(999, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 25)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "2K"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label8.Location = New System.Drawing.Point(1048, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 25)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "1K"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label9.Location = New System.Drawing.Point(469, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 25)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "1K"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label10.Location = New System.Drawing.Point(525, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 25)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "1K"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label11.Location = New System.Drawing.Point(417, 231)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 25)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "2K"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label12.Location = New System.Drawing.Point(392, 384)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 25)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "1K"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label13.Location = New System.Drawing.Point(452, 526)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 25)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "5K"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label14.Location = New System.Drawing.Point(392, 457)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 25)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "SKIP"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label15.Location = New System.Drawing.Point(500, 582)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 25)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "SKIP"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label16.Location = New System.Drawing.Point(739, 677)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 25)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "1K"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label17.Location = New System.Drawing.Point(568, 638)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 25)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "1K"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label18.Location = New System.Drawing.Point(647, 665)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 25)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "2K"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label19.Location = New System.Drawing.Point(804, 665)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 25)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "SKIP"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label20.Location = New System.Drawing.Point(895, 638)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(39, 25)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "2K"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label21.Location = New System.Drawing.Point(1019, 544)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(39, 25)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "1K"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label22.Location = New System.Drawing.Point(963, 603)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(39, 25)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "1K"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label23.Location = New System.Drawing.Point(1048, 457)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(62, 25)
        Me.Label23.TabIndex = 24
        Me.Label23.Text = "SKIP"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label24.Location = New System.Drawing.Point(1048, 305)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 25)
        Me.Label24.TabIndex = 25
        Me.Label24.Text = "SKIP"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label25.Location = New System.Drawing.Point(1073, 384)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(39, 25)
        Me.Label25.TabIndex = 26
        Me.Label25.Text = "5K"
        '
        'txtPlay1Guess
        '
        Me.txtPlay1Guess.Location = New System.Drawing.Point(141, 99)
        Me.txtPlay1Guess.Name = "txtPlay1Guess"
        Me.txtPlay1Guess.Size = New System.Drawing.Size(100, 22)
        Me.txtPlay1Guess.TabIndex = 27
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(70, 59)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 28
        Me.btnLoad.Text = "&Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'lblRandWord
        '
        Me.lblRandWord.AutoSize = True
        Me.lblRandWord.Location = New System.Drawing.Point(97, 182)
        Me.lblRandWord.Name = "lblRandWord"
        Me.lblRandWord.Size = New System.Drawing.Size(95, 16)
        Me.lblRandWord.TabIndex = 29
        Me.lblRandWord.Text = "Random Word"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1371, 750)
        Me.Controls.Add(Me.lblRandWord)
        Me.Controls.Add(Me.btnLoad)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMain"
        Me.Text = "Wheel of Fortune"
        CType(Me.picWheel, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnLoad As Button
    Friend WithEvents lblRandWord As Label
End Class
