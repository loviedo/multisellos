﻿'
' Created by SharpDevelop.
' User: Luis
' Date: 31/3/2019
' Time: 11:38
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class form_busca_prod
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
		Me.SuspendLayout
		'
		'form_busca_prod
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(943, 466)
		Me.Name = "form_busca_prod"
		Me.Text = "form_busca_prod"
		AddHandler Load, AddressOf Me.Form_busca_prodLoad
		Me.ResumeLayout(false)
	End Sub
End Class
