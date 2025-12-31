Imports BusinessLogic
Imports BusinessLogic.Services
Public Class FrmCouponApproval
    Private svc As New CouponService()
    Private Sub FrmCouponApproval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        cmbStatus.Items.AddRange(New String() {"All", "Pending", "Approved", "Rejected"})
        cmbStatus.SelectedIndex = 0
        LoadGrid()
    End Sub
    Private Sub LoadGrid()
        dgvCoupons.DataSource =
            svc.SearchCoupons(txtSearch.Text.Trim(),
                              cmbStatus.SelectedItem.ToString())
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadGrid()
    End Sub
    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        If dgvCoupons.SelectedRows.Count = 0 Then Exit Sub
        Dim id = CInt(dgvCoupons.SelectedRows(0).Cells("Id").Value)
        svc.ApproveCoupon(id)
        LoadGrid()
    End Sub
    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        If dgvCoupons.SelectedRows.Count = 0 Then Exit Sub
        Dim id = CInt(dgvCoupons.SelectedRows(0).Cells("Id").Value)
        svc.RejectCoupon(id)
        LoadGrid()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvCoupons.SelectedRows.Count = 0 Then Exit Sub
        Dim id = CInt(dgvCoupons.SelectedRows(0).Cells("Id").Value)
        If MessageBox.Show("Delete coupon?", "Confirm",
                           MessageBoxButtons.YesNo) = DialogResult.Yes Then
            svc.DeleteCoupon(id)
            LoadGrid()
        End If
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