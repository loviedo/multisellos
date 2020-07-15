'
' Created by SharpDevelop.
' User: Luis
' Date: 9/7/2020
' Time: 13:56
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class form_alta_timbrado
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
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.label5 = New System.Windows.Forms.Label()
		Me.tx_nro_ini = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.dt_fin = New System.Windows.Forms.DateTimePicker()
		Me.label14 = New System.Windows.Forms.Label()
		Me.dt_inicio = New System.Windows.Forms.DateTimePicker()
		Me.label3 = New System.Windows.Forms.Label()
		Me.tx_doc_tim = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.tx_nro_tim = New System.Windows.Forms.TextBox()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.button2 = New System.Windows.Forms.Button()
		Me.button1 = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.panel1.SuspendLayout
		Me.panel2.SuspendLayout
		Me.SuspendLayout
		'
		'panel1
		'
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.label6)
		Me.panel1.Controls.Add(Me.textBox1)
		Me.panel1.Controls.Add(Me.label5)
		Me.panel1.Controls.Add(Me.tx_nro_ini)
		Me.panel1.Controls.Add(Me.label4)
		Me.panel1.Controls.Add(Me.dt_fin)
		Me.panel1.Controls.Add(Me.label14)
		Me.panel1.Controls.Add(Me.dt_inicio)
		Me.panel1.Controls.Add(Me.label3)
		Me.panel1.Controls.Add(Me.tx_doc_tim)
		Me.panel1.Controls.Add(Me.label2)
		Me.panel1.Controls.Add(Me.tx_nro_tim)
		Me.panel1.Location = New System.Drawing.Point(12, 53)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(617, 328)
		Me.panel1.TabIndex = 0
		AddHandler Me.panel1.Paint, AddressOf Me.Panel1Paint
		'
		'label5
		'
		Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.Location = New System.Drawing.Point(17, 200)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(133, 29)
		Me.label5.TabIndex = 33
		Me.label5.Text = "Nro Inicial:"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_nro_ini
		'
		Me.tx_nro_ini.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_nro_ini.Location = New System.Drawing.Point(156, 200)
		Me.tx_nro_ini.Multiline = true
		Me.tx_nro_ini.Name = "tx_nro_ini"
		Me.tx_nro_ini.Size = New System.Drawing.Size(430, 29)
		Me.tx_nro_ini.TabIndex = 32
		Me.tx_nro_ini.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'label4
		'
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(13, 161)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(137, 23)
		Me.label4.TabIndex = 31
		Me.label4.Text = "Fecha Fin:"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'dt_fin
		'
		Me.dt_fin.Location = New System.Drawing.Point(156, 164)
		Me.dt_fin.Name = "dt_fin"
		Me.dt_fin.Size = New System.Drawing.Size(234, 20)
		Me.dt_fin.TabIndex = 30
		Me.dt_fin.Value = New Date(2019, 4, 10, 19, 48, 34, 0)
		'
		'label14
		'
		Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label14.Location = New System.Drawing.Point(13, 127)
		Me.label14.Name = "label14"
		Me.label14.Size = New System.Drawing.Size(137, 23)
		Me.label14.TabIndex = 29
		Me.label14.Text = "Fecha Inicio:"
		Me.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'dt_inicio
		'
		Me.dt_inicio.Location = New System.Drawing.Point(156, 129)
		Me.dt_inicio.Name = "dt_inicio"
		Me.dt_inicio.Size = New System.Drawing.Size(234, 20)
		Me.dt_inicio.TabIndex = 28
		Me.dt_inicio.Value = New Date(2019, 4, 10, 19, 48, 34, 0)
		'
		'label3
		'
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.Location = New System.Drawing.Point(17, 85)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(133, 29)
		Me.label3.TabIndex = 10
		Me.label3.Text = "Documento:"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_doc_tim
		'
		Me.tx_doc_tim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_doc_tim.Location = New System.Drawing.Point(156, 85)
		Me.tx_doc_tim.Multiline = true
		Me.tx_doc_tim.Name = "tx_doc_tim"
		Me.tx_doc_tim.Size = New System.Drawing.Size(430, 29)
		Me.tx_doc_tim.TabIndex = 9
		Me.tx_doc_tim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(17, 38)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(133, 29)
		Me.label2.TabIndex = 8
		Me.label2.Text = "Nro:"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_nro_tim
		'
		Me.tx_nro_tim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_nro_tim.Location = New System.Drawing.Point(156, 38)
		Me.tx_nro_tim.Multiline = true
		Me.tx_nro_tim.Name = "tx_nro_tim"
		Me.tx_nro_tim.Size = New System.Drawing.Size(430, 29)
		Me.tx_nro_tim.TabIndex = 7
		Me.tx_nro_tim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'panel2
		'
		Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel2.Controls.Add(Me.button2)
		Me.panel2.Controls.Add(Me.button1)
		Me.panel2.Location = New System.Drawing.Point(12, 387)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(617, 66)
		Me.panel2.TabIndex = 1
		'
		'button2
		'
		Me.button2.Location = New System.Drawing.Point(82, 17)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(121, 33)
		Me.button2.TabIndex = 1
		Me.button2.Text = "Guardar"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(431, 17)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(121, 33)
		Me.button1.TabIndex = 0
		Me.button1.Text = "Cancelar"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'label1
		'
		Me.label1.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(12, 9)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(617, 41)
		Me.label1.TabIndex = 17
		Me.label1.Text = "AGREGAR TIMBRADO"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label6
		'
		Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label6.Location = New System.Drawing.Point(17, 246)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(133, 29)
		Me.label6.TabIndex = 35
		Me.label6.Text = "Nro Final:"
		Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'textBox1
		'
		Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox1.Location = New System.Drawing.Point(156, 246)
		Me.textBox1.Multiline = true
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(430, 29)
		Me.textBox1.TabIndex = 34
		Me.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'form_alta_timbrado
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(640, 465)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.panel1)
		Me.Name = "form_alta_timbrado"
		Me.Text = "form_alta_timbrado"
		AddHandler Load, AddressOf Me.Form_alta_timbradoLoad
		Me.panel1.ResumeLayout(false)
		Me.panel1.PerformLayout
		Me.panel2.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private textBox1 As System.Windows.Forms.TextBox
	Private label6 As System.Windows.Forms.Label
	Private tx_nro_ini As System.Windows.Forms.TextBox
	Private label5 As System.Windows.Forms.Label
	Private dt_inicio As System.Windows.Forms.DateTimePicker
	Private label14 As System.Windows.Forms.Label
	Private dt_fin As System.Windows.Forms.DateTimePicker
	Private label4 As System.Windows.Forms.Label
	Private tx_nro_tim As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private tx_doc_tim As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private button2 As System.Windows.Forms.Button
	Private button1 As System.Windows.Forms.Button
	Private panel2 As System.Windows.Forms.Panel
	Private panel1 As System.Windows.Forms.Panel
End Class
