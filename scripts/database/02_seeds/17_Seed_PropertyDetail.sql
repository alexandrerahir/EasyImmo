/*******************************************************************************
Projet      : EasyImmo
Fichier     : 17_Seed_PropertyDetail.sql
Description : Insertion des données dans la table PropertyDetail (détails des biens immobiliers)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

INSERT INTO PropertyDetail (LivingArea, LandArea, TotalSurfaceArea, BedroomCount, BathroomCount, ToiletCount, TotalRoomCount, EnergyClass, EnergyConsumption, HeatingType, ConstructionYear, Condition, PropertyID) VALUES
    (28,   NULL,  28,   0, 1, 1, 1,  'D', 280, 'Électrique',   2005, 'Bon',          1),
    (18,   NULL,  18,   0, 0, 0, 1,  'E', NULL, NULL,          1990, 'Correct',       2),
    (145,  300,   445,  4, 2, 2, 8,  'C', 180, 'Gaz naturel',  1998, 'Bon',          3),
    (95,   NULL,  95,   3, 1, 1, 5,  'B', 120, 'Gaz naturel',  2010, 'Très bon',     4),
    (32,   NULL,  32,   0, 1, 1, 1,  'C', 210, 'Électrique',   2015, 'Excellent',    5),
    (NULL, 800,   800,  0, 0, 0, 0,  NULL, NULL, NULL,         NULL, 'Non bâti',      6),
    (45,   NULL,  45,   0, 1, 1, 2,  'D', 260, 'Électrique',   1985, 'Correct',      7),
    (280,  1200,  1480, 5, 3, 4, 12, 'A', 85,  'Pompe à chaleur', 2018, 'Excellent', 8),
    (NULL, 1500,  1500, 0, 0, 0, 0,  NULL, NULL, NULL,         NULL, 'Non bâti',      9),
    (75,   NULL,  75,   2, 1, 1, 4,  'C', 195, 'Gaz naturel',  2008, 'Bon',          10),
    (30,   NULL,  30,   0, 1, 1, 1,  'C', 220, 'Électrique',   2012, 'Très bon',     11),
    (110,  80,    190,  3, 1, 2, 6,  'D', 240, 'Mazout',       1975, 'Correct',      12),
    (88,   NULL,  88,   3, 1, 1, 5,  'B', 135, 'Gaz naturel',  2014, 'Très bon',     13),
    (320,  800,   1120, 5, 3, 4, 14, 'A', 75,  'Pompe à chaleur', 2020, 'Excellent', 14),
    (20,   NULL,  20,   0, 0, 0, 1,  'E', NULL, NULL,          2000, 'Bon',          15),
    (130,  600,   730,  3, 2, 2, 7,  'C', 200, 'Gaz naturel',  1988, 'Bon',          16),
    (29,   NULL,  29,   0, 1, 1, 1,  'D', 270, 'Électrique',   2003, 'Correct',      17),
    (NULL, 20000, 20000,0, 0, 0, 0,  NULL, NULL, NULL,         NULL, 'Non bâti',      18),
    (120,  NULL,  120,  5, 2, 2, 7,  'C', 185, 'Gaz naturel',  2011, 'Bon',          19),
    (250,  900,   1150, 4, 2, 3, 10, 'B', 110, 'Gaz naturel',  2005, 'Très bon',     20),
    (65,   NULL,  65,   2, 1, 1, 4,  'B', 145, 'Gaz naturel',  2016, 'Excellent',    21),
    (115,  450,   565,  3, 1, 2, 6,  'C', 175, 'Mazout',       1995, 'Bon',          22),
    (82,   NULL,  82,   3, 1, 1, 5,  'C', 190, 'Gaz naturel',  2009, 'Bon',          23),
    (27,   NULL,  27,   0, 1, 1, 1,  'A', 60,  'Électrique',   2022, 'Excellent',    24),
    (40,   NULL,  40,   0, 1, 1, 2,  'D', NULL, 'Électrique',  1992, 'Correct',      25),
    (350,  1500,  1850, 5, 4, 5, 15, 'A', 70,  'Pompe à chaleur', 2019, 'Excellent', 26),
    (NULL, 3000,  3000, 0, 0, 0, 0,  NULL, NULL, NULL,         NULL, 'Non bâti',      27),
    (140,  500,   640,  4, 2, 2, 8,  'B', 125, 'Gaz naturel',  2013, 'Très bon',     28),
    (70,   NULL,  70,   2, 1, 1, 3,  'C', 215, 'Électrique',   2007, 'Bon',          29),
    (31,   NULL,  31,   0, 1, 1, 1,  'C', 235, 'Électrique',   2010, 'Bon',          30),
    (36,   NULL,  36,   0, 0, 0, 2,  'D', NULL, NULL,          2001, 'Correct',      31),
    (NULL, 600,   600,  0, 0, 0, 0,  NULL, NULL, NULL,         NULL, 'Non bâti',      32),
    (290,  1100,  1390, 5, 3, 4, 13, 'B', 95,  'Pompe à chaleur', 2015, 'Excellent', 33),
    (160,  700,   860,  4, 2, 3, 9,  'C', 170, 'Gaz naturel',  2000, 'Bon',          34),
    (78,   NULL,  78,   3, 1, 1, 4,  'B', 130, 'Gaz naturel',  2017, 'Très bon',     35),
    (33,   NULL,  33,   0, 1, 1, 1,  'B', 155, 'Électrique',   2018, 'Excellent',    36),
    (310,  2000,  2310, 5, 4, 4, 14, 'A', 80,  'Pompe à chaleur', 2021, 'Excellent', 37),
    (105,  NULL,  105,  4, 2, 2, 7,  'B', 140, 'Gaz naturel',  2012, 'Très bon',     38),
    (22,   NULL,  22,   0, 0, 0, 1,  'C', NULL, NULL,          2008, 'Bon',          39),
    (135,  550,   685,  4, 2, 2, 8,  'B', 115, 'Gaz naturel',  2016, 'Excellent',    40),
    (NULL, 1000,  1000, 0, 0, 0, 0,  NULL, NULL, NULL,         NULL, 'Non bâti',      41),
    (68,   NULL,  68,   2, 1, 1, 4,  'C', 205, 'Électrique',   2006, 'Bon',          42),
    (300,  1800,  2100, 5, 3, 4, 13, 'A', 90,  'Pompe à chaleur', 2017, 'Excellent', 43),
    (26,   NULL,  26,   0, 1, 1, 1,  'D', 290, 'Électrique',   2004, 'Correct',      44);