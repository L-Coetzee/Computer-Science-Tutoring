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
        Me.BTNCalculateVolume = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBHeight = New System.Windows.Forms.TextBox()
        Me.TBWidth = New System.Windows.Forms.TextBox()
        Me.TBDepth = New System.Windows.Forms.TextBox()
        Me.TBVolume = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTNCalculateVolume
        '
        Me.BTNCalculateVolume.Location = New System.Drawing.Point(282, 154)
        Me.BTNCalculateVolume.Name = "BTNCalculateVolume"
        Me.BTNCalculateVolume.Size = New System.Drawing.Size(87, 52)
        Me.BTNCalculateVolume.TabIndex = 0
        Me.BTNCalculateVolume.Text = "Calculate Volume"
        Me.BTNCalculateVolume.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Height"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Width"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Depth"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Volume in Litres"
        '
        'TBHeight
        '
        Me.TBHeight.Location = New System.Drawing.Point(72, 76)
        Me.TBHeight.Name = "TBHeight"
        Me.TBHeight.Size = New System.Drawing.Size(182, 23)
        Me.TBHeight.TabIndex = 5
        '
        'TBWidth
        '
        Me.TBWidth.Location = New System.Drawing.Point(72, 125)
        Me.TBWidth.Name = "TBWidth"
        Me.TBWidth.Size = New System.Drawing.Size(182, 23)
        Me.TBWidth.TabIndex = 6
        '
        'TBDepth
        '
        Me.TBDepth.Location = New System.Drawing.Point(72, 183)
        Me.TBDepth.Name = "TBDepth"
        Me.TBDepth.Size = New System.Drawing.Size(182, 23)
        Me.TBDepth.TabIndex = 7
        '
        'TBVolume
        '
        Me.TBVolume.Location = New System.Drawing.Point(109, 237)
        Me.TBVolume.Name = "TBVolume"
        Me.TBVolume.Size = New System.Drawing.Size(182, 23)
        Me.TBVolume.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.CadetBlue
        Me.Label5.Location = New System.Drawing.Point(90, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(185, 28)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Volume Calculator"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 285)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBVolume)
        Me.Controls.Add(Me.TBDepth)
        Me.Controls.Add(Me.TBWidth)
        Me.Controls.Add(Me.TBHeight)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNCalculateVolume)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNCalculateVolume As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TBHeight As TextBox
    Friend WithEvents TBWidth As TextBox
    Friend WithEvents TBDepth As TextBox
    Friend WithEvents TBVolume As TextBox
    Friend WithEvents Label5 As Label
End Class
