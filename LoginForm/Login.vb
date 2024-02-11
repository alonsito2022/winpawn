Imports System.Net.Http
Imports System.Text

Public Class Login
    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text

        Dim query As String = $"mutation{{
                                loginUser(email:""{email}"", password:""{password}""){{
                                    success
                                    token
                                    error
                                }}
                            }}"

        ' Construye la consulta GraphQL como un objeto anónimo
        Dim requestData = New With {
            .query = query
        }

        Dim jsonRequest As String = Newtonsoft.Json.JsonConvert.SerializeObject(requestData)

        Dim httpClient As New HttpClient()
        Dim requestContent As New StringContent(jsonRequest, Encoding.UTF8, "application/json")

        ' Establece la URL del servidor GraphQL al que deseas enviar la consulta
        Dim graphqlEndpoint As String = "http://192.168.1.20:8000/graphql"

        Try
            Dim response = Await httpClient.PostAsync(graphqlEndpoint, requestContent)

            If response.IsSuccessStatusCode Then
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                ' Aquí puedes procesar la respuesta GraphQL en formato JSON según tus necesidades
                MessageBox.Show("Respuesta del servidor: " & jsonResponse, "Respuesta GraphQL")
            Else
                MessageBox.Show("Error al enviar la solicitud: " & response.StatusCode.ToString(), "Error")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al enviar la solicitud: " & ex.Message, "Error")
        Finally
            httpClient.Dispose()
        End Try
    End Sub
End Class