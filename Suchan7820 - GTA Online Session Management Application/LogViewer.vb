Public Class LogViewer
    Private Sub LogViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim logpath As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData, "ApplicationLog.log")
        If IO.File.Exists(logpath) Then
            Logbox.Text = IO.File.ReadAllText(logpath)
        Else
            Logbox.Font = New Font(Logbox.Font, Logbox.Font.Style Or FontStyle.Italic)
            Logbox.Text = Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & "                                아직 기록이 없음"
        End If
    End Sub
    Private Sub Logdel_Click(sender As Object, e As EventArgs) Handles Logdel.Click
        Dim logpath As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData, "ApplicationLog.log")
        IO.File.Delete(logpath)
        Logbox.Font = New Font(Logbox.Font, Logbox.Font.Style Or FontStyle.Italic)
        Logbox.Text = Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & "                                아직 기록이 없음"
    End Sub
    Private Sub Ref_Click(sender As Object, e As EventArgs) Handles Ref.Click
        Dim logpath As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData, "ApplicationLog.log")
        If Not IO.File.Exists(logpath) Then
            Logbox.Text = Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & "                                아직 기록이 없음"
        Else
            Logbox.Font = New Font(Logbox.Font, Logbox.Font.Style And FontStyle.Regular)
            Logbox.Text = IO.File.ReadAllText(logpath)
        End If
    End Sub
End Class