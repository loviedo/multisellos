'
' Created by SharpDevelop.
' User: Luis
' Date: 9/23/2018
' Time: 12:02 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'


Imports System.Data
Imports System.Data.SqlClient

Public Partial Class form_add_cliente
	
	Dim con_str As String
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'c
		' TODO : Add constructor code after InitializeComponents
		'
		con_str = "Server=localhost\SQLEXPRESS;Database=MULTISELLOS;User Id=admin;Password=Super123;"
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		Me.Close()		
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		'insertamos el formulario cargado.		
		
		'aqui rellenamos en una tabla los clientes de entrada y luego filtramos segun escribamos.
	
		Dim conn = New System.Data.SqlClient.SqlConnection(con_str)
		
		Dim cli_ins As New SqlCommand("INSERT INTO clientes ([Nombre], [RUC], [Telefono], [Email], [Fec_nac], [Direccion])" &
                                  " VALUES(@Nombre, @RUC, @Telefono, @Email, @Fec_nac, @Direccion)", conn)

		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@Nombre", .SqlDbType = SqlDbType.NVarChar, .Value = tx_nom_c.Text})
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@RUC", .SqlDbType = SqlDbType.VarChar, .Value = tx_ruc_c.Text})
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@Telefono", .SqlDbType = SqlDbType.VarChar, .Value = tx_tel_c.Text})
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@Email", .SqlDbType = SqlDbType.VarChar, .Value = tx_email_c.Text})
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@Fec_nac", .SqlDbType = SqlDbType.DateTime, .Value = dt_fecnac_c.value})
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@Direccion", .SqlDbType = SqlDbType.NVarChar, .Value = tx_dir_c.Text})
		
		If tx_tel_c.TextLength > 0 And tx_ruc_c.TextLength > 0 And tx_nom_c.TextLength >0 Then
			'si no esta vacio insertamos.
			Try
				conn.Open()
			    
			    If cli_ins.ExecuteNonQuery() Then
			    	Messagebox.Show("Insertado Exitosamente.")
			    	tx_nom_c.Text = ""
			    	tx_ruc_c.Text  = ""
			    	tx_tel_c.Text = ""
			    	tx_email_c.Text = ""
			    	dt_fecnac_c.Text = ""
			    	tx_dir_c.Text = ""
			    	Me.DialogResult = Windows.Forms.DialogResult.OK
			    Else
			    	Messagebox.Show("Error al insertar.")
			    	Me.DialogResult = Windows.Forms.DialogResult.Cancel
			    End If
			    
			Catch ex As Exception
				MessageBox.Show(ex.Message.ToString)
			Finally
				conn.Close()
				cli_ins.Dispose()
				
				'refrescamos el DGV
				
			End Try
		Else
			MessageBox.Show("DEBE COMPLETAR LOS CAMPOS OBLIGATORIOS!")
		End If
	End Sub
	
	
	Sub Form_add_clienteLoad(sender As Object, e As EventArgs)
		Me.CenterToScreen()				
	End Sub
End Class
