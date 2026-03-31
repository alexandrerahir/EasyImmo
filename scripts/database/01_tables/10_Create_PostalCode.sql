/*******************************************************************************
Projet      : EasyImmo
Fichier     : 10_Create_PostalCode.sql
Description : Création de la table PostalCode (codes postaux)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

CREATE TABLE PostalCode(
    PostalCodeID INT IDENTITY(1,1) PRIMARY KEY,
    PostalCode NVARCHAR(20) NOT NULL,
    
    -- Clé étrangère
    MunicipalityID INT NOT NULL,

    FOREIGN KEY (MunicipalityID) REFERENCES Municipality(MunicipalityID)
);