<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UpdateHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XemSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XemKháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateHàngToolStripMenuItem, Me.KháchHàngToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(383, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UpdateHàngToolStripMenuItem
        '
        Me.UpdateHàngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XemSảnPhẩmToolStripMenuItem})
        Me.UpdateHàngToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow
        Me.UpdateHàngToolStripMenuItem.Name = "UpdateHàngToolStripMenuItem"
        Me.UpdateHàngToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.UpdateHàngToolStripMenuItem.Text = "Update Hàng"
        '
        'XemSảnPhẩmToolStripMenuItem
        '
        Me.XemSảnPhẩmToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.XemSảnPhẩmToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow
        Me.XemSảnPhẩmToolStripMenuItem.Name = "XemSảnPhẩmToolStripMenuItem"
        Me.XemSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.XemSảnPhẩmToolStripMenuItem.Text = "Xem sản phẩm"
        '
        'KháchHàngToolStripMenuItem
        '
        Me.KháchHàngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XemKháchHàngToolStripMenuItem})
        Me.KháchHàngToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow
        Me.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
        Me.KháchHàngToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.KháchHàngToolStripMenuItem.Text = "Khách hàng"
        '
        'XemKháchHàngToolStripMenuItem
        '
        Me.XemKháchHàngToolStripMenuItem.Name = "XemKháchHàngToolStripMenuItem"
        Me.XemKháchHàngToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.XemKháchHàngToolStripMenuItem.Text = "Xem khách hàng"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(383, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UpdateHàngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XemSảnPhẩmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KháchHàngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XemKháchHàngToolStripMenuItem As ToolStripMenuItem
End Class
