<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shutdown
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Shutdown))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label_Operation = New System.Windows.Forms.Label()
        Me.AbortButton = New System.Windows.Forms.Button()
        Me.ShutdownButton = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbLogoff = New System.Windows.Forms.RadioButton()
        Me.rbHibernate = New System.Windows.Forms.RadioButton()
        Me.rbSleep = New System.Windows.Forms.RadioButton()
        Me.rbShutdown = New System.Windows.Forms.RadioButton()
        Me.shut_reboot = New System.Windows.Forms.CheckBox()
        Me.shut_force = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label_Message = New System.Windows.Forms.Label()
        Me.shut_message = New System.Windows.Forms.TextBox()
        Me.shut_timeout = New System.Windows.Forms.TextBox()
        Me.Label_Timeout = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.pre_timer = New System.Windows.Forms.Timer(Me.components)
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        resources.ApplyResources(Me.SplitContainer1, "SplitContainer1")
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        resources.ApplyResources(Me.SplitContainer1.Panel1, "SplitContainer1.Panel1")
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListView1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ProgressBar1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_Operation)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AbortButton)
        Me.toolTip.SetToolTip(Me.SplitContainer1.Panel1, resources.GetString("SplitContainer1.Panel1.ToolTip"))
        '
        'SplitContainer1.Panel2
        '
        resources.ApplyResources(Me.SplitContainer1.Panel2, "SplitContainer1.Panel2")
        Me.SplitContainer1.Panel2.Controls.Add(Me.ShutdownButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Cancel_Button)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.toolTip.SetToolTip(Me.SplitContainer1.Panel2, resources.GetString("SplitContainer1.Panel2.ToolTip"))
        Me.toolTip.SetToolTip(Me.SplitContainer1, resources.GetString("SplitContainer1.ToolTip"))
        '
        'ListView1
        '
        resources.ApplyResources(Me.ListView1, "ListView1")
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowGroups = False
        Me.ListView1.ShowItemToolTips = True
        Me.toolTip.SetToolTip(Me.ListView1, resources.GetString("ListView1.ToolTip"))
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        resources.ApplyResources(Me.ColumnHeader1, "ColumnHeader1")
        '
        'ColumnHeader2
        '
        resources.ApplyResources(Me.ColumnHeader2, "ColumnHeader2")
        '
        'ProgressBar1
        '
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        Me.ProgressBar1.Maximum = 0
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.toolTip.SetToolTip(Me.ProgressBar1, resources.GetString("ProgressBar1.ToolTip"))
        '
        'Label_Operation
        '
        resources.ApplyResources(Me.Label_Operation, "Label_Operation")
        Me.Label_Operation.Name = "Label_Operation"
        Me.toolTip.SetToolTip(Me.Label_Operation, resources.GetString("Label_Operation.ToolTip"))
        '
        'AbortButton
        '
        resources.ApplyResources(Me.AbortButton, "AbortButton")
        Me.AbortButton.Name = "AbortButton"
        Me.toolTip.SetToolTip(Me.AbortButton, resources.GetString("AbortButton.ToolTip"))
        Me.AbortButton.UseVisualStyleBackColor = True
        '
        'ShutdownButton
        '
        resources.ApplyResources(Me.ShutdownButton, "ShutdownButton")
        Me.ShutdownButton.Name = "ShutdownButton"
        Me.toolTip.SetToolTip(Me.ShutdownButton, resources.GetString("ShutdownButton.ToolTip"))
        Me.ShutdownButton.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        resources.ApplyResources(Me.Cancel_Button, "Cancel_Button")
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.toolTip.SetToolTip(Me.Cancel_Button, resources.GetString("Cancel_Button.ToolTip"))
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.rbLogoff)
        Me.GroupBox1.Controls.Add(Me.rbHibernate)
        Me.GroupBox1.Controls.Add(Me.rbSleep)
        Me.GroupBox1.Controls.Add(Me.rbShutdown)
        Me.GroupBox1.Controls.Add(Me.shut_reboot)
        Me.GroupBox1.Controls.Add(Me.shut_force)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label_Message)
        Me.GroupBox1.Controls.Add(Me.shut_message)
        Me.GroupBox1.Controls.Add(Me.shut_timeout)
        Me.GroupBox1.Controls.Add(Me.Label_Timeout)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        Me.toolTip.SetToolTip(Me.GroupBox1, resources.GetString("GroupBox1.ToolTip"))
        '
        'rbLogoff
        '
        resources.ApplyResources(Me.rbLogoff, "rbLogoff")
        Me.rbLogoff.Name = "rbLogoff"
        Me.rbLogoff.TabStop = True
        Me.toolTip.SetToolTip(Me.rbLogoff, resources.GetString("rbLogoff.ToolTip"))
        Me.rbLogoff.UseVisualStyleBackColor = True
        '
        'rbHibernate
        '
        resources.ApplyResources(Me.rbHibernate, "rbHibernate")
        Me.rbHibernate.Name = "rbHibernate"
        Me.rbHibernate.TabStop = True
        Me.toolTip.SetToolTip(Me.rbHibernate, resources.GetString("rbHibernate.ToolTip"))
        Me.rbHibernate.UseVisualStyleBackColor = True
        '
        'rbSleep
        '
        resources.ApplyResources(Me.rbSleep, "rbSleep")
        Me.rbSleep.Name = "rbSleep"
        Me.rbSleep.TabStop = True
        Me.toolTip.SetToolTip(Me.rbSleep, resources.GetString("rbSleep.ToolTip"))
        Me.rbSleep.UseVisualStyleBackColor = True
        '
        'rbShutdown
        '
        resources.ApplyResources(Me.rbShutdown, "rbShutdown")
        Me.rbShutdown.Name = "rbShutdown"
        Me.rbShutdown.TabStop = True
        Me.toolTip.SetToolTip(Me.rbShutdown, resources.GetString("rbShutdown.ToolTip"))
        Me.rbShutdown.UseVisualStyleBackColor = True
        '
        'shut_reboot
        '
        resources.ApplyResources(Me.shut_reboot, "shut_reboot")
        Me.shut_reboot.Checked = True
        Me.shut_reboot.CheckState = System.Windows.Forms.CheckState.Checked
        Me.shut_reboot.Name = "shut_reboot"
        Me.toolTip.SetToolTip(Me.shut_reboot, resources.GetString("shut_reboot.ToolTip"))
        '
        'shut_force
        '
        resources.ApplyResources(Me.shut_force, "shut_force")
        Me.shut_force.Name = "shut_force"
        Me.toolTip.SetToolTip(Me.shut_force, resources.GetString("shut_force.ToolTip"))
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        Me.toolTip.SetToolTip(Me.Label15, resources.GetString("Label15.ToolTip"))
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        Me.toolTip.SetToolTip(Me.Label16, resources.GetString("Label16.ToolTip"))
        '
        'Label_Message
        '
        resources.ApplyResources(Me.Label_Message, "Label_Message")
        Me.Label_Message.Name = "Label_Message"
        Me.toolTip.SetToolTip(Me.Label_Message, resources.GetString("Label_Message.ToolTip"))
        '
        'shut_message
        '
        resources.ApplyResources(Me.shut_message, "shut_message")
        Me.shut_message.Name = "shut_message"
        Me.toolTip.SetToolTip(Me.shut_message, resources.GetString("shut_message.ToolTip"))
        '
        'shut_timeout
        '
        resources.ApplyResources(Me.shut_timeout, "shut_timeout")
        Me.shut_timeout.Name = "shut_timeout"
        Me.toolTip.SetToolTip(Me.shut_timeout, resources.GetString("shut_timeout.ToolTip"))
        '
        'Label_Timeout
        '
        resources.ApplyResources(Me.Label_Timeout, "Label_Timeout")
        Me.Label_Timeout.Name = "Label_Timeout"
        Me.toolTip.SetToolTip(Me.Label_Timeout, resources.GetString("Label_Timeout.ToolTip"))
        '
        'timer
        '
        Me.timer.Interval = 1000
        '
        'pre_timer
        '
        Me.pre_timer.Interval = 1000
        '
        'toolTip
        '
        Me.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        '
        'Shutdown
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Shutdown"
        Me.toolTip.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AbortButton As System.Windows.Forms.Button
    Friend WithEvents Label_Operation As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents timer As System.Windows.Forms.Timer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label_Message As System.Windows.Forms.Label
    Friend WithEvents shut_message As System.Windows.Forms.TextBox
    Friend WithEvents shut_timeout As System.Windows.Forms.TextBox
    Friend WithEvents Label_Timeout As System.Windows.Forms.Label
    Friend WithEvents shut_reboot As System.Windows.Forms.CheckBox
    Friend WithEvents shut_force As System.Windows.Forms.CheckBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ShutdownButton As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents rbHibernate As System.Windows.Forms.RadioButton
    Friend WithEvents rbSleep As System.Windows.Forms.RadioButton
    Friend WithEvents rbShutdown As System.Windows.Forms.RadioButton
    Friend WithEvents pre_timer As System.Windows.Forms.Timer
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents rbLogoff As System.Windows.Forms.RadioButton
End Class
