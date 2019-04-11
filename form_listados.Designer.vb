'
' Created by SharpDevelop.
' User: Luis
' Date: 10/4/2019
' Time: 21:32
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class form_listados
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
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.label1 = New System.Windows.Forms.Label()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.button2 = New System.Windows.Forms.Button()
		Me.label5 = New System.Windows.Forms.Label()
		Me.tx_carpeta = New System.Windows.Forms.TextBox()
		Me.button1 = New System.Windows.Forms.Button()
		Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
		Me.panel3.SuspendLayout
		Me.panel2.SuspendLayout
		Me.SuspendLayout
		'
		'panel3
		'
		Me.panel3.BackColor = System.Drawing.SystemColors.ControlDark
		Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel3.Controls.Add(Me.label1)
		Me.panel3.Location = New System.Drawing.Point(12, 12)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(656, 54)
		Me.panel3.TabIndex = 37
		'
		'label1
		'
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(3, 10)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(127, 31)
		Me.label1.TabIndex = 0
		Me.label1.Text = "LISTADOS"
		'
		'panel2
		'
		Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel2.Controls.Add(Me.button2)
		Me.panel2.Controls.Add(Me.label5)
		Me.panel2.Controls.Add(Me.tx_carpeta)
		Me.panel2.Controls.Add(Me.button1)
		Me.panel2.Location = New System.Drawing.Point(12, 72)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(656, 341)
		Me.panel2.TabIndex = 38
		'
		'button2
		'
		Me.button2.Location = New System.Drawing.Point(418, 78)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(118, 29)
		Me.button2.TabIndex = 40
		Me.button2.Text = "Seleccionar"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'label5
		'
		Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.Location = New System.Drawing.Point(92, 46)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(105, 29)
		Me.label5.TabIndex = 39
		Me.label5.Text = "Carpeta:"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_carpeta
		'
		Me.tx_carpeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_carpeta.Location = New System.Drawing.Point(101, 78)
		Me.tx_carpeta.Multiline = true
		Me.tx_carpeta.Name = "tx_carpeta"
		Me.tx_carpeta.Size = New System.Drawing.Size(311, 29)
		Me.tx_carpeta.TabIndex = 38
		Me.tx_carpeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(101, 173)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(435, 36)
		Me.button1.TabIndex = 37
		Me.button1.Text = "Ventas Diarias"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'form_listados
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(680, 425)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.panel3)
		Me.Name = "form_listados"
		Me.Text = "form_listados"
		Me.panel3.ResumeLayout(false)
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private folderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
	Private button2 As System.Windows.Forms.Button
	Private panel2 As System.Windows.Forms.Panel
	Private label1 As System.Windows.Forms.Label
	Private panel3 As System.Windows.Forms.Panel
	Private tx_carpeta As System.Windows.Forms.TextBox
	Private label5 As System.Windows.Forms.Label
	Private button1 As System.Windows.Forms.Button
End Class
