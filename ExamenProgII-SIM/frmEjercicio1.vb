'
' Created by SharpDevelop.
' User: Adalid
' Date: 30/6/2022
' Time: 22:27
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class frmEjercicio1
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	
	Sub TbxCantidadTextChanged(sender As Object, e As EventArgs)
		If IsNumeric(tbxCantidad.Text) Then
			tbxDolar.Text=CDec(tbxCantidad.Text)*0.15
			tbxEuro.Text=CDec(tbxCantidad.Text)*0.14
			tbxPArgentino.Text=CDec(tbxCantidad.Text)*18.33
			tbxPChileno.Text=CDec(tbxCantidad.Text)*134.17
			tbxReal.Text=CDec(tbxCantidad.Text)*0.77
			tbxSol.Text=CDec(tbxCantidad.Text)*0.55
			tbxYen.Text=CDec(tbxCantidad.Text)*19.78
		End If
	End Sub
End Class
