/*******************************************************************************
Projet      : EasyImmo
Fichier     : 23_Create_AgentEvent.sql
Description : Création de la table AgentEvent (association entre agents et événements)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

CREATE TABLE AgentEvent (
    AgentEventID INT IDENTITY(1,1) PRIMARY KEY,

    -- Clés étrangères
    AgentID INT NOT NULL,
    EventID INT NOT NULL,

    FOREIGN KEY (AgentID) REFERENCES Agent(AgentID),
    FOREIGN KEY (EventID) REFERENCES Event(EventID)
);