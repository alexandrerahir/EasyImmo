/*******************************************************************************
Projet      : EasyImmo
Fichier     : 05_Seed_EventType.sql
Description : Insertion de données dans la table EventType (types d'événements)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

INSERT INTO EventType (EventTypeName) VALUES
    -- Visites
    ('Visite planifiée'),
    ('Visite effectuée'),

    -- Contacts
    ('Appel téléphonique'),
    ('Réunion client'),
    ('Réunion équipe'),

    -- Signatures
    ('Signature offre'),
    ('Signature bail'),
    ('Signature de compromis'),
    ('Signature d''acte notarié'),

    -- Administratif
    ('Etat des lieux'),
    ('Remise des clés'),
    ('Rendez-vous notaire');