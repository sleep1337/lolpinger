

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Timer1.Start()

            


    End Sub

    Public Shared Function GetPingMs(ByRef hostNameOrAddress As String)
        Dim ping As New System.Net.NetworkInformation.Ping
        Return ping.Send(hostNameOrAddress).RoundtripTime
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer2.Start()

        Dim EUW = LogInCheckBox1.Checked
        Dim EUNE = LogInCheckBox2.Checked
        Dim NA = LogInCheckBox3.Checked
        Dim LAN = LogInCheckBox4.Checked



        If EUW = True Then






            Try
                Dim EUWPING As Integer = GetPingMs("104.160.141.3")
                LogInRadialProgressBar1.Value = EUWPING
                LogInStatusBar1.Text = ("Pinging EUW...")


                If EUWPING >= 25 Then
                    LogInRadialProgressBar1.ProgressColour = Color.LightGreen

                End If
                If EUWPING >= 45 Then
                    LogInRadialProgressBar1.ProgressColour = Color.DarkGreen

                End If
                If EUWPING >= 65 Then
                    LogInRadialProgressBar1.ProgressColour = Color.Orange

                End If
                If EUWPING >= 125 Then
                    LogInRadialProgressBar1.ProgressColour = Color.OrangeRed


                End If



                If EUWPING >= 200 Then
                    LogInRadialProgressBar1.ProgressColour = Color.Red

                End If
            Catch ex As Exception

            End Try


        End If
        If EUNE = True Then

            Try
                Dim EUNEPING As Integer = GetPingMs("104.160.142.3")
                LogInRadialProgressBar1.Value = EUNEPING
                LogInStatusBar1.Text = ("Pinging EUNE...")
                If EUNEPING >= 25 Then
                    LogInRadialProgressBar1.ProgressColour = Color.LightGreen

                End If
                If EUNEPING >= 45 Then
                    LogInRadialProgressBar1.ProgressColour = Color.DarkGreen

                End If
                If EUNEPING >= 65 Then
                    LogInRadialProgressBar1.ProgressColour = Color.Orange

                End If
                If EUNEPING >= 150 Then
                    LogInRadialProgressBar1.ProgressColour = Color.OrangeRed


                End If



                If EUNEPING >= 200 Then
                    LogInRadialProgressBar1.ProgressColour = Color.Red

                End If
            Catch ex As Exception

            End Try
        End If

        If NA = True Then

            Try
                Dim NAPING As Integer = GetPingMs("104.160.131.3")
                LogInRadialProgressBar1.Value = NAPING
                LogInStatusBar1.Text = ("Pinging NA...")
                If NAPING >= 25 Then
                    LogInRadialProgressBar1.ProgressColour = Color.LightGreen

                End If
                If NAPING >= 45 Then
                    LogInRadialProgressBar1.ProgressColour = Color.DarkGreen

                End If
                If NAPING >= 65 Then
                    LogInRadialProgressBar1.ProgressColour = Color.Orange

                End If
                If NAPING >= 125 Then
                    LogInRadialProgressBar1.ProgressColour = Color.OrangeRed


                End If



                If NAPING >= 200 Then
                    LogInRadialProgressBar1.ProgressColour = Color.Red

                End If
            Catch ex As Exception

            End Try
        End If

        If LAN = True Then
            Try
                Dim LANPING As Integer = GetPingMs("104.160.125.3")
                LogInRadialProgressBar1.Value = LANPING
                LogInStatusBar1.Text = ("Pinging LAN...")

                If LANPING >= 25 Then
                    LogInRadialProgressBar1.ProgressColour = Color.LightGreen

                End If
                If LANPING >= 45 Then
                    LogInRadialProgressBar1.ProgressColour = Color.DarkGreen

                End If
                If LANPING >= 65 Then
                    LogInRadialProgressBar1.ProgressColour = Color.Orange

                End If
                If LANPING >= 125 Then
                    LogInRadialProgressBar1.ProgressColour = Color.OrangeRed


                End If



                If LANPING >= 200 Then
                    LogInRadialProgressBar1.ProgressColour = Color.Red
                End If

            Catch ex As Exception

            End Try

        End If


    End Sub



    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub LogInThemeContainer1_Click(sender As Object, e As EventArgs) Handles LogInThemeContainer1.Click


    End Sub

    Private Sub LogInGroupBox1_Click(sender As Object, e As EventArgs) Handles LogInGroupBox1.Click

    End Sub



    Private Sub LogInStatusBar1_Click(sender As Object, e As EventArgs) Handles LogInStatusBar1.Click


    End Sub

    Private Sub LogInCheckBox1_CheckedChanged(sender As Object) Handles LogInCheckBox1.CheckedChanged

        LogInCheckBox2.Checked = False
        LogInCheckBox3.Checked = False
        LogInCheckBox4.Checked = False
    End Sub

    Private Sub LogInGroupBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LogInCheckBox2_CheckedChanged(sender As Object) Handles LogInCheckBox2.CheckedChanged

        LogInCheckBox1.Checked = False

        LogInCheckBox3.Checked = False
        LogInCheckBox4.Checked = False
    End Sub

    Private Sub LogInCheckBox3_CheckedChanged(sender As Object) Handles LogInCheckBox3.CheckedChanged
        LogInCheckBox1.Checked = False
        LogInCheckBox2.Checked = False

        LogInCheckBox4.Checked = False
    End Sub

    Private Sub LogInCheckBox4_CheckedChanged(sender As Object) Handles LogInCheckBox4.CheckedChanged
        LogInCheckBox1.Checked = False
        LogInCheckBox2.Checked = False
        LogInCheckBox3.Checked = False

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If LogInProgressBar1.Value < 99 Then
            Try
                LogInProgressBar1.Value = LogInProgressBar1.Value + 5
            Catch ex As Exception

            End Try

        Else
            LogInProgressBar1.Value = 0
        End If

    End Sub

    Private Sub LogInRadialProgressBar1_Click(sender As Object, e As EventArgs) Handles LogInRadialProgressBar1.Click

    End Sub

    Private Sub LogInProgressBar1_Click(sender As Object, e As EventArgs) Handles LogInProgressBar1.Click

    End Sub
End Class

