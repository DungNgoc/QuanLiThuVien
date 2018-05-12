Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility
Public Class DocGiaBUS



    Private dgDAL As DocGiaDAL
    Public Sub New()
        dgDAL = New DocGiaDAL()
    End Sub
    Public Sub New(connectionString As String)
        dgDAL = New DocGiaDAL(connectionString)
    End Sub
    Public Function isValidName(dg As DocGiaDTO) As Boolean

        If (dg.HoVaTen.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function isValidAge(dg As DocGiaDTO) As Boolean
        Dim NamHienTai = DateTime.Now.Year
        If ((NamHienTai - dg.NgaySinh.Year) < 18 Or (NamHienTai - dg.NgaySinh.Year) > 55) Then
            Return False
        End If
        Return True
    End Function



    Public Function TinhNgayHetHan(dg As DocGiaDTO) As Boolean
        Dim ThoiGian = DateTime.Now
        If (dg.NgayLap.AddMonths(6) > ThoiGian) Then
            Return False
        End If
        Return True
    End Function
    Public Function insert(dg As DocGiaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.insert(dg)
    End Function
    Public Function update(dg As DocGiaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.update(dg)
    End Function
    Public Function delete(MaLoaiDocGia As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.delete(MaLoaiDocGia)
    End Function
    Public Function selectAll(ByRef listLoaiDocGia As List(Of DocGiaDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.selectALL(listLoaiDocGia)
    End Function
    'Public Function selectALL_ByMaLop(iMaLop As Integer, ByRef listHS As List(Of HocSinhDTO)) As Result
    '        '1. verify data here!!

    '        '2. insert to DB
    '        Return hsDAL.selectALL_ByMaLop(iMaLop, listHS)
    '    End Function
    Public Function selectALL_ByType(MaLoaiDocGia As Integer, ByRef listDocGia As List(Of DocGiaDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.selectALL_ByType(MaLoaiDocGia, listDocGia)
    End Function
    Public Function buildMaDocGia(ByRef nextMaDocGia As Integer) As Result
        Return dgDAL.buildMaDocGia(nextMaDocGia)
    End Function
End Class

