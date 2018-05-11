<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ThemSach
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
        Me.Txt_MaSach = New System.Windows.Forms.TextBox()
        Me.TxtTenSach = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_NhaXuatBan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_NamXuatBan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txt_TriGia = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Cb_Theloai = New System.Windows.Forms.ComboBox()
        Me.Cb_TenTacGia = New System.Windows.Forms.ComboBox()
        Me.Dtp_NgayNhap = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Nhap = New System.Windows.Forms.Button()
        Me.Btn_NhapVaDong = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Sách"
        '
        'Txt_MaSach
        '
        Me.Txt_MaSach.Location = New System.Drawing.Point(181, 52)
        Me.Txt_MaSach.Name = "Txt_MaSach"
        Me.Txt_MaSach.ReadOnly = True
        Me.Txt_MaSach.Size = New System.Drawing.Size(309, 22)
        Me.Txt_MaSach.TabIndex = 1
        '
        'TxtTenSach
        '
        Me.TxtTenSach.Location = New System.Drawing.Point(181, 99)
        Me.TxtTenSach.Name = "TxtTenSach"
        Me.TxtTenSach.Size = New System.Drawing.Size(309, 22)
        Me.TxtTenSach.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên Sách"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Thể loại"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(76, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Ngày Nhập"
        '
        'Txt_NhaXuatBan
        '
        Me.Txt_NhaXuatBan.Location = New System.Drawing.Point(181, 289)
        Me.Txt_NhaXuatBan.Name = "Txt_NhaXuatBan"
        Me.Txt_NhaXuatBan.Size = New System.Drawing.Size(309, 22)
        Me.Txt_NhaXuatBan.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(76, 292)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Nhà Xuất Bản"
        '
        'Txt_NamXuatBan
        '
        Me.Txt_NamXuatBan.Location = New System.Drawing.Point(181, 243)
        Me.Txt_NamXuatBan.Name = "Txt_NamXuatBan"
        Me.Txt_NamXuatBan.Size = New System.Drawing.Size(309, 22)
        Me.Txt_NamXuatBan.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(76, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Năm Xuất Bản"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(76, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Tên tác giả"
        '
        'Txt_TriGia
        '
        Me.Txt_TriGia.Location = New System.Drawing.Point(181, 376)
        Me.Txt_TriGia.Name = "Txt_TriGia"
        Me.Txt_TriGia.Size = New System.Drawing.Size(309, 22)
        Me.Txt_TriGia.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(76, 379)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Trị Giá"
        '
        'Cb_Theloai
        '
        Me.Cb_Theloai.FormattingEnabled = True
        Me.Cb_Theloai.Location = New System.Drawing.Point(181, 145)
        Me.Cb_Theloai.Name = "Cb_Theloai"
        Me.Cb_Theloai.Size = New System.Drawing.Size(309, 24)
        Me.Cb_Theloai.TabIndex = 18
        '
        'Cb_TenTacGia
        '
        Me.Cb_TenTacGia.FormattingEnabled = True
        Me.Cb_TenTacGia.Location = New System.Drawing.Point(181, 196)
        Me.Cb_TenTacGia.Name = "Cb_TenTacGia"
        Me.Cb_TenTacGia.Size = New System.Drawing.Size(309, 24)
        Me.Cb_TenTacGia.TabIndex = 20
        '
        'Dtp_NgayNhap
        '
        Me.Dtp_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_NgayNhap.Location = New System.Drawing.Point(181, 334)
        Me.Dtp_NgayNhap.Name = "Dtp_NgayNhap"
        Me.Dtp_NgayNhap.Size = New System.Drawing.Size(309, 22)
        Me.Dtp_NgayNhap.TabIndex = 21
        '
        'Btn_Nhap
        '
        Me.Btn_Nhap.Location = New System.Drawing.Point(67, 426)
        Me.Btn_Nhap.Name = "Btn_Nhap"
        Me.Btn_Nhap.Size = New System.Drawing.Size(108, 56)
        Me.Btn_Nhap.TabIndex = 22
        Me.Btn_Nhap.Text = "Nhập"
        Me.Btn_Nhap.UseVisualStyleBackColor = True
        '
        'Btn_NhapVaDong
        '
        Me.Btn_NhapVaDong.Location = New System.Drawing.Point(315, 426)
        Me.Btn_NhapVaDong.Name = "Btn_NhapVaDong"
        Me.Btn_NhapVaDong.Size = New System.Drawing.Size(175, 56)
        Me.Btn_NhapVaDong.TabIndex = 23
        Me.Btn_NhapVaDong.Text = "Nhập Và Đóng"
        Me.Btn_NhapVaDong.UseVisualStyleBackColor = True
        '
        'Frm_ThemSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 533)
        Me.Controls.Add(Me.Btn_NhapVaDong)
        Me.Controls.Add(Me.Btn_Nhap)
        Me.Controls.Add(Me.Dtp_NgayNhap)
        Me.Controls.Add(Me.Cb_TenTacGia)
        Me.Controls.Add(Me.Cb_Theloai)
        Me.Controls.Add(Me.Txt_TriGia)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txt_NhaXuatBan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txt_NamXuatBan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTenSach)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_MaSach)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_ThemSach"
        Me.Text = "Thêm Sách"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_MaSach As TextBox
    Friend WithEvents TxtTenSach As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_NhaXuatBan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_NamXuatBan As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Txt_TriGia As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Cb_Theloai As ComboBox
    Friend WithEvents Cb_TenTacGia As ComboBox
    Friend WithEvents Dtp_NgayNhap As DateTimePicker
    Friend WithEvents Btn_Nhap As Button
    Friend WithEvents Btn_NhapVaDong As Button
End Class
