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
			tx_id_cliente.Text = cli.id_cli'traemos el id del cliente del formulario
    	Else
        	'tx_nom_cliente.Text = "Cancelado"
    	End If
    	cli.Dispose()		
	End Sub
	
	Sub Button4Click(sender As Object, e As EventArgs)
		'guardamos e imprimimos
		
		' vemos la fecha a cargar
		Dim fec_actual As Date = dtp1.Value
		
		
		'GUARDAMOS
		Dim conn = New System.Data.SqlClient.SqlConnection(con_str)
		
		'******************************************************************************INSERTAMOS DATOS DE FACTURA
		Dim cli_ins As New SqlCommand("INSERT INTO recibos ([fecha],[nro_recibo], [id_cliente], [id_factura], [monto], [concepto])" &
			" VALUES(@fecha,@nro_recibo, @id_cliente, @id_factura, @monto, @concepto)", conn)
		
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@fecha", .SqlDbType = SqlDbType.Date, .Value = fec_actual})
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@nro_recibo", .SqlDbType = SqlDbType.NVarChar, .Value = tx_nro_recibo.Text})
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@id_cliente", .SqlDbType = SqlDbType.NVarChar, .Value = tx_id_cliente.Text})
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@id_factura", .SqlDbType = SqlDbType.NVarChar, .Value = tx_id_factu.Text})'nro de factura
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@monto", .SqlDbType = SqlDbType.Int, .Value = Convert.ToInt32(tx_monto.Text)})'nro de remision
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@concepto", .SqlDbType = SqlDbType.NVarChar, .Value = tx_concepto.Text})
		
		
		Try
			conn.Open()
		    If cli_ins.ExecuteNonQuery() Then
		    	Messagebox.Show("Insertado Exitosamente.")
		    Else
		    	Messagebox.Show("Error al insertar.")
		    End If
		Catch ex As Exception
			MessageBox.Show(ex.Message.ToString)
		Finally
			conn.Close()
			cli_ins.Dispose()
		End Try
		
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		'Llamamos al formulario de BUSCAR FACTURAS
		Dim fact As New form_busca_fact()
		If fact.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
			' traemos el contenido
			tx_factu.Text = fact.nro_factu
			tx_id_factu.Text = fact.id_factu
    	Else
        	'tx_nom_cliente.Text = "Cancelado"
    	End If
    	fact.Dispose()	
	End Sub
End Class
