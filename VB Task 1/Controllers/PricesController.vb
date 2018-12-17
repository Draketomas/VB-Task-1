Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports VB_Task_1
Imports VB_Task_1.Models

Namespace Controllers
    Public Class PricesController
        Inherits System.Web.Mvc.Controller

        Private db As New Task1DBContext

        ' GET: Prices
        Function Index() As ActionResult
            Return View(db.Price.ToList())
        End Function

        ' GET: Prices/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim price As Price = db.Price.Find(id)
            If IsNothing(price) Then
                Return HttpNotFound()
            End If
            Return View(price)
        End Function

        ' GET: Prices/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Prices/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ID,PriceValue")> ByVal price As Price) As ActionResult
            If ModelState.IsValid Then
                db.Price.Add(price)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(price)
        End Function

        ' GET: Prices/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim price As Price = db.Price.Find(id)
            If IsNothing(price) Then
                Return HttpNotFound()
            End If
            Return View(price)
        End Function

        ' POST: Prices/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ID,PriceValue")> ByVal price As Price) As ActionResult
            If ModelState.IsValid Then
                db.Entry(price).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(price)
        End Function

        ' GET: Prices/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim price As Price = db.Price.Find(id)
            If IsNothing(price) Then
                Return HttpNotFound()
            End If
            Return View(price)
        End Function

        ' POST: Prices/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim price As Price = db.Price.Find(id)
            db.Price.Remove(price)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
