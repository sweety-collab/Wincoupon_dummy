Imports System.Data
Imports DataAccess

Public Class CouponService

    Private ReadOnly repo As New CouponRepository()

    ''' <summary>
    ''' Formats coupon data as a string for audit logging.
    ''' </summary>
    Private Function FormatData(code As String, discount As Decimal,
                                dtype As String, minAmt As Decimal,
                                maxDisc As Decimal, expiry As Date,
                                active As Boolean) As String
        Return $"Code={code}; Discount={discount}; Type={dtype}; " &
               $"Min={minAmt}; Max={maxDisc}; Expiry={expiry:d}; Active={active}"
    End Function


    ''' <summary>
    ''' Creates a coupon and logs the action for auditing.
    ''' </summary>
    Public Sub CreateCouponWithAudit(code As String, discount As Decimal,
                                     dtype As String, minAmt As Decimal,
                                     maxDisc As Decimal, expiry As Date,
                                     active As Boolean)
        repo.CreateCoupon(code, discount, dtype, minAmt, maxDisc, expiry, active)
        repo.LogAudit(0, "CREATE", "", FormatData(code, discount, dtype, minAmt, maxDisc, expiry, active))
    End Sub

    ''' <summary>
    ''' Updates a coupon and logs the action for auditing.
    ''' </summary>
    Public Sub UpdateCouponWithAudit(id As Integer, oldData As String,
                                     code As String, discount As Decimal,
                                     dtype As String, minAmt As Decimal,
                                     maxDisc As Decimal, expiry As Date,
                                     active As Boolean)
        repo.UpdateCoupon(id, code, discount, dtype, minAmt, maxDisc, expiry, active)
        repo.LogAudit(id, "UPDATE", oldData, FormatData(code, discount, dtype, minAmt, maxDisc, expiry, active))
    End Sub
    ' ================= SEARCH =================
    Public Function SearchCoupons(code As String, status As String) As DataTable
        Return repo.SearchCoupons(code, status)
    End Function
    ' ================= APPROVE =================
    ' ================= APPROVE =================
    Public Sub ApproveCoupon(id As Integer)
        repo.ApproveCoupon(id)
        repo.LogAudit(id, "APPROVE", "Pending", "Approved")
    End Sub
    ' ================= REJECT =================
    Public Sub RejectCoupon(id As Integer)
        repo.RejectCoupon(id)
        repo.LogAudit(id, "REJECT", "Pending", "Rejected")
    End Sub
    ' ================= DELETE =================
    Public Sub DeleteCoupon(id As Integer)
        repo.DeleteCoupon(id)
        repo.LogAudit(id, "DELETE", "Exists", "Deleted")
    End Sub
End Class
