/*******************************************************************************
Projet      : EasyImmo
Fichier     : 18_Create_Photo.sql
Description : Création de la table Photo (photos des biens)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

CREATE TABLE Photo (
    PhotoID INT IDENTITY(1,1) PRIMARY KEY,
    PhotoURL NVARCHAR(255) NOT NULL,

    -- Clé étrangère
    PropertyID INT NOT NULL,

    FOREIGN KEY (PropertyID) REFERENCES Property(PropertyID)
);