/*******************************************************************************
Projet      : EasyImmo
Fichier     : 04_Seed_DocumentType.sql
Description : Insertion de données dans la table DocumentType (types de documents)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

INSERT INTO DocumentType (DocumentTypeName) VALUES
    -- Types de documents courants
    ('Contrat de bail'),
    ('Compromis de vente'),
    ('Acte notarié'),
    ('Etat des lieux'),
    ('Garantie locative'),

    -- Types de documents administratifs
    ('Pièce d''identité'),
    ('Justificatif de domicile'),
    ('Attestation de revenus'),
    ('Relevé bancaire');