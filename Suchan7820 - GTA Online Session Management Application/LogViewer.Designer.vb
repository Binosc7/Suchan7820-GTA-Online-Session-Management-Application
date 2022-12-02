<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogViewer
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Logbox = New System.Windows.Forms.RichTextBox()
        Me.LogController = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Logdel = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ref = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogController.SuspendLayout()
        Me.SuspendLayout()
        '
        'Logbox
        '
        Me.Logbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Logbox.ContextMenuStrip = Me.LogController
        Me.Logbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Logbox.Font = New System.Drawing.Font("맑은 고딕", 11.0!)
        Me.Logbox.Location = New System.Drawing.Point(0, 0)
        Me.Logbox.Name = "Logbox"
        Me.Logbox.ReadOnly = True
        Me.Logbox.Size = New System.Drawing.Size(444, 531)
        Me.Logbox.TabIndex = 0
        Me.Logbox.Text = "I am cute and lovely"
        '
        'LogController
        '
        Me.LogController.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Logdel, Me.Ref})
        Me.LogController.Name = "LogController"
        Me.LogController.Size = New System.Drawing.Size(183, 48)
        '
        'Logdel
        '
        Me.Logdel.Name = "Logdel"
        Me.Logdel.Size = New System.Drawing.Size(182, 22)
        Me.Logdel.Text = "모든 실행 기록 삭제"
        '
        'Ref
        '
        Me.Ref.Name = "Ref"
        Me.Ref.Size = New System.Drawing.Size(182, 22)
        Me.Ref.Text = "새로고침"
        '
        'LogViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 531)
        Me.Controls.Add(Me.Logbox)
        Me.Name = "LogViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "실행 기록"
        Me.TopMost = True
        Me.LogController.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Logbox As RichTextBox
    Friend WithEvents LogController As ContextMenuStrip
    Friend WithEvents Logdel As ToolStripMenuItem
    Friend WithEvents Ref As ToolStripMenuItem
End Class
