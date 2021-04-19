--inlock DDL

CREATE DATABASE	inlock_games_manha
GO 

USE inlock_games_manha
GO

CREATE TABLE Estudio
(
	idEstudio		INT PRIMARY KEY IDENTITY
	,nomeEstudio	VARCHAR (200) NOT NULL
);
GO

CREATE TABLE Jogo
(
	idJogo			INT PRIMARY KEY IDENTITY
	,nomeJogo		VARCHAR (200) NOT NULL
	,descrição		VARCHAR (500) NOT NULL
	,dataLançamento	DATE NOT NULL
	,valor			INT NOT NULL
	,idEstuddio		INT FOREIGN KEY REFERENCES Estudio (idEstudio)
);
GO

CREATE TABLE TipoUsuário
(
	idTipoUsuário	INT PRIMARY KEY IDENTITY
	,título			VARCHAR (100) NOT NULL
);
GO

CREATE TABLE Usuário
(
	idUsuário		INT PRIMARY KEY IDENTITY
	,email			VARCHAR (100) UNIQUE NOT NULL
	,senha			VARCHAR (20) NOT NULL
	,idTipoUsuário	INT FOREIGN KEY REFERENCES TipoUsuário (idTipoUsuário)
);
GO