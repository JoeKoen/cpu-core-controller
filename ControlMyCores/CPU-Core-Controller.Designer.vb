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
        Me.fss = New System.Windows.Forms.TrackBar()
        Me.singlecoreval = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ReportLbl = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.scpl = New System.Windows.Forms.ListBox()
        Me.rfpl1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.pclist = New System.Windows.Forms.CheckedListBox()
        Me.rfspcl = New System.Windows.Forms.Button()
        Me.CoreBox2 = New System.Windows.Forms.GroupBox()
        Me.cs = New System.Windows.Forms.CheckedListBox()
        Me.fcp2 = New System.Windows.Forms.Button()
        Me.ProcessChanger = New System.ComponentModel.BackgroundWorker()
        Me.ProcessChanger2 = New System.ComponentModel.BackgroundWorker()
        Me.ProcessChanger3 = New System.ComponentModel.BackgroundWorker()
        Me.MCBW = New System.ComponentModel.BackgroundWorker()
        CType(Me.fss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.CoreBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'fss
        '
        Me.fss.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fss.LargeChange = 1
        Me.fss.Location = New System.Drawing.Point(6, 19)
        Me.fss.Maximum = 8
        Me.fss.Name = "fss"
        Me.fss.Size = New System.Drawing.Size(303, 45)
        Me.fss.TabIndex = 1
        '
        'singlecoreval
        '
        Me.singlecoreval.AutoSize = True
        Me.singlecoreval.Location = New System.Drawing.Point(6, 67)
        Me.singlecoreval.Name = "singlecoreval"
        Me.singlecoreval.Size = New System.Drawing.Size(86, 13)
        Me.singlecoreval.TabIndex = 2
        Me.singlecoreval.Text = "Core Selected: 0"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox1.Controls.Add(Me.ReportLbl)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.fss)
        Me.GroupBox1.Controls.Add(Me.singlecoreval)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 111)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Single Core Controller - Set all programs to use a single core"
        '
        'ReportLbl
        '
        Me.ReportLbl.AutoSize = True
        Me.ReportLbl.Location = New System.Drawing.Point(84, 88)
        Me.ReportLbl.Name = "ReportLbl"
        Me.ReportLbl.Size = New System.Drawing.Size(84, 13)
        Me.ReportLbl.TabIndex = 5
        Me.ReportLbl.Text = "Doing Nothing..."
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(234, 83)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Reset to All"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Force"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(330, 477)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(322, 451)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Single Core Controller"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox2.Controls.Add(Me.scpl)
        Me.GroupBox2.Controls.Add(Me.rfpl1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(316, 334)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Current Process List"
        '
        'scpl
        '
        Me.scpl.BackColor = System.Drawing.Color.SkyBlue
        Me.scpl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scpl.FormattingEnabled = True
        Me.scpl.Location = New System.Drawing.Point(3, 39)
        Me.scpl.Name = "scpl"
        Me.scpl.Size = New System.Drawing.Size(310, 292)
        Me.scpl.Sorted = True
        Me.scpl.TabIndex = 4
        '
        'rfpl1
        '
        Me.rfpl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.rfpl1.Location = New System.Drawing.Point(3, 16)
        Me.rfpl1.Name = "rfpl1"
        Me.rfpl1.Size = New System.Drawing.Size(310, 23)
        Me.rfpl1.TabIndex = 5
        Me.rfpl1.Text = "Refresh Process List"
        Me.rfpl1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.CoreBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(322, 451)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Multicore Controller"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox4.Controls.Add(Me.pclist)
        Me.GroupBox4.Controls.Add(Me.rfspcl)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(3, 118)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(316, 330)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Select Which Programs to force onto the cores chosen."
        '
        'pclist
        '
        Me.pclist.BackColor = System.Drawing.Color.SkyBlue
        Me.pclist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pclist.FormattingEnabled = True
        Me.pclist.Location = New System.Drawing.Point(3, 16)
        Me.pclist.Name = "pclist"
        Me.pclist.Size = New System.Drawing.Size(310, 288)
        Me.pclist.Sorted = True
        Me.pclist.TabIndex = 0
        '
        'rfspcl
        '
        Me.rfspcl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rfspcl.Location = New System.Drawing.Point(3, 304)
        Me.rfspcl.Name = "rfspcl"
        Me.rfspcl.Size = New System.Drawing.Size(310, 23)
        Me.rfspcl.TabIndex = 1
        Me.rfspcl.Text = "Refresh Process List"
        Me.rfspcl.UseVisualStyleBackColor = True
        '
        'CoreBox2
        '
        Me.CoreBox2.BackColor = System.Drawing.Color.SkyBlue
        Me.CoreBox2.Controls.Add(Me.cs)
        Me.CoreBox2.Controls.Add(Me.fcp2)
        Me.CoreBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.CoreBox2.Location = New System.Drawing.Point(3, 3)
        Me.CoreBox2.Name = "CoreBox2"
        Me.CoreBox2.Size = New System.Drawing.Size(316, 115)
        Me.CoreBox2.TabIndex = 1
        Me.CoreBox2.TabStop = False
        Me.CoreBox2.Text = "Select Cores to Use -Doing Nothing"
        '
        'cs
        '
        Me.cs.BackColor = System.Drawing.Color.SkyBlue
        Me.cs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cs.FormattingEnabled = True
        Me.cs.Location = New System.Drawing.Point(3, 16)
        Me.cs.MultiColumn = True
        Me.cs.Name = "cs"
        Me.cs.Size = New System.Drawing.Size(310, 73)
        Me.cs.TabIndex = 0
        '
        'fcp2
        '
        Me.fcp2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.fcp2.Location = New System.Drawing.Point(3, 89)
        Me.fcp2.Name = "fcp2"
        Me.fcp2.Size = New System.Drawing.Size(310, 23)
        Me.fcp2.TabIndex = 1
        Me.fcp2.Text = "Force Checked Processes"
        Me.fcp2.UseVisualStyleBackColor = True
        '
        'ProcessChanger
        '
        Me.ProcessChanger.WorkerReportsProgress = True
        '
        'ProcessChanger2
        '
        Me.ProcessChanger2.WorkerReportsProgress = True
        '
        'ProcessChanger3
        '
        Me.ProcessChanger3.WorkerReportsProgress = True
        '
        'MCBW
        '
        Me.MCBW.WorkerReportsProgress = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(330, 477)
        Me.Controls.Add(Me.TabControl1)
        Me.MinimumSize = New System.Drawing.Size(346, 516)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control My Cores"
        CType(Me.fss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.CoreBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fss As System.Windows.Forms.TrackBar
    Friend WithEvents singlecoreval As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents scpl As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rfpl1 As System.Windows.Forms.Button
    Friend WithEvents CoreBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cs As System.Windows.Forms.CheckedListBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents pclist As System.Windows.Forms.CheckedListBox
    Friend WithEvents rfspcl As System.Windows.Forms.Button
    Friend WithEvents fcp2 As System.Windows.Forms.Button
    Friend WithEvents ProcessChanger As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProcessChanger2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProcessChanger3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ReportLbl As System.Windows.Forms.Label
    Friend WithEvents MCBW As System.ComponentModel.BackgroundWorker

End Class
