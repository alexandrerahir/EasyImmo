/*******************************************************************************
Projet      : EasyImmo
Fichier     : 16_Create_Property.sql
Description : Création de la table Property (biens immobiliers)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

CREATE TABLE Property (
    PropertyID INT IDENTITY(1,1) PRIMARY KEY,
    PropertyTitle NVARCHAR(255) NOT NULL,
    PropertyDescription NVARCHAR(MAX) NULL,

    -- Clés étrangères
    PersonID INT NOT NULL,
    PropertyTypeID INT NOT NULL,
    AddressID INT NOT NULL,

    FOREIGN KEY (PersonID) REFERENCES Person(PersonID),
    FOREIGN KEY (PropertyTypeID) REFERENCES PropertyType(PropertyTypeID),
    FOREIGN KEY (AddressID) REFERENCES Address(AddressID)
);