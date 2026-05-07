/*******************************************************************************
Projet      : EasyImmo
Fichier     : 19_Seed_Listing.sql
Description : Insertion des données dans la table Listing (annonces immobilières)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

INSERT INTO Listing (ListingStartDate, ListingEndDate, ListingPrice, AgencyFees, NotaryFees, RentalCharge, RentalWarranty, ListingTypeID, PropertyID, AgentID) VALUES
    -- Propriété 1 - Appartement lumineux - Louer
    ('2026-03-30', NULL, 1200.0, NULL, NULL, 100.0, 1200.0, 2, 1, 1),
    ('2025-11-30', '2026-01-31', 1200.0, NULL, NULL, 100.0, 1200.0, 2, 1, 1),

    -- Propriété 2 - Maison familiale - Vendre
    ('2026-03-30', NULL, 350000.0, 5000.0, 15000.0, NULL, NULL, 1, 2, 2),
    ('2025-12-30', '2026-02-28', 350000.0, 5000.0, 15000.0, NULL, NULL, 1, 2, 2);

    