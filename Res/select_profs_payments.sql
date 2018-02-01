SELECT DISTINCT 
ProfPayment.Id,
Profs.Name as [Prenom prof],
Profs.FamilyName as [Nom prof],
Matieres.[Description] as Matiere,
Niveaux.[Description] as Niveau,
ProfPayment.Montant ,
ProfPayment.[Date],
Users.username as [Effectué par]
from
ProfPayment,
Profs,
Matieres,
Niveaux,
Users,
Modules
where(
ProfPayment.ProfId = Profs.Id 
and
Modules.Id = ProfPayment.ModuleId
and
Matieres.Id = Modules.Id
and
Niveaux.Id = Modules.[year]
and
Users.Id = ProfPayment.userId
);
