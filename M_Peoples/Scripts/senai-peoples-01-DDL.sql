--DDL

--cria o banco de dados com o nome M_Peolpes
	CREATE DATABASE M_Peoples
	GO

--define o banco de dados a ser usado
USE M_Peoples
GO

--cria uma tabela com o nome funcionrios
CREATE TABLE Funcionarios
(
	idFuncionario	INT PRIMARY KEY IDENTITY
	,nome			VARCHAR (100) NOT NULL
	,sobrenome		VARCHAR (100) NOT NULL
);
GO

--adiciona a coluna DataNascimento na tabela Funcionarios
ALTER TABLE Funcionarios
ADD DataNascimento Date
