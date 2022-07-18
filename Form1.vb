Imports System.IO
Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Using Entry As StreamWriter = New StreamWriter(Application.StartupPath & "\PeopleEntry\" & "Data.txt")
            MessageBox.Show("Data Recorded!")

            Entry.WriteLine(vbCrLf & lblName.Text & " " + tbxName.Text)
            Entry.WriteLine(lblAddress.Text & " " + tbxAddress.Text)
            Entry.WriteLine(lblCnum.Text & " " + tbxCnum.Text)
            Entry.WriteLine(lblTemp.Text & " " + tbxTemp.Text)


            If radMale.Checked = True Then
                Entry.WriteLine(vbCrLf & gbxGender.Text + radMale.Text)
            Else
                Entry.WriteLine(vbCrLf & gbxGender.Text + " " + radFemale.Text)
            End If

            Entry.Close()

            tbxName.Text = ""
            tbxAddress.Text = ""
            tbxCnum.Text = ""
            tbxTemp.Text = ""

            radMale.Checked = False
            radFemale.Checked = False
        End Using

    End Sub
End Class
