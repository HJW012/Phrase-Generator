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
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.picSettings = New System.Windows.Forms.PictureBox()
        CType(Me.picSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(359, 474)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(142, 23)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Generate Phrase"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(303, 236)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(87, 35)
        Me.lblOutput.TabIndex = 1
        Me.lblOutput.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(732, 677)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(77, 17)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'picSettings
        '
        Me.picSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSettings.Image = Global.WindowsApplication1.My.Resources.Resources.settingson
        Me.picSettings.Location = New System.Drawing.Point(65, 572)
        Me.picSettings.Name = "picSettings"
        Me.picSettings.Size = New System.Drawing.Size(20, 20)
        Me.picSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSettings.TabIndex = 4
        Me.picSettings.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 727)
        Me.Controls.Add(Me.picSettings)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnGenerate)
        Me.Name = "Form1"
        Me.Text = "Phrase Generator"
        CType(Me.picSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents picSettings As System.Windows.Forms.PictureBox

End Class
