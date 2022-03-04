<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LandingPageForm
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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNoAccount = New System.Windows.Forms.Label()
        Me.lblAccountNo = New System.Windows.Forms.Label()
        Me.lblPin = New System.Windows.Forms.Label()
        Me.txtPin = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.pnlHome.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHome
        '
        Me.pnlHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.pnlHome.Controls.Add(Me.btnLogin)
        Me.pnlHome.Controls.Add(Me.Label1)
        Me.pnlHome.Controls.Add(Me.lblNoAccount)
        Me.pnlHome.Controls.Add(Me.lblAccountNo)
        Me.pnlHome.Controls.Add(Me.lblPin)
        Me.pnlHome.Controls.Add(Me.txtPin)
        Me.pnlHome.Controls.Add(Me.txtUsername)
        Me.pnlHome.Controls.Add(Me.lblWelcome)
        Me.pnlHome.Location = New System.Drawing.Point(0, 0)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(812, 452)
        Me.pnlHome.TabIndex = 0
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(386, 323)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(85, 31)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(457, 403)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Create one."
        '
        'lblNoAccount
        '
        Me.lblNoAccount.AutoSize = True
        Me.lblNoAccount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNoAccount.ForeColor = System.Drawing.Color.White
        Me.lblNoAccount.Location = New System.Drawing.Point(306, 403)
        Me.lblNoAccount.Name = "lblNoAccount"
        Me.lblNoAccount.Size = New System.Drawing.Size(156, 14)
        Me.lblNoAccount.TabIndex = 5
        Me.lblNoAccount.Text = "Dont have an account?"
        '
        'lblAccountNo
        '
        Me.lblAccountNo.AutoSize = True
        Me.lblAccountNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAccountNo.ForeColor = System.Drawing.Color.White
        Me.lblAccountNo.Location = New System.Drawing.Point(290, 194)
        Me.lblAccountNo.Name = "lblAccountNo"
        Me.lblAccountNo.Size = New System.Drawing.Size(115, 14)
        Me.lblAccountNo.TabIndex = 4
        Me.lblAccountNo.Text = "Account Number"
        '
        'lblPin
        '
        Me.lblPin.AutoSize = True
        Me.lblPin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPin.ForeColor = System.Drawing.Color.White
        Me.lblPin.Location = New System.Drawing.Point(377, 235)
        Me.lblPin.Name = "lblPin"
        Me.lblPin.Size = New System.Drawing.Size(28, 14)
        Me.lblPin.TabIndex = 3
        Me.lblPin.Text = "Pin"
        '
        'txtPin
        '
        Me.txtPin.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtPin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPin.ForeColor = System.Drawing.Color.White
        Me.txtPin.Location = New System.Drawing.Point(421, 233)
        Me.txtPin.Name = "txtPin"
        Me.txtPin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPin.Size = New System.Drawing.Size(100, 29)
        Me.txtPin.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtUsername.ForeColor = System.Drawing.Color.White
        Me.txtUsername.Location = New System.Drawing.Point(421, 187)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 29)
        Me.txtUsername.TabIndex = 1
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Verdana", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblWelcome.Location = New System.Drawing.Point(188, 80)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(493, 45)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome to Mulla ATM"
        '
        'LandingPageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 450)
        Me.Controls.Add(Me.pnlHome)
        Me.Name = "LandingPageForm"
        Me.Text = "Form1"
        Me.pnlHome.ResumeLayout(False)
        Me.pnlHome.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHome As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNoAccount As Label
    Friend WithEvents lblAccountNo As Label
    Friend WithEvents lblPin As Label
    Friend WithEvents txtPin As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnLogin As Button
End Class
