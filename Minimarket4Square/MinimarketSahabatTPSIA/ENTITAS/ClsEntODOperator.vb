Public Class ClsEntODOperator
    Private id As String
    Private nama As String
    Private alamat As String
    Private telpon As String
    Private status As String
    Private username As String
    Private password As String


    Public Property idOperator() As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property

    Public Property NamaOperator() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property alamatOperator() As String
        Get
            Return alamat
        End Get
        Set(value As String)
            alamat = value
        End Set
    End Property

    Public Property telponOperator() As String
        Get
            Return telpon
        End Get
        Set(value As String)
            telpon = value
        End Set
    End Property

    Public Property statusOperator() As String
        Get
            Return status
        End Get
        Set(value As String)
            status = value
        End Set
    End Property

    Public Property usernameOp() As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property passOp() As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property
End Class
