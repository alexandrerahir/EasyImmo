/*******************************************************************************
Projet      : EasyImmo
Fichier     : 24_Create_FolderEvent.sql
Description : Création de la table FolderEvent (association entre les dossiers et les événements)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

CREATE TABLE FolderEvent (
    FolderEventID INT IDENTITY(1,1) PRIMARY KEY,

    -- Clés étrangères
    FolderID INT NOT NULL,
    EventID INT NOT NULL,

    FOREIGN KEY (FolderID) REFERENCES Folder(FolderID),
    FOREIGN KEY (EventID) REFERENCES Event(EventID)
);