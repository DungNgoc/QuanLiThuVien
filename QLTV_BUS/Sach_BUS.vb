Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility

Public Class Sach_BUS

    Private SachDAL As Sach_DAL
    Public Sub New()
        SachDAL = New Sach_DAL()
    End Sub
    Public Sub New(connectionString As String)
        SachDAL = New Sach_DAL(connectionString)
    End Sub
    Public Function isValidNamXuatBan(Sach As Sach_DTO) As Boolean
        Dim currentyear = DateTime.Now.Year
        If (currentyear - Sach.NamXuatBan < 0 And currentyear - Sach.NamXuatBan > 8) Then
            Return False
        End If

        Return True
    End Function
    Public Function isValidTacGia(TacGia As TacGia_DTO, Sach As Sach_DTO) As Boolean
        'Dim currentyear = DateTime.Now.Year
        If (Sach.TenTacGia > TacGia.TenTacGia And Sach.TenTacGia < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function isValidTheLoai(Sach As Sach_DTO) As Boolean
        'Dim currentyear = DateTime.Now.Year
        If (Sach.TheLoai > 3 And Sach.TheLoai < 1) Then
            Return False
        End If

        Return True
    End Function

    Public Function insert(Sach As Sach_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return SachDAL.insert(Sach)
    End Function
    'Public Function update(hs As HocSinhDTO) As Result
    '    '1. verify data here!!

    '    '2. insert to DB
    '    Return hsDAL.update(hs)
    'End Function
    'Public Function delete(maLoai As Integer) As Result
    '    '1. verify data here!!

    '    '2. insert to DB
    '    Return hsDAL.delete(maLoai)
    'End Function
    Public Function selectAll(ByRef listSach As List(Of Sach_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return SachDAL.selectALL(listSach)
    End Function
    'Public Function selectALL_ByMaLop(iMaLop As Integer, ByRef listHS As List(Of HocSinhDTO)) As Result
    '    '1. verify data here!!

    '    '2. insert to DB
    '    Return hsDAL.selectALL_ByMaLop(iMaLop, listHS)
    'End Function
    'Public Function selectALL_ByType(maLoai As Integer, ByRef listHS As List(Of HocSinhDTO)) As Result
    '    '1. verify data here!!

    '    '2. insert to DB
    '    Return hsDAL.selectALL_ByType(maLoai, listHS)
    'End Function
    Public Function buildMaSach(ByRef nextMaSach As Integer) As Result
        Return SachDAL.buildMaSach(nextMaSach)
    End Function
End Class
