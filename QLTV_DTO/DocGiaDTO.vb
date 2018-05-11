Public Class DocGiaDTO
    Private strMaDocGia As String
    Private strHoVaTen As String
    Private iLoaiDocGia As Integer
    Private dateNgaySinh As DateTime
    Private strDiaChi As String
    Private strEmail As String
    Private dateNgayLap As DateTime
    Public Sub New()

    End Sub

    Public Sub New(strMaDocGia As String, strHoVaTen As String, iLoaiDocGia As Integer, dateNgaySinh As DateTime, strDiaChi As String, strEmail As String, dateNgayLap As DateTime)
        Me.strMaDocGia = strMaDocGia
        Me.strHoVaTen = strHoVaTen
        Me.iLoaiDocGia = iLoaiDocGia
        Me.dateNgaySinh = dateNgaySinh
        Me.strDiaChi = strDiaChi
        Me.strEmail = strEmail
        Me.dateNgayLap = dateNgayLap
    End Sub

    Property MaDocGia() As String
        Get
            Return strMaDocGia
        End Get
        Set(ByVal Value As String)
            strMaDocGia = Value
        End Set
    End Property

    Property HoVaTen() As String
        Get
            Return strHoVaTen
        End Get
        Set(ByVal Value As String)
            strHoVaTen = Value
        End Set
    End Property

    Property LoaiDocGia() As Integer
        Get
            Return iLoaiDocGia
        End Get
        Set(ByVal Value As Integer)
            iLoaiDocGia = Value
        End Set
    End Property

    Property NgaySinh() As DateTime
        Get
            Return dateNgaySinh
        End Get
        Set(ByVal Value As DateTime)
            dateNgaySinh = Value
        End Set
    End Property

    Property DiaChi() As String
        Get
            Return strDiaChi
        End Get
        Set(ByVal Value As String)
            strDiaChi = Value
        End Set
    End Property

    Property Email() As String
        Get
            Return strEmail
        End Get
        Set(ByVal Value As String)
            strEmail = Value
        End Set
    End Property

    Property NgayLap() As DateTime
        Get
            Return dateNgayLap
        End Get
        Set(ByVal Value As DateTime)
            dateNgayLap = Value
        End Set
    End Property



End Class
