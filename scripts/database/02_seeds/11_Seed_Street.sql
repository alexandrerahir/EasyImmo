/*******************************************************************************
Projet      : EasyImmo
Fichier     : 11_Seed_Street.sql
Description : Insertion des données dans la table Street (rues)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

INSERT INTO Street (StreetName, PostalCodeID) VALUES
    -- Rue de la province de Brabant Wallon
    ('Rue de Bruxelles',             1), -- Wavre
    ('Avenue de la Gare',            2), -- Nivelles
    ('Boulevard de l''Europe',       3), -- Braine-l'Alleud
    ('Place du Grand Sablon',        4), -- Ottignies-Louvain-la-Neuve

    -- Rue de la province de Hainaut
    ('Rue de la coupe',              5), -- Mons  
    ('Boulevard Tirou',              6), -- Charleroi
    ('Rue Royal',                    7), -- Tournai
    ('Place de la Louve',            8), -- La Louvière

    -- Rue de la province de Liège
    ('Place Saint-Lambert',          9), -- Liège
    ('Rue des Raines',              10), -- Verviers
    ('Avenue des Ardennes',         11), -- Huy
    ('Rue Cockerill',               12), -- Seraing

    -- Rue de la province de Luxembourg
    ('Rue des Faubourgs',           13), -- Arlon
    ('Rue du Sablon',               14), -- Bastogne
    ('Avenue Bouvier',              15), -- Virton
    ('Rue des Brasseurs',           16), -- Marche-en-Famenne

    -- Rue de la province de Namur
    ('Rue de Fer',                   17), -- Namur
    ('Rue Grande',                   18), -- Dinant
    ('Chaussée de Wavre',            19), -- Gembloux
    ('Rue de la Station',            20), -- Couvin

    -- Rue de la région de Bruxelles-Capitale
    ('Avenue Louise',                21), -- Bruxelles
    ('Rue de l''Abattoir',           22), -- Anderlecht
    ('Avenue Louis Bertrand',        23), -- Schaerbeek
    ('Place du Luxembourg',          24), -- Ixelles

    -- Rue de la province d''Anvers
    ('Meir',                         25), -- Anvers
    ('IJzerenleen',                  26), -- Mechelen
    ('Grote Markt',                  27), -- Turnhout
    ('Antwerpsestraat',              28), -- Lier

    -- Rue de la province de Brabant Flamand
    ('Bondgenotenlaan',              29), -- Leuven
    ('Brusselsesteenweg',            30), -- Vilvorde
    ('Beestenmarkt',                 31), -- Halle
    ('Beauduinstraat',               32), -- Tienen

    -- Rue de la province de Flandre-Occidentale
    ('Steenstraat',                  33), -- Bruges
    ('Korte Steenstraat',            34), -- Kortrijk
    ('Albert I-promenade',           35), -- Ostende
    ('Ooststraat',                   36), -- Roeselare

    -- Rue de la province de Flandre-Orientale
    ('Veldstraat',                   37), -- Gand
    ('Nieuwstraat',                  38), -- Alost
    ('Stationsstraat',               39), -- Eeklo
    ('Heldenlaan',                   40), -- Zottegem

    -- Rue de la province de Limbourg
    ('Koning Albertstraat',          41), -- Hasselt
    ('Stationsstraat',               42), -- Genk
    ('Hemelingenstraat',             43), -- Tongres
    ('Bosstraat',                    44); -- Maaseik