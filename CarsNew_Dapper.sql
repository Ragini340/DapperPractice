CREATE TABLE CarNew (
    id int IDENTITY(1,1) PRIMARY KEY,
    Name varchar(255) NOT NULL,
	price INT
   
);
INSERT INTO CarNew(Name, price) VALUES('Audi', 52642);
INSERT INTO CarNew(Name, price) VALUES('Mercedes', 57127);
INSERT INTO CarNew(Name, price) VALUES('Skoda', 9000);
INSERT INTO CarNew(Name, price) VALUES('Volvo', 29000);
INSERT INTO CarNew(Name, price) VALUES('Bentley', 350000);
INSERT INTO CarNew(Name, price) VALUES('Citroen', 21000);
INSERT INTO CarNew(Name, price) VALUES('Hummer', 41400);
INSERT INTO CarNew(Name, price) VALUES('Volkswagen', 21600);