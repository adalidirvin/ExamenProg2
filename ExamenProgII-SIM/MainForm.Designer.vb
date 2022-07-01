'
' Created by SharpDevelop.
' User: Adalid
' Date: 30/6/2022
' Time: 20:44
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class frmInicio
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
		Me.pbxPerfil1 = New System.Windows.Forms.PictureBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.button1 = New System.Windows.Forms.Button()
		Me.button2 = New System.Windows.Forms.Button()
		Me.button3 = New System.Windows.Forms.Button()
		Me.button4 = New System.Windows.Forms.Button()
		Me.mnMenu = New System.Windows.Forms.MenuStrip()
		Me.inicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.fotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.perfil1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.perfil2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.perfil3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.perfil4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.perfil5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.lbFecHora = New System.Windows.Forms.Label()
		Me.pbxPerfil2 = New System.Windows.Forms.PictureBox()
		Me.pbxPerfil3 = New System.Windows.Forms.PictureBox()
		Me.pbxPerfil4 = New System.Windows.Forms.PictureBox()
		Me.pbxPerfil5 = New System.Windows.Forms.PictureBox()
		CType(Me.pbxPerfil1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.mnMenu.SuspendLayout
		CType(Me.pbxPerfil2,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pbxPerfil3,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pbxPerfil4,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pbxPerfil5,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'pbxPerfil1
		'
		Me.pbxPerfil1.Image = CType(resources.GetObject("pbxPerfil1.Image"),System.Drawing.Image)
		Me.pbxPerfil1.Location = New System.Drawing.Point(44, 82)
		Me.pbxPerfil1.Name = "pbxPerfil1"
		Me.pbxPerfil1.Size = New System.Drawing.Size(220, 220)
		Me.pbxPerfil1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pbxPerfil1.TabIndex = 0
		Me.pbxPerfil1.TabStop = false
		Me.pbxPerfil1.Visible = false
		'
		'label1
		'
		Me.label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
		Me.label1.Location = New System.Drawing.Point(335, 26)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(238, 94)
		Me.label1.TabIndex = 1
		Me.label1.Text = "EXAMEN"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"DE"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"PROGRAMACIÓN"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(303, 137)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(89, 27)
		Me.label2.TabIndex = 2
		Me.label2.Text = "Estudiante:"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label3
		'
		Me.label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.Location = New System.Drawing.Point(303, 175)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(89, 27)
		Me.label3.TabIndex = 3
		Me.label3.Text = "CI:"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'textBox1
		'
		Me.textBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox1.Location = New System.Drawing.Point(397, 138)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(210, 23)
		Me.textBox1.TabIndex = 4
		'
		'textBox2
		'
		Me.textBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox2.Location = New System.Drawing.Point(397, 177)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.Size = New System.Drawing.Size(210, 23)
		Me.textBox2.TabIndex = 5
		'
		'button1
		'
		Me.button1.BackColor = System.Drawing.SystemColors.MenuHighlight
		Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button1.ForeColor = System.Drawing.Color.White
		Me.button1.Location = New System.Drawing.Point(374, 226)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(188, 28)
		Me.button1.TabIndex = 6
		Me.button1.Text = "Ejercicio 1"
		Me.button1.UseVisualStyleBackColor = false
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'button2
		'
		Me.button2.BackColor = System.Drawing.SystemColors.MenuHighlight
		Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button2.ForeColor = System.Drawing.Color.White
		Me.button2.Location = New System.Drawing.Point(374, 260)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(188, 28)
		Me.button2.TabIndex = 7
		Me.button2.Text = "Ejercicio 2"
		Me.button2.UseVisualStyleBackColor = false
		'
		'button3
		'
		Me.button3.BackColor = System.Drawing.SystemColors.MenuHighlight
		Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.button3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button3.ForeColor = System.Drawing.Color.White
		Me.button3.Location = New System.Drawing.Point(374, 294)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(188, 28)
		Me.button3.TabIndex = 8
		Me.button3.Text = "Ejercicio 3"
		Me.button3.UseVisualStyleBackColor = false
		'
		'button4
		'
		Me.button4.BackColor = System.Drawing.SystemColors.MenuHighlight
		Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.button4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button4.ForeColor = System.Drawing.Color.White
		Me.button4.Location = New System.Drawing.Point(374, 328)
		Me.button4.Name = "button4"
		Me.button4.Size = New System.Drawing.Size(188, 28)
		Me.button4.TabIndex = 9
		Me.button4.Text = "Ejercicio 4"
		Me.button4.UseVisualStyleBackColor = false
		'
		'mnMenu
		'
		Me.mnMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.inicioToolStripMenuItem, Me.fotoToolStripMenuItem, Me.toolStripMenuItem1})
		Me.mnMenu.Location = New System.Drawing.Point(0, 0)
		Me.mnMenu.Name = "mnMenu"
		Me.mnMenu.Size = New System.Drawing.Size(619, 24)
		Me.mnMenu.TabIndex = 10
		Me.mnMenu.Text = "menuStrip1"
		'
		'inicioToolStripMenuItem
		'
		Me.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem"
		Me.inicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
		Me.inicioToolStripMenuItem.Text = "Inicio"
		'
		'fotoToolStripMenuItem
		'
		Me.fotoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.perfil1ToolStripMenuItem, Me.perfil2ToolStripMenuItem, Me.perfil3ToolStripMenuItem, Me.perfil4ToolStripMenuItem, Me.perfil5ToolStripMenuItem})
		Me.fotoToolStripMenuItem.Name = "fotoToolStripMenuItem"
		Me.fotoToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
		Me.fotoToolStripMenuItem.Text = "Perfil"
		'
		'perfil1ToolStripMenuItem
		'
		Me.perfil1ToolStripMenuItem.Name = "perfil1ToolStripMenuItem"
		Me.perfil1ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.perfil1ToolStripMenuItem.Text = "Perfil 1"
		AddHandler Me.perfil1ToolStripMenuItem.Click, AddressOf Me.Perfil1ToolStripMenuItemClick
		'
		'perfil2ToolStripMenuItem
		'
		Me.perfil2ToolStripMenuItem.Name = "perfil2ToolStripMenuItem"
		Me.perfil2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.perfil2ToolStripMenuItem.Text = "Perfil 2"
		AddHandler Me.perfil2ToolStripMenuItem.Click, AddressOf Me.Perfil2ToolStripMenuItemClick
		'
		'perfil3ToolStripMenuItem
		'
		Me.perfil3ToolStripMenuItem.Name = "perfil3ToolStripMenuItem"
		Me.perfil3ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.perfil3ToolStripMenuItem.Text = "Perfil 3"
		AddHandler Me.perfil3ToolStripMenuItem.Click, AddressOf Me.Perfil3ToolStripMenuItemClick
		'
		'perfil4ToolStripMenuItem
		'
		Me.perfil4ToolStripMenuItem.Name = "perfil4ToolStripMenuItem"
		Me.perfil4ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.perfil4ToolStripMenuItem.Text = "Perfil 4"
		AddHandler Me.perfil4ToolStripMenuItem.Click, AddressOf Me.Perfil4ToolStripMenuItemClick
		'
		'perfil5ToolStripMenuItem
		'
		Me.perfil5ToolStripMenuItem.Name = "perfil5ToolStripMenuItem"
		Me.perfil5ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.perfil5ToolStripMenuItem.Text = "Perfil 5"
		AddHandler Me.perfil5ToolStripMenuItem.Click, AddressOf Me.Perfil5ToolStripMenuItemClick
		'
		'toolStripMenuItem1
		'
		Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
		Me.toolStripMenuItem1.Size = New System.Drawing.Size(24, 20)
		Me.toolStripMenuItem1.Text = "?"
		'
		'lbFecHora
		'
		Me.lbFecHora.Font = New System.Drawing.Font("Century Gothic", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbFecHora.ForeColor = System.Drawing.SystemColors.MenuHighlight
		Me.lbFecHora.Location = New System.Drawing.Point(484, 3)
		Me.lbFecHora.Name = "lbFecHora"
		Me.lbFecHora.Size = New System.Drawing.Size(130, 25)
		Me.lbFecHora.TabIndex = 11
		Me.lbFecHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pbxPerfil2
		'
		Me.pbxPerfil2.Image = CType(resources.GetObject("pbxPerfil2.Image"),System.Drawing.Image)
		Me.pbxPerfil2.Location = New System.Drawing.Point(44, 82)
		Me.pbxPerfil2.Name = "pbxPerfil2"
		Me.pbxPerfil2.Size = New System.Drawing.Size(220, 220)
		Me.pbxPerfil2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pbxPerfil2.TabIndex = 12
		Me.pbxPerfil2.TabStop = false
		Me.pbxPerfil2.Visible = false
		'
		'pbxPerfil3
		'
		Me.pbxPerfil3.Image = CType(resources.GetObject("pbxPerfil3.Image"),System.Drawing.Image)
		Me.pbxPerfil3.Location = New System.Drawing.Point(44, 82)
		Me.pbxPerfil3.Name = "pbxPerfil3"
		Me.pbxPerfil3.Size = New System.Drawing.Size(220, 220)
		Me.pbxPerfil3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pbxPerfil3.TabIndex = 13
		Me.pbxPerfil3.TabStop = false
		Me.pbxPerfil3.Visible = false
		'
		'pbxPerfil4
		'
		Me.pbxPerfil4.Image = CType(resources.GetObject("pbxPerfil4.Image"),System.Drawing.Image)
		Me.pbxPerfil4.Location = New System.Drawing.Point(44, 82)
		Me.pbxPerfil4.Name = "pbxPerfil4"
		Me.pbxPerfil4.Size = New System.Drawing.Size(220, 220)
		Me.pbxPerfil4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pbxPerfil4.TabIndex = 14
		Me.pbxPerfil4.TabStop = false
		Me.pbxPerfil4.Visible = false
		'
		'pbxPerfil5
		'
		Me.pbxPerfil5.Image = CType(resources.GetObject("pbxPerfil5.Image"),System.Drawing.Image)
		Me.pbxPerfil5.Location = New System.Drawing.Point(44, 82)
		Me.pbxPerfil5.Name = "pbxPerfil5"
		Me.pbxPerfil5.Size = New System.Drawing.Size(220, 220)
		Me.pbxPerfil5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pbxPerfil5.TabIndex = 15
		Me.pbxPerfil5.TabStop = false
		Me.pbxPerfil5.Visible = false
		'
		'frmInicio
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(619, 372)
		Me.Controls.Add(Me.pbxPerfil5)
		Me.Controls.Add(Me.pbxPerfil4)
		Me.Controls.Add(Me.pbxPerfil3)
		Me.Controls.Add(Me.pbxPerfil2)
		Me.Controls.Add(Me.lbFecHora)
		Me.Controls.Add(Me.button4)
		Me.Controls.Add(Me.button3)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.textBox2)
		Me.Controls.Add(Me.textBox1)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.pbxPerfil1)
		Me.Controls.Add(Me.mnMenu)
		Me.MainMenuStrip = Me.mnMenu
		Me.Name = "frmInicio"
		Me.Text = "ExamenProgII-SIM"
		CType(Me.pbxPerfil1,System.ComponentModel.ISupportInitialize).EndInit
		Me.mnMenu.ResumeLayout(false)
		Me.mnMenu.PerformLayout
		CType(Me.pbxPerfil2,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pbxPerfil3,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pbxPerfil4,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pbxPerfil5,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private pbxPerfil5 As System.Windows.Forms.PictureBox
	Private pbxPerfil4 As System.Windows.Forms.PictureBox
	Private pbxPerfil3 As System.Windows.Forms.PictureBox
	Private pbxPerfil2 As System.Windows.Forms.PictureBox
	Private perfil5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private pbxPerfil1 As System.Windows.Forms.PictureBox
	Private lbFecHora As System.Windows.Forms.Label
	Private toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private perfil4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private perfil3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private perfil2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private perfil1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private fotoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private inicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private mnMenu As System.Windows.Forms.MenuStrip
	Private button4 As System.Windows.Forms.Button
	Private button3 As System.Windows.Forms.Button
	Private button2 As System.Windows.Forms.Button
	Private button1 As System.Windows.Forms.Button
	Private textBox2 As System.Windows.Forms.TextBox
	Private textBox1 As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
End Class
