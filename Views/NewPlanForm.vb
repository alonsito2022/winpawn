Public Class NewPlanForm
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Dim planForm As Plan = CType(Application.OpenForms("Plan"), Plan)

        'If planForm IsNot Nothing Then
        ' Crear un nuevo panel
        Dim nuevoPanel As New Panel()
        ' Configurar propiedades del nuevo panel
        'nuevoPanel.BackColor = Color.LightBlue
        'nuevoPanel.Size = New Size(200, 100)
        'nuevoPanel.Location = New Point(10, 10)

        ' Agregar el nuevo panel al panel PlanLeft del formulario principal
        Plan.PanelLeft.Controls.Add(nuevoPanel)
        'End If
    End Sub
End Class