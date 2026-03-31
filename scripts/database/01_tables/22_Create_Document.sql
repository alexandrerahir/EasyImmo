/*******************************************************************************
Projet      : EasyImmo
Fichier     : 22_Create_Document.sql
Description : Création de la table Document (documents liés aux dossiers)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

CREATE TABLE Document (
    DocumentID INT IDENTITY(1,1) PRIMARY KEY,
    DocumentPath NVARCHAR(255) NOT NULL,
    DocumentDate DATETIME NOT NULL,
    DocumentIsSigned BIT NOT NULL,
    DocumentSignatureDate DATETIME NULL,

    -- Clés étrangères
    DocumentTypeID INT NOT NULL,
    FolderID INT NOT NULL,

    FOREIGN KEY (DocumentTypeID) REFERENCES DocumentType(DocumentTypeID),
    FOREIGN KEY (FolderID) REFERENCES Folder(FolderID)
);