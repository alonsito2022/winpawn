Imports Models
Public Class Dashboard
    Dim par_user As New User
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
        BackgroundForm()
        HiddenInitial()
        OpenChildForm(New Login())
    End Sub
    Public Sub HiddenInitial()
        PanelTop.Visible = False
        PanelLogo.Visible = False
        LateralMenu.Visible = False
        PanelBotton.Visible = False
    End Sub
    Public Sub ShowInitial()
        PanelTop.Visible = True
        PanelLogo.Visible = True
        LateralMenu.Visible = True
        PanelBotton.Visible = True
        PanelBody.Controls.Clear()
        PanelBody.Controls.Add(ImgLogo)
    End Sub
    Private Sub BackgroundForm()
        ' Crear un degradado lineal horizontal
        Dim bmp As New Bitmap(LateralMenu.Width, LateralMenu.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            Dim rect As New Rectangle(0, 0, LateralMenu.Width, LateralMenu.Height)
            Dim brush As New Drawing2D.LinearGradientBrush(rect, Color.FromArgb(15, 46, 84), Color.FromArgb(24, 70, 130), Drawing2D.LinearGradientMode.Horizontal)
            g.FillRectangle(brush, rect)
        End Using
        ' Establecer la imagen de fondo del panel como el degradado
        LateralMenu.BackgroundImage = bmp
        LateralMenu.BackgroundImageLayout = ImageLayout.Stretch ' Ajustar la imagen al tamaño del panel
        ' Establecer el color de fondo sólido del panel
        'LateralMenu.BackColor = Color.FromArgb(24, 70, 130)

        PanelLogo.BackgroundImage = bmp
        PanelLogo.BackgroundImageLayout = ImageLayout.Stretch

        btnAdmin.BackgroundImage = bmp
        btnAdmin.BackgroundImageLayout = ImageLayout.Stretch

        btnConfig.BackgroundImage = bmp
        btnConfig.BackgroundImageLayout = ImageLayout.Stretch

        btnCash.BackgroundImage = bmp
        btnCash.BackgroundImageLayout = ImageLayout.Stretch

        btnReport.BackgroundImage = bmp
        btnReport.BackgroundImageLayout = ImageLayout.Stretch

        Dim bmp1 As New Bitmap(PanelTop.Width, PanelTop.Height)
        Using g As Graphics = Graphics.FromImage(bmp1)
            Dim rect As New Rectangle(0, 0, PanelTop.Width, PanelTop.Height)
            Dim brush As New Drawing2D.LinearGradientBrush(rect, Color.FromArgb(28, 70, 124), Color.FromArgb(16, 59, 115), Drawing2D.LinearGradientMode.Horizontal)
            g.FillRectangle(brush, rect)
        End Using

        PanelTop.BackgroundImage = bmp1
        PanelTop.BackgroundImageLayout = ImageLayout.Stretch

        PanelBotton.BackgroundImage = bmp1
        PanelBotton.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
    Private Sub PanelBody_Paint(sender As Object, e As PaintEventArgs) Handles PanelBody.Paint
        Dim borderColor As Color = Color.FromArgb(53, 113, 182) ' Color del borde derecho
        Dim borderWidth As Integer = 2 ' Ancho del borde Izquierdo

        Dim g As Graphics = e.Graphics
        Dim pen As New Pen(borderColor, borderWidth)

        ' Dibujar el borde derecho del panel
        g.DrawLine(pen, borderWidth, 0, borderWidth, PanelBody.Height)
    End Sub
    Private Sub PanelLogo_Paint(sender As Object, e As PaintEventArgs) Handles PanelLogo.Paint
        Dim borderColor As Color = Color.FromArgb(53, 113, 182) ' Color del borde derecho
        Dim borderWidth As Integer = 2 ' Ancho del borde abajo

        Dim g As Graphics = e.Graphics
        Dim pen As New Pen(borderColor, borderWidth)

        ' Dibujar el borde derecho del panel
        g.DrawLine(pen, 0, PanelLogo.Height - borderWidth, PanelLogo.Width, PanelLogo.Height - borderWidth)
    End Sub
    Private Sub PanelTop_Paint(sender As Object, e As PaintEventArgs) Handles PanelTop.Paint
        Dim borderColor As Color = Color.FromArgb(53, 113, 182) ' Color del borde derecho
        Dim borderWidth As Integer = 2 ' Ancho del borde abajo

        Dim g As Graphics = e.Graphics
        Dim pen As New Pen(borderColor, borderWidth)

        ' Dibujar el borde derecho del panel
        g.DrawLine(pen, 0, PanelTop.Height - borderWidth, PanelTop.Width, PanelTop.Height - borderWidth)
    End Sub
    Private Sub PanelBotton_Paint(sender As Object, e As PaintEventArgs) Handles PanelBotton.Paint
        Dim borderColor As Color = Color.FromArgb(53, 113, 182) ' Color del borde derecho
        Dim borderWidth As Integer = 2 ' Ancho del borde superior

        Dim g As Graphics = e.Graphics
        Dim pen As New Pen(borderColor, borderWidth)

        'Dibujar el borde superior del panel
        g.DrawLine(pen, 0, 0, PanelBotton.Width, 0)
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        ShowSubMenu(SubMenuAdmin)
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        RadialMenuDashboard.ShowPopup(New Drawing.Point(Me.Width / 2, Me.Height / 2))
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub

    Private Sub btnFlat_Click(sender As Object, e As EventArgs) Handles btnFlat.Click
        OpenChildForm(New Plan())
    End Sub

    Private Sub btnLetter_Click(sender As Object, e As EventArgs) Handles btnLetter.Click

    End Sub

    Private Sub btnReport1_Click(sender As Object, e As EventArgs) Handles btnReport1.Click

    End Sub

    Private Sub btnReport2_Click(sender As Object, e As EventArgs) Handles btnReport2.Click

    End Sub

    Private Sub lblLogo_Click(sender As Object, e As EventArgs) Handles lblLogo.Click
        PanelBody.Controls.Clear()
        PanelBody.Controls.Add(ImgLogo)
    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        ShowSubMenu(SubMenuConfig)
    End Sub
End Class