Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility

Public Class TheLoaiSach_BUS
    Private TheLoaiSachDAL As TheLoaiSach_DAL
    Public Sub New()
        TheLoaiSachDAL = New TheLoaiSach_DAL()
    End Sub
    Public Sub New(connectionString As String)
        TheLoaiSachDAL = New TheLoaiSach_DAL(connectionString)
    End Sub
    Public Function isValidTheLoaiSach(TheLoaiSach As TheLoaiSach_DTO) As Boolean

        If (TheLoaiSach.TenTheLoaiSach < 1) Then
            Return False
        End If

        Return True

    End Function
    Public Function insert(TheLoaiSach As TheLoaiSach_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return TheLoaiSachDAL.insert(TheLoaiSach)
    End Function
    'Public Function update(lhs As LoaiHocSinhDTO) As Result
    '    '1. verify data here!!

    '    '2. insert to DB
    '    Return lhsDAL.update(lhs)
    'End Function
    'Public Function delete(maLoai As Integer) As Result
    '    '1. verify data here!!

    '    '2. insert to DB
    '    Return lhsDAL.delete(maLoai)
    'End Function
    Public Function selectAll(ByRef listTheLoaiSach As List(Of TheLoaiSach_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return TheLoaiSachDAL.selectALL(listTheLoaiSach)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return TheLoaiSachDAL.getNextID(nextID)
    End Function
End Class
