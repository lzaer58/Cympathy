﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserRegistration
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
        Me.components = New System.ComponentModel.Container()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMi = New System.Windows.Forms.TextBox()
        Me.txtCitizenship = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.rdTeacher = New System.Windows.Forms.RadioButton()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.rdStudent = New System.Windows.Forms.RadioButton()
        Me.grpPersonal = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tableAccountType = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.cellNumber = New System.Windows.Forms.TextBox()
        Me.txtLandlineNumber = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.questionIndex = New System.Windows.Forms.ComboBox()
        Me.txtSecretAnswer = New System.Windows.Forms.TextBox()
        Me.grpCredentials = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPersonal.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.tableAccountType.SuspendLayout()
        Me.grpCredentials.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.HelpProvider1.SetHelpString(Me.DateTimePicker1, "Ahaaa....Input your birthday (so that i might send a birthday greeting just in ca" & _
        "se my developers patch a new update for me!)")
        Me.DateTimePicker1.Location = New System.Drawing.Point(221, 271)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(1)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.HelpProvider1.SetShowHelp(Me.DateTimePicker1, True)
        Me.DateTimePicker1.Size = New System.Drawing.Size(174, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 270)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Birth Date"
        '
        'txtMi
        '
        Me.HelpProvider1.SetHelpString(Me.txtMi, "Next is your middle initial (this technically is your middle name)")
        Me.txtMi.Location = New System.Drawing.Point(221, 31)
        Me.txtMi.Margin = New System.Windows.Forms.Padding(1)
        Me.txtMi.MaxLength = 1
        Me.txtMi.Name = "txtMi"
        Me.HelpProvider1.SetShowHelp(Me.txtMi, True)
        Me.txtMi.Size = New System.Drawing.Size(72, 20)
        Me.txtMi.TabIndex = 1
        '
        'txtCitizenship
        '
        Me.HelpProvider1.SetHelpString(Me.txtCitizenship, "OF WHERE DO THOU HAIL! no srsly input your nationality?")
        Me.txtCitizenship.Location = New System.Drawing.Point(221, 241)
        Me.txtCitizenship.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCitizenship.MaxLength = 20
        Me.txtCitizenship.Name = "txtCitizenship"
        Me.HelpProvider1.SetShowHelp(Me.txtCitizenship, True)
        Me.txtCitizenship.Size = New System.Drawing.Size(174, 20)
        Me.txtCitizenship.TabIndex = 8
        '
        'txtAddress
        '
        Me.HelpProvider1.SetHelpString(Me.txtAddress, "The system might also need to know your address... you know.. just in case you sk" & _
        "ip classes.")
        Me.txtAddress.Location = New System.Drawing.Point(221, 211)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(1)
        Me.txtAddress.MaxLength = 225
        Me.txtAddress.Name = "txtAddress"
        Me.HelpProvider1.SetShowHelp(Me.txtAddress, True)
        Me.txtAddress.Size = New System.Drawing.Size(174, 20)
        Me.txtAddress.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1, 240)
        Me.Label14.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Citizenship"
        '
        'rdTeacher
        '
        Me.rdTeacher.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.rdTeacher, "Select me if you want this account to be a teacher")
        Me.rdTeacher.Location = New System.Drawing.Point(101, 1)
        Me.rdTeacher.Margin = New System.Windows.Forms.Padding(1)
        Me.rdTeacher.Name = "rdTeacher"
        Me.HelpProvider1.SetShowHelp(Me.rdTeacher, True)
        Me.rdTeacher.Size = New System.Drawing.Size(65, 17)
        Me.rdTeacher.TabIndex = 12
        Me.rdTeacher.TabStop = True
        Me.rdTeacher.Text = "Teacher"
        Me.rdTeacher.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.HelpProvider1.SetHelpString(Me.txtEmail, "Input your EMAIL Here (you could actually just trash this. this is just for Ident" & _
        "ification)")
        Me.txtEmail.Location = New System.Drawing.Point(221, 181)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(1)
        Me.txtEmail.MaxLength = 40
        Me.txtEmail.Name = "txtEmail"
        Me.HelpProvider1.SetShowHelp(Me.txtEmail, True)
        Me.txtEmail.Size = New System.Drawing.Size(174, 20)
        Me.txtEmail.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1, 210)
        Me.Label13.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Address"
        '
        'rdStudent
        '
        Me.rdStudent.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.rdStudent, "Select me to set this account as a student")
        Me.rdStudent.Location = New System.Drawing.Point(1, 1)
        Me.rdStudent.Margin = New System.Windows.Forms.Padding(1)
        Me.rdStudent.Name = "rdStudent"
        Me.HelpProvider1.SetShowHelp(Me.rdStudent, True)
        Me.rdStudent.Size = New System.Drawing.Size(62, 17)
        Me.rdStudent.TabIndex = 11
        Me.rdStudent.TabStop = True
        Me.rdStudent.Text = "Student"
        Me.rdStudent.UseVisualStyleBackColor = True
        '
        'grpPersonal
        '
        Me.grpPersonal.Controls.Add(Me.TableLayoutPanel2)
        Me.HelpProvider1.SetHelpString(Me.grpPersonal, "Let's get to know you a tad bit more, shall we?")
        Me.grpPersonal.Location = New System.Drawing.Point(1, 210)
        Me.grpPersonal.Margin = New System.Windows.Forms.Padding(1)
        Me.grpPersonal.Name = "grpPersonal"
        Me.grpPersonal.Padding = New System.Windows.Forms.Padding(1)
        Me.HelpProvider1.SetShowHelp(Me.grpPersonal, True)
        Me.grpPersonal.Size = New System.Drawing.Size(443, 375)
        Me.grpPersonal.TabIndex = 5
        Me.grpPersonal.TabStop = False
        Me.grpPersonal.Text = "Personal Info"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.txtAge, 1, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.DateTimePicker1, 1, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.Label14, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.txtMi, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtSurname, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbGender, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.cellNumber, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.txtLandlineNumber, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.txtEmail, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.txtAddress, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.txtCitizenship, 1, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.txtFirstname, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label15, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(1, 14)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 12
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(441, 360)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'tableAccountType
        '
        Me.tableAccountType.ColumnCount = 2
        Me.tableAccountType.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableAccountType.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableAccountType.Controls.Add(Me.rdTeacher, 1, 0)
        Me.tableAccountType.Controls.Add(Me.rdStudent, 0, 0)
        Me.HelpProvider1.SetHelpString(Me.tableAccountType, "This will set the account type!")
        Me.tableAccountType.Location = New System.Drawing.Point(224, 155)
        Me.tableAccountType.Name = "tableAccountType"
        Me.tableAccountType.RowCount = 1
        Me.tableAccountType.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.HelpProvider1.SetShowHelp(Me.tableAccountType, True)
        Me.tableAccountType.Size = New System.Drawing.Size(200, 22)
        Me.tableAccountType.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1, 300)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Age"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtAge
        '
        Me.HelpProvider1.SetHelpString(Me.txtAge, "nudge nudge wink wink")
        Me.txtAge.Location = New System.Drawing.Point(221, 301)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(1)
        Me.txtAge.MaxLength = 2
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.HelpProvider1.SetShowHelp(Me.txtAge, True)
        Me.txtAge.Size = New System.Drawing.Size(30, 20)
        Me.txtAge.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "First Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 90)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Gender"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1, 120)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Cellular Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1, 150)
        Me.Label8.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Landline"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1, 180)
        Me.Label12.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "E-Mail"
        '
        'txtSurname
        '
        Me.HelpProvider1.SetHelpString(Me.txtSurname, "And finally, input your surname! Sir/Ma'am!")
        Me.txtSurname.Location = New System.Drawing.Point(221, 61)
        Me.txtSurname.Margin = New System.Windows.Forms.Padding(1)
        Me.txtSurname.MaxLength = 10
        Me.txtSurname.Name = "txtSurname"
        Me.HelpProvider1.SetShowHelp(Me.txtSurname, True)
        Me.txtSurname.Size = New System.Drawing.Size(175, 20)
        Me.txtSurname.TabIndex = 2
        '
        'cmbGender
        '
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cmbGender, "Sorry only two of em.")
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(221, 91)
        Me.cmbGender.Margin = New System.Windows.Forms.Padding(1)
        Me.cmbGender.Name = "cmbGender"
        Me.HelpProvider1.SetShowHelp(Me.cmbGender, True)
        Me.cmbGender.Size = New System.Drawing.Size(72, 21)
        Me.cmbGender.TabIndex = 3
        '
        'cellNumber
        '
        Me.HelpProvider1.SetHelpString(Me.cellNumber, "Input your Cellular Number. (and maybe we could be bell buddies? oh wait those we" & _
        "re pagers.. my bad.)")
        Me.cellNumber.Location = New System.Drawing.Point(221, 121)
        Me.cellNumber.Margin = New System.Windows.Forms.Padding(1)
        Me.cellNumber.MaxLength = 16
        Me.cellNumber.Name = "cellNumber"
        Me.HelpProvider1.SetShowHelp(Me.cellNumber, True)
        Me.cellNumber.Size = New System.Drawing.Size(174, 20)
        Me.cellNumber.TabIndex = 4
        '
        'txtLandlineNumber
        '
        Me.HelpProvider1.SetHelpString(Me.txtLandlineNumber, "And now Cympathy needs you to input your LANDLINE")
        Me.txtLandlineNumber.Location = New System.Drawing.Point(221, 151)
        Me.txtLandlineNumber.Margin = New System.Windows.Forms.Padding(1)
        Me.txtLandlineNumber.MaxLength = 8
        Me.txtLandlineNumber.Name = "txtLandlineNumber"
        Me.HelpProvider1.SetShowHelp(Me.txtLandlineNumber, True)
        Me.txtLandlineNumber.Size = New System.Drawing.Size(174, 20)
        Me.txtLandlineNumber.TabIndex = 5
        '
        'txtFirstname
        '
        Me.HelpProvider1.SetHelpString(Me.txtFirstname, "Well first thing's first and that is your First Name. INPUT IT NAO!")
        Me.txtFirstname.Location = New System.Drawing.Point(221, 1)
        Me.txtFirstname.Margin = New System.Windows.Forms.Padding(1)
        Me.txtFirstname.MaxLength = 10
        Me.txtFirstname.Name = "txtFirstname"
        Me.HelpProvider1.SetShowHelp(Me.txtFirstname, True)
        Me.txtFirstname.Size = New System.Drawing.Size(174, 20)
        Me.txtFirstname.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Middle Initial"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Last Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1, 76)
        Me.Label11.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Security Question"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1, 114)
        Me.Label10.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Secret Answer"
        '
        'questionIndex
        '
        Me.questionIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.questionIndex.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.questionIndex, "Just in case you forget your password, Cympathy will try to help out by asking yo" & _
        "u a personal question (we won't know about it) in order to help identify you")
        Me.questionIndex.Items.AddRange(New Object() {"Who was your childhood hero?", "What is life to you?", "What was your childhood nickname?"})
        Me.questionIndex.Location = New System.Drawing.Point(222, 77)
        Me.questionIndex.Margin = New System.Windows.Forms.Padding(1)
        Me.questionIndex.Name = "questionIndex"
        Me.HelpProvider1.SetShowHelp(Me.questionIndex, True)
        Me.questionIndex.Size = New System.Drawing.Size(174, 21)
        Me.questionIndex.TabIndex = 3
        '
        'txtSecretAnswer
        '
        Me.HelpProvider1.SetHelpString(Me.txtSecretAnswer, "Don't you dare tell this to anyone (Cympathy won't, pinky swear!) make sure only " & _
        "[YOU] know the answer to the Security Question")
        Me.txtSecretAnswer.Location = New System.Drawing.Point(222, 115)
        Me.txtSecretAnswer.Margin = New System.Windows.Forms.Padding(1)
        Me.txtSecretAnswer.MaxLength = 50
        Me.txtSecretAnswer.Name = "txtSecretAnswer"
        Me.HelpProvider1.SetShowHelp(Me.txtSecretAnswer, True)
        Me.txtSecretAnswer.Size = New System.Drawing.Size(174, 20)
        Me.txtSecretAnswer.TabIndex = 4
        '
        'grpCredentials
        '
        Me.grpCredentials.Controls.Add(Me.TableLayoutPanel1)
        Me.grpCredentials.Location = New System.Drawing.Point(1, 1)
        Me.grpCredentials.Margin = New System.Windows.Forms.Padding(1)
        Me.grpCredentials.Name = "grpCredentials"
        Me.grpCredentials.Padding = New System.Windows.Forms.Padding(1)
        Me.grpCredentials.Size = New System.Drawing.Size(444, 207)
        Me.grpCredentials.TabIndex = 4
        Me.grpCredentials.TabStop = False
        Me.grpCredentials.Text = "Credentials"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tableAccountType, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtUsername, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPassword, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtSecretAnswer, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.questionIndex, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1, 14)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(442, 192)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'txtUsername
        '
        Me.HelpProvider1.SetHelpString(Me.txtUsername, "Input the Account Username Here! This is  the system-unique name that is given pe" & _
        "r account")
        Me.txtUsername.Location = New System.Drawing.Point(222, 1)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(1)
        Me.txtUsername.MaxLength = 50
        Me.txtUsername.Name = "txtUsername"
        Me.HelpProvider1.SetShowHelp(Me.txtUsername, True)
        Me.txtUsername.Size = New System.Drawing.Size(174, 20)
        Me.txtUsername.TabIndex = 1
        '
        'txtPassword
        '
        Me.HelpProvider1.SetHelpString(Me.txtPassword, "This is a must! Input your password here! Oh and, you may want to check whoever i" & _
        "s watching you atm.")
        Me.txtPassword.Location = New System.Drawing.Point(222, 39)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(1)
        Me.txtPassword.MaxLength = 12
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.HelpProvider1.SetShowHelp(Me.txtPassword, True)
        Me.txtPassword.Size = New System.Drawing.Size(174, 20)
        Me.txtPassword.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_save
        '
        Me.HelpProvider1.SetHelpString(Me.btn_save, "HOLD UP! BEFORE YOU CLICK THAT RED X BUTTON! Save your work!! Save this account t" & _
        "o the database, by clicking on this (really bland looking) SAVE BUTTON")
        Me.btn_save.Location = New System.Drawing.Point(1, 587)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_save.Name = "btn_save"
        Me.HelpProvider1.SetShowHelp(Me.btn_save, True)
        Me.btn_save.Size = New System.Drawing.Size(109, 51)
        Me.btn_save.TabIndex = 6
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.grpCredentials)
        Me.FlowLayoutPanel1.Controls.Add(Me.grpPersonal)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_save)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(445, 668)
        Me.FlowLayoutPanel1.TabIndex = 7
        '
        'frmUserRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 668)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.WeLearnLMS.My.MySettings.Default, "MainFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.WeLearnLMS.My.MySettings.Default.MainFont
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpString(Me, "This is where we register a new user to user the system!")
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserRegistration"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formRegistration"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPersonal.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.tableAccountType.ResumeLayout(False)
        Me.tableAccountType.PerformLayout()
        Me.grpCredentials.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents grpPersonal As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMi As System.Windows.Forms.TextBox
    Friend WithEvents txtCitizenship As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents rdTeacher As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rdStudent As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtLandlineNumber As System.Windows.Forms.TextBox
    Friend WithEvents cellNumber As System.Windows.Forms.TextBox
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents grpCredentials As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents questionIndex As System.Windows.Forms.ComboBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtSecretAnswer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tableAccountType As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
