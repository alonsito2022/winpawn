Imports System.Net.Http
Imports System.Text
Imports Models.LoginResult
Imports Graphql.Users
Imports Models

Public Class Login
    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text

        Dim result As LoginResult = Await getLogin(email, password)

        If result.ErrorMessage IsNot Nothing Then
            MessageBox.Show(result.ErrorMessage, "Error")
        ElseIf result.User IsNot Nothing Then
            ' Hacer algo con el usuario, por ejemplo, mostrar un mensaje de bienvenida
            MessageBox.Show("¡Bienvenido, " & result.User.firstName & "!", "Inicio de sesión exitoso")
        Else
            MessageBox.Show("No se pudo iniciar sesión.", "Error")
        End If

    End Sub

End Class