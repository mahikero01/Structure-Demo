Public Structure Customer
    Public FirstName As String
    Public LastName As String
    Public Email As String
    Public ReadOnly Property Name() As String
        Get

            Return FirstName & " " & LastName
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return Name & " (" & Email & ")"
    End Function
End Structure
