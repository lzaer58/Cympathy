﻿Public Class frmQuizHub

    Private _Datatable As New DataTable
    Private _ClassroomID As String
    Private _XmlBase As String

    Private _IsModal As Boolean

    Private _Quiz As New c_Quiz

    Private _Deserializer As IDataDeserializer = New ImpDataDeserializer

    Friend ReadOnly Property RetrieveQuiz As c_Quiz
        Get
            Return _Quiz
        End Get
    End Property

    Friend ReadOnly Property ThrowMainDatatable As DataTable
        Get
            Return _Datatable
        End Get
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.btnView.Enabled = False
        Me.btnOK.Enabled = True
        Me._IsModal = True
    End Sub

    Public Sub New(ByRef ClassroomID As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Me._Credentials = Credentials
        Me._ClassroomID = ClassroomID
        Me._IsModal = False
    End Sub

    Friend Sub LoadAllClasses()
        Using Connection As New MySqlConnection
            With Connection
                .ConnectionString = _SharedConnString.ConnString
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With

            Using Command As New MySqlCommand
                With Command
                    .Connection = Connection
                    .CommandText = "SELECT * FROM tbl_quizes"
                End With

                Using Adapter As New MySqlDataAdapter
                    With Adapter
                        .SelectCommand = Command
                        .Fill(_Datatable)
                    End With
                End Using
            End Using
        End Using
    End Sub
    Friend Sub LoadAllClasses(ByRef ThisClassroomID As String)
        Using Connection As New MySqlConnection
            With Connection
                .ConnectionString = _SharedConnString.ConnString
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With

            Using Command As New MySqlCommand
                With Command
                    .Connection = Connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SelectQuizesFromThisClass"
                    With .Parameters
                        .AddWithValue("ClassroomID", ThisClassroomID)
                    End With
                End With

                Using Adapter As New MySqlDataAdapter
                    With Adapter
                        .SelectCommand = Command
                        .Fill(_Datatable)
                    End With
                End Using
            End Using
        End Using
    End Sub

    Private Sub ParseTextbox()
        With Me
            ._Quiz.QuestionnaireName = txtQuizName.Text
            ._Quiz.QuestionnaireID = txtQuizID.Text
        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If TypeOf DataGridView1.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
            If DataGridView1.Columns(e.ColumnIndex).Name = "btn" Then

                With DataGridView1.Rows(e.RowIndex)
                    txtQuizID.Text = .Cells(0).Value.ToString()
                    txtQuizName.Text = .Cells(1).Value.ToString()
                    _XmlBase = .Cells(2).Value.ToString()
                End With

            End If
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ParseTextbox()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmQuizHub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me._IsModal Then LoadAllClasses()
        If Not Me._IsModal Then LoadAllClasses(_ClassroomID)

        Dim btn As New DataGridViewButtonColumn()

        With btn
            .HeaderText = "Action"
            .Text = "Open"
            .Name = "btn"
            .UseColumnTextForButtonValue = True
        End With

        With DataGridView1
            .DataSource = _Datatable
            .Columns.Add(btn)

            .Columns("xml_base").Visible = False
        End With

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Me._Quiz.QuestionBase = _Deserializer.DataDeserialize(_XmlBase)
        ParseTextbox()

        Dim viewer As New frmQuizViewer(Me._Quiz)
        viewer.ShowDialog()
    End Sub
End Class