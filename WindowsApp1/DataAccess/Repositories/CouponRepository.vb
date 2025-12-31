Imports System.Data
Imports System.Data.SqlClient
Public Class CouponRepository
    Public Sub CreateCoupon(code As String, discount As Decimal,
                            dtype As String, minAmt As Decimal,
                            maxDisc As Decimal, expiry As Date,
                            active As Boolean)
        Using con = DbHelper.GetConnection()
            con.Open()
            Dim cmd As New SqlCommand(
                "INSERT INTO Coupons
                (Code, Discount, DiscountType, MinAmount, MaxDiscount, ExpiryDate, IsActive, Status)
                VALUES (@c,@d,@t,@min,@max,@exp,@act,'Pending')", con)
            cmd.Parameters.AddWithValue("@c", code)
            cmd.Parameters.AddWithValue("@d", discount)
            cmd.Parameters.AddWithValue("@t", dtype)
            cmd.Parameters.AddWithValue("@min", minAmt)
            cmd.Parameters.AddWithValue("@max", maxDisc)
            cmd.Parameters.AddWithValue("@exp", expiry)
            cmd.Parameters.AddWithValue("@act", active)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
    Public Sub UpdateCoupon(id As Integer, code As String, discount As Decimal,
                            dtype As String, minAmt As Decimal,
                            maxDisc As Decimal, expiry As Date,
                            active As Boolean)
        Using con = DbHelper.GetConnection()
            con.Open()
            Dim cmd As New SqlCommand(
                "UPDATE Coupons SET
                Code=@c, Discount=@d, DiscountType=@t,
                MinAmount=@min, MaxDiscount=@max,
                ExpiryDate=@exp, IsActive=@act
                WHERE Id=@id", con)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@c", code)
            cmd.Parameters.AddWithValue("@d", discount)
            cmd.Parameters.AddWithValue("@t", dtype)
            cmd.Parameters.AddWithValue("@min", minAmt)
            cmd.Parameters.AddWithValue("@max", maxDisc)
            cmd.Parameters.AddWithValue("@exp", expiry)
            cmd.Parameters.AddWithValue("@act", active)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function SearchCoupons(code As String, status As String) As DataTable
        Dim dt As New DataTable()
        Using con = DbHelper.GetConnection()
            Dim cmd As New SqlCommand(
           "SELECT
               c.Id,
               c.Code,
               c.Discount,
               c.DiscountType,
               c.MinAmount,
               c.MaxDiscount,
               c.ExpiryDate,
               c.IsActive,
               c.Status,
               a.Action AS LastAction,
               a.ActionDate AS LastActionDate
            FROM Coupons c
            OUTER APPLY
            (
                SELECT TOP 1 Action, ActionDate
                FROM CouponAuditLog
                WHERE CouponId = c.Id
                ORDER BY ActionDate DESC
            ) a
            WHERE (@c = '' OR c.Code LIKE '%' + @c + '%')
              AND (@s = 'All' OR c.Status = @s) ORDER BY 1 DESC", con)
            cmd.Parameters.AddWithValue("@c", code)
            cmd.Parameters.AddWithValue("@s", status)
            Using da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function
    Public Sub ApproveCoupon(id As Integer)
        UpdateStatus(id, "Approved")
    End Sub
    Public Sub RejectCoupon(id As Integer)
        UpdateStatus(id, "Rejected")
    End Sub
    Private Sub UpdateStatus(id As Integer, status As String)
        Using con = DbHelper.GetConnection()
            con.Open()
            Dim cmd As New SqlCommand(
           "UPDATE Coupons SET Status=@s WHERE Id=@id", con)
            cmd.Parameters.AddWithValue("@s", status)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
    Public Sub DeleteCoupon(id As Integer)
        Using con = DbHelper.GetConnection()
            con.Open()
            Dim cmd As New SqlCommand("DELETE FROM Coupons WHERE Id=@id", con)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
    Public Sub LogAudit(id As Integer, action As String, oldVal As String, newVal As String)
        Using con = DbHelper.GetConnection()
            con.Open()
            Dim cmd As New SqlCommand(
           "INSERT INTO CouponAuditLog (CouponId, Action, OldValue, NewValue)
            VALUES (@cid,@act,@old,@new)", con)
            cmd.Parameters.AddWithValue("@cid", id)
            cmd.Parameters.AddWithValue("@act", action)
            cmd.Parameters.AddWithValue("@old", oldVal)
            cmd.Parameters.AddWithValue("@new", newVal)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class