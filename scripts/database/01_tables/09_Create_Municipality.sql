/*******************************************************************************
Projet      : EasyImmo
Fichier     : 09_Create_Municipality.sql
Description : Création de la table Municipality (communes)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

CREATE TABLE Municipality(
    MunicipalityID INT IDENTITY(1,1) PRIMARY KEY,
    MunicipalityName NVARCHAR(100) NOT NULL,
    
    -- Clé étrangère
    ProvinceID INT NOT NULL,

    FOREIGN KEY (ProvinceID) REFERENCES Province(ProvinceID)
);