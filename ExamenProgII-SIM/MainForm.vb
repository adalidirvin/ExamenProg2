'
' Created by SharpDevelop.
' User: Adalid
' Date: 30/6/2022
' Time: 20:44
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class frmInicio
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
		lbFecHora.Text=Now
	End Sub
	
	Sub Perfil1ToolStripMenuItemClick(sender As Object, e As EventArgs)
		pbxPerfil1.Visible=True
		pbxPerfil2.Visible=False
		pbxPerfil3.Visible=False
		pbxPerfil4.Visible=False
		pbxPerfil5.Visible=False
	End Sub
	
	Sub Perfil2ToolStripMenuItemClick(sender As Object, e As EventArgs)
		pbxPerfil1.Visible=False
		pbxPerfil2.Visible=True
		pbxPerfil3.Visible=False
		pbxPerfil4.Visible=False
		pbxPerfil5.Visible=False		
	End Sub
	
	Sub Perfil3ToolStripMenuItemClick(sender As Object, e As EventArgs)
		pbxPerfil1.Visible=False
		pbxPerfil2.Visible=False
		pbxPerfil3.Visible=True
		pbxPerfil4.Visible=False
		pbxPerfil5.Visible=False	
	End Sub
	
	Sub Perfil4ToolStripMenuItemClick(sender As Object, e As EventArgs)
		pbxPerfil1.Visible=False
		pbxPerfil2.Visible=False
		pbxPerfil3.Visible=False
		pbxPerfil4.Visible=True
		pbxPerfil5.Visible=False			
	End Sub
	
	Sub Perfil5ToolStripMenuItemClick(sender As Object, e As EventArgs)
		pbxPerfil1.Visible=False
		pbxPerfil2.Visible=False
		pbxPerfil3.Visible=False
		pbxPerfil4.Visible=False
		pbxPerfil5.Visible=True			
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		frmEjercicio1.show()
	End Sub
End Class
