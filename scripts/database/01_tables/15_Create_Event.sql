/*******************************************************************************
Projet      : EasyImmo
Fichier     : 15_Create_Event.sql
Description : Création de la table Event (événements)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

CREATE TABLE Event (
    EventID INT IDENTITY(1,1) PRIMARY KEY,
    EventDate DATETIME NOT NULL,
    EventNote NVARCHAR(255) NULL,

    -- Clé étrangère
    EventTypeID INT NOT NULL,

    FOREIGN KEY (EventTypeID) REFERENCES EventType(EventTypeID)
);