Public Class ClsEntSementara
    Private kdb As String
    Private nama As String
    Private harga As Integer
    Private jml As Integer
    Private subtotal As Integer

    Public Property kdbSementara() As String
        Get
            Return kdb
        End Get
        Set(value As String)
            kdb = value
        End Set
    End Property

    Public Property namaSementara() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property hargaSementara() As Integer
        Get
            Return harga
        End Get
        Set(value As Integer)
            harga = value
        End Set
    End Property

    Public Property jumlahSementara() As Integer
        Get
            Return jml
        End Get
        Set(value As Integer)
            jml = value
        End Set
    End Property

    Public Property subtotalSementara() As Integer
        Get
            Return subtotal
        End Get
        Set(value As Integer)
            subtotal = value
        End Set
    End Property

End Class
