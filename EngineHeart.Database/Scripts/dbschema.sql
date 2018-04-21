CREATE TABLE Robots (
	id					        INTEGER           PRIMARY KEY,
	name				        VARCHAR,
	player				      VARCHAR,
	originalpurpose		  VARCHAR,
	realitycom			    INTEGER,
	humancom			      INTEGER,
	digicon				      INTEGER,
	mechanicon			    INTEGER,
	dexterity			      INTEGER,
	mobility			      INTEGER,
	perception			    INTEGER,
	reflexes			      INTEGER,
	strength			      INTEGER,
	durability			    INTEGER,
	buffer				      INTEGER,
	size				        INTEGER,
	power				        INTEGER
);

CREATE TABLE Components (
  id					        INTEGER           PRIMARY KEY,
	type				        INTEGER           NOT NULL,
	name				        VARCHAR           NOT NULL UNIQUE,
	value				        INTEGER           NOT NULL,
	description			    VARCHAR           NOT NULL,
	rated				        BIT               NOT NULL
);

CREATE TABLE RobotComponents (
	id					        INTEGER           PRIMARY KEY,
	robotid				      INTEGER           NOT NULL,
	componentid			    INTEGER           NOT NULL,
	rating				      INTEGER,
	FOREIGN KEY(robotid) REFERENCES Robots(id),
	FOREIGN KEY(componentid) REFERENCES Components(id)
);