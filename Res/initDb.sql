/*   */
INSERT INTO [dbo].[Niveaux] ([Description]) 
VALUES 
(N'1ére PRIMAIRE'),
(N'2éme PRIMAIRE'),
(N'3éme PRIMAIRE'),
(N'4éme PRIMAIRE'),
(N'5éme PRIMAIRE'),
(N'1ére CEM'),
(N'2éme CEM'),
(N'3éme CEM'),
(N'4éme CEM'),
(N'1ére Lycée'),
(N'2éme Lycée'),
(N'3éme Lycée');
 /*   */
INSERT INTO [dbo].[Matieres] ([Description]) 
VALUES 
(N'Physique'),
(N'Sciences Naturelles'),
(N'Mathématique'),
(N'Philosophie'),
(N'Langue Arabe'),
(N'Langue Anglaise'),
(N'Langue Française'),
(N'Langue Allemande'),
(N'Langue Economie'),
(N'Langue Mechanique'),
(N'Histoire & Géographie');
/*   */
INSERT INTO [dbo].[UserTypes] ([Id], [descr]) 
VALUES 
(1, N'ADMIN'),
(2, N'USER');
/*   */
INSERT INTO [dbo].[Users] ( [username], [password], [type]) 
VALUES 
( N'ADMIN', N'admin', 1),
( N'USER', N'user', 2);
/*   */
INSERT INTO [dbo].[Profs] 
( [Name], [FamilyName], [Adresse], [Phone], [userId], [date], [monthly], [prixNormal], [prixVIP], [pourcentage], [autre])
 VALUES 
 ( 'Boukhmisse', 'Azzedine', 'Hamma Bouziane sortie inferieure coté route nationale', '0696689999',1 , '09/24/2017', 1, 2000, 4000, 70, 'autre informations utiles');
/*   */
INSERT INTO [dbo].[Modules]
 ( [Matiere], [ProfId], [year], [userId], [date]) 
VALUES
 ( 1, 1, 12, 1, '09/24/2017');
/*   */
INSERT INTO [dbo].[Groups] 
( [name], [capacite], [moduleId], [date], [userId]) 
VALUES
 ( 'A', 50, 1, '09/24/2017', 1);
/*   */
INSERT INTO [dbo].[Students] 
( [Name], [FamilyName], [Adresse], [Phone], [AlterPhone], [Niveau], [date], [userId]) 
VALUES 
('Ouala Eddine', 'Berrehal', 'SDF', '0696689498', '0696689498', 12, '09/24/2017', 1);
/*   */
INSERT INTO [dbo].[StudModule]
 ( [Id],[StudentId], [ModuleId], [userId], [date]) 
VALUES 
(1, 1, 1, 1, '09/24/2017');
/*   */
INSERT INTO [dbo].[StudPayment]
 ( [StudId], [Montant], [Date], [ModuleId], [userId]) 
VALUES 
( 1, 4000, '09/24/2017', 1, 1);
/*   */
INSERT INTO [dbo].[ProfPayment]
 ( [ProfId], [Montant], [Date], [ModuleId], [userId]) 
VALUES 
( 1, 50000, '09/24/2017', 1, 1);






