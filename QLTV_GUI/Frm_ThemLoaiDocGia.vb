Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility

Public Class Frm_ThemLoaiDocGia

    Private ldgBus As LoaiDocGia_BUS

    Private Sub Btn_Nhap_Click(sender As Object, e As EventArgs) Handles Btn_Nhap.Click

        Dim ldg As LoaiDocGia_DTO
        ldg = New LoaiDocGia_DTO()

        '1. Mapping data from GUI control
        ldg.MaLoaiDocGia = Convert.ToInt32(Txt_MaloaiDocGia.Text)
        ldg.TenLoaiDocGia = Txt_TenLoaiDocGia.Text

        '2. Business .....
        If (ldgBus.isValidName(ldg) = False) Then
            MessageBox.Show("Tên Loại độc giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Txt_TenLoaiDocGia.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = ldgBus.insert(ldg)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm loại độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Txt_TenLoaiDocGia.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = ldgBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                Txt_MaloaiDocGia.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của Loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub Frm_LoaiDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ldgBus = New LoaiDocGia_BUS()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = ldgBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            Txt_MaloaiDocGia.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub

    Private Sub Btn_NhapVanDong_Click(sender As Object, e As EventArgs) Handles Btn_NhapVaDong.Click
        Dim ldg As LoaiDocGia_DTO
        ldg = New LoaiDocGia_DTO()

        '1. Mapping data from GUI control
        ldg.MaLoaiDocGia = Convert.ToInt32(Txt_MaloaiDocGia.Text)
        ldg.TenLoaiDocGia = Txt_TenLoaiDocGia.Text

        '2. Business .....
        If (ldgBus.isValidName(ldg) = False) Then
            MessageBox.Show("Tên Loại độc giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Txt_TenLoaiDocGia.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = ldgBus.insert(ldg)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm loại độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub


End Class