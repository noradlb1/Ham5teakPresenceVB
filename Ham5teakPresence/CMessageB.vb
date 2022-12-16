Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace Ham5teakPresence
	Partial Public Class CMessageB
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub label1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles label1.Click

		End Sub

		Private Sub CMessageB_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub


		Protected Overrides Sub OnShown(ByVal e As EventArgs)

			If My.Settings.Default.dark = True Then

				button1.TabStop = True
				button1.FlatStyle = FlatStyle.Flat
				button1.FlatAppearance.BorderSize = 0
				ApplyTheme(Color.FromArgb(34, 34, 34), Color.FromArgb(56, 56, 56), Color.FromArgb(242, 240, 219), Color.FromArgb(56, 56, 56))

			Else

				ApplyTheme(Color.FromArgb(244, 244, 244), Color.FromArgb(225, 225, 225), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255))

			End If

		End Sub

		Private Sub ApplyTheme(ByVal back As Color, ByVal btn As Color, ByVal TextColor As Color, ByVal menu As Color)

			Me.BackColor = back
			label1.ForeColor = TextColor
			button1.BackColor = btn
			button1.ForeColor = TextColor

		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Me.Close()
		End Sub
	End Class
End Namespace
