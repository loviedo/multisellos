'
' Created by SharpDevelop.
' User: Luis
' Date: 10/8/2018
' Time: 7:23 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class Form_facturas
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
		Me.label14 = New System.Windows.Forms.Label()
		Me.dtp1 = New System.Windows.Forms.DateTimePicker()
		Me.label13 = New System.Windows.Forms.Label()
		Me.tx_monto_total = New System.Windows.Forms.TextBox()
		Me.label12 = New System.Windows.Forms.Label()
		Me.tx_total_iva = New System.Windows.Forms.TextBox()
		Me.label11 = New System.Windows.Forms.Label()
		Me.tx_iva_5 = New System.Windows.Forms.TextBox()
		Me.label10 = New System.Windows.Forms.Label()
		Me.tx_iva_10 = New System.Windows.Forms.TextBox()
		Me.button6 = New System.Windows.Forms.Button()
		Me.label9 = New System.Windows.Forms.Label()
		Me.button1 = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.tx_remision = New System.Windows.Forms.TextBox()
		Me.ch_credito = New System.Windows.Forms.CheckBox()
		Me.ch_contado = New System.Windows.Forms.CheckBox()
		Me.panel4 = New System.Windows.Forms.Panel()
		Me.label8 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.tx_factu_num = New System.Windows.Forms.TextBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.tx_tel_cliente = New System.Windows.Forms.TextBox()
		Me.tx_ruc_cliente = New System.Windows.Forms.TextBox()
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		Me.checito = New System.Windows.Forms.DataGridViewCheckBoxColumn()
		Me.button3 = New System.Windows.Forms.Button()
		Me.tx_nom_cliente = New System.Windows.Forms.TextBox()
		Me.button4 = New System.Windows.Forms.Button()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.button2 = New System.Windows.Forms.Button()
		Me.panel2.SuspendLayout
		Me.panel4.SuspendLayout
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel1.SuspendLayout
		Me.SuspendLayout
		'
		'panel2
		'
		Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel2.Controls.Add(Me.label14)
		Me.panel2.Controls.Add(Me.dtp1)
		Me.panel2.Controls.Add(Me.label13)
		Me.panel2.Controls.Add(Me.tx_monto_total)
		Me.panel2.Controls.Add(Me.label12)
		Me.panel2.Controls.Add(Me.tx_total_iva)
		Me.panel2.Controls.Add(Me.label11)
		Me.panel2.Controls.Add(Me.tx_iva_5)
		Me.panel2.Controls.Add(Me.label10)
		Me.panel2.Controls.Add(Me.tx_iva_10)
		Me.panel2.Controls.Add(Me.button6)
		Me.panel2.Controls.Add(Me.label9)
		Me.panel2.Controls.Add(Me.button1)
		Me.panel2.Controls.Add(Me.label1)
		Me.panel2.Controls.Add(Me.tx_remision)
		Me.panel2.Controls.Add(Me.ch_credito)
		Me.panel2.Controls.Add(Me.ch_contado)
		Me.panel2.Controls.Add(Me.panel4)
		Me.panel2.Controls.Add(Me.label4)
		Me.panel2.Controls.Add(Me.label3)
		Me.panel2.Controls.Add(Me.label2)
		Me.panel2.Controls.Add(Me.tx_tel_cliente)
		Me.panel2.Controls.Add(Me.tx_ruc_cliente)
		Me.panel2.Controls.Add(Me.dataGridView1)
		Me.panel2.Controls.Add(Me.button3)
		Me.panel2.Controls.Add(Me.tx_nom_cliente)
		Me.panel2.Location = New System.Drawing.Point(12, 12)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(987, 641)
		Me.panel2.TabIndex = 7
		'
		'label14
		'
		Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label14.Location = New System.Drawing.Point(17, 7)
		Me.label14.Name = "label14"
		Me.label14.Size = New System.Drawing.Size(121, 29)
		Me.label14.TabIndex = 27
		Me.label14.Text = "FECHA:"
		Me.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'dtp1
		'
		Me.dtp1.Location = New System.Drawing.Point(156, 10)
		Me.dtp1.Name = "dtp1"
		Me.dtp1.Size = New System.Drawing.Size(200, 20)
		Me.dtp1.TabIndex = 26
		Me.dtp1.Value = New Date(2019, 4, 10, 19, 48, 34, 0)
		'
		'label13
		'
		Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label13.Location = New System.Drawing.Point(488, 565)
		Me.label13.Name = "label13"
		Me.label13.Size = New System.Drawing.Size(126, 29)
		Me.label13.TabIndex = 25
		Me.label13.Text = "MONTO TOTAL:"
		Me.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_monto_total
		'
		Me.tx_monto_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_monto_total.Location = New System.Drawing.Point(620, 566)
		Me.tx_monto_total.Multiline = true
		Me.tx_monto_total.Name = "tx_monto_total"
		Me.tx_monto_total.Size = New System.Drawing.Size(118, 29)
		Me.tx_monto_total.TabIndex = 24
		Me.tx_monto_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'label12
		'
		Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label12.Location = New System.Drawing.Point(227, 600)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(107, 29)
		Me.label12.TabIndex = 23
		Me.label12.Text = "TOTAL IVA:"
		Me.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_total_iva
		'
		Me.tx_total_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_total_iva.Location = New System.Drawing.Point(340, 601)
		Me.tx_total_iva.Multiline = true
		Me.tx_total_iva.Name = "tx_total_iva"
		Me.tx_total_iva.Size = New System.Drawing.Size(116, 29)
		Me.tx_total_iva.TabIndex = 22
		Me.tx_total_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'label11
		'
		Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label11.Location = New System.Drawing.Point(253, 565)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(81, 29)
		Me.label11.TabIndex = 21
		Me.label11.Text = "IVA 5%:"
		Me.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_iva_5
		'
		Me.tx_iva_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_iva_5.Location = New System.Drawing.Point(340, 566)
		Me.tx_iva_5.Multiline = true
		Me.tx_iva_5.Name = "tx_iva_5"
		Me.tx_iva_5.Size = New System.Drawing.Size(118, 29)
		Me.tx_iva_5.TabIndex = 20
		Me.tx_iva_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'label10
		'
		Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label10.Location = New System.Drawing.Point(29, 565)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(81, 29)
		Me.label10.TabIndex = 19
		Me.label10.Text = "IVA 10%:"
		Me.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_iva_10
		'
		Me.tx_iva_10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_iva_10.Location = New System.Drawing.Point(116, 566)
		Me.tx_iva_10.Multiline = true
		Me.tx_iva_10.Name = "tx_iva_10"
		Me.tx_iva_10.Size = New System.Drawing.Size(116, 29)
		Me.tx_iva_10.TabIndex = 18
		Me.tx_iva_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'button6
		'
		Me.button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button6.Location = New System.Drawing.Point(238, 193)
		Me.button6.Name = "button6"
		Me.button6.Size = New System.Drawing.Size(75, 23)
		Me.button6.TabIndex = 17
		Me.button6.Text = "eliminar"
		Me.button6.UseVisualStyleBackColor = true
		AddHandler Me.button6.Click, AddressOf Me.Button6Click
		'
		'label9
		'
		Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label9.Location = New System.Drawing.Point(7, 190)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(152, 29)
		Me.label9.TabIndex = 15
		Me.label9.Text = "PRODUCTOS"
		Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'button1
		'
		Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button1.Location = New System.Drawing.Point(167, 193)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(65, 23)
		Me.button1.TabIndex = 14
		Me.button1.Text = "agregar"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'label1
		'
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(3, 144)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(156, 29)
		Me.label1.TabIndex = 13
		Me.label1.Text = "Remisión Nro:"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_remision
		'
		Me.tx_remision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_remision.Location = New System.Drawing.Point(165, 144)
		Me.tx_remision.Multiline = true
		Me.tx_remision.Name = "tx_remision"
		Me.tx_remision.Size = New System.Drawing.Size(148, 29)
		Me.tx_remision.TabIndex = 12
		Me.tx_remision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'ch_credito
		'
		Me.ch_credito.Font = New System.Drawing.Font("Microsoft Sans Serif", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.ch_credito.Location = New System.Drawing.Point(788, 156)
		Me.ch_credito.Name = "ch_credito"
		Me.ch_credito.Size = New System.Drawing.Size(125, 24)
		Me.ch_credito.TabIndex = 11
		Me.ch_credito.Text = "CREDITO"
		Me.ch_credito.UseVisualStyleBackColor = true
		AddHandler Me.ch_credito.CheckedChanged, AddressOf Me.Ch_creditoCheckedChanged
		'
		'ch_contado
		'
		Me.ch_contado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.ch_contado.Location = New System.Drawing.Point(657, 156)
		Me.ch_contado.Name = "ch_contado"
		Me.ch_contado.Size = New System.Drawing.Size(125, 24)
		Me.ch_contado.TabIndex = 10
		Me.ch_contado.Text = "CONTADO"
		Me.ch_contado.UseVisualStyleBackColor = true
		AddHandler Me.ch_contado.CheckedChanged, AddressOf Me.CheckBox1CheckedChanged
		'
		'panel4
		'
		Me.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel4.Controls.Add(Me.label8)
		Me.panel4.Controls.Add(Me.label7)
		Me.panel4.Controls.Add(Me.label6)
		Me.panel4.Controls.Add(Me.tx_factu_num)
		Me.panel4.Controls.Add(Me.label5)
		Me.panel4.Location = New System.Drawing.Point(616, 35)
		Me.panel4.Name = "panel4"
		Me.panel4.Size = New System.Drawing.Size(366, 100)
		Me.panel4.TabIndex = 9
		'
		'label8
		'
		Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label8.Location = New System.Drawing.Point(209, 54)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(145, 29)
		Me.label8.TabIndex = 11
		Me.label8.Text = "label8"
		Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label7
		'
		Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label7.Location = New System.Drawing.Point(74, 54)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(129, 29)
		Me.label7.TabIndex = 10
		Me.label7.Text = "label7"
		Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label6
		'
		Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label6.Location = New System.Drawing.Point(3, 54)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(75, 29)
		Me.label6.TabIndex = 9
		Me.label6.Text = "NRO:"
		Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_factu_num
		'
		Me.tx_factu_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_factu_num.Location = New System.Drawing.Point(209, 12)
		Me.tx_factu_num.Name = "tx_factu_num"
		Me.tx_factu_num.ShortcutsEnabled = false
		Me.tx_factu_num.Size = New System.Drawing.Size(145, 26)
		Me.tx_factu_num.TabIndex = 8
		Me.tx_factu_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'label5
		'
		Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.Location = New System.Drawing.Point(3, 10)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(177, 29)
		Me.label5.TabIndex = 7
		Me.label5.Text = "FACTURA NRO:"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label4
		'
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(65, 106)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(73, 29)
		Me.label4.TabIndex = 8
		Me.label4.Text = "TEL:"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label3
		'
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.Location = New System.Drawing.Point(58, 71)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(80, 29)
		Me.label3.TabIndex = 7
		Me.label3.Text = "RUC:"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(17, 36)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(121, 29)
		Me.label2.TabIndex = 6
		Me.label2.Text = "CLIENTE:"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_tel_cliente
		'
		Me.tx_tel_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_tel_cliente.Location = New System.Drawing.Point(156, 106)
		Me.tx_tel_cliente.Multiline = true
		Me.tx_tel_cliente.Name = "tx_tel_cliente"
		Me.tx_tel_cliente.Size = New System.Drawing.Size(321, 29)
		Me.tx_tel_cliente.TabIndex = 5
		Me.tx_tel_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'tx_ruc_cliente
		'
		Me.tx_ruc_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_ruc_cliente.Location = New System.Drawing.Point(156, 71)
		Me.tx_ruc_cliente.Multiline = true
		Me.tx_ruc_cliente.Name = "tx_ruc_cliente"
		Me.tx_ruc_cliente.Size = New System.Drawing.Size(321, 29)
		Me.tx_ruc_cliente.TabIndex = 4
		Me.tx_ruc_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'dataGridView1
		'
		Me.dataGridView1.AllowUserToAddRows = false
		Me.dataGridView1.AllowUserToDeleteRows = false
		Me.dataGridView1.AllowUserToOrderColumns = true
		Me.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.checito})
		Me.dataGridView1.Location = New System.Drawing.Point(3, 224)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.Size = New System.Drawing.Size(979, 336)
		Me.dataGridView1.TabIndex = 3
		'
		'checito
		'
		Me.checito.HeaderText = "Seleccionar"
		Me.checito.Name = "checito"
		Me.checito.ToolTipText = "Chequear para seleccionar item"
		Me.checito.Width = 69
		'
		'button3
		'
		Me.button3.BackColor = System.Drawing.SystemColors.ScrollBar
		Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button3.Location = New System.Drawing.Point(483, 35)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(127, 101)
		Me.button3.TabIndex = 2
		Me.button3.Text = "Buscar Cliente"
		Me.button3.UseVisualStyleBackColor = false
		AddHandler Me.button3.Click, AddressOf Me.Button3Click
		'
		'tx_nom_cliente
		'
		Me.tx_nom_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_nom_cliente.Location = New System.Drawing.Point(156, 36)
		Me.tx_nom_cliente.Multiline = true
		Me.tx_nom_cliente.Name = "tx_nom_cliente"
		Me.tx_nom_cliente.Size = New System.Drawing.Size(321, 29)
		Me.tx_nom_cliente.TabIndex = 1
		Me.tx_nom_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'button4
		'
		Me.button4.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button4.Location = New System.Drawing.Point(788, 7)
		Me.button4.Name = "button4"
		Me.button4.Size = New System.Drawing.Size(194, 38)
		Me.button4.TabIndex = 3
		Me.button4.Text = "IMPRIMIR"
		Me.button4.UseVisualStyleBackColor = false
		AddHandler Me.button4.Click, AddressOf Me.Button4Click
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.SystemColors.ControlDark
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.button2)
		Me.panel1.Controls.Add(Me.button4)
		Me.panel1.Location = New System.Drawing.Point(12, 659)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(987, 53)
		Me.panel1.TabIndex = 6
		'
		'button2
		'
		Me.button2.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button2.Location = New System.Drawing.Point(7, 4)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(161, 44)
		Me.button2.TabIndex = 2
		Me.button2.Text = "Cancelar"
		Me.button2.UseVisualStyleBackColor = false
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'Form_facturas
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1008, 724)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.panel1)
		Me.Name = "Form_facturas"
		Me.Text = "Form_facturas"
		AddHandler Load, AddressOf Me.Form_facturasLoad
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		Me.panel4.ResumeLayout(false)
		Me.panel4.PerformLayout
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel1.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private label14 As System.Windows.Forms.Label
	Private dtp1 As System.Windows.Forms.DateTimePicker
	Private tx_monto_total As System.Windows.Forms.TextBox
	Private label13 As System.Windows.Forms.Label
	Private tx_iva_10 As System.Windows.Forms.TextBox
	Private label10 As System.Windows.Forms.Label
	Private tx_iva_5 As System.Windows.Forms.TextBox
	Private label11 As System.Windows.Forms.Label
	Private tx_total_iva As System.Windows.Forms.TextBox
	Private label12 As System.Windows.Forms.Label
	Private button6 As System.Windows.Forms.Button
	Private button1 As System.Windows.Forms.Button
	Private label9 As System.Windows.Forms.Label
	Private tx_remision As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private ch_credito As System.Windows.Forms.CheckBox
	Private ch_contado As System.Windows.Forms.CheckBox
	Private button2 As System.Windows.Forms.Button
	Private panel1 As System.Windows.Forms.Panel
	Private tx_nom_cliente As System.Windows.Forms.TextBox
	Private button3 As System.Windows.Forms.Button
	Private checito As System.Windows.Forms.DataGridViewCheckBoxColumn
	Private dataGridView1 As System.Windows.Forms.DataGridView
	Private button4 As System.Windows.Forms.Button
	Private tx_ruc_cliente As System.Windows.Forms.TextBox
	Private tx_tel_cliente As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private tx_factu_num As System.Windows.Forms.TextBox
	Private label6 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private panel4 As System.Windows.Forms.Panel
	Private panel2 As System.Windows.Forms.Panel
End Class
