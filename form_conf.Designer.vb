﻿'
' Created by SharpDevelop.
' User: Luis
' Date: 9/23/2018
' Time: 10:57 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class form_conf
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
		Me.button1 = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(378, 335)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(170, 24)
		Me.button1.TabIndex = 0
		Me.button1.Text = "Salir"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'form_conf
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(601, 398)
		Me.Controls.Add(Me.button1)
		Me.Name = "form_conf"
		Me.Text = "form_conf"
		AddHandler Load, AddressOf Me.Form_confLoad
		Me.ResumeLayout(false)
	End Sub
	Private button1 As System.Windows.Forms.Button
End Class
