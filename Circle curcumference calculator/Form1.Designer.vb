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
        Me.BTNArea = New System.Windows.Forms.Button()
        Me.BTNCircumference = New System.Windows.Forms.Button()
        Me.TBRadius = New System.Windows.Forms.TextBox()
        Me.TBCircumference = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBArea = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BTNArea
        '
        Me.BTNArea.Location = New System.Drawing.Point(336, 44)
        Me.BTNArea.Name = "BTNArea"
        Me.BTNArea.Size = New System.Drawing.Size(104, 56)
        Me.BTNArea.TabIndex = 0
        Me.BTNArea.Text = "Calculate Area"
        Me.BTNArea.UseVisualStyleBackColor = True
        '
        'BTNCircumference
        '
        Me.BTNCircumference.Location = New System.Drawing.Point(336, 127)
        Me.BTNCircumference.Name = "BTNCircumference"
        Me.BTNCircumference.Size = New System.Drawing.Size(104, 56)
        Me.BTNCircumference.TabIndex = 1
        Me.BTNCircumference.Text = "Calculate Circumference"
        Me.BTNCircumference.UseVisualStyleBackColor = True
        '
        'TBRadius
        '
        Me.TBRadius.Location = New System.Drawing.Point(22, 62)
        Me.TBRadius.Name = "TBRadius"
        Me.TBRadius.Size = New System.Drawing.Size(295, 23)
        Me.TBRadius.TabIndex = 2
        '
        'TBCircumference
        '
        Me.TBCircumference.Location = New System.Drawing.Point(177, 127)
        Me.TBCircumference.Name = "TBCircumference"
        Me.TBCircumference.Size = New System.Drawing.Size(153, 23)
        Me.TBCircumference.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Radius"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Calculated Circumference"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.CadetBlue
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Circumference Calculator"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Calculated Area"
        '
        'TBArea
        '
        Me.TBArea.Location = New System.Drawing.Point(177, 159)
        Me.TBArea.Name = "TBArea"
        Me.TBArea.Size = New System.Drawing.Size(153, 23)
        Me.TBArea.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 208)
        Me.Controls.Add(Me.TBArea)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBCircumference)
        Me.Controls.Add(Me.TBRadius)
        Me.Controls.Add(Me.BTNCircumference)
        Me.Controls.Add(Me.BTNArea)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNArea As Button
    Friend WithEvents BTNCircumference As Button
    Friend WithEvents TBRadius As TextBox
    Friend WithEvents TBCircumference As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TBArea As TextBox
End Class
