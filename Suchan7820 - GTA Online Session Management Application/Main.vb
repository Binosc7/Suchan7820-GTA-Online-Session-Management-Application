'Copyright ⓒ 2022 Suchan7820. All rights reserved.
Public Class Main
    Dim logpath As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData, "ApplicationLog.log")
    Dim last_recent_act As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData, "LastExecutedAct.log")
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
        If Not IO.File.Exists(last_recent_act) Then
            My.Computer.FileSystem.WriteAllText(last_recent_act, "최초 실행 또는 실행 작업 없거나 로그 없음", False)
            RecentAct.Text = IO.File.ReadAllText(last_recent_act)
        Else
            RecentAct.Text = IO.File.ReadAllText(last_recent_act)
        End If
    End Sub
    Private Sub CheckProc_Tick(sender As Object, e As EventArgs) Handles CheckProc.Tick 'GTA5.exe 감지 메인
        Dim Proc As Process() = Process.GetProcessesByName("GTA5")
        If Proc.Count >= 1 Then
            ProcNotier.TextAlign = ContentAlignment.MiddleCenter
            ProcNotier.Text = "                     GTA5.exe 감지됨"
            SessionMaker.Enabled = True
            CheckProcSub.Start()
            CheckProc.Stop()
        End If
    End Sub
    Private Sub CheckProcSub_Tick(sender As Object, e As EventArgs) Handles CheckProcSub.Tick 'GTA5 감지 서브
        Dim Proc As Process() = Process.GetProcessesByName("GTA5")
        If Proc.Count = 0 Then
            SessionMaker.Enabled = False
            ProcNotier.Text = "GTA5.exe를 찾지 못했습니다." & Chr(13) & "Grand Theft Auto V가 실행되었는지 확인하십시오."
            CheckProc.Start()
            CheckProcSub.Stop()
        End If
    End Sub
    Private Sub SessionMaker_Click(sender As Object, e As EventArgs) Handles SessionMaker.Click '1세 만들기
        Dim game As Process() = Process.GetProcessesByName("GTA5")
        SuspendProcess(game(0))
        SessionMaker.Enabled = False
        SessionMaker.Text = "잠시만 기다려 주세요..."
        SessionMakerTime.Start()
        My.Computer.FileSystem.WriteAllText(last_recent_act, "마지막 실행 : 1P Public Session Creation", False)
    End Sub
    Private Sub SessionMakerTime_Tick(sender As Object, e As EventArgs) Handles SessionMakerTime.Tick '1세 10초 타이머
        Dim game As Process() = Process.GetProcessesByName("GTA5")
        ResumeProcess(game(0))
        SessionMaker.Text = "1인 공개세션 만들기"
        SessionMaker.Enabled = True
        RecentAct.Text = "1P Public Session has been created successfully"
        SessionMakerTime.Stop()
        My.Computer.FileSystem.WriteAllText(logpath, "[" + Now + "]" + " 1인 공개세션이 만들어짐" + Chr(13), True)
    End Sub
    Private Sub AddFirewall_Click(sender As Object, e As EventArgs) Handles AddFirewall.Click '방화벽 생성
        Dim Firewall As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData, "AddFirewall.bat")
        IO.File.WriteAllText(Firewall, My.Resources.AddFirewall)
        Process.Start(Firewall)
        RecentAct.Text = " Firewall added completely"
        My.Computer.FileSystem.WriteAllText(logpath, "[" + Now + "]" + " GTA 온라인 세션 방화벽이 생성됨" + Chr(13), True)
        My.Computer.FileSystem.WriteAllText(last_recent_act, "마지막 실행 : Firewall Creation", False)
    End Sub
    Private Sub DelFirewall_Click(sender As Object, e As EventArgs) Handles DelFirewall.Click '방화벽 제거
        Dim Waterwall As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData, "DelFirewall.bat")
        IO.File.WriteAllText(Waterwall, My.Resources.DelFirewall)
        Process.Start(Waterwall)
        RecentAct.Text = " Firewall removed completely"
        My.Computer.FileSystem.WriteAllText(logpath, "[" + Now + "]" + " GTA 온라인 세션 방화벽이 제거됨" + Chr(13), True)
        My.Computer.FileSystem.WriteAllText(last_recent_act, "마지막 실행 : Firewall Deletion", False)
    End Sub
    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help.Click '도움말 실행
        HelpForm.Show()
    End Sub
    Private Sub Log_Click(sender As Object, e As EventArgs) Handles Log.Click '실행기록 실행
        LogViewer.Show()
    End Sub
End Class
