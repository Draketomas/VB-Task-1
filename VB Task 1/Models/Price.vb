Imports System.ComponentModel.DataAnnotations

Namespace Models
    Public Class Price
        Public Property ID() As Integer
        <Display(Name:="Price")>
        Public Property PriceValue() As Decimal
    End Class
End Namespace
