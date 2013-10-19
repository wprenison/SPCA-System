
IF OBJECT_ID('dbo.tblProceureOp', 'U') IS NOT NULL DROP TABLE tblProcedureOp;
IF OBJECT_ID('dbo.tblRecievePatient', 'U') IS NOT NULL DROP TABLE tblRecievePatient;
IF OBJECT_ID('dbo.tblAnimals', 'U') IS NOT NULL DROP TABLE tblAnimals;
IF OBJECT_ID('dbo.tblGuardians', 'U') IS NOT NULL DROP TABLE tblGuardians;
IF OBJECT_ID('dbo.tblProcedures', 'U') IS NOT NULL DROP TABLE tblProcedures;
IF OBJECT_ID('dbo.tblVets', 'U') IS NOT NULL DROP TABLE tblVets;

CREATE TABLE tblGuardians
(
GuardianID int IDENTITY(1,1) PRIMARY KEY,
FirstName varchar(20),
LastName varchar(30),
DateOfBirth date,
Tel varchar(13),
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
ProcedureID int IDENTITY(1,1) PRIMARY KEY,
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
AnimalID int IDENTITY(1,1) PRIMARY KEY,
Name varchar(20),
Species varchar(20),
Breed varchar(20),
Gender char(1),
DateRecieved date,
Illnesses varchar(50),
Injuries varchar(50),
Notes varchar(100),
RoomNo int,
Neutered bit,
EstimatedAge int,
AgroRating int,
PhotoDir varchar(50),
GuardianID int FOREIGN KEY REFERENCES tblGuardians(GuardianID)
)

--AgroRating on a scale pf 0 - 5
-- No agro = 0
-- agro towards other animals = 1 ro 2
-- agro towards people = 3 or 4
-- agro towards everyone = 5

INSERT INTO tblAnimals(Name, Species, Breed,Gender, DateRecieved, Illnesses, Injuries, Notes, RoomNo, Neutered, EstimatedAge, AgroRating, GuardianID)
VALUES ('Cloe', 'Canine', 'Dushond','F', '20131012', null, 'Broken Leg', null, 105, 1,3,0,1),
('Rocket', 'Canine', 'Rotviler','M', '20120517', 'Malnutrition', null,null,207,0,2,2,null),
('Storm', 'Feline', 'Savana','F', '20100416', null, null, 'Neutering required', 201, 0,1,0,null),
('Genna', 'Canine', 'Labradour','F', '20130517', 'Ear infection', null, 'Drop required hourly', 107, 1, 8, 0,2),
('Kissy', 'Feline', 'Savana','F', '20130421', 'Tooth abesis', null, 'Not eating, and limping', 104, 1, 13, 0,3),
('Kitten', 'Feline', 'Tourtise Shell','F', '20131225', null , 'Burnt and broken bone', 'Vacinations needed', 103,0,3,5,null),
('Candy', 'Canine', 'Poodle','F', '20130718', null, 'Snake bite', 'Speacial low carb food', 102,1,5,1,4),
('Milo', 'Canine', 'Jack Russle','M', '20130514', null, 'Cuts', null, 231, 0, 3, 5,null),
('Chanel', 'Canine', 'Labradour','F', '20120510', 'Cancer', null, 'Leg cancer', 201, 1, 9, 0,5),
('Pepper', 'Canine', 'Labradour Mix','M', '20130621', null, null, 'Very cold', 101, 0, 3, 1,null),
('Charlie', 'Bird', 'Ring Neck','M', '20130308', null, null, 'Afraid of bags', 103, null, 1, 3,2),
('Elu', ' Bird', 'Electus','M', '20130704', null, 'Broken Wing', null, 106, null, 3, 5,null),
('Lumen', 'Bird', 'Ring Neck','F', '20130411', null, null, 'Tendancy to pluck', 144, null, 1, 0,null) 

CREATE TABLE tblVets
(
VetID int IDENTITY(1,1) PRIMARY KEY,
FirstName varchar(20),
LastName varchar(30),
DateOfBirth date,
Tel int,
ResAddress varchar(50),
Qualification varchar(30)
)

INSERT INTO tblVets(FirstName, LastName, DateOfBirth, Tel, ResAddress, Qualification)
VALUES('Danni', 'Benoure', '19900712', '0781697540', '97 Kromboom Rd, Rondebosch, 7754', 'Bsc Med'),
('Alecia', 'Stenhouse', '19870501', '0836337521', '12 Keurkjtie Close, Vredekloof, 7942', 'Bsc Vet'),
('Alexsis', 'Berminger', '19660612', '0785423691', '42 Clear Water Drive, Somerset West 2256', 'Masters Vet'),
('Rhonwen', 'Renison', '19780410', '0825641792', '101 Loop St, Cape Town, 8001', 'Dip Med') 

--CREATE TABLE tblRecievePatient
--(
--RecievePatientID int IDENTITY(1,1) PRIMARY KEY(GuardianID, AnimalID),
--GuardianID int FOREIGN KEY REFERENCES tblGuardians(GuardianID) NOT NULL,
--AnimalID int FOREIGN KEY REFERENCES tblAnimals(AnimalID) NOT NULL
--)

--INSERT INTO tblRecievePatient(GuardianID, AnimalID)
--VALUES(1,1),
--(2,4),
--(3,5),
--(4,7),
--(5,9),
--(2,11)

CREATE TABLE tblProcedureOp
(
ProcedureOpID int IDENTITY(1,1) PRIMARY KEY,
ProcedureID int FOREIGN KEY REFERENCES tblProcedures(ProcedureID),
AnimalID int FOREIGN KEY REFERENCES	tblAnimals(AnimalID),
VetID int FOREIGN KEY REFERENCES tblVets(VetID)
)

INSERT INTO tblProcedureOp(ProcedureID, AnimalID, VetID)
VALUES(1,2,1),
(2,2,1),
(2,3,2),
(2,6,3),
(2,8,4),
(2,10,1),
(3,2,2),
(7,7,3),
(7,12,4)
