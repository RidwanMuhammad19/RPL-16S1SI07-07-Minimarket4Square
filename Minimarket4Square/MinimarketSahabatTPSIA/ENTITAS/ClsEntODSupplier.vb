Public Class ClsEntODSupplier
    Private idSup As String
    Private nama As String
    Private alamat As String
    Private telpon As String
    Private email As String


    Public Property idSupplier() As String
        Get
            Return idSup
        End Get
        Set(value As String)
            idSup = value
        End Set
    End Property

    Public Property NamaSupplier() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property alamatSupplier() As String
        Get
            Return alamat
        End Get
        Set(value As String)
            alamat = value
        End Set
    End Property

    Public Property teleponSup() As String
        Get
            Return telpon
        End Get
        Set(value As String)
            telpon = value
        End Set
    End Property

    Public Property emailSup() As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property
End Class
