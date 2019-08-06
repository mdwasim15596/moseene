<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeDetails
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.tbMobileNo = New System.Windows.Forms.TextBox()
        Me.tbempAddress = New System.Windows.Forms.TextBox()
        Me.tbEmpName = New System.Windows.Forms.TextBox()
        Me.tbEmpid = New System.Windows.Forms.TextBox()
        Me.lblMobileNo = New System.Windows.Forms.Label()
        Me.lblempAdd = New System.Windows.Forms.Label()
        Me.lblEmpName = New System.Windows.Forms.Label()
        Me.lblEmpid = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(49, 351)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(545, 149)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EMPLOYEE RECORDS"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightCyan
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(526, 120)
        Me.DataGridView1.TabIndex = 0
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Teal
        Me.btnUpdate.Location = New System.Drawing.Point(216, 300)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(104, 32)
        Me.btnUpdate.TabIndex = 22
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnADD
        '
        Me.btnADD.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnADD.ForeColor = System.Drawing.Color.Teal
        Me.btnADD.Location = New System.Drawing.Point(93, 300)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(104, 32)
        Me.btnADD.TabIndex = 21
        Me.btnADD.Text = "ADD"
        Me.btnADD.UseVisualStyleBackColor = True
        '
        'tbMobileNo
        '
        Me.tbMobileNo.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMobileNo.Location = New System.Drawing.Point(216, 237)
        Me.tbMobileNo.MaxLength = 10
        Me.tbMobileNo.Name = "tbMobileNo"
        Me.tbMobileNo.Size = New System.Drawing.Size(222, 26)
        Me.tbMobileNo.TabIndex = 20
        '
        'tbempAddress
        '
        Me.tbempAddress.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbempAddress.Location = New System.Drawing.Point(216, 152)
        Me.tbempAddress.Multiline = True
        Me.tbempAddress.Name = "tbempAddress"
        Me.tbempAddress.Size = New System.Drawing.Size(287, 62)
        Me.tbempAddress.TabIndex = 19
        '
        'tbEmpName
        '
        Me.tbEmpName.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmpName.Location = New System.Drawing.Point(216, 108)
        Me.tbEmpName.Name = "tbEmpName"
        Me.tbEmpName.Size = New System.Drawing.Size(222, 26)
        Me.tbEmpName.TabIndex = 18
        '
        'tbEmpid
        '
        Me.tbEmpid.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmpid.Location = New System.Drawing.Point(216, 64)
        Me.tbEmpid.Name = "tbEmpid"
        Me.tbEmpid.Size = New System.Drawing.Size(121, 26)
        Me.tbEmpid.TabIndex = 17
        '
        'lblMobileNo
        '
        Me.lblMobileNo.AutoSize = True
        Me.lblMobileNo.BackColor = System.Drawing.Color.Transparent
        Me.lblMobileNo.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobileNo.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblMobileNo.Location = New System.Drawing.Point(86, 244)
        Me.lblMobileNo.Name = "lblMobileNo"
        Me.lblMobileNo.Size = New System.Drawing.Size(94, 19)
        Me.lblMobileNo.TabIndex = 16
        Me.lblMobileNo.Text = "MOBILE NO"
        '
        'lblempAdd
        '
        Me.lblempAdd.AutoSize = True
        Me.lblempAdd.BackColor = System.Drawing.Color.Transparent
        Me.lblempAdd.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblempAdd.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblempAdd.Location = New System.Drawing.Point(82, 171)
        Me.lblempAdd.Name = "lblempAdd"
        Me.lblempAdd.Size = New System.Drawing.Size(118, 19)
        Me.lblempAdd.TabIndex = 15
        Me.lblempAdd.Text = "EMP ADDRESS "
        '
        'lblEmpName
        '
        Me.lblEmpName.AutoSize = True
        Me.lblEmpName.BackColor = System.Drawing.Color.Transparent
        Me.lblEmpName.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpName.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblEmpName.Location = New System.Drawing.Point(82, 121)
        Me.lblEmpName.Name = "lblEmpName"
        Me.lblEmpName.Size = New System.Drawing.Size(94, 19)
        Me.lblEmpName.TabIndex = 14
        Me.lblEmpName.Text = "EMP NAME "
        '
        'lblEmpid
        '
        Me.lblEmpid.AutoSize = True
        Me.lblEmpid.BackColor = System.Drawing.Color.Transparent
        Me.lblEmpid.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpid.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblEmpid.Location = New System.Drawing.Point(86, 77)
        Me.lblEmpid.Name = "lblEmpid"
        Me.lblEmpid.Size = New System.Drawing.Size(67, 19)
        Me.lblEmpid.TabIndex = 13
        Me.lblEmpid.Text = "EMP ID "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(164, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 32)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "EMPLOYEE DETAILS"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Teal
        Me.btnDelete.Location = New System.Drawing.Point(455, 300)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(104, 32)
        Me.btnDelete.TabIndex = 24
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Teal
        Me.btnReset.Location = New System.Drawing.Point(336, 300)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(104, 32)
        Me.btnReset.TabIndex = 25
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'EmployeeDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.BackgroundImage = Global.VideoVisionMS.My.Resources.Resources.images__4_
        Me.ClientSize = New System.Drawing.Size(614, 512)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnADD)
        Me.Controls.Add(Me.tbMobileNo)
        Me.Controls.Add(Me.tbempAddress)
        Me.Controls.Add(Me.tbEmpName)
        Me.Controls.Add(Me.tbEmpid)
        Me.Controls.Add(Me.lblMobileNo)
        Me.Controls.Add(Me.lblempAdd)
        Me.Controls.Add(Me.lblEmpName)
        Me.Controls.Add(Me.lblEmpid)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "EmployeeDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Details"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents tbMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents tbempAddress As System.Windows.Forms.TextBox
    Friend WithEvents tbEmpName As System.Windows.Forms.TextBox
    Friend WithEvents tbEmpid As System.Windows.Forms.TextBox
    Friend WithEvents lblMobileNo As System.Windows.Forms.Label
    Friend WithEvents lblempAdd As System.Windows.Forms.Label
    Friend WithEvents lblEmpName As System.Windows.Forms.Label
    Friend WithEvents lblEmpid As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
End Class
