Public Class TacGia_DTO
    Private iMaTacGia As Integer
    Private strTenTacGia As String

    Public Sub New()
    End Sub
    Public Sub New(iMaTacGia As Integer, strTenTacGia As String)
        Me.iMaTacGia = iMaTacGia
        Me.strTenTacGia = strTenTacGia
    End Sub
    Property MaTacGia() As Integer
        Get
            Return iMaTacGia
        End Get
        Set(ByVal Value As Integer)
            iMaTacGia = Value
        End Set
    End Property
    Property TenTacGia() As String
        Get
            Return strTenTacGia
        End Get
        Set(ByVal Value As String)
            strTenTacGia = Value
        End Set
    End Property
End Class
