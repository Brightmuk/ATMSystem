<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
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
        Me.pnlHome = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.btnChangePin = New System.Windows.Forms.Button()
        Me.btnFastCash = New System.Windows.Forms.Button()
        Me.btnMiniStatement = New System.Windows.Forms.Button()
        Me.btnWithdrawCash = New System.Windows.Forms.Button()
        Me.btnBalanceEnquiry = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlHome.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHome
        '
        Me.pnlHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.pnlHome.Controls.Add(Me.lblTitle)
        Me.pnlHome.Controls.Add(Me.btnDeposit)
        Me.pnlHome.Controls.Add(Me.btnChangePin)
        Me.pnlHome.Controls.Add(Me.btnFastCash)
        Me.pnlHome.Controls.Add(Me.btnMiniStatement)
        Me.pnlHome.Controls.Add(Me.btnWithdrawCash)
        Me.pnlHome.Controls.Add(Me.btnBalanceEnquiry)
        Me.pnlHome.Controls.Add(Me.btnLogout)
        Me.pnlHome.Controls.Add(Me.Label6)
        Me.pnlHome.Location = New System.Drawing.Point(0, 0)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(801, 453)
        Me.pnlHome.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 24.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(329, 26)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(178, 40)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Text = "Transact"
        '
        'btnDeposit
        '
        Me.btnDeposit.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDeposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeposit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeposit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDeposit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnDeposit.Location = New System.Drawing.Point(453, 111)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(184, 46)
        Me.btnDeposit.TabIndex = 13
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = False
        '
        'btnChangePin
        '
        Me.btnChangePin.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnChangePin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnChangePin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangePin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnChangePin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnChangePin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnChangePin.Location = New System.Drawing.Point(453, 269)
        Me.btnChangePin.Name = "btnChangePin"
        Me.btnChangePin.Size = New System.Drawing.Size(184, 46)
        Me.btnChangePin.TabIndex = 12
        Me.btnChangePin.Text = "Change Pin"
        Me.btnChangePin.UseVisualStyleBackColor = False
        '
        'btnFastCash
        '
        Me.btnFastCash.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnFastCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFastCash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFastCash.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnFastCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFastCash.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFastCash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnFastCash.Location = New System.Drawing.Point(453, 188)
        Me.btnFastCash.Name = "btnFastCash"
        Me.btnFastCash.Size = New System.Drawing.Size(184, 46)
        Me.btnFastCash.TabIndex = 11
        Me.btnFastCash.Text = "Fast Cash"
        Me.btnFastCash.UseVisualStyleBackColor = False
        '
        'btnMiniStatement
        '
        Me.btnMiniStatement.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnMiniStatement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMiniStatement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMiniStatement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnMiniStatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMiniStatement.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMiniStatement.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnMiniStatement.Location = New System.Drawing.Point(156, 269)
        Me.btnMiniStatement.Name = "btnMiniStatement"
        Me.btnMiniStatement.Size = New System.Drawing.Size(184, 46)
        Me.btnMiniStatement.TabIndex = 10
        Me.btnMiniStatement.Text = "Mini Statement"
        Me.btnMiniStatement.UseVisualStyleBackColor = False
        '
        'btnWithdrawCash
        '
        Me.btnWithdrawCash.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnWithdrawCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnWithdrawCash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWithdrawCash.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnWithdrawCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWithdrawCash.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnWithdrawCash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnWithdrawCash.Location = New System.Drawing.Point(156, 188)
        Me.btnWithdrawCash.Name = "btnWithdrawCash"
        Me.btnWithdrawCash.Size = New System.Drawing.Size(184, 46)
        Me.btnWithdrawCash.TabIndex = 9
        Me.btnWithdrawCash.Text = "Withdraw Cash"
        Me.btnWithdrawCash.UseVisualStyleBackColor = False
        '
        'btnBalanceEnquiry
        '
        Me.btnBalanceEnquiry.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnBalanceEnquiry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBalanceEnquiry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBalanceEnquiry.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnBalanceEnquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBalanceEnquiry.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBalanceEnquiry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnBalanceEnquiry.Location = New System.Drawing.Point(156, 111)
        Me.btnBalanceEnquiry.Name = "btnBalanceEnquiry"
        Me.btnBalanceEnquiry.Size = New System.Drawing.Size(184, 46)
        Me.btnBalanceEnquiry.TabIndex = 8
        Me.btnBalanceEnquiry.Text = "Balance Enquiry"
        Me.btnBalanceEnquiry.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Pink
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(699, 394)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(89, 30)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(547, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 15)
        Me.Label6.TabIndex = 5
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlHome)
        Me.Name = "HomeForm"
        Me.Text = "Form1"
        Me.pnlHome.ResumeLayout(False)
        Me.pnlHome.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHome As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnChangePin As Button
    Friend WithEvents btnFastCash As Button
    Friend WithEvents btnMiniStatement As Button
    Friend WithEvents btnWithdrawCash As Button
    Friend WithEvents btnBalanceEnquiry As Button
    Friend WithEvents lblTitle As Label
End Class
