Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click
        Dim str As String
        str = txtFullName.Text

        Dim str2 As String
        str2 = str.Trim()

        Dim firstSpace As Integer
        firstSpace = str2.IndexOf(" ")

        Dim fstName As String
        fstName = str2.Substring(0, firstSpace)

        txtFirstName.Text = CStr(fstName)



    End Sub
End Class
