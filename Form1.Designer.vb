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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblRepeatPin = New System.Windows.Forms.Label()
        Me.txtRepeatPin = New System.Windows.Forms.TextBox()
        Me.lblNewPin = New System.Windows.Forms.Label()
        Me.txtNewPin = New System.Windows.Forms.TextBox()
        Me.lblCurrentPin = New System.Windows.Forms.Label()
        Me.txtCurrentPin = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnChangePin = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnChangePin)
        Me.Panel1.Controls.Add(Me.lblCurrentPin)
        Me.Panel1.Controls.Add(Me.txtCurrentPin)
        Me.Panel1.Controls.Add(Me.lblNewPin)
        Me.Panel1.Controls.Add(Me.txtNewPin)
        Me.Panel1.Controls.Add(Me.lblRepeatPin)
        Me.Panel1.Controls.Add(Me.txtRepeatPin)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 24.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(318, 58)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(226, 40)
        Me.lblTitle.TabIndex = 16
        Me.lblTitle.Text = "Change Pin"
        '
        'lblRepeatPin
        '
        Me.lblRepeatPin.AutoSize = True
        Me.lblRepeatPin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRepeatPin.ForeColor = System.Drawing.Color.White
        Me.lblRepeatPin.Location = New System.Drawing.Point(318, 266)
        Me.lblRepeatPin.Name = "lblRepeatPin"
        Me.lblRepeatPin.Size = New System.Drawing.Size(78, 14)
        Me.lblRepeatPin.TabIndex = 18
        Me.lblRepeatPin.Text = "Repeat Pin"
        '
        'txtRepeatPin
        '
        Me.txtRepeatPin.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtRepeatPin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRepeatPin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtRepeatPin.ForeColor = System.Drawing.Color.White
        Me.txtRepeatPin.Location = New System.Drawing.Point(408, 266)
        Me.txtRepeatPin.Name = "txtRepeatPin"
        Me.txtRepeatPin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRepeatPin.Size = New System.Drawing.Size(100, 29)
        Me.txtRepeatPin.TabIndex = 17
        '
        'lblNewPin
        '
        Me.lblNewPin.AutoSize = True
        Me.lblNewPin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNewPin.ForeColor = System.Drawing.Color.White
        Me.lblNewPin.Location = New System.Drawing.Point(318, 226)
        Me.lblNewPin.Name = "lblNewPin"
        Me.lblNewPin.Size = New System.Drawing.Size(62, 14)
        Me.lblNewPin.TabIndex = 20
        Me.lblNewPin.Text = "New Pin"
        '
        'txtNewPin
        '
        Me.txtNewPin.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtNewPin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewPin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNewPin.ForeColor = System.Drawing.Color.White
        Me.txtNewPin.Location = New System.Drawing.Point(408, 219)
        Me.txtNewPin.Name = "txtNewPin"
        Me.txtNewPin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPin.Size = New System.Drawing.Size(100, 29)
        Me.txtNewPin.TabIndex = 19
        '
        'lblCurrentPin
        '
        Me.lblCurrentPin.AutoSize = True
        Me.lblCurrentPin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCurrentPin.ForeColor = System.Drawing.Color.White
        Me.lblCurrentPin.Location = New System.Drawing.Point(318, 154)
        Me.lblCurrentPin.Name = "lblCurrentPin"
        Me.lblCurrentPin.Size = New System.Drawing.Size(82, 14)
        Me.lblCurrentPin.TabIndex = 22
        Me.lblCurrentPin.Text = "Current Pin"
        '
        'txtCurrentPin
        '
        Me.txtCurrentPin.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtCurrentPin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrentPin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCurrentPin.ForeColor = System.Drawing.Color.White
        Me.txtCurrentPin.Location = New System.Drawing.Point(408, 147)
        Me.txtCurrentPin.Name = "txtCurrentPin"
        Me.txtCurrentPin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCurrentPin.Size = New System.Drawing.Size(100, 29)
        Me.txtCurrentPin.TabIndex = 21
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Pink
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(291, 352)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 30)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnChangePin
        '
        Me.btnChangePin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnChangePin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnChangePin.ForeColor = System.Drawing.SystemColors.Control
        Me.btnChangePin.Location = New System.Drawing.Point(441, 352)
        Me.btnChangePin.Name = "btnChangePin"
        Me.btnChangePin.Size = New System.Drawing.Size(83, 30)
        Me.btnChangePin.TabIndex = 22
        Me.btnChangePin.Text = "Change"
        Me.btnChangePin.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCurrentPin As Label
    Friend WithEvents txtCurrentPin As TextBox
    Friend WithEvents lblNewPin As Label
    Friend WithEvents txtNewPin As TextBox
    Friend WithEvents lblRepeatPin As Label
    Friend WithEvents txtRepeatPin As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnChangePin As Button
End Class
