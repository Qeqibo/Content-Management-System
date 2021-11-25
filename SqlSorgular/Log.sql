Create TRIGGER  [dbo].[WebCmsDB_Trigger]
ON [dbo].[tblLogin] FOR INSERT, UPDATE, DELETE NOT FOR REPLICATION
AS

 SET NOCOUNT ON;

--INSERT,UPDATE yada DELETE i�lemi oldu�unu belirleme

    DECLARE @operation as Varchar(10)
    DECLARE @Count as int
    SET @operation = 'Inserted' -- Setting operation to 'Inserted'
              SELECT @Count = COUNT(*) FROM DELETED
    if @Count > 0
        BEGIN
              SET @operation = 'Deleted' -- Set Operation to 'Deleted'
              SELECT @Count = COUNT(*) FROM INSERTED
              IF @Count > 0
              SET @operation = 'Updated' -- Set Operation to 'Updated'
        END
--Silme i�lemini yakala
	if @operation = 'Deleted'

			BEGIN
				Insert into tblLog(Islem_Tarihi,Islem,id,ad,soyad)
				SELECT GETDATE(),'Deleted',LoginID,LoginName,LoginSurname  from deleted
			END
	ELSE
			BEGIN
--trigger, insert ve update i�in ayn� davran�r.Burada belirtebiliriz.
				SELECT GETDATE(),'inserted',LoginID,LoginName,LoginSurname from inserted
--Yeni kay�t i�lemini yakala
		 if @operation = 'Inserted'

			BEGIN
				 Insert into tblLog(Islem_Tarihi,Islem,id,ad,soyad)
				 SELECT GETDATE(),'inserted',LoginID,LoginName,LoginSurname from inserted
			END
-- G�ncelleme i�lemini yakala
	ELSE
			BEGIN
				  INSERT INTO tblLog(Islem_Tarihi,Islem,id,ad,soyad)
				  SELECT GETDATE(),'Updated',LoginID,LoginName,LoginSurname from inserted

			END
	END