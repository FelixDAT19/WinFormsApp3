<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.InputBox = New System.Windows.Forms.TextBox()
        Me.Multiplikation = New System.Windows.Forms.Label()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.Result = New System.Windows.Forms.PictureBox()
        Me.Streak = New System.Windows.Forms.Label()
        Me.Txt23 = New System.Windows.Forms.TextBox()
        CType(Me.Result, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InputBox
        '
        Me.InputBox.Location = New System.Drawing.Point(26, 67)
        Me.InputBox.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.InputBox.Name = "InputBox"
        Me.InputBox.Size = New System.Drawing.Size(152, 23)
        Me.InputBox.TabIndex = 0
        '
        'Multiplikation
        '
        Me.Multiplikation.AutoSize = True
        Me.Multiplikation.Location = New System.Drawing.Point(26, 32)
        Me.Multiplikation.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Multiplikation.Name = "Multiplikation"
        Me.Multiplikation.Size = New System.Drawing.Size(35, 15)
        Me.Multiplikation.TabIndex = 1
        Me.Multiplikation.Text = "Multi"
        '
        'Calculate
        '
        Me.Calculate.Location = New System.Drawing.Point(26, 109)
        Me.Calculate.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(150, 34)
        Me.Calculate.TabIndex = 2
        Me.Calculate.Text = "Räkna"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'Result
        '
        Me.Result.Location = New System.Drawing.Point(258, 67)
        Me.Result.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(128, 76)
        Me.Result.TabIndex = 3
        Me.Result.TabStop = False
        '
        'Streak
        '
        Me.Streak.AutoSize = True
        Me.Streak.Location = New System.Drawing.Point(258, 32)
        Me.Streak.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Streak.Name = "Streak"
        Me.Streak.Size = New System.Drawing.Size(42, 15)
        Me.Streak.TabIndex = 4
        Me.Streak.Text = "Streak:"
        '
        'Txt23
        '
        Me.Txt23.Location = New System.Drawing.Point(200, 176)
        Me.Txt23.Name = "Txt23"
        Me.Txt23.Size = New System.Drawing.Size(100, 23)
        Me.Txt23.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 211)
        Me.Controls.Add(Me.Txt23)
        Me.Controls.Add(Me.Streak)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.Multiplikation)
        Me.Controls.Add(Me.InputBox)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Result, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InputBox As TextBox
    Friend WithEvents Multiplikation As Label
    Friend WithEvents Calculate As Button
    Friend WithEvents Result As PictureBox
    Friend WithEvents Streak As Label
    Friend WithEvents Txt23 As TextBox
End Class
