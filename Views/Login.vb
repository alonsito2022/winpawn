Imports System.Net.Http
Imports System.Text
Imports Graphql.Users
Imports Models

Public Class Login
    Dim result As New LoginResult
    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim email As String = txtUser.Text
        Dim password As String = txtPassword.Text

        result = Await getLogin(email, password)

        If result.ErrorMessage IsNot Nothing Then
            MessageBox.Show(result.ErrorMessage, "Error")
        ElseIf result.User IsNot Nothing Then
            ' Hacer algo con el usuario, por ejemplo, mostrar un mensaje de bienvenida
            'MessageBox.Show("¡Bienvenido, " & result.User.firstName & "!", "Inicio de sesión exitoso")
            Dashboard.txtUsername.Text = result.User.firstName + " " + result.User.lastName

            ' Ajustar el tamaño del Label para que quepa todo el texto
            Dashboard.txtUsername.AutoSize = True

            ' Obtener el ancho actual del Label
            Dim currentWidth As Integer = Dashboard.txtUsername.Width

            ' Establecer la nueva posición del Label
            Dashboard.txtUsername.Left = Dashboard.txtUsername.Left - currentWidth ' Mover el Label a la izquierda
            Dashboard.txtUsername.Width = currentWidth ' Establecer el ancho del Label igual al ancho original

            ' Alinear el texto a la derecha para que el texto largo se muestre a la izquierda
            Dashboard.txtUsername.TextAlign = ContentAlignment.MiddleRight
        Else
            MessageBox.Show("No se pudo iniciar sesión.", "Error")
        End If
    End Sub
    Private Sub BackgroundForm()
        ' Crear un degradado lineal horizontal
        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)
            Dim brush As New Drawing2D.LinearGradientBrush(rect, Color.FromArgb(28, 70, 124), Color.FromArgb(16, 59, 115), Drawing2D.LinearGradientMode.Horizontal)
            g.FillRectangle(brush, rect)
        End Using
        ' Establecer la imagen de fondo del panel como el degradado
        Me.BackgroundImage = bmp
        Me.BackgroundImageLayout = ImageLayout.Stretch
        lblEmail.ForeColor = Color.White
        lblPassword.ForeColor = Color.White
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundForm()
    End Sub
End Class