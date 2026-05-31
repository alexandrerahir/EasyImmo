/*******************************************************************************
Projet      : EasyImmo
Fichier     : 20_Seed_Folder.sql
Description : Insertion de données dans la table Folder (dossiers)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

INSERT INTO Folder (FolderOpenDate, FolderCloseDate, FolderCloseReason, ListingID, PersonID) VALUES
-- Listing 1 (terminé) - 2 dossiers
('2019-09-05', '2019-10-01', 'Dossier incomplet', 1, 3),
('2019-10-15', '2020-08-31', 'Contrat signé', 1, 7),

-- Listing 2 (terminé) - 2 dossiers
('2020-09-10', '2020-10-05', 'Candidat désisté', 2, 12),
('2020-10-20', '2020-11-15', 'Contrat signé', 2, 19),

-- Listing 3 (terminé) - 1 dossier
('2022-09-15', '2022-10-20', 'Contrat signé', 3, 25),

-- Listing 4 (terminé) - 1 dossier
('2023-01-20', '2023-02-15', 'Contrat signé', 4, 8),

-- Listing 5 (terminé) - 2 dossiers
('2018-06-10', '2018-07-01', 'Dossier refusé', 5, 14),
('2018-07-15', '2018-08-01', 'Contrat signé', 5, 21),

-- Listing 6 (terminé) - 1 dossier
('2019-07-10', '2019-08-01', 'Contrat signé', 6, 33),

-- Listing 7 (ouvert) - 2 dossiers
('2022-09-10', NULL, NULL, 7, 41),
('2022-11-01', NULL, NULL, 7, 45),

-- Listing 8 (terminé) - 2 dossiers
('2019-09-10', '2019-10-15', 'Candidat désisté', 8, 2),
('2019-10-20', '2019-11-30', 'Contrat signé', 8, 16),

-- Listing 9 (terminé) - 1 dossier
('2021-09-05', '2021-10-10', 'Contrat signé', 9, 28),

-- Listing 10 (ouvert) - 2 dossiers
('2023-09-05', NULL, NULL, 10, 37),
('2023-11-01', NULL, NULL, 10, 50),

-- Listing 11 (ouvert) - 1 dossier
('2024-11-10', NULL, NULL, 11, 43),

-- Listing 12 (terminé) - 2 dossiers
('2022-06-05', '2022-07-01', 'Dossier incomplet', 12, 5),
('2022-07-15', '2022-08-30', 'Contrat signé', 12, 11),

-- Listing 13 (terminé) - 1 dossier
('2022-04-10', '2022-05-20', 'Contrat signé', 13, 22),

-- Listing 14 (terminé) - 2 dossiers
('2023-03-05', '2023-04-01', 'Candidat désisté', 14, 31),
('2023-04-15', '2023-06-01', 'Contrat signé', 14, 38),

-- Listing 15 (ouvert) - 1 dossier
('2024-03-10', NULL, NULL, 15, 47),

-- Listing 16 (terminé) - 2 dossiers
('2018-09-10', '2018-10-15', 'Dossier refusé', 16, 6),
('2018-11-01', '2019-01-15', 'Contrat signé', 16, 13),

-- Listing 17 (terminé) - 1 dossier
('2020-09-10', '2020-10-20', 'Contrat signé', 17, 24),

-- Listing 18 (ouvert) - 2 dossiers
('2022-09-15', NULL, NULL, 18, 35),
('2023-01-10', NULL, NULL, 18, 49),

-- Listing 19 (terminé) - 1 dossier
('2015-06-10', '2015-08-01', 'Contrat signé', 19, 4),

-- Listing 20 (ouvert) - 1 dossier
('2024-01-20', NULL, NULL, 20, 52),

-- Listing 21 (ouvert) - aucun dossier (propriété sans dossier)

-- Listing 22 (terminé) - 2 dossiers
('2020-01-10', '2020-02-15', 'Dossier incomplet', 22, 9),
('2020-03-01', '2020-04-15', 'Contrat signé', 22, 17),

-- Listing 23 (ouvert) - 1 dossier
('2023-03-10', NULL, NULL, 23, 26),

-- Listing 24 (terminé) - 1 dossier
('2021-05-10', '2021-07-01', 'Contrat signé', 24, 39),

-- Listing 25 (terminé) - 2 dossiers
('2022-02-05', '2022-03-01', 'Candidat désisté', 25, 44),
('2022-03-15', '2022-06-01', 'Contrat signé', 25, 10),

-- Listing 26 (ouvert) - 1 dossier
('2024-10-10', NULL, NULL, 26, 57),

-- Listing 27 (terminé) - 1 dossier
('2016-09-10', '2017-01-01', 'Contrat signé', 27, 18),

-- Listing 28 (ouvert) - 2 dossiers
('2024-09-10', NULL, NULL, 28, 30),
('2024-10-15', NULL, NULL, 28, 42),

-- Listing 29 (terminé) - 1 dossier
('2023-03-10', '2023-05-01', 'Contrat signé', 29, 54),

-- Listing 30 (terminé) - 1 dossier
('2021-06-10', '2021-08-01', 'Contrat signé', 30, 15),

-- Listing 31 (ouvert) - 2 dossiers
('2024-05-10', NULL, NULL, 31, 23),
('2024-06-15', NULL, NULL, 31, 48),

-- Listing 32 (ouvert) - 1 dossier
('2025-02-05', NULL, NULL, 32, 56),

-- Listing 33 (terminé) - 2 dossiers
('2016-01-10', '2016-03-01', 'Dossier refusé', 33, 1),
('2016-04-01', '2016-06-01', 'Contrat signé', 33, 20),

-- Listing 34 (terminé) - 1 dossier
('2019-02-10', '2019-04-01', 'Contrat signé', 34, 29),

-- Listing 35 (terminé) - 1 dossier
('2021-03-10', '2021-05-01', 'Contrat signé', 35, 36),

-- Listing 36 (ouvert) - 1 dossier
('2024-02-10', NULL, NULL, 36, 51),

-- Listing 37 (terminé) - 2 dossiers
('2022-11-05', '2022-12-01', 'Candidat désisté', 37, 40),
('2023-01-15', '2023-03-01', 'Contrat signé', 37, 46),

-- Listing 38 (ouvert) - 1 dossier
('2024-11-10', NULL, NULL, 38, 53),

-- Listing 39 (ouvert) - aucun dossier (propriété sans dossier)

-- Listing 40 (terminé) - 1 dossier
('2022-09-10', '2022-11-01', 'Contrat signé', 40, 27),

-- Listing 41 (ouvert) - 1 dossier
('2024-12-10', NULL, NULL, 41, 32),

-- Listing 42 (terminé) - 2 dossiers
('2019-01-10', '2019-02-15', 'Dossier incomplet', 42, 55),
('2019-03-01', '2019-05-01', 'Contrat signé', 42, 34),

-- Listing 43 (terminé) - 1 dossier
('2021-02-10', '2021-04-01', 'Contrat signé', 43, 7),

-- Listing 44 (ouvert) - 2 dossiers
('2023-01-10', NULL, NULL, 44, 3),
('2023-03-01', NULL, NULL, 44, 9),

-- Listing 45 (ouvert) - 1 dossier
('2023-08-10', NULL, NULL, 45, 19),

-- Listing 46 (terminé) - 2 dossiers
('2024-01-05', '2024-02-01', 'Dossier refusé', 46, 28),
('2024-02-15', '2024-03-10', 'Contrat signé', 46, 11),

-- Listing 47 (terminé) - 1 dossier
('2023-06-10', '2023-08-01', 'Contrat signé', 47, 45),

-- Listing 48 (terminé) - 2 dossiers
('2024-04-05', '2024-05-15', 'Candidat désisté', 48, 16),
('2024-05-20', '2024-07-01', 'Contrat signé', 48, 21),

-- Listing 49 (ouvert) - 1 dossier
('2025-01-20', NULL, NULL, 49, 38),

-- Listing 50 (ouvert) - aucun dossier (propriété sans dossier)

-- Listing 51 (terminé) - 1 dossier
('2018-04-10', '2018-06-01', 'Contrat signé', 51, 6),

-- Listing 52 (terminé) - 1 dossier
('2020-05-10', '2020-07-01', 'Contrat signé', 52, 14),

-- Listing 53 (terminé) - 2 dossiers
('2022-06-05', '2022-07-15', 'Dossier incomplet', 53, 22),
('2022-08-01', '2022-10-01', 'Contrat signé', 53, 30),

-- Listing 54 (ouvert) - 1 dossier
('2024-09-10', NULL, NULL, 54, 47),

-- Listing 55 (ouvert) - 2 dossiers
('2024-08-20', NULL, NULL, 55, 4),
('2024-09-15', NULL, NULL, 55, 12),

-- Listing 56 (ouvert) - 1 dossier
('2025-02-20', NULL, NULL, 56, 39),

-- Listing 57 (terminé) - 1 dossier
('2019-01-10', '2019-03-01', 'Contrat signé', 57, 26),

-- Listing 58 (terminé) - 2 dossiers
('2021-01-10', '2021-02-15', 'Candidat désisté', 58, 33),
('2021-03-01', '2021-05-01', 'Contrat signé', 58, 41),

-- Listing 59 (ouvert) - 1 dossier
('2023-01-10', NULL, NULL, 59, 50),

-- Listing 60 (ouvert) - aucun dossier (propriété sans dossier)

-- Listing 61 (terminé) - 1 dossier
('2023-05-10', '2023-07-01', 'Contrat signé', 61, 8),

-- Listing 62 (ouvert) - 2 dossiers
('2024-10-20', NULL, NULL, 62, 17),
('2024-11-15', NULL, NULL, 62, 44),

-- Listing 63 (ouvert) - 1 dossier
('2024-11-10', NULL, NULL, 63, 55),

-- Listing 64 (terminé) - 2 dossiers
('2020-09-10', '2020-10-15', 'Dossier refusé', 64, 2),
('2020-11-01', '2021-01-15', 'Contrat signé', 64, 10),

-- Listing 65 (terminé) - 1 dossier
('2022-09-10', '2022-11-01', 'Contrat signé', 65, 18),

-- Listing 66 (ouvert) - 2 dossiers
('2024-09-10', NULL, NULL, 66, 29),
('2024-10-20', NULL, NULL, 66, 37);

