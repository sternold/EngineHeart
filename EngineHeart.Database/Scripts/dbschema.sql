CREATE TABLE Robot (
	Id					int,
	Name				varchar(255),
	Player				varchar(255),
	OriginalPurpose		varchar(255),
	RealityCom			int,
	HumanCom			int,
	DigiCon				int,
	MechaniCon			int,
	Dexterity			int,
	Mobility			int,
	Perception			int,
	Reflexes			int,
	Strength			int,
	Durability			int,
	Buffer				int,
	Size				int,
	Power				int
);

CREATE TABLE Components (
    Id					int,
	Type				int,
	Name				varchar(255),
	Value				int,
	Description			varchar(255),
	Rated				int
);

CREATE TABLE RobotComponents (
	Id					int,
	RobotId				int,
	ComponentId			int,
	Rating				int
);