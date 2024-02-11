Imports System.Net.Http
Imports System.Text
Imports System.Windows.Forms
Imports Models
Imports Models.User
Imports Newtonsoft.Json

Public Class Users

    Public Shared Async Function getLogin(ByVal email As String, ByVal password As String) As Task(Of LoginResult)

        Dim loginResult As New LoginResult()

        Dim query As String = $"mutation{{
                                    loginUser(email:""{email}"", password:""{password}""){{
                                        success
                                        token
                                        error
                                        user{{
                                            id
                                            email
                                            firstName
                                            lastName
                                            document
                                            phone
                                      }}
                                    }}
                                }}"

        ' Construye la consulta GraphQL como un objeto anónimo
        Dim requestData = New With {
            .query = query
        }

        Console.WriteLine(query)

        Dim jsonRequest As String = Newtonsoft.Json.JsonConvert.SerializeObject(requestData)

        Dim httpClient As New HttpClient()
        Dim requestContent As New StringContent(jsonRequest, Encoding.UTF8, "application/json")

        ' Establece la URL del servidor GraphQL al que deseas enviar la consulta
        Dim graphqlEndpoint As String = "http://192.168.1.20:8000/graphql"

        Try
            Dim response = Await httpClient.PostAsync(graphqlEndpoint, requestContent)

            If response.IsSuccessStatusCode Then
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                Dim responseData = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(jsonResponse)
                Dim userData = responseData("data")("loginUser")("user")
                loginResult.User = JsonConvert.DeserializeObject(Of User)(JsonConvert.SerializeObject(userData))
            Else
                loginResult.ErrorMessage = "Error al enviar la solicitud: " & response.StatusCode.ToString()
            End If
        Catch ex As Exception
            loginResult.ErrorMessage = "Error al enviar la solicitud: " & ex.Message
        Finally
            httpClient.Dispose()
        End Try

        Return loginResult
    End Function

End Class
