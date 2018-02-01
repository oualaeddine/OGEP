/*get identities and reset cmd*/
SELECT 
    IDENT_SEED(TABLE_NAME) AS Seed,
    IDENT_INCR(TABLE_NAME) AS Increment,
    IDENT_CURRENT(TABLE_NAME) AS Current_Identity,
    TABLE_NAME,
    'DBCC CHECKIDENT(' + TABLE_NAME + ', RESEED, ' + CAST(IDENT_SEED(TABLE_NAME) AS VARCHAR(10)) + ')'
FROM 
    INFORMATION_SCHEMA.TABLES
WHERE 
    OBJECTPROPERTY(OBJECT_ID(TABLE_NAME), 'TableHasIdentity') = 1
    AND TABLE_TYPE = 'BASE TABLE'
	/*reset identity*/
	EXEC sp_MSforeachtable 'DBCC CHECKIDENT ([?], reseed, 1)'
