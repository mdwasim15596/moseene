<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewAdmin
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
        Me.tbUserID = New System.Windows.Forms.TextBox()
        Me.lblUSerid = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbconfmpass = New System.Windows.Forms.TextBox()
        Me.lblConfmpass = New System.Windows.Forms.Label()
        Me.tbpass = New System.Windows.Forms.TextBox()
        Me.tbusername = New System.Windows.Forms.TextBox()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbUserID
        '
        Me.tbUserID.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUserID.Location = New System.Drawing.Point(219, 60)
        Me.tbUserID.Name = "tbUserID"
        Me.tbUserID.Size = New System.Drawing.Size(121, 26)
        Me.tbUserID.TabIndex = 27
        '
        'lblUSerid
        '
        Me.lblUSerid.AutoSize = True
        Me.lblUSerid.BackColor = System.Drawing.Color.Transparent
        Me.lblUSerid.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUSerid.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblUSerid.Location = New System.Drawing.Point(35, 66)
        Me.lblUSerid.Name = "lblUSerid"
        Me.lblUSerid.Size = New System.Drawing.Size(65, 19)
        Me.lblUSerid.TabIndex = 26
        Me.lblUSerid.Text = "USERID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(173, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 32)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "NEW ID"
        '
        'tbconfmpass
        '
        Me.tbconfmpass.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbconfmpass.Location = New System.Drawing.Point(219, 197)
        Me.tbconfmpass.Name = "tbconfmpass"
        Me.tbconfmpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbconfmpass.Size = New System.Drawing.Size(222, 26)
        Me.tbconfmpass.TabIndex = 34
        '
        'lblConfmpass
        '
        Me.lblConfmpass.AutoSize = True
        Me.lblConfmpass.BackColor = System.Drawing.Color.Transparent
        Me.lblConfmpass.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfmpass.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblConfmpass.Location = New System.Drawing.Point(35, 204)
        Me.lblConfmpass.Name = "lblConfmpass"
        Me.lblConfmpass.Size = New System.Drawing.Size(171, 19)
        Me.lblConfmpass.TabIndex = 33
        Me.lblConfmpass.Text = "CONFIRM PASSWORD "
        '
        'tbpass
        '
        Me.tbpass.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpass.Location = New System.Drawing.Point(219, 150)
        Me.tbpass.Name = "tbpass"
        Me.tbpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbpass.Size = New System.Drawing.Size(222, 26)
        Me.tbpass.TabIndex = 32
        '
        'tbusername
        '
        Me.tbusername.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbusername.Location = New System.Drawing.Point(219, 104)
        Me.tbusername.Name = "tbusername"
        Me.tbusername.Size = New System.Drawing.Size(222, 26)
        Me.tbusername.TabIndex = 31
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.BackColor = System.Drawing.Color.Transparent
        Me.lblpass.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpass.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblpass.Location = New System.Drawing.Point(35, 157)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(96, 19)
        Me.lblpass.TabIndex = 30
        Me.lblpass.Text = "PASSWORD "
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.BackColor = System.Drawing.Color.Transparent
        Me.lblusername.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblusername.Location = New System.Drawing.Point(35, 111)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(96, 19)
        Me.lblusername.TabIndex = 29
        Me.lblusername.Text = "USERNAME "
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Teal
        Me.btnCancel.Location = New System.Drawing.Point(331, 279)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 33)
        Me.btnCancel.TabIndex = 40
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Teal
        Me.btnUpdate.Location = New System.Drawing.Point(85, 279)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 33)
        Me.btnUpdate.TabIndex = 39
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Teal
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDelete.Location = New System.Drawing.Point(206, 279)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 33)
        Me.btnDelete.TabIndex = 38
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.ForeColor = System.Drawing.Color.Teal
        Me.btnreset.Location = New System.Drawing.Point(331, 241)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(90, 33)
        Me.btnreset.TabIndex = 37
        Me.btnreset.Text = "RESET"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.Teal
        Me.btnedit.Location = New System.Drawing.Point(206, 241)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(90, 33)
        Me.btnedit.TabIndex = 36
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Teal
        Me.btnsave.Location = New System.Drawing.Point(85, 241)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(90, 33)
        Me.btnsave.TabIndex = 35
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 331)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 143)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightCyan
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(405, 118)
        Me.DataGridView1.TabIndex = 0
        '
        'NewAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.BackgroundImage = Global.VideoVisionMS.My.Resources.Resources.images__3_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(496, 496)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.tbconfmpass)
        Me.Controls.Add(Me.lblConfmpass)
        Me.Controls.Add(Me.tbpass)
        Me.Controls.Add(Me.tbusername)
        Me.Controls.Add(Me.lblpass)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbUserID)
        Me.Controls.Add(Me.lblUSerid)
        Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NewAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Admin"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbUserID As System.Windows.Forms.TextBox
    Friend WithEvents lblUSerid As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbconfmpass As System.Windows.Forms.TextBox
    Friend WithEvents lblConfmpass As System.Windows.Forms.Label
    Friend WithEvents tbpass As System.Windows.Forms.TextBox
    Friend WithEvents tbusername As System.Windows.Forms.TextBox
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
