/*******************************************************************************
Projet      : EasyImmo
Fichier     : 12_Create_Address.sql
Description : Description de la table/du script
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

CREATE TABLE Address (
    AddressID INT IDENTITY(1,1) PRIMARY KEY,
    HouseNumber INT NOT NULL,
    BoxNumber NVARCHAR(20) NULL,
    
    -- Clé étrangère
    StreetID INT NOT NULL,

    FOREIGN KEY (StreetID) REFERENCES Street(StreetID)
);