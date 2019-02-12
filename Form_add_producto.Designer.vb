'
' Created by SharpDevelop.
' User: Luis
' Date: 3/11/2018
' Time: 10:46
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class Form_add_producto
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
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.label6 = New System.Windows.Forms.Label()
		Me.tx_precio3 = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.tx_des = New System.Windows.Forms.TextBox()
		Me.tx_precio2 = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.tx_precio1 = New System.Windows.Forms.TextBox()
		Me.tx_cod = New System.Windows.Forms.TextBox()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.button2 = New System.Windows.Forms.Button()
		Me.button1 = New System.Windows.Forms.Button()
		Me.panel2.SuspendLayout
		Me.panel1.SuspendLayout
		Me.SuspendLayout
		'
		'panel2
		'
		Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel2.Controls.Add(Me.label6)
		Me.panel2.Controls.Add(Me.tx_precio3)
		Me.panel2.Controls.Add(Me.label2)
		Me.panel2.Controls.Add(Me.label7)
		Me.panel2.Controls.Add(Me.tx_des)
		Me.panel2.Controls.Add(Me.tx_precio2)
		Me.panel2.Controls.Add(Me.label1)
		Me.panel2.Controls.Add(Me.label4)
		Me.panel2.Controls.Add(Me.label3)
		Me.panel2.Controls.Add(Me.tx_precio1)
		Me.panel2.Controls.Add(Me.tx_cod)
		Me.panel2.Location = New System.Drawing.Point(12, 12)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(588, 349)
		Me.panel2.TabIndex = 13
		'
		'label6
		'
		Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label6.Location = New System.Drawing.Point(68, 208)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(135, 29)
		Me.label6.TabIndex = 26
		Me.label6.Text = "PRECIO 3:"
		Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_precio3
		'
		Me.tx_precio3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_precio3.Location = New System.Drawing.Point(223, 208)
		Me.tx_precio3.Name = "tx_precio3"
		Me.tx_precio3.Size = New System.Drawing.Size(360, 24)
		Me.tx_precio3.TabIndex = 25
		Me.tx_precio3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(68, 173)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(135, 29)
		Me.label2.TabIndex = 24
		Me.label2.Text = "PRECIO 2:"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label7
		'
		Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label7.Location = New System.Drawing.Point(28, 263)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(183, 29)
		Me.label7.TabIndex = 23
		Me.label7.Text = "DESCRIPCION:"
		Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_des
		'
		Me.tx_des.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_des.Location = New System.Drawing.Point(223, 263)
		Me.tx_des.Multiline = true
		Me.tx_des.Name = "tx_des"
		Me.tx_des.Size = New System.Drawing.Size(360, 49)
		Me.tx_des.TabIndex = 6
		Me.tx_des.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'tx_precio2
		'
		Me.tx_precio2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_precio2.Location = New System.Drawing.Point(223, 173)
		Me.tx_precio2.Name = "tx_precio2"
		Me.tx_precio2.Size = New System.Drawing.Size(360, 24)
		Me.tx_precio2.TabIndex = 4
		Me.tx_precio2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'label1
		'
		Me.label1.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(3, 8)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(580, 41)
		Me.label1.TabIndex = 16
		Me.label1.Text = "AGREGAR PRODUCTO"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label4
		'
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(68, 135)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(135, 29)
		Me.label4.TabIndex = 15
		Me.label4.Text = "PRECIO 1:"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label3
		'
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.Location = New System.Drawing.Point(68, 98)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(143, 29)
		Me.label3.TabIndex = 14
		Me.label3.Text = "CODIGO:"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_precio1
		'
		Me.tx_precio1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_precio1.Location = New System.Drawing.Point(223, 139)
		Me.tx_precio1.Name = "tx_precio1"
		Me.tx_precio1.Size = New System.Drawing.Size(360, 24)
		Me.tx_precio1.TabIndex = 3
		Me.tx_precio1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'tx_cod
		'
		Me.tx_cod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_cod.Location = New System.Drawing.Point(223, 103)
		Me.tx_cod.Name = "tx_cod"
		Me.tx_cod.Size = New System.Drawing.Size(360, 24)
		Me.tx_cod.TabIndex = 2
		Me.tx_cod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'panel1
		'
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.button2)
		Me.panel1.Controls.Add(Me.button1)
		Me.panel1.Location = New System.Drawing.Point(12, 367)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(588, 66)
		Me.panel1.TabIndex = 12
		'
		'button2
		'
		Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button2.Location = New System.Drawing.Point(465, 22)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(105, 33)
		Me.button2.TabIndex = 8
		Me.button2.Text = "CANCELAR"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'button1
		'
		Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button1.Location = New System.Drawing.Point(12, 22)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(105, 33)
		Me.button1.TabIndex = 7
		Me.button1.Text = "INSERTAR"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'Form_add_producto
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(621, 450)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.panel1)
		Me.Name = "Form_add_producto"
		Me.Text = "Form_add_producto"
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		Me.panel1.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private tx_precio3 As System.Windows.Forms.TextBox
	Private label6 As System.Windows.Forms.Label
	Private button1 As System.Windows.Forms.Button
	Private button2 As System.Windows.Forms.Button
	Private panel1 As System.Windows.Forms.Panel
	Private tx_cod As System.Windows.Forms.TextBox
	Private tx_precio1 As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private tx_precio2 As System.Windows.Forms.TextBox
	Private tx_des As System.Windows.Forms.TextBox
	Private label7 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private panel2 As System.Windows.Forms.Panel
End Class
