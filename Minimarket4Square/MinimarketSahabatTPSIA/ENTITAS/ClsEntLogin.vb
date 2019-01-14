Public Class ClsEntLogin
    Private username As String
    Private password As String
    Private status As String
    Private kdo As String

    Public Property usernameOperator() As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property kodeOperator() As String
        Get
            Return kdo
        End Get
        Set(value As String)
            kdo = value
        End Set
    End Property

    Public Property passOperator() As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
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
End Class
