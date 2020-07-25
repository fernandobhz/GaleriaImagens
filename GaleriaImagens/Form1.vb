Imports System.IO

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dir As String = "E:\nova pasta"
        ImageGallery1.Directorypath = dir

    End Sub

    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub ImageGallery1_ImagemAdicionada(Local As String) Handles ImageGallery1.ImagemAdicionada
        MsgBox("Imagem adicionada: " & Local)
    End Sub

    Private Sub ImageGallery1_ImagemDeletada(Local As String) Handles ImageGallery1.ImagemDeletada
        MsgBox("Imagem deletada: " & Local)

    End Sub

End Class

