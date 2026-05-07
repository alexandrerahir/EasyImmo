/*******************************************************************************
Projet      : EasyImmo
Fichier     : 01_Create_PropertyType.sql
Description : Création de la table PropertyType (types de propriétés)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

CREATE TABLE PropertyType(
    PropertyTypeID INT IDENTITY(1,1) PRIMARY KEY,
    PropertyTypeName NVARCHAR(50) NOT NULL
);