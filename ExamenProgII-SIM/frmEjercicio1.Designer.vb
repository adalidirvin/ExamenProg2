'
' Created by SharpDevelop.
' User: Adalid
' Date: 30/6/2022
' Time: 22:27
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class frmEjercicio1
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
		Me.gbxConversor = New System.Windows.Forms.GroupBox()
		Me.tbxPArgentino = New System.Windows.Forms.TextBox()
		Me.tbxYen = New System.Windows.Forms.TextBox()
		Me.tbxReal = New System.Windows.Forms.TextBox()
		Me.tbxPChileno = New System.Windows.Forms.TextBox()
		Me.tbxSol = New System.Windows.Forms.TextBox()
		Me.tbxEuro = New System.Windows.Forms.TextBox()
		Me.tbxDolar = New System.Windows.Forms.TextBox()
		Me.label8 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.tbxCantidad = New System.Windows.Forms.TextBox()
		Me.gbxConversor.SuspendLayout
		Me.SuspendLayout
		'
		'gbxConversor
		'
		Me.gbxConversor.Controls.Add(Me.tbxPArgentino)
		Me.gbxConversor.Controls.Add(Me.tbxYen)
		Me.gbxConversor.Controls.Add(Me.tbxReal)
		Me.gbxConversor.Controls.Add(Me.tbxPChileno)
		Me.gbxConversor.Controls.Add(Me.tbxSol)
		Me.gbxConversor.Controls.Add(Me.tbxEuro)
		Me.gbxConversor.Controls.Add(Me.tbxDolar)
		Me.gbxConversor.Controls.Add(Me.label8)
		Me.gbxConversor.Controls.Add(Me.label7)
		Me.gbxConversor.Controls.Add(Me.label6)
		Me.gbxConversor.Controls.Add(Me.label5)
		Me.gbxConversor.Controls.Add(Me.label4)
		Me.gbxConversor.Controls.Add(Me.label3)
		Me.gbxConversor.Controls.Add(Me.label2)
		Me.gbxConversor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gbxConversor.Location = New System.Drawing.Point(10, 9)
		Me.gbxConversor.Name = "gbxConversor"
		Me.gbxConversor.Size = New System.Drawing.Size(369, 266)
		Me.gbxConversor.TabIndex = 0
		Me.gbxConversor.TabStop = false
		Me.gbxConversor.Text = "Conversor de monedas"
		'
		'tbxPArgentino
		'
		Me.tbxPArgentino.Location = New System.Drawing.Point(168, 225)
		Me.tbxPArgentino.Name = "tbxPArgentino"
		Me.tbxPArgentino.Size = New System.Drawing.Size(195, 23)
		Me.tbxPArgentino.TabIndex = 13
		'
		'tbxYen
		'
		Me.tbxYen.Location = New System.Drawing.Point(168, 193)
		Me.tbxYen.Name = "tbxYen"
		Me.tbxYen.Size = New System.Drawing.Size(195, 23)
		Me.tbxYen.TabIndex = 12
		'
		'tbxReal
		'
		Me.tbxReal.Location = New System.Drawing.Point(168, 161)
		Me.tbxReal.Name = "tbxReal"
		Me.tbxReal.Size = New System.Drawing.Size(195, 23)
		Me.tbxReal.TabIndex = 11
		'
		'tbxPChileno
		'
		Me.tbxPChileno.Location = New System.Drawing.Point(168, 129)
		Me.tbxPChileno.Name = "tbxPChileno"
		Me.tbxPChileno.Size = New System.Drawing.Size(195, 23)
		Me.tbxPChileno.TabIndex = 10
		'
		'tbxSol
		'
		Me.tbxSol.Location = New System.Drawing.Point(168, 97)
		Me.tbxSol.Name = "tbxSol"
		Me.tbxSol.Size = New System.Drawing.Size(195, 23)
		Me.tbxSol.TabIndex = 9
		'
		'tbxEuro
		'
		Me.tbxEuro.Location = New System.Drawing.Point(168, 65)
		Me.tbxEuro.Name = "tbxEuro"
		Me.tbxEuro.Size = New System.Drawing.Size(195, 23)
		Me.tbxEuro.TabIndex = 8
		'
		'tbxDolar
		'
		Me.tbxDolar.Location = New System.Drawing.Point(168, 33)
		Me.tbxDolar.Name = "tbxDolar"
		Me.tbxDolar.Size = New System.Drawing.Size(195, 23)
		Me.tbxDolar.TabIndex = 7
		'
		'label8
		'
		Me.label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label8.Location = New System.Drawing.Point(17, 225)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(133, 22)
		Me.label8.TabIndex = 6
		Me.label8.Text = "Peso Argentino"
		Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label7
		'
		Me.label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label7.Location = New System.Drawing.Point(17, 193)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(133, 22)
		Me.label7.TabIndex = 5
		Me.label7.Text = "Yen"
		Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label6
		'
		Me.label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label6.Location = New System.Drawing.Point(17, 161)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(133, 22)
		Me.label6.TabIndex = 4
		Me.label6.Text = "Real"
		Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label5
		'
		Me.label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.Location = New System.Drawing.Point(17, 129)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(133, 22)
		Me.label5.TabIndex = 3
		Me.label5.Text = "Peso Chileno"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label4
		'
		Me.label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(17, 97)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(133, 22)
		Me.label4.TabIndex = 2
		Me.label4.Text = "Sol"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label3
		'
		Me.label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.Location = New System.Drawing.Point(17, 65)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(133, 22)
		Me.label3.TabIndex = 1
		Me.label3.Text = "Euro"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(17, 33)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(98, 22)
		Me.label2.TabIndex = 0
		Me.label2.Text = "Dolar"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label1
		'
		Me.label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
		Me.label1.Location = New System.Drawing.Point(389, 106)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(135, 31)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Cantidad en Bs."
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tbxCantidad
		'
		Me.tbxCantidad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tbxCantidad.Location = New System.Drawing.Point(392, 152)
		Me.tbxCantidad.Name = "tbxCantidad"
		Me.tbxCantidad.Size = New System.Drawing.Size(128, 23)
		Me.tbxCantidad.TabIndex = 1
		AddHandler Me.tbxCantidad.TextChanged, AddressOf Me.TbxCantidadTextChanged
		'
		'frmEjercicio1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(532, 283)
		Me.Controls.Add(Me.tbxCantidad)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.gbxConversor)
		Me.Name = "frmEjercicio1"
		Me.Text = "Ejercicio 1"
		Me.gbxConversor.ResumeLayout(false)
		Me.gbxConversor.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private tbxCantidad As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private tbxDolar As System.Windows.Forms.TextBox
	Private tbxEuro As System.Windows.Forms.TextBox
	Private tbxSol As System.Windows.Forms.TextBox
	Private tbxPChileno As System.Windows.Forms.TextBox
	Private tbxReal As System.Windows.Forms.TextBox
	Private tbxYen As System.Windows.Forms.TextBox
	Private tbxPArgentino As System.Windows.Forms.TextBox
	Private gbxConversor As System.Windows.Forms.GroupBox
End Class
