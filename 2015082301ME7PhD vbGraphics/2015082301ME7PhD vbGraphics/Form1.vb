Public Class Form1
    Dim up1 As Boolean = False
    Dim down1 As Boolean = False
    Dim left1 As Boolean = False
    Dim right1 As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim gr As Graphics = CreateGraphics()
        Dim p As Pen = New Pen(Color.Blue, 10)
        gr.DrawLine(p, 100, 100, 200, 100)
        gr.DrawEllipse(p, 100, 200, 300, 300)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Left
                left1 = True
            Case Keys.Right
                right1 = True
            Case Keys.Up
                up1 = True
            Case Keys.Down
                down1 = True
        End Select
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyValue
            Case Keys.Left
                left1 = False

            Case Keys.Right
                right1 = False

            Case Keys.Up
                up1 = False

            Case Keys.Down
                down1 = False
            Case Keys.Escape
                Button1.Enabled = True

        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If left1 = True Then
            pic.Left = pic.Left - 1
        End If
        If right1 = True Then
            pic.Left = pic.Left + 1
        End If
        If up1 = True Then
            pic.Top = pic.Top - 1
        End If
        If down1 = True Then
            pic.Top = pic.Top + 1
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
    End Sub
End Class
