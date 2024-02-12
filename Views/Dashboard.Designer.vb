<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.LateralMenu = New System.Windows.Forms.Panel()
        Me.SubMenuReport = New System.Windows.Forms.Panel()
        Me.btnReport2 = New System.Windows.Forms.Button()
        Me.btnReport1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCash = New System.Windows.Forms.Button()
        Me.SubMenuConfig = New System.Windows.Forms.Panel()
        Me.btnLetter = New System.Windows.Forms.Button()
        Me.btnFlat = New System.Windows.Forms.Button()
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.SubMenuAdmin = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.txtUsername = New System.Windows.Forms.Label()
        Me.PanelBotton = New System.Windows.Forms.Panel()
        Me.PanelBody = New System.Windows.Forms.Panel()
        Me.ImgLogo = New System.Windows.Forms.PictureBox()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.LateralMenu.SuspendLayout()
        Me.SubMenuReport.SuspendLayout()
        Me.SubMenuConfig.SuspendLayout()
        Me.SubMenuAdmin.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.PanelBody.SuspendLayout()
        CType(Me.ImgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LateralMenu
        '
        Me.LateralMenu.AutoScroll = True
        Me.LateralMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.LateralMenu.Controls.Add(Me.SubMenuReport)
        Me.LateralMenu.Controls.Add(Me.Button1)
        Me.LateralMenu.Controls.Add(Me.btnCash)
        Me.LateralMenu.Controls.Add(Me.SubMenuConfig)
        Me.LateralMenu.Controls.Add(Me.btnConfig)
        Me.LateralMenu.Controls.Add(Me.SubMenuAdmin)
        Me.LateralMenu.Controls.Add(Me.btnAdmin)
        Me.LateralMenu.Controls.Add(Me.PanelLogo)
        Me.LateralMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.LateralMenu.Location = New System.Drawing.Point(0, 0)
        Me.LateralMenu.Name = "LateralMenu"
        Me.LateralMenu.Size = New System.Drawing.Size(200, 561)
        Me.LateralMenu.TabIndex = 0
        '
        'SubMenuReport
        '
        Me.SubMenuReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.SubMenuReport.Controls.Add(Me.btnReport2)
        Me.SubMenuReport.Controls.Add(Me.btnReport1)
        Me.SubMenuReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuReport.Location = New System.Drawing.Point(0, 444)
        Me.SubMenuReport.Name = "SubMenuReport"
        Me.SubMenuReport.Size = New System.Drawing.Size(200, 87)
        Me.SubMenuReport.TabIndex = 7
        '
        'btnReport2
        '
        Me.btnReport2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReport2.FlatAppearance.BorderSize = 0
        Me.btnReport2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnReport2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnReport2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport2.Font = New System.Drawing.Font("Olimpos Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport2.ForeColor = System.Drawing.Color.White
        Me.btnReport2.Location = New System.Drawing.Point(0, 40)
        Me.btnReport2.Name = "btnReport2"
        Me.btnReport2.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnReport2.Size = New System.Drawing.Size(200, 40)
        Me.btnReport2.TabIndex = 1
        Me.btnReport2.Text = "Reporte2"
        Me.btnReport2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport2.UseVisualStyleBackColor = True
        '
        'btnReport1
        '
        Me.btnReport1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReport1.FlatAppearance.BorderSize = 0
        Me.btnReport1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnReport1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnReport1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport1.Font = New System.Drawing.Font("Olimpos Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport1.ForeColor = System.Drawing.Color.White
        Me.btnReport1.Location = New System.Drawing.Point(0, 0)
        Me.btnReport1.Name = "btnReport1"
        Me.btnReport1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnReport1.Size = New System.Drawing.Size(200, 40)
        Me.btnReport1.TabIndex = 0
        Me.btnReport1.Text = "Reporte1"
        Me.btnReport1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Olimpos Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 399)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(200, 45)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Reportes sistema"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCash
        '
        Me.btnCash.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCash.FlatAppearance.BorderSize = 0
        Me.btnCash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnCash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCash.Font = New System.Drawing.Font("Olimpos Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCash.ForeColor = System.Drawing.Color.White
        Me.btnCash.Location = New System.Drawing.Point(0, 354)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnCash.Size = New System.Drawing.Size(200, 45)
        Me.btnCash.TabIndex = 5
        Me.btnCash.Text = "Administracion caja"
        Me.btnCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCash.UseVisualStyleBackColor = True
        '
        'SubMenuConfig
        '
        Me.SubMenuConfig.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.SubMenuConfig.Controls.Add(Me.btnLetter)
        Me.SubMenuConfig.Controls.Add(Me.btnFlat)
        Me.SubMenuConfig.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuConfig.Location = New System.Drawing.Point(0, 267)
        Me.SubMenuConfig.Name = "SubMenuConfig"
        Me.SubMenuConfig.Size = New System.Drawing.Size(200, 87)
        Me.SubMenuConfig.TabIndex = 4
        '
        'btnLetter
        '
        Me.btnLetter.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLetter.FlatAppearance.BorderSize = 0
        Me.btnLetter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnLetter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLetter.Font = New System.Drawing.Font("Olimpos Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetter.ForeColor = System.Drawing.Color.White
        Me.btnLetter.Location = New System.Drawing.Point(0, 40)
        Me.btnLetter.Name = "btnLetter"
        Me.btnLetter.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnLetter.Size = New System.Drawing.Size(200, 40)
        Me.btnLetter.TabIndex = 1
        Me.btnLetter.Text = "Carta"
        Me.btnLetter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLetter.UseVisualStyleBackColor = True
        '
        'btnFlat
        '
        Me.btnFlat.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFlat.FlatAppearance.BorderSize = 0
        Me.btnFlat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnFlat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnFlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFlat.Font = New System.Drawing.Font("Olimpos Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFlat.ForeColor = System.Drawing.Color.White
        Me.btnFlat.Location = New System.Drawing.Point(0, 0)
        Me.btnFlat.Name = "btnFlat"
        Me.btnFlat.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnFlat.Size = New System.Drawing.Size(200, 40)
        Me.btnFlat.TabIndex = 0
        Me.btnFlat.Text = "Planos"
        Me.btnFlat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFlat.UseVisualStyleBackColor = True
        '
        'btnConfig
        '
        Me.btnConfig.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConfig.FlatAppearance.BorderSize = 0
        Me.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfig.Font = New System.Drawing.Font("Olimpos Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfig.ForeColor = System.Drawing.Color.White
        Me.btnConfig.Location = New System.Drawing.Point(0, 222)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnConfig.Size = New System.Drawing.Size(200, 45)
        Me.btnConfig.TabIndex = 3
        Me.btnConfig.Text = "Configuracion"
        Me.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfig.UseVisualStyleBackColor = True
        '
        'SubMenuAdmin
        '
        Me.SubMenuAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.SubMenuAdmin.Controls.Add(Me.btnPrint)
        Me.SubMenuAdmin.Controls.Add(Me.btnUser)
        Me.SubMenuAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuAdmin.Location = New System.Drawing.Point(0, 135)
        Me.SubMenuAdmin.Name = "SubMenuAdmin"
        Me.SubMenuAdmin.Size = New System.Drawing.Size(200, 87)
        Me.SubMenuAdmin.TabIndex = 2
        '
        'btnPrint
        '
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Olimpos Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(0, 40)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnPrint.Size = New System.Drawing.Size(200, 40)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Impresoras"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnUser
        '
        Me.btnUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Olimpos Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.White
        Me.btnUser.Location = New System.Drawing.Point(0, 0)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnUser.Size = New System.Drawing.Size(200, 40)
        Me.btnUser.TabIndex = 0
        Me.btnUser.Text = "Usuarios"
        Me.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAdmin.FlatAppearance.BorderSize = 0
        Me.btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Font = New System.Drawing.Font("Olimpos Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.Color.White
        Me.btnAdmin.Location = New System.Drawing.Point(0, 90)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnAdmin.Size = New System.Drawing.Size(200, 45)
        Me.btnAdmin.TabIndex = 1
        Me.btnAdmin.Text = "Administracion"
        Me.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(200, 90)
        Me.PanelLogo.TabIndex = 0
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.txtUsername)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(200, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(784, 30)
        Me.PanelTop.TabIndex = 1
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsername.AutoSize = True
        Me.txtUsername.Font = New System.Drawing.Font("Olimpos Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.White
        Me.txtUsername.Location = New System.Drawing.Point(775, 6)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(0, 19)
        Me.txtUsername.TabIndex = 0
        Me.txtUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PanelBotton
        '
        Me.PanelBotton.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.PanelBotton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBotton.Location = New System.Drawing.Point(200, 531)
        Me.PanelBotton.Name = "PanelBotton"
        Me.PanelBotton.Size = New System.Drawing.Size(784, 30)
        Me.PanelBotton.TabIndex = 2
        '
        'PanelBody
        '
        Me.PanelBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PanelBody.Controls.Add(Me.ImgLogo)
        Me.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBody.Location = New System.Drawing.Point(200, 30)
        Me.PanelBody.Name = "PanelBody"
        Me.PanelBody.Size = New System.Drawing.Size(784, 501)
        Me.PanelBody.TabIndex = 3
        '
        'ImgLogo
        '
        Me.ImgLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ImgLogo.Image = CType(resources.GetObject("ImgLogo.Image"), System.Drawing.Image)
        Me.ImgLogo.Location = New System.Drawing.Point(288, 145)
        Me.ImgLogo.Name = "ImgLogo"
        Me.ImgLogo.Size = New System.Drawing.Size(218, 220)
        Me.ImgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgLogo.TabIndex = 0
        Me.ImgLogo.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.PanelBody)
        Me.Controls.Add(Me.PanelBotton)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.LateralMenu)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.LateralMenu.ResumeLayout(False)
        Me.SubMenuReport.ResumeLayout(False)
        Me.SubMenuConfig.ResumeLayout(False)
        Me.SubMenuAdmin.ResumeLayout(False)
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.PanelBody.ResumeLayout(False)
        CType(Me.ImgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LateralMenu As Panel
    Public WithEvents btnAdmin As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents SubMenuConfig As Panel
    Friend WithEvents btnLetter As Button
    Friend WithEvents btnFlat As Button
    Public WithEvents btnConfig As Button
    Friend WithEvents SubMenuAdmin As Panel
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnUser As Button
    Friend WithEvents SubMenuReport As Panel
    Friend WithEvents btnReport2 As Button
    Friend WithEvents btnReport1 As Button
    Public WithEvents Button1 As Button
    Public WithEvents btnCash As Button
    Friend WithEvents PanelTop As Panel
    Friend WithEvents PanelBotton As Panel
    Friend WithEvents PanelBody As Panel
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents ImgLogo As PictureBox
    Friend WithEvents txtUsername As Label
End Class
