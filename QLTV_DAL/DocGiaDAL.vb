﻿Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility

Public Class DocGiaDAL
    Public connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function BuildMaDocGia(ByRef nextMaDocGia As String) As Result 'ex: 18222229
        nextMaDocGia = String.Empty
        Dim y = DateTime.Now.Year
        Dim x = y.ToString().Substring(2)
        nextMaDocGia = x + "000000"

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [madocgia] "
        query &= "FROM [tblDocGia] "
        query &= "ORDER BY [madocgia] DESC "

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
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("madocgia")
                        End While
                    End If
                    If (msOnDB <> Nothing And msOnDB.Length >= 8) Then
                        Dim currentYear = DateTime.Now.Year.ToString().Substring(2)
                        Dim iCurrentYear = Integer.Parse(currentYear)
                        Dim currentYearOnDB = msOnDB.Substring(0, 2)
                        Dim icurrentYearOnDB = Integer.Parse(currentYearOnDB)
                        Dim year = iCurrentYear
                        If (year < icurrentYearOnDB) Then
                            year = icurrentYearOnDB
                        End If
                        nextMaDocGia = year.ToString()
                        Dim v = msOnDB.Substring(2)
                        Dim convertDecimal = Convert.ToDecimal(v)
                        convertDecimal = convertDecimal + 1
                        Dim tmp = convertDecimal.ToString()
                        tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                        nextMaDocGia = nextMaDocGia + tmp
                        System.Console.WriteLine(nextMaDocGia)
                    End If

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số Độc Giả kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function Insert(dg As DocGiaDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblDocGia] ([madocgia], [hovaten], [maloaidocgia], [ngaysinh], [diachi],[email],[ngaylap],[ngayhethan],[tinhtrangthe],[sosachdamuon])"
        query &= "VALUES (@madocgia,@hovaten,@maloaidocgia,@ngaysinh,@diachi,@email, @ngaylap, @ngayhethan, @tinhtrangthe, @sosachdamuon)"

        'get MaDocGia
        Dim nextMaDocGia = "1"
        BuildMaDocGia(nextMaDocGia)
        dg.MaDocGia = nextMaDocGia

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@madocgia", dg.MaDocGia)
                    .Parameters.AddWithValue("@hovaten", dg.HoVaTen)
                    .Parameters.AddWithValue("@maloaidocgia", dg.LoaiDocGia)
                    .Parameters.AddWithValue("@ngaysinh", dg.NgaySinh)
                    .Parameters.AddWithValue("@diachi", dg.DiaChi)
                    .Parameters.AddWithValue("@email", dg.Email)
                    .Parameters.AddWithValue("@ngaylap", dg.NgayLap)
                    .Parameters.AddWithValue("@ngayhethan", dg.NgayHetHan)
                    .Parameters.AddWithValue("@tinhtrangthe", dg.TinhTrangThe)
                    .Parameters.AddWithValue("@sosachdamuon", dg.SoSachDaMuon)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm Độc Giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function SelectALL(ByRef listDocGia As List(Of DocGiaDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [madocgia], [hovaten], [maloaidocgia], [ngaysinh], [diachi], [email], [ngaylap],[ngayhethan],[tinhtrangthe],[sosachdamuon]"
        query &= "FROM [tblDocGia]"


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
                        listDocGia.Clear()
                        While reader.Read()
                            listDocGia.Add(New DocGiaDTO(reader("madocgia"), reader("hovaten"), reader("maloaidocgia"), reader("ngaysinh"), reader("diachi"), reader("email"), reader("ngaylap"), reader("ngayhethan"), reader("tinhtrangthe"), reader("sosachdamuon")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Độc Giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function SelectALL_ByType(MaLoaiDocGia As Integer, ByRef listDocGia As List(Of DocGiaDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [madocgia], [hovaten],[maloaidocgia], [ngaysinh], [diachi], [email], [ngaylap],[ngayhethan],[tinhtrangthe],[sosachdamuon] "
        query &= "FROM [tblDocGia] "
        query &= "WHERE [maloaidocgia] = @maloaidocgia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maloaidocgia", MaLoaiDocGia)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listDocGia.Clear()
                        While reader.Read()
                            listDocGia.Add(New DocGiaDTO(reader("madocgia"), reader("hovaten"), reader("maloaidocgia"), reader("ngaysinh"), reader("diachi"), reader("email"), reader("ngaylap"), reader("ngayhethan"), reader("tinhtrangthe"), reader("sosachdamuon")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Độc Giả theo Loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function Update(dg As DocGiaDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblDocGia] SET"
        query &= " ,[hovaten] = @hovaten "
        query &= " ,[maloaidocgia] = @maloaidocgia "
        query &= " ,[ngaysinh] = @ngaysinh "
        query &= " ,[diachi] = @diachi "
        query &= " ,[email] = @email "
        query &= " ,[ngaylap] = @ngaylap "
        query &= " ,[ngayhethan]=@ngayhethan"
        query &= " ,[tinhtrangthe]=@tinhtrangthe"
        query &= " ,[sosachdamuon]=@sosachdamuon"

        query &= " WHERE "
        query &= " [madocgia] = @madocgia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@hovaten", dg.HoVaTen)
                    .Parameters.AddWithValue("@maloaidocgia", dg.LoaiDocGia)
                    .Parameters.AddWithValue("@ngaysinh", dg.NgaySinh)
                    .Parameters.AddWithValue("@diachi", dg.DiaChi)
                    .Parameters.AddWithValue("@email", dg.Email)
                    .Parameters.AddWithValue("@ngaylap", dg.NgayLap)
                    .Parameters.AddWithValue("@madocgia", dg.MaDocGia)
                    .Parameters.AddWithValue("@ngayhethan", dg.NgayHetHan)
                    .Parameters.AddWithValue("@tinhtrangthe", dg.TinhTrangThe)
                    .Parameters.AddWithValue("@sosachdamuon", dg.SoSachDaMuon)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật Độc Giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function Delete(MaDocGia As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblDocGia] "
        query &= " WHERE "
        query &= " [madocgia] = @madocgia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@madocgia", MaDocGia)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa Độc Giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
End Class

