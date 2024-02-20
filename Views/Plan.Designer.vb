<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Plan
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
        Me.PanelRight = New System.Windows.Forms.Panel()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.btnPlan = New System.Windows.Forms.Button()
        Me.btnBoard = New System.Windows.Forms.Button()
        Me.PanelRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelRight
        '
        Me.PanelRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.PanelRight.Controls.Add(Me.btnBoard)
        Me.PanelRight.Controls.Add(Me.btnPlan)
        Me.PanelRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelRight.Location = New System.Drawing.Point(757, 0)
        Me.PanelRight.Name = "PanelRight"
        Me.PanelRight.Size = New System.Drawing.Size(192, 579)
        Me.PanelRight.TabIndex = 0
        '
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(757, 579)
        Me.PanelLeft.TabIndex = 1
        '
        'btnPlan
        '
        Me.btnPlan.Location = New System.Drawing.Point(32, 22)
        Me.btnPlan.Name = "btnPlan"
        Me.btnPlan.Size = New System.Drawing.Size(126, 23)
        Me.btnPlan.TabIndex = 0
        Me.btnPlan.Text = "Nuevo plano"
        Me.btnPlan.UseVisualStyleBackColor = True
        '
        'btnBoard
        '
        Me.btnBoard.Location = New System.Drawing.Point(32, 67)
        Me.btnBoard.Name = "btnBoard"
        Me.btnBoard.Size = New System.Drawing.Size(126, 23)
        Me.btnBoard.TabIndex = 1
        Me.btnBoard.Text = "Nueva mesa"
        Me.btnBoard.UseVisualStyleBackColor = True
        '
        'Plan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 579)
        Me.Controls.Add(Me.PanelLeft)
        Me.Controls.Add(Me.PanelRight)
        Me.Name = "Plan"
        Me.Text = "Plan"
        Me.PanelRight.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelRight As Panel
    Friend WithEvents btnBoard As Button
    Friend WithEvents btnPlan As Button
    Public WithEvents PanelLeft As Panel
End Class
