'
' Created by SharpDevelop.
' User: Luis
' Date: 10/4/2019
' Time: 22:48
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class form_compras
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
		Me.button3 = New System.Windows.Forms.Button()
		Me.button2 = New System.Windows.Forms.Button()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.label14 = New System.Windows.Forms.Label()
		Me.dtp1 = New System.Windows.Forms.DateTimePicker()
		Me.tx_id_prov = New System.Windows.Forms.TextBox()
		Me.label7 = New System.Windows.Forms.Label()
		Me.tx_monto = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.tx_factu = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.tx_tel_prov = New System.Windows.Forms.TextBox()
		Me.tx_ruc_prov = New System.Windows.Forms.TextBox()
		Me.tx_nom_prov = New System.Windows.Forms.TextBox()
		Me.button1 = New System.Windows.Forms.Button()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.label1 = New System.Windows.Forms.Label()
		Me.panel1.SuspendLayout
		Me.panel2.SuspendLayout
		Me.panel3.SuspendLayout
		Me.SuspendLayout
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.SystemColors.ControlDark
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.button3)
		Me.panel1.Controls.Add(Me.button2)
		Me.panel1.Location = New System.Drawing.Point(12, 397)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(762, 54)
		Me.panel1.TabIndex = 7
		'
		'button3
		'
		Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button3.Location = New System.Drawing.Point(23, 6)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(204, 43)
		Me.button3.TabIndex = 1
		Me.button3.Text = "Cancelar"
		Me.button3.UseVisualStyleBackColor = true
		AddHandler Me.button3.Click, AddressOf Me.Button3Click
		'
		'button2
		'
		Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button2.Location = New System.Drawing.Point(532, 6)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(208, 43)
		Me.button2.TabIndex = 0
		Me.button2.Text = "Cargar datos"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'panel2
		'
		Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel2.Controls.Add(Me.label14)
		Me.panel2.Controls.Add(Me.dtp1)
		Me.panel2.Controls.Add(Me.tx_id_prov)
		Me.panel2.Controls.Add(Me.label7)
		Me.panel2.Controls.Add(Me.tx_monto)
		Me.panel2.Controls.Add(Me.label2)
		Me.panel2.Controls.Add(Me.tx_factu)
		Me.panel2.Controls.Add(Me.label4)
		Me.panel2.Controls.Add(Me.label3)
		Me.panel2.Controls.Add(Me.label5)
		Me.panel2.Controls.Add(Me.tx_tel_prov)
		Me.panel2.Controls.Add(Me.tx_ruc_prov)
		Me.panel2.Controls.Add(Me.tx_nom_prov)
		Me.panel2.Controls.Add(Me.button1)
		Me.panel2.Location = New System.Drawing.Point(12, 72)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(762, 319)
		Me.panel2.TabIndex = 8
		'
		'label14
		'
		Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label14.Location = New System.Drawing.Point(70, 24)
		Me.label14.Name = "label14"
		Me.label14.Size = New System.Drawing.Size(107, 29)
		Me.label14.TabIndex = 43
		Me.label14.Text = "FECHA:"
		Me.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'dtp1
		'
		Me.dtp1.Location = New System.Drawing.Point(178, 29)
		Me.dtp1.Name = "dtp1"
		Me.dtp1.Size = New System.Drawing.Size(200, 20)
		Me.dtp1.TabIndex = 42
		Me.dtp1.Value = New Date(2019, 4, 10, 19, 48, 34, 0)
		'
		'tx_id_prov
		'
		Me.tx_id_prov.Location = New System.Drawing.Point(624, 252)
		Me.tx_id_prov.Name = "tx_id_prov"
		Me.tx_id_prov.Size = New System.Drawing.Size(100, 20)
		Me.tx_id_prov.TabIndex = 41
		Me.tx_id_prov.Visible = false
		'
		'label7
		'
		Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label7.Location = New System.Drawing.Point(65, 243)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(107, 29)
		Me.label7.TabIndex = 40
		Me.label7.Text = "MONTO:"
		Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_monto
		'
		Me.tx_monto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_monto.Location = New System.Drawing.Point(178, 243)
		Me.tx_monto.Multiline = true
		Me.tx_monto.Name = "tx_monto"
		Me.tx_monto.Size = New System.Drawing.Size(302, 29)
		Me.tx_monto.TabIndex = 39
		Me.tx_monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(62, 203)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(107, 29)
		Me.label2.TabIndex = 38
		Me.label2.Text = "Fact Nro:"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_factu
		'
		Me.tx_factu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_factu.Location = New System.Drawing.Point(178, 203)
		Me.tx_factu.Multiline = true
		Me.tx_factu.Name = "tx_factu"
		Me.tx_factu.Size = New System.Drawing.Size(302, 29)
		Me.tx_factu.TabIndex = 37
		Me.tx_factu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'label4
		'
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(106, 141)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(63, 29)
		Me.label4.TabIndex = 36
		Me.label4.Text = "TEL:"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label3
		'
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.Location = New System.Drawing.Point(98, 106)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(71, 29)
		Me.label3.TabIndex = 35
		Me.label3.Text = "RUC:"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label5
		'
		Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.Location = New System.Drawing.Point(3, 71)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(169, 29)
		Me.label5.TabIndex = 34
		Me.label5.Text = "PROVEEDOR:"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_tel_prov
		'
		Me.tx_tel_prov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_tel_prov.Location = New System.Drawing.Point(178, 141)
		Me.tx_tel_prov.Multiline = true
		Me.tx_tel_prov.Name = "tx_tel_prov"
		Me.tx_tel_prov.Size = New System.Drawing.Size(302, 29)
		Me.tx_tel_prov.TabIndex = 33
		Me.tx_tel_prov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'tx_ruc_prov
		'
		Me.tx_ruc_prov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_ruc_prov.Location = New System.Drawing.Point(178, 106)
		Me.tx_ruc_prov.Multiline = true
		Me.tx_ruc_prov.Name = "tx_ruc_prov"
		Me.tx_ruc_prov.Size = New System.Drawing.Size(302, 29)
		Me.tx_ruc_prov.TabIndex = 32
		Me.tx_ruc_prov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'tx_nom_prov
		'
		Me.tx_nom_prov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_nom_prov.Location = New System.Drawing.Point(178, 71)
		Me.tx_nom_prov.Multiline = true
		Me.tx_nom_prov.Name = "tx_nom_prov"
		Me.tx_nom_prov.Size = New System.Drawing.Size(302, 29)
		Me.tx_nom_prov.TabIndex = 31
		Me.tx_nom_prov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'button1
		'
		Me.button1.BackColor = System.Drawing.SystemColors.ScrollBar
		Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button1.Location = New System.Drawing.Point(486, 69)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(127, 101)
		Me.button1.TabIndex = 30
		Me.button1.Text = "Buscar Poveedor"
		Me.button1.UseVisualStyleBackColor = false
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'panel3
		'
		Me.panel3.BackColor = System.Drawing.SystemColors.ControlDark
		Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel3.Controls.Add(Me.label1)
		Me.panel3.Location = New System.Drawing.Point(12, 12)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(762, 54)
		Me.panel3.TabIndex = 9
		'
		'label1
		'
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(3, 10)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(127, 31)
		Me.label1.TabIndex = 0
		Me.label1.Text = "COMPRAS"
		'
		'form_compras
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(786, 463)
		Me.Controls.Add(Me.panel3)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.panel1)
		Me.Name = "form_compras"
		Me.Text = "form_compras"
		AddHandler Load, AddressOf Me.Form_comprasLoad
		Me.panel1.ResumeLayout(false)
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		Me.panel3.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private button1 As System.Windows.Forms.Button
	Private tx_nom_prov As System.Windows.Forms.TextBox
	Private tx_ruc_prov As System.Windows.Forms.TextBox
	Private tx_tel_prov As System.Windows.Forms.TextBox
	Private label5 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private tx_factu As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private tx_monto As System.Windows.Forms.TextBox
	Private label7 As System.Windows.Forms.Label
	Private tx_id_prov As System.Windows.Forms.TextBox
	Private dtp1 As System.Windows.Forms.DateTimePicker
	Private label14 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private panel3 As System.Windows.Forms.Panel
	Private panel2 As System.Windows.Forms.Panel
	Private button2 As System.Windows.Forms.Button
	Private button3 As System.Windows.Forms.Button
	Private panel1 As System.Windows.Forms.Panel
End Class
