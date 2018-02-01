select distinct
[Modules].[Id] ,
[Matieres].[Description] as [matiere],
[Niveaux].[Description] as [niveau],
[Modules].[date],
Modules.ProfId

from
[Modules],
[Niveaux],
[Matieres]
where(
[modules].ProfId = 1
and
[modules].[year] = [niveaux].[Id]
and
[modules].[Matiere] = [Matieres].[Id]

);
 