CREATE FUNCTION [dbo].[getStudentPaiment]
(
	@module int,
	@niveau int,
	@search varchar
)
RETURNS TABLE AS RETURN
(
	SELECT [nom],[prenom],[matiere],[nom prof],[prenom prof],[niveau]
	FROM Students_paiments
	Where
	(
		(
			Students_paiments.moduleid = @module
			OR 
			@module IS NULL
		)
		AND 
		(
			Students_paiments.Niveauid = @niveau 
			OR  
			@niveau IS NULL
		)
		AND 
		(
			(
				([Nom] LIKE @search + N'%') 	
				OR	
				([Prenom] LIKE @search + N'%') 
				OR
				(Students_paiments.studId LIKE @search + N'%')
			)
			OR
			@search IS NULL
		)
	)
)
