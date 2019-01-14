Public Class ClsEntTransPenjualan
    Private kdp As String
    Private ido As String
    Private tgl As Date
    Private total As Integer






    Public Property kdPenjualan() As String
        Get
            Return kdp
        End Get
        Set(value As String)
            kdp = value
        End Set
    End Property


    Public Property idOperator() As String
        Get
            Return ido
        End Get
        Set(value As String)
            ido = value
        End Set
    End Property

    Public Property tanggal() As Date
        Get
            Return tgl
        End Get
        Set(value As Date)
            tgl = value
        End Set
    End Property

    Public Property totalBelanja() As Integer
        Get
            Return total
        End Get
        Set(value As Integer)
            total = value
        End Set
    End Property
End Class
