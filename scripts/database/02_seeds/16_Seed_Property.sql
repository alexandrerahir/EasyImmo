/*******************************************************************************
Projet      : EasyImmo
Fichier     : 16_Seed_Property.sql
Description : Insertion des données dans la table Property (biens immobiliers)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

INSERT INTO Property (PropertyTitle, PropertyDescription, PersonID, PropertyTypeID, AddressID) VALUES
    ('Appartement lumineux', 'Bel appartement de 3 pièces avec balcon, situé au centre-ville.', 1, 1, 1),
    ('Maison familiale', 'Spacieuse maison de 4 chambres avec jardin, proche des écoles.', 2, 2, 2);