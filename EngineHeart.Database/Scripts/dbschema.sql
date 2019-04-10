CREATE TABLE Components (
	id					        INTEGER           PRIMARY KEY,
	type				        INTEGER           NOT NULL,
	name				        VARCHAR           NOT NULL UNIQUE,
	value				        INTEGER           NOT NULL,
	description					VARCHAR           NOT NULL,
	rated				        BIT               NOT NULL
);