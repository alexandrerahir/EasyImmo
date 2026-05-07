/*******************************************************************************
Projet      : EasyImmo
Fichier     : 11_Create_Street.sql
Description : Création de la table Street (rues)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

CREATE TABLE Street (
    StreetID INT IDENTITY(1,1) PRIMARY KEY,
    StreetName NVARCHAR(100) NOT NULL,
    
    -- Clé étrangère
    PostalCodeID INT NOT NULL,

    FOREIGN KEY (PostalCodeID) REFERENCES PostalCode(PostalCodeID)
);