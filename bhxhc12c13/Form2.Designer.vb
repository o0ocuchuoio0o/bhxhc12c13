<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.diachiphuongxa = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MaBC = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 43)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Quay lại"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'diachiphuongxa
        '
        Me.diachiphuongxa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diachiphuongxa.Location = New System.Drawing.Point(115, 70)
        Me.diachiphuongxa.Name = "diachiphuongxa"
        Me.diachiphuongxa.Size = New System.Drawing.Size(462, 29)
        Me.diachiphuongxa.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(664, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 39)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Nhập"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MaBC
        '
        Me.MaBC.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaBC.Location = New System.Drawing.Point(115, 105)
        Me.MaBC.Name = "MaBC"
        Me.MaBC.Size = New System.Drawing.Size(250, 38)
        Me.MaBC.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(178, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(664, 84)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 39)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Ko Nhập"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(113, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(530, 29)
        Me.label1.TabIndex = 7
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(290, 261)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 43)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "test"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 307)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MaBC)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.diachiphuongxa)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents diachiphuongxa As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MaBC As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents label1 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
