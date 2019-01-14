Public Class ClsEntDetPenjualan
    Private kdp As String
    Private kdb As String
    Private subtot As Integer
    Private jml As Integer

    Public Property kodePenjualan() As String
        Get
            Return kdp
        End Get
        Set(value As String)
            kdp = value
        End Set
    End Property

    Public Property kodeBarang() As String
        Get
            Return kdb
        End Get
        Set(value As String)
            kdb = value
        End Set
    End Property

    Public Property subtotal() As String
        Get
            Return subtot
        End Get
        Set(value As String)
            subtot = value
        End Set
    End Property

    Public Property jumlahBeli() As String
        Get
            Return jml
        End Get
        Set(value As String)
            jml = value
        End Set
    End Property

End Class
