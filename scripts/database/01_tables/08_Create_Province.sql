/*******************************************************************************
Projet      : EasyImmo
Fichier     : 08_Create_Province.sql
Description : Création de la table Province (provinces)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

CREATE TABLE Province(
    ProvinceID INT IDENTITY(1,1) PRIMARY KEY,
    ProvinceName NVARCHAR(100) NOT NULL,
    
    -- Clé étrangère
    RegionID INT NOT NULL,

    FOREIGN KEY (RegionID) REFERENCES Region(RegionID)
);