/*******************************************************************************
Projet      : EasyImmo
Fichier     : 07_Create_Region.sql
Description : Création de la table Region (régions)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

CREATE TABLE Region(
    RegionID INT IDENTITY(1,1) PRIMARY KEY,
    RegionName NVARCHAR(100) NOT NULL,
    
    -- Clé étrangère
    CountryID INT NOT NULL,

    FOREIGN KEY (CountryID) REFERENCES Country(CountryID)
);