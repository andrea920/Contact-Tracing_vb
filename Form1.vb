Imports System.IO
Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim Entry As StreamWriter = New StreamWriter(Application.StartupPath & "\PeopleEntry\" & "Data.txt")


        Entry.WriteLine(lblName.Text & " " + tbxName.Text)
        Entry.WriteLine(lblAddress.Text & " " + tbxAddress.Text)
        Entry.WriteLine(lblCnum.Text & " " + tbxCnum.Text)
        Entry.WriteLine(lblTemp.Text & " " + tbxTemp.Text)


    End Sub
End Class
