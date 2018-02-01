CREATE FUNCTION [dbo].[getStudentGroup]
(
	@studid int,
	@nom varchar,
	@prenom varchar


)

RETURNS TABLE AS RETURN
(
	SELECT [nom],[prenom],[Date affectation],[affecté par]
	From Students_groups WHERE
	(
	   (
			Students_groups.Id = @studid
			OR 
			@studid IS NULL
		)
		AND 
		(
			[nom] LIKE @nom + N'%'
			OR  
			@nom IS NULL
		)
		AND 
		(
			[prenom] LIKE @prenom + N'%'
			OR  
			@prenom IS NULL
		)
	)
)
