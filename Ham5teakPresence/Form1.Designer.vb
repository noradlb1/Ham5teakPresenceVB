Namespace Ham5teakPresence
	Partial Public Class Form1
		Private components As System.ComponentModel.IContainer = Nothing
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.button3 = New System.Windows.Forms.Button()
			Me.custom = New System.Windows.Forms.Button()
			Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
			Me.button4 = New System.Windows.Forms.Button()
			Me.linkLabel2 = New System.Windows.Forms.LinkLabel()
			Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
			Me.settingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.themeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.darkModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.lightModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.minimizeToTrayOnCloseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.yesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.noToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.viewGuideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.notifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
			Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.closeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.autoStartOnStartupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.yesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.noToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.menuStrip1.SuspendLayout()
			Me.contextMenuStrip1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' button1
			' 
			Me.button1.BackColor = System.Drawing.Color.Transparent
			Me.button1.Location = New System.Drawing.Point(45, 32)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(111, 23)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Update Presence"
			Me.button1.UseVisualStyleBackColor = False
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' button2
			' 
			Me.button2.BackColor = System.Drawing.Color.Transparent
			Me.button2.Location = New System.Drawing.Point(264, 32)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(110, 23)
			Me.button2.TabIndex = 1
			Me.button2.Text = "Remove Presence"
			Me.button2.UseVisualStyleBackColor = False
'			Me.button2.Click += New System.EventHandler(Me.button2_Click)
			' 
			' button3
			' 
			Me.button3.BackColor = System.Drawing.Color.Transparent
			Me.button3.Location = New System.Drawing.Point(171, 32)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(75, 23)
			Me.button3.TabIndex = 2
			Me.button3.Text = "Help"
			Me.button3.UseVisualStyleBackColor = False
'			Me.button3.Click += New System.EventHandler(Me.button3_Click)
			' 
			' custom
			' 
			Me.custom.Location = New System.Drawing.Point(205, 41)
			Me.custom.MaximumSize = New System.Drawing.Size(169, 23)
			Me.custom.MinimumSize = New System.Drawing.Size(169, 23)
			Me.custom.Name = "custom"
			Me.custom.Size = New System.Drawing.Size(169, 23)
			Me.custom.TabIndex = 3
			Me.custom.Text = "Create Your Custom Presence"
			Me.custom.UseVisualStyleBackColor = True
'			Me.custom.Click += New System.EventHandler(Me.custom_Click)
			' 
			' linkLabel1
			' 
			Me.linkLabel1.AutoSize = True
			Me.linkLabel1.Location = New System.Drawing.Point(48, 46)
			Me.linkLabel1.Name = "linkLabel1"
			Me.linkLabel1.Size = New System.Drawing.Size(108, 13)
			Me.linkLabel1.TabIndex = 4
			Me.linkLabel1.TabStop = True
			Me.linkLabel1.Text = "About Rich Presence"
'			Me.linkLabel1.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.linkLabel1_LinkClicked)
			' 
			' button4
			' 
			Me.button4.BackColor = System.Drawing.Color.Transparent
			Me.button4.Location = New System.Drawing.Point(205, 60)
			Me.button4.Name = "button4"
			Me.button4.Size = New System.Drawing.Size(169, 23)
			Me.button4.TabIndex = 3
			Me.button4.Text = "Create Your Custom Presence"
			Me.button4.UseVisualStyleBackColor = False
'			Me.button4.Click += New System.EventHandler(Me.button4_Click)
			' 
			' linkLabel2
			' 
			Me.linkLabel2.AutoSize = True
			Me.linkLabel2.LinkColor = System.Drawing.Color.DodgerBlue
			Me.linkLabel2.Location = New System.Drawing.Point(48, 66)
			Me.linkLabel2.Name = "linkLabel2"
			Me.linkLabel2.Size = New System.Drawing.Size(108, 13)
			Me.linkLabel2.TabIndex = 4
			Me.linkLabel2.TabStop = True
			Me.linkLabel2.Text = "About Rich Presence"
'			Me.linkLabel2.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.linkLabel2_LinkClicked)
			' 
			' menuStrip1
			' 
			Me.menuStrip1.BackColor = System.Drawing.Color.White
			Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.settingsToolStripMenuItem, Me.helpToolStripMenuItem})
			Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
			Me.menuStrip1.Name = "menuStrip1"
			Me.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
			Me.menuStrip1.Size = New System.Drawing.Size(426, 24)
			Me.menuStrip1.TabIndex = 5
			Me.menuStrip1.Text = "menuStrip1"
'			Me.menuStrip1.ItemClicked += New System.Windows.Forms.ToolStripItemClickedEventHandler(Me.menuStrip1_ItemClicked)
			' 
			' settingsToolStripMenuItem
			' 
			Me.settingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.themeToolStripMenuItem1, Me.minimizeToTrayOnCloseToolStripMenuItem1, Me.autoStartOnStartupToolStripMenuItem})
			Me.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem"
			Me.settingsToolStripMenuItem.ShortcutKeys = (CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys))
			Me.settingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
			Me.settingsToolStripMenuItem.Text = "Settings"
'			Me.settingsToolStripMenuItem.Click += New System.EventHandler(Me.settingsToolStripMenuItem_Click)
			' 
			' themeToolStripMenuItem1
			' 
			Me.themeToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.darkModeToolStripMenuItem, Me.lightModeToolStripMenuItem})
			Me.themeToolStripMenuItem1.Name = "themeToolStripMenuItem1"
			Me.themeToolStripMenuItem1.ShortcutKeys = (CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys))
			Me.themeToolStripMenuItem1.ShowShortcutKeys = False
			Me.themeToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
			Me.themeToolStripMenuItem1.Text = "Theme"
			' 
			' darkModeToolStripMenuItem
			' 
			Me.darkModeToolStripMenuItem.Checked = True
			Me.darkModeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
			Me.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem"
			Me.darkModeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
			Me.darkModeToolStripMenuItem.Text = "Dark Mode"
'			Me.darkModeToolStripMenuItem.Click += New System.EventHandler(Me.darkModeToolStripMenuItem_Click)
			' 
			' lightModeToolStripMenuItem
			' 
			Me.lightModeToolStripMenuItem.Name = "lightModeToolStripMenuItem"
			Me.lightModeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
			Me.lightModeToolStripMenuItem.Text = "Light Mode"
'			Me.lightModeToolStripMenuItem.Click += New System.EventHandler(Me.lightModeToolStripMenuItem_Click)
			' 
			' minimizeToTrayOnCloseToolStripMenuItem1
			' 
			Me.minimizeToTrayOnCloseToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.yesToolStripMenuItem, Me.noToolStripMenuItem})
			Me.minimizeToTrayOnCloseToolStripMenuItem1.Name = "minimizeToTrayOnCloseToolStripMenuItem1"
			Me.minimizeToTrayOnCloseToolStripMenuItem1.ShortcutKeys = (CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys))
			Me.minimizeToTrayOnCloseToolStripMenuItem1.ShowShortcutKeys = False
			Me.minimizeToTrayOnCloseToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
			Me.minimizeToTrayOnCloseToolStripMenuItem1.Text = "Minimize To Tray On Close"
			' 
			' yesToolStripMenuItem
			' 
			Me.yesToolStripMenuItem.Name = "yesToolStripMenuItem"
			Me.yesToolStripMenuItem.ShortcutKeys = (CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys))
			Me.yesToolStripMenuItem.ShowShortcutKeys = False
			Me.yesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
			Me.yesToolStripMenuItem.Text = "Yes"
'			Me.yesToolStripMenuItem.Click += New System.EventHandler(Me.yesToolStripMenuItem_Click)
			' 
			' noToolStripMenuItem
			' 
			Me.noToolStripMenuItem.Checked = True
			Me.noToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
			Me.noToolStripMenuItem.Name = "noToolStripMenuItem"
			Me.noToolStripMenuItem.ShortcutKeys = (CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys))
			Me.noToolStripMenuItem.ShowShortcutKeys = False
			Me.noToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
			Me.noToolStripMenuItem.Text = "No"
'			Me.noToolStripMenuItem.Click += New System.EventHandler(Me.noToolStripMenuItem_Click)
			' 
			' helpToolStripMenuItem
			' 
			Me.helpToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
			Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.viewGuideToolStripMenuItem})
			Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
			Me.helpToolStripMenuItem.ShortcutKeys = (CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys))
			Me.helpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
			Me.helpToolStripMenuItem.Text = "Help"
			' 
			' viewGuideToolStripMenuItem
			' 
			Me.viewGuideToolStripMenuItem.Name = "viewGuideToolStripMenuItem"
			Me.viewGuideToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
			Me.viewGuideToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.viewGuideToolStripMenuItem.Text = "View Guide"
'			Me.viewGuideToolStripMenuItem.Click += New System.EventHandler(Me.viewGuideToolStripMenuItem_Click)
			' 
			' notifyIcon1
			' 
			Me.notifyIcon1.Icon = (DirectCast(resources.GetObject("notifyIcon1.Icon"), System.Drawing.Icon))
			Me.notifyIcon1.Text = "Ham5teak Presence"
			Me.notifyIcon1.Visible = True
'			Me.notifyIcon1.MouseDoubleClick += New System.Windows.Forms.MouseEventHandler(Me.notifyIcon1_MouseDoubleClick)
			' 
			' contextMenuStrip1
			' 
			Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.openToolStripMenuItem, Me.closeToolStripMenuItem})
			Me.contextMenuStrip1.Name = "contextMenuStrip1"
			Me.contextMenuStrip1.Size = New System.Drawing.Size(104, 48)
'			Me.contextMenuStrip1.Opening += New System.ComponentModel.CancelEventHandler(Me.contextMenuStrip1_Opening_1)
			' 
			' openToolStripMenuItem
			' 
			Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
			Me.openToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
			Me.openToolStripMenuItem.Text = "Open"
'			Me.openToolStripMenuItem.Click += New System.EventHandler(Me.openToolStripMenuItem_Click)
			' 
			' closeToolStripMenuItem
			' 
			Me.closeToolStripMenuItem.Name = "closeToolStripMenuItem"
			Me.closeToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
			Me.closeToolStripMenuItem.Text = "Close"
'			Me.closeToolStripMenuItem.Click += New System.EventHandler(Me.closeToolStripMenuItem_Click)
			' 
			' autoStartOnStartupToolStripMenuItem
			' 
			Me.autoStartOnStartupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.yesToolStripMenuItem1, Me.noToolStripMenuItem1})
			Me.autoStartOnStartupToolStripMenuItem.Name = "autoStartOnStartupToolStripMenuItem"
			Me.autoStartOnStartupToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
			Me.autoStartOnStartupToolStripMenuItem.Text = "Auto-Start On Startup"
			' 
			' yesToolStripMenuItem1
			' 
			Me.yesToolStripMenuItem1.Name = "yesToolStripMenuItem1"
			Me.yesToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
			Me.yesToolStripMenuItem1.Text = "Enabled"
'			Me.yesToolStripMenuItem1.Click += New System.EventHandler(Me.yesToolStripMenuItem1_Click)
			' 
			' noToolStripMenuItem1
			' 
			Me.noToolStripMenuItem1.Name = "noToolStripMenuItem1"
			Me.noToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
			Me.noToolStripMenuItem1.Text = "Disabled"
'			Me.noToolStripMenuItem1.Click += New System.EventHandler(Me.noToolStripMenuItem1_Click)
			' 
			' Form1
			' 
			Me.AllowDrop = True
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(426, 96)
			Me.Controls.Add(Me.menuStrip1)
			Me.Controls.Add(Me.linkLabel2)
			Me.Controls.Add(Me.button4)
			Me.Controls.Add(Me.button3)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.HelpButton = True
			Me.Icon = (DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MainMenuStrip = Me.menuStrip1
			Me.MaximizeBox = False
			Me.MaximumSize = New System.Drawing.Size(442, 135)
			Me.MinimumSize = New System.Drawing.Size(442, 135)
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Ham5teak Presence"
'			Me.Load += New System.EventHandler(Me.Form1_Load_1)
			Me.menuStrip1.ResumeLayout(False)
			Me.menuStrip1.PerformLayout()
			Me.contextMenuStrip1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private WithEvents button3 As System.Windows.Forms.Button
		Private WithEvents custom As System.Windows.Forms.Button
		Private WithEvents linkLabel1 As System.Windows.Forms.LinkLabel
		Private WithEvents button4 As System.Windows.Forms.Button
		Private WithEvents linkLabel2 As System.Windows.Forms.LinkLabel
		Private WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
		Private WithEvents settingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private themeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents darkModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents lightModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private minimizeToTrayOnCloseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents yesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents noToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents viewGuideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents notifyIcon1 As System.Windows.Forms.NotifyIcon
		Private WithEvents contextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
		Private WithEvents openToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents closeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private autoStartOnStartupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents yesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents noToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	End Class
End Namespace

