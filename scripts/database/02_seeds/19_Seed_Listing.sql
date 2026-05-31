/*******************************************************************************
Projet      : EasyImmo
Fichier     : 19_Seed_Listing.sql
Description : Insertion des données dans la table Listing (annonces immobilières)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

INSERT INTO Listing (ListingStartDate, ListingEndDate, ListingPrice, AgencyFees, NotaryFees, RentalCharge, RentalWarranty, ListingTypeID, PropertyID, AgentID) VALUES
-- PropertyID 1 - Studio Wavre (3 locations successives, étudiant tournant)
('2019-09-01', '2020-08-31', 580,   60,  NULL, 50,  1160, 2, 1, 1),
('2020-09-01', '2022-08-31', 600,   60,  NULL, 50,  1200, 2, 1, 1),
('2022-09-01', '2024-08-31', 630,   65,  NULL, 50,  1260, 2, 1, 1),

-- PropertyID 2 - Garage Wavre (jamais mis en annonce, propriétaire l utilise)

-- PropertyID 3 - Maison familiale Charleroi (1 vente terminée)
('2023-01-15', '2023-09-20', 285000, 8500, 22800, NULL, NULL, 1, 3, 3),

-- PropertyID 4 - Appartement Liège centre (3 locations, toujours reloué)
('2018-06-01', '2019-05-31', 780,   75,  NULL, 100, 1560, 2, 4, 2),
('2019-07-01', '2022-06-30', 810,   75,  NULL, 100, 1620, 2, 4, 2),
('2022-09-01', NULL,         850,   75,  NULL, 100, 1700, 2, 4, 2),

-- PropertyID 5 - Studio Liège (2 locations terminées, 1 en cours)
('2019-09-01', '2021-08-31', 490,   55,  NULL, 40,  980,  2, 5, 4),
('2021-09-01', '2023-08-31', 520,   55,  NULL, 40,  1040, 2, 5, 4),
('2023-09-01', NULL,         555,   60,  NULL, 40,  1110, 2, 5, 4),

-- PropertyID 6 - Terrain Liège (vente en cours, sur le marché depuis peu)
('2024-11-01', NULL, 95000, 3000, 7600, NULL, NULL, 1, 6, 5),

-- PropertyID 7 - Garage Liège (jamais mis en annonce)

-- PropertyID 8 - Villa Arlon (1 vente terminée, bien parti vite)
('2022-06-01', '2022-11-30', 595000, 15000, 47600, NULL, NULL, 1, 8, 6),

-- PropertyID 9 - Terrain Arlon boisé (2 tentatives de vente, prix revu)
('2022-04-01', '2022-10-01', 58000, 2000, 4640, NULL, NULL, 1, 9, 7),  -- Pas vendu, trop cher
('2023-03-01', '2023-09-01', 52000, 1800, 4160, NULL, NULL, 1, 9, 7),  -- Pas vendu encore
('2024-03-01', NULL,         46000, 1800, 3680, NULL, NULL, 1, 9, 7),  -- 3ème tentative prix cassé

-- PropertyID 10 - Appartement Namur (jamais mis en annonce, occupé par le proprio)

-- PropertyID 11 - Studio Namur (3 locations successives étudiants)
('2018-09-01', '2020-08-31', 480,   55,  NULL, 30,  960,  2, 11, 2),
('2020-09-01', '2022-08-31', 500,   55,  NULL, 30,  1000, 2, 11, 2),
('2022-09-01', NULL,         540,   60,  NULL, 30,  1080, 2, 11, 2),

-- PropertyID 12 - Maison Namur (longue location, puis vente en cours)
('2015-06-01', '2023-05-31', 920,   100, NULL, 120, 1840, 2, 12, 4),  -- 8 ans de location
('2024-01-15', NULL,         229000, 7000, 18320, NULL, NULL, 1, 12, 4),

-- PropertyID 13 - Appartement Wavre (jamais mis en annonce)

-- PropertyID 14 - Villa Liège domotique (vente en cours premium)
('2024-08-01', NULL, 780000, 20000, 62400, NULL, NULL, 1, 14, 6),

-- PropertyID 15 - Garage box Liège (2 locations successives)
('2020-01-01', '2022-12-31', 80,   40,  NULL, NULL, 160,  2, 15, 7),
('2023-03-01', NULL,         95,   40,  NULL, NULL, 190,  2, 15, 7),

-- PropertyID 16 - Maison campagne Arlon (vente ratée 2x, retiré du marché)
('2021-05-01', '2021-11-01', 275000, 8000, 22000, NULL, NULL, 1, 16, 1),
('2022-02-01', '2022-08-01', 258000, 8000, 20640, NULL, NULL, 1, 16, 1),
-- Propriétaire découragé, plus d annonce

-- PropertyID 17 - Studio Arlon (location en cours)
('2024-10-01', NULL, 490, 55, NULL, 50, 980, 2, 17, 2),

-- PropertyID 18 - Terrain agricole Arlon (jamais mis en annonce, héritage familial)

-- PropertyID 19 - Grand appartement Wavre (location longue durée terminée, vente)
('2016-09-01', '2024-06-30', 1100, 100, NULL, 140, 2200, 2, 19, 4),
('2024-09-01', NULL,         245000, 7500, 19600, NULL, NULL, 1, 19, 4),

-- PropertyID 20 - Villa Liège traditionnelle (1 vente terminée)
('2023-03-01', '2024-01-15', 450000, 12000, 36000, NULL, NULL, 1, 20, 5),

-- PropertyID 21 - Appartement duplex Liège (1 location terminée, 1 en cours)
('2021-06-01', '2024-04-30', 920,   90,  NULL, 80,  1840, 2, 21, 6),
('2024-05-01', NULL,         980,   90,  NULL, 80,  1960, 2, 21, 6),

-- PropertyID 22 - Maison PMR Arlon (vente récente en cours)
('2025-02-01', NULL, 235000, 7000, 18800, NULL, NULL, 1, 22, 7),

-- PropertyID 23 - Appartement Wavre (3 locations puis vente)
('2016-01-01', '2018-12-31', 720,   70,  NULL, 80,  1440, 2, 23, 1),
('2019-02-01', '2021-01-31', 750,   70,  NULL, 80,  1500, 2, 23, 1),
('2021-03-01', '2023-09-30', 780,   75,  NULL, 80,  1560, 2, 23, 1),
('2024-02-01', NULL,         189000, 5800, 15120, NULL, NULL, 1, 23, 1),

-- PropertyID 24 - Studio neuf Wavre (2 locations back to back)
('2022-11-01', '2024-10-31', 740,   75,  NULL, NULL, 1480, 2, 24, 2),
('2024-11-01', NULL,         775,   75,  NULL, NULL, 1550, 2, 24, 2),

-- PropertyID 25 - Garage atelier Wavre (jamais mis en annonce)

-- PropertyID 26 - Villa luxueuse Charleroi (vente en cours exclusivité)
('2025-03-01', NULL, 895000, 22000, 71600, NULL, NULL, 1, 26, 6),

-- PropertyID 27 - Grand terrain Charleroi (vente terminée)
('2022-09-01', '2023-07-10', 110000, 4000, 8800, NULL, NULL, 1, 27, 7),

-- PropertyID 28 - Maison bureau Arlon (jamais mis en annonce, proprio cherche locataire direct)

-- PropertyID 29 - Appartement investissement Charleroi (vente en cours, déjà loué)
('2024-12-01', NULL, 138000, 4500, 11040, NULL, NULL, 1, 29, 2),

-- PropertyID 30 - Studio Charleroi (3 locations successives)
('2019-01-01', '2020-12-31', 450,   50,  NULL, 40,  900,  2, 30, 3),
('2021-02-01', '2022-12-31', 480,   55,  NULL, 40,  960,  2, 30, 3),
('2023-01-01', NULL,         520,   55,  NULL, 40,  1040, 2, 30, 3),

-- PropertyID 31 - Garage double Charleroi (1 location en cours)
('2023-08-01', NULL, 175, 50, NULL, NULL, 350, 2, 31, 4),

-- PropertyID 32 - Terrain viabilisé Charleroi (vente terminée très vite, bien placé)
('2024-01-01', '2024-03-15', 82000, 3000, 6560, NULL, NULL, 1, 32, 5),

-- PropertyID 33 - Villa provençale Liège (2 tentatives vente, prix revu à la baisse)
('2023-06-01', '2023-12-01', 680000, 17000, 54400, NULL, NULL, 1, 33, 6),
('2024-04-01', '2024-10-01', 645000, 16000, 51600, NULL, NULL, 1, 33, 6),
('2025-01-15', NULL,         610000, 16000, 48800, NULL, NULL, 1, 33, 6),

-- PropertyID 34 - Maison avec gîte Arlon (vente en cours)
('2024-07-01', NULL, 310000, 9500, 24800, NULL, NULL, 1, 34, 7),

-- PropertyID 35 - Appartement Arlon (3 locations puis vente)
('2018-04-01', '2020-03-31', 680,   65,  NULL, 60,  1360, 2, 35, 1),
('2020-05-01', '2022-04-30', 700,   65,  NULL, 60,  1400, 2, 35, 1),
('2022-06-01', '2024-05-31', 720,   70,  NULL, 60,  1440, 2, 35, 1),
('2024-09-01', NULL,         168000, 5200, 13440, NULL, NULL, 1, 35, 1),

-- PropertyID 36 - Studio meublé Charleroi (location en cours, récent)
('2024-08-15', NULL, 610, 65, NULL, NULL, 1220, 2, 36, 2),

-- PropertyID 37 - Villa bord de Meuse (vente en cours, bien exceptionnel)
('2025-02-15', NULL, 980000, 25000, 78400, NULL, NULL, 1, 37, 6),

-- PropertyID 38 - Appartement spacieux Liège (jamais mis en annonce, famille)

-- PropertyID 39 - Box stockage Liège (3 locations successives)
('2019-01-01', '2020-12-31', 85,   35,  NULL, NULL, 170, 2, 39, 4),
('2021-01-01', '2022-12-31', 95,   40,  NULL, NULL, 190, 2, 39, 4),
('2023-01-01', NULL,         110,  40,  NULL, NULL, 220, 2, 39, 4),

-- PropertyID 40 - Maison rénovée Arlon (vente en cours)
('2025-01-01', NULL, 289000, 9000, 23120, NULL, NULL, 1, 40, 5),

-- PropertyID 41 - Terrain plat Arlon (2 tentatives, prix revu)
('2023-05-01', '2023-11-01', 72000, 2500, 5760, NULL, NULL, 1, 41, 7),
('2024-10-15', NULL,         63000, 2500, 5040, NULL, NULL, 1, 41, 7),

-- PropertyID 42 - Appartement Charleroi (jamais mis en annonce)

-- PropertyID 43 - Villa court de tennis Namur (vente en cours prestige)
('2024-11-01', NULL, 750000, 19000, 60000, NULL, NULL, 1, 43, 6),

-- PropertyID 44 - Studio étudiant Namur (3 locations successives rentrées)
('2020-09-01', '2022-08-31', 400,   50,  NULL, 30,  800,  2, 44, 7),
('2022-09-01', '2024-08-31', 420,   50,  NULL, 30,  840,  2, 44, 7),
('2024-09-01', NULL,         450,   55,  NULL, 30,  900,  2, 44, 7);

    