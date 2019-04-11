'
' Created by SharpDevelop.
' User: Luis
' Date: 10/4/2019
' Time: 21:32
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Data
Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Partial Class form_listados
	
	Dim con_str As String = "Server=localhost\SQLEXPRESS;Database=MULTISELLOS;User Id=admin;Password=Super123;"
	
	Public Sub New()
		
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		
		Dim conn = New System.Data.SqlClient.SqlConnection(con_str)
		
		'aqui generamos el excel y 
		Dim consulta As String = "select f.fecha, f.nro_factura, c.nombre, c.ruc, f.remision_nro, f.monto, f.total_iva_10, f.total_iva_5, f.monto_total from dbo.facturas f " & _
			"inner join dbo.clientes c on c.id = f.id_cliente order by f.fecha desc"
		
		Dim ds As New DataSet()
		
		Try
			conn.Open()
			Dim a = new SqlDataAdapter(consulta, conn)
			
			Dim dt = New DataTable()
			a.Fill(dt)
		    ds.Tables.Add(dt)
		    ds.EnforceConstraints = false
		    dt.Constraints.Clear()
		   
		    'AHORA GENERAR EXCEL CON LA INFO
		    
			Dim xlApp As Excel.Application = New Microsoft.Office.Interop.Excel.Application()

	        If xlApp Is Nothing Then
	            MessageBox.Show("Excel no esta instalado!!")
	            Return
	        End If
	
	        Dim xlWorkBook As Excel.Workbook
	        Dim xlWorkSheet As Excel.Worksheet
	        Dim misValue As Object = System.Reflection.Missing.Value
	
	        xlApp = New Excel.ApplicationClass
	        xlWorkBook = xlApp.Workbooks.Add(misValue)
	        xlWorkSheet = CType(xlWorkBook.Sheets(1), Excel.Worksheet)
	        
	        Dim dc As System.Data.DataColumn
	        Dim dr As System.Data.DataRow
	        Dim colIndex As Integer = 0
	        Dim rowIndex As Integer = 0
	        
	        

            For Each dc In dt.Columns
                colIndex = colIndex + 1
                xlApp.Cells(1, colIndex) = dc.ColumnName
            Next
            
            
            'FORMA RAPIDA
            Dim arr As Object(,) = New Object(dt.Rows.Count - 1, dt.Columns.Count - 1) {}
		    For r As Integer = 0 To dt.Rows.Count - 1
		        dr = dt.Rows(r)
		        For c As Integer = 0 To dt.Columns.Count - 1
		            arr(r, c) = dr(c)
		        Next
		    Next
		    
		    'copiando info
		    Dim c1 As Excel.Range = CType(xlWorkSheet.Cells(2, 1), Excel.Range)
		    Dim c2 As Excel.Range = CType(xlWorkSheet.Cells(2 + dt.Rows.Count - 1, dt.Columns.Count), Excel.Range)
		    Dim range As Excel.Range = xlWorkSheet.Range(c1, c2)
		    range.Value = arr
		    
		    
            xlWorkSheet.Columns.AutoFit()
            
            
	        xlWorkSheet.SaveAs(tx_carpeta.Text & "\VENTAS_MULTISELLOS.xlsx")
	        xlWorkBook.Close()
	        xlApp.Quit()
	
	        clean_obj(xlApp)
	        clean_obj(xlWorkBook)
	        clean_obj(xlWorkSheet)
	
			MsgBox("Base de datos exportada en " & tx_carpeta.Text & "\VENTAS_MULTISELLOS.xlsx")
	
		Catch ex As Exception
			MessageBox.Show(ex.Message.ToString)
		Finally
		    conn.Close()
		End Try
		
	End Sub
	
	
	Sub Button2Click(sender As Object, e As EventArgs)
	    If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
	        tx_carpeta.Text = FolderBrowserDialog1.SelectedPath
	    End If			
	End Sub
	
	Private Sub clean_obj(ByVal obj As Object)
	    Try
	        System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
	        obj = Nothing
	    Catch ex As Exception
	        obj = Nothing
	    Finally
	        GC.Collect()
	    End Try
    End Sub
	
End Class
