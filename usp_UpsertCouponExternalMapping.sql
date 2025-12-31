CREATE PROCEDURE usp_UpsertCouponExternalMapping
    @CouponId INT,
    @ExternalMappingID INT -- You can add more parameters as needed
AS
BEGIN
    SET NOCOUNT ON;
 
    IF EXISTS (SELECT 1 FROM SourceTable WHERE CouponId = @CouponId)
    BEGIN
        -- Update operation
        UPDATE SourceTable
        SET ExternalMappingID = @ExternalMappingID
        WHERE CouponId = @CouponId;
    END
    ELSE
    BEGIN
        -- Insert operation
        INSERT INTO SourceTable (CouponId, ExternalMappingID)
        VALUES (@CouponId, @ExternalMappingID);
    END
END