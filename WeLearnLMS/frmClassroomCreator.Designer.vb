﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassroomCreator
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtClassName = New System.Windows.Forms.TextBox()
        Me.cmbClassroomType = New System.Windows.Forms.ComboBox()
        Me.rtbClassDescription = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelProfessorsOnly = New System.Windows.Forms.Panel()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelProfessorsOnly.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(206, 204)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 38)
        Me.TableLayoutPanel1.TabIndex = 20
        '
        'Button1
        '
        Me.HelpProvider1.SetHelpString(Me.Button1, "now before you can save the classroom, you have to add it")
        Me.Button1.Location = New System.Drawing.Point(3, 2)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.HelpProvider1.SetShowHelp(Me.Button1, True)
        Me.Button1.Size = New System.Drawing.Size(91, 33)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HelpProvider1.SetHelpString(Me.OK_Button, "click this to save the classroom")
        Me.OK_Button.Location = New System.Drawing.Point(101, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.HelpProvider1.SetShowHelp(Me.OK_Button, True)
        Me.OK_Button.Size = New System.Drawing.Size(89, 30)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "SAVE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Type in the Class Name or Subject Code"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 138)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Class Type"
        '
        'txtClassName
        '
        Me.HelpProvider1.SetHelpString(Me.txtClassName, "This is the name of the classroom. Anything goes... not really. type in the subje" & _
        "ct code or the classroom name")
        Me.txtClassName.Location = New System.Drawing.Point(3, 23)
        Me.txtClassName.Margin = New System.Windows.Forms.Padding(1)
        Me.txtClassName.MaxLength = 20
        Me.txtClassName.Name = "txtClassName"
        Me.HelpProvider1.SetShowHelp(Me.txtClassName, True)
        Me.txtClassName.Size = New System.Drawing.Size(401, 20)
        Me.txtClassName.TabIndex = 2
        '
        'cmbClassroomType
        '
        Me.cmbClassroomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClassroomType.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cmbClassroomType, "Check if the classroom is SEMESTRAL or TRIMESTRAL")
        Me.cmbClassroomType.Location = New System.Drawing.Point(4, 159)
        Me.cmbClassroomType.Margin = New System.Windows.Forms.Padding(1)
        Me.cmbClassroomType.Name = "cmbClassroomType"
        Me.HelpProvider1.SetShowHelp(Me.cmbClassroomType, True)
        Me.cmbClassroomType.Size = New System.Drawing.Size(135, 21)
        Me.cmbClassroomType.TabIndex = 17
        '
        'rtbClassDescription
        '
        Me.HelpProvider1.SetHelpString(Me.rtbClassDescription, "Type in the Classroom Description")
        Me.rtbClassDescription.Location = New System.Drawing.Point(3, 67)
        Me.rtbClassDescription.Margin = New System.Windows.Forms.Padding(1)
        Me.rtbClassDescription.MaxLength = 20
        Me.rtbClassDescription.Name = "rtbClassDescription"
        Me.HelpProvider1.SetShowHelp(Me.rtbClassDescription, True)
        Me.rtbClassDescription.Size = New System.Drawing.Size(401, 71)
        Me.rtbClassDescription.TabIndex = 7
        Me.rtbClassDescription.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-1, 49)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Your Class Description... (Err.. Keep it short)"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 500
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PanelProfessorsOnly
        '
        Me.PanelProfessorsOnly.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelProfessorsOnly.Controls.Add(Me.Label2)
        Me.PanelProfessorsOnly.Controls.Add(Me.Label1)
        Me.PanelProfessorsOnly.Controls.Add(Me.txtClassName)
        Me.PanelProfessorsOnly.Controls.Add(Me.cmbClassroomType)
        Me.PanelProfessorsOnly.Controls.Add(Me.rtbClassDescription)
        Me.PanelProfessorsOnly.Controls.Add(Me.Label4)
        Me.PanelProfessorsOnly.Location = New System.Drawing.Point(15, 15)
        Me.PanelProfessorsOnly.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelProfessorsOnly.Name = "PanelProfessorsOnly"
        Me.PanelProfessorsOnly.Size = New System.Drawing.Size(405, 246)
        Me.PanelProfessorsOnly.TabIndex = 21
        '
        'frmClassroomCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 273)
        Me.Controls.Add(Me.PanelProfessorsOnly)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.WeLearnLMS.My.MySettings.Default, "MainFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.WeLearnLMS.My.MySettings.Default.MainFont
        Me.HelpProvider1.SetHelpString(Me, "This module is where we create a classroom! Time to start studyying!!")
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmClassroomCreator"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmClassroomCreator"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelProfessorsOnly.ResumeLayout(False)
        Me.PanelProfessorsOnly.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtClassName As System.Windows.Forms.TextBox
    Friend WithEvents cmbClassroomType As System.Windows.Forms.ComboBox
    Friend WithEvents rtbClassDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents PanelProfessorsOnly As System.Windows.Forms.Panel
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
