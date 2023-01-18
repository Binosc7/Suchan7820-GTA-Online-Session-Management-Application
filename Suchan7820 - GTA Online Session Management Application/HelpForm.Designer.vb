<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpForm
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
        Me.SessionMakerInst = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MadeBySuchan7820 = New System.Windows.Forms.Label()
        Me.SessionMakerInst.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SessionMakerInst
        '
        Me.SessionMakerInst.Controls.Add(Me.Label1)
        Me.SessionMakerInst.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.SessionMakerInst.Location = New System.Drawing.Point(12, 12)
        Me.SessionMakerInst.Name = "SessionMakerInst"
        Me.SessionMakerInst.Size = New System.Drawing.Size(360, 87)
        Me.SessionMakerInst.TabIndex = 0
        Me.SessionMakerInst.TabStop = False
        Me.SessionMakerInst.Text = "1인 공개세션 만들기"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 57)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GTA 온라인 세션과의 연결을 해제합니다." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "일정 플레이어가 모여야 시작되는 작업들의 경우" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "이 기능을 사용하면 임무가 취소됩니다."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 87)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GTA 온라인 세션 방화벽 생성"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(328, 57)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "GTA 온라인이 사용하는 세션 포트를 차단합니다." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "플레이어가 보내는 데이터를 모두 차단하기 때문에" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "자신을 제외하고 모두 세션에 참가할 수 없습" &
    "니다." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 87)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GTA 온라인 세션 방화벽 제거"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(350, 57)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "GTA온라인이 사용하는 세션 포트를 개방합니다." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "다른 플레이어가 보내는 세션 데이터를 다시 받습니다." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "이후 플레이어가 현재 세션에 참가할 수 " &
    "있습니다."
        '
        'MadeBySuchan7820
        '
        Me.MadeBySuchan7820.AutoSize = True
        Me.MadeBySuchan7820.Font = New System.Drawing.Font("맑은 고딕", 11.0!)
        Me.MadeBySuchan7820.ForeColor = System.Drawing.Color.MediumPurple
        Me.MadeBySuchan7820.Location = New System.Drawing.Point(15, 288)
        Me.MadeBySuchan7820.Name = "MadeBySuchan7820"
        Me.MadeBySuchan7820.Size = New System.Drawing.Size(353, 20)
        Me.MadeBySuchan7820.TabIndex = 0
        Me.MadeBySuchan7820.Text = "Copyright ⓒ 2022 Suchan7820. All rights reserved."
        '
        'HelpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 311)
        Me.Controls.Add(Me.MadeBySuchan7820)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.SessionMakerInst)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HelpForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "도움말"
        Me.TopMost = True
        Me.SessionMakerInst.ResumeLayout(False)
        Me.SessionMakerInst.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SessionMakerInst As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MadeBySuchan7820 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
