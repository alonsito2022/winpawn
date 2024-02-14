<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.LateralMenu = New System.Windows.Forms.Panel()
        Me.SubMenuReport = New System.Windows.Forms.Panel()
        Me.btnReport2 = New System.Windows.Forms.Button()
        Me.btnReport1 = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
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
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.txtUsername = New System.Windows.Forms.Label()
        Me.PanelBotton = New System.Windows.Forms.Panel()
        Me.PanelBody = New System.Windows.Forms.Panel()
        Me.ImgLogo = New System.Windows.Forms.PictureBox()
        Me.RadialMenuDashboard = New DevExpress.XtraBars.Ribbon.RadialMenu(Me.components)
        Me.Radial_btnUsers = New DevExpress.XtraBars.BarButtonItem()
        Me.Radia_btnBusiness = New DevExpress.XtraBars.BarButtonItem()
        Me.Radial_btnSubsidiaries = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LateralMenu.SuspendLayout()
        Me.SubMenuReport.SuspendLayout()
        Me.SubMenuConfig.SuspendLayout()
        Me.SubMenuAdmin.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.PanelBody.SuspendLayout()
        CType(Me.ImgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadialMenuDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LateralMenu
        '
        Me.LateralMenu.AutoScroll = True
        Me.LateralMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.LateralMenu.Controls.Add(Me.SubMenuReport)
        Me.LateralMenu.Controls.Add(Me.btnReport)
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
        Me.SubMenuReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer))
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
        Me.btnReport2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReport2.FlatAppearance.BorderSize = 0
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
        Me.btnReport1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReport1.FlatAppearance.BorderSize = 0
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
        'btnReport
        '
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Olimpos Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.Location = New System.Drawing.Point(0, 399)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnReport.Size = New System.Drawing.Size(200, 45)
        Me.btnReport.TabIndex = 6
        Me.btnReport.Text = "Reportes sistema"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnCash
        '
        Me.btnCash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCash.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCash.FlatAppearance.BorderSize = 0
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
        Me.SubMenuConfig.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer))
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
        Me.btnLetter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLetter.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLetter.FlatAppearance.BorderSize = 0
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
        Me.btnFlat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFlat.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFlat.FlatAppearance.BorderSize = 0
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
        Me.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfig.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConfig.FlatAppearance.BorderSize = 0
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
        Me.SubMenuAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer))
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
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPrint.FlatAppearance.BorderSize = 0
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
        Me.btnUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUser.FlatAppearance.BorderSize = 0
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
        Me.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAdmin.FlatAppearance.BorderSize = 0
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
        Me.PanelLogo.Controls.Add(Me.lblLogo)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(200, 90)
        Me.PanelLogo.TabIndex = 0
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.BackColor = System.Drawing.Color.Transparent
        Me.lblLogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLogo.Font = New System.Drawing.Font("Olimpos Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogo.ForeColor = System.Drawing.Color.White
        Me.lblLogo.Location = New System.Drawing.Point(12, 21)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(174, 48)
        Me.lblLogo.TabIndex = 0
        Me.lblLogo.Text = "Sistema"
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(100, Byte), Integer))
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
        Me.txtUsername.BackColor = System.Drawing.Color.Transparent
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
        Me.PanelBotton.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.PanelBotton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBotton.Location = New System.Drawing.Point(200, 531)
        Me.PanelBotton.Name = "PanelBotton"
        Me.PanelBotton.Size = New System.Drawing.Size(784, 30)
        Me.PanelBotton.TabIndex = 2
        '
        'PanelBody
        '
        Me.PanelBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.PanelBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelBody.Controls.Add(Me.ImgLogo)
        Me.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBody.Location = New System.Drawing.Point(200, 30)
        Me.PanelBody.Name = "PanelBody"
        Me.PanelBody.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.PanelBody.Size = New System.Drawing.Size(784, 501)
        Me.PanelBody.TabIndex = 3
        '
        'ImgLogo
        '
        Me.ImgLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ImgLogo.Image = CType(resources.GetObject("ImgLogo.Image"), System.Drawing.Image)
        Me.ImgLogo.Location = New System.Drawing.Point(290, 145)
        Me.ImgLogo.Name = "ImgLogo"
        Me.ImgLogo.Size = New System.Drawing.Size(218, 220)
        Me.ImgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgLogo.TabIndex = 0
        Me.ImgLogo.TabStop = False
        '
        'RadialMenuDashboard
        '
        Me.RadialMenuDashboard.AutoExpand = True
        Me.RadialMenuDashboard.ButtonRadius = 20
        Me.RadialMenuDashboard.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Radial_btnUsers), New DevExpress.XtraBars.LinkPersistInfo(Me.Radia_btnBusiness), New DevExpress.XtraBars.LinkPersistInfo(Me.Radial_btnSubsidiaries)})
        Me.RadialMenuDashboard.Manager = Me.BarManager1
        Me.RadialMenuDashboard.Name = "RadialMenuDashboard"
        '
        'Radial_btnUsers
        '
        Me.Radial_btnUsers.Caption = "Lista Usuarios"
        Me.Radial_btnUsers.Id = 0
        Me.Radial_btnUsers.ItemAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Radial_btnUsers.ItemAppearance.Normal.Font = New System.Drawing.Font("Olimpos Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radial_btnUsers.ItemAppearance.Normal.ForeColor = System.Drawing.Color.White
        Me.Radial_btnUsers.ItemAppearance.Normal.Options.UseBackColor = True
        Me.Radial_btnUsers.ItemAppearance.Normal.Options.UseFont = True
        Me.Radial_btnUsers.ItemAppearance.Normal.Options.UseForeColor = True
        Me.Radial_btnUsers.ItemInMenuAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Radial_btnUsers.ItemInMenuAppearance.Normal.ForeColor = System.Drawing.Color.White
        Me.Radial_btnUsers.ItemInMenuAppearance.Normal.Options.UseBackColor = True
        Me.Radial_btnUsers.ItemInMenuAppearance.Normal.Options.UseForeColor = True
        Me.Radial_btnUsers.Name = "Radial_btnUsers"
        '
        'Radia_btnBusiness
        '
        Me.Radia_btnBusiness.Caption = "Empresa"
        Me.Radia_btnBusiness.Id = 1
        Me.Radia_btnBusiness.ItemAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Radia_btnBusiness.ItemAppearance.Normal.Font = New System.Drawing.Font("Olimpos Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radia_btnBusiness.ItemAppearance.Normal.ForeColor = System.Drawing.Color.White
        Me.Radia_btnBusiness.ItemAppearance.Normal.Options.UseBackColor = True
        Me.Radia_btnBusiness.ItemAppearance.Normal.Options.UseFont = True
        Me.Radia_btnBusiness.ItemAppearance.Normal.Options.UseForeColor = True
        Me.Radia_btnBusiness.ItemInMenuAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Radia_btnBusiness.ItemInMenuAppearance.Normal.ForeColor = System.Drawing.Color.White
        Me.Radia_btnBusiness.ItemInMenuAppearance.Normal.Options.UseBackColor = True
        Me.Radia_btnBusiness.ItemInMenuAppearance.Normal.Options.UseForeColor = True
        Me.Radia_btnBusiness.Name = "Radia_btnBusiness"
        '
        'Radial_btnSubsidiaries
        '
        Me.Radial_btnSubsidiaries.Caption = "Sedes"
        Me.Radial_btnSubsidiaries.Id = 2
        Me.Radial_btnSubsidiaries.ItemAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Radial_btnSubsidiaries.ItemAppearance.Normal.Font = New System.Drawing.Font("Olimpos Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radial_btnSubsidiaries.ItemAppearance.Normal.ForeColor = System.Drawing.Color.White
        Me.Radial_btnSubsidiaries.ItemAppearance.Normal.Options.UseBackColor = True
        Me.Radial_btnSubsidiaries.ItemAppearance.Normal.Options.UseFont = True
        Me.Radial_btnSubsidiaries.ItemAppearance.Normal.Options.UseForeColor = True
        Me.Radial_btnSubsidiaries.ItemInMenuAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Radial_btnSubsidiaries.ItemInMenuAppearance.Normal.ForeColor = System.Drawing.Color.White
        Me.Radial_btnSubsidiaries.ItemInMenuAppearance.Normal.Options.UseBackColor = True
        Me.Radial_btnSubsidiaries.ItemInMenuAppearance.Normal.Options.UseForeColor = True
        Me.Radial_btnSubsidiaries.Name = "Radial_btnSubsidiaries"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.Radial_btnUsers, Me.Radia_btnBusiness, Me.Radial_btnSubsidiaries})
        Me.BarManager1.MaxItemId = 3
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(984, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 561)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(984, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 561)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(984, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 561)
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
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.LateralMenu.ResumeLayout(False)
        Me.SubMenuReport.ResumeLayout(False)
        Me.SubMenuConfig.ResumeLayout(False)
        Me.SubMenuAdmin.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.PanelBody.ResumeLayout(False)
        CType(Me.ImgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadialMenuDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Public WithEvents btnReport As Button
    Public WithEvents btnCash As Button
    Friend WithEvents PanelTop As Panel
    Friend WithEvents PanelBotton As Panel
    Friend WithEvents PanelBody As Panel
    Friend WithEvents ImgLogo As PictureBox
    Friend WithEvents txtUsername As Label
    Friend WithEvents lblLogo As Label
    Friend WithEvents RadialMenuDashboard As DevExpress.XtraBars.Ribbon.RadialMenu
    Friend WithEvents Radial_btnUsers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Radia_btnBusiness As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Radial_btnSubsidiaries As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
End Class
