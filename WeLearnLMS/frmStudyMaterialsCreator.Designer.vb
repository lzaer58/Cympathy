﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudyMaterialsCreator
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
        Me.txtMaterialName = New System.Windows.Forms.TextBox()
        Me.txtMaterialDescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddMaterial = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMaterialName
        '
        Me.HelpProvider1.SetHelpString(Me.txtMaterialName, "Enter the material name")
        Me.txtMaterialName.Location = New System.Drawing.Point(143, 3)
        Me.txtMaterialName.Name = "txtMaterialName"
        Me.HelpProvider1.SetShowHelp(Me.txtMaterialName, True)
        Me.txtMaterialName.Size = New System.Drawing.Size(134, 20)
        Me.txtMaterialName.TabIndex = 0
        '
        'txtMaterialDescription
        '
        Me.HelpProvider1.SetHelpString(Me.txtMaterialDescription, "Enter the material description")
        Me.txtMaterialDescription.Location = New System.Drawing.Point(143, 60)
        Me.txtMaterialDescription.Multiline = True
        Me.txtMaterialDescription.Name = "txtMaterialDescription"
        Me.HelpProvider1.SetShowHelp(Me.txtMaterialDescription, True)
        Me.txtMaterialDescription.Size = New System.Drawing.Size(134, 52)
        Me.txtMaterialDescription.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Material Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Material Description"
        '
        'btnAddMaterial
        '
        Me.HelpProvider1.SetHelpString(Me.btnAddMaterial, "Save the data to the database")
        Me.btnAddMaterial.Location = New System.Drawing.Point(211, 131)
        Me.btnAddMaterial.Name = "btnAddMaterial"
        Me.HelpProvider1.SetShowHelp(Me.btnAddMaterial, True)
        Me.btnAddMaterial.Size = New System.Drawing.Size(75, 23)
        Me.btnAddMaterial.TabIndex = 4
        Me.btnAddMaterial.Text = "Add"
        Me.btnAddMaterial.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtMaterialName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtMaterialDescription, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(9, 10)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(280, 115)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'frmStudyMaterialsCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 170)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnAddMaterial)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.WeLearnLMS.My.MySettings.Default, "MainFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.WeLearnLMS.My.MySettings.Default.MainFont
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStudyMaterialsCreator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStudyMaterialsCreator"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtMaterialName As System.Windows.Forms.TextBox
    Friend WithEvents txtMaterialDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAddMaterial As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
