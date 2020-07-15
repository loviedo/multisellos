'
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
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.timbradosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.listarTimbradosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.seleccionarTimbradosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.label5 = New System.Windows.Forms.Label()
		Me.tx_nro_ini = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.panel1.SuspendLayout
		Me.menuStrip1.SuspendLayout
		Me.SuspendLayout
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(571, 430)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(199, 36)
		Me.button1.TabIndex = 0
		Me.button1.Text = "Salir"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'panel1
		'
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.label5)
		Me.panel1.Controls.Add(Me.tx_nro_ini)
		Me.panel1.Location = New System.Drawing.Point(12, 68)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(758, 347)
		Me.panel1.TabIndex = 1
		'
		'menuStrip1
		'
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.timbradosToolStripMenuItem})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Size = New System.Drawing.Size(782, 24)
		Me.menuStrip1.TabIndex = 2
		Me.menuStrip1.Text = "menuStrip1"
		'
		'timbradosToolStripMenuItem
		'
		Me.timbradosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.listarTimbradosToolStripMenuItem, Me.seleccionarTimbradosToolStripMenuItem})
		Me.timbradosToolStripMenuItem.Name = "timbradosToolStripMenuItem"
		Me.timbradosToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
		Me.timbradosToolStripMenuItem.Text = "Timbrados"
		'
		'listarTimbradosToolStripMenuItem
		'
		Me.listarTimbradosToolStripMenuItem.Name = "listarTimbradosToolStripMenuItem"
		Me.listarTimbradosToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
		Me.listarTimbradosToolStripMenuItem.Text = "Listado Timbrados"
		AddHandler Me.listarTimbradosToolStripMenuItem.Click, AddressOf Me.ListarTimbradosToolStripMenuItemClick
		'
		'seleccionarTimbradosToolStripMenuItem
		'
		Me.seleccionarTimbradosToolStripMenuItem.Name = "seleccionarTimbradosToolStripMenuItem"
		Me.seleccionarTimbradosToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
		Me.seleccionarTimbradosToolStripMenuItem.Text = "Alta Timbrados"
		AddHandler Me.seleccionarTimbradosToolStripMenuItem.Click, AddressOf Me.SeleccionarTimbradosToolStripMenuItemClick
		'
		'label5
		'
		Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.Location = New System.Drawing.Point(3, 10)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(248, 29)
		Me.label5.TabIndex = 35
		Me.label5.Text = "Nro Timbrado Vigente:"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_nro_ini
		'
		Me.tx_nro_ini.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_nro_ini.Location = New System.Drawing.Point(15, 45)
		Me.tx_nro_ini.Multiline = true
		Me.tx_nro_ini.Name = "tx_nro_ini"
		Me.tx_nro_ini.ReadOnly = true
		Me.tx_nro_ini.Size = New System.Drawing.Size(430, 29)
		Me.tx_nro_ini.TabIndex = 2
		Me.tx_nro_ini.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'label1
		'
		Me.label1.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(12, 24)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(758, 41)
		Me.label1.TabIndex = 18
		Me.label1.Text = "Configuración Sistema"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'form_conf
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(782, 478)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.panel1)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.menuStrip1)
		Me.MainMenuStrip = Me.menuStrip1
		Me.Name = "form_conf"
		Me.Text = "form_conf"
		AddHandler Load, AddressOf Me.Form_confLoad
		Me.panel1.ResumeLayout(false)
		Me.panel1.PerformLayout
		Me.menuStrip1.ResumeLayout(false)
		Me.menuStrip1.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private label1 As System.Windows.Forms.Label
	Private tx_nro_ini As System.Windows.Forms.TextBox
	Private label5 As System.Windows.Forms.Label
	Private seleccionarTimbradosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private listarTimbradosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private timbradosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private menuStrip1 As System.Windows.Forms.MenuStrip
	Private panel1 As System.Windows.Forms.Panel
	Private button1 As System.Windows.Forms.Button
End Class
