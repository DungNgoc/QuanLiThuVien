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
        Me.Txt_MaloaiDocGia = New System.Windows.Forms.TextBox()
        Me.Txt_TenLoaiDocGia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Nhap = New System.Windows.Forms.Button()
        Me.Btn_NhapVaDong = New System.Windows.Forms.Button()
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
        'Txt_MaloaiDocGia
        '
        Me.Txt_MaloaiDocGia.Location = New System.Drawing.Point(349, 44)
        Me.Txt_MaloaiDocGia.Name = "Txt_MaloaiDocGia"
        Me.Txt_MaloaiDocGia.ReadOnly = True
        Me.Txt_MaloaiDocGia.Size = New System.Drawing.Size(220, 26)
        Me.Txt_MaloaiDocGia.TabIndex = 1
        '
        'Txt_TenLoaiDocGia
        '
        Me.Txt_TenLoaiDocGia.Location = New System.Drawing.Point(349, 85)
        Me.Txt_TenLoaiDocGia.Name = "Txt_TenLoaiDocGia"
        Me.Txt_TenLoaiDocGia.Size = New System.Drawing.Size(220, 26)
        Me.Txt_TenLoaiDocGia.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(69, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 41)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên Loại Độc Giả"
        '
        'Btn_Nhap
        '
        Me.Btn_Nhap.Location = New System.Drawing.Point(94, 169)
        Me.Btn_Nhap.Name = "Btn_Nhap"
        Me.Btn_Nhap.Size = New System.Drawing.Size(149, 45)
        Me.Btn_Nhap.TabIndex = 4
        Me.Btn_Nhap.Text = "Nhập"
        Me.Btn_Nhap.UseVisualStyleBackColor = True
        '
        'Btn_NhapVaDong
        '
        Me.Btn_NhapVaDong.Location = New System.Drawing.Point(420, 169)
        Me.Btn_NhapVaDong.Name = "Btn_NhapVaDong"
        Me.Btn_NhapVaDong.Size = New System.Drawing.Size(149, 45)
        Me.Btn_NhapVaDong.TabIndex = 5
        Me.Btn_NhapVaDong.Text = "Nhập Và Đóng"
        Me.Btn_NhapVaDong.UseVisualStyleBackColor = True
        '
        'Frm_ThemLoaiDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 226)
        Me.Controls.Add(Me.Btn_NhapVaDong)
        Me.Controls.Add(Me.Btn_Nhap)
        Me.Controls.Add(Me.Txt_TenLoaiDocGia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_MaloaiDocGia)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_ThemLoaiDocGia"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm Loại Độc Giả"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_MaloaiDocGia As TextBox
    Friend WithEvents Txt_TenLoaiDocGia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Nhap As Button
    Friend WithEvents Btn_NhapVaDong As Button
End Class
