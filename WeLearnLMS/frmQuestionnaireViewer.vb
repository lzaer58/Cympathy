﻿Imports System.Xml.Serialization
Imports System.IO
Imports System.Security.Cryptography

Public Class frmQuestionnaireViewer

    Private _Questionnaire As New c_Questionnaire

    Private _cQuiz As New c_Quiz
    Private _cExam As New c_Exam
    Private _IsExam As Boolean
    Private _PreGrades As New c_PreGrade

    Private _Index As UInt32

    Private _Shuffler As IAnswerArrayShuffler = New ImpAnswerArrayShuffler

    Friend ReadOnly Property GetPregrade As c_PreGrade
        Get
            Return _PreGrades
        End Get
    End Property

    Public Sub New(ByRef ThisQuiz As c_Quiz)
        InitializeComponent()
        Me._cQuiz = ThisQuiz
        Me._IsExam = False
        ForEachStuff(_cQuiz.QuestionBase)
    End Sub
    Public Sub New(ByRef ThisExam As c_Exam)
        InitializeComponent()
        Me._cExam = ThisExam
        Me._IsExam = True
        ForEachStuff(_cExam.QuestionBase)
    End Sub
    Public Sub New(ByRef ThisQuestionnaire As c_Questionnaire)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._Questionnaire = ThisQuestionnaire
    End Sub
    Public Sub New(ByRef XMLString As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me._Questionnaire = DataDeserialize(XMLString)
    End Sub

    ''' <summary>
    ''' Use this to Deserialize the data
    ''' </summary>
    ''' <param name="data">XML String to return</param>
    ''' <returns>c_ShortQuiz</returns>
    ''' <remarks></remarks>
    Private Function DataDeserialize(ByVal data As String) As c_Questionnaire
        Dim xs As New XmlSerializer(GetType(c_Questionnaire))
        Dim newList As c_Questionnaire = CType(xs.Deserialize(New StringReader(data)), c_Questionnaire)
        Return newList
    End Function

    ''' <summary>
    ''' Use this Shuffler for the Questions
    ''' </summary>
    ''' <param name="ThisCollection">c_SmallQuestions</param>
    ''' <returns>c_SmallQuestion List</returns>
    ''' <remarks></remarks>
    Private Function ShufflePartTwo(ByVal ThisCollection As List(Of c_SmallQuestion)) As List(Of c_SmallQuestion)
        Dim r As Random = New Random()
        Return ThisCollection.OrderBy(Function(a) r.Next()).ToList()
    End Function

    ''' <summary>
    ''' Use this to parse the lists to the Datagridview
    ''' AKA
    ''' Setup the datagridview
    ''' </summary>
    ''' <param name="ThisType"></param>
    ''' <remarks></remarks>
    Private Sub ForEachStuff(ByRef ThisType As List(Of c_SmallQuestion))
        Dim INDEX As UInt32 = 0
        Dim AnswerArray(4) As String

        For Each item As c_SmallQuestion In ThisType

            INDEX += 1
            With item
                AnswerArray(0) = .Distractor1
                AnswerArray(1) = .Distractor2
                AnswerArray(2) = .Distractor3
                AnswerArray(3) = .Distractor4
                '_Shuffler.Shuffle(AnswerArray)
                DataGridView1.Rows.Add(INDEX, .QuestionBase, AnswerArray(0), AnswerArray(1), AnswerArray(2), AnswerArray(3))
            End With
        Next
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If TypeOf DataGridView1.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
            With DataGridView1.Rows(e.RowIndex)
                Me._Index = e.RowIndex
                RichTextBox1.Text = .Cells("tttQuestionBase").Value.ToString()
                RadioButton1.Text = .Cells("tttDistractor1").Value.ToString()
                RadioButton2.Text = .Cells("tttDistractor2").Value.ToString()
                RadioButton3.Text = .Cells("tttDistractor3").Value.ToString()
                RadioButton4.Text = .Cells("tttDistractor4").Value.ToString()
            End With
        End If

    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click, RadioButton2.Click, RadioButton3.Click, RadioButton4.Click
        Dim i = DataGridView1.CurrentRow.Index

        With DataGridView1
            .Rows(i).Cells("tttANS").Value = DirectCast(sender, RadioButton).Text
        End With
    End Sub

    ''' <summary>
    ''' Count all the Correct Answers VS All Answers
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Counter()
        Dim AllQuestions As UInt16 = 0
        Dim Hits As UInt16 = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            AllQuestions += 1
            If row.Cells("tttANS").Value = row.Cells("tttDistractor4").Value Then
                Hits += 1
            End If
        Next

        With Me._PreGrades
            .Hits = Hits
            .TotalQuestions = AllQuestions
        End With
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        With DirectCast(sender, RadioButton)
            If .Checked = True Then
                'TODO - SET THE "YOUR ANSWER" COLUMN INTO THE TEXT OF THE RADIO BUTTON!
                Dim UpdatedDataRow As DataGridViewRow
                UpdatedDataRow = DataGridView1.Rows(Me._Index)
                'Set Cells equal to the Senders Text property
                UpdatedDataRow.Cells(5).Value = .Text
            End If
        End With
    End Sub

    Private Sub frmQuestionnaireViewer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Counter()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmQuestionnaireViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class