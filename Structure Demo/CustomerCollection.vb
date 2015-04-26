Public Class CustomerCollection
    Inherits CollectionBase

    Private objEmailHashtable As New Hashtable

    Public Sub Add(newCustomer As Customer)
        Me.List.Add(newCustomer)
    End Sub

    Public Sub Remove(oldCustomer As Customer)
        Me.List.Remove(oldCustomer)
    End Sub

    Default Public Property Item(index As Integer) As Customer
        Get
            Return CType(Me.List.Item(index), Customer)
        End Get
        Set(value As Customer)
            Me.List.Item(index) = value
        End Set
    End Property
End Class
