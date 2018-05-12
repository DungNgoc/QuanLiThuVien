Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class Frm_ThemDocGia


    Private dgBus As DocGiaBUS
    Private ldgBus As LoaiDocGia_BUS

    Private Sub btn_Nhap_Click(sender As Object, e As EventArgs) Handles btn_Nhap.Click

        Dim docgia As DocGiaDTO
        docgia = New DocGiaDTO()

        '1. Mapping data from GUI control
        docgia.MaDocGia = Txt_MaDocGia.Text
        docgia.HoVaTen = Txt_HoVaTen.Text
        docgia.LoaiDocGia = Convert.ToInt32(Cb_LoaiDocGia.SelectedValue)
        docgia.NgaySinh = Dtp_NgaySinh.Value
        docgia.DiaChi = Txt_DiaChi.Text
        docgia.Email = Txt_Email.Text
        docgia.NgayLap = Dtp_NgayLap.Value


        '2. Business .....
        If (dgBus.isValidName(docgia) = False) Then
            MessageBox.Show("Họ tên độc giả không đúng")
            Txt_HoVaTen.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = dgBus.insert(docgia)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Độc Giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set Madocgia auto
            Dim nextMaDocGia = "1"
            result = dgBus.buildMaDocGia(nextMaDocGia)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã Độc Gỉa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            Txt_MaDocGia.Text = nextMaDocGia
            Txt_DiaChi.Text = String.Empty
            Txt_HoVaTen.Text = String.Empty

        Else
            MessageBox.Show("Thêm Độc Gia không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub

    Private Sub Frm_ThemDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgBus = New DocGiaBUS()
        ldgBus = New LoaiDocGia_BUS()

        ' Load LoaiDocGia list
        Dim listLoaiDocGia = New List(Of LoaiDocGia_DTO)
        Dim result As Result
        result = ldgBus.selectAll(listLoaiDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Cb_LoaiDocGia.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        Cb_LoaiDocGia.DisplayMember = "TenLoaiDocGia"
        Cb_LoaiDocGia.ValueMember = "MaLoaiDocGia"

        'set MaDocgIA auto
        Dim nextMaDocGia = "1"
        result = dgBus.buildMaDocGia(nextMaDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã Độc Giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Txt_MaDocGia.Text = nextMaDocGia

    End Sub
    Private Sub btn_NhapVaDong_Click(sender As Object, e As EventArgs) Handles btn_NhapVaDong.Click
        Dim docgia As DocGiaDTO
        docgia = New DocGiaDTO()

        '1. Mapping data from GUI control
        docgia.MaDocGia = Txt_MaDocGia.Text
        docgia.HoVaTen = Txt_HoVaTen.Text
        docgia.LoaiDocGia = Convert.ToInt32(Cb_LoaiDocGia.SelectedValue)
        docgia.NgaySinh = Dtp_NgaySinh.Value
        docgia.DiaChi = Txt_DiaChi.Text
        docgia.Email = Txt_Email.Text
        docgia.NgayLap = Dtp_NgayLap.Value



        '2. Business .....
        If (dgBus.isValidName(docgia) = False) Then
            MessageBox.Show("Họ tên Độc Gỉa không đúng")
            Txt_HoVaTen.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = dgBus.insert(docgia)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Độc Gỉa thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm Độc Giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub



End Class