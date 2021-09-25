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
        Me.BTNCalculateEmissions = New System.Windows.Forms.Button()
        Me.TBInputEngineCapacity = New System.Windows.Forms.TextBox()
        Me.TBInputMileage = New System.Windows.Forms.TextBox()
        Me.TBInputFuelType = New System.Windows.Forms.TextBox()
        Me.TBOutputEmissions = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTNCalculateEmissions
        '
        Me.BTNCalculateEmissions.Location = New System.Drawing.Point(242, 52)
        Me.BTNCalculateEmissions.Name = "BTNCalculateEmissions"
        Me.BTNCalculateEmissions.Size = New System.Drawing.Size(97, 118)
        Me.BTNCalculateEmissions.TabIndex = 0
        Me.BTNCalculateEmissions.Text = "Calculate"
        Me.BTNCalculateEmissions.UseVisualStyleBackColor = True
        '
        'TBInputEngineCapacity
        '
        Me.TBInputEngineCapacity.Location = New System.Drawing.Point(22, 118)
        Me.TBInputEngineCapacity.Name = "TBInputEngineCapacity"
        Me.TBInputEngineCapacity.Size = New System.Drawing.Size(148, 23)
        Me.TBInputEngineCapacity.TabIndex = 1
        '
        'TBInputMileage
        '
        Me.TBInputMileage.Location = New System.Drawing.Point(22, 168)
        Me.TBInputMileage.Name = "TBInputMileage"
        Me.TBInputMileage.Size = New System.Drawing.Size(148, 23)
        Me.TBInputMileage.TabIndex = 2
        '
        'TBInputFuelType
        '
        Me.TBInputFuelType.Location = New System.Drawing.Point(22, 70)
        Me.TBInputFuelType.Name = "TBInputFuelType"
        Me.TBInputFuelType.Size = New System.Drawing.Size(148, 23)
        Me.TBInputFuelType.TabIndex = 3
        '
        'TBOutputEmissions
        '
        Me.TBOutputEmissions.Location = New System.Drawing.Point(191, 216)
        Me.TBOutputEmissions.Name = "TBOutputEmissions"
        Me.TBOutputEmissions.Size = New System.Drawing.Size(148, 23)
        Me.TBOutputEmissions.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Input Fuel Type (Diesel/Petrol)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Input Engine Capacity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Input Mileage"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(107, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Emissions = "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(107, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 28)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "CO2 Calculator"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 251)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBOutputEmissions)
        Me.Controls.Add(Me.TBInputFuelType)
        Me.Controls.Add(Me.TBInputMileage)
        Me.Controls.Add(Me.TBInputEngineCapacity)
        Me.Controls.Add(Me.BTNCalculateEmissions)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNCalculateEmissions As Button
    Friend WithEvents TBInputEngineCapacity As TextBox
    Friend WithEvents TBInputMileage As TextBox
    Friend WithEvents TBInputFuelType As TextBox
    Friend WithEvents TBOutputEmissions As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
