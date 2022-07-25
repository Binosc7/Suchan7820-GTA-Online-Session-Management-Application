'Copyright ⓒ 2022 Suchan7820. All rights reserved.
Public Class Main
    Dim logpath As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData, "ApplicationLog.log")
    Private Sub SuspendProcess(ByVal process As System.Diagnostics.Process) '프로세스 일시 중단
        For Each t As ProcessThread In process.Threads
            Dim th As IntPtr
            th = OpenThread(ThreadAccess.SUSPEND_RESUME, False, t.Id)
            If th <> IntPtr.Zero Then
                SuspendThread(th)
                CloseHandle(th)
            End If
        Next
    End Sub
    Private Sub ResumeProcess(ByVal process As System.Diagnostics.Process) '프로세스 다시 시작
        For Each t As ProcessThread In process.Threads
            Dim th As IntPtr
            th = OpenThread(ThreadAccess.SUSPEND_RESUME, False, t.Id)
            If th <> IntPtr.Zero Then
                ResumeThread(th)
                CloseHandle(th)
            End If
        Next
    End Sub
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckProc.Start()
    End Sub
    Private Sub CheckProc_Tick(sender As Object, e As EventArgs) Handles CheckProc.Tick
        Dim Proc As Process() = Process.GetProcessesByName("GTA5")
        If Proc.Count >= 1 Then
            ProcNotier.TextAlign = ContentAlignment.MiddleCenter
            ProcNotier.Text = "                     GTA5.exe 감지됨"
            SessionMaker.Enabled = True
            CheckProcSub.Start()
            CheckProc.Stop()
        End If
    End Sub
    Private Sub CheckProcSub_Tick(sender As Object, e As EventArgs) Handles CheckProcSub.Tick
        Dim Proc As Process() = Process.GetProcessesByName("GTA5")
        If Proc.Count = 0 Then
            SessionMaker.Enabled = False
            ProcNotier.Text = "GTA5.exe를 찾지 못했습니다." & Chr(13) & "Grand Theft Auto V가 실행되었는지 확인하십시오."
            CheckProc.Start()
            CheckProcSub.Stop()
        End If
    End Sub
    Private Sub SessionMaker_Click(sender As Object, e As EventArgs) Handles SessionMaker.Click
        Dim game As Process() = Process.GetProcessesByName("GTA5")
        SuspendProcess(game(0))
        SessionMaker.Enabled = False
        SessionMaker.Text = "잠시만 기다려 주세요..."
        SessionMakerTime.Start()
    End Sub
    Private Sub SessionMakerTime_Tick(sender As Object, e As EventArgs) Handles SessionMakerTime.Tick
        Dim game As Process() = Process.GetProcessesByName("GTA5")
        ResumeProcess(game(0))
        SessionMaker.Text = "1인 공개세션 만들기"
        SessionMaker.Enabled = True
        RecentAct.Text = "1P Public Session has been created successfully"
        SessionMakerTime.Stop()
        My.Computer.FileSystem.WriteAllText(logpath, "[" + Now + "]" + " 1인 공개세션이 만들어짐" + Chr(13), True)
    End Sub
    Private Sub AddFirewall_Click(sender As Object, e As EventArgs) Handles AddFirewall.Click
        Dim Firewall As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData, "AddFirewall.bat")
        IO.File.WriteAllText(Firewall, My.Resources.AddFirewall)
        Process.Start(Firewall)
        RecentAct.Text = " Firewall added completely"
        My.Computer.FileSystem.WriteAllText(logpath, "[" + Now + "]" + " GTA 온라인 세션 방화벽이 생성됨" + Chr(13), True)
    End Sub
    Private Sub DelFirewall_Click(sender As Object, e As EventArgs) Handles DelFirewall.Click
        Dim Waterwall As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData, "DelFirewall.bat")
        IO.File.WriteAllText(Waterwall, My.Resources.DelFirewall)
        Process.Start(Waterwall)
        RecentAct.Text = " Firewall removed completely"
        My.Computer.FileSystem.WriteAllText(logpath, "[" + Now + "]" + " GTA 온라인 세션 방화벽이 제거됨" + Chr(13), True)
    End Sub
    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help.Click
        HelpForm.Show()
    End Sub
    Private Sub Log_Click(sender As Object, e As EventArgs) Handles Log.Click
        LogViewer.Show()
    End Sub
End Class
