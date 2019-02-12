'
' Created by SharpDevelop.
' User: Luis
' Date: 9/23/2018
' Time: 10:51 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		'ampliamos la pantalla
		Me.WindowState = FormWindowState.Maximized
	End Sub
	
	Sub SalirToolStripMenuItemClick(sender As Object, e As EventArgs)
		'Cerrar programa
		Application.Exit
	End Sub
	
	Sub ConfigurarToolStripMenuItemClick(sender As Object, e As EventArgs)
		'Llamamos al formulario de configuraciones
		Dim confi As New form_conf()
		If confi.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
        	' traemos el contenido
    	Else
        	'tx_nom_cliente.Text = "Cancelado"
    	End If
    	confi.Dispose()
	End Sub
	
	
	Sub EmitirFacturaToolStripMenuItemClick(sender As Object, e As EventArgs)
		'llamamos al form de facturas
		
		Dim factu As New Form_facturas()
		If factu.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
        	' traemos el contenido
    	Else
        	'tx_nom_cliente.Text = "Cancelado"
    	End If
    	factu.Dispose()
	End Sub
	
	Sub EmitirTicketToolStripMenuItemClick(sender As Object, e As EventArgs)
		''abrir form de emitir ticket
	End Sub
	
	Sub AdministrarToolStripMenuItemClick(sender As Object, e As EventArgs)
		'Llamamos al formulario de abm de clientes
		Dim cli As New form_cliente()
		If cli.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
        	' traemos el contenido
    	Else
        	'tx_nom_cliente.Text = "Cancelado"
    	End If
    	cli.Dispose()
	End Sub
	
	Sub AdministrarToolStripMenuItem1Click(sender As Object, e As EventArgs)
		'Llamamos al formulario de PRODUCTOS de clientes
		Dim cli As New Form_productos()
		If cli.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
        	' traemos el contenido
    	Else
        	'tx_nom_cliente.Text = "Cancelado"
    	End If
    	cli.Dispose()
	End Sub
	
	Sub AdministrarToolStripMenuItem2Click(sender As Object, e As EventArgs)
		'Llamamos al formulario de PROVEEDORES de clientes
		Dim prov As New form_proveedor()
		If prov.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
        	'traemos el contenido
    	Else
        	'tx_nom_cliente.Text = "Cancelado"
    	End If
    	prov.Dispose()
	End Sub
	
	Sub RecibosToolStripMenuItemClick(sender As Object, e As EventArgs)
		'llamamos el form del recibo
	End Sub
End Class
