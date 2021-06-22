--DQL

USE M_Peoples
GO

--lista todos os funcion�rios e todas suas informa��es
SELECT * FROM Funcionarios
GO

--lista todos os funcion�rios
SELECT IdFuncionario, Nome, Sobrenome 
FROM Funcionarios;

--mostra o funcion�rio com ID = 1
SELECT IdFuncionario, Nome, Sobrenome 
FROM Funcionarios 
WHERE IdFuncionario = 1;

--mostra o funcion�rio que tem o nome Catarina
SELECT IdFuncionario, Nome, Sobrenome 
FROM Funcionarios 
WHERE Nome = 'Catarina';

--mostra o nome completo dos funcion�rios
SELECT IdFuncionario, CONCAT (Nome,' ',Sobrenome) AS [Nome Completo], 
DataNascimento FROM Funcionarios;

--lista todos os funcion�rios de forma ordenada
SELECT IdFuncionario, Nome, Sobrenome, DataNascimento 
FROM Funcionarios 
ORDER BY Nome DESC;