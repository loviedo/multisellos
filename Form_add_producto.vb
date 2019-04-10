'
' Created by SharpDevelop.
' User: Luis
' Date: 3/11/2018
' Time: 10:46
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports System.Data
Imports System.Data.SqlClient
Public Partial Class Form_add_producto
	
	Dim con_str As String
	Public iva As Integer = 0
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
		con_str = "Server=localhost\SQLEXPRESS;Database=MULTISELLOS;User Id=admin;Password=Super123;"
	End Sub
	

	
	Sub Button2Click(sender As Object, e As EventArgs)
		'salimos
		Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Close()	
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		'guardamos el valor de los productos	
		Dim conn = New System.Data.SqlClient.SqlConnection(con_str)
		'Dim iva As Integer
		
		If combo_iva.SelectedItem = "10%" Then
			iva = 10
		ElseIf combo_iva.SelectedItem = "5%"
			iva = 5
		Else
			iva = 0
		End If
		
		
		Dim cli_ins As New SqlCommand("INSERT INTO productos ([codigo], [descripcion], [precio1], [precio2], [precio3], [iva])" &
                                  " VALUES(@codigo, @descripcion, @precio1, @precio2, @precio3, @iva)", conn)

		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@codigo", .SqlDbType = SqlDbType.NVarChar, .Value = tx_cod.Text})
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@descripcion", .SqlDbType = SqlDbType.NVarChar, .Value = tx_des.Text})
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@precio1", .SqlDbType = SqlDbType.Int, .Value = tx_precio1.Text})
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@precio2", .SqlDbType = SqlDbType.Int, .Value = tx_precio2.Text})
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@precio3", .SqlDbType = SqlDbType.Int, .Value = tx_precio3.Text})
		cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@iva", .SqlDbType = SqlDbType.Int, .Value = iva})
		
		If tx_cod.TextLength > 0 And tx_des.TextLength > 0 And tx_precio1.TextLength >0 Then
			'si no esta vacio insertamos.
			Try
				conn.Open()
			    
			    If cli_ins.ExecuteNonQuery() Then
			    	Messagebox.Show("Insertado Exitosamente.")
			    	tx_cod.Text = ""
			    	tx_des.Text  = ""
			    	tx_precio1.Text = ""
			    	tx_precio2.Text = ""
			    	tx_precio3.Text = ""
			    Else
			    	Messagebox.Show("Error al insertar.")
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
		
		Me.DialogResult = System.Windows.Forms.DialogResult.Ok
	End Sub
	
	Sub Form_add_productoLoad(sender As Object, e As EventArgs)
		Me.CenterToScreen()		
		
		combo_iva.SelectedIndex= 0
	End Sub
End Class
