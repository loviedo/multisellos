'
' Created by SharpDevelop.
' User: Luis
' Date: 3/11/2018
' Time: 10:41
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Data
Imports System.Data.SqlClient

Public Partial Class Form_productos
	
		Dim con_str As String
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
		con_str = "Server=localhost\SQLEXPRESS;Database=MULTISELLOS;User Id=admin;Password=Super123;"
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
        'pasamos el resultado al form que llamo a este form
        Me.DialogResult = System.Windows.Forms.DialogResult.OK			
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		'form para agregar producto	
		
		Dim add_pro As New Form_add_producto()
		If add_pro.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
			'traemos el contenido
			
			Dim con As New SqlConnection(con_str)
			Dim cmd As New SqlCommand
			
			Dim consulta As String = "Select id, codigo, descripcion, precio1, precio2 , precio3, iva from productos"
			
			Try
				con.Open()
				cmd = con.CreateCommand()
			    cmd.CommandText = consulta
			    Dim dt = new DataTable()
			    dt.Load(cmd.ExecuteReader())
		       
				DataGridView1.AutoGenerateColumns = True
				DataGridView1.DataSource = dt
				DataGridView1.Refresh
			    
			    
			Catch ex As Exception
				MessageBox.Show(ex.Message.ToString)
			Finally
			    con.Close()
			End Try
    	Else
        	'tx_nom_cliente.Text = "Cancelado"
    	End If
    	add_pro.Dispose()		
	End Sub
	
	Sub DataGridView1CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
		Dim i As Integer
		i = DataGridView1.CurrentRow.Index
		
		TextBox1.Text = DataGridView1.Item(1, i).Value.ToString
		TextBox2.Text = DataGridView1.Item(2, i).Value.ToString				
	End Sub
	
	Sub Button3Click(sender As Object, e As EventArgs)
		'cerramos formulario
		Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Close()	
	End Sub
	
	Sub TextBox4TextChanged(sender As Object, e As EventArgs)
		'AQUI FILTRAMOS LOS VALORES A MEDIDA QUE SE TIPEA
		
		Dim con As New SqlConnection(con_str)
		Dim cmd As New SqlCommand
		
		Dim consulta As String = "Select id, codigo, descripcion, precio1, precio2 , precio3, iva from productos"
		'Dim datos As System.Data.SqlServerCe.SqlCeDataReader
		
		If textBox4.Text.Length >= 1 Then
			consulta = consulta + " where codigo like '%" + textBox4.Text + "%'"
		End If
		
		Try
			con.Open()
			cmd = con.CreateCommand()
		    cmd.CommandText = consulta
		    Dim dt = new DataTable()
		    dt.Load(cmd.ExecuteReader())
	       
			DataGridView1.AutoGenerateColumns = True
			DataGridView1.DataSource = dt
			DataGridView1.Refresh
		    
		    
		Catch ex As Exception
			MessageBox.Show(ex.Message.ToString)
		Finally
		    con.Close()
		End Try		
	End Sub
	
	Sub Form_productosLoad(sender As Object, e As EventArgs)
		Me.CenterToScreen()	
		
		'cargamos los clientes que hubieran
		Dim con As New SqlConnection(con_str)
		Dim cmd As New SqlCommand
		
		
		Dim consulta As String = "Select id, codigo, descripcion, precio1, precio2 , precio3, iva from productos"
		
		Try
			con.Open()
			cmd = con.CreateCommand()
		    cmd.CommandText = consulta
		    Dim dt = new DataTable()
		    dt.Load(cmd.ExecuteReader())
			
			dataGridView1.AutoGenerateColumns = True
			dataGridView1.DataSource = dt
			dataGridView1.Refresh
			
		Catch ex As Exception
			MessageBox.Show(ex.Message.ToString)
		Finally
			con.Close()
		End Try
		
		'cargamos en el Datagrid
		For Each dgvr As DataGridViewRow In DataGridView1.Rows
			dgvr.Cells("codigo").ToolTipText = "Doble click para selecccionar"
			dgvr.Cells("descripcion").ToolTipText = "Doble click para selecccionar"
		Next		
	End Sub

End Class
