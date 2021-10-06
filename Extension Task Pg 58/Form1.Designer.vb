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
        Me.LBOutputMultiples = New System.Windows.Forms.ListBox()
        Me.BTNPrime = New System.Windows.Forms.Button()
        Me.TBInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LBOutputMultiples
        '
        Me.LBOutputMultiples.FormattingEnabled = True
        Me.LBOutputMultiples.ItemHeight = 15
        Me.LBOutputMultiples.Location = New System.Drawing.Point(25, 136)
        Me.LBOutputMultiples.Name = "LBOutputMultiples"
        Me.LBOutputMultiples.Size = New System.Drawing.Size(217, 124)
        Me.LBOutputMultiples.TabIndex = 0
        '
        'BTNPrime
        '
        Me.BTNPrime.Location = New System.Drawing.Point(271, 44)
        Me.BTNPrime.Name = "BTNPrime"
        Me.BTNPrime.Size = New System.Drawing.Size(103, 60)
        Me.BTNPrime.TabIndex = 1
        Me.BTNPrime.Text = "Prime ?"
        Me.BTNPrime.UseVisualStyleBackColor = True
        '
        'TBInput
        '
        Me.TBInput.Location = New System.Drawing.Point(25, 44)
        Me.TBInput.Name = "TBInput"
        Me.TBInput.Size = New System.Drawing.Size(217, 23)
        Me.TBInput.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Input Number"
        '
        'TBOutput
        '
        Me.TBOutput.Location = New System.Drawing.Point(25, 92)
        Me.TBOutput.Name = "TBOutput"
        Me.TBOutput.Size = New System.Drawing.Size(217, 23)
        Me.TBOutput.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 303)
        Me.Controls.Add(Me.TBOutput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBInput)
        Me.Controls.Add(Me.BTNPrime)
        Me.Controls.Add(Me.LBOutputMultiples)
        Me.Name = "Form1"
        Me.Text = "Modulus Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBOutputMultiples As ListBox
    Friend WithEvents BTNPrime As Button
    Friend WithEvents TBInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBOutput As TextBox
End Class
