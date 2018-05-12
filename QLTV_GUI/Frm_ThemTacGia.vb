Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility

Public Class Frm_ThemTacGia
    Private TacGiaBUS As TacGia_BUS

    Private Sub Frm_ThemTacGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TacGiaBUS = New TacGia_BUS()

        Dim Result As Result

        Dim nextMaTacGia = "1"
        Result = TacGiaBUS.buildMaTacGia(nextMaTacGia)
        If (Result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(Result.SystemMessage)
            Me.Close()
            Return
        End If
        Txt_MaTacGia.Text = nextMaTacGia
    End Sub

    Private Sub Btn_Nhap_Click(sender As Object, e As EventArgs) Handles Btn_Nhap.Click

        Dim TacGia As TacGia_DTO
        TacGia = New TacGia_DTO()
        '1. Mapping data from GUI control
        TacGia.TenTacGia = TxtTenTacGia.Text
        TacGia.MaTacGia = Txt_MaTacGia.Text
        'TacGia.TenTacGia = Sach.TenTacGia
        '2. Business .....
        If (TacGiaBUS.isValidInsert(TacGia) = False) Then
            MessageBox.Show("Đã đủ 100 tác giả")
            Me.Close()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = TacGiaBUS.insert(TacGia)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm tác giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMaTacGia = "1"
            result = TacGiaBUS.buildMaTacGia(nextMaTacGia)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            Txt_MaTacGia.Text = nextMaTacGia
            TxtTenTacGia.Text = String.Empty
        Else
            MessageBox.Show("Thêm tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If





    End Sub
End Class