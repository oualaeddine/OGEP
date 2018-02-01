
select 
[Groups].[Id],
[matieres].[Description] as matiere,
[Profs].[FamilyName] as Nom_prof,
[Profs].Name as prenom_prof,
[Groups].[name] as [group]

from
 [Groups],
 [Modules],
 [profs],
 [matieres],
 [Niveaux]
 where
 (
 [Groups].[moduleId] = [Modules].[Id]  
 and 
 [profs].[Id] = [modules].[profid]
  and
 [modules].[Matiere] = [Matieres].id 
 and
 [modules].[year] = Niveaux.Id 
 and
 [profs].[Id] = 1
 and
 [modules].[year] = 12
 and
 [modules].[Matiere] = 1
 );
