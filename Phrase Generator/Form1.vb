Public Class Form1
    Dim input As String
    Dim output As String
    Dim phrases(200) As String
    Dim nouns(200) As String
    Dim verbs(200) As String
    Dim adjectives(200) As String
    Dim names(200) As String
    Dim index As Integer
    Dim rnd1 As Integer
    Dim rnd2 As Integer
    Dim rnd3 As Integer

    Dim txtY As Integer = 10

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        populateArrays()
        lblOutput.Text = String.Empty
    End Sub

    Private Sub btnGenerate_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerate.Click
        randomize()
        output = "Well " & verbs(rnd1) & " me " & adjectives(rnd2) & " and call me " & names(rnd3) & "."
        lblOutput.Text = output
        'newTextbox()
    End Sub

    'USER DEFINES SUBS
    Public Sub randomize()
        rnd1 = Int(Rnd() * 10)
        rnd2 = Int(Rnd() * 10)
        rnd3 = Int(Rnd() * 10)
    End Sub

    Public Sub populateArrays()
        verbs(0) = "kill"
        verbs(1) = "lick"
        verbs(2) = "slap"
        verbs(3) = "tickle"
        verbs(4) = "bash"
        verbs(5) = "throw"
        verbs(6) = "digest"
        verbs(7) = "hit"
        verbs(8) = "smash"
        verbs(9) = "love"
        verbs(10) = "kiss"

        adjectives(0) = "sexy"
        adjectives(1) = "silly"
        adjectives(2) = "funny"
        adjectives(3) = "blind"
        adjectives(4) = "itchy"
        adjectives(5) = "jealous"
        adjectives(6) = "nervous"
        adjectives(7) = "lazy"
        adjectives(8) = "scary"
        adjectives(9) = "grumpy"
        adjectives(10) = "fierce"

        names(0) = "Rowan"
        names(1) = "Sally"
        names(2) = "Suzy"
        names(3) = "Sam"
        names(4) = "Robert"
        names(5) = "Timothy"
        names(6) = "Clara"
        names(7) = "Dwayne"
        names(8) = "Renaldo"
        names(9) = "Nila"
        names(10) = "Chung"
    End Sub

    Public Sub newTextbox()
        Dim f As New System.Drawing.Font("Sans Serif", 10)

        Dim txtBox As New TextBox
        txtBox.Width = 1000
        txtBox.Height = 25
        txtBox.Top = txtY
        txtBox.Left = 850
        txtBox.ReadOnly = True
        txtBox.BorderStyle = BorderStyle.None
        txtBox.Font = f
        txtBox.Font = New System.Drawing.Font(txtBox.Font, FontStyle.Bold)
        Me.Controls.Add(txtBox)
        txtY = txtY + 30
        txtBox.Text = output
    End Sub

    Private Sub picSettings_HoverOn(sender As System.Object, e As System.EventArgs) Handles picSettings.MouseEnter
        picSettings.Image = My.Resources.settings
    End Sub

    Private Sub picSettings_HoverOff(sender As System.Object, e As System.EventArgs) Handles picSettings.MouseLeave
        picSettings.Image = My.Resources.settingson
    End Sub

    Private Sub picSettings_Click(sender As System.Object, e As System.EventArgs) Handles picSettings.Click
        Form2.Show()
        Form2.Left = Me.Left
        Form2.Top = Me.Top
    End Sub
End Class