<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ThemDocGia
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
        Me.Txt_HoVaTen = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_DiaChi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cb_LoaiDocGia = New System.Windows.Forms.ComboBox()
        Me.Txt_Email = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_MaDocGia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Dtp_NgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.Dtp_NgayLap = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Nhap = New System.Windows.Forms.Button()
        Me.Btn_NhapVaDong = New System.Windows.Forms.Button()
        Me.dtp_NgayHetHan = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txt_TinhTrangThe = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_SoSachDaMuon = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Họ và Tên"
        '
        'Txt_HoVaTen
        '
        Me.Txt_HoVaTen.Location = New System.Drawing.Point(313, 96)
        Me.Txt_HoVaTen.Name = "Txt_HoVaTen"
        Me.Txt_HoVaTen.Size = New System.Drawing.Size(240, 26)
        Me.Txt_HoVaTen.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Loại Độc Giả"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(133, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ngày Sinh"
        '
        'Txt_DiaChi
        '
        Me.Txt_DiaChi.Location = New System.Drawing.Point(313, 242)
        Me.Txt_DiaChi.Name = "Txt_DiaChi"
        Me.Txt_DiaChi.Size = New System.Drawing.Size(240, 26)
        Me.Txt_DiaChi.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(133, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Địa Chỉ"
        '
        'Cb_LoaiDocGia
        '
        Me.Cb_LoaiDocGia.FormattingEnabled = True
        Me.Cb_LoaiDocGia.Location = New System.Drawing.Point(313, 144)
        Me.Cb_LoaiDocGia.Name = "Cb_LoaiDocGia"
        Me.Cb_LoaiDocGia.Size = New System.Drawing.Size(240, 28)
        Me.Cb_LoaiDocGia.TabIndex = 8
        '
        'Txt_Email
        '
        Me.Txt_Email.Location = New System.Drawing.Point(313, 294)
        Me.Txt_Email.Name = "Txt_Email"
        Me.Txt_Email.Size = New System.Drawing.Size(240, 26)
        Me.Txt_Email.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(133, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(127, 346)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = " Ngày Lập"
        '
        'Txt_MaDocGia
        '
        Me.Txt_MaDocGia.Location = New System.Drawing.Point(313, 40)
        Me.Txt_MaDocGia.Name = "Txt_MaDocGia"
        Me.Txt_MaDocGia.ReadOnly = True
        Me.Txt_MaDocGia.Size = New System.Drawing.Size(240, 26)
        Me.Txt_MaDocGia.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(133, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Mã Độc Giả"
        '
        'Dtp_NgaySinh
        '
        Me.Dtp_NgaySinh.Location = New System.Drawing.Point(313, 192)
        Me.Dtp_NgaySinh.Name = "Dtp_NgaySinh"
        Me.Dtp_NgaySinh.Size = New System.Drawing.Size(240, 26)
        Me.Dtp_NgaySinh.TabIndex = 15
        '
        'Dtp_NgayLap
        '
        Me.Dtp_NgayLap.Location = New System.Drawing.Point(313, 343)
        Me.Dtp_NgayLap.Name = "Dtp_NgayLap"
        Me.Dtp_NgayLap.Size = New System.Drawing.Size(240, 26)
        Me.Dtp_NgayLap.TabIndex = 16
        '
        'Btn_Nhap
        '
        Me.Btn_Nhap.Location = New System.Drawing.Point(137, 540)
        Me.Btn_Nhap.Name = "Btn_Nhap"
        Me.Btn_Nhap.Size = New System.Drawing.Size(159, 50)
        Me.Btn_Nhap.TabIndex = 17
        Me.Btn_Nhap.Text = "Nhập"
        Me.Btn_Nhap.UseVisualStyleBackColor = True
        '
        'Btn_NhapVaDong
        '
        Me.Btn_NhapVaDong.Location = New System.Drawing.Point(515, 540)
        Me.Btn_NhapVaDong.Name = "Btn_NhapVaDong"
        Me.Btn_NhapVaDong.Size = New System.Drawing.Size(170, 50)
        Me.Btn_NhapVaDong.TabIndex = 18
        Me.Btn_NhapVaDong.Text = "Nhập Và Đóng"
        Me.Btn_NhapVaDong.UseVisualStyleBackColor = True
        '
        'dtp_NgayHetHan
        '
        Me.dtp_NgayHetHan.Location = New System.Drawing.Point(313, 389)
        Me.dtp_NgayHetHan.Name = "dtp_NgayHetHan"
        Me.dtp_NgayHetHan.Size = New System.Drawing.Size(240, 26)
        Me.dtp_NgayHetHan.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(127, 392)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = " Ngày hết hạn"
        '
        'Txt_TinhTrangThe
        '
        Me.Txt_TinhTrangThe.Location = New System.Drawing.Point(313, 436)
        Me.Txt_TinhTrangThe.Name = "Txt_TinhTrangThe"
        Me.Txt_TinhTrangThe.ReadOnly = True
        Me.Txt_TinhTrangThe.Size = New System.Drawing.Size(240, 26)
        Me.Txt_TinhTrangThe.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(127, 433)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Tình trạng thẻ"
        '
        'Txt_SoSachDaMuon
        '
        Me.Txt_SoSachDaMuon.Location = New System.Drawing.Point(313, 486)
        Me.Txt_SoSachDaMuon.Name = "Txt_SoSachDaMuon"
        Me.Txt_SoSachDaMuon.ReadOnly = True
        Me.Txt_SoSachDaMuon.Size = New System.Drawing.Size(240, 26)
        Me.Txt_SoSachDaMuon.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(127, 483)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 20)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Số sách đã mượn"
        '
        'Frm_ThemDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 684)
        Me.Controls.Add(Me.Txt_SoSachDaMuon)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Txt_TinhTrangThe)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtp_NgayHetHan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Btn_NhapVaDong)
        Me.Controls.Add(Me.Btn_Nhap)
        Me.Controls.Add(Me.Dtp_NgayLap)
        Me.Controls.Add(Me.Dtp_NgaySinh)
        Me.Controls.Add(Me.Txt_MaDocGia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txt_Email)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Cb_LoaiDocGia)
        Me.Controls.Add(Me.Txt_DiaChi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_HoVaTen)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_ThemDocGia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm Độc Giả"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_HoVaTen As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_DiaChi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Cb_LoaiDocGia As ComboBox
    Friend WithEvents Txt_Email As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_MaDocGia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Dtp_NgaySinh As DateTimePicker
    Friend WithEvents Dtp_NgayLap As DateTimePicker
    Friend WithEvents Btn_Nhap As Button
    Friend WithEvents Btn_NhapVaDong As Button
    Friend WithEvents dtp_NgayHetHan As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Txt_TinhTrangThe As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Txt_SoSachDaMuon As TextBox
    Friend WithEvents Label10 As Label
End Class
