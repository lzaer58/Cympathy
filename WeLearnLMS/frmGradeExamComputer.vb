﻿Public Class frmGradeExamComputer

    Private _AllExamsCount As UInt32
    Private _RecordedCount As UInt32
    Private _AverageDatatable As New DataTable
    Private _GradeSummation As Double = 0.0
    Private _FullAverage As Double = 0.0

    Private Sub frmGradeExamComputer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
    End Sub
#Region "Properties"
    Friend ReadOnly Property ExamCount As UInt32
        Get
            Return _AllExamsCount
        End Get
    End Property

    Friend ReadOnly Property RecordedCount As UInt32
        Get
            Return _RecordedCount
        End Get
    End Property

    Friend ReadOnly Property GradeSummation As Double
        Get
            Return _GradeSummation
        End Get
    End Property

    Friend ReadOnly Property FullAverage As Double
        Get
            Return _FullAverage
        End Get
    End Property

    Friend ReadOnly Property GetMyDatatable As DataTable
        Get
            Return Me._AverageDatatable
        End Get
    End Property
#End Region
#Region "Functionality"
    ''' <summary>
    ''' Find the count of all registered Quizes in ThisClassroom
    ''' </summary>
    ''' <param name="ClassroomID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function GetCountQuizesInClassroom(ByRef ClassroomID As String)
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Using Command As New MySqlCommand
                With Command
                    .Connection = Connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "CountExams"
                    With .Parameters
                        .AddWithValue("ClassID", ClassroomID)
                    End With
                    Return .ExecuteScalar()
                End With
            End Using
        End Using
    End Function

    ''' <summary>
    ''' Summate all the quiz grades
    ''' </summary>
    ''' <remarks></remarks>
    Friend Function GetSumationOfExams() As Double
        Dim myGradeSummation = 0.0
        For Each Row As DataRow In Me._AverageDatatable.Rows
            myGradeSummation += Row("exam_grade")
        Next
        Return myGradeSummation
    End Function

    ''' <summary>
    ''' Return the Count of AverageDatatable
    ''' This could also be known as the 
    ''' Count of all the Quizes the Studen Answered
    ''' </summary>
    ''' <remarks></remarks>
    Friend Function GetRecordedCount() As UInt32
        Return Me._AverageDatatable.Rows.Count
    End Function

    ''' <summary>
    ''' Get The Datatable containing all the quizes
    ''' </summary>
    ''' <param name="UserID"></param>
    ''' <param name="ClassID"></param>
    ''' <remarks></remarks>
    Friend Function GetAnsweredExams(ByRef UserID As String, ByRef ClassID As String) As DataTable
        Dim DimTable As New DataTable
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With

            Using Command As New MySqlCommand
                With Command
                    .Connection = Connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SelectGradesExam"
                    With .Parameters
                        .AddWithValue("UserID", UserID)
                        .AddWithValue("ClassID", ClassID)
                    End With
                End With
                Using Adapter As New MySqlDataAdapter(Command)
                    With Adapter
                        .Fill(DimTable)
                    End With
                End Using
            End Using
        End Using
        Return DimTable
    End Function

    ''' <summary>
    ''' Get Full average of all quizes
    ''' </summary>
    ''' <param name="Summation">The Summated grade of all quizes</param>
    ''' <param name="Count">The Count of all existing quizes</param>
    ''' <returns>a Double</returns>
    ''' <remarks></remarks>
    Friend Function GetNewAverage(ByVal Summation As Double, ByVal Count As UInt32) As Double
        Return (Summation / Count)
    End Function
#End Region
    ''' <summary>
    ''' Display all necessary data outside to the GUI
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DisplayOnDatagridview()

        Dim btn As New DataGridViewButtonColumn()

        With btn
            .HeaderText = "Action"
            .Text = "Open"
            .Name = "btn"
            .UseColumnTextForButtonValue = True
        End With

        With DataGridView1

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .DataSource = Me._AverageDatatable
            .Columns.Add(btn)
            If .Columns.Contains("id") Then .Columns("id").Visible = False

            .Refresh()
        End With
    End Sub

    ''' <summary>
    ''' Display all necessary data outside to the GUI
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DisplayOnTextboxes()
        With Me
            .txtFullAverage.Text = ._FullAverage.ToString
            .txtAllExams.Text = ._AllExamsCount.ToString
            .txtYourExams.Text = ._RecordedCount.ToString
            .txtFullSummation.Text = ._GradeSummation
        End With
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Me._AverageDatatable = GetAnsweredExams(_SharedUserID, _SharedClassroom.ClassroomId)
        BackgroundWorker1.ReportProgress(20)
        'get sum of all recorded exams (YOU)
        Me._RecordedCount = GetRecordedCount()
        BackgroundWorker1.ReportProgress(40)
        'get count of all exams (ALL)
        Me._AllExamsCount = GetCountQuizesInClassroom(_SharedClassroom.ClassroomId)
        BackgroundWorker1.ReportProgress(60)
        'get sum of grades of all exams
        Me._GradeSummation = GetSumationOfExams()
        BackgroundWorker1.ReportProgress(80)
        'get average
        Me._FullAverage = GetNewAverage(Me._GradeSummation, Me._AllExamsCount)
        BackgroundWorker1.ReportProgress(100)
    End Sub

    Friend Function ReturnFullAverage() As Double
        Me._AverageDatatable = GetAnsweredExams(_SharedUserID, _SharedClassroom.ClassroomId)
        'get sum of all recorded exams (YOU)
        Me._RecordedCount = GetRecordedCount()
        'get count of all exams (ALL)
        Me._AllExamsCount = GetCountQuizesInClassroom(_SharedClassroom.ClassroomId)
        'get sum of grades of all exams
        Me._GradeSummation = GetSumationOfExams()
        'get average
        Me._FullAverage = GetNewAverage(Me._GradeSummation, Me._AllExamsCount)
        Return Me._FullAverage
    End Function

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        DisplayOnDatagridview()
        DisplayOnTextboxes()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        backgroundProgress.Value = e.ProgressPercentage
    End Sub
End Class