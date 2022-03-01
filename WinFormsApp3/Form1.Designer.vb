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
        Me.SuspendLayout()
        '
        'InputBox
        '
        Me.InputBox.Location = New System.Drawing.Point(48, 143)
        Me.InputBox.Name = "InputBox"
        Me.InputBox.Size = New System.Drawing.Size(279, 39)
        Me.InputBox.TabIndex = 0
        '
        'Multiplikation
        '
        Me.Multiplikation.AutoSize = True
        Me.Multiplikation.Location = New System.Drawing.Point(48, 69)
        Me.Multiplikation.Name = "Multiplikation"
        Me.Multiplikation.Size = New System.Drawing.Size(70, 32)
        Me.Multiplikation.TabIndex = 1
        Me.Multiplikation.Text = "Multi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Multiplikation)
        Me.Controls.Add(Me.InputBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InputBox As TextBox
    Friend WithEvents Multiplikation As Label
End Class
