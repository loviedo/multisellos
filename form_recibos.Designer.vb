﻿'
' Created by SharpDevelop.
' User: Luis
' Date: 31/3/2019
' Time: 09:30
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class form_recibos
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
		Me.button4 = New System.Windows.Forms.Button()
		Me.button2 = New System.Windows.Forms.Button()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.tx_id_factu = New System.Windows.Forms.TextBox()
		Me.label14 = New System.Windows.Forms.Label()
		Me.dtp1 = New System.Windows.Forms.DateTimePicker()
		Me.tx_id_cliente = New System.Windows.Forms.TextBox()
		Me.label7 = New System.Windows.Forms.Label()
		Me.tx_monto = New System.Windows.Forms.TextBox()
		Me.label6 = New System.Windows.Forms.Label()
		Me.tx_concepto = New System.Windows.Forms.TextBox()
		Me.button1 = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.tx_factu = New System.Windows.Forms.TextBox()
		Me.panel4 = New System.Windows.Forms.Panel()
		Me.tx_nro_recibo = New System.Windows.Forms.TextBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.tx_tel_cliente = New System.Windows.Forms.TextBox()
		Me.tx_ruc_cliente = New System.Windows.Forms.TextBox()
		Me.tx_nom_cliente = New System.Windows.Forms.TextBox()
		Me.button3 = New System.Windows.Forms.Button()
		Me.panel1.SuspendLayout
		Me.panel2.SuspendLayout
		Me.panel4.SuspendLayout
		Me.SuspendLayout
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.SystemColors.ControlDark
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.button4)
		Me.panel1.Controls.Add(Me.button2)
		Me.panel1.Location = New System.Drawing.Point(12, 411)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(974, 53)
		Me.panel1.TabIndex = 7
		'
		'button4
		'
		Me.button4.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button4.Location = New System.Drawing.Point(775, 2)
		Me.button4.Name = "button4"
		Me.button4.Size = New System.Drawing.Size(194, 46)
		Me.button4.TabIndex = 9
		Me.button4.Text = "IMPRIMIR"
		Me.button4.UseVisualStyleBackColor = false
		AddHandler Me.button4.Click, AddressOf Me.Button4Click
		'
		'button2
		'
		Me.button2.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button2.Location = New System.Drawing.Point(21, 4)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(161, 44)
		Me.button2.TabIndex = 2
		Me.button2.Text = "Cancelar"
		Me.button2.UseVisualStyleBackColor = false
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'panel2
		'
		Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel2.Controls.Add(Me.tx_id_factu)
		Me.panel2.Controls.Add(Me.label14)
		Me.panel2.Controls.Add(Me.dtp1)
		Me.panel2.Controls.Add(Me.tx_id_cliente)
		Me.panel2.Controls.Add(Me.label7)
		Me.panel2.Controls.Add(Me.tx_monto)
		Me.panel2.Controls.Add(Me.label6)
		Me.panel2.Controls.Add(Me.tx_concepto)
		Me.panel2.Controls.Add(Me.button1)
		Me.panel2.Controls.Add(Me.label1)
		Me.panel2.Controls.Add(Me.tx_factu)
		Me.panel2.Controls.Add(Me.panel4)
		Me.panel2.Controls.Add(Me.label4)
		Me.panel2.Controls.Add(Me.label3)
		Me.panel2.Controls.Add(Me.label2)
		Me.panel2.Controls.Add(Me.tx_tel_cliente)
		Me.panel2.Controls.Add(Me.tx_ruc_cliente)
		Me.panel2.Controls.Add(Me.tx_nom_cliente)
		Me.panel2.Controls.Add(Me.button3)
		Me.panel2.Location = New System.Drawing.Point(12, 12)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(974, 393)
		Me.panel2.TabIndex = 8
		'
		'tx_id_factu
		'
		Me.tx_id_factu.Location = New System.Drawing.Point(843, 237)
		Me.tx_id_factu.Name = "tx_id_factu"
		Me.tx_id_factu.Size = New System.Drawing.Size(100, 20)
		Me.tx_id_factu.TabIndex = 30
		Me.tx_id_factu.Visible = false
		'
		'label14
		'
		Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label14.Location = New System.Drawing.Point(15, 18)
		Me.label14.Name = "label14"
		Me.label14.Size = New System.Drawing.Size(121, 29)
		Me.label14.TabIndex = 29
		Me.label14.Text = "FECHA:"
		Me.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'dtp1
		'
		Me.dtp1.Location = New System.Drawing.Point(140, 23)
		Me.dtp1.Name = "dtp1"
		Me.dtp1.Size = New System.Drawing.Size(200, 20)
		Me.dtp1.TabIndex = 28
		Me.dtp1.Value = New Date(2019, 4, 10, 19, 48, 34, 0)
		'
		'tx_id_cliente
		'
		Me.tx_id_cliente.Location = New System.Drawing.Point(843, 202)
		Me.tx_id_cliente.Name = "tx_id_cliente"
		Me.tx_id_cliente.Size = New System.Drawing.Size(100, 20)
		Me.tx_id_cliente.TabIndex = 22
		Me.tx_id_cliente.Visible = false
		'
		'label7
		'
		Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label7.Location = New System.Drawing.Point(15, 237)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(107, 29)
		Me.label7.TabIndex = 21
		Me.label7.Text = "MONTO:"
		Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_monto
		'
		Me.tx_monto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_monto.Location = New System.Drawing.Point(140, 237)
		Me.tx_monto.Multiline = true
		Me.tx_monto.Name = "tx_monto"
		Me.tx_monto.Size = New System.Drawing.Size(321, 29)
		Me.tx_monto.TabIndex = 20
		Me.tx_monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'label6
		'
		Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label6.Location = New System.Drawing.Point(7, 277)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(147, 29)
		Me.label6.TabIndex = 19
		Me.label6.Text = "CONCEPTO:"
		Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_concepto
		'
		Me.tx_concepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_concepto.Location = New System.Drawing.Point(7, 306)
		Me.tx_concepto.Multiline = true
		Me.tx_concepto.Name = "tx_concepto"
		Me.tx_concepto.Size = New System.Drawing.Size(948, 72)
		Me.tx_concepto.TabIndex = 18
		Me.tx_concepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(467, 197)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(127, 29)
		Me.button1.TabIndex = 17
		Me.button1.Text = "Buscar Factura"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'label1
		'
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(15, 197)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(107, 29)
		Me.label1.TabIndex = 16
		Me.label1.Text = "Fact Nro:"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_factu
		'
		Me.tx_factu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_factu.Location = New System.Drawing.Point(140, 197)
		Me.tx_factu.Multiline = true
		Me.tx_factu.Name = "tx_factu"
		Me.tx_factu.Size = New System.Drawing.Size(321, 29)
		Me.tx_factu.TabIndex = 15
		Me.tx_factu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'panel4
		'
		Me.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel4.Controls.Add(Me.tx_nro_recibo)
		Me.panel4.Controls.Add(Me.label5)
		Me.panel4.Location = New System.Drawing.Point(611, 65)
		Me.panel4.Name = "panel4"
		Me.panel4.Size = New System.Drawing.Size(352, 100)
		Me.panel4.TabIndex = 10
		'
		'tx_nro_recibo
		'
		Me.tx_nro_recibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_nro_recibo.Location = New System.Drawing.Point(186, 13)
		Me.tx_nro_recibo.Name = "tx_nro_recibo"
		Me.tx_nro_recibo.ShortcutsEnabled = false
		Me.tx_nro_recibo.Size = New System.Drawing.Size(145, 26)
		Me.tx_nro_recibo.TabIndex = 8
		Me.tx_nro_recibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'label5
		'
		Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.Location = New System.Drawing.Point(3, 10)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(177, 29)
		Me.label5.TabIndex = 7
		Me.label5.Text = "RECIBO NRO:"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label4
		'
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(59, 135)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(63, 29)
		Me.label4.TabIndex = 14
		Me.label4.Text = "TEL:"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label3
		'
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.Location = New System.Drawing.Point(51, 100)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(71, 29)
		Me.label3.TabIndex = 13
		Me.label3.Text = "RUC:"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(7, 65)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(115, 29)
		Me.label2.TabIndex = 12
		Me.label2.Text = "CLIENTE:"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_tel_cliente
		'
		Me.tx_tel_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_tel_cliente.Location = New System.Drawing.Point(140, 135)
		Me.tx_tel_cliente.Multiline = true
		Me.tx_tel_cliente.Name = "tx_tel_cliente"
		Me.tx_tel_cliente.Size = New System.Drawing.Size(321, 29)
		Me.tx_tel_cliente.TabIndex = 11
		Me.tx_tel_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'tx_ruc_cliente
		'
		Me.tx_ruc_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_ruc_cliente.Location = New System.Drawing.Point(140, 100)
		Me.tx_ruc_cliente.Multiline = true
		Me.tx_ruc_cliente.Name = "tx_ruc_cliente"
		Me.tx_ruc_cliente.Size = New System.Drawing.Size(321, 29)
		Me.tx_ruc_cliente.TabIndex = 10
		Me.tx_ruc_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'tx_nom_cliente
		'
		Me.tx_nom_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_nom_cliente.Location = New System.Drawing.Point(140, 65)
		Me.tx_nom_cliente.Multiline = true
		Me.tx_nom_cliente.Name = "tx_nom_cliente"
		Me.tx_nom_cliente.Size = New System.Drawing.Size(321, 29)
		Me.tx_nom_cliente.TabIndex = 9
		Me.tx_nom_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'button3
		'
		Me.button3.BackColor = System.Drawing.SystemColors.ScrollBar
		Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button3.Location = New System.Drawing.Point(467, 63)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(127, 101)
		Me.button3.TabIndex = 3
		Me.button3.Text = "Buscar Cliente"
		Me.button3.UseVisualStyleBackColor = false
		AddHandler Me.button3.Click, AddressOf Me.Button3Click
		'
		'form_recibos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(998, 477)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.panel1)
		Me.Name = "form_recibos"
		Me.Text = "form_recibos"
		AddHandler Load, AddressOf Me.Form_recibosLoad
		Me.panel1.ResumeLayout(false)
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		Me.panel4.ResumeLayout(false)
		Me.panel4.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private tx_id_factu As System.Windows.Forms.TextBox
	Private dtp1 As System.Windows.Forms.DateTimePicker
	Private label14 As System.Windows.Forms.Label
	Private tx_id_cliente As System.Windows.Forms.TextBox
	Private tx_monto As System.Windows.Forms.TextBox
	Private label7 As System.Windows.Forms.Label
	Private button4 As System.Windows.Forms.Button
	Private button1 As System.Windows.Forms.Button
	Private tx_concepto As System.Windows.Forms.TextBox
	Private label6 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private tx_nro_recibo As System.Windows.Forms.TextBox
	Private panel4 As System.Windows.Forms.Panel
	Private tx_factu As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private tx_nom_cliente As System.Windows.Forms.TextBox
	Private tx_ruc_cliente As System.Windows.Forms.TextBox
	Private tx_tel_cliente As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private button3 As System.Windows.Forms.Button
	Private panel2 As System.Windows.Forms.Panel
	Private button2 As System.Windows.Forms.Button
	Private panel1 As System.Windows.Forms.Panel
End Class
