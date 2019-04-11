'
' Created by SharpDevelop.
' User: Luis
' Date: 10/4/2019
' Time: 22:48
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Data
Imports System.Data.SqlClient


Public Partial Class form_compras
	
	Dim id_proveedor As Integer
	Dim con_str As String
	Public Sub New()
		
		con_str = "Server=localhost\SQLEXPRESS;Database=MULTISELLOS;User Id=admin;Password=Super123;"
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub Form_comprasLoad(sender As Object, e As EventArgs)
		Me.CenterToScreen()		
	End Sub
	
	Sub Button3Click(sender As Object, e As EventArgs)
		Me.Close()		
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		'Llamamos al formulario de abm de clientes
		Dim prov As New form_proveedor()
		If prov.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
			' traemos el contenido
			tx_nom_prov.Text = prov.textBox1.Text 'proveedor nombre
			tx_ruc_prov.text = prov.textBox2.Text 'proveedor RUC
			tx_tel_prov.Text = prov.textBox3.Text 'proveedor tel	
			tx_id_prov.Text = prov.id_pro'traemos el id del proveedor del formulario
			id_proveedor = prov.id_pro
    	Else
        	'tx_nom_cliente.Text = "Cancelado"
    	End If
    	prov.Dispose()			
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		'fecha actual
		Dim fec_actual As Date = dtp1.Value
		
		'guardamos los datos
		Dim conn = New System.Data.SqlClient.SqlConnection(con_str)
		
		'******************************************************************************INSERTAMOS DATOS DE FACTURA
		Dim cli_ins As New SqlCommand("INSERT INTO compras ([fecha],[nro_factura], [id_proveedor],  [monto])" &
			" VALUES(@fecha,@nro_factura, @id_proveedor, @monto)", conn)
		
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@fecha", .SqlDbType = SqlDbType.Date, .Value = fec_actual})
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@nro_factura", .SqlDbType = SqlDbType.NVarChar, .Value = tx_factu.Text})
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@id_proveedor", .SqlDbType = SqlDbType.NVarChar, .Value = id_proveedor})
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@monto", .SqlDbType = SqlDbType.Int, .Value = Convert.ToInt32(tx_monto.Text)})		
		
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
End Class
