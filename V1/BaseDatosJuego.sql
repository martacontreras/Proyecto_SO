DROP DATABASE IF EXISTS Juego;
CREATE DATABASE Juego;
USE Juego;

CREATE TABLE Jugador(
	id INT,
	username VARCHAR(20),
	pass VARCHAR(20),
	partidas_ganadas INT,
	PRIMARY KEY (id)
)ENGINE=InnoDB;

CREATE TABLE Partida(
	id INT,
	fecha VARCHAR(15),
	hora VARCHAR(15),
	duracion INT,
	tablon VARCHAR(20),
	ganador VARCHAR(20),
	num_jugadores INT,
	PRIMARY KEY (id)
)ENGINE=InnoDB;

CREATE TABLE Participacion(
	idJ INT,
	idP INT,
	FOREIGN KEY (idJ) REFERENCES Jugador(id),
	FOREIGN KEY (idP) REFERENCES Partida(id)
)ENGINE=InnoDB;

INSERT INTO Jugador VALUES (1,'Juan','Juan1',1);
INSERT INTO Jugador VALUES (2,'Pedro','Pedro2',4);


INSERT INTO Partida VALUES (1,'11.03.22','12:56',12,'CasaDePapel','Juan',2);
INSERT INTO Partida VALUES (2,'11.03.22','12:56',12,'StarWars','Pedro',2);
INSERT INTO Partida VALUES (3,'11.03.22','12:56',12,'HarryPotter','Pedro',2);
INSERT INTO Partida VALUES (4,'11.03.22','12:56',12,'HarryPotter','Pedro',2);
INSERT INTO Partida VALUES (5,'11.03.22','12:56',12,'HarryPotter','Pedro',2);

INSERT INTO Participacion VALUES (1,1);
INSERT INTO Participacion VALUES (2,1);
INSERT INTO Participacion VALUES (1,2);
INSERT INTO Participacion VALUES (2,2);
INSERT INTO Participacion VALUES (1,3);
INSERT INTO Participacion VALUES (2,3);
INSERT INTO Participacion VALUES (1,4);
INSERT INTO Participacion VALUES (2,4);
INSERT INTO Participacion VALUES (1,5);
INSERT INTO Participacion VALUES (2,5);