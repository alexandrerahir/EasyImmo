/*
==============================================================================
Description : Script de création de la base de données EasyImmo
Auteur : Alexandre Rahir
Version : 1.0.0
==============================================================================
*/


USE EasyImmo;

-- =============================================
-- 1. CREATION DES TABLES
-- =============================================

-- Table TypePropriete
CREATE TABLE TypePropriete (
    TypeProprieteID			INT IDENTITY(1,1) PRIMARY KEY,
    LibelleTypePropriete	NVARCHAR(100) NOT NULL
);

-- Table Personne
CREATE TABLE Personne (
	PersonneID				INT IDENTITY(1,1) PRIMARY KEY,
	PrenomPersonne			NVARCHAR(100) NOT NULL,
	NomPersonne				NVARCHAR(100) NOT NULL,
	EmailPersonne			NVARCHAR(100) NOT NULL UNIQUE,
	NumeroPersonne			NVARCHAR(20) NOT NULL UNIQUE,
	AdressePersonne			NVARCHAR(255) NOT NULL
);

-- Table Agent
CREATE TABLE Agent (
	AgentID					INT IDENTITY(1,1) PRIMARY KEY,
	PrenomAgent				NVARCHAR(100) NOT NULL,
	NomAgent				NVARCHAR(100) NOT NULL,
	EmailAgent				NVARCHAR(100) NOT NULL UNIQUE,
	NumeroAgent				NVARCHAR(20) NOT NULL UNIQUE,
	MotDePasseAgent			NVARCHAR(50) NOT NULL
);

-- Table TypeEvenement
CREATE TABLE TypeEvenement (
	TypeEvenementID			INT IDENTITY(1,1) PRIMARY KEY,
	LibelleTypeEvenement	NVARCHAR(100) NOT NULL
);

-- Table Propriete
CREATE TABLE Propriete (
    ProprieteID				INT IDENTITY(1,1) PRIMARY KEY,
    TitrePropriete			NVARCHAR(150) NOT NULL,
    DescriptionPropriete	NVARCHAR(255),
    AdressePropriete		NVARCHAR(255) NOT NULL,
    ConsommationEnergie		DECIMAL(6, 2),
    ClasseEnergie			CHAR(1),
    SurfaceHabitable		DECIMAL(10, 2),
    SurfaceTerrain			DECIMAL(10, 2),
    NombrePieces			INT,
    NombreChambres			INT,
    NombreSallesBain		INT,
    Garage					BIT,
    Parking					BIT,
    Jardin					BIT,
    Balcon					BIT,
    Terrasse				BIT,
    EtatBien				NVARCHAR(50),
    AnneeConstruction		DATE,

	PersonneID				INT NOT NULL,
	TypeProprieteID			INT NOT NULL

	-- Clé étrangère
    CONSTRAINT FK_Propriete_Personne 
        FOREIGN KEY (PersonneID) 
        REFERENCES Personne(PersonneID),

	CONSTRAINT FK_Propriete_TypePropriete
		FOREIGN KEY (TypeProprieteID)
		REFERENCES TypePropriete(TypeProprieteID)
);

-- Table Photo
CREATE TABLE Photo (
	PhotoID					INT IDENTITY(1,1) PRIMARY KEY,
	PhotoURL				NVARCHAR(255) NOT NULL UNIQUE,
	EstPrincipale			BIT,

	ProprieteID				INT NOT NULL

	-- Clé étrangère
	CONSTRAINT FK_Photo_Propriete
		FOREIGN KEY (ProprieteID)
		REFERENCES Propriete(ProprieteID)
);

-- Table Dossier
CREATE TABLE Dossier (
	DossierID				INT IDENTITY(1,1) PRIMARY KEY,
	TypeDossier				NVARCHAR(100),
	Prix					DECIMAL(10,2),
	DateDebutDossier		DATE,
	DateFinDossier			DATE,
	StatutDossier			NVARCHAR(50),

	PersonneID				INT,
	AgentID					INT NOT NULL,
	ProprieteID				INT NOT NULL

	-- Clé étrangère
	CONSTRAINT FK_Dossier_Personne
		FOREIGN KEY (PersonneID)
		REFERENCES Personne(PersonneID),

	CONSTRAINT FK_Dossier_Agent
		FOREIGN KEY (AgentID)
		REFERENCES Agent(AgentID),

	CONSTRAINT FK_Dossier_Propriete
		FOREIGN KEY (ProprieteID)
		REFERENCES Propriete(ProprieteID)
);

-- Table Evenement
CREATE TABLE Evenement (
	EvenementID				INT IDENTITY(1,1) PRIMARY KEY,
	TitreEvement			NVARCHAR(100) NOT NULL,
	NotesEvenement			NVARCHAR(MAX),
	DateHeureDebutEvenement DATETIME2,
	DateHeureFinEvenement	DATETIME2,
	StatutEvenement			NVARCHAR(50) NOT NULL,

	PersonneID				INT,
	DossierID				INT,
	TypeEvenementID			INT NOT NULL

	-- Clé étrangère
	CONSTRAINT FK_Evenement_Personne
		FOREIGN KEY (PersonneID)
		REFERENCES Personne(PersonneID),

	CONSTRAINT FK_Evenement_Dossier
		FOREIGN KEY (DossierID)
		REFERENCES Dossier(DossierID),

	CONSTRAINT FK_Evenement_TypeEvenement
		FOREIGN KEY (TypeEvenementID)
		REFERENCES TypeEvenement(TypeEvenementID)
);

-- Table de jointure entre Evenement et Agent
CREATE TABLE EvenementAgent (
	EvenementAgentID		INT IDENTITY(1,1) PRIMARY KEY,
	AgentID					INT,
	EvenementID				INT

	-- Clé étrangère
	CONSTRAINT FK_EvenementAgent_Agent
		FOREIGN KEY (AgentID)
		REFERENCES Agent(AgentID),

	CONSTRAINT FK_EvenementAgent_Evenement
		FOREIGN KEY (EvenementID)
		REFERENCES Evenement(EvenementID)
);



-- =============================================
-- 2. ....
-- =============================================


PRINT 'Création de la base de données EasyImmo terminée avec succès.';