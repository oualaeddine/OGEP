CREATE VIEW [dbo].[Students_paiments]
	AS 

	select distinct
	[StudPayment].[Id],
	[Students].[FamilyName] as [Nom],
	[Students].[Name] as [prenom],
	[Matieres].[Description] as [matiere],
	[Profs].[FamilyName] as [Nom Prof],
	[Profs].[Name] as [prenom Prof],
	[Niveaux].[Description] as [niveau],
	Students.Id as studId,
	[Modules].[id] as moduleid,
	[Niveaux].[id] as niveauid

from
	Niveaux,Profs,Matieres,Students,StudPayment,Modules
where(
	[StudPayment].[StudId] = [Students].[Id] 
	and
	[StudPayment].[ModuleId] = [Modules].[Id] 
	and
	[Modules].[Matiere] = [Matieres].[Id] 
	and
	[Modules].[ProfId] = [Profs].[Id] 
	and
	[Modules].[year] = [Niveaux].[Id]
);