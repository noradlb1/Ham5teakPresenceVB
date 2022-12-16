Namespace Ham5teakPresence
	Partial Public Class CMessageB
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CMessageB))
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.button1 = New System.Windows.Forms.Button()
			DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pictureBox1
			' 
			Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.pictureBox1.Image = (DirectCast(resources.GetObject("pictureBox1.Image"), System.Drawing.Image))
			Me.pictureBox1.Location = New System.Drawing.Point(95, 15)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(246, 193)
			Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
			Me.pictureBox1.TabIndex = 0
			Me.pictureBox1.TabStop = False
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(76, 227)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(286, 13)
			Me.label1.TabIndex = 1
			Me.label1.Text = "The presence should be looking like the image seen above"
'			Me.label1.Click += New System.EventHandler(Me.label1_Click)
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.ForeColor = System.Drawing.Color.Crimson
			Me.label2.Location = New System.Drawing.Point(105, 246)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(225, 26)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Make sure to have game activity enabled from" & ControlChars.CrLf & "discord settings before applying th" & "e presence!"
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(173, 290)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(75, 23)
			Me.button1.TabIndex = 3
			Me.button1.Text = "OK"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' CMessageB
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(424, 325)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.pictureBox1)
			Me.MaximizeBox = False
			Me.MaximumSize = New System.Drawing.Size(440, 364)
			Me.MinimizeBox = False
			Me.MinimumSize = New System.Drawing.Size(440, 364)
			Me.Name = "CMessageB"
			Me.ShowIcon = False
			Me.Text = "Help"
'			Me.Load += New System.EventHandler(Me.CMessageB_Load)
			DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private WithEvents label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private WithEvents button1 As System.Windows.Forms.Button
	End Class
End Namespace