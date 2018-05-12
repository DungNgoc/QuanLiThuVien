<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_QLDocGia
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
        Me.Cb_LoaiDocGia = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dgv_ListDocGia = New System.Windows.Forms.DataGridView()
        Me.Txt_SoSachDaMuon = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_TinhTrangThe = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Dtp_NgayLap = New System.Windows.Forms.DateTimePicker()
        Me.Dtp_NgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.Txt_MaDocGia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_Email = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_DiaChi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_HoVaTen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_CapNhap = New System.Windows.Forms.Button()
        Me.Btn_Xoa = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txt_NgayHetHan = New System.Windows.Forms.TextBox()
        Me.Cb_LoaiDocGiaCapNhap = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.Dgv_ListDocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cb_LoaiDocGia
        '
        Me.Cb_LoaiDocGia.FormattingEnabled = True
        Me.Cb_LoaiDocGia.Location = New System.Drawing.Point(384, 26)
        Me.Cb_LoaiDocGia.Name = "Cb_LoaiDocGia"
        Me.Cb_LoaiDocGia.Size = New System.Drawing.Size(240, 28)
        Me.Cb_LoaiDocGia.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Loại Độc Giả"
        '
        'Dgv_ListDocGia
        '
        Me.Dgv_ListDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListDocGia.Location = New System.Drawing.Point(95, 99)
        Me.Dgv_ListDocGia.Name = "Dgv_ListDocGia"
        Me.Dgv_ListDocGia.ReadOnly = True
        Me.Dgv_ListDocGia.RowTemplate.Height = 28
        Me.Dgv_ListDocGia.Size = New System.Drawing.Size(789, 241)
        Me.Dgv_ListDocGia.TabIndex = 11
        '
        'Txt_SoSachDaMuon
        '
        Me.Txt_SoSachDaMuon.Location = New System.Drawing.Point(384, 747)
        Me.Txt_SoSachDaMuon.Name = "Txt_SoSachDaMuon"
        Me.Txt_SoSachDaMuon.ReadOnly = True
        Me.Txt_SoSachDaMuon.Size = New System.Drawing.Size(240, 26)
        Me.Txt_SoSachDaMuon.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(204, 753)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 20)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Số sách đã mượn"
        '
        'Txt_TinhTrangThe
        '
        Me.Txt_TinhTrangThe.Location = New System.Drawing.Point(384, 701)
        Me.Txt_TinhTrangThe.Name = "Txt_TinhTrangThe"
        Me.Txt_TinhTrangThe.ReadOnly = True
        Me.Txt_TinhTrangThe.Size = New System.Drawing.Size(240, 26)
        Me.Txt_TinhTrangThe.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(204, 707)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 20)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Tình trạng thẻ"
        '
        'Dtp_NgayLap
        '
        Me.Dtp_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_NgayLap.Location = New System.Drawing.Point(384, 615)
        Me.Dtp_NgayLap.Name = "Dtp_NgayLap"
        Me.Dtp_NgayLap.Size = New System.Drawing.Size(240, 26)
        Me.Dtp_NgayLap.TabIndex = 36
        '
        'Dtp_NgaySinh
        '
        Me.Dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_NgaySinh.Location = New System.Drawing.Point(384, 480)
        Me.Dtp_NgaySinh.Name = "Dtp_NgaySinh"
        Me.Dtp_NgaySinh.Size = New System.Drawing.Size(240, 26)
        Me.Dtp_NgaySinh.TabIndex = 35
        '
        'Txt_MaDocGia
        '
        Me.Txt_MaDocGia.Location = New System.Drawing.Point(384, 383)
        Me.Txt_MaDocGia.Name = "Txt_MaDocGia"
        Me.Txt_MaDocGia.ReadOnly = True
        Me.Txt_MaDocGia.Size = New System.Drawing.Size(240, 26)
        Me.Txt_MaDocGia.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(204, 386)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 20)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Mã Độc Giả"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(198, 621)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 20)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = " Ngày Lập"
        '
        'Txt_Email
        '
        Me.Txt_Email.Location = New System.Drawing.Point(384, 567)
        Me.Txt_Email.Name = "Txt_Email"
        Me.Txt_Email.Size = New System.Drawing.Size(240, 26)
        Me.Txt_Email.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(204, 573)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Email"
        '
        'Txt_DiaChi
        '
        Me.Txt_DiaChi.Location = New System.Drawing.Point(384, 520)
        Me.Txt_DiaChi.Name = "Txt_DiaChi"
        Me.Txt_DiaChi.Size = New System.Drawing.Size(240, 26)
        Me.Txt_DiaChi.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(204, 526)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Địa Chỉ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(204, 485)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Ngày Sinh"
        '
        'Txt_HoVaTen
        '
        Me.Txt_HoVaTen.Location = New System.Drawing.Point(384, 430)
        Me.Txt_HoVaTen.Name = "Txt_HoVaTen"
        Me.Txt_HoVaTen.Size = New System.Drawing.Size(240, 26)
        Me.Txt_HoVaTen.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(204, 436)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Họ và Tên"
        '
        'Btn_CapNhap
        '
        Me.Btn_CapNhap.Location = New System.Drawing.Point(268, 839)
        Me.Btn_CapNhap.Name = "Btn_CapNhap"
        Me.Btn_CapNhap.Size = New System.Drawing.Size(113, 45)
        Me.Btn_CapNhap.TabIndex = 46
        Me.Btn_CapNhap.Text = "Cập Nhập"
        Me.Btn_CapNhap.UseVisualStyleBackColor = True
        '
        'Btn_Xoa
        '
        Me.Btn_Xoa.Location = New System.Drawing.Point(526, 839)
        Me.Btn_Xoa.Name = "Btn_Xoa"
        Me.Btn_Xoa.Size = New System.Drawing.Size(113, 45)
        Me.Btn_Xoa.TabIndex = 47
        Me.Btn_Xoa.Text = "Xóa"
        Me.Btn_Xoa.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(198, 665)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 20)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = " Ngày hết hạn"
        '
        'Txt_NgayHetHan
        '
        Me.Txt_NgayHetHan.Location = New System.Drawing.Point(384, 658)
        Me.Txt_NgayHetHan.Name = "Txt_NgayHetHan"
        Me.Txt_NgayHetHan.ReadOnly = True
        Me.Txt_NgayHetHan.Size = New System.Drawing.Size(240, 26)
        Me.Txt_NgayHetHan.TabIndex = 45
        '
        'Cb_LoaiDocGiaCapNhap
        '
        Me.Cb_LoaiDocGiaCapNhap.FormattingEnabled = True
        Me.Cb_LoaiDocGiaCapNhap.Location = New System.Drawing.Point(384, 782)
        Me.Cb_LoaiDocGiaCapNhap.Name = "Cb_LoaiDocGiaCapNhap"
        Me.Cb_LoaiDocGiaCapNhap.Size = New System.Drawing.Size(240, 28)
        Me.Cb_LoaiDocGiaCapNhap.TabIndex = 49
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(204, 790)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 20)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Loại Độc Giả"
        '
        'Frm_QLDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(953, 896)
        Me.Controls.Add(Me.Cb_LoaiDocGiaCapNhap)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Btn_Xoa)
        Me.Controls.Add(Me.Btn_CapNhap)
        Me.Controls.Add(Me.Txt_NgayHetHan)
        Me.Controls.Add(Me.Txt_SoSachDaMuon)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Txt_TinhTrangThe)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Dtp_NgayLap)
        Me.Controls.Add(Me.Dtp_NgaySinh)
        Me.Controls.Add(Me.Txt_MaDocGia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txt_Email)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txt_DiaChi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txt_HoVaTen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Dgv_ListDocGia)
        Me.Controls.Add(Me.Cb_LoaiDocGia)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Frm_QLDocGia"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lí Độc Giả"
        CType(Me.Dgv_ListDocGia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cb_LoaiDocGia As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Dgv_ListDocGia As DataGridView
    Friend WithEvents Txt_SoSachDaMuon As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Txt_TinhTrangThe As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Dtp_NgayLap As DateTimePicker
    Friend WithEvents Dtp_NgaySinh As DateTimePicker
    Friend WithEvents Txt_MaDocGia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_Email As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_DiaChi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_HoVaTen As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_CapNhap As Button
    Friend WithEvents Btn_Xoa As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Txt_NgayHetHan As TextBox
    Friend WithEvents Cb_LoaiDocGiaCapNhap As ComboBox
    Friend WithEvents Label11 As Label
End Class
