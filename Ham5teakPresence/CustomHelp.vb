Imports DiscordRPC
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace Ham5teakPresence
	Partial Public Class CustomHelp
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub


		Private Sub linkLabel1_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked
			System.Diagnostics.Process.Start("https://discord.com/developers/applications")
		End Sub


		Protected Overrides Sub OnShown(ByVal e As EventArgs)

			If My.Settings.Default.dark = True Then
				ApplyTheme(Color.FromArgb(34, 34, 34), Color.FromArgb(56, 56, 56), Color.FromArgb(242, 240, 219), Color.FromArgb(56, 56, 56))

			Else

				ApplyTheme(Color.FromArgb(244, 244, 244), Color.FromArgb(225, 225, 225), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255))

			End If

		End Sub

		Private Sub ApplyTheme(ByVal back As Color, ByVal btn As Color, ByVal TextColor As Color, ByVal menu As Color)

			Me.BackColor = back
			label1.ForeColor = TextColor
			label2.ForeColor = TextColor
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

		End Sub

		Private privateClient As DiscordRpcClient
		Public Property Client() As DiscordRpcClient
			Get
				Return privateClient
			End Get
			Private Set(ByVal value As DiscordRpcClient)
				privateClient = value
			End Set
		End Property
		Private Sub label3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles label3.Click

		End Sub
	End Class
End Namespace
