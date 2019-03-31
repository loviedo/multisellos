﻿'
' Created by SharpDevelop.
' User: Luis
' Date: 31/3/2019
' Time: 11:38
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports Excel = Microsoft.Office.Interop.Excel

Public Partial Class form_busca_prod
	
	Dim con_str = "Server=localhost\SQLEXPRESS;Database=MULTISELLOS;User Id=admin;Password=Super123;"
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub Form_busca_prodLoad(sender As Object, e As EventArgs)
		Me.CenterToScreen()	
		
		'cargamos los clientes que hubieran
		Dim con As New SqlConnection(con_str)
		Dim cmd As New SqlCommand
		
		'mostramos la info y luego seleccionamos
		Dim consulta As String = "select * from productos"
		
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
			dgvr.Cells("precio1").ToolTipText = "Doble click para selecccionar"
		Next	
	End Sub
	
	Sub TextBox4TextChanged(sender As Object, e As EventArgs)
		
		'AQUI FILTRAMOS LOS VALORES A MEDIDA QUE SE TIPEA
		Dim con As New SqlConnection(con_str)
		Dim cmd As New SqlCommand
		
		
		'traemos los datos de todas las facturas CREDITO
		Dim consulta As String = "select * from productos"
		'Dim datos As System.Data.SqlServerCe.SqlCeDataReader
		
		If textBox4.Text.Length >= 1 Then
			consulta = consulta + " where descripcion like '%" + textBox4.Text + "%'"
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
	
	Sub DataGridView1CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
		'se asigna la factura
		Dim i As Integer
		i = DataGridView1.CurrentRow.Index
		
		TextBox1.Text = DataGridView1.Item(1, i).Value.ToString'codigo
		TextBox2.Text = DataGridView1.Item(2, i).Value.ToString'descripcion
		TextBox3.Text = DataGridView1.Item(3, i).Value.ToString'precio
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		'cargar datos al formulario
		
	End Sub
	
	Sub Button3Click(sender As Object, e As EventArgs)
		Me.Close()		
	End Sub
End Class