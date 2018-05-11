<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ThemLoaiDocGia
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_MaloaiDocGia = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Bt_Nhap = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(69, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Loại Độc Giả"
        '
        'txt_MaloaiDocGia
        '
        Me.txt_MaloaiDocGia.Location = New System.Drawing.Point(349, 44)
        Me.txt_MaloaiDocGia.Name = "txt_MaloaiDocGia"
        Me.txt_MaloaiDocGia.ReadOnly = True
        Me.txt_MaloaiDocGia.Size = New System.Drawing.Size(220, 26)
        Me.txt_MaloaiDocGia.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(349, 85)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(220, 26)
        Me.TextBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(69, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 41)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên Loại Độc Giả"
        '
        'Bt_Nhap
        '
        Me.Bt_Nhap.Location = New System.Drawing.Point(262, 169)
        Me.Bt_Nhap.Name = "Bt_Nhap"
        Me.Bt_Nhap.Size = New System.Drawing.Size(149, 45)
        Me.Bt_Nhap.TabIndex = 4
        Me.Bt_Nhap.Text = "Nhập"
        Me.Bt_Nhap.UseVisualStyleBackColor = True
        '
        'Frm_ThemLoaiDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 226)
        Me.Controls.Add(Me.Bt_Nhap)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_MaloaiDocGia)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_ThemLoaiDocGia"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm Loại Độc Giả"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_MaloaiDocGia As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Bt_Nhap As Button
End Class
