/*******************************************************************************
Projet      : EasyImmo
Fichier     : 13_Create_Agent.sql
Description : Création de la table Agent (agents immobiliers)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

CREATE TABLE Agent (
    AgentID INT IDENTITY(1,1) PRIMARY KEY,
    FirstNameAgent NVARCHAR(50) NOT NULL,
    LastNameAgent NVARCHAR(50) NOT NULL,
    EmailAgent NVARCHAR(100) NOT NULL,
    PhoneAgent NVARCHAR(20) NOT NULL,
    PasswordAgent NVARCHAR(255) NOT NULL
);