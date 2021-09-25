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
        Me.BTNCalculate = New System.Windows.Forms.Button()
        Me.TBStudentMark = New System.Windows.Forms.TextBox()
        Me.TBMaxMark = New System.Windows.Forms.TextBox()
        Me.TBGrade = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTNCalculate
        '
        Me.BTNCalculate.Location = New System.Drawing.Point(284, 50)
        Me.BTNCalculate.Name = "BTNCalculate"
        Me.BTNCalculate.Size = New System.Drawing.Size(111, 84)
        Me.BTNCalculate.TabIndex = 0
        Me.BTNCalculate.Text = "Calculate Grade"
        Me.BTNCalculate.UseVisualStyleBackColor = True
        '
        'TBStudentMark
        '
        Me.TBStudentMark.Location = New System.Drawing.Point(34, 50)
        Me.TBStudentMark.Name = "TBStudentMark"
        Me.TBStudentMark.Size = New System.Drawing.Size(107, 23)
        Me.TBStudentMark.TabIndex = 1
        '
        'TBMaxMark
        '
        Me.TBMaxMark.Location = New System.Drawing.Point(162, 50)
        Me.TBMaxMark.Name = "TBMaxMark"
        Me.TBMaxMark.Size = New System.Drawing.Size(107, 23)
        Me.TBMaxMark.TabIndex = 2
        '
        'TBGrade
        '
        Me.TBGrade.Location = New System.Drawing.Point(34, 111)
        Me.TBGrade.Name = "TBGrade"
        Me.TBGrade.Size = New System.Drawing.Size(235, 23)
        Me.TBGrade.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Input Student Mark"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(162, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Input Max Mark"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Grade Achieved"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Chocolate
        Me.Label4.Location = New System.Drawing.Point(206, -2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Exam Grading Calculator"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 162)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBGrade)
        Me.Controls.Add(Me.TBMaxMark)
        Me.Controls.Add(Me.TBStudentMark)
        Me.Controls.Add(Me.BTNCalculate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNCalculate As Button
    Friend WithEvents TBStudentMark As TextBox
    Friend WithEvents TBMaxMark As TextBox
    Friend WithEvents TBGrade As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
