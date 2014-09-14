<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.picSettings = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.menuWelcome = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.lblMenuAbout = New System.Windows.Forms.Label()
        Me.lblMenuPhrase = New System.Windows.Forms.Label()
        CType(Me.picSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(175, 297)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(140, 30)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Generate Phrase"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'picSettings
        '
        Me.picSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSettings.Image = Global.WindowsApplication1.My.Resources.Resources.settingson
        Me.picSettings.Location = New System.Drawing.Point(12, 307)
        Me.picSettings.Name = "picSettings"
        Me.picSettings.Size = New System.Drawing.Size(20, 20)
        Me.picSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSettings.TabIndex = 4
        Me.picSettings.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.menuWelcome, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(685, 344)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Black
        Me.RectangleShape2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RectangleShape2.FillColor = System.Drawing.Color.DarkGray
        Me.RectangleShape2.FillGradientColor = System.Drawing.Color.LightGreen
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(259, 9)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.Size = New System.Drawing.Size(125, 24)
        '
        'menuWelcome
        '
        Me.menuWelcome.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.menuWelcome.BorderColor = System.Drawing.Color.Black
        Me.menuWelcome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuWelcome.FillColor = System.Drawing.Color.Silver
        Me.menuWelcome.FillGradientColor = System.Drawing.Color.LightGreen
        Me.menuWelcome.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.menuWelcome.Location = New System.Drawing.Point(97, 9)
        Me.menuWelcome.Name = "menuWelcome"
        Me.menuWelcome.SelectionColor = System.Drawing.Color.Transparent
        Me.menuWelcome.Size = New System.Drawing.Size(50, 24)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.FillColor = System.Drawing.Color.Silver
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(22, 119)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Size = New System.Drawing.Size(622, 61)
        '
        'txtOutput
        '
        Me.txtOutput.BackColor = System.Drawing.Color.Silver
        Me.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOutput.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(22, 133)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(622, 37)
        Me.txtOutput.TabIndex = 6
        Me.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(133, 68)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(132, 32)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(132, 32)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(321, 297)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(140, 30)
        Me.btnCopy.TabIndex = 8
        Me.btnCopy.Text = "Copy to Clipboard"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'lblMenuAbout
        '
        Me.lblMenuAbout.AutoSize = True
        Me.lblMenuAbout.BackColor = System.Drawing.Color.Silver
        Me.lblMenuAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMenuAbout.Location = New System.Drawing.Point(101, 13)
        Me.lblMenuAbout.Name = "lblMenuAbout"
        Me.lblMenuAbout.Size = New System.Drawing.Size(45, 17)
        Me.lblMenuAbout.TabIndex = 9
        Me.lblMenuAbout.Text = "About"
        '
        'lblMenuPhrase
        '
        Me.lblMenuPhrase.AutoSize = True
        Me.lblMenuPhrase.BackColor = System.Drawing.Color.DarkGray
        Me.lblMenuPhrase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMenuPhrase.Location = New System.Drawing.Point(261, 13)
        Me.lblMenuPhrase.Name = "lblMenuPhrase"
        Me.lblMenuPhrase.Size = New System.Drawing.Size(122, 17)
        Me.lblMenuPhrase.TabIndex = 10
        Me.lblMenuPhrase.Text = "Phrase Generator"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 344)
        Me.Controls.Add(Me.lblMenuPhrase)
        Me.Controls.Add(Me.lblMenuAbout)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.picSettings)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Phrase Generator"
        CType(Me.picSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents picSettings As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Private WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents menuWelcome As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblMenuAbout As System.Windows.Forms.Label
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblMenuPhrase As System.Windows.Forms.Label

End Class
