<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.cmbBeverage = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.chkDiscount = New System.Windows.Forms.CheckBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblFinalTotal = New System.Windows.Forms.Label()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(268, 196)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(49, 13)
        Me.lblDiscount.TabIndex = 1
        Me.lblDiscount.Text = "Discount"
        '
        'cmbBeverage
        '
        Me.cmbBeverage.FormattingEnabled = True
        Me.cmbBeverage.Location = New System.Drawing.Point(318, 145)
        Me.cmbBeverage.Name = "cmbBeverage"
        Me.cmbBeverage.Size = New System.Drawing.Size(103, 21)
        Me.cmbBeverage.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(309, 95)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(133, 20)
        Me.txtName.TabIndex = 3
        Me.txtName.Text = "po"
        '
        'chkDiscount
        '
        Me.chkDiscount.AutoSize = True
        Me.chkDiscount.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.chkDiscount.Location = New System.Drawing.Point(271, 254)
        Me.chkDiscount.Name = "chkDiscount"
        Me.chkDiscount.Size = New System.Drawing.Size(68, 17)
        Me.chkDiscount.TabIndex = 4
        Me.chkDiscount.Text = "Discount"
        Me.chkDiscount.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(327, 296)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(351, 196)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(46, 13)
        Me.lblSubtotal.TabIndex = 6
        Me.lblSubtotal.Text = "Subtotal"
        '
        'lblFinalTotal
        '
        Me.lblFinalTotal.AutoSize = True
        Me.lblFinalTotal.Location = New System.Drawing.Point(439, 196)
        Me.lblFinalTotal.Name = "lblFinalTotal"
        Me.lblFinalTotal.Size = New System.Drawing.Size(53, 13)
        Me.lblFinalTotal.TabIndex = 7
        Me.lblFinalTotal.Text = "FinalTotal"
        '
        'nudQuantity
        '
        Me.nudQuantity.Location = New System.Drawing.Point(318, 228)
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(120, 20)
        Me.nudQuantity.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.nudQuantity)
        Me.Controls.Add(Me.lblFinalTotal)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.chkDiscount)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.cmbBeverage)
        Me.Controls.Add(Me.lblDiscount)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDiscount As Label
    Friend WithEvents cmbBeverage As ComboBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents chkDiscount As CheckBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblFinalTotal As Label
    Friend WithEvents nudQuantity As NumericUpDown
End Class
