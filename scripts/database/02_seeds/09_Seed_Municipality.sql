/*******************************************************************************
Projet      : EasyImmo
Fichier     : 09_Seed_Municipality.sql
Description : Insertion des données dans la table Municipality (communes)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

INSERT INTO Municipality (MunicipalityName, ProvinceID) VALUES
    ('Wavre',                       1), 
    ('Nivelles',                    1), 
    ('Braine-l''Alleud',            1), 
    ('Ottignies-Louvain-la-Neuve',  1),

    -- Communes de la province de Hainaut
    ('Mons',                        2), 
    ('Charleroi',                   2), 
    ('Tournai',                     2), 
    ('La Louvière',                 2),

    -- Communes de la province de Liège
    ('Liège',                       3), 
    ('Verviers',                    3),
    ('Huy',                         3), 
    ('Seraing',                     3),

    -- Communes de la province de Luxembourg
    ('Arlon',                       4), 
    ('Bastogne',                    4), 
    ('Virton',                      4), 
    ('Marche-en-Famenne',           4),

    -- Communes de la province de Namur
    ('Namur',                       5), 
    ('Dinant',                      5), 
    ('Gembloux',                    5), 
    ('Couvin',                      5),

    -- Communes de la région de Bruxelles-Capitale
    ('Bruxelles',                   6), 
    ('Anderlecht',                  6), 
    ('Schaerbeek',                  6), 
    ('Ixelles',                     6),

    -- Communes de la province d''Anvers
    ('Anvers',                      7), 
    ('Mechelen',                    7), 
    ('Turnhout',                    7), 
    ('Lier',                        7),

    -- Communes de la province de Brabant Flamand
    ('Leuven',                      8), 
    ('Vilvorde',                    8), 
    ('Halle',                       8), 
    ('Tienen',                      8),

    -- Communes de la province de Flandre-Occidentale
    ('Bruges',                      9), 
    ('Kortrijk',                    9), 
    ('Ostende',                     9), 
    ('Roeselare',                   9),

    -- Communes de la province de Flandre-Orientale
    ('Gand',                        10), 
    ('Alost',                       10), 
    ('Eeklo',                       10), 
    ('Zottegem',                    10),

    -- Communes de la province de Limbourg
    ('Hasselt',                     11), 
    ('Genk',                        11), 
    ('Tongres',                     11), 
    ('Maaseik',                     11);