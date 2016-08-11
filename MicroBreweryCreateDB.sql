IF OBJECT_ID('MicroBreweryRatings', 'U') IS NOT NULL DROP TABLE MicroBreweryRatings;
IF OBJECT_ID('BeerRatings', 'U') IS NOT NULL DROP TABLE BeerRatings;
IF OBJECT_ID('Beers', 'U') IS NOT NULL DROP TABLE Beers;
IF OBJECT_ID('Beertypes', 'U') IS NOT NULL DROP TABLE Beertypes;
IF OBJECT_ID('MicroBrewerys', 'U') IS NOT NULL DROP TABLE MicroBrewerys;

CREATE TABLE MicroBrewerys (
	Id INT IDENTITY NOT NULL,
	MicroBreweryDescription VARCHAR (1000),
	Name VARCHAR(255),
	TotalRatingValue INT,
	RatingCount INT,
	Latitude FLOAT,
	Longitude FLOAT,
	Location VARCHAR(255),
	OpeningHours VARCHAR(255),
	PRIMARY KEY (Id)
);

CREATE TABLE Beertypes (
	Id INT IDENTITY NOT NULL,
	Name VARCHAR (255) NOT NULL,
	PRIMARY KEY (Id)
);

CREATE TABLE Beers (
	Id INT IDENTITY NOT NULL,
	AlcoholPercentage FLOAT,
	BeerDescription VARCHAR (1000),
	BrewedById INT NOT NULL,
	Name VARCHAR(255),
	Price Decimal(10,2),
	BeerTypeId INT NOT NULL,
	TotalRatingValue INT,
	RatingCount INT,
	FOREIGN KEY (BeerTypeId) REFERENCES BeerTypes(Id),
	FOREIGN KEY (BrewedById) REFERENCES MicroBrewerys(Id),
	PRIMARY KEY (Id)
);


CREATE TABLE BeerRatings (
	Id INT IDENTITY NOT NULL,
	Value INT NOT NULL,
	BeerId INT NOT NULL,
	FOREIGN KEY (BeerId) REFERENCES Beers(Id),
	PRIMARY KEY (Id)
);

CREATE TABLE MicroBreweryRatings (
	Id INT IDENTITY NOT NULL,
	Value INT NOT NULL,
	MicroBreweryId INT NOT NULL,
	FOREIGN KEY (MicroBreweryId) REFERENCES MicroBrewerys(Id),
	PRIMARY KEY (Id)
);