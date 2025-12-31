<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCouponCreate
    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblCode As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblDiscountType As Label
    Friend WithEvents lblMinAmount As Label
    Friend WithEvents lblMaxDiscount As Label
    Friend WithEvents lblExpiry As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents cmbDiscountType As ComboBox
    Friend WithEvents txtMinAmount As TextBox
    Friend WithEvents txtMaxDiscount As TextBox
    Friend WithEvents dtpExpiryDate As DateTimePicker
    Friend WithEvents chkIsActive As CheckBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnApproval As Button
    Friend WithEvents dgvCoupons As DataGridView
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblDiscountType = New System.Windows.Forms.Label()
        Me.lblMinAmount = New System.Windows.Forms.Label()
        Me.lblMaxDiscount = New System.Windows.Forms.Label()
        Me.lblExpiry = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.cmbDiscountType = New System.Windows.Forms.ComboBox()
        Me.txtMinAmount = New System.Windows.Forms.TextBox()
        Me.txtMaxDiscount = New System.Windows.Forms.TextBox()
        Me.dtpExpiryDate = New System.Windows.Forms.DateTimePicker()
        Me.chkIsActive = New System.Windows.Forms.CheckBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnApproval = New System.Windows.Forms.Button()
        Me.dgvCoupons = New System.Windows.Forms.DataGridView()
        CType(Me.dgvCoupons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.Location = New System.Drawing.Point(20, 15)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(253, 32)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Coupon Create / Edit"
        '
        'lblCode
        '
        Me.lblCode.Location = New System.Drawing.Point(20, 60)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(100, 23)
        Me.lblCode.TabIndex = 1
        Me.lblCode.Text = "Coupon Code"
        '
        'lblDiscount
        '
        Me.lblDiscount.Location = New System.Drawing.Point(20, 95)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(100, 23)
        Me.lblDiscount.TabIndex = 2
        Me.lblDiscount.Text = "Discount"
        '
        'lblDiscountType
        '
        Me.lblDiscountType.Location = New System.Drawing.Point(20, 130)
        Me.lblDiscountType.Name = "lblDiscountType"
        Me.lblDiscountType.Size = New System.Drawing.Size(100, 23)
        Me.lblDiscountType.TabIndex = 3
        Me.lblDiscountType.Text = "Discount Type"
        '
        'lblMinAmount
        '
        Me.lblMinAmount.Location = New System.Drawing.Point(20, 165)
        Me.lblMinAmount.Name = "lblMinAmount"
        Me.lblMinAmount.Size = New System.Drawing.Size(100, 23)
        Me.lblMinAmount.TabIndex = 4
        Me.lblMinAmount.Text = "Minimum Amount"
        '
        'lblMaxDiscount
        '
        Me.lblMaxDiscount.Location = New System.Drawing.Point(20, 200)
        Me.lblMaxDiscount.Name = "lblMaxDiscount"
        Me.lblMaxDiscount.Size = New System.Drawing.Size(100, 23)
        Me.lblMaxDiscount.TabIndex = 5
        Me.lblMaxDiscount.Text = "Maximum Discount"
        '
        'lblExpiry
        '
        Me.lblExpiry.Location = New System.Drawing.Point(20, 235)
        Me.lblExpiry.Name = "lblExpiry"
        Me.lblExpiry.Size = New System.Drawing.Size(100, 23)
        Me.lblExpiry.TabIndex = 6
        Me.lblExpiry.Text = "Expiry Date"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(160, 57)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(200, 20)
        Me.txtCode.TabIndex = 7
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(160, 92)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(200, 20)
        Me.txtDiscount.TabIndex = 8
        '
        'cmbDiscountType
        '
        Me.cmbDiscountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDiscountType.Items.AddRange(New Object() {"Percentage", "Flat"})
        Me.cmbDiscountType.Location = New System.Drawing.Point(160, 127)
        Me.cmbDiscountType.Name = "cmbDiscountType"
        Me.cmbDiscountType.Size = New System.Drawing.Size(200, 28)
        Me.cmbDiscountType.TabIndex = 9
        '
        'txtMinAmount
        '
        Me.txtMinAmount.Location = New System.Drawing.Point(160, 162)
        Me.txtMinAmount.Name = "txtMinAmount"
        Me.txtMinAmount.Size = New System.Drawing.Size(200, 20)
        Me.txtMinAmount.TabIndex = 10
        '
        'txtMaxDiscount
        '
        Me.txtMaxDiscount.Location = New System.Drawing.Point(160, 197)
        Me.txtMaxDiscount.Name = "txtMaxDiscount"
        Me.txtMaxDiscount.Size = New System.Drawing.Size(200, 20)
        Me.txtMaxDiscount.TabIndex = 11
        '
        'dtpExpiryDate
        '
        Me.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExpiryDate.Location = New System.Drawing.Point(160, 232)
        Me.dtpExpiryDate.Name = "dtpExpiryDate"
        Me.dtpExpiryDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpExpiryDate.TabIndex = 12
        '
        'chkIsActive
        '
        Me.chkIsActive.Checked = True
        Me.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIsActive.Location = New System.Drawing.Point(160, 265)
        Me.chkIsActive.Name = "chkIsActive"
        Me.chkIsActive.Size = New System.Drawing.Size(104, 24)
        Me.chkIsActive.TabIndex = 13
        Me.chkIsActive.Text = "Is Active"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(400, 60)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(120, 30)
        Me.btnCreate.TabIndex = 14
        Me.btnCreate.Text = "Create"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(400, 95)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 30)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(400, 130)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 30)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        '
        'btnApproval
        '
        Me.btnApproval.Location = New System.Drawing.Point(400, 165)
        Me.btnApproval.Name = "btnApproval"
        Me.btnApproval.Size = New System.Drawing.Size(120, 30)
        Me.btnApproval.TabIndex = 17
        Me.btnApproval.Text = "Approval"
        '
        'dgvCoupons
        '
        Me.dgvCoupons.ColumnHeadersHeight = 34
        ' Me.dgvCoupons.Location = New System.Drawing.Point(20, 310)
        Me.dgvCoupons.Name = "dgvCoupons"
        Me.dgvCoupons.ReadOnly = True
        Me.dgvCoupons.RowHeadersWidth = 62
        Me.dgvCoupons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        ' Me.dgvCoupons.Size = New System.Drawing.Size(760, 230)
        Me.dgvCoupons.Anchor = CType(
   AnchorStyles.Top Or AnchorStyles.Bottom Or
   AnchorStyles.Left Or AnchorStyles.Right, AnchorStyles)
        Me.dgvCoupons.Location = New Drawing.Point(20, 310)
        Me.dgvCoupons.Size = New Drawing.Size(1200, 400)
        Me.dgvCoupons.TabIndex = 18
        '
        'FrmCouponCreate
        '
        Me.ClientSize = New System.Drawing.Size(820, 560)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblDiscountType)
        Me.Controls.Add(Me.lblMinAmount)
        Me.Controls.Add(Me.lblMaxDiscount)
        Me.Controls.Add(Me.lblExpiry)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.cmbDiscountType)
        Me.Controls.Add(Me.txtMinAmount)
        Me.Controls.Add(Me.txtMaxDiscount)
        Me.Controls.Add(Me.dtpExpiryDate)
        Me.Controls.Add(Me.chkIsActive)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnApproval)
        Me.Controls.Add(Me.dgvCoupons)
        Me.Name = "FrmCouponCreate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coupon Management"
        CType(Me.dgvCoupons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class