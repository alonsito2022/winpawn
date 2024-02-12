Public Class Dashboard
    Public Sub CustomizeDesing()
        SubMenuAdmin.Visible = False
        SubMenuConfig.Visible = False
        SubMenuReport.Visible = False
    End Sub
    Private Sub HiddenSubMenu()
        If (SubMenuAdmin.Visible = True) Then
            SubMenuAdmin.Visible = False
        End If
        If (SubMenuConfig.Visible = True) Then
            SubMenuConfig.Visible = False
        End If
        If (SubMenuReport.Visible = True) Then
            SubMenuReport.Visible = False
        End If
    End Sub
    Private Sub ShowSubMenu(ByVal SubMenu As Panel)
        If (SubMenu.Visible = False) Then
            HiddenSubMenu()
            SubMenu.Visible = True
        Else
            SubMenu.Visible = False
        End If
    End Sub
    Private activeMyForm As Form = Nothing

    Private Sub OpenChildForm(ByVal newChildForm As Form)
        ' Verificar si hay un formulario activo
        If activeMyForm IsNot Nothing AndAlso Not activeMyForm.IsDisposed Then
            activeMyForm.Close() ' Cerrar el formulario activo si existe
        End If

        ' Establecer el nuevo formulario como el formulario activo
        activeMyForm = newChildForm

        ' Configurar propiedades del nuevo formulario
        newChildForm.TopLevel = False
        newChildForm.FormBorderStyle = FormBorderStyle.None
        newChildForm.Dock = DockStyle.Fill

        ' Agregar el nuevo formulario al panel
        PanelBody.Controls.Add(newChildForm)
        PanelBody.Tag = newChildForm

        ' Traer el nuevo formulario al frente y mostrarlo
        newChildForm.BringToFront()
        newChildForm.Show()
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomizeDesing()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        ShowSubMenu(SubMenuAdmin)
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        btnUser.BackColor = Color.White
        btnUser.ForeColor = Color.Black
        OpenChildForm(New Login())
        HiddenSubMenu()
    End Sub
End Class