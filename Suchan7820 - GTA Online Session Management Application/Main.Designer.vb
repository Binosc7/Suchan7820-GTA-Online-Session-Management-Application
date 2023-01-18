<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MadeBySuchan7820 = New System.Windows.Forms.Label()
        Me.ProcNotier = New System.Windows.Forms.Label()
        Me.DetectOpt = New System.Windows.Forms.GroupBox()
        Me.SessionMaker = New System.Windows.Forms.Button()
        Me.NoDetectOpt = New System.Windows.Forms.GroupBox()
        Me.Help = New System.Windows.Forms.Button()
        Me.DelFirewall = New System.Windows.Forms.Button()
        Me.AddFirewall = New System.Windows.Forms.Button()
        Me.RecentAct = New System.Windows.Forms.TextBox()
        Me.Log = New System.Windows.Forms.Button()
        Me.CheckProc = New System.Windows.Forms.Timer(Me.components)
        Me.SessionMakerTime = New System.Windows.Forms.Timer(Me.components)
        Me.CheckProcSub = New System.Windows.Forms.Timer(Me.components)
        Me.DetectOpt.SuspendLayout()
        Me.NoDetectOpt.SuspendLayout()
        Me.SuspendLayout()
        '
        'MadeBySuchan7820
        '
        Me.MadeBySuchan7820.AutoSize = True
        Me.MadeBySuchan7820.Font = New System.Drawing.Font("맑은 고딕", 11.0!)
        Me.MadeBySuchan7820.ForeColor = System.Drawing.Color.MediumPurple
        Me.MadeBySuchan7820.Location = New System.Drawing.Point(14, 282)
        Me.MadeBySuchan7820.Name = "MadeBySuchan7820"
        Me.MadeBySuchan7820.Size = New System.Drawing.Size(353, 20)
        Me.MadeBySuchan7820.TabIndex = 0
        Me.MadeBySuchan7820.Text = "Copyright ⓒ 2023 Suchan7820. All rights reserved."
        '
        'ProcNotier
        '
        Me.ProcNotier.AutoSize = True
        Me.ProcNotier.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.ProcNotier.Location = New System.Drawing.Point(16, 17)
        Me.ProcNotier.Name = "ProcNotier"
        Me.ProcNotier.Size = New System.Drawing.Size(327, 38)
        Me.ProcNotier.TabIndex = 0
        Me.ProcNotier.Text = "GTA5.exe를 찾지 못했습니다." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grand Theft Auto V가 실행되었는지 확인하십시오."
        Me.ProcNotier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DetectOpt
        '
        Me.DetectOpt.Controls.Add(Me.SessionMaker)
        Me.DetectOpt.Controls.Add(Me.ProcNotier)
        Me.DetectOpt.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.DetectOpt.Location = New System.Drawing.Point(12, 12)
        Me.DetectOpt.Name = "DetectOpt"
        Me.DetectOpt.Size = New System.Drawing.Size(360, 95)
        Me.DetectOpt.TabIndex = 0
        Me.DetectOpt.TabStop = False
        Me.DetectOpt.Text = "GTA5 프로세스 감지"
        '
        'SessionMaker
        '
        Me.SessionMaker.Enabled = False
        Me.SessionMaker.Font = New System.Drawing.Font("맑은 고딕", 12.0!)
        Me.SessionMaker.Location = New System.Drawing.Point(6, 58)
        Me.SessionMaker.Name = "SessionMaker"
        Me.SessionMaker.Size = New System.Drawing.Size(348, 30)
        Me.SessionMaker.TabIndex = 1
        Me.SessionMaker.Text = "1인 공개세션 만들기"
        Me.SessionMaker.UseVisualStyleBackColor = True
        '
        'NoDetectOpt
        '
        Me.NoDetectOpt.Controls.Add(Me.Help)
        Me.NoDetectOpt.Controls.Add(Me.DelFirewall)
        Me.NoDetectOpt.Controls.Add(Me.AddFirewall)
        Me.NoDetectOpt.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.NoDetectOpt.Location = New System.Drawing.Point(12, 113)
        Me.NoDetectOpt.Name = "NoDetectOpt"
        Me.NoDetectOpt.Size = New System.Drawing.Size(360, 134)
        Me.NoDetectOpt.TabIndex = 1
        Me.NoDetectOpt.TabStop = False
        Me.NoDetectOpt.Text = "GTA5 프로세스 비감지"
        '
        'Help
        '
        Me.Help.Font = New System.Drawing.Font("맑은 고딕", 12.0!)
        Me.Help.Location = New System.Drawing.Point(6, 96)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(348, 30)
        Me.Help.TabIndex = 4
        Me.Help.Text = "도움말"
        Me.Help.UseVisualStyleBackColor = True
        '
        'DelFirewall
        '
        Me.DelFirewall.Font = New System.Drawing.Font("맑은 고딕", 12.0!)
        Me.DelFirewall.Location = New System.Drawing.Point(6, 60)
        Me.DelFirewall.Name = "DelFirewall"
        Me.DelFirewall.Size = New System.Drawing.Size(348, 30)
        Me.DelFirewall.TabIndex = 3
        Me.DelFirewall.Text = "GTA 온라인 세션 방화벽 제거"
        Me.DelFirewall.UseVisualStyleBackColor = True
        '
        'AddFirewall
        '
        Me.AddFirewall.Font = New System.Drawing.Font("맑은 고딕", 12.0!)
        Me.AddFirewall.Location = New System.Drawing.Point(6, 24)
        Me.AddFirewall.Name = "AddFirewall"
        Me.AddFirewall.Size = New System.Drawing.Size(348, 30)
        Me.AddFirewall.TabIndex = 2
        Me.AddFirewall.Text = "GTA 온라인 세션 방화벽 생성"
        Me.AddFirewall.UseVisualStyleBackColor = True
        '
        'RecentAct
        '
        Me.RecentAct.Enabled = False
        Me.RecentAct.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.RecentAct.Location = New System.Drawing.Point(12, 253)
        Me.RecentAct.Name = "RecentAct"
        Me.RecentAct.Size = New System.Drawing.Size(279, 23)
        Me.RecentAct.TabIndex = 0
        Me.RecentAct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Log
        '
        Me.Log.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.Log.Location = New System.Drawing.Point(297, 253)
        Me.Log.Name = "Log"
        Me.Log.Size = New System.Drawing.Size(75, 23)
        Me.Log.TabIndex = 5
        Me.Log.Text = "실행 기록"
        Me.Log.UseVisualStyleBackColor = True
        '
        'CheckProc
        '
        '
        'SessionMakerTime
        '
        Me.SessionMakerTime.Interval = 10000
        '
        'CheckProcSub
        '
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 311)
        Me.Controls.Add(Me.Log)
        Me.Controls.Add(Me.RecentAct)
        Me.Controls.Add(Me.NoDetectOpt)
        Me.Controls.Add(Me.DetectOpt)
        Me.Controls.Add(Me.MadeBySuchan7820)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GTAO Session Management Application"
        Me.TopMost = True
        Me.DetectOpt.ResumeLayout(False)
        Me.DetectOpt.PerformLayout()
        Me.NoDetectOpt.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MadeBySuchan7820 As Label
    Friend WithEvents ProcNotier As Label
    Friend WithEvents DetectOpt As GroupBox
    Friend WithEvents SessionMaker As Button
    Friend WithEvents NoDetectOpt As GroupBox
    Friend WithEvents AddFirewall As Button
    Friend WithEvents Help As Button
    Friend WithEvents DelFirewall As Button
    Friend WithEvents RecentAct As TextBox
    Friend WithEvents Log As Button
    Friend WithEvents CheckProc As Timer
    Friend WithEvents SessionMakerTime As Timer
    Friend WithEvents CheckProcSub As Timer
End Class
