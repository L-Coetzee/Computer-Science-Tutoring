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
        Me.TBEngineType = New System.Windows.Forms.TextBox()
        Me.TBEngineCapacity = New System.Windows.Forms.TextBox()
        Me.TBMileage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBEmissions = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTNCalculate
        '
        Me.BTNCalculate.Location = New System.Drawing.Point(193, 83)
        Me.BTNCalculate.Name = "BTNCalculate"
        Me.BTNCalculate.Size = New System.Drawing.Size(76, 81)
        Me.BTNCalculate.TabIndex = 0
        Me.BTNCalculate.Text = "Calculate Emissions"
        Me.BTNCalculate.UseVisualStyleBackColor = True
        '
        'TBEngineType
        '
        Me.TBEngineType.Location = New System.Drawing.Point(12, 40)
        Me.TBEngineType.Name = "TBEngineType"
        Me.TBEngineType.Size = New System.Drawing.Size(163, 23)
        Me.TBEngineType.TabIndex = 1
        '
        'TBEngineCapacity
        '
        Me.TBEngineCapacity.Location = New System.Drawing.Point(12, 134)
        Me.TBEngineCapacity.Name = "TBEngineCapacity"
        Me.TBEngineCapacity.Size = New System.Drawing.Size(163, 23)
        Me.TBEngineCapacity.TabIndex = 2
        '
        'TBMileage
        '
        Me.TBMileage.Location = New System.Drawing.Point(12, 86)
        Me.TBMileage.Name = "TBMileage"
        Me.TBMileage.Size = New System.Drawing.Size(163, 23)
        Me.TBMileage.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Input Engine Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Input Mileage"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Input Engine Capacity"
        '
        'TBEmissions
        '
        Me.TBEmissions.Location = New System.Drawing.Point(12, 178)
        Me.TBEmissions.Name = "TBEmissions"
        Me.TBEmissions.Size = New System.Drawing.Size(163, 23)
        Me.TBEmissions.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Emissions"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 221)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBEmissions)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBMileage)
        Me.Controls.Add(Me.TBEngineCapacity)
        Me.Controls.Add(Me.TBEngineType)
        Me.Controls.Add(Me.BTNCalculate)
        Me.Name = "Form1"
        Me.Text = "CO2 Calculator (Case)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNCalculate As Button
    Friend WithEvents TBEngineType As TextBox
    Friend WithEvents TBEngineCapacity As TextBox
    Friend WithEvents TBMileage As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TBEmissions As TextBox
    Friend WithEvents Label4 As Label
End Class
