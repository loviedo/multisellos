'
' Created by SharpDevelop.
' User: Luis
' Date: 31/3/2019
' Time: 09:30
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports Excel = Microsoft.Office.Interop.Excel

Public Partial Class form_recibos
	
	Dim con_str = "Server=localhost\SQLEXPRESS;Database=MULTISELLOS;User Id=admin;Password=Super123;"
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
		
	End Sub
	
	Sub Form_recibosLoad(sender As Object, e As EventArgs)
		Me.CenterToScreen()		
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		Me.Close()
		
	End Sub
	
	Sub Button3Click(sender As Object, e As EventArgs)
		'Llamamos al formulario de abm de clientes
		Dim cli As New form_cliente()
		If cli.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
			' traemos el contenido
			tx_nom_cliente.Text = cli.textBox1.Text 'cliente nombre
			tx_ruc_cliente.text = cli.textBox2.Text 'cliente RUC
			tx_tel_cliente.Text = cli.textBox3.Text 'cliente tel	
    	Else
        	'tx_nom_cliente.Text = "Cancelado"
    	End If
    	cli.Dispose()		
	End Sub
	
	Sub Button4Click(sender As Object, e As EventArgs)
		'guardamos e imprimimos
		
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		'Llamamos al formulario de BUSCAR FACTURAS
		Dim fact As New form_busca_fact()
		If fact.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
			' traemos el contenido
			tx_factu.Text = "asd"
    	Else
        	'tx_nom_cliente.Text = "Cancelado"
    	End If
    	fact.Dispose()	
	End Sub
End Class
