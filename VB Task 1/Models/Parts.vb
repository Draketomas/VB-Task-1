Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Namespace Models
    Public Class Parts
        'Primary Key
        Public Property ID() As Integer
        Public Property PartNumber() As String
        Public Property Description() As String
        Public Property PriceID() As Integer
        <ForeignKey("PriceID")>
        Public Property PriceRef() As Price
    End Class
End Namespace