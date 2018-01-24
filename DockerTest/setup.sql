GO
USE master;
GO
CREATE TABLE Sets (Id int NOT NULL, SetName nvarchar(max), PRIMARY KEY (Id));
Go
CREATE TABLE Rarity (Id int NOT NULL, Name nvarchar(max), PRIMARY KEY(Id));
Go
CREATE TABLE Cards (Id int NOT NULL, Name nvarchar(max), ManaCost int, Attack int, Health int, RarityId int, SetsId int
PRIMARY KEY (Id),
FOREIGN KEY (RarityId) REFERENCES Rarity(Id),
FOREIGN KEY (SetsId) REFERENCES Sets(Id));
GO

INSERT INTO Rarity VALUES (1, 'Free');
INSERT INTO Rarity VALUES (2, 'Common');
INSERT INTO Rarity VALUES (3, 'Rare');
INSERT INTO Rarity VALUES (4, 'Epic');
INSERT INTO Rarity VALUES (5, 'Legendary');

INSERT INTO Sets VALUES (1, 'Basic');
INSERT INTO Sets VALUES (2, 'Classic');
INSERT INTO Sets VALUES (3, 'Hall of Fame');
INSERT INTO Sets VALUES (4, 'Curse of Naxxramas');
INSERT INTO Sets VALUES (5, 'Goblins vs Gnomes');
INSERT INTO Sets VALUES (6, 'Blackrock Mountain');
INSERT INTO Sets VALUES (7, 'The Grand Tournament');
INSERT INTO Sets VALUES (8, 'League of Explorers');
INSERT INTO Sets VALUES (9, 'Whispers of the Old Gods');
INSERT INTO Sets VALUES (10, 'One Night in Karazhan');
INSERT INTO Sets VALUES (11, 'Mean Streets of Gadgetzan');
INSERT INTO Sets VALUES (12, 'Journey to UnGoro');
INSERT INTO Sets VALUES (13, 'Knights of the Frozen Throne');
INSERT INTO Sets VALUES (14, 'Kobolds and Catacombs');

INSERT INTO Cards VALUES (1, 'Ragnaros the Firelord', 8, 8, 8, 5, 3);
INSERT INTO Cards VALUES (2, 'Call of the Wild', 9, null, null, 4, 11);
INSERT INTO Cards VALUES (3, 'Corridor Creeper', 7, 5, 5, 4, 14);
