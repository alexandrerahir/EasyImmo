/*******************************************************************************
Projet      : EasyImmo
Fichier     : 19_Create_Listing.sql
Description : Création de la table Listing (annonces immobilières)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

CREATE TABLE Listing (
    ListingID INT IDENTITY(1,1) PRIMARY KEY,
    ListingStartDate DATETIME NOT NULL,
    ListingEndDate DATETIME NULL,
    ListingPrice FLOAT NOT NULL,
    AgencyFees FLOAT NULL,
    NotaryFees FLOAT NULL,
    RentalCharge FLOAT NULL,
    RentalWarranty FLOAT NULL,

    -- Clés étrangères
    ListingTypeID INT NOT NULL,
    PropertyID INT NOT NULL,
    AgentID INT NOT NULL,

    FOREIGN KEY (PropertyID) REFERENCES Property(PropertyID),
    FOREIGN KEY (ListingTypeID) REFERENCES ListingType(ListingTypeID),
    FOREIGN KEY (AgentID) REFERENCES Agent(AgentID)
);
