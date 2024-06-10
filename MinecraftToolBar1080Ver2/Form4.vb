Public Class Form4
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Location = New System.Drawing.Point(0, 970)
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label2.Text > 0 Then
            Label2.Text = Label2.Text - 1
        Else
            Me.Hide()
            Dim AllProcesses As Process() = Process.GetProcesses()
            For Each process In AllProcesses
                If process.MainWindowTitle <> "" Then
                    Dim name As String = process.ProcessName
                    If name = "chrome" Then
                        process.CloseMainWindow()
                    End If
                End If
            Next
            Label2.Text = "10"
            Timer1.Stop()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim AllProcesses As Process() = Process.GetProcesses()
        For Each process In AllProcesses
            If process.MainWindowTitle <> "" Then
                Dim name As String = process.ProcessName
                If name = "chrome" Then
                    process.CloseMainWindow()
                End If
            End If
        Next
        Timer1.Stop()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer1.Stop()
        Me.Hide()
    End Sub
End Class