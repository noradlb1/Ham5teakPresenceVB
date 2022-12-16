Imports DiscordRPC
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.Win32

Namespace Ham5teakPresence
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			notifyIcon1.ContextMenuStrip = contextMenuStrip1
			AddHandler FormClosing, AddressOf FormIsClosing
			AddHandler notifyIcon1.Click, AddressOf notifyIcon1_Click
		End Sub
		Private Sub notifyIcon1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Me.Activate()
			Me.Show()
		End Sub

		Private Sub FormIsClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
			If yesToolStripMenuItem.Checked = True AndAlso e.CloseReason = CloseReason.UserClosing Then

				e.Cancel = True
				Me.Hide()


			End If
		End Sub

		Public Class RendererEx
			Inherits ToolStripProfessionalRenderer

			Protected Overrides Sub OnRenderMenuItemBackground(ByVal e As ToolStripItemRenderEventArgs)
				e.Item.BackColor = Color.FromArgb(45, 45, 48)
			End Sub

		End Class
		Private inita As Boolean = False

		Private privateClient As DiscordRpcClient
		Public Property Client() As DiscordRpcClient
			Get
				Return privateClient
			End Get
			Private Set(ByVal value As DiscordRpcClient)
				privateClient = value
			End Set
		End Property

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)

			yesToolStripMenuItem.Checked = My.Settings.Default.yes
			noToolStripMenuItem.Checked = My.Settings.Default.no
			darkModeToolStripMenuItem.Checked = My.Settings.Default.dark
			lightModeToolStripMenuItem.Checked = My.Settings.Default.light
			yesToolStripMenuItem1.Checked = My.Settings.Default.Enabled
			noToolStripMenuItem1.Checked = My.Settings.Default.Disabled

		End Sub

		Protected Overrides Sub OnShown(ByVal e As EventArgs)

			If My.Settings.Default.Enabled = True Then


				Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
				key.SetValue("Ham5teakPresence", Application.ExecutablePath)

			ElseIf My.Settings.Default.Disabled = True Then

				Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
				key.DeleteValue("Ham5teakPresence", False)
			End If

			If My.Settings.Default.dark = True Then

				button1.TabStop = True
				button1.FlatStyle = FlatStyle.Flat
				button1.FlatAppearance.BorderSize = 0
				button2.TabStop = True
				button2.FlatStyle = FlatStyle.Flat
				button2.FlatAppearance.BorderSize = 0
				button4.TabStop = True
				button4.FlatStyle = FlatStyle.Flat
				button4.FlatAppearance.BorderSize = 0
				button3.TabStop = True
				button3.FlatStyle = FlatStyle.Flat
				button3.FlatAppearance.BorderSize = 0
				ApplyTheme(Color.FromArgb(34, 34, 34), Color.FromArgb(56, 56, 56), Color.FromArgb(242, 240, 219), Color.FromArgb(56, 56, 56))

			Else

				ApplyTheme(Color.FromArgb(244, 244, 244), Color.FromArgb(225, 225, 225), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255))

			End If

		End Sub

		Private Sub ApplyTheme(ByVal back As Color, ByVal btn As Color, ByVal TextColor As Color, ByVal menu As Color)
			Me.BackColor = back
			button1.BackColor = btn
			button1.ForeColor = TextColor
			button1.FlatAppearance.BorderColor = btn
			button2.BackColor = btn
			button2.ForeColor = TextColor
			button2.FlatAppearance.BorderColor = btn
			button3.BackColor = btn
			button3.ForeColor = TextColor
			button3.FlatAppearance.BorderColor = btn
			button4.BackColor = btn
			button4.ForeColor = TextColor
			button4.FlatAppearance.BorderColor = btn
			menuStrip1.Renderer = New RendererEx()
			Me.menuStrip1.BackColor = menu
			Me.menuStrip1.ForeColor = TextColor
			Me.settingsToolStripMenuItem.ForeColor = TextColor
			Me.settingsToolStripMenuItem.BackColor = menu
			Me.helpToolStripMenuItem.ForeColor = TextColor
			Me.helpToolStripMenuItem.BackColor = menu
			button1.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255)
			button2.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255)
			button3.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255)
			button4.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255)

		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim customform = Application.OpenForms("Custom")
			If inita <> False Then
				Dim message1 As String = "Presence is already applied."
				Dim title1 As String = "Ham5teak Presence"
				MessageBox.Show(message1, title1)
			ElseIf customform IsNot Nothing Then
				Dim message As String = "Please close the Custom Presence application first."
				Dim title As String = "Ham5teak Presence"
				MessageBox.Show(message, title)
				Return
			Else
				inita = True
				Client = New DiscordRpcClient("833302091790417920")
				Client.Initialize()
				Client.SetPresence(New RichPresence() With {.Details = "", .State = "SG Cracked Minecraft Server", .Assets = New Assets() With {.LargeImageKey = "icon", .LargeImageText = "Ham5teak", .SmallImageKey = ""}, .Buttons = New DiscordRPC.Button() { New DiscordRPC.Button() With {.Label = "Join Discord", .Url = "https://discord.gg/QNfQmHg"}, New DiscordRPC.Button() With {.Label = "Visit Shop", .Url = "http://shop.ham5teak.xyz/"} }})
				Dim message As String = "Presence has been applied."
				Dim title As String = "Ham5teak Presence"
				MessageBox.Show(message, title)
			End If
		End Sub
		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			If inita = True Then
				Client.Dispose()
				inita = False
				Dim message2 As String = "Presence has been removed."
				Dim title2 As String = "Ham5teak Presence"
				MessageBox.Show(message2, title2)
			Else
				Dim message As String = "Please apply the presence first."
				Dim title As String = "Ham5teak Presence"
				MessageBox.Show(message, title)
			End If
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			Dim form = Application.OpenForms("CMessageB")
			If form IsNot Nothing Then
				form = New CMessageB()
				Return
			End If
			Dim helpBox As New CMessageB()
			helpBox.Show()
		End Sub

		Private Sub linkLabel1_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked
			System.Diagnostics.Process.Start("https://discord.com/developers/docs/rich-presence/how-to")
		End Sub

		Private Sub custom_Click(ByVal sender As Object, ByVal e As EventArgs) Handles custom.Click

			Dim form = Application.OpenForms("Custom")
			If form IsNot Nothing Then
				form = New Custom()
				Return
			End If
			Dim helpBox As New Custom()
			helpBox.Show()
		End Sub

		Private Sub linkLabel2_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles linkLabel2.LinkClicked
			System.Diagnostics.Process.Start("https://discord.com/developers/docs/rich-presence/how-to")
		End Sub

		Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button4.Click
			If inita = True Then

				Dim message As String = "Please remove your current presence first."
				Dim title As String = "Custom Presence"
				MessageBox.Show(message, title)
				Return

			End If
			Dim form = Application.OpenForms("Custom")
			If form IsNot Nothing Then
				form = New Custom()
				Return
			End If
			Dim helpBox As New Custom()
			helpBox.Show()

		End Sub

		Private Sub contextMenuStrip1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)

		End Sub

		Private Sub darkModeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles darkModeToolStripMenuItem.Click
			button1.TabStop = True
			button1.FlatStyle = FlatStyle.Flat
			button1.FlatAppearance.BorderSize = 0
			button2.TabStop = True
			button2.FlatStyle = FlatStyle.Flat
			button2.FlatAppearance.BorderSize = 0
			button4.TabStop = True
			button4.FlatStyle = FlatStyle.Flat
			button4.FlatAppearance.BorderSize = 0
			button3.TabStop = True
			button3.FlatStyle = FlatStyle.Flat
			button3.FlatAppearance.BorderSize = 0
			lightModeToolStripMenuItem.Checked = False
			darkModeToolStripMenuItem.Checked = True
			My.Settings.Default.dark = True
			My.Settings.Default.light = False
			My.Settings.Default.Save()
			My.Settings.Default.Reload()
			ApplyTheme(Color.FromArgb(34, 34, 34), Color.FromArgb(56, 56, 56), Color.FromArgb(242, 240, 219), Color.FromArgb(56, 56, 56))
		End Sub

		Private Sub lightModeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lightModeToolStripMenuItem.Click
			button1.TabStop = True
			button1.FlatStyle = FlatStyle.Standard
			button1.FlatAppearance.BorderSize = 0
			button2.TabStop = True
			button2.FlatStyle = FlatStyle.Standard
			button2.FlatAppearance.BorderSize = 0
			button4.TabStop = True
			button4.FlatStyle = FlatStyle.Standard
			button4.FlatAppearance.BorderSize = 0
			button3.TabStop = True
			button3.FlatStyle = FlatStyle.Standard
			button3.FlatAppearance.BorderSize = 1
			darkModeToolStripMenuItem.Checked = False
			lightModeToolStripMenuItem.Checked = True
			My.Settings.Default.dark = False
			My.Settings.Default.light = True
			My.Settings.Default.Save()
			My.Settings.Default.Reload()
			ApplyTheme(Color.FromArgb(244, 244, 244), Color.FromArgb(225, 225, 225), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255))
		End Sub

		Private Sub yesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles yesToolStripMenuItem.Click
			yesToolStripMenuItem.Checked = True
			noToolStripMenuItem.Checked = False
			My.Settings.Default.yes = True
			My.Settings.Default.no = False
			My.Settings.Default.Save()
			My.Settings.Default.Reload()
		End Sub

		Private Sub noToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles noToolStripMenuItem.Click
			noToolStripMenuItem.Checked = True
			yesToolStripMenuItem.Checked = False
			My.Settings.Default.yes = False
			My.Settings.Default.no = True
			My.Settings.Default.Save()
			My.Settings.Default.Reload()
		End Sub

		Private Sub notifyIcon1_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles notifyIcon1.MouseDoubleClick
			If Me.WindowState = FormWindowState.Minimized Then
				Me.WindowState = FormWindowState.Normal
			End If
			Me.Activate()
		End Sub

		Private Sub openToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles openToolStripMenuItem.Click
			Me.Activate()
			Me.Show()
		End Sub

		Private Sub closeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles closeToolStripMenuItem.Click
			If yesToolStripMenuItem.Checked = True Then
				noToolStripMenuItem.Checked = True
				yesToolStripMenuItem.Checked = False
				Me.Close()
			Else
				Me.Close()
			End If
		End Sub

		Private Sub contextMenuStrip1_Opening_1(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles contextMenuStrip1.Opening

		End Sub

		Private Sub settingsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles settingsToolStripMenuItem.Click

			yesToolStripMenuItem.Checked = My.Settings.Default.yes
			noToolStripMenuItem.Checked = My.Settings.Default.no
			darkModeToolStripMenuItem.Checked = My.Settings.Default.dark
			lightModeToolStripMenuItem.Checked = My.Settings.Default.light
			yesToolStripMenuItem1.Checked = My.Settings.Default.Enabled
			noToolStripMenuItem1.Checked = My.Settings.Default.Disabled

		End Sub

		Private Sub menuStrip1_ItemClicked(ByVal sender As Object, ByVal e As ToolStripItemClickedEventArgs) Handles menuStrip1.ItemClicked

		End Sub

		Private Sub viewGuideToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles viewGuideToolStripMenuItem.Click
			System.Diagnostics.Process.Start("https://github.com/Beastman9095/Ham5teakPresence/wiki/Guide-To-Discord-Rich-Presences#steps")
		End Sub

		Private Sub noToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles noToolStripMenuItem1.Click
			noToolStripMenuItem1.Checked = True
			yesToolStripMenuItem1.Checked = False
			My.Settings.Default.Enabled = False
			My.Settings.Default.Disabled = True
			My.Settings.Default.Save()
			My.Settings.Default.Reload()
			Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
			key.DeleteValue("Ham5teakPresence", False)

		End Sub

		Private Sub yesToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles yesToolStripMenuItem1.Click
			noToolStripMenuItem1.Checked = False
			yesToolStripMenuItem1.Checked = True
			My.Settings.Default.Disabled = False
			My.Settings.Default.Enabled = True
			My.Settings.Default.Save()
			My.Settings.Default.Reload()
			Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
			key.SetValue("Ham5teakPresence", Application.ExecutablePath)
		End Sub

		Private Sub Form1_Load_1(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub
	End Class
End Namespace
