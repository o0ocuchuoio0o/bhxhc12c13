<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.tx = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gr = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.nm = New System.Windows.Forms.ComboBox()
        Me.th = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.gr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tx
        '
        Me.tx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx.Location = New System.Drawing.Point(124, 60)
        Me.tx.Name = "tx"
        Me.tx.Size = New System.Drawing.Size(292, 26)
        Me.tx.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(441, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Kiểm tra"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gr
        '
        Me.gr.Cursor = System.Windows.Forms.Cursors.Default
        Me.gr.Location = New System.Drawing.Point(15, 100)
        Me.gr.MainView = Me.GridView1
        Me.gr.Name = "gr"
        Me.gr.Size = New System.Drawing.Size(1000, 165)
        Me.gr.TabIndex = 2
        Me.gr.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gr
        Me.GridView1.Name = "GridView1"
        '
        'nm
        '
        Me.nm.FormattingEnabled = True
        Me.nm.Location = New System.Drawing.Point(329, 3)
        Me.nm.Name = "nm"
        Me.nm.Size = New System.Drawing.Size(79, 21)
        Me.nm.TabIndex = 48
        '
        'th
        '
        Me.th.Location = New System.Drawing.Point(265, 3)
        Me.th.Name = "th"
        Me.th.Size = New System.Drawing.Size(46, 21)
        Me.th.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Tháng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Nhập mã"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(-2, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 35)
        Me.Button2.TabIndex = 55
        Me.Button2.Text = "Quay về"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 321)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nm)
        Me.Controls.Add(Me.th)
        Me.Controls.Add(Me.gr)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tx)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tx As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents gr As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nm As System.Windows.Forms.ComboBox
    Friend WithEvents th As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
