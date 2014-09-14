<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.chboxAudio = New System.Windows.Forms.CheckBox()
        Me.chboxExplicit = New System.Windows.Forms.CheckBox()
        Me.tooltipSounds = New System.Windows.Forms.ToolTip(Me.components)
        Me.chboxMusic = New System.Windows.Forms.CheckBox()
        Me.tooltipMusic = New System.Windows.Forms.ToolTip(Me.components)
        Me.tooltipExplicit = New System.Windows.Forms.ToolTip(Me.components)
        Me.chboxSpeech = New System.Windows.Forms.CheckBox()
        Me.tooltipSpeech = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'chboxAudio
        '
        Me.chboxAudio.AutoSize = True
        Me.chboxAudio.Location = New System.Drawing.Point(154, 282)
        Me.chboxAudio.Name = "chboxAudio"
        Me.chboxAudio.Size = New System.Drawing.Size(78, 21)
        Me.chboxAudio.TabIndex = 0
        Me.chboxAudio.Text = "Sounds"
        Me.tooltipSounds.SetToolTip(Me.chboxAudio, "Enable or disable all sound effects.")
        Me.chboxAudio.UseVisualStyleBackColor = True
        '
        'chboxExplicit
        '
        Me.chboxExplicit.AutoSize = True
        Me.chboxExplicit.Location = New System.Drawing.Point(306, 281)
        Me.chboxExplicit.Name = "chboxExplicit"
        Me.chboxExplicit.Size = New System.Drawing.Size(73, 21)
        Me.chboxExplicit.TabIndex = 1
        Me.chboxExplicit.Text = "Explicit"
        Me.tooltipExplicit.SetToolTip(Me.chboxExplicit, "Enable or disable all explicit content ie swear words")
        Me.chboxExplicit.UseVisualStyleBackColor = True
        '
        'tooltipSounds
        '
        Me.tooltipSounds.AutomaticDelay = 300
        Me.tooltipSounds.ToolTipTitle = "Sound Effects"
        '
        'chboxMusic
        '
        Me.chboxMusic.AutoSize = True
        Me.chboxMusic.Location = New System.Drawing.Point(228, 323)
        Me.chboxMusic.Name = "chboxMusic"
        Me.chboxMusic.Size = New System.Drawing.Size(66, 21)
        Me.chboxMusic.TabIndex = 2
        Me.chboxMusic.Text = "Music"
        Me.tooltipSounds.SetToolTip(Me.chboxMusic, "Enable or disable all music")
        Me.chboxMusic.UseVisualStyleBackColor = True
        '
        'tooltipMusic
        '
        Me.tooltipMusic.AutomaticDelay = 300
        Me.tooltipMusic.ToolTipTitle = "Music"
        '
        'tooltipExplicit
        '
        Me.tooltipExplicit.AutomaticDelay = 300
        Me.tooltipExplicit.ToolTipTitle = "Explicit Content"
        '
        'chboxSpeech
        '
        Me.chboxSpeech.AutoSize = True
        Me.chboxSpeech.Location = New System.Drawing.Point(228, 243)
        Me.chboxSpeech.Name = "chboxSpeech"
        Me.chboxSpeech.Size = New System.Drawing.Size(78, 21)
        Me.chboxSpeech.TabIndex = 3
        Me.chboxSpeech.Text = "Speech"
        Me.tooltipSpeech.SetToolTip(Me.chboxSpeech, "Enable or disable the text-to-speech feature")
        Me.chboxSpeech.UseVisualStyleBackColor = True
        '
        'tooltipSpeech
        '
        Me.tooltipSpeech.AutomaticDelay = 300
        Me.tooltipSpeech.ToolTipTitle = "Speech"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 396)
        Me.Controls.Add(Me.chboxSpeech)
        Me.Controls.Add(Me.chboxMusic)
        Me.Controls.Add(Me.chboxExplicit)
        Me.Controls.Add(Me.chboxAudio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Phrase Generator: Settings"
        Me.tooltipExplicit.SetToolTip(Me, "Enable or disable all explicit content.")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chboxAudio As System.Windows.Forms.CheckBox
    Friend WithEvents chboxExplicit As System.Windows.Forms.CheckBox
    Friend WithEvents tooltipSounds As System.Windows.Forms.ToolTip
    Friend WithEvents tooltipExplicit As System.Windows.Forms.ToolTip
    Friend WithEvents chboxMusic As System.Windows.Forms.CheckBox
    Friend WithEvents tooltipMusic As System.Windows.Forms.ToolTip
    Friend WithEvents chboxSpeech As System.Windows.Forms.CheckBox
    Friend WithEvents tooltipSpeech As System.Windows.Forms.ToolTip
End Class
