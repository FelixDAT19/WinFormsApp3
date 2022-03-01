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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "Resultat"}, -1)
        Me.InputBox = New System.Windows.Forms.TextBox()
        Me.Multiplikation = New System.Windows.Forms.Label()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.Result = New System.Windows.Forms.PictureBox()
        Me.Streak = New System.Windows.Forms.Label()
        Me.lblhighscore = New System.Windows.Forms.Label()
        Me.ResultView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        CType(Me.Result, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InputBox
        '
        Me.InputBox.Location = New System.Drawing.Point(48, 143)
        Me.InputBox.Margin = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.InputBox.Name = "InputBox"
        Me.InputBox.Size = New System.Drawing.Size(278, 39)
        Me.InputBox.TabIndex = 0
        '
        'Multiplikation
        '
        Me.Multiplikation.AutoSize = True
        Me.Multiplikation.Location = New System.Drawing.Point(48, 68)
        Me.Multiplikation.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Multiplikation.Name = "Multiplikation"
        Me.Multiplikation.Size = New System.Drawing.Size(70, 32)
        Me.Multiplikation.TabIndex = 1
        Me.Multiplikation.Text = "Multi"
        '
        'Calculate
        '
        Me.Calculate.Location = New System.Drawing.Point(48, 233)
        Me.Calculate.Margin = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(278, 73)
        Me.Calculate.TabIndex = 2
        Me.Calculate.Text = "Räkna"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'Result
        '
        Me.Result.Location = New System.Drawing.Point(480, 143)
        Me.Result.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(238, 163)
        Me.Result.TabIndex = 3
        Me.Result.TabStop = False
        '
        'Streak
        '
        Me.Streak.AutoSize = True
        Me.Streak.Location = New System.Drawing.Point(478, 68)
        Me.Streak.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Streak.Name = "Streak"
        Me.Streak.Size = New System.Drawing.Size(84, 32)
        Me.Streak.TabIndex = 4
        Me.Streak.Text = "Streak:"
        '
        'lblhighscore
        '
        Me.lblhighscore.AutoSize = True
        Me.lblhighscore.Location = New System.Drawing.Point(480, 108)
        Me.lblhighscore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblhighscore.Name = "lblhighscore"
        Me.lblhighscore.Size = New System.Drawing.Size(121, 32)
        Me.lblhighscore.TabIndex = 5
        Me.lblhighscore.Text = "Highscore"
        '
        'ResultView
        '
        Me.ResultView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ResultView.HideSelection = False
        Me.ResultView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.ResultView.Location = New System.Drawing.Point(823, 68)
        Me.ResultView.Name = "ResultView"
        Me.ResultView.Size = New System.Drawing.Size(249, 238)
        Me.ResultView.TabIndex = 6
        Me.ResultView.UseCompatibleStateImageBehavior = False
        Me.ResultView.View = System.Windows.Forms.View.List
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Resultat"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 363)
        Me.Controls.Add(Me.ResultView)
        Me.Controls.Add(Me.lblhighscore)
        Me.Controls.Add(Me.Streak)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.Multiplikation)
        Me.Controls.Add(Me.InputBox)
        Me.Margin = New System.Windows.Forms.Padding(1, 3, 1, 3)
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
    Friend WithEvents lblhighscore As Label
    Friend WithEvents ResultView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
End Class
