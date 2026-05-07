/*******************************************************************************
Projet      : EasyImmo
Fichier     : 12_Seed_Address.sql
Description : Insertion des données dans la table Address (adresses)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

INSERT INTO Address (HouseNumber, BoxNumber, StreetID) VALUES
    (15,  NULL,  1),   -- 15 Rue de Bruxelles, 1300 Wavre
    (42,  'B2',  6),   -- 42 Boulevard Tirou, 6000 Charleroi
    (8,   NULL,  9),   -- 8  Place Saint-Lambert, 4000 Liège
    (73,  'A1',  17),  -- 73 Rue de Fer, 5000 Namur
    (29,  NULL,  13);  -- 29 Rue des Faubourgs, 6700 Arlon