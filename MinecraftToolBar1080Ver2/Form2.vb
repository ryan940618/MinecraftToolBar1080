Public Class Form2
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Location = New System.Drawing.Point(1730, 1000)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Form1.CheckBox1.Checked = True
            Form1.TopMost = True
            Me.Hide()
            Form3.Hide()
        End If
    End Sub
End Class
