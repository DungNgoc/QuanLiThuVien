Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility

Public Class Frm_ThemTheLoaiSach

    Private TheLoaiSachBUS As TheLoaiSach_BUS
    Private Sub Frm_ThemTheLoaiSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TheLoaiSachBUS = New TheLoaiSach_BUS()

        Dim Result As Result

        Dim nextMaTheLoaisach = "1"
        Result = TheLoaiSachBUS.getNextID(nextMaTheLoaisach)
        If (Result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã thể loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(Result.SystemMessage)
            Me.Close()
            Return
        End If
        Txt_MaTheLoaiSach.Text = nextMaTheLoaisach
    End Sub

    Private Sub Btn_Nhap_Click(sender As Object, e As EventArgs) Handles Btn_Nhap.Click
        Dim TheLoaiSach As TheLoaiSach_DTO
        TheLoaiSach = New TheLoaiSach_DTO()
        '1. Mapping data from GUI control
        TheLoaiSach.MaTheLoaiSach = Txt_MaTheLoaiSach.Text
        TheLoaiSach.TenTheLoaiSach = Txt_TenTheLoaiSach.Text
        'TacGia.TenTacGia = Sach.TenTacGia
        '2. Business .....
        If (TheLoaiSachBUS.isValidTheLoaiSach(TheLoaiSach) = False) Then
            MessageBox.Show("Đã đủ thể loại qui định")
            Me.Close()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = TheLoaiSachBUS.insert(TheLoaiSach)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm tác giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMaTheLoaiSach = "1"
            result = TheLoaiSachBUS.getNextID(nextMaTheLoaiSach)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            Txt_MaTheLoaiSach.Text = nextMaTheLoaiSach
            Txt_MaTheLoaiSach.Text = String.Empty
        Else
            MessageBox.Show("Thêm tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class