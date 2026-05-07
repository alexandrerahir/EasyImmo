/*******************************************************************************
Projet      : EasyImmo
Fichier     : 03_Seed_StepType.sql
Description : Insertion de données dans la table StepType (types d'étapes)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

INSERT INTO StepType (StepTypeName) VALUES
    -- Étapes initiales
    ('Demande de renseignements'),
    ('Visite planifiée'),
    ('Visite effectuée'),

    -- Étapes de négociation
    ('Offre déposée'),
    ('Offre refusée'),
    ('Contre-offre déposée'),
    ('Offre acceptée'),

    -- Étapes administratives
    ('Documents demandés'),
    ('Documents reçus'),
    ('Dossier complet'),

    -- Étapes de légales (vente)
    ('Compromis envoyé'),
    ('Compromis signé'),
    ('Acte notarié envoyé'),
    ('Acte notarié signé'),

    -- Étapes de légales (location)
    ('Bail envoyé'),
    ('Bail signé'),
    ('Etat des lieux planifié'),
    ('Etat des lieux effectué'),

    -- Étapes financières (vente)
    ('Paiement reçu'),

    -- Étapes financières (location)
    ('Garentie locative reçue'),
    ('Premier mois de loyer reçu'),

    -- Étapes finales
    ('Remise des clés planifiée'),
    ('Remise des clés effectuée');