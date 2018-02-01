SELECT DISTINCT
[Students].Id as Num,
Students.Name as Nom,
Students.FamilyName as Prenom,
Students.Phone as Tel,
Students.AlterPhone as Tel2,
Niveaux.[Description] as [Niveau],
Students.Adresse as Adresse,
Students.[date] as [Date inscription],
Users.username as [Ajouté par]
From
Students,
Niveaux,
Users
Where(
Students.Niveau = Niveaux.Id 
AND
Students.userId = Users.Id
);

