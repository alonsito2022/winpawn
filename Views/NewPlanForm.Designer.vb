<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewPlanForm
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
        Me.PanelNewPlanForm = New System.Windows.Forms.Panel()
        Me.txtNamePlan = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.nudWidth = New System.Windows.Forms.NumericUpDown()
        Me.nudHeight = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbSubsidiary = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.PanelNewPlanForm.SuspendLayout()
        CType(Me.nudWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelNewPlanForm
        '
        Me.PanelNewPlanForm.Controls.Add(Me.btnCancel)
        Me.PanelNewPlanForm.Controls.Add(Me.btnSave)
        Me.PanelNewPlanForm.Controls.Add(Me.Label3)
        Me.PanelNewPlanForm.Controls.Add(Me.cmbSubsidiary)
        Me.PanelNewPlanForm.Controls.Add(Me.Label2)
        Me.PanelNewPlanForm.Controls.Add(Me.Label1)
        Me.PanelNewPlanForm.Controls.Add(Me.nudHeight)
        Me.PanelNewPlanForm.Controls.Add(Me.nudWidth)
        Me.PanelNewPlanForm.Controls.Add(Me.lblName)
        Me.PanelNewPlanForm.Controls.Add(Me.txtNamePlan)
        Me.PanelNewPlanForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelNewPlanForm.Location = New System.Drawing.Point(0, 0)
        Me.PanelNewPlanForm.Name = "PanelNewPlanForm"
        Me.PanelNewPlanForm.Size = New System.Drawing.Size(251, 267)
        Me.PanelNewPlanForm.TabIndex = 0
        '
        'txtNamePlan
        '
        Me.txtNamePlan.Location = New System.Drawing.Point(41, 37)
        Me.txtNamePlan.Name = "txtNamePlan"
        Me.txtNamePlan.Size = New System.Drawing.Size(154, 20)
        Me.txtNamePlan.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(38, 21)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(74, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Nombre Plano"
        '
        'nudWidth
        '
        Me.nudWidth.DecimalPlaces = 2
        Me.nudWidth.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudWidth.Location = New System.Drawing.Point(41, 80)
        Me.nudWidth.Name = "nudWidth"
        Me.nudWidth.Size = New System.Drawing.Size(154, 20)
        Me.nudWidth.TabIndex = 2
        '
        'nudHeight
        '
        Me.nudHeight.DecimalPlaces = 2
        Me.nudHeight.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudHeight.Location = New System.Drawing.Point(41, 122)
        Me.nudHeight.Name = "nudHeight"
        Me.nudHeight.Size = New System.Drawing.Size(154, 20)
        Me.nudHeight.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ancho(%)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Largo(%)"
        '
        'cmbSubsidiary
        '
        Me.cmbSubsidiary.FormattingEnabled = True
        Me.cmbSubsidiary.Location = New System.Drawing.Point(41, 164)
        Me.cmbSubsidiary.Name = "cmbSubsidiary"
        Me.cmbSubsidiary.Size = New System.Drawing.Size(154, 21)
        Me.cmbSubsidiary.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Sucursal"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(41, 202)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(122, 202)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'NewPlanForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 267)
        Me.Controls.Add(Me.PanelNewPlanForm)
        Me.Name = "NewPlanForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Creacion de plano"
        Me.PanelNewPlanForm.ResumeLayout(False)
        Me.PanelNewPlanForm.PerformLayout()
        CType(Me.nudWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelNewPlanForm As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbSubsidiary As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nudHeight As NumericUpDown
    Friend WithEvents nudWidth As NumericUpDown
    Friend WithEvents lblName As Label
    Friend WithEvents txtNamePlan As TextBox
End Class
