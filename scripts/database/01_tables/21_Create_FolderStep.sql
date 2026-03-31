/*******************************************************************************
Projet      : EasyImmo
Fichier     : 21_Create_FolderStep.sql
Description : Création de la table FolderStep (étapes des dossiers)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

CREATE TABLE FolderStep (
    FolderStepID INT IDENTITY(1,1) PRIMARY KEY,
    FolderStepDate DATETIME NOT NULL,
    FolderStepNote NVARCHAR(255) NULL,

    -- Clés étrangères
    FolderID INT NOT NULL,
    StepTypeID INT NOT NULL,

    FOREIGN KEY (FolderID) REFERENCES Folder(FolderID),
    FOREIGN KEY (StepTypeID) REFERENCES StepType(StepTypeID)
);