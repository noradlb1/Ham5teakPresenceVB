Namespace Ham5teakPresence
	Partial Public Class Custom
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Custom))
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.detailsbox = New System.Windows.Forms.TextBox()
			Me.statusbox = New System.Windows.Forms.TextBox()
			Me.button1text = New System.Windows.Forms.TextBox()
			Me.button1url = New System.Windows.Forms.TextBox()
			Me.button2url = New System.Windows.Forms.TextBox()
			Me.button2text = New System.Windows.Forms.TextBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.label6 = New System.Windows.Forms.Label()
			Me.label7 = New System.Windows.Forms.Label()
			Me.label8 = New System.Windows.Forms.Label()
			Me.label9 = New System.Windows.Forms.Label()
			Me.label10 = New System.Windows.Forms.Label()
			Me.smallimagekeybox = New System.Windows.Forms.TextBox()
			Me.largeimagetextbox = New System.Windows.Forms.TextBox()
			Me.largeimagekeybox = New System.Windows.Forms.TextBox()
			Me.label11 = New System.Windows.Forms.Label()
			Me.smallimagetextbox = New System.Windows.Forms.TextBox()
			Me.label12 = New System.Windows.Forms.Label()
			Me.label13 = New System.Windows.Forms.Label()
			Me.label14 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.button3 = New System.Windows.Forms.Button()
			Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
			Me.SuspendLayout()
			' 
			' textBox1
			' 
			Me.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
			Me.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
			Me.textBox1.Location = New System.Drawing.Point(19, 12)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(100, 20)
			Me.textBox1.TabIndex = 0
'			Me.textBox1.TextChanged += New System.EventHandler(Me.textBox1_TextChanged)
			' 
			' detailsbox
			' 
			Me.detailsbox.Location = New System.Drawing.Point(19, 38)
			Me.detailsbox.Name = "detailsbox"
			Me.detailsbox.Size = New System.Drawing.Size(100, 20)
			Me.detailsbox.TabIndex = 1
'			Me.detailsbox.TextChanged += New System.EventHandler(Me.detailsbox_TextChanged)
			' 
			' statusbox
			' 
			Me.statusbox.Location = New System.Drawing.Point(19, 64)
			Me.statusbox.Name = "statusbox"
			Me.statusbox.Size = New System.Drawing.Size(100, 20)
			Me.statusbox.TabIndex = 2
			' 
			' button1text
			' 
			Me.button1text.Location = New System.Drawing.Point(29, 219)
			Me.button1text.Name = "button1text"
			Me.button1text.Size = New System.Drawing.Size(100, 20)
			Me.button1text.TabIndex = 4
			' 
			' button1url
			' 
			Me.button1url.Location = New System.Drawing.Point(29, 264)
			Me.button1url.Name = "button1url"
			Me.button1url.Size = New System.Drawing.Size(100, 20)
			Me.button1url.TabIndex = 5
			' 
			' button2url
			' 
			Me.button2url.Location = New System.Drawing.Point(297, 264)
			Me.button2url.Name = "button2url"
			Me.button2url.Size = New System.Drawing.Size(100, 20)
			Me.button2url.TabIndex = 7
			' 
			' button2text
			' 
			Me.button2text.Location = New System.Drawing.Point(297, 219)
			Me.button2text.Name = "button2text"
			Me.button2text.Size = New System.Drawing.Size(100, 20)
			Me.button2text.TabIndex = 6
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(47, 203)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(62, 13)
			Me.label3.TabIndex = 10
			Me.label3.Text = "Button Text"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(48, 248)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(63, 13)
			Me.label4.TabIndex = 11
			Me.label4.Text = "Button URL"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(125, 15)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(73, 13)
			Me.label5.TabIndex = 12
			Me.label5.Text = "Application ID"
			Me.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(125, 41)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(39, 13)
			Me.label6.TabIndex = 13
			Me.label6.Text = "Details"
'			Me.label6.Click += New System.EventHandler(Me.label6_Click)
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Location = New System.Drawing.Point(125, 67)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(37, 13)
			Me.label7.TabIndex = 14
			Me.label7.Text = "Status"
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New System.Drawing.Point(321, 67)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(85, 13)
			Me.label8.TabIndex = 20
			Me.label8.Text = "Small Image Key"
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Location = New System.Drawing.Point(321, 41)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(90, 13)
			Me.label9.TabIndex = 19
			Me.label9.Text = "Large Image Text"
			' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.Location = New System.Drawing.Point(321, 15)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(87, 13)
			Me.label10.TabIndex = 18
			Me.label10.Text = "Large Image Key"
			Me.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft
			' 
			' smallimagekeybox
			' 
			Me.smallimagekeybox.Location = New System.Drawing.Point(215, 64)
			Me.smallimagekeybox.Name = "smallimagekeybox"
			Me.smallimagekeybox.Size = New System.Drawing.Size(100, 20)
			Me.smallimagekeybox.TabIndex = 17
			' 
			' largeimagetextbox
			' 
			Me.largeimagetextbox.Location = New System.Drawing.Point(215, 38)
			Me.largeimagetextbox.Name = "largeimagetextbox"
			Me.largeimagetextbox.Size = New System.Drawing.Size(100, 20)
			Me.largeimagetextbox.TabIndex = 16
			' 
			' largeimagekeybox
			' 
			Me.largeimagekeybox.Location = New System.Drawing.Point(215, 12)
			Me.largeimagekeybox.Name = "largeimagekeybox"
			Me.largeimagekeybox.Size = New System.Drawing.Size(100, 20)
			Me.largeimagekeybox.TabIndex = 15
			' 
			' label11
			' 
			Me.label11.AutoSize = True
			Me.label11.Location = New System.Drawing.Point(321, 93)
			Me.label11.Name = "label11"
			Me.label11.Size = New System.Drawing.Size(88, 13)
			Me.label11.TabIndex = 22
			Me.label11.Text = "Small Image Text"
			' 
			' smallimagetextbox
			' 
			Me.smallimagetextbox.Location = New System.Drawing.Point(215, 90)
			Me.smallimagetextbox.Name = "smallimagetextbox"
			Me.smallimagetextbox.Size = New System.Drawing.Size(100, 20)
			Me.smallimagetextbox.TabIndex = 21
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(162)))
			Me.label12.Location = New System.Drawing.Point(311, 163)
			Me.label12.Name = "label12"
			Me.label12.Size = New System.Drawing.Size(72, 20)
			Me.label12.TabIndex = 23
			Me.label12.Text = "Button 2"
			Me.label12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			' 
			' label13
			' 
			Me.label13.AutoSize = True
			Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(162)))
			Me.label13.Location = New System.Drawing.Point(41, 163)
			Me.label13.Name = "label13"
			Me.label13.Size = New System.Drawing.Size(72, 20)
			Me.label13.TabIndex = 24
			Me.label13.Text = "Button 1"
			Me.label13.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			' 
			' label14
			' 
			Me.label14.AutoSize = True
			Me.label14.Location = New System.Drawing.Point(316, 203)
			Me.label14.Name = "label14"
			Me.label14.Size = New System.Drawing.Size(62, 13)
			Me.label14.TabIndex = 25
			Me.label14.Text = "Button Text"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(315, 248)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(63, 13)
			Me.label1.TabIndex = 26
			Me.label1.Text = "Button URL"
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(160, 163)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(108, 23)
			Me.button1.TabIndex = 27
			Me.button1.Text = "Update Presence"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' button2
			' 
			Me.button2.Location = New System.Drawing.Point(160, 198)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(108, 23)
			Me.button2.TabIndex = 28
			Me.button2.Text = "Remove Presence"
			Me.button2.UseVisualStyleBackColor = True
'			Me.button2.Click += New System.EventHandler(Me.button2_Click)
			' 
			' button3
			' 
			Me.button3.Location = New System.Drawing.Point(160, 238)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(108, 46)
			Me.button3.TabIndex = 29
			Me.button3.Text = "How To Get Application ID"
			Me.button3.UseVisualStyleBackColor = True
'			Me.button3.Click += New System.EventHandler(Me.button3_Click)
			' 
			' linkLabel1
			' 
			Me.linkLabel1.AutoSize = True
			Me.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue
			Me.linkLabel1.Location = New System.Drawing.Point(178, 295)
			Me.linkLabel1.Name = "linkLabel1"
			Me.linkLabel1.Size = New System.Drawing.Size(71, 13)
			Me.linkLabel1.TabIndex = 30
			Me.linkLabel1.TabStop = True
			Me.linkLabel1.Text = "Detailed Help"
'			Me.linkLabel1.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.linkLabel1_LinkClicked)
			' 
			' Custom
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(426, 320)
			Me.Controls.Add(Me.linkLabel1)
			Me.Controls.Add(Me.button3)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.label14)
			Me.Controls.Add(Me.label13)
			Me.Controls.Add(Me.label12)
			Me.Controls.Add(Me.label11)
			Me.Controls.Add(Me.smallimagetextbox)
			Me.Controls.Add(Me.label8)
			Me.Controls.Add(Me.label9)
			Me.Controls.Add(Me.label10)
			Me.Controls.Add(Me.smallimagekeybox)
			Me.Controls.Add(Me.largeimagetextbox)
			Me.Controls.Add(Me.largeimagekeybox)
			Me.Controls.Add(Me.label7)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.button2url)
			Me.Controls.Add(Me.button2text)
			Me.Controls.Add(Me.button1url)
			Me.Controls.Add(Me.button1text)
			Me.Controls.Add(Me.statusbox)
			Me.Controls.Add(Me.detailsbox)
			Me.Controls.Add(Me.textBox1)
			Me.Icon = (DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.MaximumSize = New System.Drawing.Size(442, 359)
			Me.MinimumSize = New System.Drawing.Size(442, 359)
			Me.Name = "Custom"
			Me.Text = "Custom Presence"
'			Me.Load += New System.EventHandler(Me.Custom_Load)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents textBox1 As System.Windows.Forms.TextBox
		Private WithEvents detailsbox As System.Windows.Forms.TextBox
		Private statusbox As System.Windows.Forms.TextBox
		Private button1text As System.Windows.Forms.TextBox
		Private button1url As System.Windows.Forms.TextBox
		Private button2url As System.Windows.Forms.TextBox
		Private button2text As System.Windows.Forms.TextBox
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private WithEvents label6 As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private label9 As System.Windows.Forms.Label
		Private label10 As System.Windows.Forms.Label
		Private smallimagekeybox As System.Windows.Forms.TextBox
		Private largeimagetextbox As System.Windows.Forms.TextBox
		Private largeimagekeybox As System.Windows.Forms.TextBox
		Private label11 As System.Windows.Forms.Label
		Private smallimagetextbox As System.Windows.Forms.TextBox
		Private label12 As System.Windows.Forms.Label
		Private label13 As System.Windows.Forms.Label
		Private label14 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private WithEvents button3 As System.Windows.Forms.Button
		Private WithEvents linkLabel1 As System.Windows.Forms.LinkLabel
	End Class
End Namespace