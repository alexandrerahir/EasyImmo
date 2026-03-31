/*******************************************************************************
Projet      : EasyImmo
Fichier     : 17_Seed_PropertyDetail.sql
Description : Insertion des données dans la table PropertyDetail (détails des biens immobiliers)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

INSERT INTO PropertyDetail (LivingArea, LandArea, TotalSurfaceArea, BedroomCount, BathroomCount, ToiletCount, TotalRoomCount, EnergyClass, EnergyConsumption, HeatingType, ConstructionYear, Condition, PropertyID) VALUES
    (85.5, NULL, 85.5, 2, 1, 1, 3, 'B', 150.0, 'Central', 2010, 'Bon état', 1),
    (120.0, 300.0, 420.0, 4, 2, 2, 6, 'C', 200.0, 'Gaz', 2005, 'Très bon état', 2);