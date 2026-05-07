/*******************************************************************************
Projet      : EasyImmo
Fichier     : 03_Create_StepType.sql
Description : Création de la table StepType (types d'étapes)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

CREATE TABLE StepType(
    StepTypeID INT IDENTITY(1,1) PRIMARY KEY,
    StepTypeName NVARCHAR(50) NOT NULL
);