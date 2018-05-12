Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility

Public Class TheLoaiSach_DAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function getNextID(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaTheLoaiSach] "
        query &= "FROM [tblTheLoaiSach] "
        query &= "ORDER BY [MaTheLoaiSach] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("MaTheLoaiSach")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của thể loại sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(TheLoaiSach As TheLoaiSach_DTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblTheLoaiSach] ([MaTheLoaiSach], [TenTheLoaiSach])"
        query &= "VALUES (@MaTheLoaiSach,@TenTheLoaiSach)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        TheLoaiSach.MaTheLoaiSach = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaTheLoaiSach", TheLoaiSach.MaTheLoaiSach)
                    .Parameters.AddWithValue("@TenTheLoaiSach", TheLoaiSach.TenTheLoaiSach)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    'Public Function update(lhs As LoaiHocSinhDTO) As Result

    '    Dim query As String = String.Empty
    '    query &= " UPDATE [tblLoaiHocSinh] SET"
    '    query &= " [tenloaihocsinh] = @tenloaihocsinh "
    '    query &= "WHERE "
    '    query &= " [maloaihocsinh] = @maloaihocsinh "

    '    Using conn As New SqlConnection(connectionString)
    '        Using comm As New SqlCommand()
    '            With comm
    '                .Connection = conn
    '                .CommandType = CommandType.Text
    '                .CommandText = query
    '                .Parameters.AddWithValue("@maloaihocsinh", lhs.MaLoaiHS)
    '                .Parameters.AddWithValue("@tenloaihocsinh", lhs.TenLoai)
    '            End With
    '            Try
    '                conn.Open()
    '                comm.ExecuteNonQuery()
    '            Catch ex As Exception
    '                Console.WriteLine(ex.StackTrace)
    '                conn.Close()
    '                ' them that bai!!!
    '                Return New Result(False, "Cập nhật học sinh không thành công", ex.StackTrace)
    '            End Try
    '        End Using
    '    End Using
    'Return New Result(True) ' thanh cong
    'End Function

    Public Function selectALL(ByRef listTheloaiSach As List(Of TheLoaiSach_DTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaTheLoaiSach], [TenTheLoaiSach]"
        query &= " FROM [tblTheLoaiSach]"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listTheloaiSach.Clear()
                        While reader.Read()
                            listTheloaiSach.Add(New TheLoaiSach_DTO(reader("MaTheLoaiSach"), reader("TenTheLoaiSach")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả thể loại sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    'Public Function delete(maLoai As Integer) As Result

    '    Dim query As String = String.Empty
    '    query &= " DELETE FROM [tblLoaiHocSinh] "
    '    query &= " WHERE "
    '    query &= " [maloaihocsinh] = @maloaihocsinh "

    '    Using conn As New SqlConnection(connectionString)
    '        Using comm As New SqlCommand()
    '            With comm
    '                .Connection = conn
    '                .CommandType = CommandType.Text
    '                .CommandText = query
    '                .Parameters.AddWithValue("@maloaihocsinh", maLoai)
    '            End With
    '            Try
    '                conn.Open()
    '                comm.ExecuteNonQuery()
    '            Catch ex As Exception
    '                Console.WriteLine(ex.StackTrace)
    '                conn.Close()
    '                ' them that bai!!!
    '                Return New Result(False, "Xóa học sinh không thành công", ex.StackTrace)
    '            End Try
    '        End Using
    '    End Using
    '    Return New Result(True) ' thanh cong
    'End Function
End Class
