'
' Created by SharpDevelop.
' User: Luis
' Date: 10/8/2018
' Time: 7:23 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports Excel = Microsoft.Office.Interop.Excel

Public Partial Class Form_facturas
	
	Private id_cliente As integer
	Dim con_str = "Server=localhost\SQLEXPRESS;Database=MULTISELLOS;User Id=admin;Password=Super123;"
	
	Dim tipo_factura = "CONTADO"
	
	Dim monto As Integer = 0'para el total monto sin iva
	Dim monto_iva_10 As Integer = 0'para el total iva 10
	Dim monto_iva_5 As Integer = 0' para el total iva 5
	Dim monto_total As Integer = 0' monto total a facturar
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'

	End Sub
	
	Sub Button4Click(sender As Object, e As EventArgs)
		'aqui guardamos los datos y luego imprimimos.
		'MessageBox.Show(tipo_factura) 'debug
		If tx_nom_cliente.TextLength > 0 And tx_ruc_cliente.TextLength > 0 And tx_factu_num.TextLength > 0 And dataGridView1.RowCount >0 Then
			
			'recorremos el DGV y sumamos los valores
			For Each dgvr As DataGridViewRow In DataGridView1.Rows
				monto = monto + Convert.ToInt32(dgvr.Cells("PRECIO TOTAL").Value.ToString)'total monto sin iva
				monto_iva_10 = monto_iva_10 + Convert.ToInt32(dgvr.Cells("IVA 10%").Value.ToString)'total 10%
				monto_iva_5 = monto_iva_5 + Convert.ToInt32(dgvr.Cells("IVA 5%").Value.ToString)'total 5%
				monto_total = monto_total + Convert.ToInt32(dgvr.Cells("MONTO TOTAL").Value.ToString)'monto total
			Next
			
			'fecha actual
			Dim fec_actual As Date = dtp1.Value
			

		    
			'GUARDAMOS
			Dim conn = New System.Data.SqlClient.SqlConnection(con_str)
			
			'******************************************************************************INSERTAMOS DATOS DE FACTURA
			Dim cli_ins As New SqlCommand("INSERT INTO facturas ([fecha],[nro_factura], [id_cliente], [tipo_fact], [remision_nro], [monto], [total_iva_10], [total_iva_5], [monto_total])" &
				" VALUES(@fecha,@nro_factura, @id_cliente, @tipo_fact, @remision, @monto, @iva_10_total, @iva_5_total, @monto_total)", conn)
			
			cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@fecha", .SqlDbType = SqlDbType.Date, .Value = fec_actual})
			cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@nro_factura", .SqlDbType = SqlDbType.NVarChar, .Value = tx_factu_num.Text})
			cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@id_cliente", .SqlDbType = SqlDbType.NVarChar, .Value = id_cliente})
			cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@tipo_fact", .SqlDbType = SqlDbType.NVarChar, .Value = tipo_factura})'var que guarda el tipo de factura
			cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@remision", .SqlDbType = SqlDbType.Int, .Value = Convert.ToInt32(tx_remision.Text)})'nro de remision
			cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@monto", .SqlDbType = SqlDbType.Int, .Value = monto})
			cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@iva_10_total", .SqlDbType = SqlDbType.BigInt, .Value = monto_iva_10})
			cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@iva_5_total", .SqlDbType = SqlDbType.BigInt, .Value = monto_iva_5})
			cli_ins.Parameters.Add(New SqlParameter With {.ParameterName = "@monto_total", .SqlDbType = SqlDbType.BigInt, .Value = monto_total})
			
			
			Try
				conn.Open()
			    If cli_ins.ExecuteNonQuery() Then
			    	Messagebox.Show("Insertado Exitosamente.")
			    Else
			    	Messagebox.Show("Error al insertar.")
			    End If
			Catch ex As Exception
				MessageBox.Show(ex.Message.ToString)
			Finally
				conn.Close()
				cli_ins.Dispose()
			End Try
			
			'******************************************************************************INSERTAMOS DATOS DE PRODUCTOS DE FACTURA
			Dim cli_ins2 As New SqlCommand("INSERT INTO fact_productos ([fecha],[nro_factura], [cod_producto], [cant], [precio])" &
				" VALUES(@fecha, @nro_factura, @cod_producto, @cant, @precio)", conn)
			
			'recorremos el DGV e insertamos los valores
			For Each dgvr As DataGridViewRow In DataGridView1.Rows
				cli_ins2.Parameters.Add(New SqlParameter With {.ParameterName = "@fecha", .SqlDbType = SqlDbType.Date, .Value = fec_actual})
				cli_ins2.Parameters.Add(New SqlParameter With {.ParameterName = "@nro_factura", .SqlDbType = SqlDbType.NVarChar, .Value = tx_factu_num.Text})
				cli_ins2.Parameters.Add(New SqlParameter With {.ParameterName = "@cod_producto", .SqlDbType = SqlDbType.NVarChar, .Value = dgvr.Cells("CODIGO").Value})
				cli_ins2.Parameters.Add(New SqlParameter With {.ParameterName = "@cant", .SqlDbType = SqlDbType.Int, .Value = Convert.ToInt32(dgvr.Cells("CANTIDAD").Value)})
				cli_ins2.Parameters.Add(New SqlParameter With {.ParameterName = "@precio", .SqlDbType = SqlDbType.Int, .Value = Convert.ToInt32(dgvr.Cells("PRECIO").Value)})
				
				Try
					conn.Open()
				    If cli_ins2.ExecuteNonQuery() Then
				    Else
				    	Messagebox.Show("Error al insertar.")
				    End If
				Catch ex As Exception
					MessageBox.Show(ex.Message.ToString)
				Finally
					conn.Close()
					cli_ins2.Parameters.RemoveAt("@fecha")
					cli_ins2.Parameters.RemoveAt("@nro_factura")
					cli_ins2.Parameters.RemoveAt("@cod_producto")
					cli_ins2.Parameters.RemoveAt("@cant")
					cli_ins2.Parameters.RemoveAt("@precio")
					cli_ins2.Dispose()

				End Try
				'fin ciclo
			Next
			
			'IMPRIMIMOS
			
			
			
		Else
			MessageBox.Show("Debe completar todos los datos")
		End If

		

	End Sub
	
	Sub Button3Click(sender As Object, e As EventArgs)
		'Llamamos al formulario de abm de clientes
		Dim cli As New form_cliente()
		If cli.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
			'traemos el contenido
			id_cliente = cli.id_cli'traemos el id del cliente del formulario
			tx_nom_cliente.Text = cli.textBox1.Text 'cliente nombre
			tx_ruc_cliente.text = cli.textBox2.Text 'cliente RUC
			tx_tel_cliente.Text = cli.textBox3.Text 'cliente tel	
    	Else
        	'tx_nom_cliente.Text = "Cancelado"
    	End If
    	cli.Dispose()
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		Me.Close()		
	End Sub
	
	Sub CheckBox1CheckedChanged(sender As Object, e As EventArgs)
		If ch_contado.Checked = True Then
			ch_credito.Checked = False
			tipo_factura = "CONTADO"
		Else
			tipo_factura = ""
		End If
	End Sub
	
	Sub Ch_creditoCheckedChanged(sender As Object, e As EventArgs)
		If ch_credito.Checked = True Then
			ch_contado.Checked = False
			tipo_factura = "CREDITO"
		Else
			tipo_factura = ""
		End If
	End Sub
	
	Sub Form_facturasLoad(sender As Object, e As EventArgs)
		Me.CenterToScreen()	
		
		'fecha de hoy
		dtp1.Value = DateTime.Now
		
		'chequeamos el contado
		ch_contado.Checked = true
		
		'inicializamos el DGV1
		dataGridView1.Columns.Add("CODIGO","CODIGO")
		dataGridView1.Columns.Add("DESCRIPCION","DESCRIPCION")
		dataGridView1.Columns.Add("CANTIDAD","CANTIDAD")
		dataGridView1.Columns.Add("PRECIO","PRECIO")
		dataGridView1.Columns.Add("PRECIO TOTAL","PRECIO TOTAL")
		dataGridView1.Columns.Add("IVA 10%","IVA 10%")
		dataGridView1.Columns.Add("IVA 5%","IVA 5%")
		dataGridView1.Columns.Add("MONTO TOTAL","MONTO TOTAL")'total + iva / total exento
		
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		'Llamamos al formulario de BUSCAR FACTURAS
		Dim prod As New form_busca_prod()
		If prod.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
			Dim monto As Integer = 0
			Dim iva_10 As Integer = 0
			Dim iva_5 As Integer = 0
			Dim iva_total As Integer = 0
			Dim monto_total As Integer = 0
			
			
			'Cargamos el gridview segun los datos selecccionados.
			'calculamos el total del producto
			Dim total As Integer 
			total = (Convert.ToInt32(prod.tx_canti.Text))*(Convert.ToInt32(prod.comboBox1.Text))
			
			'calculamos el iva
			If prod.tipo_iva = 10 Then
				iva_10 = total*0.1
			ElseIf prod.tipo_iva = 5 Then
				iva_5 = total*0.05
			End If
			
			tx_id_prod.Text = prod.id_prod
			
			'CALCULAMOS EL MONTO TOTAL 
			monto_total = total + iva_10 + iva_5
			
			'insertamos la fila con los datos calculados
			DataGridView1.Rows.Add(False, prod.TextBox1.Text, prod.TextBox2.Text, prod.tx_canti.Text, prod.comboBox1.text,total.ToString,iva_10.ToString,iva_5.ToString,monto_total.ToString)
			DataGridView1.Refresh
			
			
			'RECORREMOS el dgv para ACTUALIZAR los totales de IVA y MONTO FINAL
			monto = 0
			iva_10 = 0
			iva_5 = 0
			iva_total = 0
			monto_total = 0
			
			For Each dgvr As DataGridViewRow In DataGridView1.Rows
				'Messagebox.Show(dgvr.Cells("PRECIO TOTAL").Value.ToString)'debug
				monto = monto + Convert.ToInt32(dgvr.Cells("PRECIO TOTAL").Value.ToString)'total monto sin iva
				iva_10 = iva_10 + Convert.ToInt32(dgvr.Cells("IVA 10%").Value.ToString)'total 10%
				iva_5 = iva_5 + Convert.ToInt32(dgvr.Cells("IVA 5%").Value.ToString)'total 5%
				monto_total = monto_total + Convert.ToInt32(dgvr.Cells("MONTO TOTAL").Value.ToString)'monto total
			Next
			
			'mostramos los valores
			tx_iva_10.Text = iva_10.ToString
			tx_iva_5.Text = iva_5.ToString
			tx_total_iva.Text = iva_10 + iva_5
			tx_monto_total.Text = monto_total
			
    	Else
    		'tx_nom_cliente.Text = "Cancelado"
    		
    	End If
    	prod.Dispose()	
	End Sub
	
	
	
	'sacado de https://www.lawebdelprogramador.com/foros/Visual-Basic.NET/839884-Numeros-a-letras-una-forma-facil.html
    Public Function letras(ByVal nCifra As Object) As String
        ' Defino variables
        Dim cifra, bloque, decimales, cadena As String
        Dim longituid, posision, unidadmil As Byte
 
        ' En caso de que unidadmil sea:
        ' 0 = cientos
        ' 1 = miles
        ' 2 = millones
        ' 3 = miles de millones
        ' 4 = billones
        ' 5 = miles de billones
 
        ' Reemplazo el símbolo decimal por un punto (.) y luego guardo la parte entera y la decimal por separado
        ' Es necesario poner el cero a la izquierda del punto así si el valor es de sólo decimales, se lo fuerza
        ' a colocar el cero para que no genere error
        cifra = Format(CType(nCifra, Decimal), "###############0.#0")
        decimales = Microsoft.VisualBasic.Mid(cifra, Len(cifra) - 1, 2)
        cifra = Microsoft.VisualBasic.Left(cifra, Len(cifra) - 3)
 
        ' Verifico que el valor no sea cero
        If cifra = "0" Then
            Return IIf(decimales = "00", "cero", "cero con " & decimales & "/100")
        End If
 
        ' Evaluo su longitud (como mínimo una cadena debe tener 3 dígitos)
        If Len(cifra) < 3 Then
            cifra = Rellenar(cifra, 3)
        End If
 
        ' Invierto la cadena
        cifra = Invertir(cifra)
 
        ' Inicializo variables
        posision = 1
        unidadmil = 0
        cadena = ""
 
        ' Selecciono bloques de a tres cifras empezando desde el final (de la cadena invertida)
        Do While posision <= Len(cifra)
            ' Selecciono una porción del numero
            bloque = Mid(cifra, posision, 3)
 
            ' Transformo el número a cadena
            cadena = Convertir(bloque, unidadmil) & " " & cadena.Trim
 
            ' Incremento la cantidad desde donde seleccionar la subcadena
            posision = posision + 3
 
            ' Incremento la posisión de la unidad de mil
            unidadmil = unidadmil + 1
        Loop
 
        ' Cargo la función
        Return IIf(decimales = "00", cadena.Trim.ToLower, cadena.Trim.ToLower & " con " & decimales & "/100")
    End Function
    
    ' Esta función es complemento de la función de conversión.
    ' En los arrays se agrega una posisión inicial vacía ya que VB.NET empieza de la posisión cero
    Private Function Convertir(ByVal cadena As String, ByVal unidadmil As Byte) As String
        ' Defino variables
        Dim centena, decena, unidad As Byte
 
        ' Invierto la subcadena (la original habia sido invertida en el procedimiento NumeroATexto)
        cadena = Invertir(cadena)
 
        ' Determino la longitud de la cadena
        If Len(cadena) < 3 Then
            cadena = Rellenar(cadena, 3)
        End If
 
        ' Verifico que la cadena no esté vacía (000)
        If cadena = "000" Then
            Return ""
        End If
 
        ' Desarmo el numero (empiezo del dígito cero por el manejo de cadenas de VB.NET)
        centena = CType(cadena.Substring(0, 1), Byte)
        decena = CType(cadena.Substring(1, 1), Byte)
        unidad = CType(cadena.Substring(2, 1), Byte)
        cadena = ""
 
        ' Calculo las centenas
        If centena <> 0 Then
            Dim centenas() As String = {"", IIf(decena = 0 And unidad = 0, "cien", "ciento"), "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos"}
            cadena = centenas(centena)
        End If
 
        ' Calculo las decenas
        If decena <> 0 Then
            Dim decenas() As String = {"", IIf(unidad = 0, "diez", IIf(unidad >= 6, "dieci", IIf(unidad = 1, "once", IIf(unidad = 2, "doce", IIf(unidad = 3, "trece", IIf(unidad = 4, "catorce", "quince")))))), IIf(unidad = 0, "veinte", "venti"), "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa"}
            cadena = cadena & " " & decenas(decena)
        End If
 
        ' Calculo las unidades (no pregunten por que este IF es necesario ... simplemente funciona)
        If decena = 1 And unidad < 6 Then
        Else
            Dim unidades() As String = {"", IIf(decena <> 1, IIf(unidadmil = 1, "un", "uno"), ""), "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve"}
            If decena >= 3 And unidad <> 0 Then
                cadena = cadena.Trim & " y "
            End If
 
            If decena = 0 Then
                cadena = cadena.Trim & " "
            End If
            cadena = cadena & unidades(unidad)
        End If
 
        ' Evaluo la posision de miles, millones, etc
        If unidadmil <> 0 Then
            Dim agregado() As String = {"", "mil", IIf((centena = 0) And (decena = 0) And (unidad = 1), "millón", "millones"), "mil millones", "billones", "mil billones"}
            If (centena = 0) And (decena = 0) And (unidad = 1) And unidadmil = 2 Then
                cadena = "un"
            End If
            cadena = cadena & " " & agregado(unidadmil) 
        End If
 
        ' Cargo la función
        Return cadena.Trim '& " Guaraníes"
    End Function    
    
        ' Esta función recibe una cadena de caracteres y la devuelve "invertida".
    Public Function Invertir(ByVal cadena As String) As String
        ' Defino variables
        Dim retornar As String
 
        ' Inviero la cadena
        For posision As Short = cadena.Length To 1 Step -1
            retornar = retornar & cadena.Substring(posision - 1, 1)
        Next
 
        ' Retorno la cadena invertida
        Return retornar
    End Function
 
    ' Esta función rellena con ceros a la izquierda un número pasado como parámetro. Con el parámetro "cifras" se especifica la cantidad de dígitos a la izquierda.
    Public Function Rellenar(ByVal valor As Object, ByVal cifras As Byte) As String
        ' Defino variables
        Dim cadena As String
 
        ' Verifico el valor pasado
        If Not IsNumeric(valor) Then
            valor = 0
        Else
            valor = CType(valor, Integer)
        End If
 
        ' Cargo la cadena
        cadena = valor.ToString.Trim
 
        ' Relleno con los ceros que sean necesarios para llenar los dígitos pedidos
        For puntero As Byte = (Len(cadena) + 1) To cifras
            cadena = "0" & cadena
        Next puntero
 
        ' Cargo la función
        Return cadena
    End Function
	
	Sub Button6Click(sender As Object, e As EventArgs)
		If DataGridView1.Rows.Count() > 0 Then
			For i As Integer = DataGridView1.Rows.Count() - 1 To 0 Step -1
            	Dim delete As Boolean
            	delete = DataGridView1.Rows(i).Cells(0).Value

	            'si esta chequeado, borrar
	            If delete Then
	                Dim row As DataGridViewRow
	                row = DataGridView1.Rows(i)
	                DataGridView1.Rows.Remove(row)
	            End If
			Next
			
			'calculamos los valores nuevamente para mostrar abajo
			Dim monto As Integer = 0
			Dim iva_10 As Integer = 0
			Dim iva_5 As Integer = 0
			Dim iva_total As Integer = 0
			Dim monto_total As Integer = 0

			'RECORREMOS el dgv para sumar los totales de IVA y MONTO FINAL			
			For Each dgvr As DataGridViewRow In DataGridView1.Rows
				'Messagebox.Show(dgvr.Cells("PRECIO TOTAL").Value.ToString)'debug
				monto = monto + Convert.ToInt32(dgvr.Cells("PRECIO TOTAL").Value.ToString)'total monto sin iva
				iva_10 = iva_10 + Convert.ToInt32(dgvr.Cells("IVA 10%").Value.ToString)'total 10%
				iva_5 = iva_5 + Convert.ToInt32(dgvr.Cells("IVA 5%").Value.ToString)'total 5%
				monto_total = monto_total + Convert.ToInt32(dgvr.Cells("MONTO TOTAL").Value.ToString)'monto total
			Next
			
			'mostramos los valores
			tx_iva_10.Text = iva_10.ToString
			tx_iva_5.Text = iva_5.ToString
			tx_total_iva.Text = iva_10 + iva_5
			
			DataGridView1.Refresh
		End If
		'MessageBox.show("sdfsdf")'debug
	End Sub
End Class
