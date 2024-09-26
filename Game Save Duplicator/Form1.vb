Imports System.IO

Public Class Form1
    'Application Variables
    Dim FolBrowsString1 As String = ""
    Dim FolBrowsString2 As String = ""
    Dim NewGameText As String
    Dim directoryTargetLocation As String
    Dim Destinydirectory As String

    'Initial Start of the Application
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Call the Form Load Procedure
            InitStart()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'Load all game data into the Listbox,Target Folder Combobox and Destination Folder Combobox to view them
    Private Sub InitStart()
        Try
            'Clear All items before Updating them with new Data
            ListBox1.Items.Clear()
            ComboBox1.Items.Clear()
            ComboBox2.Items.Clear()

            'Load All new Settings Data for user to view
            ListBox1.Items.Add("Destination Folder: " & My.Settings.DesFol)
            ListBox1.Items.Add(My.Settings.Game1 & " - " & My.Settings.GamePath1)
            ListBox1.Items.Add(My.Settings.Game2 & " - " & My.Settings.GamePath2)
            ListBox1.Items.Add(My.Settings.Game3 & " - " & My.Settings.GamePath3)
            ListBox1.Items.Add(My.Settings.Game4 & " - " & My.Settings.GamePath4)
            ListBox1.Items.Add(My.Settings.Game5 & " - " & My.Settings.GamePath5)
            ListBox1.Items.Add(My.Settings.Game6 & " - " & My.Settings.GamePath6)
            ListBox1.Items.Add(My.Settings.Game7 & " - " & My.Settings.GamePath7)
            ListBox1.Items.Add(My.Settings.Game8 & " - " & My.Settings.GamePath8)
            ListBox1.Items.Add(My.Settings.Game9 & " - " & My.Settings.GamePath9)
            ListBox1.Items.Add(My.Settings.Game10 & " - " & My.Settings.GamePath10)
            ListBox1.Items.Add(My.Settings.Game11 & " - " & My.Settings.GamePath11)
            ListBox1.Items.Add(My.Settings.Game12 & " - " & My.Settings.GamePath12)
            ListBox1.Items.Add(My.Settings.Game13 & " - " & My.Settings.GamePath13)
            ListBox1.Items.Add(My.Settings.Game14 & " - " & My.Settings.GamePath14)
            ListBox1.Items.Add(My.Settings.Game15 & " - " & My.Settings.GamePath15)
            ListBox1.Items.Add(My.Settings.Game16 & " - " & My.Settings.GamePath16)
            ListBox1.Items.Add(My.Settings.Game17 & " - " & My.Settings.GamePath17)
            ListBox1.Items.Add(My.Settings.Game18 & " - " & My.Settings.GamePath18)
            ListBox1.Items.Add(My.Settings.Game19 & " - " & My.Settings.GamePath19)
            ListBox1.Items.Add(My.Settings.Game20 & " - " & My.Settings.GamePath20)

            'Load All new Settings Data for user to view and Select for Functions
            ComboBox1.Items.Add(My.Settings.Game1)
            ComboBox1.Items.Add(My.Settings.Game2)
            ComboBox1.Items.Add(My.Settings.Game3)
            ComboBox1.Items.Add(My.Settings.Game4)
            ComboBox1.Items.Add(My.Settings.Game5)
            ComboBox1.Items.Add(My.Settings.Game6)
            ComboBox1.Items.Add(My.Settings.Game7)
            ComboBox1.Items.Add(My.Settings.Game8)
            ComboBox1.Items.Add(My.Settings.Game9)
            ComboBox1.Items.Add(My.Settings.Game10)
            ComboBox1.Items.Add(My.Settings.Game11)
            ComboBox1.Items.Add(My.Settings.Game12)
            ComboBox1.Items.Add(My.Settings.Game13)
            ComboBox1.Items.Add(My.Settings.Game14)
            ComboBox1.Items.Add(My.Settings.Game15)
            ComboBox1.Items.Add(My.Settings.Game16)
            ComboBox1.Items.Add(My.Settings.Game17)
            ComboBox1.Items.Add(My.Settings.Game18)
            ComboBox1.Items.Add(My.Settings.Game19)
            ComboBox1.Items.Add(My.Settings.Game20)

            ComboBox2.Items.Add(My.Settings.DesFol)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'Display FolderBrowseDialog 2 To search for Game Save Folder (Target Folder)
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Try
            If FolderBrowserDialog2.ShowDialog() = DialogResult.OK Then
                FolBrowsString2 = FolderBrowserDialog2.SelectedPath
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'Check if Valid and Save new Entered Game Details to My.Settings
    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Try
            'Check if the Targeted Folder has a Name, Continue if yes
            If TextBox1.Text = "" Then
                MessageBox.Show("Please Enter the Games Name", "No Game Description")

                'Check if the Targeted Folders Path has been Selected yet, Continue if yes
            ElseIf FolBrowsString2.ToString = "" Then
                MessageBox.Show("Please Choose The Games Save Folder Path", "No Game Path")

                'If A name has been Enter aswell as a path, Save the detials
            Else
                'Check if there is a Spot Availabe in My.settings and Enter New Folder Name and Path Details
                If My.Settings.GamePath1 = "No Game Folder Path Selected" Then
                    My.Settings.Game1 = TextBox1.Text
                    My.Settings.GamePath1 = FolBrowsString2
                    My.Settings.Save()
                    MessageBox.Show("Game Details Saved", "Game Save Duplicator")

                ElseIf My.Settings.GamePath2 = "No Game Folder Path Selected" Then
                    My.Settings.Game2 = TextBox1.Text
                    My.Settings.GamePath2 = FolBrowsString2
                    My.Settings.Save()
                    MessageBox.Show("Game Details Saved", "Game Save Duplicator")

                ElseIf My.Settings.GamePath3 = "No Game Folder Path Selected" Then
                    My.Settings.Game3 = TextBox1.Text
                    My.Settings.GamePath3 = FolBrowsString2
                    My.Settings.Save()
                    MessageBox.Show("Game Details Saved", "Game Save Duplicator")

                ElseIf My.Settings.GamePath4 = "No Game Folder Path Selected" Then
                    My.Settings.Game4 = TextBox1.Text
                    My.Settings.GamePath4 = FolBrowsString2
                    My.Settings.Save()
                    MessageBox.Show("Game Details Saved", "Game Save Duplicator")

                ElseIf My.Settings.GamePath5 = "No Game Folder Path Selected" Then
                    My.Settings.Game5 = TextBox1.Text
                    My.Settings.GamePath5 = FolBrowsString2
                    My.Settings.Save()
                    MessageBox.Show("Game Details Saved", "Game Save Duplicator")

                ElseIf My.Settings.GamePath6 = "No Game Folder Path Selected" Then
                    My.Settings.Game6 = TextBox1.Text
                    My.Settings.GamePath6 = FolBrowsString2
                    My.Settings.Save()
                    MessageBox.Show("Game Details Saved", "Game Save Duplicator")

                ElseIf My.Settings.GamePath7 = "No Game Folder Path Selected" Then
                    My.Settings.Game7 = TextBox1.Text
                    My.Settings.GamePath7 = FolBrowsString2
                    My.Settings.Save()
                    MessageBox.Show("Game Details Saved", "Game Save Duplicator")

                ElseIf My.Settings.GamePath8 = "No Game Folder Path Selected" Then
                    My.Settings.Game8 = TextBox1.Text
                    My.Settings.GamePath8 = FolBrowsString2
                    My.Settings.Save()
                    MessageBox.Show("Game Details Saved", "Game Save Duplicator")

                ElseIf My.Settings.GamePath9 = "No Game Folder Path Selected" Then
                    My.Settings.Game9 = TextBox1.Text
                    My.Settings.GamePath9 = FolBrowsString2
                    My.Settings.Save()
                    MessageBox.Show("Game Details Saved", "Game Save Duplicator")

                ElseIf My.Settings.GamePath10 = "No Game Folder Path Selected" Then
                    My.Settings.Game10 = TextBox1.Text
                    My.Settings.GamePath10 = FolBrowsString2
                    My.Settings.Save()
                    MessageBox.Show("Game Details Saved", "Game Save Duplicator")

                ElseIf My.Settings.GamePath11 = "No Game Folder Path Selected" Then
                    My.Settings.Game11 = TextBox1.Text
                    My.Settings.GamePath11 = FolBrowsString2
                    My.Settings.Save()
                    MessageBox.Show("Game Details Saved", "Game Save Duplicator")

                ElseIf My.Settings.GamePath12 = "No Game Folder Path Selected" Then
                    My.Settings.Game12 = TextBox1.Text
                    My.Settings.GamePath12 = FolBrowsString2
                    My.Settings.Save()
                    MessageBox.Show("Game Details Saved", "Game Save Duplicator")

                ElseIf My.Settings.GamePath13 = "No Game Folder Path Selected" Then
                    My.Settings.Game13 = TextBox1.Text
                    My.Settings.GamePath13 = FolBrowsString2
                    My.Settings.Save()
                    MessageBox.Show("Game Details Saved", "Game Save Duplicator")

                ElseIf My.Settings.GamePath14 = "No Game Folder Path Selected" Then
                    My.Settings.Game14 = TextBox1.Text
                    My.Settings.GamePath14 = FolBrowsString2
                    My.Settings.Save()
                    MessageBox.Show("Game Details Saved", "Game Save Duplicator")

                ElseIf My.Settings.GamePath15 = "No Game Folder Path Selected" Then
                    My.Settings.Game15 = TextBox1.Text
                    My.Settings.GamePath15 = FolBrowsString2
                    My.Settings.Save()
                    MessageBox.Show("Game Details Saved", "Game Save Duplicator")

                ElseIf My.Settings.GamePath16 = "No Game Folder Path Selected" Then
                    My.Settings.Game16 = TextBox1.Text
                    My.Settings.GamePath16 = FolBrowsString2
                    My.Settings.Save()
                    MessageBox.Show("Game Details Saved", "Game Save Duplicator")

                ElseIf My.Settings.GamePath17 = "No Game Folder Path Selected" Then
                    My.Settings.Game17 = TextBox1.Text
                    My.Settings.GamePath17 = FolBrowsString2
                    My.Settings.Save()
                    MessageBox.Show("Game Details Saved", "Game Save Duplicator")

                ElseIf My.Settings.GamePath18 = "No Game Folder Path Selected" Then
                    My.Settings.Game18 = TextBox1.Text
                    My.Settings.GamePath18 = FolBrowsString2
                    My.Settings.Save()
                    MessageBox.Show("Game Details Saved", "Game Save Duplicator")

                ElseIf My.Settings.GamePath19 = "No Game Folder Path Selected" Then
                    My.Settings.Game19 = TextBox1.Text
                    My.Settings.GamePath19 = FolBrowsString2
                    My.Settings.Save()
                    MessageBox.Show("Game Details Saved", "Game Save Duplicator")

                ElseIf My.Settings.GamePath20 = "No Game Folder Path Selected" Then
                    My.Settings.Game20 = TextBox1.Text
                    My.Settings.GamePath20 = FolBrowsString2
                    My.Settings.Save()
                    MessageBox.Show("Game Details Saved", "Game Save Duplicator")

                    'If there are now more settings available in My.settings :
                Else
                    MessageBox.Show("Please Delete Some Settings to make Space", "No more settings available (20\20 used)")
                End If

                'Clear Input Fields For Next use
                TextBox1.Text = ""
                FolBrowsString2 = ""

                'Load all the new Data for the User to view
                InitStart()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'Display FolderBrowseDialog 1 To search for Destination Folder to Save Target Folders (Destination Folder)
    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        Try
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                FolBrowsString1 = FolderBrowserDialog1.SelectedPath
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'Check if Valid and Save new Entered Destination Folder Details to My.Settings
    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Try
            'Check if a Destination Folder has been Selected yet
            If FolBrowsString1.ToString = "" Then
                MessageBox.Show("Please Choose a Destination Folder Path", "No Game Path Selected")

                'If destination Folder has been Selected, Save it to my.settings
            Else
                My.Settings.DesFol = FolBrowsString1
                My.Settings.Save()
                MessageBox.Show("Destination Folder is now Saved", "Game Save Duplicator")

                'Clear String for next use
                FolBrowsString1 = ""

                'Load all new Saved Data for the User to view
                InitStart()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'Clear All the Saved Settings
    Private Sub IconButton8_Click(sender As Object, e As EventArgs) Handles IconButton8.Click
        Try
            'Ask user if their certian they want to clear Settings
            Dim result2 As DialogResult = MessageBox.Show("Are you sure you want to Delete All Saved Data ?", "Game Save Duplicator", MessageBoxButtons.YesNoCancel)
            If result2 = DialogResult.Cancel Then
                'Nothing Happens
            ElseIf result2 = DialogResult.No Then
                'Nothing Happens

                'If yes, Clear all data
            ElseIf result2 = DialogResult.Yes Then
                My.Settings.DesFol = "No Destination Folder Path Selected"
                My.Settings.Game1 = "No Game Data"
                My.Settings.Game2 = "No Game Data"
                My.Settings.Game3 = "No Game Data"
                My.Settings.Game4 = "No Game Data"
                My.Settings.Game5 = "No Game Data"
                My.Settings.Game6 = "No Game Data"
                My.Settings.Game7 = "No Game Data"
                My.Settings.Game8 = "No Game Data"
                My.Settings.Game9 = "No Game Data"
                My.Settings.Game10 = "No Game Data"
                My.Settings.Game11 = "No Game Data"
                My.Settings.Game12 = "No Game Data"
                My.Settings.Game13 = "No Game Data"
                My.Settings.Game14 = "No Game Data"
                My.Settings.Game15 = "No Game Data"
                My.Settings.Game16 = "No Game Data"
                My.Settings.Game17 = "No Game Data"
                My.Settings.Game18 = "No Game Data"
                My.Settings.Game19 = "No Game Data"
                My.Settings.Game20 = "No Game Data"
                My.Settings.GamePath1 = "No Game Folder Path Selected"
                My.Settings.GamePath2 = "No Game Folder Path Selected"
                My.Settings.GamePath3 = "No Game Folder Path Selected"
                My.Settings.GamePath4 = "No Game Folder Path Selected"
                My.Settings.GamePath5 = "No Game Folder Path Selected"
                My.Settings.GamePath6 = "No Game Folder Path Selected"
                My.Settings.GamePath7 = "No Game Folder Path Selected"
                My.Settings.GamePath8 = "No Game Folder Path Selected"
                My.Settings.GamePath9 = "No Game Folder Path Selected"
                My.Settings.GamePath10 = "No Game Folder Path Selected"
                My.Settings.GamePath11 = "No Game Folder Path Selected"
                My.Settings.GamePath12 = "No Game Folder Path Selected"
                My.Settings.GamePath13 = "No Game Folder Path Selected"
                My.Settings.GamePath14 = "No Game Folder Path Selected"
                My.Settings.GamePath15 = "No Game Folder Path Selected"
                My.Settings.GamePath16 = "No Game Folder Path Selected"
                My.Settings.GamePath17 = "No Game Folder Path Selected"
                My.Settings.GamePath18 = "No Game Folder Path Selected"
                My.Settings.GamePath19 = "No Game Folder Path Selected"
                My.Settings.GamePath20 = "No Game Folder Path Selected"

                My.Settings.Save()

                MessageBox.Show("All Application Game Saved Data Deleted", "Game Save Duplicator")

                'Clear Input Fields
                ComboBox1.Text = ""
                ComboBox2.Text = ""

                'Load New Updated Data for user to view
                InitStart()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'Where Everyting Start.
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Try
            'Make sure the Input Fiels Are valid
            If ComboBox1.Text = "" Then
                MessageBox.Show("Please Select a Targeted Game", "Game Save Duplicator")
            ElseIf ComboBox1.Text = "No Game Data" Then
                MessageBox.Show("Please Select a Valid Targeted Game", "Game Save Duplicator")
            ElseIf ComboBox2.Text = "" Then
                MessageBox.Show("Please Select a Destination Folder", "Game Save Duplicator")
            ElseIf ComboBox2.Text = "No Destination Folder Path Selected" Then
                MessageBox.Show("Please Select a Valid Destination Folder", "Game Save Duplicator")
            Else
                'Check which Value in the Combobox belongs to Which Settings, and Select that Game path
                If ComboBox1.Text = My.Settings.Game1 Then
                    directoryTargetLocation = My.Settings.GamePath1
                ElseIf ComboBox1.Text = My.Settings.Game2 Then
                    directoryTargetLocation = My.Settings.GamePath2
                ElseIf ComboBox1.Text = My.Settings.Game3 Then
                    directoryTargetLocation = My.Settings.GamePath3
                ElseIf ComboBox1.Text = My.Settings.Game4 Then
                    directoryTargetLocation = My.Settings.GamePath4
                ElseIf ComboBox1.Text = My.Settings.Game5 Then
                    directoryTargetLocation = My.Settings.GamePath5
                ElseIf ComboBox1.Text = My.Settings.Game6 Then
                    directoryTargetLocation = My.Settings.GamePath6
                ElseIf ComboBox1.Text = My.Settings.Game7 Then
                    directoryTargetLocation = My.Settings.GamePath7
                ElseIf ComboBox1.Text = My.Settings.Game8 Then
                    directoryTargetLocation = My.Settings.GamePath8
                ElseIf ComboBox1.Text = My.Settings.Game9 Then
                    directoryTargetLocation = My.Settings.GamePath9
                ElseIf ComboBox1.Text = My.Settings.Game10 Then
                    directoryTargetLocation = My.Settings.GamePath10
                ElseIf ComboBox1.Text = My.Settings.Game11 Then
                    directoryTargetLocation = My.Settings.GamePath11
                ElseIf ComboBox1.Text = My.Settings.Game12 Then
                    directoryTargetLocation = My.Settings.GamePath12
                ElseIf ComboBox1.Text = My.Settings.Game13 Then
                    directoryTargetLocation = My.Settings.GamePath13
                ElseIf ComboBox1.Text = My.Settings.Game14 Then
                    directoryTargetLocation = My.Settings.GamePath14
                ElseIf ComboBox1.Text = My.Settings.Game15 Then
                    directoryTargetLocation = My.Settings.GamePath15
                ElseIf ComboBox1.Text = My.Settings.Game16 Then
                    directoryTargetLocation = My.Settings.GamePath16
                ElseIf ComboBox1.Text = My.Settings.Game17 Then
                    directoryTargetLocation = My.Settings.GamePath17
                ElseIf ComboBox1.Text = My.Settings.Game18 Then
                    directoryTargetLocation = My.Settings.GamePath18
                ElseIf ComboBox1.Text = My.Settings.Game19 Then
                    directoryTargetLocation = My.Settings.GamePath19
                ElseIf ComboBox1.Text = My.Settings.Game20 Then
                    directoryTargetLocation = My.Settings.GamePath20
                End If

                'These is only 1 Destination Path allowed so automatically the One that is Selected is the one.
                Destinydirectory = ComboBox2.SelectedItem

                'Start the Copy Function
                BackgroundWorker1.RunWorkerAsync()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'Cancel the Copying Process
    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        Try
            'if something is being Copied, Cancel it
            If BackgroundWorker1.IsBusy Then
                BackgroundWorker1.CancelAsync()

                'if nothing is being Copied:
            Else
                MessageBox.Show("Nothing is being Copied at the moment", "Game Save Duplicator")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    '!!!!!!!!!!!!!!!!!!!     Where the magic Happens     !!!!!!!!!!!!!!!!!!!
    'the Copying process
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Dim parts As String() = directoryTargetLocation.Split(New Char() {"\"c})
        Dim filename As String = parts(parts.Count - 1) 'target folder name

        Dim dir_path As String = "" 'directory without target folder name
        For f As Integer = 0 To parts.Count - 2
            dir_path += parts(f) + "\"
        Next


        Dim copied As Integer = 0
        Dim counter As Integer = IO.Directory.GetFiles(directoryTargetLocation, "*.*", IO.SearchOption.AllDirectories).Length 'counts the number of files
        SetProgressbar(counter, ProgressBar2) 'Sets ProgressBar maximum to number of files

        setLabelTxt("Copied (0/" + counter.ToString + ")", Label4) 'displays the amount of copied files

        Dim FolderList As New List(Of String)
        FolderList.Add(directoryTargetLocation) 'Set first folder


        Do While True
            If (BackgroundWorker1.CancellationPending = True) Then 'cancel loop
                e.Cancel = True
                Exit Do
            End If

            Dim FoldersInsideDirectory As New List(Of String)

            If FolderList.Count = 0 Then
                Exit Do 'If there is no folder to copy Exit Do
            Else

                For l As Integer = 0 To FolderList.Count - 1

                    If (BackgroundWorker1.CancellationPending = True) Then 'stop for loop
                        e.Cancel = True
                        Exit For
                    End If

                    Dim sourceDirectoryInfo As New System.IO.DirectoryInfo(FolderList(l))

                    Dim dest As String = FolderList(l).Replace(dir_path, "")
                    If (Not System.IO.Directory.Exists(Destinydirectory + "\" + dest)) Then 'create subFolder inside directory
                        System.IO.Directory.CreateDirectory(Destinydirectory + "\" + dest)
                    End If

                    Dim fileSystemInfo As System.IO.FileSystemInfo

                    For Each fileSystemInfo In sourceDirectoryInfo.GetFileSystemInfos
                        If (BackgroundWorker1.CancellationPending = True) Then
                            e.Cancel = True
                            Exit For
                        End If
                        Dim destinationFileName As String = System.IO.Path.Combine(Destinydirectory + "\" + dest, fileSystemInfo.Name)
                        If TypeOf fileSystemInfo Is System.IO.FileInfo Then
                            Dim streamRead As New System.IO.FileStream(fileSystemInfo.FullName, System.IO.FileMode.Open)
                            setLabelTxt(fileSystemInfo.FullName.ToString, LabelProgress)
                            Dim streamWrite As New System.IO.FileStream(Destinydirectory + "\" + dest + "\" + fileSystemInfo.Name, IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.None)
                            Dim lngLen As Long = streamRead.Length - 1
                            setLabelTxt("Copy bytes : (0/" + (lngLen * 100).ToString + ")", Label10)
                            Dim byteBuffer(1048576) As Byte   'our stream buffer
                            Dim intBytesRead As Integer    'number of bytes read
                            While streamRead.Position < lngLen    'keep streaming until EOF
                                If (BackgroundWorker1.CancellationPending = True) Then
                                    e.Cancel = True
                                    Exit While
                                End If
                                BackgroundWorker1.ReportProgress(CInt(streamRead.Position / lngLen * 100))
                                setLabelTxt("Copy bytes : (" + CInt(streamRead.Position).ToString + "/" + (lngLen * 100).ToString + ")", Label10)
                                intBytesRead = (streamRead.Read(byteBuffer, 0, 1048576))
                                streamWrite.Write(byteBuffer, 0, intBytesRead)
                            End While
                            'Clean up 
                            streamWrite.Flush()
                            streamWrite.Close()
                            streamRead.Close()
                            addProgress(1, ProgressBar2)
                            copied += 1
                            setLabelTxt("Copied (" + copied.ToString + "/" + counter.ToString + ")", Label4)
                        Else
                            FoldersInsideDirectory.Add(fileSystemInfo.FullName)
                        End If
                    Next
                Next
                FolderList.Clear()
                FolderList = FoldersInsideDirectory
            End If
        Loop
    End Sub

    'Update Progress bar value when new Files are being Moved
    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    'If Copy process is completed or Stopped
    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Cancelled = True Then
            MessageBox.Show("Copy Process Canceled!", "Game Save Duplicator")
        Else
            MessageBox.Show("Copy Process Completed!", "Game Save Duplicator")
        End If

        'clear everything for next use
        ProgressBar1.Value = 0
        ProgressBar2.Value = 0
        Label10.Text = "Copy Bytes: (0/0)"
        LabelProgress.Text = "Nothing is being Copied at the moment"
    End Sub

    'Show What is being Copied at the moment with Label
    Private Sub setLabelTxt(ByVal text As String, ByVal lbl As Label)
        If lbl.InvokeRequired Then
            lbl.Invoke(New setLabelTxtInvoker(AddressOf setLabelTxt), text, lbl)
        Else
            lbl.Text = text
        End If
    End Sub
    Private Delegate Sub setLabelTxtInvoker(ByVal text As String, ByVal lbl As Label)

    'Change ProgressBar 1 Progression
    Private Sub SetProgressbar(ByVal val As Integer, ByVal progressba As ProgressBar)
        If progressba.InvokeRequired Then
            progressba.Invoke(New SetProgressbarInvoker(AddressOf SetProgressbar), val, progressba)
        Else
            progressba.Value = 0
            progressba.Maximum = val
        End If
    End Sub
    Private Delegate Sub SetProgressbarInvoker(ByVal val As Integer, ByVal progressba As ProgressBar)

    'Change ProgressBar 2 Progression
    Private Sub addProgress(ByVal val As Integer, ByVal progressba As ProgressBar)
        If progressba.InvokeRequired Then
            progressba.Invoke(New addProgressInvoker(AddressOf addProgress), val, progressba)
        Else
            progressba.Value += val
        End If
    End Sub
    Private Delegate Sub addProgressInvoker(ByVal val As Integer, ByVal progressba As ProgressBar)

End Class