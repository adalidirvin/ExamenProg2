﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System


'This class was auto-generated by the StronglyTypedResourceBuilder
'class via a tool like ResGen or Visual Studio.
'To add or remove a member, edit your .ResX file then rerun ResGen
'with the /str option, or rebuild your VS project.
'''<summary>
'''  A strongly-typed resource class, for looking up localized strings, etc.
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
 Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
 Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
Friend Class MainForm
	
	Private Shared resourceMan As Global.System.Resources.ResourceManager
	
	Private Shared resourceCulture As Global.System.Globalization.CultureInfo
	
	<Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
	Friend Sub New()
		MyBase.New
	End Sub
	
	'''<summary>
	'''  Returns the cached ResourceManager instance used by this class.
	'''</summary>
	<Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
	Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
		Get
			If Object.ReferenceEquals(resourceMan, Nothing) Then
				Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("ExamenProgII_SIM.MainForm", GetType(MainForm).Assembly)
				resourceMan = temp
			End If
			Return resourceMan
		End Get
	End Property
	
	'''<summary>
	'''  Overrides the current thread's CurrentUICulture property for all
	'''  resource lookups using this strongly typed resource class.
	'''</summary>
	<Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
	Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
		Get
			Return resourceCulture
		End Get
		Set
			resourceCulture = value
		End Set
	End Property
	
	'''<summary>
	'''  Looks up a localized resource of type System.Drawing.Bitmap.
	'''</summary>
	Friend Shared ReadOnly Property pbxPerfil1_Image() As System.Drawing.Bitmap
		Get
			Dim obj As Object = ResourceManager.GetObject("pbxPerfil1.Image", resourceCulture)
			Return CType(obj,System.Drawing.Bitmap)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized resource of type System.Drawing.Bitmap.
	'''</summary>
	Friend Shared ReadOnly Property pbxPerfil2_Image() As System.Drawing.Bitmap
		Get
			Dim obj As Object = ResourceManager.GetObject("pbxPerfil2.Image", resourceCulture)
			Return CType(obj,System.Drawing.Bitmap)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized resource of type System.Drawing.Bitmap.
	'''</summary>
	Friend Shared ReadOnly Property pbxPerfil3_Image() As System.Drawing.Bitmap
		Get
			Dim obj As Object = ResourceManager.GetObject("pbxPerfil3.Image", resourceCulture)
			Return CType(obj,System.Drawing.Bitmap)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized resource of type System.Drawing.Bitmap.
	'''</summary>
	Friend Shared ReadOnly Property pbxPerfil4_Image() As System.Drawing.Bitmap
		Get
			Dim obj As Object = ResourceManager.GetObject("pbxPerfil4.Image", resourceCulture)
			Return CType(obj,System.Drawing.Bitmap)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized resource of type System.Drawing.Bitmap.
	'''</summary>
	Friend Shared ReadOnly Property pbxPerfil5_Image() As System.Drawing.Bitmap
		Get
			Dim obj As Object = ResourceManager.GetObject("pbxPerfil5.Image", resourceCulture)
			Return CType(obj,System.Drawing.Bitmap)
		End Get
	End Property
End Class
