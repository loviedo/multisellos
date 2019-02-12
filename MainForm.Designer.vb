'
' Created by SharpDevelop.
' User: Luis
' Date: 9/23/2018
' Time: 10:51 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
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
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.adminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.configurarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.acercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.salirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.faToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.emitirFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.emitirTicketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.recibosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.clientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.administrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.productosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.administrarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.proveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.administrarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.menuStrip1.SuspendLayout
		Me.SuspendLayout
		'
		'menuStrip1
		'
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.adminToolStripMenuItem, Me.faToolStripMenuItem, Me.clientesToolStripMenuItem, Me.productosToolStripMenuItem, Me.proveedoresToolStripMenuItem})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Size = New System.Drawing.Size(1372, 24)
		Me.menuStrip1.TabIndex = 0
		Me.menuStrip1.Text = "menuStrip1"
		'
		'adminToolStripMenuItem
		'
		Me.adminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.configurarToolStripMenuItem, Me.acercaDeToolStripMenuItem, Me.salirToolStripMenuItem})
		Me.adminToolStripMenuItem.Name = "adminToolStripMenuItem"
		Me.adminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
		Me.adminToolStripMenuItem.Text = "Admin"
		'
		'configurarToolStripMenuItem
		'
		Me.configurarToolStripMenuItem.Name = "configurarToolStripMenuItem"
		Me.configurarToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
		Me.configurarToolStripMenuItem.Text = "Configurar..."
		AddHandler Me.configurarToolStripMenuItem.Click, AddressOf Me.ConfigurarToolStripMenuItemClick
		'
		'acercaDeToolStripMenuItem
		'
		Me.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem"
		Me.acercaDeToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
		Me.acercaDeToolStripMenuItem.Text = "Acerca de"
		'
		'salirToolStripMenuItem
		'
		Me.salirToolStripMenuItem.Name = "salirToolStripMenuItem"
		Me.salirToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
		Me.salirToolStripMenuItem.Text = "Salir"
		AddHandler Me.salirToolStripMenuItem.Click, AddressOf Me.SalirToolStripMenuItemClick
		'
		'faToolStripMenuItem
		'
		Me.faToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.emitirFacturaToolStripMenuItem, Me.emitirTicketToolStripMenuItem, Me.recibosToolStripMenuItem})
		Me.faToolStripMenuItem.Name = "faToolStripMenuItem"
		Me.faToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
		Me.faToolStripMenuItem.Text = "Facturacion"
		'
		'emitirFacturaToolStripMenuItem
		'
		Me.emitirFacturaToolStripMenuItem.Name = "emitirFacturaToolStripMenuItem"
		Me.emitirFacturaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.emitirFacturaToolStripMenuItem.Text = "Facturas"
		AddHandler Me.emitirFacturaToolStripMenuItem.Click, AddressOf Me.EmitirFacturaToolStripMenuItemClick
		'
		'emitirTicketToolStripMenuItem
		'
		Me.emitirTicketToolStripMenuItem.Name = "emitirTicketToolStripMenuItem"
		Me.emitirTicketToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.emitirTicketToolStripMenuItem.Text = "Tickets"
		AddHandler Me.emitirTicketToolStripMenuItem.Click, AddressOf Me.EmitirTicketToolStripMenuItemClick
		'
		'recibosToolStripMenuItem
		'
		Me.recibosToolStripMenuItem.Name = "recibosToolStripMenuItem"
		Me.recibosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.recibosToolStripMenuItem.Text = "Recibos"
		AddHandler Me.recibosToolStripMenuItem.Click, AddressOf Me.RecibosToolStripMenuItemClick
		'
		'clientesToolStripMenuItem
		'
		Me.clientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.administrarToolStripMenuItem})
		Me.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem"
		Me.clientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
		Me.clientesToolStripMenuItem.Text = "Clientes"
		'
		'administrarToolStripMenuItem
		'
		Me.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem"
		Me.administrarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.administrarToolStripMenuItem.Text = "Administrar..."
		AddHandler Me.administrarToolStripMenuItem.Click, AddressOf Me.AdministrarToolStripMenuItemClick
		'
		'productosToolStripMenuItem
		'
		Me.productosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.administrarToolStripMenuItem1})
		Me.productosToolStripMenuItem.Name = "productosToolStripMenuItem"
		Me.productosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
		Me.productosToolStripMenuItem.Text = "Productos"
		'
		'administrarToolStripMenuItem1
		'
		Me.administrarToolStripMenuItem1.Name = "administrarToolStripMenuItem1"
		Me.administrarToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
		Me.administrarToolStripMenuItem1.Text = "Administrar..."
		AddHandler Me.administrarToolStripMenuItem1.Click, AddressOf Me.AdministrarToolStripMenuItem1Click
		'
		'proveedoresToolStripMenuItem
		'
		Me.proveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.administrarToolStripMenuItem2})
		Me.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem"
		Me.proveedoresToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
		Me.proveedoresToolStripMenuItem.Text = "Proveedores"
		'
		'administrarToolStripMenuItem2
		'
		Me.administrarToolStripMenuItem2.Name = "administrarToolStripMenuItem2"
		Me.administrarToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
		Me.administrarToolStripMenuItem2.Text = "Administrar..."
		AddHandler Me.administrarToolStripMenuItem2.Click, AddressOf Me.AdministrarToolStripMenuItem2Click
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1372, 613)
		Me.Controls.Add(Me.menuStrip1)
		Me.MainMenuStrip = Me.menuStrip1
		Me.Name = "MainForm"
		Me.Text = "MULTISELLOS"
		AddHandler Load, AddressOf Me.MainFormLoad
		Me.menuStrip1.ResumeLayout(false)
		Me.menuStrip1.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private recibosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private administrarToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Private proveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private administrarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private productosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private administrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private clientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private emitirTicketToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private emitirFacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private faToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private configurarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private salirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private acercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private adminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private menuStrip1 As System.Windows.Forms.MenuStrip
End Class
