/*******************************************************************************
Projet      : EasyImmo
Fichier     : 02_Create_ListingType.sql
Description : Création de la table ListingType (types d'annonces)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

CREATE TABLE ListingType(
    ListingTypeID INT IDENTITY(1,1) PRIMARY KEY,
    ListingTypeName NVARCHAR(50) NOT NULL
);
