Imports DiscordRPC
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace Ham5teakPresence
	Partial Public Class Custom
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private inita As Boolean = False
'INSTANT VB NOTE: The variable enabled was renamed since Visual Basic does not allow variables and other class members to have the same name:
		Private enabled_Renamed As Boolean = False

		Private privateClient As DiscordRpcClient
		Public Property Client() As DiscordRpcClient
			Get
				Return privateClient
			End Get
			Private Set(ByVal value As DiscordRpcClient)
				privateClient = value
			End Set
		End Property

		Private Sub Custom_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

			' loads the last form entries from settings, will apply default if none has been applied yet

			textBox1.Text = My.Settings.Default.appid
			detailsbox.Text = My.Settings.Default.details
			statusbox.Text = My.Settings.Default.status
			largeimagetextbox.Text = My.Settings.Default.lit
			largeimagekeybox.Text = My.Settings.Default.lik
			smallimagetextbox.Text = My.Settings.Default.sit
			smallimagekeybox.Text = My.Settings.Default.sik
			button1url.Text = My.Settings.Default.b1u
			button1text.Text = My.Settings.Default.b1t
			button2url.Text = My.Settings.Default.b2u
			button2text.Text = My.Settings.Default.b2t

		End Sub


		Protected Overrides Sub OnShown(ByVal e As EventArgs)

			If My.Settings.Default.dark = True Then

				button1.TabStop = True
				button1.FlatStyle = FlatStyle.Flat
				button1.FlatAppearance.BorderSize = 0
				button2.TabStop = True
				button2.FlatStyle = FlatStyle.Flat
				button2.FlatAppearance.BorderSize = 0
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
			label1.ForeColor = TextColor
			label3.ForeColor = TextColor
			label4.ForeColor = TextColor
			label5.ForeColor = TextColor
			label6.ForeColor = TextColor
			label7.ForeColor = TextColor
			label8.ForeColor = TextColor
			label9.ForeColor = TextColor
			label10.ForeColor = TextColor
			label11.ForeColor = TextColor
			label12.ForeColor = TextColor
			label13.ForeColor = TextColor
			label14.ForeColor = TextColor
			button1.BackColor = btn
			button1.ForeColor = TextColor
			button2.BackColor = btn
			button2.ForeColor = TextColor
			button3.BackColor = btn
			button3.ForeColor = TextColor

		End Sub


		Private Sub label6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles label6.Click

		End Sub

		Private Sub label8_Click(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			Dim form = Application.OpenForms("CustomHelp")
			If form IsNot Nothing Then
				form = New CustomHelp()
				Return
			End If
			Dim chelpBox As New CustomHelp()
			chelpBox.Show()
		End Sub

		Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles textBox1.TextChanged

		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click

			' Defining boxes


			Dim appid As String
			appid = textBox1.Text
			Dim details As String
			details = detailsbox.Text
			Dim status As String
			status = statusbox.Text
			Dim lik As String
			lik = largeimagekeybox.Text
			Dim lit As String
			lit = largeimagetextbox.Text
			Dim sik As String
			sik = smallimagekeybox.Text
			Dim sit As String
			sit = smallimagetextbox.Text
			Dim b1t As String
			b1t = button1text.Text
			Dim b1u As String
			b1u = button1url.Text
			Dim b2t As String
			b2t = button2text.Text
			Dim b2u As String
			b2u = button2url.Text


			' Checks and applying of presence

			If enabled_Renamed <> False Then
				Dim message1 As String = "Presence is already applied."
				Dim title1 As String = "Custom Presence"
				MessageBox.Show(message1, title1)
			ElseIf String.IsNullOrEmpty(appid) Then

				Dim message1 As String = "Application ID must be entered."
				Dim title1 As String = "Custom Presence"
				MessageBox.Show(message1, title1)
			ElseIf (Not String.IsNullOrEmpty(b2u)) AndAlso (Not String.IsNullOrEmpty(b1u)) Then
				enabled_Renamed = True
				inita = True
				Client = New DiscordRpcClient(appid)
				Client.Initialize()
				Client.SetPresence(New RichPresence() With {.Details = details, .State = status, .Assets = New Assets() With {.LargeImageKey = lik, .LargeImageText = lit, .SmallImageKey = sik, .SmallImageText = sit}, .Buttons = New DiscordRPC.Button() { New DiscordRPC.Button() With {.Label = b1t, .Url = b1u}, New DiscordRPC.Button() With {.Label = b2t, .Url = b2u} }})
				Dim message As String = "Presence has been applied."
				Dim title As String = "Custom Presence"
				MessageBox.Show(message, title)
			ElseIf String.IsNullOrEmpty(b2u) AndAlso String.IsNullOrEmpty(b1u) Then
				enabled_Renamed = True
				inita = True
				Client = New DiscordRpcClient(appid)
				Client.Initialize()
				Client.SetPresence(New RichPresence() With {.Details = details, .State = status, .Assets = New Assets() With {.LargeImageKey = lik, .LargeImageText = lit, .SmallImageKey = sik, .SmallImageText = sit}})
				Dim message As String = "Presence has been applied."
				Dim title As String = "Custom Presence"
				MessageBox.Show(message, title)
			ElseIf (Not String.IsNullOrEmpty(b2u)) AndAlso String.IsNullOrEmpty(b1u) Then
				enabled_Renamed = True
				inita = True
				Client = New DiscordRpcClient(appid)
				Client.Initialize()
				Client.SetPresence(New RichPresence() With {.Details = details, .State = status, .Assets = New Assets() With {.LargeImageKey = lik, .LargeImageText = lit, .SmallImageKey = sik, .SmallImageText = sit}, .Buttons = New DiscordRPC.Button() { New DiscordRPC.Button() With {.Label = b2t, .Url = b2u} }})
				Dim message As String = "Presence has been applied."
				Dim title As String = "Custom Presence"
				MessageBox.Show(message, title)
			ElseIf String.IsNullOrEmpty(b2u) AndAlso (Not String.IsNullOrEmpty(b1u)) Then
				enabled_Renamed = True
				inita = True
				Client = New DiscordRpcClient(appid)
				Client.Initialize()
				Client.SetPresence(New RichPresence() With {.Details = details, .State = status, .Assets = New Assets() With {.LargeImageKey = lik, .LargeImageText = lit, .SmallImageKey = sik, .SmallImageText = sit}, .Buttons = New DiscordRPC.Button() { New DiscordRPC.Button() With {.Label = b1t, .Url = b1u} }})
				Dim message As String = "Presence has been applied."
				Dim title As String = "Custom Presence"
				MessageBox.Show(message, title)
			End If

			' Form events in general


			' Saves the entries to settings

			My.Settings.Default.appid = textBox1.Text
			My.Settings.Default.details = detailsbox.Text
			My.Settings.Default.status = statusbox.Text
			My.Settings.Default.lit = largeimagetextbox.Text
			My.Settings.Default.lik = largeimagekeybox.Text
			My.Settings.Default.sit = smallimagetextbox.Text
			My.Settings.Default.sik = smallimagekeybox.Text
			My.Settings.Default.b1u = button1url.Text
			My.Settings.Default.b1t = button1text.Text
			My.Settings.Default.b2u = button2url.Text
			My.Settings.Default.b2t = button2text.Text
			My.Settings.Default.Save()
			My.Settings.Default.Reload()

			' disables close button as long as the presence is running
			Me.ControlBox = False
		End Sub

		Private Sub detailsbox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles detailsbox.TextChanged

		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click

			If inita = True Then
				enabled_Renamed = False
				Client.Dispose()
				Me.ControlBox = True ' re-enables close button
				inita = False
				Dim message2 As String = "Presence has been removed."
				Dim title2 As String = "Custom Presence"
				MessageBox.Show(message2, title2)
			Else
				Dim message As String = "Please apply a presence first."
				Dim title As String = "Custom Presence"
				MessageBox.Show(message, title)
			End If
		End Sub

		Private Sub linkLabel1_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked
			System.Diagnostics.Process.Start("https://github.com/noradlb1")
		End Sub
	End Class
End Namespace
