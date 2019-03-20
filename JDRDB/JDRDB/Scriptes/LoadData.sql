
--/*
--Modèle de script de post-déploiement							
----------------------------------------------------------------------------------------
-- Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
-- Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
-- Exemple :      :r .\monfichier.sql								
-- Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
-- Exemple :      :setvar TableName MyTable							
--               SELECT * FROM [$(TableName)]					
----------------------------------------------------------------------------------------
--*/


insert into Province values
('Cyrodiil'), 
('Bordeciel'), 
('Morrowind'), 
('Marais Noir'), 
('Elsweyr'), 
('Valboisé'), 
('Achipelle de l''automne'), 
('Lenclume'), 
('Hauteroche')

insert into Lieu values
('Foret'),
('Egout'),
('Grotte'),
('Plaine'),
('Crypte'),
('Désert')

insert into Rang values
('E'),('D'),('C'),('B'),('A'),('S')

insert into Ame values
('Inférieure'),('Commune'),('Supérieur'),('Magistrale'),('Noire')

insert into ClasseStat values
('Caracteristique'),('Guerrier'),('Voleur'),('Mage')

insert into Stat values
('Sante',1),
('Vigeur',1), 
('Magie',1),
('RegenSante',1),
('RegenVigeur',1),
--5
('RegenMagie',1),
('Force',1),
('Intelligence',1),
('Volonté',1),
('Agilité',1),
--10
('Rapidité',1),
('Endurence',1),
('Personnalité',1),
('Perception',1),
('Niveau',1),
--15
('Point de destins',1),
('Point de fortune',1),
('Forgeage',2),
('Armure Lourde',2),
('Blocage',2),
--20
('Deux Mains',2),
('Une Main',2),
('Distance',2),
('Armure Légère',3),
('Furtivité',3),
--25
('Crochetage',3),
('Vol',3),
('Eloquence',3),
('Alchimie',3),
('Illusion',4),
--30
('Conjuration',4),
('Destruction',4),
('Guérison',4),
('Altération',4),
('Enchantement',4),
--35
('Septimes',1),
('Encombrement',1),
('Vivres',1),
('Attaque',1),
('Défense',1),
--40
('Réflexe',1),
('Dégats',1),
('Prix',1)

insert into Signe values
('Le Guerrier','2x +5 dans Guerrier'),
('La Dame','Récupértion de vigeur +50% et santé +10%'),
('Le Destrier','Capacité de chargement +50% et l''armure équipée n''est plus prises en compte'),
('Le Seigneur','Dégats reçus -25%'),

('Le Voleur','2x +5 dans Voleur'),
('Le Serpent','Peut enduire une arme d''un poison paralysant x1 par jour'),
('La Tour','Peut ouvrir n''importe quel verrou x1 par jour '),
('L''Ombre','Peut devenir invisible pendant 5 minutes 1x par jour'),

('Le Mage','2x+5 dans Mage'),
('L''Apprenti','Récupération de magie +50% mais dégat magie reçue +50%'),
('L''Atronach','20% des dégats reçus sont convertis en magie récupérée, magie +50% mais récupération de magie -50%'),
('Le Rituel','peut réanimer un cadavre pandant 30 minutes 1x par jour'),

('L''Amant','Point de fortune +1')

insert into RangMagie values
('Novice'), ('Apprenti'), ('Adepte'), ('Expert'), ('Maître')

insert into EcoleMagie values
('Destruction'), ('Conjuration'), ('Guérison'), ('Atlération'), ('Illusion') 

insert into Resistence values
('Feu : 50%'), 
('Feu : Immunité'), 
('Froid : 50%'), 
('Froid : Immunité'), 
('Foudre : 50%'), 
--5
('Foudre : Immunité'), 
('Magie : 50%'), 
('Blessure : 50%'),
('Infections : 50%'),
('Maladie : Immunité'),
--10
('Poison : Immunité')

--insert into Faiblesse values  --A ajouter si possible
--('Feu'), 
--('Froid'), 
--('Foudre'), 
--('Magie'), 
--('Infections'),
--('Maladie'),
--('Poison')

insert into Capacite values
('Voix de l''empire', 'Calme les ennemis plus faible en parlant'),
('Chance impérial', 'Or trouver +10%'),
('Adrénaline', 'Régénération vie en combat +10, 1x par jour'),
('Vivant dans le froid', 'Résistance au froid'),
('Jamais fatigué', 'Régénération vigueur +3'),
--5
('Mangeur de scorpion', 'Ne peut être empoisonné'),
('Peau de dragon','20% des dégats reçus sont convertis en magie récupérée'),
('Sang hybride','Résistance à la magie +50%'),
('Magie des  mers','Régénération magie +3'),
('Sang de mer','Résistance aux infections'),
--10
('Ami de la nature','Peut dompter un animal plus faible et en faire un familier'),
('Imprévisible','Point de fortune +1'),
('Vivant dans les cendres','Résistance au feu'),
('Cri de guerre','Fait peur aux ennemis plus faible'),
('Peuple de guerrier','Résistance aux blessures'),
--15
('Amphibie','Respire sous l''eau'),
('Habitant des marais','Ne peut être malade'),
('Nyctalopie','Voit dans le noir'),
('Griffes rétractables','Dégâts main nue x2'),
('Crache des flammes','10 dégats de feu a distence'),
--20
('Venin','Empoisonne'),
('Ligottage','Emprisonne et étrangle'),
('Venin paralysant','Paralyse la cible (poison)'),
('Régénération','Régénère 10 de santé par tour'),
('Dragon de Feu','Vol et crache des flammes'),
--25
('Dragon de Froid','Vol et crache du froid')


exec AjouterRace 'Impériale',1,null,1,2,8,8,6,6,8,8,10,0,8,8,0,8,0,0,0,0,0,0,0,0,0,8,12,0,8,10
exec AjouterRace 'Nordique',2,3,3,4,6,8,8,8,8,6,10,8,0,8,12,8,0,8,0,0,0,8,0,0,0,0,0,0,0,10
exec AjouterRace 'Rougegarde',8,11,5,6,8,6,6,8,8,10,8,10,8,0,8,0,12,8,0,0,0,0,0,0,0,0,8,0,8,0
exec AjouterRace 'Breton',9,7,7,8,10,6,10,6,6,10,6,8,8,12,8,8,8,0,0,0,0,0,0,0,0,0,0,0,0,8
exec AjouterRace 'Haut-Elfe',7,9,9,10,8,10,10,6,6,6,8,10,0,0,0,0,0,0,0,0,0,0,8,8,8,12,0,8,8,0
exec AjouterRace 'Elfe des bois',6,9,11,10,6,10,8,8,8,6,8,15,0,0,0,0,0,0,0,0,0,0,0,0,12,8,8,8,8,8
exec AjouterRace 'Elfe Noir',3,1,12,13,6,10,6,10,10,6,8,14,0,0,0,0,0,12,8,8,8,8,0,8,0,0,0,0,0,0
exec AjouterRace 'Orque',9,8,14,15,8,8,6,8,10,6,8,13,0,0,0,0,0,0,8,8,0,0,0,8,8,0,12,0,8,0
exec AjouterRace 'Argonien',4,10,16,17,8,10,8,8,8,6,6,14,0,0,0,0,0,0,8,8,12,8,0,0,0,0,0,8,8,0
exec AjouterRace 'Khajiit',5,null,18,19,8,8,6,10,8,6,8,16,0,0,0,0,8,8,0,12,8,8,0,8,0,0,0,0,0,0


insert into ClassePNJ values 
('Bandit (Lourd)'),
('Bandit (Léger)'),
('Sorcier')


exec AjouterMatiere 'Tissu', 0,0,1,0,0,0
exec AjouterMatiere 'Bois', 1,0,0,1,1,1
exec AjouterMatiere 'Os', 1,0,1,1,1,1
exec AjouterMatiere 'Peau', 0, 0, 1,1,1,1
exec AjouterMatiere 'Cuir', 0, 0, 1,2,2,2
exec AjouterMatiere 'Fer', 1, 1, 0,3,3,3
--('Corrindon', 1, 1, 0),
--('Acier', 1, 1, 0),
--('Argent', 1, 1, 0),
--('Or', 1, 1, 0),
--('Dwemer', 1, 1, 0),
--('Orichalque', 1, 1, 0),
--('Mithril', 1, 0, 1),
--('Vif-Argent', 1, 1, 0),
--('Pierre de Lune', 1, 0, 1),
--('Malachite', 1, 0, 1),
--('Ebonite', 1, 1, 0),
--('Daedra', 1, 1, 0),
--('Ecaille de Dragon', 0, 0, 1),
--('Os de Dragon', 1, 1, 0)

insert into TypeArme values
('Lame'),
('Outil'),
('Contendant'),
('Distance')

exec AjouterStyle 'Basique', default;
exec AjouterStyle 'Impérial', default;

exec AjouterArme 'Epée', 0, 0, 1, 5, 5, 40
exec AjouterArme 'Hache d''arme', 5, 1, 2, 10 ,10 ,80

exec AjouterArmure 'Plastron', 5, 7, 70
exec AjouterArmure 'Casque',2,3,25
exec AjouterArmure 'Bottes',1,2,15
exec AjouterArmure 'Jambières',4,7,70
exec AjouterArmure 'Brassards',1,2,15
exec AjouterArmure 'Bouclier',4,5,30

Exec AjouterClasse 'Guerrier', 1,0,0,0,0,1,0 ,10,10,10,10,10,10, 0,0,0,0,0,0, 0,0,0,0,0,0
Exec AjouterClasse 'Voleur', 0,1,1,0,0,0,0, 0,0,0,0,0,0, 10,10,10,10,10,10, 0,0,0,0,0,0 
Exec AjouterClasse 'Mage', 0,0,0,1,1,0,0, 0,0,0,0,0,0, 0,0,0,0,0,0, 10,10,10,10,10,10

Exec AjouterEnchantement 'Enflammer', 'Ajoute 10 dégats de feu',200,10

Exec AjouterMagie 'Flamme','Inflige 15 dégats de feu',1,1,15,100;

Exec AjouterMonstre 'Ragnar',1,1,null,null,25,15,2,2,15
Exec AjouterMonstre 'Cafard Assain',1,1,null,null,25,15,2,2,15

Exec AjouterObjet 'Potion de soin',1,15,'Restaure 50 de santé'

Exec AjouterPNJ 1,1,1,3,80,7,3

Exec AjouterEquipement 1,null,6,1,null
Exec AjouterEquipement null,1,4,2,null

insert into [PNJ-Equipement] values (1,1)
insert into [PNJ-Equipement] values (1,2)

Exec AjouterPJ 'Toto le brave',1,1,1,1,4
Exec AjouterEquipementPJ 1,1
Exec AjouterEquipementPJ 1,2
exec AjouterMagiePJ 1,1
Exec AjouterObjetPJ 1,1

insert into Roles values ('Admin'),('User'),('MJ'),('Joueur')

--Exec AjouterUtilisateur 'Bouillot','Alex','AlexBou','븫䠌᪹᭽枊ꡓ쮹�렖祃麟戕萒竟燍뻩ູᒦ뷇䊒꩐䒞虪╧藦嶦퇵ꔹᣍ줍','alexbouillot@hotmail.com' 
--mdp = test1234
--Exec AjouterUtilisateur 'Dhondt','Laurent','Lolo','䳁캻꾮듽皛槒檋혡﮴㫋ᘩ唌冕慂傖撼錘ߠ頠뫓‥섾맡ｪ얒恠᲎А','lolo@gmail.com'
--mdp = mdp1234

--insert into Role_Utilisateur values (1,1)
--insert into PJ_User (Id_PJ,Id_User) values (1,1)