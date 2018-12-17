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
    Public Class PartsController
        Inherits System.Web.Mvc.Controller

        Private db As New Task1DBContext

        ' GET: Parts
        Function Index() As ActionResult
            Dim parts = db.Parts.Include(Function(p) p.PriceRef)
            Return View(parts.ToList())
        End Function

        ' GET: Parts/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim parts As Parts = db.Parts.Find(id)
            Dim price As Price = db.Price.Find(parts.PriceID)
            If IsNothing(parts) Then
                Return HttpNotFound()
            End If
            parts.PriceRef = price
            Return View(parts)
        End Function

        ' GET: Parts/Create
        Function Create() As ActionResult
            ViewBag.PriceID = New SelectList(db.Price, "ID", "PriceValue")
            Return View()
        End Function

        ' POST: Parts/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ID,PartNumber,Description,PriceID")> ByVal parts As Parts) As ActionResult
            If ModelState.IsValid Then
                db.Parts.Add(parts)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.PriceID = New SelectList(db.Price, "ID", "PriceValue", parts.PriceID)
            Return View(parts)
        End Function

        ' GET: Parts/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim parts As Parts = db.Parts.Find(id)
            If IsNothing(parts) Then
                Return HttpNotFound()
            End If
            ViewBag.PriceID = New SelectList(db.Price, "ID", "PriceValue", parts.PriceID)
            Return View(parts)
        End Function

        ' POST: Parts/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ID,PartNumber,Description,PriceID")> ByVal parts As Parts) As ActionResult
            If ModelState.IsValid Then
                db.Entry(parts).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.PriceID = New SelectList(db.Price, "ID", "PriceValue", parts.PriceID)
            Return View(parts)
        End Function

        ' GET: Parts/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim parts As Parts = db.Parts.Find(id)
            If IsNothing(parts) Then
                Return HttpNotFound()
            End If
            Return View(parts)
        End Function

        ' POST: Parts/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim parts As Parts = db.Parts.Find(id)
            db.Parts.Remove(parts)
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
