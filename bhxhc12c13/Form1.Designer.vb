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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.nm = New System.Windows.Forms.ComboBox()
        Me.th = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pr1 = New System.Windows.Forms.ProgressBar()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.rd1 = New System.Windows.Forms.RadioButton()
        Me.rd2 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lnhap = New System.Windows.Forms.Label()
        Me.cblan = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 48)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Xử lý dữ liệu từ BHHN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'nm
        '
        Me.nm.FormattingEnabled = True
        Me.nm.Location = New System.Drawing.Point(339, 48)
        Me.nm.Name = "nm"
        Me.nm.Size = New System.Drawing.Size(79, 21)
        Me.nm.TabIndex = 24
        '
        'th
        '
        Me.th.Location = New System.Drawing.Point(275, 48)
        Me.th.Name = "th"
        Me.th.Size = New System.Drawing.Size(46, 21)
        Me.th.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Tháng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(158, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(473, 29)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Xử lý Dữ liệu C12, C13 nhận của BHHN"
        '
        'pr1
        '
        Me.pr1.Location = New System.Drawing.Point(210, 113)
        Me.pr1.Name = "pr1"
        Me.pr1.Size = New System.Drawing.Size(228, 23)
        Me.pr1.Step = 1
        Me.pr1.TabIndex = 38
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(26, 313)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 48)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Kiểm tra phong bì Datapost"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(26, 250)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(137, 48)
        Me.Button3.TabIndex = 40
        Me.Button3.Text = "Kiểm tra dữ liệu"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'rd1
        '
        Me.rd1.AutoSize = True
        Me.rd1.Checked = True
        Me.rd1.Location = New System.Drawing.Point(289, 75)
        Me.rd1.Name = "rd1"
        Me.rd1.Size = New System.Drawing.Size(44, 17)
        Me.rd1.TabIndex = 41
        Me.rd1.TabStop = True
        Me.rd1.Text = "C12"
        Me.rd1.UseVisualStyleBackColor = True
        '
        'rd2
        '
        Me.rd2.AutoSize = True
        Me.rd2.Location = New System.Drawing.Point(339, 75)
        Me.rd2.Name = "rd2"
        Me.rd2.Size = New System.Drawing.Size(44, 17)
        Me.rd2.TabIndex = 42
        Me.rd2.Text = "C13"
        Me.rd2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 519)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Label1"
        '
        'lnhap
        '
        Me.lnhap.AutoSize = True
        Me.lnhap.Location = New System.Drawing.Point(458, 122)
        Me.lnhap.Name = "lnhap"
        Me.lnhap.Size = New System.Drawing.Size(0, 13)
        Me.lnhap.TabIndex = 44
        '
        'cblan
        '
        Me.cblan.Location = New System.Drawing.Point(480, 48)
        Me.cblan.Name = "cblan"
        Me.cblan.Size = New System.Drawing.Size(46, 21)
        Me.cblan.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(437, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Lần gửi"
        '
        'grid
        '
        Me.grid.Cursor = System.Windows.Forms.Cursors.Default
        Me.grid.Location = New System.Drawing.Point(192, 113)
        Me.grid.MainView = Me.GridView1
        Me.grid.Name = "grid"
        Me.grid.Size = New System.Drawing.Size(1000, 600)
        Me.grid.TabIndex = 47
        Me.grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grid
        Me.GridView1.Name = "GridView1"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(26, 122)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(137, 48)
        Me.Button4.TabIndex = 48
        Me.Button4.Text = "Nhận dữ liệu từ BHHN"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(26, 383)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(137, 48)
        Me.Button5.TabIndex = 49
        Me.Button5.Text = "Kết thúc"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 541)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cblan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lnhap)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rd2)
        Me.Controls.Add(Me.rd1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.pr1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nm)
        Me.Controls.Add(Me.th)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents nm As System.Windows.Forms.ComboBox
    Friend WithEvents th As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pr1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents rd1 As System.Windows.Forms.RadioButton
    Friend WithEvents rd2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lnhap As System.Windows.Forms.Label
    Friend WithEvents cblan As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button

End Class
