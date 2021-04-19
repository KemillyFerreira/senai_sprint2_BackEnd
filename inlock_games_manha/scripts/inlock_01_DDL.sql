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
	,descri��o		VARCHAR (500) NOT NULL
	,dataLan�amento	DATE NOT NULL
	,valor			INT NOT NULL
	,idEstuddio		INT FOREIGN KEY REFERENCES Estudio (idEstudio)
);
GO

CREATE TABLE TipoUsu�rio
(
	idTipoUsu�rio	INT PRIMARY KEY IDENTITY
	,t�tulo			VARCHAR (100) NOT NULL
);
GO

CREATE TABLE Usu�rio
(
	idUsu�rio		INT PRIMARY KEY IDENTITY
	,email			VARCHAR (100) UNIQUE NOT NULL
	,senha			VARCHAR (20) NOT NULL
	,idTipoUsu�rio	INT FOREIGN KEY REFERENCES TipoUsu�rio (idTipoUsu�rio)
);
GO