CREATE DATABASE Pansiyon;

USE Pansiyon;

CREATE TABLE Oda(
	ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TC INT NOT NULL,
	AdSoyad VARCHAR(MAX) NOT NULL,
	Cinsiyet VARCHAR(MAX) NOT NULL,
	Oda VARCHAR(MAX) NOT NULL,
)

INSERT Oda(TC, AdSoyad, Cinsiyet, Oda) VALUES (1, 'Hande', 'gad?n', 'Tekki?ilik');

SELECT * FROM Oda