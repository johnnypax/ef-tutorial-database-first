CREATE DATABASE ef_lez01_single_table;
USE ef_lez01_single_table;

CREATE TABLE Contatto(
	contattoID INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50) NOT NULL,
	cognome VARCHAR(50) NOT NULL,
	email VARCHAR(100) NOT NULL UNIQUE,
	cod_fis CHAR(16) NOT NULL UNIQUE,
	eta INT,
);

INSERT INTO Contatto(nome, cognome, email, cod_fis, eta) VALUES
('Giovanni', 'Pace', 'gio@pace.com', 'PCAGNN', 37),
('Valeria', 'Verdi', 'val@verdi.com', 'VLRVRD', 65),
('Mario', 'Rossi', 'mar@rossi.com', 'MRRRSS', 67),
('Marika', 'Mariko', 'mrk@rossi.com', 'MRKMRK', 34);

SELECT * FROM Contatto WHERE nome LIKE '%io%';