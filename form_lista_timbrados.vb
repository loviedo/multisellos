'
' Created by SharpDevelop.
' User: Luis
' Date: 14/7/2020
' Time: 23:49
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Data
Imports System.Data.SqlClient

Public Partial Class form_lista_timbrados
	
	Private con_str As String
	Public nro_tim As String'variable para pasar el nro timbrado acutalmente vigente al form padre
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
		 con_str = "Server=localhost\SQLEXPRESS;Database=MULTISELLOS;User Id=admin;Password=Super123;"
	End Sub
	
	
	
	Sub Button1Click(sender As Object, e As EventArgs)
		Me.DialogResult = System.Windows.Forms.DialogResult.OK
	End Sub
	
	Sub Dgv1CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
		'al hacer doble click en la fila, seleccionamoscomo vigente
		
		Dim filas_afectadas As Integer'ver retorno, siempre deberia ser 1
		
		Dim i As Integer
		Dim id_tim As Integer'id del nro de timbrado a actualizar
		Dim tim_vigente As String'nro del timbrado a setear como vigente
		
		i = dgv1.CurrentRow.Index
		
		id_tim = dgv1.Item(0, i).Value'id para actualizar el valor
		tim_vigente = dgv1.Item(2, i).Value.ToString'nro para actualizar el valor
		
		'actualizamos el valor del vigente en la base de datos.
		Using con As New SqlConnection(con_str)
			'actualizamos al timbrado vigente
	        Using cmd As New SqlCommand("UPDATE timbrados set vigente='SI' WHERE id=@id_tim", con)
	
	            cmd.Parameters.Add("@id_tim", SqlDbType.Int).Value = id_tim
	
	            con.Open()
	            filas_afectadas = cmd.ExecuteNonQuery()
	            con.Close()
	        End Using
	        
	        'ponemos como no vigentes todas las demas
	        Using cmd As New SqlCommand("UPDATE timbrados set vigente='NO' WHERE id<>@id_tim", con)
	
	            cmd.Parameters.Add("@id_tim", SqlDbType.Int).Value = id_tim
	            con.Open()
	            filas_afectadas = cmd.ExecuteNonQuery()
	            con.Close()
	        End Using
		End Using
		
		'asignamos para pasar al form padre
		nro_tim = tim_vigente
		
		'avisamos que actualizamos
		MessageBox.Show("TIMBRADO VIGENTE NRO: " & tim_vigente)
		'refrescamos el data grid view
		Me.Form_lista_timbradosLoad(sender, e)
		
	End Sub
	
	Sub Form_lista_timbradosLoad(sender As Object, e As EventArgs)
		Me.CenterToScreen()	
		'recuperamos los datos de los diferentes timbrados cargados.
		
		Dim con As New SqlConnection(con_str)
		Dim cmd As New SqlCommand
	
		Dim consulta As String = "Select id As ID ,vigente As VIGENTE, nro As NUMERO, documento As DOCUMENTO, fecha_inicio As 'FECHA INICIO'," & _
		"fecha_fin as 'FECHA FIN', nro_inicio as 'NRO INICIAL', nro_fin as 'NRO FINAL' from timbrados"
	
		Try
			con.Open()
			cmd = con.CreateCommand()
		    cmd.CommandText = consulta
		    Dim dt = new DataTable()
		    dt.Load(cmd.ExecuteReader())
			
			dgv1.AutoGenerateColumns = True
			dgv1.DataSource = dt
			dgv1.Refresh
			
		Catch ex As Exception
			MessageBox.Show(ex.Message.ToString)
		Finally
			con.Close()
		End Try
		
		'cargamos en el Datagrid
		For Each dgvr As DataGridViewRow In dgv1.Rows
			'dgvr.Cells("numero").ToolTipText = "Doble click para selecccionar"
			'dgvr.Cells("descripcion").ToolTipText = "Doble click para selecccionar"
			'dgvr.Cells("precio1").ToolTipText = "Doble click para selecccionar"
		Next
	End Sub
End Class
