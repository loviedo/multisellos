'
' Created by SharpDevelop.
' User: Luis
' Date: 9/23/2018
' Time: 10:57 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Data
Imports System.Data.SqlClient

Public Partial Class form_conf
	
	Private con_str = "Server=localhost\SQLEXPRESS;Database=MULTISELLOS;User Id=admin;Password=Super123;"
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub Form_confLoad(sender As Object, e As EventArgs)
		Me.CenterToScreen()	
		
		'recuperamos el timbrado vigente actual y mostramos en el tx
		Using con As New SqlClient.SqlConnection(con_str)
		     Using cmd As New SqlClient.SqlCommand("select nro from timbrados where vigente = 'SI'", con)
		        con.Open()
		        Using reader As SqlClient.SqlDataReader = cmd.ExecuteReader
		           'This will loop through all returned records 
		           While reader.Read
		              tx_timbrado.Text = reader("nro").ToString
		              'handle returned value before next loop here
		           End While
		        End Using
		        con.Close()
		     End Using
		  End Using
		
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		Me.Close()
		
	End Sub
	
	Sub ListarTimbradosToolStripMenuItemClick(sender As Object, e As EventArgs)
		'llamamos a la vista de listado de timbrados.
		'aca podemos seleccionar el timbrado a usarse actualmente
		Dim timbra As New form_lista_timbrados()
		If timbra.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
			'asignamos el valor del timbrado seleccionado como vigente actual
			tx_timbrado.Text = timbra.nro_tim
    	Else
        	'
    	End If
    	timbra.Dispose()
	End Sub
	
	Sub SeleccionarTimbradosToolStripMenuItemClick(sender As Object, e As EventArgs)
		'damos de alta un timbrado
		'mostramos el campo con los datos a cargar y luego se lista
		Dim timbra As New form_alta_timbrado()
		If timbra.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
			'traemos el contenido
			
    	Else
        	'
    	End If
    	timbra.Dispose()
		
	End Sub
End Class
