'
' Created by SharpDevelop.
' User: Luis
' Date: 31/3/2019
' Time: 09:30
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class form_recibos
	
	Dim con_str = "Server=localhost\SQLEXPRESS;Database=MULTISELLOS;User Id=admin;Password=Super123;"
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
		
	End Sub
	
	Sub Form_recibosLoad(sender As Object, e As EventArgs)
		Me.CenterToScreen()		
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		Me.Close()
		
	End Sub
	
	Sub Button3Click(sender As Object, e As EventArgs)
		'Llamamos al formulario de abm de clientes
		Dim cli As New form_cliente()
		If cli.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
        	' traemos el contenido
    	Else
        	'tx_nom_cliente.Text = "Cancelado"
    	End If
    	cli.Dispose()		
	End Sub
	
	Sub Button4Click(sender As Object, e As EventArgs)
		'guardamos e imprimimos
		
	End Sub
End Class
