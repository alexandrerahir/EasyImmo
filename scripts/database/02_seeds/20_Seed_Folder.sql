/*******************************************************************************
Projet      : EasyImmo
Fichier     : 20_Seed_Folder.sql
Description : Insertion de données dans la table Folder (dossiers)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

INSERT INTO Folder (FolderOpenDate, ListingID, PersonID) VALUES 
    -- listing de l'appartement lumineux à louer (ListingID = 1) (dossier en cours)
    ('2026-03-30', 1, 4),

    -- listing de l'appartment lumineux à louer (ListingID = 2) (dossier fini)
    ('2025-11-30', '2026-01-31', 'Bail signé/remise clés', 2, 3),

    -- listing de la maison familiale à vendre (ListingID = 3) (dossier en cours)
    ('2026-03-30', 3, 6),

    -- listing de la maison familiale à vendre (ListingID = 4) (dossier fini)
    ('2025-12-30', '2026-02-28', 'Vente conclue', 4, 5)