--DDL
CREATE DATABASE SENAI_HROADS_MANHA;

USE SENAI_HROADS_MANHA;

CREATE TABLE TipoHabilidade
(
	idTipoHabilidade	INT PRIMARY KEY IDENTITY
	,Tipo VARCHAR		(20)
);

CREATE TABLE Habilidade
(
	idHabilidade	INT PRIMARY KEY IDENTITY
	,Nome			VARCHAR(30)
	,idTipoHabilidade	INT FOREIGN KEY REFERENCES TipoHabilidade (idTipoHabilidade)
);

CREATE TABLE Classe
(
	idClasse	INT PRIMARY KEY IDENTITY
	,Nome		VARCHAR(50)
);

CREATE TABLE ClasseHabilidade
(
	idClasse		INT FOREIGN KEY REFERENCES Classe (idClasse)
	,idHabilidade	INT FOREIGN KEY REFERENCES Habilidade (idHabilidade)
);

CREATE TABLE Personagem
(
	idPersonagem	INT PRIMARY KEY IDENTITY
	,Nome			VARCHAR (20)
	,Classe			VARCHAR (50)
	,idClasse		INT FOREIGN KEY REFERENCES Classe(idClasse)
	,VidaMax		TINYINT
	,ManaMax		TINYINT
	,DataAtualizaçao VARCHAR(20)
	,DataCriacao	 VARCHAR (20)
);
