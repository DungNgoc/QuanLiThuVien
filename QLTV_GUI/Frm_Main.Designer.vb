<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QuảnLíĐộcGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmLoạiĐộcGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLíLoạiĐộcGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ThêmĐộcGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLíĐộcGiảToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLíĐộcGiảToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(900, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuảnLíĐộcGiảToolStripMenuItem
        '
        Me.QuảnLíĐộcGiảToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThêmLoạiĐộcGiảToolStripMenuItem, Me.QuảnLíLoạiĐộcGiảToolStripMenuItem, Me.ToolStripSeparator1, Me.ThêmĐộcGiảToolStripMenuItem, Me.QuảnLíĐộcGiảToolStripMenuItem1})
        Me.QuảnLíĐộcGiảToolStripMenuItem.Name = "QuảnLíĐộcGiảToolStripMenuItem"
        Me.QuảnLíĐộcGiảToolStripMenuItem.Size = New System.Drawing.Size(144, 29)
        Me.QuảnLíĐộcGiảToolStripMenuItem.Text = "Quản lí độc giả"
        '
        'ThêmLoạiĐộcGiảToolStripMenuItem
        '
        Me.ThêmLoạiĐộcGiảToolStripMenuItem.Name = "ThêmLoạiĐộcGiảToolStripMenuItem"
        Me.ThêmLoạiĐộcGiảToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ThêmLoạiĐộcGiảToolStripMenuItem.Text = "Thêm loại độc giả"
        '
        'QuảnLíLoạiĐộcGiảToolStripMenuItem
        '
        Me.QuảnLíLoạiĐộcGiảToolStripMenuItem.Name = "QuảnLíLoạiĐộcGiảToolStripMenuItem"
        Me.QuảnLíLoạiĐộcGiảToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.QuảnLíLoạiĐộcGiảToolStripMenuItem.Text = "Quản lí loại độc giả"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(249, 6)
        '
        'ThêmĐộcGiảToolStripMenuItem
        '
        Me.ThêmĐộcGiảToolStripMenuItem.Name = "ThêmĐộcGiảToolStripMenuItem"
        Me.ThêmĐộcGiảToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ThêmĐộcGiảToolStripMenuItem.Text = "Thêm độc giả"
        '
        'QuảnLíĐộcGiảToolStripMenuItem1
        '
        Me.QuảnLíĐộcGiảToolStripMenuItem1.Name = "QuảnLíĐộcGiảToolStripMenuItem1"
        Me.QuảnLíĐộcGiảToolStripMenuItem1.Size = New System.Drawing.Size(252, 30)
        Me.QuảnLíĐộcGiảToolStripMenuItem1.Text = "Quản lí độc giả"
        '
        'Frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_Main"
        Me.Text = "Frm_Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents QuảnLíĐộcGiảToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThêmLoạiĐộcGiảToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThêmĐộcGiảToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLíĐộcGiảToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents QuảnLíLoạiĐộcGiảToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
