<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BalanceForm
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
        Me.pnlTheme = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.pnlTheme.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTheme
        '
        Me.pnlTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.pnlTheme.Controls.Add(Me.btnExit)
        Me.pnlTheme.Controls.Add(Me.lblTitle)
        Me.pnlTheme.Controls.Add(Me.lblResult)
        Me.pnlTheme.Location = New System.Drawing.Point(0, 0)
        Me.pnlTheme.Name = "pnlTheme"
        Me.pnlTheme.Size = New System.Drawing.Size(801, 453)
        Me.pnlTheme.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Pink
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(377, 320)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 30)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(271, 66)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(306, 38)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Balance Enquiry"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblResult.ForeColor = System.Drawing.Color.White
        Me.lblResult.Location = New System.Drawing.Point(307, 197)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(150, 14)
        Me.lblResult.TabIndex = 0
        Me.lblResult.Text = "Your balance is Ksh.0"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BalanceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlTheme)
        Me.Name = "BalanceForm"
        Me.Text = "Form1"
        Me.pnlTheme.ResumeLayout(False)
        Me.pnlTheme.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTheme As Panel
    Friend WithEvents lblResult As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnExit As Button
End Class
