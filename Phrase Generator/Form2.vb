Public Class Form2
    Public Sub chboxAudio_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chboxAudio.CheckedChanged
        If chboxAudio.CheckState = CheckState.Checked Then
            Form1.audio = True
        Else
            Form1.audio = False
        End If
    End Sub

    'SAVING AND LOADING SETTINGS
    Private Sub Form2_close(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosed
        My.Settings.Audio = chboxAudio.CheckState
    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        chboxAudio.CheckState = My.Settings.Audio
    End Sub
End Class