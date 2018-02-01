SELECT DISTINCT
[Profs].Id as [Num],
[Profs].Name as [Nom],
[Profs].FamilyName as [Prenom],
[Profs].Phone as [Tel],
[Profs].monthly as [Methode de payement],
[Profs].pourcentage as [Pourcentage],
[Profs].prixNormal as [Prix G normal],
[Profs].prixVIP as [Prix G VIP],
[Profs].Adresse as [Adresse],
[Profs].autre as [Autres],
[Profs].[date] as [Date inscription],
Users.username as [Ajouté par]
From
[Profs],
Niveaux,
Users
Where(
[Profs].userId = Users.Id
);

