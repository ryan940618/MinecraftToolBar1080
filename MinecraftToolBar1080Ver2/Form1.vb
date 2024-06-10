Imports System.Threading
Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
        Form2.Hide()
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Location = New System.Drawing.Point(0, 1040)
        Label1.Text = Format(Now, "HH:mm:ss")
        Label2.Text = Format(Now, "yyyy/MM/dd")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Shell("cmd /c ""C:\Users\oem\Downloads\Telegram Desktop\EZBlocker2\EZBlocker2.exe""", vbHide)
        Form4.Show()
        Form4.Timer1.Start()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Shell("c:\windows\system32\rundll32.exe shell32.dll,#61")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Shell("taskmgr")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Shell("notepad")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Shell("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Shell("SndVol", vbNormalFocus)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Shell("cmd /c C:\Users\oem\Desktop\變更鍵盤或其他輸入方法.lnk", vbHide)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub GameModeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GameModeToolStripMenuItem.Click
        Shell("cmd /c ""C:\Users\oem\AppData\Local\Microsoft\Windows\Themes\Game Mode.theme""", vbHide)
        Shell("taskkill /f /im explorer.exe", vbHide)
        Shell("taskkill /f /im IDMan.exe", vbHide)
        Shell("taskkill /f /im PDStyleAgent.exe", vbHide)
        Shell("taskkill /f /im TuneupUI.exe", vbHide)
        Shell("taskkill /f /im ""地牛Wake Up!.exe""", vbHide)
        Shell("taskkill /f /im wuauclt.exe", vbHide)
        Shell("cmd /c C:\Users\oem\Desktop\變更鍵盤或其他輸入方法.lnk", vbHide)
    End Sub

    Private Sub DefaultModeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultModeToolStripMenuItem.Click
        Shell("cmd /c ""C:\Users\oem\AppData\Local\Microsoft\Windows\Themes\Game Mode.theme""", vbHide)
        Shell("C:\Windows\explorer.exe")
        Shell("cmd /c C:\Users\oem\Desktop\變更鍵盤或其他輸入方法.lnk", vbHide)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Shell("cmd /c ""D:\Minecraft Launcher\MinecraftLauncher.exe""", vbHide)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.TopMost = True
        Else
            Form2.CheckBox1.Checked = False
            Form3.Label1.Text = Format(Now, "HH:mm:ss")
            Form3.Label2.Text = Format(Now, "yyyy/MM/dd")
            Form2.Show()
            Form3.Show()
            Me.TopMost = False
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = Format(Now, "HH:mm:ss")
        Label2.Text = Format(Now, "yyyy/MM/dd")
        Form3.Label1.Text = Format(Now, "HH:mm:ss")
        Form3.Label2.Text = Format(Now, "yyyy/MM/dd")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Shell("cmd /c ""C:\Users\oem\AppData\Local\Discord\Update.exe --processStart Discord.exe""", vbHide)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Shell("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe -incognito https://www.google.com/")
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        While True
            Dim val As Decimal = PerformanceCounter1.NextValue
            Thread.Sleep(500)
            val = PerformanceCounter1.NextValue
            If Label3.InvokeRequired = True Then
                Label3.Invoke(Sub() Label3.Text = "CPU:" & val.ToString("N2") & " %")
            Else
                Label3.Text = "CPU:" & val.ToString("N2") & " %"
            End If
        End While
    End Sub

    Private Sub RestartDiscordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartDiscordToolStripMenuItem.Click
        Shell("taskkill /f /im Discord.exe", vbHide)
        Shell("cmd /c ""C:\Users\oem\AppData\Local\Discord\Update.exe --processStart Discord.exe""", vbHide)
    End Sub

    Private Sub TaskkillExplorerexeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaskkillExplorerexeToolStripMenuItem.Click
        Shell("taskkill /f /im Explorer.exe", vbHide)
    End Sub

    Private Sub TaskkillDiscordexeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaskkillDiscordexeToolStripMenuItem.Click
        Shell("taskkill /f /im Discord.exe", vbHide)
    End Sub

    Private Sub TaskkillGTAVexeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaskkillGTAVexeToolStripMenuItem.Click
        Shell("taskkill /f /im GTAV.exe", vbHide)
    End Sub
End Class
