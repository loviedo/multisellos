'
' Created by SharpDevelop.
' User: Luis
' Date: 10/8/2018
' Time: 7:23 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports Excel = Microsoft.Office.Interop.Excel

Public Partial Class Form_facturas
	
	
	Dim con_str = "Server=localhost\SQLEXPRESS;Database=MULTISELLOS;User Id=admin;Password=Super123;"
	
	Dim tipo_factura = "CONTADO"

	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'

	End Sub
	
	Sub Button4Click(sender As Object, e As EventArgs)
		'aqui guardamos los datos y luego imprimimos.
		MessageBox.Show(tipo_factura)
		If tipo_factura = "CONTADO" Or tipo_factura = "CREDITO" Then
			'guardamos e imprimimos
			
			
			
		End If

		

	End Sub
	
	Sub Button3Click(sender As Object, e As EventArgs)
		'Llamamos al formulario de abm de clientes
		Dim cli As New form_cliente()
		If cli.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
			'traemos el contenido
			tx_nom_cliente.Text = cli.textBox1.Text 'cliente nombre
			tx_ruc_cliente.text = cli.textBox2.Text 'cliente RUC
			tx_tel_cliente.Text = cli.textBox3.Text 'cliente tel	
    	Else
        	'tx_nom_cliente.Text = "Cancelado"
    	End If
    	cli.Dispose()
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		Me.Close()		
	End Sub
	
	Sub CheckBox1CheckedChanged(sender As Object, e As EventArgs)
		If ch_contado.Checked = True Then
			ch_credito.Checked = False
			tipo_factura = "CONTADO"
		Else
			tipo_factura = ""
		End If
	End Sub
	
	Sub Ch_creditoCheckedChanged(sender As Object, e As EventArgs)
		If ch_credito.Checked = True Then
			ch_contado.Checked = False
			tipo_factura = "CREDITO"
		Else
			tipo_factura = ""
		End If
	End Sub
	
	Sub Form_facturasLoad(sender As Object, e As EventArgs)
		Me.CenterToScreen()	
		
		'chequeamos el contado
		ch_contado.Checked = true
		
		'inicializamos el DGV1
		dataGridView1.Columns.Add("CODIGO","CODIGO")
		dataGridView1.Columns.Add("DESCRIPCION","DESCRIPCION")
		dataGridView1.Columns.Add("CANTIDAD","CANTIDAD")
		dataGridView1.Columns.Add("PRECIO","PRECIO")
		dataGridView1.Columns.Add("TOTAL","TOTAL")
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		'Llamamos al formulario de BUSCAR FACTURAS
		Dim prod As New form_busca_prod()
		If prod.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
			'Cargamos el gridview segun los datos selecccionados.
			DataGridView1.Rows.Add(False,prod.TextBox1.Text,prod.TextBox2.Text, prod.tx_canti.Text, prod.comboBox1.text,"002345")
			DataGridView1.Refresh
    	Else
        	'tx_nom_cliente.Text = "Cancelado"
    	End If
    	prod.Dispose()	
	End Sub
End Class
