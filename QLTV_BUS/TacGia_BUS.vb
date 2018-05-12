Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility

Public Class TacGia_BUS
    Private TacGiaDAL As TacGia_DAL
    Public Sub New()
        TacGiaDAL = New TacGia_DAL()
    End Sub
    Public Sub New(connectionString As String)
        TacGiaDAL = New TacGia_DAL(connectionString)
    End Sub
    Public Function isValidInsert(TacGia As TacGia_DTO) As Boolean
        'Dim currentyear = DateTime.Now.Year
        If (TacGia.MaTacGia > 100) Then
            Return False
        End If

        Return True
    End Function
    Public Function insert(TacGia As TacGia_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return TacGiaDAL.insert(TacGia)
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
    Public Function selectAll(ByRef listTacGia As List(Of TacGia_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return TacGiaDAL.selectALL(listTacGia)
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
    Public Function buildMaTacGia(ByRef nextMaTacGia As Integer) As Result
        Return TacGiaDAL.buildMaTacGIa(nextMaTacGia)
    End Function
End Class
