<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerBill
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
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblPackageSelected = New System.Windows.Forms.Label()
        Me.lblPackageAmount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbCustomerID = New System.Windows.Forms.TextBox()
        Me.tbPackageSelected = New System.Windows.Forms.TextBox()
        Me.tbAmount = New System.Windows.Forms.TextBox()
        Me.dtpTodaysdate = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartDAte = New System.Windows.Forms.DateTimePicker()
        Me.lblAmountPaid = New System.Windows.Forms.Label()
        Me.rbYes = New System.Windows.Forms.RadioButton()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.tbCustomerName = New System.Windows.Forms.TextBox()
        Me.tbTotalAmount = New System.Windows.Forms.TextBox()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.tbTotalDays = New System.Windows.Forms.TextBox()
        Me.lbltotalDays = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnViewBills = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerID.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblCustomerID.Location = New System.Drawing.Point(15, 64)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(100, 19)
        Me.lblCustomerID.TabIndex = 0
        Me.lblCustomerID.Text = "Customer ID"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerName.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblCustomerName.Location = New System.Drawing.Point(15, 105)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(125, 19)
        Me.lblCustomerName.TabIndex = 1
        Me.lblCustomerName.Text = "Customer Name"
        '
        'lblPackageSelected
        '
        Me.lblPackageSelected.AutoSize = True
        Me.lblPackageSelected.BackColor = System.Drawing.Color.Transparent
        Me.lblPackageSelected.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblPackageSelected.Location = New System.Drawing.Point(15, 147)
        Me.lblPackageSelected.Name = "lblPackageSelected"
        Me.lblPackageSelected.Size = New System.Drawing.Size(135, 19)
        Me.lblPackageSelected.TabIndex = 2
        Me.lblPackageSelected.Text = "Package Selected"
        '
        'lblPackageAmount
        '
        Me.lblPackageAmount.AutoSize = True
        Me.lblPackageAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblPackageAmount.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblPackageAmount.Location = New System.Drawing.Point(15, 189)
        Me.lblPackageAmount.Name = "lblPackageAmount"
        Me.lblPackageAmount.Size = New System.Drawing.Size(133, 19)
        Me.lblPackageAmount.TabIndex = 3
        Me.lblPackageAmount.Text = "Package Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label1.Location = New System.Drawing.Point(15, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Todays Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label2.Location = New System.Drawing.Point(15, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Start Date"
        '
        'tbCustomerID
        '
        Me.tbCustomerID.Location = New System.Drawing.Point(166, 57)
        Me.tbCustomerID.Name = "tbCustomerID"
        Me.tbCustomerID.Size = New System.Drawing.Size(121, 26)
        Me.tbCustomerID.TabIndex = 7
        '
        'tbPackageSelected
        '
        Me.tbPackageSelected.Location = New System.Drawing.Point(166, 140)
        Me.tbPackageSelected.Name = "tbPackageSelected"
        Me.tbPackageSelected.Size = New System.Drawing.Size(193, 26)
        Me.tbPackageSelected.TabIndex = 8
        '
        'tbAmount
        '
        Me.tbAmount.Location = New System.Drawing.Point(166, 182)
        Me.tbAmount.Name = "tbAmount"
        Me.tbAmount.Size = New System.Drawing.Size(121, 26)
        Me.tbAmount.TabIndex = 9
        '
        'dtpTodaysdate
        '
        Me.dtpTodaysdate.Location = New System.Drawing.Point(166, 272)
        Me.dtpTodaysdate.Name = "dtpTodaysdate"
        Me.dtpTodaysdate.Size = New System.Drawing.Size(200, 26)
        Me.dtpTodaysdate.TabIndex = 10
        '
        'dtpStartDAte
        '
        Me.dtpStartDAte.Location = New System.Drawing.Point(166, 225)
        Me.dtpStartDAte.Name = "dtpStartDAte"
        Me.dtpStartDAte.Size = New System.Drawing.Size(200, 26)
        Me.dtpStartDAte.TabIndex = 11
        '
        'lblAmountPaid
        '
        Me.lblAmountPaid.AutoSize = True
        Me.lblAmountPaid.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblAmountPaid.Location = New System.Drawing.Point(9, 14)
        Me.lblAmountPaid.Name = "lblAmountPaid"
        Me.lblAmountPaid.Size = New System.Drawing.Size(106, 19)
        Me.lblAmountPaid.TabIndex = 12
        Me.lblAmountPaid.Text = "Amount Paid"
        '
        'rbYes
        '
        Me.rbYes.AutoSize = True
        Me.rbYes.ForeColor = System.Drawing.Color.Teal
        Me.rbYes.Location = New System.Drawing.Point(13, 37)
        Me.rbYes.Name = "rbYes"
        Me.rbYes.Size = New System.Drawing.Size(51, 23)
        Me.rbYes.TabIndex = 13
        Me.rbYes.TabStop = True
        Me.rbYes.Text = "Yes"
        Me.rbYes.UseVisualStyleBackColor = True
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.ForeColor = System.Drawing.Color.Teal
        Me.rbNo.Location = New System.Drawing.Point(13, 62)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(47, 23)
        Me.rbNo.TabIndex = 14
        Me.rbNo.TabStop = True
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.ForeColor = System.Drawing.Color.Teal
        Me.btnOk.Location = New System.Drawing.Point(81, 409)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(90, 33)
        Me.btnOk.TabIndex = 15
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.ForeColor = System.Drawing.Color.Teal
        Me.btnCancel.Location = New System.Drawing.Point(321, 409)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 33)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.ForeColor = System.Drawing.Color.Teal
        Me.btnReset.Location = New System.Drawing.Point(202, 409)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(90, 33)
        Me.btnReset.TabIndex = 17
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'tbCustomerName
        '
        Me.tbCustomerName.Location = New System.Drawing.Point(166, 98)
        Me.tbCustomerName.Name = "tbCustomerName"
        Me.tbCustomerName.Size = New System.Drawing.Size(193, 26)
        Me.tbCustomerName.TabIndex = 18
        '
        'tbTotalAmount
        '
        Me.tbTotalAmount.Location = New System.Drawing.Point(166, 365)
        Me.tbTotalAmount.Name = "tbTotalAmount"
        Me.tbTotalAmount.Size = New System.Drawing.Size(121, 26)
        Me.tbTotalAmount.TabIndex = 20
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalAmount.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblTotalAmount.Location = New System.Drawing.Point(15, 368)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(110, 19)
        Me.lblTotalAmount.TabIndex = 19
        Me.lblTotalAmount.Text = "Total Amount"
        '
        'tbTotalDays
        '
        Me.tbTotalDays.Location = New System.Drawing.Point(166, 317)
        Me.tbTotalDays.Name = "tbTotalDays"
        Me.tbTotalDays.Size = New System.Drawing.Size(121, 26)
        Me.tbTotalDays.TabIndex = 22
        '
        'lbltotalDays
        '
        Me.lbltotalDays.AutoSize = True
        Me.lbltotalDays.BackColor = System.Drawing.Color.Transparent
        Me.lbltotalDays.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lbltotalDays.Location = New System.Drawing.Point(15, 324)
        Me.lbltotalDays.Name = "lbltotalDays"
        Me.lbltotalDays.Size = New System.Drawing.Size(85, 19)
        Me.lbltotalDays.TabIndex = 21
        Me.lbltotalDays.Text = "Total Days"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.Color.Transparent
        Me.lbl3.Font = New System.Drawing.Font("Cambria", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.Teal
        Me.lbl3.Location = New System.Drawing.Point(150, 9)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(217, 32)
        Me.lbl3.TabIndex = 25
        Me.lbl3.Text = "CUSTOMER BILL"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbYes)
        Me.GroupBox1.Controls.Add(Me.lblAmountPaid)
        Me.GroupBox1.Controls.Add(Me.rbNo)
        Me.GroupBox1.Location = New System.Drawing.Point(365, 317)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(154, 86)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'btnViewBills
        '
        Me.btnViewBills.ForeColor = System.Drawing.Color.Teal
        Me.btnViewBills.Location = New System.Drawing.Point(178, 448)
        Me.btnViewBills.Name = "btnViewBills"
        Me.btnViewBills.Size = New System.Drawing.Size(128, 33)
        Me.btnViewBills.TabIndex = 27
        Me.btnViewBills.Text = "View Bills"
        Me.btnViewBills.UseVisualStyleBackColor = True
        '
        'CustomerBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.BackgroundImage = Global.VideoVisionMS.My.Resources.Resources.download__5_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(578, 490)
        Me.Controls.Add(Me.btnViewBills)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.tbTotalDays)
        Me.Controls.Add(Me.lbltotalDays)
        Me.Controls.Add(Me.tbTotalAmount)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.tbCustomerName)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.dtpStartDAte)
        Me.Controls.Add(Me.dtpTodaysdate)
        Me.Controls.Add(Me.tbAmount)
        Me.Controls.Add(Me.tbPackageSelected)
        Me.Controls.Add(Me.tbCustomerID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPackageAmount)
        Me.Controls.Add(Me.lblPackageSelected)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CustomerBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Bill"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents lblPackageSelected As System.Windows.Forms.Label
    Friend WithEvents lblPackageAmount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents tbPackageSelected As System.Windows.Forms.TextBox
    Friend WithEvents tbAmount As System.Windows.Forms.TextBox
    Friend WithEvents dtpTodaysdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStartDAte As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAmountPaid As System.Windows.Forms.Label
    Friend WithEvents rbYes As System.Windows.Forms.RadioButton
    Friend WithEvents rbNo As System.Windows.Forms.RadioButton
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents tbCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents tbTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents tbTotalDays As System.Windows.Forms.TextBox
    Friend WithEvents lbltotalDays As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnViewBills As System.Windows.Forms.Button
End Class
