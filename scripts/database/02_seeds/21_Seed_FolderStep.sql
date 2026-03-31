/*******************************************************************************
Projet      : EasyImmo
Fichier     : 21_Seed_FolderStep.sql
Description : Insertion de données dans la table FolderStep (étapes des dossiers)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

INSERT INTO FolderStep (FolderStepDate, FolderStepNote, FolderID, StepTypeID) VALUES
    -- Etapes du dossier de l'appartement lumineux à louer (ListingID = 1)
    ('2026-03-30', 'Demande de visite via le site.', 1, 1),
    ('2026-03-31', 'Visite effectuée. Très bon feeling.', 1, 3),

    -- Etapes du dossier de l'appartment lumineux à louer (ListingID = 2) (dossier fini)
    ('2025-11-30', 'Demande de visite via le site.', 2, 1),
    ('2025-12-01', 'Visite effectuée. Très bon feeling.', 2, 3),
    ('2025-12-02', 'Offre déposée par le client.', 2, 4),
    ('2025-12-03', 'Offre acceptée par l''agent.', 2, 7),
    ('2025-12-10', 'Bail envoyé au client pour signature.', 2, 15),
    ('2025-12-15', 'Bail signé reçu du client.', 2, 16),
    ('2026-01-25', 'Etat des lieux planifié pour le 30/01/2026.', 2, 17),
    ('2026-01-30', 'Etat des lieux effectué. Remise des clés effectuée.', 2, 23),

    -- Etapes du dossier de la maison familiale à vendre (ListingID = 3) (dossier en cours)
    ('2026-03-30', 'Renseignements sur le cadastre.', 3, 1),
    ('2026-04-02', 'Offre déposée à 340.000€.', 3, 4),

    -- Etapes du dossier de la maison familiale à vendre (ListingID = 4) (dossier fini)
    ('2023-12-30', 'Renseignements sur le cadastre.', 4, 1),
    ('2024-01-05', 'Offre déposée à 340.000€.', 4, 4),
    ('2024-01-10', 'Offre acceptée par le vendeur.', 4, 7),
    ('2024-01-15', 'Compromis envoyé au client pour signature.', 4, 9),
    ('2024-01-20', 'Compromis signé reçu du client.', 4, 10),
    ('2024-02-01', 'Acte notarié envoyé au client pour signature.', 4, 11),
    ('2024-02-20', 'Acte notarié signé reçu du client. Vente conclue.', 4, 12),
    ('2024-02-25', 'Paiement reçu du client.', 4, 19),
    ('2024-02-28', 'Remise des clés effectuée.', 4, 23);