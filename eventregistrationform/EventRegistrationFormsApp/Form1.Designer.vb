<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnRegister = New Button()
        chkPremium = New CheckBox()
        chkLaunch = New CheckBox()
        GroupBox2 = New GroupBox()
        radMomo = New RadioButton()
        radCredit = New RadioButton()
        Label4 = New Label()
        txtName = New TextBox()
        txtAge = New TextBox()
        btnExit = New Button()
        eventCategory = New ComboBox()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(323, 9)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(10)
        Label1.Size = New Size(221, 45)
        Label1.TabIndex = 0
        Label1.Text = "Event Registration Form"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(135, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 25)
        Label2.TabIndex = 1
        Label2.Text = "Full Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(135, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 25)
        Label3.TabIndex = 2
        Label3.Text = "Age:"
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(399, 374)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(221, 51)
        btnRegister.TabIndex = 3
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' chkPremium
        ' 
        chkPremium.AutoSize = True
        chkPremium.Location = New Point(154, 242)
        chkPremium.Name = "chkPremium"
        chkPremium.Size = New Size(178, 29)
        chkPremium.TabIndex = 0
        chkPremium.Text = "Premium Package"
        chkPremium.UseVisualStyleBackColor = True
        ' 
        ' chkLaunch
        ' 
        chkLaunch.AutoSize = True
        chkLaunch.Location = New Point(358, 242)
        chkLaunch.Name = "chkLaunch"
        chkLaunch.Size = New Size(166, 29)
        chkLaunch.TabIndex = 1
        chkLaunch.Text = "Launch Included"
        chkLaunch.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(radMomo)
        GroupBox2.Controls.Add(radCredit)
        GroupBox2.Location = New Point(135, 288)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(550, 67)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "Payment Method"
        ' 
        ' radMomo
        ' 
        radMomo.AutoSize = True
        radMomo.Location = New Point(223, 26)
        radMomo.Name = "radMomo"
        radMomo.Size = New Size(152, 29)
        radMomo.TabIndex = 1
        radMomo.TabStop = True
        radMomo.Text = "Mobile Money"
        radMomo.UseVisualStyleBackColor = True
        ' 
        ' radCredit
        ' 
        radCredit.AutoSize = True
        radCredit.Location = New Point(19, 30)
        radCredit.Name = "radCredit"
        radCredit.Size = New Size(126, 29)
        radCredit.TabIndex = 0
        radCredit.TabStop = True
        radCredit.Text = "Credit Card"
        radCredit.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(135, 181)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 25)
        Label4.TabIndex = 7
        Label4.Text = "Category:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(270, 79)
        txtName.Name = "txtName"
        txtName.Size = New Size(350, 31)
        txtName.TabIndex = 8
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(270, 132)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(350, 31)
        txtAge.TabIndex = 9
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(135, 374)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(221, 51)
        btnExit.TabIndex = 10
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' eventCategory
        ' 
        eventCategory.FormattingEnabled = True
        eventCategory.Items.AddRange(New Object() {"Workshop", "Seminar", "Conference"})
        eventCategory.Location = New Point(270, 181)
        eventCategory.Name = "eventCategory"
        eventCategory.Size = New Size(182, 33)
        eventCategory.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(eventCategory)
        Controls.Add(btnExit)
        Controls.Add(chkPremium)
        Controls.Add(chkLaunch)
        Controls.Add(txtAge)
        Controls.Add(txtName)
        Controls.Add(Label4)
        Controls.Add(GroupBox2)
        Controls.Add(btnRegister)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents chkLaunch As CheckBox
    Friend WithEvents chkPremium As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radMomo As RadioButton
    Friend WithEvents radCredit As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents eventCategory As ComboBox

End Class
