INSERT INTO Airport (airportId, IATA, country) VALUES (1, 'CPH', 'Denmark'), (2, 'CDG', 'France'), (3, 'HEL', 'Finland'), (4, 'DUB', 'Ireland'),(5, 'LAX', 'USA')
INSERT INTO Company (companyId, companyName) VALUES (1, 'SAS'), (2, 'Emirates'), (3, 'Ryanair'), (4, 'Thomson Airways'), (5, 'Lufthansa')
INSERT INTO TravelRoute (travelRouteId, ownerCompanyId, fromId, toId) VALUES (1, 1, 'CPH', 'CDG'), (2, 3, 'CPH', 'HEL'), (3, 2, 'CPH', 'LAX'),
	(4, 1, 'CPH', 'DUB'), (5, 4, 'CPH', 'HEL')
	