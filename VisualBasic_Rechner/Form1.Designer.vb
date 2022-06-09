<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.HightInCm = New System.Windows.Forms.TextBox()
        Me.WeightInKg = New System.Windows.Forms.TextBox()
        Me.PGröße = New System.Windows.Forms.TextBox()
        Me.PGewicht = New System.Windows.Forms.TextBox()
        Me.RadioMale = New System.Windows.Forms.RadioButton()
        Me.RadioFemale = New System.Windows.Forms.RadioButton()
        Me.Alter = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(319, 384)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 34)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Berrechnen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HightInCm
        '
        Me.HightInCm.Location = New System.Drawing.Point(365, 117)
        Me.HightInCm.Name = "HightInCm"
        Me.HightInCm.Size = New System.Drawing.Size(252, 22)
        Me.HightInCm.TabIndex = 2
        '
        'WeightInKg
        '
        Me.WeightInKg.Location = New System.Drawing.Point(365, 163)
        Me.WeightInKg.Name = "WeightInKg"
        Me.WeightInKg.Size = New System.Drawing.Size(252, 22)
        Me.WeightInKg.TabIndex = 3
        '
        'PGröße
        '
        Me.PGröße.Location = New System.Drawing.Point(267, 213)
        Me.PGröße.Name = "PGröße"
        Me.PGröße.Size = New System.Drawing.Size(350, 22)
        Me.PGröße.TabIndex = 4
        Me.PGröße.Text = "Perzentil (%) für Größe"
        '
        'PGewicht
        '
        Me.PGewicht.Location = New System.Drawing.Point(267, 263)
        Me.PGewicht.Name = "PGewicht"
        Me.PGewicht.Size = New System.Drawing.Size(350, 22)
        Me.PGewicht.TabIndex = 5
        Me.PGewicht.Text = "Perzentil (%) für Gewicht"
        '
        'RadioMale
        '
        Me.RadioMale.AutoSize = True
        Me.RadioMale.Location = New System.Drawing.Point(305, 327)
        Me.RadioMale.Name = "RadioMale"
        Me.RadioMale.Size = New System.Drawing.Size(59, 21)
        Me.RadioMale.TabIndex = 6
        Me.RadioMale.TabStop = True
        Me.RadioMale.Text = "Male"
        Me.RadioMale.UseVisualStyleBackColor = True
        '
        'RadioFemale
        '
        Me.RadioFemale.AutoSize = True
        Me.RadioFemale.Location = New System.Drawing.Point(447, 327)
        Me.RadioFemale.Name = "RadioFemale"
        Me.RadioFemale.Size = New System.Drawing.Size(75, 21)
        Me.RadioFemale.TabIndex = 7
        Me.RadioFemale.TabStop = True
        Me.RadioFemale.Text = "Female"
        Me.RadioFemale.UseVisualStyleBackColor = True
        '
        'Alter
        '
        Me.Alter.FormattingEnabled = True
        Me.Alter.ItemHeight = 16
        Me.Alter.Items.AddRange(New Object() {"4 Monate", "5 Monate", "6 Monate", "7 Monate", "7.5 Monate", "8 Monate", "8.5 Monate", "9 Monate", "9.5 Monate", "10 Monate", "10.5 Monate", "11 Monate", "12 Monate", "15 Monate", "18 Monate", "21 Monate", "2 Jahre", "2.5 Jahre", "3 Jahre", "3.5 Jahre ", "4 Jahre", "4.5 Jahre", "5 Jahre", "5.5 Jahre", "6 Jahre", "6.5 Jahre", "7 Jahre", "7.5 Jahre", "8 Jahre", "8.5 Jahre", "9 Jahre", "9.5 Jahre", "10 Jahre", "10.5 Jahre", "11 Jahre", "11.5 Jahre", "12 Jahre", "12.5 Jahre", "13 Jahre", "13.5 Jahre", "14 Jahre", "14.5 Jahre", "15 Jahre", "15.5 Jahre", "16 Jahre", "16.5 Jahre", "17 Jahre", "17.5 Jahre", "18 Jahre"})
        Me.Alter.Location = New System.Drawing.Point(365, 71)
        Me.Alter.Name = "Alter"
        Me.Alter.Size = New System.Drawing.Size(252, 20)
        Me.Alter.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(264, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Age"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(264, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Hight in cm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(264, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Weight in kg"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Alter)
        Me.Controls.Add(Me.RadioFemale)
        Me.Controls.Add(Me.RadioMale)
        Me.Controls.Add(Me.PGewicht)
        Me.Controls.Add(Me.PGröße)
        Me.Controls.Add(Me.WeightInKg)
        Me.Controls.Add(Me.HightInCm)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Pezentilenrechner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents HightInCm As TextBox
    Friend WithEvents WeightInKg As TextBox
    Friend WithEvents PGröße As TextBox
    Friend WithEvents PGewicht As TextBox
    Friend WithEvents RadioMale As RadioButton
    Friend WithEvents RadioFemale As RadioButton
    Friend WithEvents Alter As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
