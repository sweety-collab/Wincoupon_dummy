Imports BusinessLogic
Imports BusinessLogic.Services
Public Class FrmCouponCreate
    Private svc As New CouponService()
    Private selectedId As Integer = 0
    Private oldAuditData As String = ""
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub FrmCouponCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Maximize form
        Me.WindowState = FormWindowState.Maximized
        ' Improve grid behavior
        'With dgvCoupons
        '    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        '    .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        '    .RowHeadersVisible = False
        '    .AllowUserToResizeRows = False
        '    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        '    .MultiSelect = False
        '    .RowTemplate.Height = 32
        'End With
        LoadGrid()
    End Sub
    Private Sub LoadGrid()
        dgvCoupons.DataSource = svc.SearchCoupons("", "All")
    End Sub
    ' ================= VALIDATION =================
    Private Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(txtCode.Text) Then
            MessageBox.Show("Coupon code is required")
            Return False
        End If
        If Not IsNumeric(txtDiscount.Text) OrElse CDec(txtDiscount.Text) <= 0 Then
            MessageBox.Show("Invalid discount")
            Return False
        End If
        If cmbDiscountType.Text = "Percentage" AndAlso CDec(txtDiscount.Text) > 100 Then
            MessageBox.Show("Percentage discount cannot exceed 100")
            Return False
        End If
        If Not IsNumeric(txtMinAmount.Text) OrElse CDec(txtMinAmount.Text) < 0 Then
            MessageBox.Show("Invalid minimum amount")
            Return False
        End If
        If Not IsNumeric(txtMaxDiscount.Text) OrElse CDec(txtMaxDiscount.Text) < 0 Then
            MessageBox.Show("Invalid maximum discount")
            Return False
        End If
        If dtpExpiryDate.Value.Date < Date.Today Then
            MessageBox.Show("Expiry date cannot be in the past")
            Return False
        End If
        Return True
    End Function
    ' ================= CREATE =================
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If Not ValidateInput() Then Exit Sub
        svc.CreateCouponWithAudit(
            txtCode.Text.Trim(),
            CDec(txtDiscount.Text),
            cmbDiscountType.Text,
            CDec(txtMinAmount.Text),
            CDec(txtMaxDiscount.Text),
            dtpExpiryDate.Value,
            chkIsActive.Checked
        )
        MessageBox.Show("Coupon Created")
        ClearForm()
        LoadGrid()
    End Sub
    ' ================= UPDATE =================
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedId = 0 Then
            MessageBox.Show("Select a coupon first")
            Exit Sub
        End If
        If Not ValidateInput() Then Exit Sub
        svc.UpdateCouponWithAudit(
            selectedId,
            oldAuditData,
            txtCode.Text.Trim(),
            CDec(txtDiscount.Text),
            cmbDiscountType.Text,
            CDec(txtMinAmount.Text),
            CDec(txtMaxDiscount.Text),
            dtpExpiryDate.Value,
            chkIsActive.Checked
        )
        MessageBox.Show("Coupon Updated")
        ClearForm()
        LoadGrid()
    End Sub
    ' ================= GRID SELECT =================
    Private Sub dgvCoupons_CellClick(sender As Object,
                                e As DataGridViewCellEventArgs) _
                                Handles dgvCoupons.CellClick
        If e.RowIndex < 0 Then Exit Sub
        selectedId = CInt(dgvCoupons.Rows(e.RowIndex).Cells("Id").Value)
        txtCode.Text =
       dgvCoupons.Rows(e.RowIndex).Cells("Code").Value.ToString()
        txtDiscount.Text =
       dgvCoupons.Rows(e.RowIndex).Cells("Discount").Value.ToString()
        cmbDiscountType.Text =
       dgvCoupons.Rows(e.RowIndex).Cells("DiscountType").Value.ToString()
        txtMinAmount.Text =
       dgvCoupons.Rows(e.RowIndex).Cells("MinAmount").Value.ToString()
        txtMaxDiscount.Text =
       dgvCoupons.Rows(e.RowIndex).Cells("MaxDiscount").Value.ToString()
        ' ✅ SAFE DATE HANDLING
        If IsDBNull(dgvCoupons.Rows(e.RowIndex).Cells("ExpiryDate").Value) Then
            dtpExpiryDate.Value = Date.Today
        Else
            dtpExpiryDate.Value =
           Convert.ToDateTime(dgvCoupons.Rows(e.RowIndex).Cells("ExpiryDate").Value)
        End If
        ' ✅ SAFE BOOLEAN HANDLING
        If IsDBNull(dgvCoupons.Rows(e.RowIndex).Cells("IsActive").Value) Then
            chkIsActive.Checked = False
        Else
            chkIsActive.Checked =
           Convert.ToBoolean(dgvCoupons.Rows(e.RowIndex).Cells("IsActive").Value)
        End If
        ' STORE OLD DATA FOR AUDIT
        oldAuditData =
       $"Code={txtCode.Text}; Discount={txtDiscount.Text}; Type={cmbDiscountType.Text}; " &
       $"Min={txtMinAmount.Text}; Max={txtMaxDiscount.Text}; " &
       $"Expiry={dtpExpiryDate.Value:d}; Active={chkIsActive.Checked}"

        dgvCoupons.Columns("LastAction").HeaderText = "Last Action"
        dgvCoupons.Columns("LastActionDate").HeaderText = "Last Action Date"
        dgvCoupons.Columns("LastActionDate").DefaultCellStyle.Format = "dd-MMM-yyyy HH:mm"

    End Sub
    ' ================= CLEAR =================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub
    Private Sub ClearForm()
        selectedId = 0
        txtCode.Clear()
        txtDiscount.Clear()
        txtMinAmount.Clear()
        txtMaxDiscount.Clear()
        chkIsActive.Checked = True
        dtpExpiryDate.Value = Date.Today
        cmbDiscountType.SelectedIndex = 0
    End Sub
    ' ================= APPROVAL =================
    Private Sub btnApproval_Click(sender As Object, e As EventArgs) Handles btnApproval.Click
        Dim f As New FrmCouponApproval()
        f.ShowDialog()
        LoadGrid()
    End Sub
    Private Sub dgvCoupons_RowPrePaint(sender As Object,
                                  e As DataGridViewRowPrePaintEventArgs) _
                                  Handles dgvCoupons.RowPrePaint
        Dim row = dgvCoupons.Rows(e.RowIndex)
        If row.Cells("Status").Value Is Nothing Then Exit Sub
        If IsDBNull(row.Cells("Status").Value) Then Exit Sub
        Dim status As String = row.Cells("Status").Value.ToString()
        Select Case status
            Case "Approved"
                row.DefaultCellStyle.BackColor = Color.LightGreen
                row.DefaultCellStyle.ForeColor = Color.Black
            Case "Pending"
                row.DefaultCellStyle.BackColor = Color.LightYellow
                row.DefaultCellStyle.ForeColor = Color.Black
            Case "Rejected"
                row.DefaultCellStyle.BackColor = Color.MistyRose
                row.DefaultCellStyle.ForeColor = Color.Black
            Case Else
                row.DefaultCellStyle.BackColor = Color.LightGray
                row.DefaultCellStyle.ForeColor = Color.Black
        End Select
    End Sub
End Class