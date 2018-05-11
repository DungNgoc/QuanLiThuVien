Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility
Public Class LoaiDocGia_BUS
    Private ldgDAL As LoaiDocGia_DAL
    Public Sub New()
        ldgDAL = New LoaiDocGia_DAL()
    End Sub
    Public Sub New(connectionString As String)
        ldgDAL = New LoaiDocGia_DAL(connectionString)
    End Sub
    Public Function isValidName(ldg As LoaiDocGia_DTO) As Boolean

        If (ldg.TenLoaiDocGia.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function insert(ldg As LoaiDocGia_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ldgDAL.insert(ldg)
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
    Public Function selectAll(ByRef listLoaiDocGia As List(Of LoaiDocGia_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ldgDAL.selectALL(listLoaiDocGia)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return ldgDAL.getNextID(nextID)
    End Function
End Class


