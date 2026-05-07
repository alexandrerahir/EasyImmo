/*******************************************************************************
Projet      : EasyImmo
Fichier     : 17_Create_PropertyDetail.sql
Description : Création de la table PropertyDetail (détails d'une propriété)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

CREATE TABLE PropertyDetail (
    PropertyDetailID INT IDENTITY(1,1) PRIMARY KEY,
    LivingArea FLOAT NULL,
    LandArea FLOAT NULL,
    TotalSurfaceArea FLOAT NULL,
    BedroomCount INT NULL,
    BathroomCount INT NULL,
    ToiletCount INT NULL,
    TotalRoomCount INT NULL,
    EnergyClass NVARCHAR(20) NULL,
    EnergyConsumption FLOAT NULL,
    HeatingType NVARCHAR(50) NULL,
    ConstructionYear INT NULL,
    Condition NVARCHAR(50) NULL,

    -- Clé étrangère
    PropertyID INT NOT NULL,

    FOREIGN KEY (PropertyID) REFERENCES Property(PropertyID)
);