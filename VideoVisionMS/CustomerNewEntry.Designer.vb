﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerNewEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblDOJ = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cbPackageSelected = New System.Windows.Forms.ComboBox()
        Me.tbAmount = New System.Windows.Forms.TextBox()
        Me.tbMobileno = New System.Windows.Forms.TextBox()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.tbCustomerName = New System.Windows.Forms.TextBox()
        Me.tbCustomerID = New System.Windows.Forms.TextBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblPackageSelected = New System.Windows.Forms.Label()
        Me.lblMobileno = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.btnVIEWALLCUSTOMERS = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(221, 385)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(181, 26)
        Me.DateTimePicker1.TabIndex = 38
        '
        'lblDOJ
        '
        Me.lblDOJ.AutoSize = True
        Me.lblDOJ.BackColor = System.Drawing.Color.Transparent
        Me.lblDOJ.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOJ.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblDOJ.Location = New System.Drawing.Point(45, 393)
        Me.lblDOJ.Name = "lblDOJ"
        Me.lblDOJ.Size = New System.Drawing.Size(139, 19)
        Me.lblDOJ.TabIndex = 37
        Me.lblDOJ.Text = "DATE OF JOINING "
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Teal
        Me.btnBack.Location = New System.Drawing.Point(351, 432)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 33)
        Me.btnBack.TabIndex = 36
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Teal
        Me.btnReset.Location = New System.Drawing.Point(237, 432)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(90, 33)
        Me.btnReset.TabIndex = 35
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Teal
        Me.btnSave.Location = New System.Drawing.Point(117, 432)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 33)
        Me.btnSave.TabIndex = 34
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cbPackageSelected
        '
        Me.cbPackageSelected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPackageSelected.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPackageSelected.FormattingEnabled = True
        Me.cbPackageSelected.Location = New System.Drawing.Point(219, 291)
        Me.cbPackageSelected.Name = "cbPackageSelected"
        Me.cbPackageSelected.Size = New System.Drawing.Size(181, 27)
        Me.cbPackageSelected.TabIndex = 33
        '
        'tbAmount
        '
        Me.tbAmount.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAmount.Location = New System.Drawing.Point(219, 338)
        Me.tbAmount.Name = "tbAmount"
        Me.tbAmount.Size = New System.Drawing.Size(121, 26)
        Me.tbAmount.TabIndex = 32
        '
        'tbMobileno
        '
        Me.tbMobileno.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMobileno.Location = New System.Drawing.Point(219, 240)
        Me.tbMobileno.MaxLength = 10
        Me.tbMobileno.Name = "tbMobileno"
        Me.tbMobileno.Size = New System.Drawing.Size(222, 26)
        Me.tbMobileno.TabIndex = 31
        '
        'tbAddress
        '
        Me.tbAddress.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddress.Location = New System.Drawing.Point(219, 158)
        Me.tbAddress.Multiline = True
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(287, 62)
        Me.tbAddress.TabIndex = 30
        '
        'tbCustomerName
        '
        Me.tbCustomerName.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCustomerName.Location = New System.Drawing.Point(219, 110)
        Me.tbCustomerName.Name = "tbCustomerName"
        Me.tbCustomerName.Size = New System.Drawing.Size(222, 26)
        Me.tbCustomerName.TabIndex = 29
        '
        'tbCustomerID
        '
        Me.tbCustomerID.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCustomerID.Location = New System.Drawing.Point(219, 62)
        Me.tbCustomerID.Name = "tbCustomerID"
        Me.tbCustomerID.Size = New System.Drawing.Size(121, 26)
        Me.tbCustomerID.TabIndex = 28
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblAmount.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblAmount.Location = New System.Drawing.Point(45, 346)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(80, 19)
        Me.lblAmount.TabIndex = 27
        Me.lblAmount.Text = "AMOUNT "
        '
        'lblPackageSelected
        '
        Me.lblPackageSelected.AutoSize = True
        Me.lblPackageSelected.BackColor = System.Drawing.Color.Transparent
        Me.lblPackageSelected.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPackageSelected.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblPackageSelected.Location = New System.Drawing.Point(45, 299)
        Me.lblPackageSelected.Name = "lblPackageSelected"
        Me.lblPackageSelected.Size = New System.Drawing.Size(159, 19)
        Me.lblPackageSelected.TabIndex = 26
        Me.lblPackageSelected.Text = "PACKAGE SELECTED "
        '
        'lblMobileno
        '
        Me.lblMobileno.AutoSize = True
        Me.lblMobileno.BackColor = System.Drawing.Color.Transparent
        Me.lblMobileno.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobileno.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblMobileno.Location = New System.Drawing.Point(45, 247)
        Me.lblMobileno.Name = "lblMobileno"
        Me.lblMobileno.Size = New System.Drawing.Size(94, 19)
        Me.lblMobileno.TabIndex = 25
        Me.lblMobileno.Text = "MOBILE NO"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblAddress.Location = New System.Drawing.Point(45, 175)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(81, 19)
        Me.lblAddress.TabIndex = 24
        Me.lblAddress.Text = "ADDRESS "
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerName.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblCustomerName.Location = New System.Drawing.Point(45, 117)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(144, 19)
        Me.lblCustomerName.TabIndex = 23
        Me.lblCustomerName.Text = "CUSTOMER NAME "
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerID.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerID.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblCustomerID.Location = New System.Drawing.Point(45, 69)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(121, 19)
        Me.lblCustomerID.TabIndex = 22
        Me.lblCustomerID.Text = "CUSTOMER  ID "
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.BackColor = System.Drawing.Color.Transparent
        Me.lbl10.Font = New System.Drawing.Font("Cambria", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10.ForeColor = System.Drawing.Color.Teal
        Me.lbl10.Location = New System.Drawing.Point(117, 9)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(324, 32)
        Me.lbl10.TabIndex = 21
        Me.lbl10.Text = "NEW CUSTOMERS ENTRY"
        '
        'btnVIEWALLCUSTOMERS
        '
        Me.btnVIEWALLCUSTOMERS.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVIEWALLCUSTOMERS.ForeColor = System.Drawing.Color.Teal
        Me.btnVIEWALLCUSTOMERS.Location = New System.Drawing.Point(152, 471)
        Me.btnVIEWALLCUSTOMERS.Name = "btnVIEWALLCUSTOMERS"
        Me.btnVIEWALLCUSTOMERS.Size = New System.Drawing.Size(248, 33)
        Me.btnVIEWALLCUSTOMERS.TabIndex = 39
        Me.btnVIEWALLCUSTOMERS.Text = "VIEW ALL CUSTOMERS"
        Me.btnVIEWALLCUSTOMERS.UseVisualStyleBackColor = True
        '
        'CustomerNewEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.BackgroundImage = Global.VideoVisionMS.My.Resources.Resources.images1
        Me.ClientSize = New System.Drawing.Size(603, 510)
        Me.Controls.Add(Me.btnVIEWALLCUSTOMERS)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblDOJ)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cbPackageSelected)
        Me.Controls.Add(Me.tbAmount)
        Me.Controls.Add(Me.tbMobileno)
        Me.Controls.Add(Me.tbAddress)
        Me.Controls.Add(Me.tbCustomerName)
        Me.Controls.Add(Me.tbCustomerID)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblPackageSelected)
        Me.Controls.Add(Me.lblMobileno)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Controls.Add(Me.lbl10)
        Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "CustomerNewEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer New Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDOJ As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cbPackageSelected As System.Windows.Forms.ComboBox
    Friend WithEvents tbAmount As System.Windows.Forms.TextBox
    Friend WithEvents tbMobileno As System.Windows.Forms.TextBox
    Friend WithEvents tbAddress As System.Windows.Forms.TextBox
    Friend WithEvents tbCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents tbCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lblPackageSelected As System.Windows.Forms.Label
    Friend WithEvents lblMobileno As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents lbl10 As System.Windows.Forms.Label
    Friend WithEvents btnVIEWALLCUSTOMERS As System.Windows.Forms.Button
End Class
