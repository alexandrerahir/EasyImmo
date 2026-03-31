/*******************************************************************************
Projet      : EasyImmo
Fichier     : 06_Create_Country.sql
Description : Création de la table Country (pays)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

CREATE TABLE Country(
    CountryID INT IDENTITY(1,1) PRIMARY KEY,
    CountryName NVARCHAR(100) NOT NULL,
    IsoCode NVARCHAR(10) NOT NULL
);