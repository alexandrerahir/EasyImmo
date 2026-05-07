/*******************************************************************************
Projet      : EasyImmo
Fichier     : 20_Create_Folder.sql
Description : Création de la table Folder (dossiers)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

CREATE TABLE Folder (
    FolderID INT IDENTITY(1,1) PRIMARY KEY,
    FolderOpenDate DATETIME NOT NULL,
    FolderCloseDate DATETIME NULL,
    FolderCloseReason NVARCHAR(255) NULL,

    -- Clés étrangères
    ListingID INT NOT NULL,
    PersonID INT NOT NULL,

    FOREIGN KEY (ListingID) REFERENCES Listing(ListingID),
    FOREIGN KEY (PersonID) REFERENCES Person(PersonID)
);