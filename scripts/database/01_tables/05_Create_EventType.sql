/*******************************************************************************
Projet      : EasyImmo
Fichier     : 05_Create_EventType.sql
Description : Création de la table EventType (types d'événements)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

CREATE TABLE EventType(
    EventTypeID INT IDENTITY(1,1) PRIMARY KEY,
    EventTypeName NVARCHAR(50) NOT NULL
);