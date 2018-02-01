CREATE FUNCTION [dbo].[getGroupsInfo]
(
	@niveau int,
	@matiere int,
	@enseignant int
)

RETURNS TABLE AS RETURN
(
	select [matiere],[Nom_prof],[prenom_prof],[group]
	from Groups_info where 
	(
		(
			Groups_info.niveauId = @niveau
			OR 
			@niveau IS NULL
		)
		AND 
		(
			Groups_info.matiereId = @matiere
			OR  
			@matiere IS NULL
		)
		AND 
		(
			Groups_info.ProfId=@enseignant
			OR
			@enseignant IS NULL
		)
	)
)