<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        ConverterApp2 = New Label()
        Label1 = New Label()
        Input = New TextBox()
        GroupBox1 = New GroupBox()
        Ignore = New RadioButton()
        MeterstoInches = New RadioButton()
        InchestoMeters = New RadioButton()
        Label2 = New Label()
        Convert = New Button()
        Save = New Button()
        Clear = New Button()
        ClearList = New Button()
        SavetoFile = New Button()
        Answer = New GroupBox()
        Results = New ListBox()
        FileNoti = New GroupBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(27, 105)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(317, 252)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ConverterApp2
        ' 
        ConverterApp2.AutoSize = True
        ConverterApp2.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ConverterApp2.Location = New Point(432, 56)
        ConverterApp2.Name = "ConverterApp2"
        ConverterApp2.Size = New Size(400, 65)
        ConverterApp2.TabIndex = 1
        ConverterApp2.Text = "Converter App 2"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(350, 223)
        Label1.Name = "Label1"
        Label1.Size = New Size(391, 32)
        Label1.TabIndex = 2
        Label1.Text = "Enter value and choose conversion"
        ' 
        ' Input
        ' 
        Input.BackColor = SystemColors.ScrollBar
        Input.Location = New Point(758, 226)
        Input.Name = "Input"
        Input.Size = New Size(234, 31)
        Input.TabIndex = 3
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ActiveBorder
        GroupBox1.Controls.Add(Ignore)
        GroupBox1.Controls.Add(MeterstoInches)
        GroupBox1.Controls.Add(InchestoMeters)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(409, 351)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(570, 265)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        ' 
        ' Ignore
        ' 
        Ignore.AutoSize = True
        Ignore.Location = New Point(348, 76)
        Ignore.Name = "Ignore"
        Ignore.Size = New Size(89, 29)
        Ignore.TabIndex = 3
        Ignore.TabStop = True
        Ignore.Text = "Ignore"
        Ignore.UseVisualStyleBackColor = True
        ' 
        ' MeterstoInches
        ' 
        MeterstoInches.AutoSize = True
        MeterstoInches.Location = New Point(80, 158)
        MeterstoInches.Name = "MeterstoInches"
        MeterstoInches.Size = New Size(168, 29)
        MeterstoInches.TabIndex = 2
        MeterstoInches.TabStop = True
        MeterstoInches.Text = "Meters to Inches"
        MeterstoInches.UseVisualStyleBackColor = True
        ' 
        ' InchestoMeters
        ' 
        InchestoMeters.AutoSize = True
        InchestoMeters.Location = New Point(80, 111)
        InchestoMeters.Name = "InchestoMeters"
        InchestoMeters.Size = New Size(168, 29)
        InchestoMeters.TabIndex = 1
        InchestoMeters.TabStop = True
        InchestoMeters.Text = "Inches to Meters"
        InchestoMeters.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(6, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(300, 38)
        Label2.TabIndex = 0
        Label2.Text = "Convert Measurement"
        ' 
        ' Convert
        ' 
        Convert.Location = New Point(440, 642)
        Convert.Name = "Convert"
        Convert.Size = New Size(328, 60)
        Convert.TabIndex = 5
        Convert.Text = "Convert"
        Convert.UseVisualStyleBackColor = True
        ' 
        ' Save
        ' 
        Save.Location = New Point(440, 796)
        Save.Name = "Save"
        Save.Size = New Size(328, 60)
        Save.TabIndex = 6
        Save.Text = "Save Results"
        Save.UseVisualStyleBackColor = True
        ' 
        ' Clear
        ' 
        Clear.Location = New Point(440, 884)
        Clear.Name = "Clear"
        Clear.Size = New Size(328, 60)
        Clear.TabIndex = 7
        Clear.Text = "Clear Results"
        Clear.UseVisualStyleBackColor = True
        ' 
        ' ClearList
        ' 
        ClearList.Location = New Point(16, 912)
        ClearList.Name = "ClearList"
        ClearList.Size = New Size(328, 60)
        ClearList.TabIndex = 8
        ClearList.Text = "Clear List"
        ClearList.UseVisualStyleBackColor = True
        ' 
        ' SavetoFile
        ' 
        SavetoFile.Location = New Point(16, 1009)
        SavetoFile.Name = "SavetoFile"
        SavetoFile.Size = New Size(328, 60)
        SavetoFile.TabIndex = 9
        SavetoFile.Text = "Save to File"
        SavetoFile.UseVisualStyleBackColor = True
        ' 
        ' Answer
        ' 
        Answer.Location = New Point(440, 718)
        Answer.Name = "Answer"
        Answer.Size = New Size(459, 61)
        Answer.TabIndex = 11
        Answer.TabStop = False
        ' 
        ' Results
        ' 
        Results.FormattingEnabled = True
        Results.ItemHeight = 25
        Results.Location = New Point(27, 375)
        Results.Name = "Results"
        Results.Size = New Size(317, 504)
        Results.TabIndex = 12
        ' 
        ' FileNoti
        ' 
        FileNoti.Location = New Point(422, 1017)
        FileNoti.Name = "FileNoti"
        FileNoti.Size = New Size(512, 83)
        FileNoti.TabIndex = 13
        FileNoti.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1075, 1144)
        Controls.Add(FileNoti)
        Controls.Add(Results)
        Controls.Add(Answer)
        Controls.Add(SavetoFile)
        Controls.Add(ClearList)
        Controls.Add(Clear)
        Controls.Add(Save)
        Controls.Add(Convert)
        Controls.Add(GroupBox1)
        Controls.Add(Input)
        Controls.Add(Label1)
        Controls.Add(ConverterApp2)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ConverterApp2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Input As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents InchestoMeters As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Ignore As RadioButton
    Friend WithEvents MeterstoInches As RadioButton
    Friend WithEvents Convert As Button
    Friend WithEvents Save As Button
    Friend WithEvents Clear As Button
    Friend WithEvents ClearList As Button
    Friend WithEvents SavetoFile As Button
    Friend WithEvents Answer As GroupBox
    Friend WithEvents Results As ListBox
    Friend WithEvents FileNoti As GroupBox

End Class
