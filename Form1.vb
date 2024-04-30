Imports Microsoft.VisualBasic.Devices
Imports System.IO
Imports System.Text
Imports System.Xml

'Jaden Torres
'Final Project 
'GUI
'Bruce Montgomery
'Sources: https://learn.microsoft.com/en-us/dotnet/visual-basic/developing-apps/programming/drives-directories-files/how-to-write-text-to-files-with-a-streamwriter, Midterm Project
Public Class Form1

    Dim strInput As String 'initial parse
    Dim decInput As Decimal 'parse to decimal
    Dim OneTool As Decimal = 39.3700787 'conversion formula
    Dim TwoTool As Decimal = 39.3700787 'conversion formula
    Dim DecOneTool As Decimal ' variable to capture results of OneTool and temp
    Dim DecTwoTool As Decimal ' variable to capture results of TwoTool and temp
    Dim AnswerTool As Decimal ' variable to house the definite answer
    Dim AnswerWindow = New String() {}
    Dim Items As String ' Formatted answer string
    Dim temp As Decimal 'Used to compute answer
    Dim proc As Decimal 'use to tell which radio button was seleted.
    Dim path As String = "measures.txt" 'path of text file
    Dim fs As FileStream = File.Create(path)
    Dim filect As Integer = 0 'not used
    Dim line As String 'used to write into file
    Dim writer As System.IO.StreamWriter

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'loads form
        Ignore.PerformClick()
        Ignore.Hide()
        FileNoti.ResetText()
        Results.Items.Clear()

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub InchestoMeters_CheckedChanged(sender As Object, e As EventArgs) Handles InchestoMeters.CheckedChanged 'inches to meters checked
        proc = 1
    End Sub

    Private Sub MeterstoInches_CheckedChanged(sender As Object, e As EventArgs) Handles MeterstoInches.CheckedChanged 'meters to inches checked
        proc = 2
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Input.TextChanged

    End Sub

    Private Sub Convert_Click(sender As Object, e As EventArgs) Handles Convert.Click 'what happens when the convert button is pressed
        strInput = Input.Text
        If Decimal.TryParse(strInput, decInput) = False Then
            MsgBox("Error: The value you have entered is not numeric. Please try again")
            Input.ResetText()
            Answer.ResetText()
            Ignore.Show()
            Ignore.PerformClick()
            Ignore.Hide()
            Exit Sub
        Else
            If IsNumeric(strInput) = False Then
                MsgBox("Error: Value you have entered is not numeric. Please try again")
                Input.ResetText()
                Answer.ResetText()
                Exit Sub
            Else
                If decInput < 0 Then
                    MsgBox("Error: Value you have entered is negative. Please try again")
                    Input.ResetText()
                    Answer.ResetText()
                    Exit Sub
                End If
            End If
        End If
        temp = 0
        temp = decInput
        Compute()
    End Sub

    Public Sub Compute() 'sub class variable to compute the conversions
        If proc = 1 Then
            AnswerTool = 0
            DecOneTool = Math.Round(temp / OneTool, 3)
            AnswerTool = DecOneTool
            Items = (decInput.ToString() + " inches is " + AnswerTool.ToString() + " meters.")
        Else
            If proc = 2 Then
                AnswerTool = 0
                DecTwoTool = Math.Round(temp * TwoTool, 3)
                AnswerTool = DecTwoTool
                Items = (decInput.ToString() + "meters is " + AnswerTool.ToString() + " inches.")
            End If
        End If
        Stat_Output()
    End Sub



    Private Sub Stat_Output() 'formats the answer into a string to present to user
        If proc = 1 Then
            Answer.Text = decInput.ToString() + "inches is " + AnswerTool.ToString() + " meters."
            fs.Close()
            'Using reader As StreamReader = New StreamReader(path)
            'line = reader.ReadLine
            'End Using
            FileNoti.Show()
        Else
            If proc = 2 Then
                Answer.Text = decInput.ToString() + "meters is " + AnswerTool.ToString() + " inches."
                fs.Close()
                'Using reader As StreamReader = New StreamReader(path)
                'line = reader.ReadLine
                'End Using
                FileNoti.Show()
            End If
        End If
    End Sub


    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click 'adds item to lists
        Results.Items.Add(Items)
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click 'resets everything except list
        Input.ResetText()
        Answer.ResetText()
        proc = 0
    End Sub

    Private Sub ClearList_Click(sender As Object, e As EventArgs) Handles ClearList.Click 'clears list
        Results.Items.Clear()
        FileNoti.ResetText()
        Items = ""
        AnswerWindow = {}
    End Sub

    Private Sub SavetoFile_Click(sender As Object, e As EventArgs) Handles SavetoFile.Click 'writes into file
        writer = New IO.StreamWriter(path)
        For Each item In Results.Items
            writer.WriteLine(item)
        Next
        writer.Close()
        FileNoti.Text = String.Format("Saved {0} entries to measures.txt", Results.Items.Count)
    End Sub

End Class
