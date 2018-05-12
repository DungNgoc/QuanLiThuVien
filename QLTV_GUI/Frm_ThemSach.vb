Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility

Public Class Frm_ThemSach

    Private SachBUS As Sach_BUS
    Private TheLoaiSachBUS As TheLoaiSach_BUS
    Private TacGiaBUS As TacGia_BUS
    Private Sub Frm_ThemSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SachBUS = New Sach_BUS()
        TheLoaiSachBUS = New TheLoaiSach_BUS()
        TacGiaBUS = New TacGia_BUS()
        ' Load LoaiHocSinh list


        Dim listTheLoaiSach = New List(Of TheLoaiSach_DTO)
        Dim result As Result
        result = TheLoaiSachBUS.selectAll(listTheLoaiSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách thể loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Cb_Theloai.DataSource = New BindingSource(listTheLoaiSach, String.Empty)
        Cb_Theloai.DisplayMember = "TenTheLoaiSach"
        Cb_Theloai.ValueMember = "MaTheLoaiSach"



        Dim listTacGia = New List(Of TacGia_DTO)
        'Dim result1 As Result
        result = TacGiaBUS.selectAll(listTacGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Cb_TenTacGia.DataSource = New BindingSource(listTacGia, String.Empty)
        Cb_TenTacGia.DisplayMember = "TenTacGia"
        Cb_TenTacGia.ValueMember = "MaTacGia"

        'set MSSH auto
        Dim nextMaSach = "1"
        result = SachBUS.buildMaSach(nextMaSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Txt_MaSach.Text = nextMaSach

    End Sub

    Private Sub Btn_Nhap_Click(sender As Object, e As EventArgs) Handles Btn_Nhap.Click
        Dim Sach As Sach_DTO
        Sach = New Sach_DTO()
        Dim TacGia As TacGia_DTO
        TacGia = New TacGia_DTO()
        '1. Mapping data from GUI control
        Sach.MaSach = Txt_MaSach.Text
        Sach.TenSach = TxtTenSach.Text
        Sach.NamXuatBan = Txt_NamXuatBan.Text
        Sach.NhaXuatBan = Txt_NhaXuatBan.Text
        Sach.NgayNhap = Dtp_NgayNhap.Value
        Sach.TheLoai = Convert.ToInt32(Cb_Theloai.SelectedValue)
        Sach.TenTacGia = Convert.ToInt32(Cb_TenTacGia.SelectedValue)
        Sach.TriGia = Txt_TriGia.Text
        'TacGia.TenTacGia = Sach.TenTacGia
        '2. Business .....
        If (SachBUS.isValidNamXuatBan(Sach) = False) Then
            MessageBox.Show("Chi nhan sach xuat ban trong vong 8 nam")
            Txt_NamXuatBan.Focus()
            Return
        End If

        If (SachBUS.isValidTacGia(TacGia, Sach) = False) Then
            MessageBox.Show("Tác giả chưa có trong cơ sở dữ liệu")
            Cb_TenTacGia.Focus()
            Return
        End If
        If (SachBUS.isValidTheLoai(Sach) = False) Then
            MessageBox.Show("Thể loại không hợp lệ")
            Cb_Theloai.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = SachBUS.insert(Sach)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMaSach = "1"
            result = SachBUS.buildMaSach(nextMaSach)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            Txt_MaSach.Text = nextMaSach
            TxtTenSach.Text = String.Empty
            Txt_NamXuatBan.Text = String.Empty
            Txt_NhaXuatBan.Text = String.Empty
            Txt_TriGia.Text = String.Empty
        Else
            MessageBox.Show("Thêm sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub
End Class