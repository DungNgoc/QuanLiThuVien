Public Class LoaiDocGia_DTO


    Private iMaLoaiDocGia As Integer
    Private strTenLoaiDocGia As String

    Public Sub New()
    End Sub
    Public Sub New(ml As Integer, tl As String)
        iMaLoaiDocGia = ml
        strTenLoaiDocGia = tl
    End Sub
    Property MaLoaiDocGia() As Integer
        Get
            Return iMaLoaiDocGia
        End Get
        Set(ByVal Value As Integer)
            iMaLoaiDocGia = Value
        End Set
    End Property
    Property TenLoaiDocGia() As String
        Get
            Return strTenLoaiDocGia
        End Get
        Set(ByVal Value As String)
            strTenLoaiDocGia = Value
        End Set
    End Property

End Class


