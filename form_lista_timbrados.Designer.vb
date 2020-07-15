'
' Created by SharpDevelop.
' User: Luis
' Date: 14/7/2020
' Time: 23:49
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class form_lista_timbrados
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.label1 = New System.Windows.Forms.Label()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.dgv1 = New System.Windows.Forms.DataGridView()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.button1 = New System.Windows.Forms.Button()
		Me.panel1.SuspendLayout
		CType(Me.dgv1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel2.SuspendLayout
		Me.SuspendLayout
		'
		'label1
		'
		Me.label1.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(12, 9)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(781, 41)
		Me.label1.TabIndex = 19
		Me.label1.Text = "Timbrados"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'panel1
		'
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.dgv1)
		Me.panel1.Location = New System.Drawing.Point(12, 53)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(781, 397)
		Me.panel1.TabIndex = 20
		'
		'dgv1
		'
		Me.dgv1.AllowUserToAddRows = false
		Me.dgv1.AllowUserToDeleteRows = false
		Me.dgv1.AllowUserToOrderColumns = true
		Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
		Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv1.Location = New System.Drawing.Point(3, 12)
		Me.dgv1.Name = "dgv1"
		Me.dgv1.ReadOnly = true
		Me.dgv1.Size = New System.Drawing.Size(773, 293)
		Me.dgv1.TabIndex = 5
		AddHandler Me.dgv1.CellContentClick, AddressOf Me.Dgv1CellContentClick
		'
		'panel2
		'
		Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel2.Controls.Add(Me.button1)
		Me.panel2.Location = New System.Drawing.Point(12, 456)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(781, 45)
		Me.panel2.TabIndex = 21
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(600, 3)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(148, 36)
		Me.button1.TabIndex = 0
		Me.button1.Text = "Salir"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'form_lista_timbrados
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(805, 502)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.panel1)
		Me.Controls.Add(Me.label1)
		Me.Name = "form_lista_timbrados"
		Me.Text = "form_lista_timbrados"
		AddHandler Load, AddressOf Me.Form_lista_timbradosLoad
		Me.panel1.ResumeLayout(false)
		CType(Me.dgv1,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel2.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private dgv1 As System.Windows.Forms.DataGridView
	Private button1 As System.Windows.Forms.Button
	Private panel2 As System.Windows.Forms.Panel
	Private panel1 As System.Windows.Forms.Panel
	Private label1 As System.Windows.Forms.Label
End Class
