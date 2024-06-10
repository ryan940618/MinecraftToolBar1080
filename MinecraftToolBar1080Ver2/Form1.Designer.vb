<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefaultModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskkillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskkillGTAVexeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskkillDiscordexeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskkillExplorerexeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpecialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartDiscordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PerformanceCounter1 = New System.Diagnostics.PerformanceCounter()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gray
        Me.Button3.Font = New System.Drawing.Font("微軟正黑體", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(1656, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(65, 38)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModesToolStripMenuItem, Me.TaskkillToolStripMenuItem, Me.SpecialToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 70)
        '
        'ModesToolStripMenuItem
        '
        Me.ModesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameModeToolStripMenuItem, Me.DefaultModeToolStripMenuItem})
        Me.ModesToolStripMenuItem.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ModesToolStripMenuItem.Name = "ModesToolStripMenuItem"
        Me.ModesToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ModesToolStripMenuItem.Text = "Modes"
        '
        'GameModeToolStripMenuItem
        '
        Me.GameModeToolStripMenuItem.Name = "GameModeToolStripMenuItem"
        Me.GameModeToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.GameModeToolStripMenuItem.Text = "Game Mode"
        '
        'DefaultModeToolStripMenuItem
        '
        Me.DefaultModeToolStripMenuItem.Name = "DefaultModeToolStripMenuItem"
        Me.DefaultModeToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.DefaultModeToolStripMenuItem.Text = "Default Mode"
        '
        'TaskkillToolStripMenuItem
        '
        Me.TaskkillToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TaskkillGTAVexeToolStripMenuItem, Me.TaskkillDiscordexeToolStripMenuItem, Me.TaskkillExplorerexeToolStripMenuItem})
        Me.TaskkillToolStripMenuItem.Name = "TaskkillToolStripMenuItem"
        Me.TaskkillToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.TaskkillToolStripMenuItem.Text = "Taskkill"
        '
        'TaskkillGTAVexeToolStripMenuItem
        '
        Me.TaskkillGTAVexeToolStripMenuItem.Name = "TaskkillGTAVexeToolStripMenuItem"
        Me.TaskkillGTAVexeToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.TaskkillGTAVexeToolStripMenuItem.Text = "Taskkill GTAV.exe"
        '
        'TaskkillDiscordexeToolStripMenuItem
        '
        Me.TaskkillDiscordexeToolStripMenuItem.Name = "TaskkillDiscordexeToolStripMenuItem"
        Me.TaskkillDiscordexeToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.TaskkillDiscordexeToolStripMenuItem.Text = "Taskkill Discord.exe"
        '
        'TaskkillExplorerexeToolStripMenuItem
        '
        Me.TaskkillExplorerexeToolStripMenuItem.Name = "TaskkillExplorerexeToolStripMenuItem"
        Me.TaskkillExplorerexeToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.TaskkillExplorerexeToolStripMenuItem.Text = "Taskkill Explorer.exe"
        '
        'SpecialToolStripMenuItem
        '
        Me.SpecialToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestartDiscordToolStripMenuItem})
        Me.SpecialToolStripMenuItem.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SpecialToolStripMenuItem.Name = "SpecialToolStripMenuItem"
        Me.SpecialToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.SpecialToolStripMenuItem.Text = "Special"
        '
        'RestartDiscordToolStripMenuItem
        '
        Me.RestartDiscordToolStripMenuItem.Name = "RestartDiscordToolStripMenuItem"
        Me.RestartDiscordToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.RestartDiscordToolStripMenuItem.Text = "Restart Discord"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("微軟正黑體", 15.0!, System.Drawing.FontStyle.Bold)
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(1531, 5)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(119, 29)
        Me.CheckBox1.TabIndex = 22
        Me.CheckBox1.Text = "TopMost"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Button7.Font = New System.Drawing.Font("微軟正黑體", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Image = Global.MinecraftToolBar1080Ver2.My.Resources.Resources.Minecraft
        Me.Button7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button7.Location = New System.Drawing.Point(961, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(136, 38)
        Me.Button7.TabIndex = 21
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("微軟正黑體", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button2.Image = Global.MinecraftToolBar1080Ver2.My.Resources.Resources.Chrome
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(457, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 38)
        Me.Button2.TabIndex = 19
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Button12.Font = New System.Drawing.Font("微軟正黑體", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button12.ForeColor = System.Drawing.Color.White
        Me.Button12.Image = Global.MinecraftToolBar1080Ver2.My.Resources.Resources.Keyboard
        Me.Button12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button12.Location = New System.Drawing.Point(824, 0)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(139, 38)
        Me.Button12.TabIndex = 15
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Button9.Font = New System.Drawing.Font("微軟正黑體", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Image = Global.MinecraftToolBar1080Ver2.My.Resources.Resources.Run
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button9.Location = New System.Drawing.Point(109, 0)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(96, 38)
        Me.Button9.TabIndex = 12
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("微軟正黑體", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Image = Global.MinecraftToolBar1080Ver2.My.Resources.Resources.Notepad
        Me.Button6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button6.Location = New System.Drawing.Point(327, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(132, 38)
        Me.Button6.TabIndex = 9
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("微軟正黑體", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Image = Global.MinecraftToolBar1080Ver2.My.Resources.Resources.Taskmgr
        Me.Button5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button5.Location = New System.Drawing.Point(203, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(126, 38)
        Me.Button5.TabIndex = 8
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("微軟正黑體", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Global.MinecraftToolBar1080Ver2.My.Resources.Resources.Spotify
        Me.Button4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button4.Location = New System.Drawing.Point(-1, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 38)
        Me.Button4.TabIndex = 7
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.MinecraftToolBar1080Ver2.My.Resources.Resources.SndVol
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(710, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 38)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1835, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 18)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "HH:mm:ss"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1823, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 18)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "yyyy/MM/dd"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("微軟正黑體", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Image = Global.MinecraftToolBar1080Ver2.My.Resources.Resources.Discord
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button8.Location = New System.Drawing.Point(1095, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(124, 38)
        Me.Button8.TabIndex = 25
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Button10.Font = New System.Drawing.Font("微軟正黑體", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button10.Image = Global.MinecraftToolBar1080Ver2.My.Resources.Resources.Incognito
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button10.Location = New System.Drawing.Point(582, 0)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(130, 38)
        Me.Button10.TabIndex = 26
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1360, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 18)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "CPU:"
        '
        'BackgroundWorker1
        '
        '
        'PerformanceCounter1
        '
        Me.PerformanceCounter1.CategoryName = "Processor"
        Me.PerformanceCounter1.CounterName = "% Processor Time"
        Me.PerformanceCounter1.InstanceName = "_Total"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1920, 40)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Opacity = 0.8R
        Me.ShowInTaskbar = False
        Me.Text = "Minecraft Tool Bar"
        Me.TopMost = True
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ModesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GameModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DefaultModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PerformanceCounter1 As System.Diagnostics.PerformanceCounter
    Friend WithEvents TaskkillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TaskkillGTAVexeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TaskkillDiscordexeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TaskkillExplorerexeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpecialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartDiscordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
