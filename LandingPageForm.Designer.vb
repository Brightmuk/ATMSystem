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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LandingPageForm))
        Me.pnlHome = New System.Windows.Forms.Panel()
        Me.pcLogo = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNoAccount = New System.Windows.Forms.Label()
        Me.lblIdNumber = New System.Windows.Forms.Label()
        Me.lblPin = New System.Windows.Forms.Label()
        Me.txtPin = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.pnlHome.SuspendLayout()
        CType(Me.pcLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHome
        '
        Me.pnlHome.AutoSize = True
        Me.pnlHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.pnlHome.Controls.Add(Me.pcLogo)
        Me.pnlHome.Controls.Add(Me.btnLogin)
        Me.pnlHome.Controls.Add(Me.Label1)
        Me.pnlHome.Controls.Add(Me.lblNoAccount)
        Me.pnlHome.Controls.Add(Me.lblIdNumber)
        Me.pnlHome.Controls.Add(Me.lblPin)
        Me.pnlHome.Controls.Add(Me.txtPin)
        Me.pnlHome.Controls.Add(Me.txtId)
        Me.pnlHome.Controls.Add(Me.lblWelcome)
        Me.pnlHome.Location = New System.Drawing.Point(0, 0)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(812, 452)
        Me.pnlHome.TabIndex = 0
        '
        'pcLogo
        '
        Me.pcLogo.Image = CType(resources.GetObject("pcLogo.Image"), System.Drawing.Image)
        Me.pcLogo.Location = New System.Drawing.Point(88, 69)
        Me.pcLogo.Name = "pcLogo"
        Me.pcLogo.Size = New System.Drawing.Size(81, 73)
        Me.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcLogo.TabIndex = 8
        Me.pcLogo.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
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
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
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
        'lblIdNumber
        '
        Me.lblIdNumber.AutoSize = True
        Me.lblIdNumber.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblIdNumber.ForeColor = System.Drawing.Color.White
        Me.lblIdNumber.Location = New System.Drawing.Point(328, 194)
        Me.lblIdNumber.Name = "lblIdNumber"
        Me.lblIdNumber.Size = New System.Drawing.Size(77, 14)
        Me.lblIdNumber.TabIndex = 4
        Me.lblIdNumber.Text = "Id Number"
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
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtId.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtId.ForeColor = System.Drawing.Color.White
        Me.txtId.Location = New System.Drawing.Point(421, 187)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 29)
        Me.txtId.TabIndex = 1
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Verdana", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
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
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(811, 450)
        Me.Controls.Add(Me.pnlHome)
        Me.Name = "LandingPageForm"
        Me.Text = "Form1"
        Me.pnlHome.ResumeLayout(False)
        Me.pnlHome.PerformLayout()
        CType(Me.pcLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlHome As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNoAccount As Label
    Friend WithEvents lblIdNumber As Label
    Friend WithEvents lblPin As Label
    Friend WithEvents txtPin As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents pcLogo As PictureBox
End Class
