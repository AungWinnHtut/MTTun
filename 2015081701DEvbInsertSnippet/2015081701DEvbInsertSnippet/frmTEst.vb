Imports System.IO
Public Class frmTEst
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists("d:\test.txt")

        If fileExists Then

            Dim fileSize As Long
            fileSize = My.Computer.FileSystem.GetFileInfo("d:\test.txt").Length
            Dim fileContents As String
            fileContents = My.Computer.FileSystem.ReadAllText("d:\test.txt")
            txtTest.Text = "file exists " + "file size is " + fileSize.ToString() + " " + fileContents
        Else
            txtTest.Text = "file does not exists"
        End If

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog <> DialogResult.Cancel Then
            Dim sr As StreamReader = New StreamReader(OpenFileDialog1.FileName)
            txtTest.Text = sr.ReadToEnd()
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            MessageBox.Show("enter key")
        ElseIf e.KeyCode = Keys.Escape Then
            MessageBox.Show("esc key")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim r As Double = 0.0
        Dim a As Double = 0.0
        r = Double.Parse(TextBox1.Text)
        a = 3.14 * r * r
        TextBox2.Text = a.ToString()
    End Sub

    Private Sub txtFname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFname.KeyDown
        Dim sFname As String

        If e.KeyCode = Keys.Enter Then
            sFname = txtFname.Text.ToString()
            If File.Exists(sFname) Then
                txtTest.Text = txtTest.Text.ToString() + "file exists" + vbCrLf
            Else
                txtTest.Text = txtTest.Text.ToString() + "file does not exists " + vbCrLf
                If Directory.Exists(sFname) Then
                    txtTest.Text = txtTest.Text.ToString() + "this is a folder"
                Else
                    txtTest.Text = txtTest.Text.ToString() + "this is not a folder too"
                End If
            End If
        End If
    End Sub

    Private Sub txtTest_TextChanged(sender As Object, e As EventArgs) Handles txtTest.TextChanged

    End Sub
End Class
