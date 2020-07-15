'
' Created by SharpDevelop.
' User: Luis
' Date: 9/23/2018
' Time: 10:57 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class form_conf
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub Form_confLoad(sender As Object, e As EventArgs)
		Me.CenterToScreen()	
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		Me.Close()
		
	End Sub
	
	Sub ListarTimbradosToolStripMenuItemClick(sender As Object, e As EventArgs)
		'llamamos a la vista de listado de timbrados.
		'aca podemos seleccionar el timbrado a usarse actualmente
		
		
	End Sub
	
	Sub SeleccionarTimbradosToolStripMenuItemClick(sender As Object, e As EventArgs)
		'damos de alta un timbrado
		'mostramos el campo con los datos a cargar y luego se lista
		Dim cli As New form_alta_timbrado()
		
		
	End Sub
End Class
