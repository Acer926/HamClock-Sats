Imports System.IO
Imports System.Net


Public Class FrmHamClockeSats

    Const Moon1 As String = "1     1U     1A   26034.68546296  .00000000  00000-0  0000000 0  0016"
    Const Moon2 As String = "2     1  27.9862  -3.7664 0362000  88.2926  68.6200  0.03660000    18"

    Private ReadOnly _checkEvery As TimeSpan = TimeSpan.FromMinutes(15)  ' sets timer in minutes
    Private ReadOnly _maxAge As TimeSpan = TimeSpan.FromHours(2.5) ' 2h 30m (buffer before HamClock freaks)
    Private _updateRunning As Boolean = False
    Public url As String
    Public dest As String

    Public eSatAge As String



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cfg As String = Application.StartupPath & "\config.txt"
        LblDebug.Text = ""

        Dim lines() As String = {
        TextBox1.Text,
        TextBox2.Text
    }

        File.WriteAllLines(cfg, lines)

        MessageBox.Show("Saved.")


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'on first install the config file is not correct 
        'the text boxes are hard code defaults 

        'the user needs to update them and press the save button 

        NotifyIcon1.Icon = Me.Icon


        'NotifyIcon1.Icon = SystemIcons.Information

        NotifyIcon1.ContextMenuStrip = ContextMenuStrip1

        ' read in the config file to get our 2 file locations 
        Dim cfg As String = Application.StartupPath & "\config.txt"
        If File.Exists(cfg) Then
            Dim lines() As String = File.ReadAllLines(cfg)
            If lines.Length > 0 Then TextBox1.Text = lines(0)
            If lines.Length > 1 Then TextBox2.Text = lines(1)
        End If


        ' url = TextBox1.Text.Trim()
        'dest = TextBox2.Text.Trim() ' Ubuntu hamclock folder

        Timer1.Interval = CInt(_checkEvery.TotalMilliseconds)
        'Timer1.Start()

        ' now we will wait till the user presses the manual download and start button
        'button2 click

        'we wont need auto start in case used has hard time setting the path to the download folder
        ' optional: do a check immediately on startup
        'CheckAndUpdateEsats()




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'this sub will be the start of the timing process and download event
        'the button can also be use as a manual update if needed

        ' download the new TLE data from Amsat ..  
        ' and overwrite the old one .. 
        ' path and all is in TextBox2.Text

        url = TextBox1.Text.Trim()
        dest = TextBox2.Text.Trim() ' Ubuntu hamclock folder

        'we check here incase the user blanks out the 2 textbox fields .. 

        Try
            If url = "" Then
                MessageBox.Show("URL is blank.")
                LblDebug.Text = "You have a blank url to the sat Tle xxxxx.txt file"
                Exit Sub
            End If

            If dest = "" Then
                MessageBox.Show("Destination path is blank.")
                LblDebug.Text = "You have a blank path to HamClocks sSats.txt file"
                Exit Sub
            End If

            ' Make sure destination folder exists
            Dim folder As String = Path.GetDirectoryName(dest)
            If folder Is Nothing OrElse folder = "" OrElse Not Directory.Exists(folder) Then
                MessageBox.Show("Destination folder not found:" & vbCrLf & folder)
                LblDebug.Text = "You have path problem to HamClocks sSats.txt file location"
                Exit Sub
            End If

            ' Download and rebuild esats.txt by reading in eSat-list.txt located in \bin\degug 

            ' 1) download full AMSAT TLE text into memory
            Dim tleText As String = ""

            Using wc As New WebClient()
                tleText = wc.DownloadString(url)
            End Using

            ' 2) load your sat name list (the file in your screenshot)
            Dim satListPath As String = Application.StartupPath & "\eSat-list.txt"

            If Not File.Exists(satListPath) Then
                MessageBox.Show("Missing sat list file:" & vbCrLf & satListPath)
                LblDebug.Text = "Somehow you deleted the list of Sats in the programs folder"
                Exit Sub
            End If

            Dim wantedSats() As String = File.ReadAllLines(satListPath)


            ' 3) break AMSAT TLE file into blocks: Name / Line1 / Line2
            Dim lines() As String = tleText.Replace(vbCrLf, vbLf).Split(vbLf)

            Dim dict As New Dictionary(Of String, Tuple(Of String, String))

            Dim i As Integer = 0
            While i < lines.Length - 2

                Dim name As String = lines(i).Trim()

                If name <> "" AndAlso lines(i + 1).StartsWith("1 ") AndAlso lines(i + 2).StartsWith("2 ") Then
                    dict(name.ToUpper()) =
            New Tuple(Of String, String)(lines(i + 1), lines(i + 2))

                    i += 3
                Else
                    i += 1
                End If

            End While


            ' 4) build NEW esats.txt using ONLY sats from your list
            Dim outLines As New List(Of String)

            For Each satName In wantedSats

                Dim key As String = satName.Trim().ToUpper()

                If dict.ContainsKey(key) Then
                    outLines.Add(satName)
                    outLines.Add(dict(key).Item1)
                    outLines.Add(dict(key).Item2)
                End If

            Next


            ' 5) always add Moon block manually
            outLines.Add("Moon")
            outLines.Add(Moon1)
            outLines.Add(Moon2)


            ' 6) write final esats.txt to HamClock location
            File.WriteAllLines(dest, outLines.ToArray())

            ' success
            ' MessageBox.Show("Updated:" & vbCrLf & dest)
            LblDebug.Text = "Last Update Success @  " & Now.ToString("yyyy-MM-dd  HH:mm:ss") & "   " & dest

            Dim age As TimeSpan = DateTime.Now - File.GetLastWriteTime(dest)

            eSatAge = "Sat File Age is " & age.ToString("hh\hmm\mss\s")

            LblSatAge.Text = eSatAge

            If Not Timer1.Enabled Then
                Timer1.Start()
                LblRunning.Text = "Timer On"
            Else

            End If


        Catch ex As system.Exception
            'MessageBox.Show("Download failed:" & vbCrLf & ex.Message)
            Me.Text = "HamClock-eSats Fixer    Last Update NOT Successful  " & Now.ToString("yyyy-MM-dd HH:mm:ss") & "     " & dest


        End Try


    End Sub

    Private Sub CheckAndUpdateEsats()

        On Error Resume Next

        Dim age As TimeSpan = DateTime.Now - File.GetLastWriteTime(dest)

        eSatAge = "Sat File Age is " & age.ToString("hh\hmm\mss\s")

        LblSatAge.Text = eSatAge

        ' If age.TotalMinutes > 2 Then
        ' Beep()
        ' End If

        If age.TotalHours >= 2.5 Then
            Button2_Click(Nothing, EventArgs.Empty)
        End If

        On Error GoTo 0

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        CheckAndUpdateEsats()

    End Sub

    Private Sub FrmHamClockeSats_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        NotifyIcon1.Visible = False
        NotifyIcon1.Dispose()
    End Sub


    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        ' NotifyIcon1.Visible = False
        Me.ShowInTaskbar = True
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.Activate()
    End Sub

    Private Sub FrmHamClockeSats_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.ShowInTaskbar = False
            Me.Hide()
            NotifyIcon1.Visible = True
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) _
    Handles ToolStripMenuItem2.Click

        NotifyIcon1.Visible = False
        Application.Exit()

    End Sub


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) _
    Handles ToolStripMenuItem1.Click

        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.Activate()

    End Sub







End Class
