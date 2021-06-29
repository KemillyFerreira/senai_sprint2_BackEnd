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
	,descricao		VARCHAR (250) NOT NULL
	,dataLancamento	DATE NOT NULL
	,valor			INT NOT NULL
	,idEstudio		INT FOREIGN KEY REFERENCES Estudio (idEstudio)
);
GO

CREATE TABLE TipoUsuario
(
	idTipoUsuario	INT PRIMARY KEY IDENTITY
	,titulo			VARCHAR (100) NOT NULL
);
GO

CREATE TABLE Usuario
(
	idUsuario		INT PRIMARY KEY IDENTITY
	,email			VARCHAR (100)NOT NULL
	,senha			VARCHAR (20) NOT NULL
	,idTipoUsuario	INT FOREIGN KEY REFERENCES TipoUsuario (idTipoUsuario)
);
GO