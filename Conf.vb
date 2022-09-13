Imports MaterialSkin
Imports System.IO

Public Class Conf
    Private Sub Conf_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()
        Timer2.Start()

        On Error Resume Next


        For Each d In Directory.GetDirectories(Application.StartupPath & "\Spi")
            Directory.Delete(d, True)
        Next

        ' Finish removing also the files in the root folder
        For Each f In Directory.GetFiles(Application.StartupPath & "\Spi")
            File.Delete(f)
        Next

        Directory.Delete(Application.StartupPath & "\Spi")



        For Each d In Directory.GetDirectories(Application.StartupPath & "\So")
            Directory.Delete(d, True)
        Next

        ' Finish removing also the files in the root folder
        For Each f In Directory.GetFiles(Application.StartupPath & "\So")
            File.Delete(f)
        Next

        Directory.Delete(Application.StartupPath & "\So")



        For Each d In Directory.GetDirectories(Application.StartupPath & "\sup")
            Directory.Delete(d, True)
        Next

        ' Finish removing also the files in the root folder
        For Each f In Directory.GetFiles(Application.StartupPath & "\sup")
            File.Delete(f)
        Next

        Directory.Delete(Application.StartupPath & "\sup")


        For Each d In Directory.GetDirectories(Application.StartupPath & "\Spi ME")
            Directory.Delete(d, True)
        Next

        ' Finish removing also the files in the root folder
        For Each f In Directory.GetFiles(Application.StartupPath & "\Spi ME")
            File.Delete(f)
        Next

        Directory.Delete(Application.StartupPath & "\Spi ME")


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Directory.CreateDirectory(Application.StartupPath & "\Dark")
        Directory.CreateDirectory(Application.StartupPath & "\Blue")
        Directory.CreateDirectory(Application.StartupPath & "\Conf")
        Directory.CreateDirectory(Application.StartupPath & "\Up")


        On Error Resume Next


        For Each d In Directory.GetDirectories(Application.StartupPath & "\Spi")
            Directory.Delete(d, True)
        Next

        ' Finish removing also the files in the root folder
        For Each f In Directory.GetFiles(Application.StartupPath & "\Spi")
            File.Delete(f)
        Next

        Directory.Delete(Application.StartupPath & "\Spi")





        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance









        Me.Close()

        Form1.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Form1.Hide()
        Form1.Timer5.Start()
    End Sub
End Class