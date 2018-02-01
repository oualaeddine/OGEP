SELECT [Name] as profName,[FamilyName] as ProfFamilyName,[Matieres].[Description] 
from [Modules],[Matieres],[Profs] 
where ([Modules].[year]=1 
and 
[Modules].[Matiere] = [Matieres].[Id] 
and 
[Modules].[ProfId] = [Profs].[Id]);
