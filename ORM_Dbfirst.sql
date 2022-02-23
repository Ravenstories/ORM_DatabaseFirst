DROP TABLE TravelRoute;
DROP TABLE Company;
DROP TABLE Airport;


CREATE TABLE Company (
	companyId int primary key,
	companyName varchar(255)
	);

CREATE TABLE Airport (
	airportId int primary key,
	airportName varchar(255),
	IATA varchar(10) UNIQUE,
	country varchar(255)
	);

CREATE TABLE TravelRoute (
	travelRouteId int primary key,
	ownerCompanyId int,
	fromId varchar(10), 
	toId varchar(10),
	travelDate datetime
	);

ALTER TABLE TravelRoute ADD CONSTRAINT FK_ownerCompany Foreign key (ownerCompanyId) references Company(companyId);
ALTER TABLE TravelRoute ADD CONSTRAINT FK_fromId FOREIGN KEY (fromId) REFERENCES Airport(IATA);
ALTER TABLE TravelRoute ADD CONSTRAINT FK_toId FOREIGN KEY (toId) REFERENCES Airport(IATA);
ALTER TABLE TravelRoute ADD CONSTRAINT uc_travel UNIQUE (ownerCompanyId, fromId, toId, travelDate);




