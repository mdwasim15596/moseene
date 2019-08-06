<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerRecords
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
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.tbAmount = New System.Windows.Forms.TextBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblPackageSelected = New System.Windows.Forms.Label()
        Me.tbMobileNo = New System.Windows.Forms.TextBox()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.tbCustomerName = New System.Windows.Forms.TextBox()
        Me.tbCustomerID = New System.Windows.Forms.TextBox()
        Me.lblMobileNo = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.cbPackageSelected = New System.Windows.Forms.ComboBox()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnVIEWALLCUSTOMERS = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(249, 379)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(181, 26)
        Me.DateTimePicker1.TabIndex = 42
        '
        'lblDOJ
        '
        Me.lblDOJ.AutoSize = True
        Me.lblDOJ.BackColor = System.Drawing.Color.Transparent
        Me.lblDOJ.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOJ.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblDOJ.Location = New System.Drawing.Point(22, 385)
        Me.lblDOJ.Name = "lblDOJ"
        Me.lblDOJ.Size = New System.Drawing.Size(139, 19)
        Me.lblDOJ.TabIndex = 41
        Me.lblDOJ.Text = "DATE OF JOINING "
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.Teal
        Me.btndelete.Location = New System.Drawing.Point(325, 420)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(90, 33)
        Me.btndelete.TabIndex = 40
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.Teal
        Me.btnupdate.Location = New System.Drawing.Point(86, 420)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(90, 33)
        Me.btnupdate.TabIndex = 39
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.Teal
        Me.btnback.Location = New System.Drawing.Point(446, 420)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(90, 33)
        Me.btnback.TabIndex = 37
        Me.btnback.Text = "BACK"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'tbAmount
        '
        Me.tbAmount.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAmount.Location = New System.Drawing.Point(249, 331)
        Me.tbAmount.Name = "tbAmount"
        Me.tbAmount.Size = New System.Drawing.Size(121, 26)
        Me.tbAmount.TabIndex = 36
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblAmount.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblAmount.Location = New System.Drawing.Point(22, 339)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(80, 19)
        Me.lblAmount.TabIndex = 34
        Me.lblAmount.Text = "AMOUNT "
        '
        'lblPackageSelected
        '
        Me.lblPackageSelected.AutoSize = True
        Me.lblPackageSelected.BackColor = System.Drawing.Color.Transparent
        Me.lblPackageSelected.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPackageSelected.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblPackageSelected.Location = New System.Drawing.Point(21, 294)
        Me.lblPackageSelected.Name = "lblPackageSelected"
        Me.lblPackageSelected.Size = New System.Drawing.Size(159, 19)
        Me.lblPackageSelected.TabIndex = 33
        Me.lblPackageSelected.Text = "PACKAGE SELECTED "
        '
        'tbMobileNo
        '
        Me.tbMobileNo.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMobileNo.Location = New System.Drawing.Point(249, 240)
        Me.tbMobileNo.MaxLength = 10
        Me.tbMobileNo.Name = "tbMobileNo"
        Me.tbMobileNo.Size = New System.Drawing.Size(222, 26)
        Me.tbMobileNo.TabIndex = 32
        '
        'tbAddress
        '
        Me.tbAddress.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddress.Location = New System.Drawing.Point(249, 161)
        Me.tbAddress.Multiline = True
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(287, 62)
        Me.tbAddress.TabIndex = 31
        '
        'tbCustomerName
        '
        Me.tbCustomerName.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCustomerName.Location = New System.Drawing.Point(249, 118)
        Me.tbCustomerName.Name = "tbCustomerName"
        Me.tbCustomerName.Size = New System.Drawing.Size(222, 26)
        Me.tbCustomerName.TabIndex = 30
        '
        'tbCustomerID
        '
        Me.tbCustomerID.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCustomerID.Location = New System.Drawing.Point(249, 76)
        Me.tbCustomerID.Name = "tbCustomerID"
        Me.tbCustomerID.Size = New System.Drawing.Size(121, 26)
        Me.tbCustomerID.TabIndex = 29
        '
        'lblMobileNo
        '
        Me.lblMobileNo.AutoSize = True
        Me.lblMobileNo.BackColor = System.Drawing.Color.Transparent
        Me.lblMobileNo.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobileNo.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblMobileNo.Location = New System.Drawing.Point(22, 248)
        Me.lblMobileNo.Name = "lblMobileNo"
        Me.lblMobileNo.Size = New System.Drawing.Size(94, 19)
        Me.lblMobileNo.TabIndex = 28
        Me.lblMobileNo.Text = "MOBILE NO"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblAddress.Location = New System.Drawing.Point(22, 179)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(81, 19)
        Me.lblAddress.TabIndex = 27
        Me.lblAddress.Text = "ADDRESS "
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerName.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblCustomerName.Location = New System.Drawing.Point(22, 126)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(144, 19)
        Me.lblCustomerName.TabIndex = 26
        Me.lblCustomerName.Text = "CUSTOMER NAME "
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerID.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerID.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblCustomerID.Location = New System.Drawing.Point(22, 84)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(117, 19)
        Me.lblCustomerID.TabIndex = 25
        Me.lblCustomerID.Text = "CUSTOMER ID "
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.Color.Transparent
        Me.lbl3.Font = New System.Drawing.Font("Cambria", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.Teal
        Me.lbl3.Location = New System.Drawing.Point(151, 9)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(279, 32)
        Me.lbl3.TabIndex = 24
        Me.lbl3.Text = "CUSTOMER RECORDS"
        '
        'cbPackageSelected
        '
        Me.cbPackageSelected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPackageSelected.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPackageSelected.FormattingEnabled = True
        Me.cbPackageSelected.Location = New System.Drawing.Point(249, 286)
        Me.cbPackageSelected.Name = "cbPackageSelected"
        Me.cbPackageSelected.Size = New System.Drawing.Size(222, 27)
        Me.cbPackageSelected.TabIndex = 43
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.ForeColor = System.Drawing.Color.Teal
        Me.btnreset.Location = New System.Drawing.Point(207, 420)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(90, 33)
        Me.btnreset.TabIndex = 44
        Me.btnreset.Text = "RESET"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnVIEWALLCUSTOMERS
        '
        Me.btnVIEWALLCUSTOMERS.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVIEWALLCUSTOMERS.ForeColor = System.Drawing.Color.Teal
        Me.btnVIEWALLCUSTOMERS.Location = New System.Drawing.Point(191, 459)
        Me.btnVIEWALLCUSTOMERS.Name = "btnVIEWALLCUSTOMERS"
        Me.btnVIEWALLCUSTOMERS.Size = New System.Drawing.Size(248, 33)
        Me.btnVIEWALLCUSTOMERS.TabIndex = 45
        Me.btnVIEWALLCUSTOMERS.Text = "VIEW ALL CUSTOMERS"
        Me.btnVIEWALLCUSTOMERS.UseVisualStyleBackColor = True
        '
        'CustomerRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.BackgroundImage = Global.VideoVisionMS.My.Resources.Resources.images__9_
        Me.ClientSize = New System.Drawing.Size(673, 493)
        Me.Controls.Add(Me.btnVIEWALLCUSTOMERS)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.cbPackageSelected)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblDOJ)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.tbAmount)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblPackageSelected)
        Me.Controls.Add(Me.tbMobileNo)
        Me.Controls.Add(Me.tbAddress)
        Me.Controls.Add(Me.tbCustomerName)
        Me.Controls.Add(Me.tbCustomerID)
        Me.Controls.Add(Me.lblMobileNo)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Controls.Add(Me.lbl3)
        Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CustomerRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Records"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDOJ As System.Windows.Forms.Label
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents tbAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lblPackageSelected As System.Windows.Forms.Label
    Friend WithEvents tbMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents tbAddress As System.Windows.Forms.TextBox
    Friend WithEvents tbCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents tbCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents lblMobileNo As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents cbPackageSelected As System.Windows.Forms.ComboBox
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnVIEWALLCUSTOMERS As System.Windows.Forms.Button
End Class
