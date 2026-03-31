/*******************************************************************************
Projet      : EasyImmo
Fichier     : 14_Create_Person.sql
Description : Création de la table Person (personnes)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

CREATE TABLE Person(
    PersonID INT IDENTITY(1,1) PRIMARY KEY,
    FirstNamePerson NVARCHAR(50) NOT NULL,
    LastNamePerson NVARCHAR(50) NOT NULL,
    EmailPerson NVARCHAR(100) NOT NULL,
    PhonePerson NVARCHAR(20) NOT NULL,

    -- Clé étrangère
    AddressID INT NOT NULL,

    FOREIGN KEY (AddressID) REFERENCES Address(AddressID)
);