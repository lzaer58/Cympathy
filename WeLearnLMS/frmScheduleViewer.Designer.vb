﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScheduleViewer
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.grpTimeslot = New System.Windows.Forms.GroupBox()
        Me.tblTimeslotPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.txtTimeStart = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTimeEnd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grpClassroom = New System.Windows.Forms.GroupBox()
        Me.tblClassroomPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtClassroomID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClassroomName = New System.Windows.Forms.TextBox()
        Me.txtClassroomDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtClassroomType = New System.Windows.Forms.TextBox()
        Me.grpDay = New System.Windows.Forms.GroupBox()
        Me.tblDayPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.txtDayDescription = New System.Windows.Forms.TextBox()
        Me.txtDayID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkVisible = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTimeslot.SuspendLayout()
        Me.tblTimeslotPanel.SuspendLayout()
        Me.grpClassroom.SuspendLayout()
        Me.tblClassroomPanel.SuspendLayout()
        Me.grpDay.SuspendLayout()
        Me.tblDayPanel.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(612, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'grpTimeslot
        '
        Me.grpTimeslot.Controls.Add(Me.tblTimeslotPanel)
        Me.grpTimeslot.Location = New System.Drawing.Point(209, 159)
        Me.grpTimeslot.Name = "grpTimeslot"
        Me.grpTimeslot.Size = New System.Drawing.Size(200, 129)
        Me.grpTimeslot.TabIndex = 3
        Me.grpTimeslot.TabStop = False
        Me.grpTimeslot.Text = "Timeslot"
        '
        'tblTimeslotPanel
        '
        Me.tblTimeslotPanel.ColumnCount = 2
        Me.tblTimeslotPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTimeslotPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTimeslotPanel.Controls.Add(Me.txtTimeStart, 1, 0)
        Me.tblTimeslotPanel.Controls.Add(Me.Label6, 0, 0)
        Me.tblTimeslotPanel.Controls.Add(Me.txtTimeEnd, 1, 1)
        Me.tblTimeslotPanel.Controls.Add(Me.Label7, 0, 1)
        Me.tblTimeslotPanel.Location = New System.Drawing.Point(5, 18)
        Me.tblTimeslotPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.tblTimeslotPanel.Name = "tblTimeslotPanel"
        Me.tblTimeslotPanel.RowCount = 2
        Me.tblTimeslotPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTimeslotPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTimeslotPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblTimeslotPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblTimeslotPanel.Size = New System.Drawing.Size(190, 106)
        Me.tblTimeslotPanel.TabIndex = 6
        '
        'txtTimeStart
        '
        Me.txtTimeStart.Location = New System.Drawing.Point(98, 3)
        Me.txtTimeStart.Name = "txtTimeStart"
        Me.txtTimeStart.ReadOnly = True
        Me.txtTimeStart.Size = New System.Drawing.Size(89, 23)
        Me.txtTimeStart.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Hour Start"
        '
        'txtTimeEnd
        '
        Me.txtTimeEnd.Location = New System.Drawing.Point(98, 56)
        Me.txtTimeEnd.Name = "txtTimeEnd"
        Me.txtTimeEnd.ReadOnly = True
        Me.txtTimeEnd.Size = New System.Drawing.Size(89, 23)
        Me.txtTimeEnd.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Hour End"
        '
        'grpClassroom
        '
        Me.grpClassroom.Controls.Add(Me.tblClassroomPanel)
        Me.grpClassroom.Location = New System.Drawing.Point(3, 159)
        Me.grpClassroom.Name = "grpClassroom"
        Me.grpClassroom.Size = New System.Drawing.Size(200, 129)
        Me.grpClassroom.TabIndex = 2
        Me.grpClassroom.TabStop = False
        Me.grpClassroom.Text = "Classroom"
        '
        'tblClassroomPanel
        '
        Me.tblClassroomPanel.ColumnCount = 2
        Me.tblClassroomPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblClassroomPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblClassroomPanel.Controls.Add(Me.Label1, 0, 3)
        Me.tblClassroomPanel.Controls.Add(Me.txtClassroomID, 1, 3)
        Me.tblClassroomPanel.Controls.Add(Me.Label2, 0, 0)
        Me.tblClassroomPanel.Controls.Add(Me.txtClassroomName, 1, 0)
        Me.tblClassroomPanel.Controls.Add(Me.txtClassroomDescription, 1, 1)
        Me.tblClassroomPanel.Controls.Add(Me.Label3, 0, 1)
        Me.tblClassroomPanel.Controls.Add(Me.Label4, 0, 2)
        Me.tblClassroomPanel.Controls.Add(Me.txtClassroomType, 1, 2)
        Me.tblClassroomPanel.Location = New System.Drawing.Point(5, 18)
        Me.tblClassroomPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.tblClassroomPanel.Name = "tblClassroomPanel"
        Me.tblClassroomPanel.RowCount = 4
        Me.tblClassroomPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblClassroomPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblClassroomPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblClassroomPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblClassroomPanel.Size = New System.Drawing.Size(190, 106)
        Me.tblClassroomPanel.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID"
        '
        'txtClassroomID
        '
        Me.txtClassroomID.Location = New System.Drawing.Point(98, 81)
        Me.txtClassroomID.Name = "txtClassroomID"
        Me.txtClassroomID.ReadOnly = True
        Me.txtClassroomID.Size = New System.Drawing.Size(89, 23)
        Me.txtClassroomID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name"
        '
        'txtClassroomName
        '
        Me.txtClassroomName.Location = New System.Drawing.Point(98, 3)
        Me.txtClassroomName.Name = "txtClassroomName"
        Me.txtClassroomName.ReadOnly = True
        Me.txtClassroomName.Size = New System.Drawing.Size(89, 23)
        Me.txtClassroomName.TabIndex = 2
        '
        'txtClassroomDescription
        '
        Me.txtClassroomDescription.Location = New System.Drawing.Point(98, 29)
        Me.txtClassroomDescription.Name = "txtClassroomDescription"
        Me.txtClassroomDescription.ReadOnly = True
        Me.txtClassroomDescription.Size = New System.Drawing.Size(89, 23)
        Me.txtClassroomDescription.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Type"
        '
        'txtClassroomType
        '
        Me.txtClassroomType.Location = New System.Drawing.Point(98, 55)
        Me.txtClassroomType.Name = "txtClassroomType"
        Me.txtClassroomType.ReadOnly = True
        Me.txtClassroomType.Size = New System.Drawing.Size(89, 23)
        Me.txtClassroomType.TabIndex = 4
        '
        'grpDay
        '
        Me.grpDay.Controls.Add(Me.tblDayPanel)
        Me.grpDay.Location = New System.Drawing.Point(415, 159)
        Me.grpDay.Name = "grpDay"
        Me.grpDay.Size = New System.Drawing.Size(200, 129)
        Me.grpDay.TabIndex = 4
        Me.grpDay.TabStop = False
        Me.grpDay.Text = "Day"
        '
        'tblDayPanel
        '
        Me.tblDayPanel.ColumnCount = 2
        Me.tblDayPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDayPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDayPanel.Controls.Add(Me.txtDayDescription, 1, 0)
        Me.tblDayPanel.Controls.Add(Me.txtDayID, 1, 1)
        Me.tblDayPanel.Controls.Add(Me.Label8, 0, 0)
        Me.tblDayPanel.Controls.Add(Me.Label9, 0, 1)
        Me.tblDayPanel.Location = New System.Drawing.Point(5, 18)
        Me.tblDayPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.tblDayPanel.Name = "tblDayPanel"
        Me.tblDayPanel.RowCount = 2
        Me.tblDayPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDayPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDayPanel.Size = New System.Drawing.Size(190, 106)
        Me.tblDayPanel.TabIndex = 6
        '
        'txtDayDescription
        '
        Me.txtDayDescription.Location = New System.Drawing.Point(98, 3)
        Me.txtDayDescription.Name = "txtDayDescription"
        Me.txtDayDescription.ReadOnly = True
        Me.txtDayDescription.Size = New System.Drawing.Size(89, 23)
        Me.txtDayDescription.TabIndex = 0
        '
        'txtDayID
        '
        Me.txtDayID.Location = New System.Drawing.Point(98, 56)
        Me.txtDayID.Name = "txtDayID"
        Me.txtDayID.ReadOnly = True
        Me.txtDayID.Size = New System.Drawing.Size(89, 23)
        Me.txtDayID.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 34)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Day Description"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Day ID"
        '
        'chkVisible
        '
        Me.chkVisible.AutoSize = True
        Me.chkVisible.Checked = True
        Me.chkVisible.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVisible.Location = New System.Drawing.Point(2, 293)
        Me.chkVisible.Margin = New System.Windows.Forms.Padding(2)
        Me.chkVisible.Name = "chkVisible"
        Me.chkVisible.Size = New System.Drawing.Size(112, 21)
        Me.chkVisible.TabIndex = 5
        Me.chkVisible.Text = "Show More..."
        Me.chkVisible.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.DataGridView1)
        Me.FlowLayoutPanel1.Controls.Add(Me.grpClassroom)
        Me.FlowLayoutPanel1.Controls.Add(Me.grpTimeslot)
        Me.FlowLayoutPanel1.Controls.Add(Me.grpDay)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkVisible)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(626, 320)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'frmScheduleViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 320)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.WeLearnLMS.My.MySettings.Default, "MainFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.WeLearnLMS.My.MySettings.Default.MainFont
        Me.Name = "frmScheduleViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmScheduleViewer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTimeslot.ResumeLayout(False)
        Me.tblTimeslotPanel.ResumeLayout(False)
        Me.tblTimeslotPanel.PerformLayout()
        Me.grpClassroom.ResumeLayout(False)
        Me.tblClassroomPanel.ResumeLayout(False)
        Me.tblClassroomPanel.PerformLayout()
        Me.grpDay.ResumeLayout(False)
        Me.tblDayPanel.ResumeLayout(False)
        Me.tblDayPanel.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents grpTimeslot As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTimeEnd As System.Windows.Forms.TextBox
    Friend WithEvents grpClassroom As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtClassroomID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtClassroomName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtClassroomDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtClassroomType As System.Windows.Forms.TextBox
    Friend WithEvents grpDay As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDayID As System.Windows.Forms.TextBox
    Friend WithEvents txtDayDescription As System.Windows.Forms.TextBox
    Friend WithEvents chkVisible As System.Windows.Forms.CheckBox
    Friend WithEvents tblTimeslotPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblClassroomPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblDayPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txtTimeStart As System.Windows.Forms.TextBox
End Class
