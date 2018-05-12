Public Class TheLoaiSach_DTO
    Private iMaTheLoai As Integer
    Private strTenTheLoai As String

    Public Sub New()
    End Sub
    Public Sub New(iMaTheLoai As Integer, strTenTheLoai As String)
        Me.iMaTheLoai = iMaTheLoai
        Me.strTenTheLoai = strTenTheLoai
    End Sub
    Property MaTheLoaiSach() As Integer
        Get
            Return iMaTheLoai
        End Get
        Set(ByVal Value As Integer)
            iMaTheLoai = Value
        End Set
    End Property
    Property TenTheLoaiSach() As String
        Get
            Return strTenTheLoai
        End Get
        Set(ByVal Value As String)
            strTenTheLoai = Value
        End Set
    End Property
End Class
