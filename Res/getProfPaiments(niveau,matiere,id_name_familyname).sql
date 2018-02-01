CREATE FUNCTION [dbo].[getProfPaiments]
(
	@matiere int,
	@niveau int,
	@search varchar
)
RETURNS TABLE AS RETURN
(
	select [Prenom prof],[Nom prof],[Matiere],[Niveau],[Montant],[Date],[Effectué par]
	from profsPay where 
	(
		(
			profsPay.matiereId = @matiere
			OR 
			@matiere IS NULL
		)
		AND 
		(
			profsPay.NiveauId = @niveau 
			OR  
			@niveau IS NULL
		)
		AND 
		(
			(
				([Nom prof] LIKE @search + N'%') 	
				OR	
				([Prenom prof] LIKE @search + N'%') 
				OR
				(profsPay.ProfId LIKE @search + N'%')
			)
			OR
			@search IS NULL
		)
	)
)