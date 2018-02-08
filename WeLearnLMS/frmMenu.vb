﻿Public Class frmMenu

    Private _AdvancedCredentials As New c_AdvancedCredentials
    Private _Stopwatch As New Stopwatch
    Public Sub New(ByRef AdvancedCredentials As c_AdvancedCredentials)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        With Me
            ._AdvancedCredentials = AdvancedCredentials
        End With
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlagThisUser(True)

        FrmUAC.DisableAllMe(_SharedAdvancedCredentials.MyUserType, mainpanel)

        _Stopwatch.Start()
        timerSession.Start()

    End Sub

    Private Sub FlagThisUser(ByVal State As Boolean)
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()

                End If
            End With
            Dim transaction As MySqlTransaction = Connection.BeginTransaction
            Try
                Using Command As New MySqlCommand
                    With Command
                        .Connection = Connection
                        .CommandText = "SetUserOnline"
                        With .Parameters
                            .AddWithValue("UserID", _SharedUserID)
                            .AddWithValue("UserState", State)
                        End With
                        .ExecuteNonQuery()
                    End With
                End Using

            Catch XXX As MySqlException
                transaction.Rollback()
            Catch ex As Exception
                DisplayGeneralException(ex)
            End Try


        End Using
    End Sub

    Private Sub btnClassroomHub_Click(sender As Object, e As EventArgs) Handles btnClassroomHub.Click
        Dim ClassroomHub As New frmClassroomHub
        ClassroomHub.ShowDialog()
        With Me.StatusStrip1

            toolstripCLASSNAME.Text = _SharedClassroom.ClassroomName
            toolstripCLASSROOMID.Text = _SharedClassroom.ClassroomId
        End With
    End Sub

    Private Sub btnTimeManagement_Click(sender As Object, e As EventArgs) Handles btnTimeManagement.Click
        Dim TimeManagement As New frmTimeManagementHub(TryCast(_AdvancedCredentials, c_MainCredentials))
        TimeManagement.ShowDialog()
    End Sub

    Private Sub btnFeedback_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click
        Dim bbbFeedback As New frmMessageHub(TryCast(_AdvancedCredentials, c_MainCredentials))
        bbbFeedback.ShowDialog()
    End Sub

#Region "Creator"
    Private Sub btnCreateQuestionnaire_Click(sender As Object, e As EventArgs) Handles btnCreateQuestionnaire.Click
        Dim QuizCreator As New frmQuizCreator
        QuizCreator.ShowDialog()
    End Sub

    Private Sub btnCreateExam_Click(sender As Object, e As EventArgs) Handles btnCreateExam.Click
        Dim CreateExam As New frmExamsCreator
        CreateExam.ShowDialog()
    End Sub

    Private Sub btnCreateMaterials_Click(sender As Object, e As EventArgs) Handles btnCreateMaterials.Click
        Dim CreateMaterial As New frmStudyMaterialsCreator()
        CreateMaterial.ShowDialog()
    End Sub

    Private Sub btnCreateArticles_Click(sender As Object, e As EventArgs) Handles btnCreateArticles.Click
        Dim CreateArticle As New frmArticleMaker
        CreateArticle.ShowDialog()
    End Sub
#End Region

    Private Sub btnLessonList_Click(sender As Object, e As EventArgs) Handles btnLessonList.Click
        Dim viewer As New frmLessonListHub
        viewer.ShowDialog()
    End Sub

    Private Sub btnRanking_Click(sender As Object, e As EventArgs) Handles btnRanking.Click
        Dim viewer As New frmRankingHub()
        viewer.ShowDialog()
    End Sub

    Private Sub btnGrades_Click(sender As Object, e As EventArgs) Handles btnGrades.Click
        Dim viewer As New frmGradesClassroomHub
        viewer.ShowDialog()
    End Sub

    Private Sub timerSession_Tick(sender As Object, e As EventArgs) Handles timerSession.Tick
        Me.tlstrpSECONDS.Text = _Stopwatch.Elapsed.Seconds
        Me.tlstrpMINUTES.Text = _Stopwatch.Elapsed.Minutes
        Me.tlstrpHOURS.Text = _Stopwatch.Elapsed.Hours
        CheatDetector()
    End Sub

    Private Sub CheatDetector()
        If WeLearnAC.AntiCheat() Then
            With Me.lblCheatDetector
                .ForeColor = Color.Red
                .Text = "CHEAT_ENGINE DETECTED!"
            End With
            mainpanel.Enabled = False
            Exit Sub
        End If
        With Me.lblCheatDetector
            .ForeColor = Color.Green
            .Text = "Safe"
        End With
        mainpanel.Enabled = True
    End Sub

    Private Sub btnCreateClassroom_Click(sender As Object, e As EventArgs) Handles btnCreateClassroom.Click
        Dim creator As New frmClassroomCreator()
        creator.ShowDialog()
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub frmMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are you sure you want to log out?", "WeLearnLMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

            FlagThisUser(False)

            e.Cancel = False
            Exit Sub
        End If

        e.Cancel = True

    End Sub
End Class