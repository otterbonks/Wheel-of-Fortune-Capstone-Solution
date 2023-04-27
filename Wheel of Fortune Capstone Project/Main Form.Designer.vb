<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.WheelImages = New System.Windows.Forms.ImageList(Me.components)
        Me.picWheel = New System.Windows.Forms.PictureBox()
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.picWheel.Location = New System.Drawing.Point(629, 213)
        Me.picWheel.Margin = New System.Windows.Forms.Padding(4)
        Me.picWheel.Name = "picWheel"
        Me.picWheel.Size = New System.Drawing.Size(667, 615)
        Me.picWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWheel.TabIndex = 0
        Me.picWheel.TabStop = False
        '
        'btnSpin
        '
        Me.btnSpin.Location = New System.Drawing.Point(456, 335)
        Me.btnSpin.Margin = New System.Windows.Forms.Padding(4)
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
        Me.Label1.Location = New System.Drawing.Point(507, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1040)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSpin)
        Me.Controls.Add(Me.picWheel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.Text = "Wheel of Fortune"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picWheel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WheelImages As ImageList
    Friend WithEvents picWheel As PictureBox
    Friend WithEvents btnSpin As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class
