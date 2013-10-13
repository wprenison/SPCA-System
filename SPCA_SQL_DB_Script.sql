
IF OBJECT_ID('dbo.tblGarduians', 'U') IS NOT NULL DROP TABLE tblGarduians;
IF OBJECT_ID('dbo.tblAnimals', 'U') IS NOT NULL DROP TABLE tblAnimals;
IF OBJECT_ID('dbo.tblProceureOp', 'U') IS NOT NULL DROP TABLE tblProcedureOp;
IF OBJECT_ID('dbo.tblProcedures', 'U') IS NOT NULL DROP TABLE tblProcedures;
IF OBJECT_ID('dbo.tblVets', 'U') IS NOT NULL DROP TABLE tblVets;

CREATE TABLE tblGuardians
(
GarduianID int IDENTITY(1,1) PRIMARY KEY,
FirstName varchar(20),
LastName varchar(30),
DateOfBirth date,
Tel int,
ResAddress varchar(100)
)

INSERT INTO tblGuardians (FirstName, LastName, DateOfBirth, Tel, ResAddress)
VALUES('Ashleigh', 'Croucher', '19900918', '0782647507', '804 Dockside Aparments, Mechau St, De Waterkant, Cape Town, 8001'),
('Weylin', 'Renison', '19891107', '0810213161', '37 The Palms, Hadley St, Oak Glen, 7563'),
('Daniel', 'Tromp', '19910604', '0844100839', '21 Queen Victoria Rd, Rondebosch, 8257'),
('Byron', 'Coetsee', '19900721', '0832335962', '45 Kengsington Rd, Silvermine Estate, Tokia, 7750'),
('Tyler', 'Doye', '19930314', '0762541567', '89 Buitengracht Rd, Cape Town, 8001')

CREATE TABLE tblProcedures
(
ProcedureID int IDENTITY(1,1),
Name varchar(20),
ProcedureDescription varchar(100)
)

INSERT INTO tblProcedures (Name, ProcedureDescription)
VALUES ('Amputation', 'Removal of a limb'),
('Nueter', 'Removal of uteris or testies'),
('Twisted Stomach', 'Turning stomach around'),
('Tumour remaval', 'Removal of tumour affeted areas'),
('Truama', 'Broken bones, stiches, repairing internal injuries'),
('Object Removal', 'Removal of object in the stomach'),
('Vacinations', 'Rabies, tenis, ect injections'),
('Lethal Injection', 'Puting animal down, only to be performed if animal is in suffering conditions')

CREATE TABLE tblAnimals
(
AnimalID int IDENTITY(1,1),
Name varchar(20),
Species varchar(20),
Breed varchar(20),
DateRecieved date,
Illnesses varchar(50),
Injuries varchar(50),
Notes varchar(100),
RoomNo int,
Neutered bit,
EstimatedAge int,
AgroRating int
)

--AgroRating on a scale pf 0 - 5
-- No agro = 0
-- agro towards other animals = 1 ro 2
-- agro towards people = 3 or 4
-- agro towards everyone = 5

INSERT INTO tblAnimals (Name, Species, Breed, DateRecieved, Illnesses, Injuries, Notes, RoomNo, Neutered, EstimatedAge, AgroRating)
VALUES ('Cloe', 'Canine', 'Dushond', '20131012', null, 'Broken Leg', null, 105, 1,3,0),
('Rocket', 'Canine', 'Rotviler', '20120517', 'Malnutrition', null,null,207,0,2,2),
('Storm', 'Feline', 'Savana', '20100416', null, null, 'Neutering required', 201, 0,1,0),
('Genna', 'Canine', 'Labradour', '20130517', 'Ear infection', null, 'Drop required hourly', 107, 1, 8, 0),
('Kissy', 'Feline', null, '20130421', 'Tooth abesis', null, 'Not eating, and limping', 104, 1, 13, 0),
('Kitten', 'Feline', 'Tourtise Shell', '20131225', null , 'Burnt and broken bone', 'Vacinations needed', 103,0,3,5),
('Candy', 'Canine', 'Poodle', '20130718', null, 'Snake bite', 'Speacial low carb food', 102,1,5,1),
('Milo', 'Canine', 'Jack Russle', '20130514', null, 'Cuts', null, 231, 0, 3, 5),
('Chanel', 'Canine', 'Labradour', '20120510', 'Cancer', null, 'Leg cancer', 201, 1, 9, 0),
('Pepper', 'Canine', 'Labradour Mix', '20130621', null, null, 'Very cold', 101, 0, 3, 1),
('Charlie', 'Bird', 'Ring Neck', '20130308', null, null, 'Afraid of bags', 103, null, 1, 3),
('Elu', ' Bird', 'Electus', '20130704', null, 'Broken Wing', 106, null, 3, 5),
(('Lumen', 'Bird', 'Ring Neck', 

CREATE TABLE tblProcedureOp
(
ProcedureID int FOREIGN KEY REFERENCES tblProcedures(ProcedureID),
AnimalID int FOREIGN KEY REFERENCES	tblAnimals(AnimalID),
ProcedureOpID int PRIMARY KEY(ProcedureID, AnimalID)
)

CREATE TABLE tblRecievePatient
(
GuardianID int FOREIGN KEY REFERENCES tblGuardian(GuardianID) NOT NULL,
AnimalID int FOREIGN KEY REFERENCES tblAnimals(AnimalID) NOT NULL,
PRIMARY KEY(GuardianID, AnimalID)
)

CREATE TABLE tblVets
(
VetID int IDENTITY(1,1),
FirstName varchar(20),
LastName varchar(30),
DateOfBirth date,
Tel int,
ResAddress varchar(50),
Qualification varchar(30)
)