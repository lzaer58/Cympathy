﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticleMaker
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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.txtArticleName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelProfessorsOnly = New System.Windows.Forms.Panel()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelProfessorsOnly.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HelpProvider1.SetHelpString(Me.RichTextBox1, "Type in the data you want! If you feel limited in the amount of processing this t" & _
        "hing lacks, don't worry. If you copy from Office Word, it will accept the format" & _
        "ting")
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 30)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.RichTextBox1, True)
        Me.RichTextBox1.Size = New System.Drawing.Size(741, 453)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'txtArticleName
        '
        Me.HelpProvider1.SetHelpString(Me.txtArticleName, "The article name!")
        Me.txtArticleName.Location = New System.Drawing.Point(3, 3)
        Me.txtArticleName.Name = "txtArticleName"
        Me.HelpProvider1.SetShowHelp(Me.txtArticleName, True)
        Me.txtArticleName.Size = New System.Drawing.Size(100, 20)
        Me.txtArticleName.TabIndex = 1
        '
        'btnSave
        '
        Me.HelpProvider1.SetHelpString(Me.btnSave, "Saves the article to the database")
        Me.btnSave.Location = New System.Drawing.Point(109, 1)
        Me.btnSave.Name = "btnSave"
        Me.HelpProvider1.SetShowHelp(Me.btnSave, True)
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PanelProfessorsOnly
        '
        Me.PanelProfessorsOnly.Controls.Add(Me.txtArticleName)
        Me.PanelProfessorsOnly.Controls.Add(Me.btnSave)
        Me.PanelProfessorsOnly.Controls.Add(Me.RichTextBox1)
        Me.PanelProfessorsOnly.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelProfessorsOnly.Location = New System.Drawing.Point(0, 0)
        Me.PanelProfessorsOnly.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelProfessorsOnly.Name = "PanelProfessorsOnly"
        Me.PanelProfessorsOnly.Size = New System.Drawing.Size(741, 483)
        Me.PanelProfessorsOnly.TabIndex = 3
        '
        'frmArticleMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 483)
        Me.Controls.Add(Me.PanelProfessorsOnly)
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpString(Me, "This is where the user will create articles")
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmArticleMaker"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmArticleMaker"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelProfessorsOnly.ResumeLayout(False)
        Me.PanelProfessorsOnly.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents txtArticleName As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents PanelProfessorsOnly As System.Windows.Forms.Panel
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
