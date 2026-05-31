/*******************************************************************************
Projet      : EasyImmo
Fichier     : 16_Seed_Property.sql
Description : Insertion des données dans la table Property (biens immobiliers)
Auteur      : Alexandre Rahir
Date        : 31-03-2026
*******************************************************************************/

INSERT INTO Property (PropertyTitle, PropertyDescription, PersonID, PropertyTypeID, AddressID) VALUES
    ('Studio centre Wavre', 'Petit studio idéal pour étudiant, proche des transports.', 1, 4, 1),
    ('Garage Wavre', 'Garage fermé sécurisé avec électricité.', 1, 5, 1),
    ('Maison familiale Charleroi', 'Spacieuse maison 4 chambres avec jardin, proche écoles.', 2, 2, 2),
    ('Appartement Liège centre', 'Bel appartement 3 pièces avec balcon vue sur la Meuse.', 3, 1, 3),
    ('Studio Liège', 'Studio rénové proche de l université de Liège.', 3, 4, 3),
    ('Terrain Liège', 'Terrain constructible de 800m² en zone résidentielle.', 3, 6, 3),
    ('Garage Liège', 'Double garage avec atelier, électricité et eau courante.', 3, 5, 3),
    ('Villa Arlon', 'Magnifique villa avec piscine et grand jardin paysager.', 5, 3, 5),
    ('Terrain Arlon', 'Terrain boisé de 1500m² en lisière de forêt.', 5, 6, 5),
    ('Appartement Namur', 'Appartement lumineux 2 chambres avec terrasse.', 7, 1, 4),
    ('Studio Namur', 'Studio meublé équipé, disponible immédiatement.', 7, 4, 4),
    ('Maison Namur', 'Maison de ville 3 chambres avec cour intérieure.', 7, 2, 4),
    ('Appartement Wavre', 'Appartement 3 pièces rénové avec parking souterrain.', 8, 1, 1),
    ('Villa Liège', 'Villa contemporaine avec domotique intégrée et piscine.', 10, 3, 3),
    ('Garage Liège', 'Box fermé en sous-sol, accès sécurisé par badge.', 10, 5, 3),
    ('Maison Arlon', 'Charmante maison de campagne entourée de verdure.', 12, 2, 5),
    ('Studio Arlon', 'Studio cosy proche des commodités et transports.', 12, 4, 5),
    ('Terrain Arlon', 'Terrain agricole de 2 hectares, idéal pour exploitation.', 12, 6, 5),
    ('Appartement Wavre', 'Grand appartement familial 5 pièces avec cave.', 13, 1, 1),
    ('Villa Liège', 'Villa traditionnelle 4 chambres avec grand jardin.', 15, 3, 3),
    ('Appartement Liège', 'Appartement duplex avec mezzanine et terrasse.', 15, 1, 3),
    ('Maison Arlon', 'Maison plain-pied accessible PMR, 3 chambres et jardin.', 17, 2, 5),
    ('Appartement Wavre', 'Appartement calme 3 pièces avec parking privatif.', 18, 1, 1),
    ('Studio Wavre', 'Studio neuf dans résidence moderne avec ascenseur.', 18, 4, 1),
    ('Garage Wavre', 'Garage avec atelier aménagé, électricité et eau.', 18, 5, 1),
    ('Villa Charleroi', 'Villa luxueuse 5 chambres, spa et garage double.', 20, 3, 2),
    ('Terrain Charleroi', 'Grand terrain de 3000m² avec accès route principale.', 20, 6, 2),
    ('Maison Arlon', 'Maison avec bureau indépendant, idéal pour télétravail.', 22, 2, 5),
    ('Appartement Charleroi', 'Appartement investissement déjà loué, rendement 5%.', 24, 1, 2),
    ('Studio Charleroi', 'Studio lumineux grande fenêtre, coin nuit séparé.', 24, 4, 2),
    ('Garage Charleroi', 'Double garage porte électrique pour deux voitures.', 24, 5, 2),
    ('Terrain Charleroi', 'Terrain viabilisé 600m², prêt à construire.', 24, 6, 2),
    ('Villa Liège', 'Villa provençale avec oliviers et piscine naturelle.', 25, 3, 3),
    ('Maison Arlon', 'Grande maison avec gîte indépendant, revenus locatifs.', 27, 2, 5),
    ('Appartement Arlon', 'Appartement 3 pièces dans résidence calme avec parking.', 27, 1, 5),
    ('Studio Charleroi', 'Studio entièrement meublé équipé, disponible immédiatement.', 29, 4, 2),
    ('Villa Liège', 'Villa bord de Meuse avec ponton privé et vue exceptionnelle.', 30, 3, 3),
    ('Appartement Liège', 'Appartement spacieux 4 chambres deux salles de bain.', 30, 1, 3),
    ('Garage Liège', 'Box de stockage sécurisé 20m², accessible 24h/24.', 30, 5, 3),
    ('Maison Arlon', 'Maison rénovée avec matériaux de qualité, 4 chambres.', 32, 2, 5),
    ('Terrain Arlon', 'Terrain plat 1000m² en zone résidentielle viabilisé.', 32, 6, 5),
    ('Appartement Charleroi', 'Appartement avec vue dégagée, 2 chambres et terrasse.', 34, 1, 2),
    ('Villa Namur', 'Villa avec court de tennis et piscine chauffée.', 36, 3, 4),
    ('Studio Namur', 'Studio étudiant proche universités et commodités.', 36, 4, 4);