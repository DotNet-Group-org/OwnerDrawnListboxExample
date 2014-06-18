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
        Me.lbStates = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.radioOwnerNameFlagSeal = New System.Windows.Forms.RadioButton
        Me.radioOwnerNameFlag = New System.Windows.Forms.RadioButton
        Me.radioOwnerName = New System.Windows.Forms.RadioButton
        Me.radioStandard = New System.Windows.Forms.RadioButton
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbStates
        '
        Me.lbStates.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbStates.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbStates.Enabled = False
        Me.lbStates.FormattingEnabled = True
        Me.lbStates.Location = New System.Drawing.Point(15, 44)
        Me.lbStates.Name = "lbStates"
        Me.lbStates.Size = New System.Drawing.Size(261, 446)
        Me.lbStates.Sorted = True
        Me.lbStates.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "States"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(560, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileOpen, Me.ToolStripMenuItem1, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(35, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.Size = New System.Drawing.Size(111, 22)
        Me.mnuFileOpen.Text = "&Open"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(108, 6)
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(111, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(300, 265)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(300, 389)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radioOwnerNameFlagSeal)
        Me.GroupBox1.Controls.Add(Me.radioOwnerNameFlag)
        Me.GroupBox1.Controls.Add(Me.radioOwnerName)
        Me.GroupBox1.Controls.Add(Me.radioStandard)
        Me.GroupBox1.Location = New System.Drawing.Point(300, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(243, 174)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Draw Mode"
        '
        'radioOwnerNameFlagSeal
        '
        Me.radioOwnerNameFlagSeal.AutoSize = True
        Me.radioOwnerNameFlagSeal.Location = New System.Drawing.Point(11, 93)
        Me.radioOwnerNameFlagSeal.Name = "radioOwnerNameFlagSeal"
        Me.radioOwnerNameFlagSeal.Size = New System.Drawing.Size(223, 17)
        Me.radioOwnerNameFlagSeal.TabIndex = 7
        Me.radioOwnerNameFlagSeal.TabStop = True
        Me.radioOwnerNameFlagSeal.Text = "Owner Drawn, State Name, Flag and Seal"
        Me.radioOwnerNameFlagSeal.UseVisualStyleBackColor = True
        '
        'radioOwnerNameFlag
        '
        Me.radioOwnerNameFlag.AutoSize = True
        Me.radioOwnerNameFlag.Location = New System.Drawing.Point(11, 70)
        Me.radioOwnerNameFlag.Name = "radioOwnerNameFlag"
        Me.radioOwnerNameFlag.Size = New System.Drawing.Size(196, 17)
        Me.radioOwnerNameFlag.TabIndex = 6
        Me.radioOwnerNameFlag.TabStop = True
        Me.radioOwnerNameFlag.Text = "Owner Drawn, State Name and Flag"
        Me.radioOwnerNameFlag.UseVisualStyleBackColor = True
        '
        'radioOwnerName
        '
        Me.radioOwnerName.AutoSize = True
        Me.radioOwnerName.Location = New System.Drawing.Point(11, 47)
        Me.radioOwnerName.Name = "radioOwnerName"
        Me.radioOwnerName.Size = New System.Drawing.Size(174, 17)
        Me.radioOwnerName.TabIndex = 5
        Me.radioOwnerName.Text = "Owner Drawn, State Name only"
        Me.radioOwnerName.UseVisualStyleBackColor = True
        '
        'radioStandard
        '
        Me.radioStandard.AutoSize = True
        Me.radioStandard.Checked = True
        Me.radioStandard.Location = New System.Drawing.Point(11, 24)
        Me.radioStandard.Name = "radioStandard"
        Me.radioStandard.Size = New System.Drawing.Size(98, 17)
        Me.radioStandard.TabIndex = 4
        Me.radioStandard.TabStop = True
        Me.radioStandard.Text = "Standard Mode"
        Me.radioStandard.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 505)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbStates)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "OwnerDrawn ListBox Example"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbStates As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radioOwnerNameFlagSeal As System.Windows.Forms.RadioButton
    Friend WithEvents radioOwnerNameFlag As System.Windows.Forms.RadioButton
    Friend WithEvents radioOwnerName As System.Windows.Forms.RadioButton
    Friend WithEvents radioStandard As System.Windows.Forms.RadioButton

End Class
