<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccountForm
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
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblHasAccount = New System.Windows.Forms.Label()
        Me.txtPin = New System.Windows.Forms.TextBox()
        Me.lblPin = New System.Windows.Forms.Label()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.txtDateOfBirth = New System.Windows.Forms.TextBox()
        Me.txtKraPin = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtIdNumber = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblDateOfBirth = New System.Windows.Forms.Label()
        Me.lblKraPin = New System.Windows.Forms.Label()
        Me.lblIdNumber = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlTheme.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTheme
        '
        Me.pnlTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.pnlTheme.Controls.Add(Me.lblLogin)
        Me.pnlTheme.Controls.Add(Me.lblHasAccount)
        Me.pnlTheme.Controls.Add(Me.txtPin)
        Me.pnlTheme.Controls.Add(Me.lblPin)
        Me.pnlTheme.Controls.Add(Me.btnSignUp)
        Me.pnlTheme.Controls.Add(Me.txtDateOfBirth)
        Me.pnlTheme.Controls.Add(Me.txtKraPin)
        Me.pnlTheme.Controls.Add(Me.txtLastName)
        Me.pnlTheme.Controls.Add(Me.txtIdNumber)
        Me.pnlTheme.Controls.Add(Me.txtFirstName)
        Me.pnlTheme.Controls.Add(Me.lblDateOfBirth)
        Me.pnlTheme.Controls.Add(Me.lblKraPin)
        Me.pnlTheme.Controls.Add(Me.lblIdNumber)
        Me.pnlTheme.Controls.Add(Me.lblLastName)
        Me.pnlTheme.Controls.Add(Me.lblFirstName)
        Me.pnlTheme.Controls.Add(Me.lblTitle)
        Me.pnlTheme.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.pnlTheme.ForeColor = System.Drawing.Color.White
        Me.pnlTheme.Location = New System.Drawing.Point(-2, -1)
        Me.pnlTheme.Name = "pnlTheme"
        Me.pnlTheme.Size = New System.Drawing.Size(801, 450)
        Me.pnlTheme.TabIndex = 0
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLogin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblLogin.Location = New System.Drawing.Point(430, 408)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(43, 14)
        Me.lblLogin.TabIndex = 19
        Me.lblLogin.Text = "Login"
        '
        'lblHasAccount
        '
        Me.lblHasAccount.AutoSize = True
        Me.lblHasAccount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHasAccount.ForeColor = System.Drawing.Color.White
        Me.lblHasAccount.Location = New System.Drawing.Point(307, 408)
        Me.lblHasAccount.Name = "lblHasAccount"
        Me.lblHasAccount.Size = New System.Drawing.Size(123, 14)
        Me.lblHasAccount.TabIndex = 18
        Me.lblHasAccount.Text = "Have an account?"
        '
        'txtPin
        '
        Me.txtPin.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtPin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPin.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPin.Location = New System.Drawing.Point(595, 239)
        Me.txtPin.Name = "txtPin"
        Me.txtPin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPin.Size = New System.Drawing.Size(100, 27)
        Me.txtPin.TabIndex = 17
        '
        'lblPin
        '
        Me.lblPin.AutoSize = True
        Me.lblPin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPin.ForeColor = System.Drawing.Color.White
        Me.lblPin.Location = New System.Drawing.Point(434, 244)
        Me.lblPin.Name = "lblPin"
        Me.lblPin.Size = New System.Drawing.Size(28, 14)
        Me.lblPin.TabIndex = 16
        Me.lblPin.Text = "Pin"
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignUp.Location = New System.Drawing.Point(368, 343)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(83, 30)
        Me.btnSignUp.TabIndex = 15
        Me.btnSignUp.Text = "Sign up"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'txtDateOfBirth
        '
        Me.txtDateOfBirth.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtDateOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDateOfBirth.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDateOfBirth.Location = New System.Drawing.Point(285, 239)
        Me.txtDateOfBirth.Name = "txtDateOfBirth"
        Me.txtDateOfBirth.Size = New System.Drawing.Size(100, 27)
        Me.txtDateOfBirth.TabIndex = 14
        '
        'txtKraPin
        '
        Me.txtKraPin.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtKraPin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKraPin.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtKraPin.Location = New System.Drawing.Point(595, 168)
        Me.txtKraPin.Name = "txtKraPin"
        Me.txtKraPin.Size = New System.Drawing.Size(100, 27)
        Me.txtKraPin.TabIndex = 13
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLastName.Location = New System.Drawing.Point(595, 94)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 27)
        Me.txtLastName.TabIndex = 12
        '
        'txtIdNumber
        '
        Me.txtIdNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtIdNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdNumber.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtIdNumber.Location = New System.Drawing.Point(285, 168)
        Me.txtIdNumber.Name = "txtIdNumber"
        Me.txtIdNumber.Size = New System.Drawing.Size(100, 27)
        Me.txtIdNumber.TabIndex = 11
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtFirstName.Location = New System.Drawing.Point(285, 94)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 27)
        Me.txtFirstName.TabIndex = 10
        '
        'lblDateOfBirth
        '
        Me.lblDateOfBirth.AutoSize = True
        Me.lblDateOfBirth.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDateOfBirth.ForeColor = System.Drawing.Color.White
        Me.lblDateOfBirth.Location = New System.Drawing.Point(110, 244)
        Me.lblDateOfBirth.Name = "lblDateOfBirth"
        Me.lblDateOfBirth.Size = New System.Drawing.Size(91, 14)
        Me.lblDateOfBirth.TabIndex = 9
        Me.lblDateOfBirth.Text = "Date of Birth"
        '
        'lblKraPin
        '
        Me.lblKraPin.AutoSize = True
        Me.lblKraPin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblKraPin.ForeColor = System.Drawing.Color.White
        Me.lblKraPin.Location = New System.Drawing.Point(434, 173)
        Me.lblKraPin.Name = "lblKraPin"
        Me.lblKraPin.Size = New System.Drawing.Size(59, 14)
        Me.lblKraPin.TabIndex = 8
        Me.lblKraPin.Text = "KRA Pin"
        '
        'lblIdNumber
        '
        Me.lblIdNumber.AutoSize = True
        Me.lblIdNumber.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblIdNumber.ForeColor = System.Drawing.Color.White
        Me.lblIdNumber.Location = New System.Drawing.Point(124, 173)
        Me.lblIdNumber.Name = "lblIdNumber"
        Me.lblIdNumber.Size = New System.Drawing.Size(79, 14)
        Me.lblIdNumber.TabIndex = 7
        Me.lblIdNumber.Text = "ID Number"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLastName.ForeColor = System.Drawing.Color.White
        Me.lblLastName.Location = New System.Drawing.Point(434, 99)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(77, 14)
        Me.lblLastName.TabIndex = 6
        Me.lblLastName.Text = "Last Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFirstName.ForeColor = System.Drawing.Color.White
        Me.lblFirstName.Location = New System.Drawing.Point(122, 99)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(79, 14)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "First Name"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(265, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(287, 38)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Create account"
        '
        'CreateAccountForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlTheme)
        Me.Name = "CreateAccountForm"
        Me.Text = "Form1"
        Me.pnlTheme.ResumeLayout(False)
        Me.pnlTheme.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTheme As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtPin As TextBox
    Friend WithEvents lblPin As Label
    Friend WithEvents btnSignUp As Button
    Friend WithEvents txtDateOfBirth As TextBox
    Friend WithEvents txtKraPin As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtIdNumber As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblDateOfBirth As Label
    Friend WithEvents lblKraPin As Label
    Friend WithEvents lblIdNumber As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblHasAccount As Label
End Class
