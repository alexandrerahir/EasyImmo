/*******************************************************************************
Projet      : EasyImmo
Fichier     : 10_Seed_PostalCode.sql
Description : Insertion des données dans la table PostalCode (codes postaux)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

INSERT INTO PostalCode (PostalCode, MunicipalityID) VALUES
    -- Codes postaux de la province du Brabant Wallon
    ('1300',    1), -- Wavre
    ('1400',    2), -- Nivelles
    ('1420',    3), -- Braine-l'Alleud
    ('1340',    4), -- Ottignies-Louvain-la-Neuve

    -- Codes postaux de la province du Hainaut
    ('7000',    5), -- Mons  
    ('6000',    6), -- Charleroi
    ('7500',    7), -- Tournai
    ('7100',    8), -- La Louvière

    -- Codes postaux de la province de Liège
    ('4000',    9), -- Liège
    ('4800',    10), -- Verviers
    ('4500',    11), -- Huy
    ('4100',    12), -- Seraing

    -- Codes postaux de la province de Luxembourg
    ('6700',    13), -- Arlon
    ('6600',    14), -- Bastogne
    ('6760',    15), -- Virton
    ('6900',    16), -- Marche-en-Famenne

    -- Codes postaux de la province de Namur
    ('5000',    17), -- Namur
    ('5500',    18), -- Dinant
    ('5030',    19), -- Gembloux
    ('5660',    20), -- Couvin

    -- Codes postaux de la région de Bruxelles-Capitale
    ('1000',    21), -- Bruxelles
    ('1070',    22), -- Anderlecht
    ('1030',    23), -- Schaerbeek
    ('1050',    24), -- Ixelles

    -- Codes postaux de la province d'Anvers
    ('2000',    25), -- Anvers
    ('2800',    26), -- Mechelen
    ('2300',    27), -- Turnhout
    ('2500',    28), -- Lier

    -- Codes postaux de la province du Brabant Flamand
    ('3000',    29), -- Leuven
    ('1800',    30), -- Vilvorde
    ('1500',    31), -- Halle
    ('3300',    32), -- Tienen

    -- Codes postaux de la province de Flandre-Occidentale
    ('8000',    33), -- Bruges
    ('8500',    34), -- Kortrijk
    ('8400',    35), -- Ostende
    ('8800',    36), -- Roeselare

    -- Codes postaux de la province de Flandre-Orientale
    ('9000',    37), -- Gand
    ('9300',    38), -- Alost
    ('9900',    39), -- Eeklo
    ('9620',    40), -- Zottegem

    -- Codes postaux de la province du Limbourg
    ('3500',    41), -- Hasselt
    ('3600',    42), -- Genk
    ('3700',    43), -- Tongres
    ('3680',    44); -- Maaseik