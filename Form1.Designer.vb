<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListBoxSource = New System.Windows.Forms.ListBox()
        Me.ListBoxTarget = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonCheck = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxSource
        '
        Me.ListBoxSource.FormattingEnabled = True
        Me.ListBoxSource.ItemHeight = 16
        Me.ListBoxSource.Location = New System.Drawing.Point(30, 50)
        Me.ListBoxSource.Name = "ListBoxSource"
        Me.ListBoxSource.Size = New System.Drawing.Size(150, 180)
        Me.ListBoxSource.TabIndex = 0
        '
        'ListBoxTarget
        '
        Me.ListBoxTarget.AllowDrop = True
        Me.ListBoxTarget.FormattingEnabled = True
        Me.ListBoxTarget.ItemHeight = 16
        Me.ListBoxTarget.Location = New System.Drawing.Point(250, 50)
        Me.ListBoxTarget.Name = "ListBoxTarget"
        Me.ListBoxTarget.Size = New System.Drawing.Size(150, 180)
        Me.ListBoxTarget.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Исходный список"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(250, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Отсортируйте здесь"
        '
        'ButtonCheck
        '
        Me.ButtonCheck.Location = New System.Drawing.Point(160, 250)
        Me.ButtonCheck.Name = "ButtonCheck"
        Me.ButtonCheck.Size = New System.Drawing.Size(120, 30)
        Me.ButtonCheck.TabIndex = 4
        Me.ButtonCheck.Text = "Проверить"
        Me.ButtonCheck.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 303)
        Me.Controls.Add(Me.ButtonCheck)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxTarget)
        Me.Controls.Add(Me.ListBoxSource)
        Me.Name = "Form1"
        Me.Text = "Расположи по алфавиту"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents ListBoxSource As ListBox
    Friend WithEvents ListBoxTarget As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonCheck As Button
End Class
