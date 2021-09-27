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
        Me.BTNEquals = New System.Windows.Forms.Button()
        Me.TBInputOutput = New System.Windows.Forms.TextBox()
        Me.BTNAdd = New System.Windows.Forms.Button()
        Me.BTNDivide = New System.Windows.Forms.Button()
        Me.BTNSub = New System.Windows.Forms.Button()
        Me.BTNMultiply = New System.Windows.Forms.Button()
        Me.BTNClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTNEquals
        '
        Me.BTNEquals.Location = New System.Drawing.Point(229, 100)
        Me.BTNEquals.Name = "BTNEquals"
        Me.BTNEquals.Size = New System.Drawing.Size(50, 105)
        Me.BTNEquals.TabIndex = 0
        Me.BTNEquals.Text = "Equals"
        Me.BTNEquals.UseVisualStyleBackColor = True
        '
        'TBInputOutput
        '
        Me.TBInputOutput.Location = New System.Drawing.Point(43, 58)
        Me.TBInputOutput.Name = "TBInputOutput"
        Me.TBInputOutput.Size = New System.Drawing.Size(236, 23)
        Me.TBInputOutput.TabIndex = 2
        '
        'BTNAdd
        '
        Me.BTNAdd.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BTNAdd.Location = New System.Drawing.Point(43, 100)
        Me.BTNAdd.Name = "BTNAdd"
        Me.BTNAdd.Size = New System.Drawing.Size(51, 51)
        Me.BTNAdd.TabIndex = 3
        Me.BTNAdd.Text = "+"
        Me.BTNAdd.UseVisualStyleBackColor = True
        '
        'BTNDivide
        '
        Me.BTNDivide.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BTNDivide.Location = New System.Drawing.Point(100, 100)
        Me.BTNDivide.Name = "BTNDivide"
        Me.BTNDivide.Size = New System.Drawing.Size(51, 51)
        Me.BTNDivide.TabIndex = 4
        Me.BTNDivide.Text = "/"
        Me.BTNDivide.UseVisualStyleBackColor = True
        '
        'BTNSub
        '
        Me.BTNSub.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BTNSub.Location = New System.Drawing.Point(43, 155)
        Me.BTNSub.Name = "BTNSub"
        Me.BTNSub.Size = New System.Drawing.Size(51, 51)
        Me.BTNSub.TabIndex = 5
        Me.BTNSub.Text = "-"
        Me.BTNSub.UseVisualStyleBackColor = True
        '
        'BTNMultiply
        '
        Me.BTNMultiply.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BTNMultiply.Location = New System.Drawing.Point(100, 155)
        Me.BTNMultiply.Name = "BTNMultiply"
        Me.BTNMultiply.Size = New System.Drawing.Size(51, 51)
        Me.BTNMultiply.TabIndex = 6
        Me.BTNMultiply.Text = "X"
        Me.BTNMultiply.UseVisualStyleBackColor = True
        '
        'BTNClear
        '
        Me.BTNClear.Location = New System.Drawing.Point(173, 100)
        Me.BTNClear.Name = "BTNClear"
        Me.BTNClear.Size = New System.Drawing.Size(50, 105)
        Me.BTNClear.TabIndex = 7
        Me.BTNClear.Text = "CLEAR"
        Me.BTNClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 235)
        Me.Controls.Add(Me.BTNClear)
        Me.Controls.Add(Me.BTNMultiply)
        Me.Controls.Add(Me.BTNSub)
        Me.Controls.Add(Me.BTNDivide)
        Me.Controls.Add(Me.BTNAdd)
        Me.Controls.Add(Me.TBInputOutput)
        Me.Controls.Add(Me.BTNEquals)
        Me.Name = "Form1"
        Me.Text = "Calculator V2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNEquals As Button
    Friend WithEvents TBInputOutput As TextBox
    Friend WithEvents BTNAdd As Button
    Friend WithEvents BTNDivide As Button
    Friend WithEvents BTNSub As Button
    Friend WithEvents BTNMultiply As Button
    Friend WithEvents BTNClear As Button
End Class
