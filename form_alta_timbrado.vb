'
' Created by SharpDevelop.
' User: Luis
' Date: 9/7/2020
' Time: 13:56
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.


Imports System.Data
Imports System.Data.SqlClient
'
Public Partial Class form_alta_timbrado
	Private con_str As String	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
		con_str = "Server=localhost\SQLEXPRESS;Database=MULTISELLOS;User Id=admin;Password=Super123;"
	End Sub
	
	
	Sub Form_alta_timbradoLoad(sender As Object, e As EventArgs)
		Me.CenterToScreen()

		
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		'cerrar sin hacer nada
		Me.Close()	
		
		
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		'guardamos los datos cargados en la tabla de timbrados.
		
		
		Dim conn = New System.Data.SqlClient.SqlConnection(con_str)
		
		Dim cli_ins As New SqlCommand("INSERT INTO timbrados ([nro], [documento], [fecha_inicio], [fecha_fin], [nro_inicio], [nro_fin])" &
                                  " VALUES(@nro, @documento, @fecha_inicio, @fecha_fin, @nro_inicio, @nro_fin)", conn)

		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@nro", .SqlDbType = SqlDbType.NVarChar, .Value = tx_nro_tim.Text})
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@documento", .SqlDbType = SqlDbType.NVarChar, .Value = tx_doc_tim.Text})
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@fecha_inicio", .SqlDbType = SqlDbType.DateTime, .Value = dt_inicio.value})
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@fecha_fin", .SqlDbType = SqlDbType.DateTime, .Value = dt_fin.value})
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@nro_inicio", .SqlDbType = SqlDbType.NVarChar, .Value = tx_nro_ini.Text})
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@nro_fin", .SqlDbType = SqlDbType.NVarChar, .Value = tx_nro_fin.Text})
		
		If tx_nro_tim.TextLength > 0 And tx_doc_tim.TextLength > 0 And tx_nro_ini.TextLength >0 And tx_nro_fin.TextLength >0 Then
			'si no esta vacio insertamos.
			
			Try
				conn.Open()
			    
			    If cli_ins.ExecuteNonQuery() Then
			    	Messagebox.Show("Insertado Exitosamente.")
			    	tx_nro_tim.Text = ""
			    	tx_doc_tim.Text  = ""
			    	dt_inicio.Text = ""
			    	dt_fin.Text = ""
			    	tx_nro_ini.Text = ""
			    	tx_nro_fin.Text = ""
			    	Me.DialogResult = Windows.Forms.DialogResult.OK
			    Else
			    	Messagebox.Show("Error al insertar.")
			    	'otro
			    	Me.DialogResult = Windows.Forms.DialogResult.Cancel
			    End If
			    
			Catch ex As Exception
				MessageBox.Show(ex.Message.ToString)
			Finally
				conn.Close()
				cli_ins.Dispose()
				
			End Try
		Else
			MessageBox.Show("DEBE COMPLETAR LOS CAMPOS OBLIGATORIOS!")
		End If
		
		
	End Sub
End Class
