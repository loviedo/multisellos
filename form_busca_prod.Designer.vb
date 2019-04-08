'
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
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.comboBox1 = New System.Windows.Forms.ComboBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.tx_canti = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.textBox4 = New System.Windows.Forms.TextBox()
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.button3 = New System.Windows.Forms.Button()
		Me.button2 = New System.Windows.Forms.Button()
		Me.panel2.SuspendLayout
		Me.panel3.SuspendLayout
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel1.SuspendLayout
		Me.SuspendLayout
		'
		'panel2
		'
		Me.panel2.Controls.Add(Me.panel3)
		Me.panel2.Controls.Add(Me.label1)
		Me.panel2.Controls.Add(Me.textBox4)
		Me.panel2.Controls.Add(Me.dataGridView1)
		Me.panel2.Location = New System.Drawing.Point(12, 12)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(762, 494)
		Me.panel2.TabIndex = 9
		'
		'panel3
		'
		Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel3.Controls.Add(Me.comboBox1)
		Me.panel3.Controls.Add(Me.label2)
		Me.panel3.Controls.Add(Me.tx_canti)
		Me.panel3.Controls.Add(Me.label4)
		Me.panel3.Controls.Add(Me.label3)
		Me.panel3.Controls.Add(Me.label5)
		Me.panel3.Controls.Add(Me.textBox2)
		Me.panel3.Controls.Add(Me.textBox1)
		Me.panel3.Location = New System.Drawing.Point(12, 346)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(736, 148)
		Me.panel3.TabIndex = 13
		'
		'comboBox1
		'
		Me.comboBox1.FormattingEnabled = true
		Me.comboBox1.Location = New System.Drawing.Point(468, 24)
		Me.comboBox1.Name = "comboBox1"
		Me.comboBox1.Size = New System.Drawing.Size(155, 21)
		Me.comboBox1.TabIndex = 21
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(4, 88)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(133, 29)
		Me.label2.TabIndex = 20
		Me.label2.Text = "CANTIDAD:"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_canti
		'
		Me.tx_canti.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_canti.Location = New System.Drawing.Point(143, 92)
		Me.tx_canti.Name = "tx_canti"
		Me.tx_canti.Size = New System.Drawing.Size(81, 24)
		Me.tx_canti.TabIndex = 19
		'
		'label4
		'
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(346, 16)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(116, 29)
		Me.label4.TabIndex = 18
		Me.label4.Text = "PRECIO:"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label3
		'
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.Location = New System.Drawing.Point(1, 47)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(178, 29)
		Me.label3.TabIndex = 17
		Me.label3.Text = "DESCRIPCION:"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'label5
		'
		Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.Location = New System.Drawing.Point(3, 12)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(111, 29)
		Me.label5.TabIndex = 16
		Me.label5.Text = "CODIGO:"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'textBox2
		'
		Me.textBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox2.Location = New System.Drawing.Point(185, 51)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.Size = New System.Drawing.Size(416, 24)
		Me.textBox2.TabIndex = 14
		'
		'textBox1
		'
		Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox1.Location = New System.Drawing.Point(120, 16)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(200, 24)
		Me.textBox1.TabIndex = 13
		'
		'label1
		'
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(16, 15)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(134, 29)
		Me.label1.TabIndex = 8
		Me.label1.Text = "Buscar por Nro"
		'
		'textBox4
		'
		Me.textBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox4.Location = New System.Drawing.Point(156, 12)
		Me.textBox4.Name = "textBox4"
		Me.textBox4.Size = New System.Drawing.Size(197, 24)
		Me.textBox4.TabIndex = 7
		Me.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		AddHandler Me.textBox4.TextChanged, AddressOf Me.TextBox4TextChanged
		'
		'dataGridView1
		'
		Me.dataGridView1.AllowUserToAddRows = false
		Me.dataGridView1.AllowUserToDeleteRows = false
		Me.dataGridView1.AllowUserToOrderColumns = true
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Location = New System.Drawing.Point(12, 47)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.ReadOnly = true
		Me.dataGridView1.Size = New System.Drawing.Size(736, 293)
		Me.dataGridView1.TabIndex = 4
		AddHandler Me.dataGridView1.CellContentClick, AddressOf Me.DataGridView1CellContentClick
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.SystemColors.ControlDark
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.button3)
		Me.panel1.Controls.Add(Me.button2)
		Me.panel1.Location = New System.Drawing.Point(12, 512)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(762, 54)
		Me.panel1.TabIndex = 8
		'
		'button3
		'
		Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button3.Location = New System.Drawing.Point(543, 6)
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
		Me.button2.Location = New System.Drawing.Point(28, 6)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(208, 43)
		Me.button2.TabIndex = 0
		Me.button2.Text = "Cargar datos"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'form_busca_prod
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(788, 582)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.panel1)
		Me.Name = "form_busca_prod"
		Me.Text = "form_busca_prod"
		AddHandler Load, AddressOf Me.Form_busca_prodLoad
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		Me.panel3.ResumeLayout(false)
		Me.panel3.PerformLayout
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel1.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Public comboBox1 As System.Windows.Forms.ComboBox
	Public tx_canti As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private panel3 As System.Windows.Forms.Panel
	Private button2 As System.Windows.Forms.Button
	Private button3 As System.Windows.Forms.Button
	Private panel1 As System.Windows.Forms.Panel
	Public textBox1 As System.Windows.Forms.TextBox
	Private dataGridView1 As System.Windows.Forms.DataGridView
	Public textBox2 As System.Windows.Forms.TextBox
	Private textBox4 As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private panel2 As System.Windows.Forms.Panel
End Class
