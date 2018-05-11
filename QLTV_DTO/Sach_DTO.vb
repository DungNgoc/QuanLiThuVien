Public Class Sach_DTO
    Private strMaSach As String
    Private strTenSach As String
    Private iTheLoai As Integer
    Private strMaTacGia As String
    Private strTenTacGia As String
    Private strNamXuatBan As String
    Private strNhaXuatBan As String
    Private dateNgayNhap As DateTime
    Private strTriGia As String



    Public Sub New()
    End Sub
    Public Sub New(strMaSach As String,
                   strTenSach As String,
                   iTheLoai As Integer,
                   strMaTacGia As String,
                   strTenTacGia As String,
                   strNamXuatBan As String,
                   strNhaXuatBan As String,
                   dateNgayNhap As DateTime,
                   strTriGia As String)


        Me.strMaSach = strMaSach
        Me.strTenSach = strTenSach
        Me.iTheLoai = iTheLoai
        Me.strMaTacGia = strMaTacGia
        Me.strTenTacGia = strTenTacGia
        Me.strNamXuatBan = strNamXuatBan
        Me.strNhaXuatBan = strNhaXuatBan
        Me.dateNgayNhap = dateNgayNhap
        Me.strTriGia = strTriGia

    End Sub
    Property MaSach() As String
        Get
            Return strMaSach
        End Get
        Set(ByVal value As String)
            strMaSach = value
        End Set
    End Property
    Property TenSach() As String
        Get
            Return strTenSach
        End Get
        Set(ByVal value As String)
            strTenSach = value
        End Set
    End Property
    Property TheLoai() As Integer
        Get
            Return iTheLoai
        End Get
        Set(ByVal value As Integer)
            iTheLoai = value
        End Set
    End Property
    Property TenTacGia() As String
        Get
            Return strTenTacGia
        End Get
        Set(ByVal value As String)
            strTenTacGia = value
        End Set
    End Property
    Property MaTacGia() As String
        Get
            Return strMaTacGia
        End Get
        Set(ByVal value As String)
            strMaTacGia = value
        End Set
    End Property
    Property NamXuatBan() As String
        Get
            Return strNamXuatBan
        End Get
        Set(ByVal value As String)
            strNamXuatBan = value
        End Set
    End Property
    Property NhaXuatBan() As String
        Get
            Return strNhaXuatBan
        End Get
        Set(ByVal value As String)
            strNhaXuatBan = value
        End Set
    End Property
    Property NgayNhap() As Date
        Get
            Return dateNgayNhap
        End Get
        Set(ByVal value As Date)
            dateNgayNhap = value
        End Set
    End Property
    Property TriGia() As String
        Get
            Return strTriGia
        End Get
        Set(ByVal value As String)
            strTriGia = value
        End Set
    End Property
End Class
