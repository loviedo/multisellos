'
' Created by SharpDevelop.
' User: Luis
' Date: 4/11/2018
' Time: 10:42
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Data
Imports System.Data.SqlClient

Public Partial Class form_proveedor
	
	
	Public id_pro As Integer'guardamos el id del proveedor
	
	Dim con_str As String	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
		con_str = "Server=localhost\SQLEXPRESS;Database=MULTISELLOS;User Id=admin;Password=Super123;"
	End Sub
	
	Sub Form_proveedorLoad(sender As Object, e As EventArgs)
		 Me.CenterToScreen()
		
		'cargamos los clientes que hubieran
		Dim con As New SqlConnection(con_str)
		Dim cmd As New SqlCommand
		
		
		Dim consulta As String = "Select id, nombre, ruc, telefono, direccion from proveedor"

		
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
			dgvr.Cells("Nombre").ToolTipText = "Doble click para selecccionar"
			dgvr.Cells("ruc").ToolTipText = "Doble click para selecccionar"
			dgvr.Cells("Telefono").ToolTipText = "Doble click para selecccionar"
		Next		
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		'form para agregar cliente	
		
		Dim add_pro As New form_add_proveedor()
		If add_pro.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
			'traemos el contenido
			'tx_nom_cliente.Text = cliente.TextBox1.Text
        	'tx_ruc_cliente.Text = cliente.TextBox2.Text
        	'tx_tel_cliente.Text = cliente.TextBox3.Text
    	Else
        	'tx_nom_cliente.Text = "Cancelado"
    	End If
    	add_pro.Dispose()
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
        'pasamos el resultado al form que llamo a este form
        Me.DialogResult = System.Windows.Forms.DialogResult.OK			
	End Sub
	
	Sub Button3Click(sender As Object, e As EventArgs)
		'cerramos formulario
		Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Close()		
	End Sub
	
	Sub DataGridView1CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
		Dim i As Integer
		i = DataGridView1.CurrentRow.Index
		
		TextBox6.Text = DataGridView1.Item(0, i).Value.ToString'id proveedor
		TextBox1.Text = DataGridView1.Item(1, i).Value.ToString
		TextBox2.Text = DataGridView1.Item(2, i).Value.ToString
		TextBox3.Text = DataGridView1.Item(3, i).Value.ToString	
		id_pro = DataGridView1.Item(0, i).Value.ToString'id proveedor
	End Sub
	
	Sub TextBox4TextChanged(sender As Object, e As EventArgs)
		'AQUI FILTRAMOS LOS VALORES A MEDIDA QUE SE TIPEA
		
		Dim con As New SqlConnection(con_str)
		Dim cmd As New SqlCommand
		
		
		Dim consulta As String = "Select id, nombre, ruc, telefono, direccion from proveedor"
		'Dim datos As System.Data.SqlServerCe.SqlCeDataReader
		
		If textBox4.Text.Length >= 1 Then
			consulta = consulta + " where nombre like '%" + textBox4.Text + "%'"
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
End Class
