Imports System
Imports Microsoft
Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Text.RegularExpressions

Public Class Form1
    Dim runsN As Integer
    Dim selectedSave As Integer
    Dim userSynapsis As String = Nothing
    Dim savedSynapsis As String
    Dim savedSynapsisText As String
    Dim saveToDelete As Integer
    Dim saveSynapsisDeleteCandidate As String
    Dim theWholefile As String
    Dim SaveFile As System.IO.StreamWriter
    Dim shortCutName As String
    Dim dialog As New FolderBrowserDialog
    Dim TargetName As String
    Dim ShortCutPath As String
    Dim oShell As Object
    Dim oLink As Object
    'pathlnk
    Dim pathNoita_Runs As String = System.Windows.Forms.Application.StartupPath & "\Noita_Runs"
    Dim pathNoita_RunsFolder As String = System.Windows.Forms.Application.StartupPath & "\Noita_Runs\"
    Dim pathNoitaS As String = ""
    Dim pathlnkynapsisText As String = System.Windows.Forms.Application.StartupPath & "\SaveSynapsis.txt"
    Dim pathsave00 As String = ""
    Dim appPath As String = System.Windows.Forms.Application.StartupPath

    'DEBUG
    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
    End Sub

    'FORM LOAD
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'check if files exist containing paths. If not get paths and create them
        CheckPathTxt()

        'Get the latest save and the number of saves
        checkSaves()
    End Sub
    Private Sub checkSaves()
        'Clear listbox
        ListBoxSaves.Items.Clear()
        'Get the latest save and the number of saves
        For Each Dir As String In Directory.GetDirectories(pathNoita_Runs)
            runsN = My.Computer.FileSystem.GetName(Dir)
            ListBoxSaves.Items.Add(My.Computer.FileSystem.GetName(Dir))
        Next
    End Sub
    'check paths .txt files
    Private Sub CheckPathTxt()

        'TESTS:

        'Noita_Runs(folder)
        If (Not System.IO.Directory.Exists(appPath & "\Noita_Runs")) Then
            System.IO.Directory.CreateDirectory(appPath & "\Noita_Runs")
        End If

        'noitaS.lnk

        If My.Computer.FileSystem.FileExists("pathlnk.txt") = True Then
            'get the path from file
            pathNoitaS = My.Computer.FileSystem.ReadAllText("pathlnk.txt")
            'delete the stupid space that saving the file creates
            pathNoitaS = pathNoitaS.Replace(vbLf, "").Replace(vbCr, "")
        Else
            'If not then ask a path to it create a shortcut for launching
            MsgBox("Navigate and select the Noita game folder" & vbNewLine & "Usually:" & vbNewLine & "C:-->Program Files(x86)-->steam-->steamapps-->common-->Noita")
            CreateShortCut()
            pathNoitaS = ShortCutPath & "\noitaS.lnk"
        End If

        'Noita saves (saves00)

        If My.Computer.FileSystem.FileExists("pathSave00.txt") = True Then
            'get the path from file
            pathsave00 = My.Computer.FileSystem.ReadAllText("pathSave00.txt")
            'delete the stupid space that saving the file creates
            pathsave00 = pathsave00.Replace(vbLf, "").Replace(vbCr, "")
        Else
            'If not then ask a path 
            MsgBox("Navigate and select the Noita save folder" & vbNewLine & "Usually:" & "C:-->User-->'User'-->AppData-->LocalLow-->Nolla_Games_Noita-->save00")
            If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                pathsave00 = dialog.SelectedPath
                'create a .txt file that stores the path to save00 
                SaveFile = My.Computer.FileSystem.OpenTextFileWriter(appPath & "\pathSave00.txt", True)
                SaveFile.WriteLine(pathsave00)
                SaveFile.Close()
            End If
        End If


    End Sub

    'START
    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        'read path and run the shortcut
        Process.Start(pathNoitaS)
        'update labels
        LabelSTATUS.Text = "Starting..."
        LabelSTATUS.Left = Me.Width / 2 - LabelSTATUS.Width / 2

    End Sub

    'SAVE
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        'create a new save folder 
        My.Computer.FileSystem.CreateDirectory(pathNoita_RunsFolder & runsN + 1)
        'Increment var 
        runsN += 1
        'Ask user for a save explanation



        userSynapsis = InputBox("Give a short synapsis of this save", "A Short Synopsis", " -")

        SaveFile = My.Computer.FileSystem.OpenTextFileWriter(pathlnkynapsisText, True)
        SaveFile.WriteLine(runsN & userSynapsis)
        SaveFile.Close()


        'copy the files to the new save folder
        For Each file As String In IO.Directory.GetFiles(pathsave00)
            IO.File.Copy(file, file.Replace(pathsave00, pathNoita_RunsFolder & runsN))
        Next
        'Update listbox
        checkSaves()
        LabelSTATUS.Text = "Saved!"
        LabelSTATUS.Left = Me.Width / 2 - LabelSTATUS.Width / 2
    End Sub

    'LOAD
    Private Sub ButtonLoad_Click(sender As Object, e As EventArgs) Handles ButtonLoad.Click
        'Check if user has selected a save to load
        If selectedSave = Nothing Then
            MsgBox("Select a SAVE to load")
        Else
            'delete current game save
            If My.Computer.FileSystem.FileExists(pathsave00 & "\magic_numbers.salakieli") = True Then
                FileSystem.Kill(pathsave00 & "\*.*")
            Else
            End If
            'copy the save to the game
            My.Computer.FileSystem.CopyDirectory(pathNoita_RunsFolder & selectedSave, pathsave00, True)
        End If
        'start the game
        Process.Start(pathNoitaS)
        LabelSTATUS.Text = "Starting..."
        LabelSTATUS.Left = Me.Width / 2 - LabelSTATUS.Width / 2
    End Sub

    'SELECT SAVE
    Private Sub ListBoxSaves_Click(sender As Object, e As EventArgs) Handles ListBoxSaves.Click
        selectedSave = ListBoxSaves.SelectedItem
        'get synapsis of that save

        Using sr As StreamReader = File.OpenText(pathlnkynapsisText)
            Do While sr.Peek() >= 0

                'read the .txt file line by line 
                savedSynapsis = sr.ReadLine()
                savedSynapsisText = savedSynapsis
                'if line is empty then
                If savedSynapsis.Length < 1 Then
                Else
                    'line is not empty
                    savedSynapsis = savedSynapsis.Substring(0, 3)
                    If Regex.IsMatch(savedSynapsis, "^[0-9 ]+$") Then
                        'check if numeric
                        isnumeric()
                    Else
                        savedSynapsis = savedSynapsis.Substring(0, 2)
                        If Regex.IsMatch(savedSynapsis, "^[0-9 ]+$") Then
                            If savedSynapsis = selectedSave Then
                                TextBoxSynapsis.Text = savedSynapsisText
                            End If
                        Else
                            savedSynapsis = savedSynapsis.Substring(0, 1)
                            If savedSynapsis = selectedSave Then
                                TextBoxSynapsis.Text = savedSynapsisText
                            End If
                        End If
                    End If
                End If

            Loop
        End Using

        If selectedSave = 0 Then
            TextBoxSynapsis.Text = ""
        End If

        LabelSTATUS.Text = "Save " & selectedSave & " selected"
        LabelSTATUS.Left = Me.Width / 2 - LabelSTATUS.Width / 2
    End Sub

    'CHECK FOR NUMERIC
    Private Sub isnumeric()
        If savedSynapsis = selectedSave Then
            TextBoxSynapsis.Text = savedSynapsisText
        End If
    End Sub

    'DELETE
    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click


        saveToDelete = selectedSave

        If selectedSave = Nothing Then
            MsgBox("Select a SAVE to load")
        Else
            'delete folder
            System.IO.Directory.Delete(pathNoita_RunsFolder & selectedSave, True)
            'delete synapsis from .txt file
            Using sr As StreamReader = File.OpenText(pathlnkynapsisText)
                Do While sr.Peek() >= 0

                    'read the .txt file line by line
                    saveSynapsisDeleteCandidate = sr.ReadLine()
                    'if found the right line save it 
                    If saveSynapsisDeleteCandidate.Contains(saveToDelete) = True Then
                        Exit Do
                    End If
                Loop
            End Using
            'get the whole .txt file
            theWholefile = My.Computer.FileSystem.ReadAllText(pathlnkynapsisText)
            'delete the line
            theWholefile = theWholefile.Replace(saveSynapsisDeleteCandidate, "")
            'delete the old .txt file
            My.Computer.FileSystem.DeleteFile(pathlnkynapsisText)
            'save the new .txt file
            SaveFile = My.Computer.FileSystem.OpenTextFileWriter(pathlnkynapsisText, True)
            SaveFile.WriteLine(theWholefile)
            SaveFile.Close()

            checkSaves()
        End If

        LabelSTATUS.Text = "Deleted!"
        LabelSTATUS.Left = Me.Width / 2 - LabelSTATUS.Width / 2
    End Sub

    'OPEN Folder(noita runs)
    Private Sub ButtonFiles_Click(sender As Object, e As EventArgs) Handles ButtonFiles.Click
        'open noita runs file location
        Process.Start("C:\Users\LAdu3L\Desktop\Noita Runs")
    End Sub

    'Create a shortcut
    Private Sub CreateShortCut()
    

        'get target path
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ShortCutPath = dialog.SelectedPath
            TargetName = dialog.SelectedPath & "\noita.exe"
        End If

        Try
            oShell = CreateObject("WScript.Shell")
            'what to make shortcut of
            oLink = oShell.CreateShortcut(ShortCutPath & "\noitaS.lnk")
            'where to make the shortcut
            oLink.TargetPath = TargetName
            oLink.WindowStyle = 1
            oLink.Save()
            'create a .txt file that stores the path to noita.exe and the shortcut


            SaveFile = My.Computer.FileSystem.OpenTextFileWriter(apppath & "\pathlnk.txt", True)
            SaveFile.WriteLine(ShortCutPath & "\noitaS.lnk")
            SaveFile.Close()


        Catch ex As Exception

        End Try

    End Sub

End Class