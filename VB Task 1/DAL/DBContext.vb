Imports System.Data.Entity
Public Class Task1DBContext
    Inherits DbContext
    Public Property Parts As DbSet(Of Models.Parts)
    Public Property Price As DbSet(Of Models.Price)
End Class
