/*******************************************************************************
Projet      : EasyImmo
Fichier     : 04_Create_DocumentType.sql
Description : Création de la table DocumentType (types de documents)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

CREATE TABLE DocumentType(
    DocumentTypeID INT IDENTITY(1,1) PRIMARY KEY,
    DocumentTypeName NVARCHAR(50) NOT NULL
);