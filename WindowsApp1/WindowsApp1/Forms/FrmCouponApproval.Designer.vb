<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCouponApproval
    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvCoupons As DataGridView
    Friend WithEvents btnApprove As Button
    Friend WithEvents btnReject As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblSearch As Label
    Friend WithEvents lblStatus As Label
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvCoupons = New System.Windows.Forms.DataGridView()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.btnReject = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        CType(Me.dgvCoupons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' lblSearch
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(20, 15)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(92, 17)
        Me.lblSearch.Text = "Coupon Code"
        ' txtSearch
        Me.txtSearch.Location = New System.Drawing.Point(120, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(150, 22)
        ' lblStatus
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(290, 15)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(48, 17)
        Me.lblStatus.Text = "Status"
        ' cmbStatus
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.Location = New System.Drawing.Point(345, 12)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(120, 24)
        ' btnSearch
        Me.btnSearch.Location = New System.Drawing.Point(480, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 28)
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        ' dgvCoupons
        Me.dgvCoupons.AllowUserToAddRows = False
        Me.dgvCoupons.AllowUserToDeleteRows = False
        Me.dgvCoupons.ColumnHeadersHeightSizeMode =
            System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ' Me.dgvCoupons.Location = New System.Drawing.Point(20, 50)
        Me.dgvCoupons.MultiSelect = False
        Me.dgvCoupons.Name = "dgvCoupons"
        Me.dgvCoupons.ReadOnly = True
        Me.dgvCoupons.SelectionMode =
            System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        'Me.dgvCoupons.Size = New System.Drawing.Size(540, 230)
        Me.dgvCoupons.Anchor = CType(
        AnchorStyles.Top Or
        AnchorStyles.Left Or AnchorStyles.Right, AnchorStyles)

        Me.dgvCoupons.Location = New Drawing.Point(20, 80)

        Me.dgvCoupons.Size = New Drawing.Size(1200, 500)

        ' btnApprove
        Me.btnApprove.Location = New System.Drawing.Point(80, 300)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(100, 30)
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.UseVisualStyleBackColor = True
        Me.btnApprove.Anchor = AnchorStyles.Bottom
        ' btnReject
        Me.btnReject.Location = New System.Drawing.Point(240, 300)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(100, 30)
        Me.btnReject.Text = "Reject"
        Me.btnReject.UseVisualStyleBackColor = True
        Me.btnReject.Anchor = AnchorStyles.Bottom
        ' btnDelete
        Me.btnDelete.Location = New System.Drawing.Point(400, 300)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 30)
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Anchor = AnchorStyles.Bottom
        ' FrmCouponApproval
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 360)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dgvCoupons)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.btnReject)
        Me.Controls.Add(Me.btnDelete)
        Me.Name = "FrmCouponApproval"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coupon Approval"
        CType(Me.dgvCoupons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
End Class