<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmxemkhachhang
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
        Me.btnDong = New System.Windows.Forms.Button()
        Me.dgvXemkh = New System.Windows.Forms.DataGridView()
        Me.btnXemall = New System.Windows.Forms.Button()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.txtMAKH = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvXemkh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(424, 70)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 23)
        Me.btnDong.TabIndex = 10
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'dgvXemkh
        '
        Me.dgvXemkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXemkh.Location = New System.Drawing.Point(12, 99)
        Me.dgvXemkh.Name = "dgvXemkh"
        Me.dgvXemkh.Size = New System.Drawing.Size(570, 239)
        Me.dgvXemkh.TabIndex = 9
        '
        'btnXemall
        '
        Me.btnXemall.Location = New System.Drawing.Point(424, 41)
        Me.btnXemall.Name = "btnXemall"
        Me.btnXemall.Size = New System.Drawing.Size(75, 23)
        Me.btnXemall.TabIndex = 7
        Me.btnXemall.Text = "Xem tất cả"
        Me.btnXemall.UseVisualStyleBackColor = True
        '
        'btnXem
        '
        Me.btnXem.Location = New System.Drawing.Point(424, 12)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 23)
        Me.btnXem.TabIndex = 8
        Me.btnXem.Text = "Xem"
        Me.btnXem.UseVisualStyleBackColor = True
        '
        'txtMAKH
        '
        Me.txtMAKH.Location = New System.Drawing.Point(108, 19)
        Me.txtMAKH.Name = "txtMAKH"
        Me.txtMAKH.Size = New System.Drawing.Size(160, 20)
        Me.txtMAKH.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-46, -14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mã SP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Mã KH"
        '
        'frmxemkhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 350)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.dgvXemkh)
        Me.Controls.Add(Me.btnXemall)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.txtMAKH)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmxemkhachhang"
        Me.Text = "frmxemkhachhang"
        CType(Me.dgvXemkh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDong As Button
    Friend WithEvents dgvXemkh As DataGridView
    Friend WithEvents btnXemall As Button
    Friend WithEvents btnXem As Button
    Friend WithEvents txtMAKH As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
