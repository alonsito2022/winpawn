Public Class Plan
    Private Sub btnPlan_Click(sender As Object, e As EventArgs) Handles btnPlan.Click
        ' Crear una instancia del formulario modal
        Dim formModal As New NewPlanForm()
        ' Abrir el formulario modal de manera modal (bloquea el formulario principal hasta que se cierre el modal)
        formModal.ShowDialog()
    End Sub
End Class