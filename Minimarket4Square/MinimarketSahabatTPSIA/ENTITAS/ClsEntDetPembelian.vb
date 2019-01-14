Public Class ClsEntDetPembelian
    Private kdp As String
    Private ids As String
    Private qty As Integer
    Private sTotal As Integer

    Public Property kdPembelian() As String
        Get
            Return kdp
        End Get
        Set(value As String)
            kdp = value
        End Set
    End Property


    Public Property idSupplier() As String
        Get
            Return ids
        End Get
        Set(value As String)
            ids = value
        End Set
    End Property

    Public Property quantity() As Integer
        Get
            Return qty
        End Get
        Set(value As Integer)
            qty = value
        End Set
    End Property

    Public Property subTotal() As Integer
        Get
            Return sTotal
        End Get
        Set(value As Integer)
            sTotal = value
        End Set
    End Property
End Class
