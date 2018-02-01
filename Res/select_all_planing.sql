SELECT DISTINCT 
[Planning].Id,
Profs.Name as [Prenom prof],
Profs.FamilyName as [Nom prof],
[Matieres].[Description] as [Matiere],
[Niveaux].[Description] as [Niveau],
Groups.name as [Group],
[Days].[desc] as Jour,
Planning.heure,
[Durées].[desc] as durée
FROM 
Planning,
Profs,
Matieres,
Niveaux,
Modules,
[Days],
[Durées],
Groups
WHERE(
Planning.groupId = Groups.Id 
AND
Groups.moduleId = Modules.Id
AND
Niveaux.Id = Modules.[year]
and
Matieres.Id = Modules.Matiere
and
Profs.Id = Modules.ProfId
and
[Days].Id = Planning.jour
and
Durées.Id = Planning.durée
);