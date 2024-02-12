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
        Me.LateralMenu = New System.Windows.Forms.Panel()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SubMenu = New System.Windows.Forms.Panel()
        Me.btnSubMenu1 = New System.Windows.Forms.Button()
        Me.btnSubMenu2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.LateralMenu.SuspendLayout()
        Me.SubMenu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LateralMenu
        '
        Me.LateralMenu.AutoScroll = True
        Me.LateralMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.LateralMenu.Controls.Add(Me.Panel2)
        Me.LateralMenu.Controls.Add(Me.Button1)
        Me.LateralMenu.Controls.Add(Me.SubMenu)
        Me.LateralMenu.Controls.Add(Me.btnMenu)
        Me.LateralMenu.Controls.Add(Me.Panel1)
        Me.LateralMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.LateralMenu.Location = New System.Drawing.Point(0, 0)
        Me.LateralMenu.Name = "LateralMenu"
        Me.LateralMenu.Size = New System.Drawing.Size(200, 561)
        Me.LateralMenu.TabIndex = 0
        '
        'btnMenu
        '
        Me.btnMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.ForeColor = System.Drawing.Color.White
        Me.btnMenu.Location = New System.Drawing.Point(0, 90)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnMenu.Size = New System.Drawing.Size(200, 45)
        Me.btnMenu.TabIndex = 1
        Me.btnMenu.Text = "Usuarios"
        Me.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 90)
        Me.Panel1.TabIndex = 0
        '
        'SubMenu
        '
        Me.SubMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.SubMenu.Controls.Add(Me.btnSubMenu2)
        Me.SubMenu.Controls.Add(Me.btnSubMenu1)
        Me.SubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenu.Location = New System.Drawing.Point(0, 135)
        Me.SubMenu.Name = "SubMenu"
        Me.SubMenu.Size = New System.Drawing.Size(200, 87)
        Me.SubMenu.TabIndex = 2
        '
        'btnSubMenu1
        '
        Me.btnSubMenu1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSubMenu1.FlatAppearance.BorderSize = 0
        Me.btnSubMenu1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnSubMenu1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnSubMenu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubMenu1.ForeColor = System.Drawing.Color.White
        Me.btnSubMenu1.Location = New System.Drawing.Point(0, 0)
        Me.btnSubMenu1.Name = "btnSubMenu1"
        Me.btnSubMenu1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnSubMenu1.Size = New System.Drawing.Size(200, 40)
        Me.btnSubMenu1.TabIndex = 0
        Me.btnSubMenu1.Text = "Button1"
        Me.btnSubMenu1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubMenu1.UseVisualStyleBackColor = True
        '
        'btnSubMenu2
        '
        Me.btnSubMenu2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSubMenu2.FlatAppearance.BorderSize = 0
        Me.btnSubMenu2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnSubMenu2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnSubMenu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubMenu2.ForeColor = System.Drawing.Color.White
        Me.btnSubMenu2.Location = New System.Drawing.Point(0, 40)
        Me.btnSubMenu2.Name = "btnSubMenu2"
        Me.btnSubMenu2.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnSubMenu2.Size = New System.Drawing.Size(200, 40)
        Me.btnSubMenu2.TabIndex = 1
        Me.btnSubMenu2.Text = "Button2"
        Me.btnSubMenu2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubMenu2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(200, 45)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Usuarios"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 267)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 87)
        Me.Panel2.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(0, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(200, 40)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(0, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(200, 40)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Button1"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.LateralMenu)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.LateralMenu.ResumeLayout(False)
        Me.SubMenu.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LateralMenu As Panel
    Public WithEvents btnMenu As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Public WithEvents Button1 As Button
    Friend WithEvents SubMenu As Panel
    Friend WithEvents btnSubMenu2 As Button
    Friend WithEvents btnSubMenu1 As Button
End Class
