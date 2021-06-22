--DQL

USE M_Peoples
GO

--lista todos os funcionários e todas suas informações
SELECT * FROM Funcionarios
GO

--lista todos os funcionários
SELECT IdFuncionario, Nome, Sobrenome 
FROM Funcionarios;

--mostra o funcionário com ID = 1
SELECT IdFuncionario, Nome, Sobrenome 
FROM Funcionarios 
WHERE IdFuncionario = 1;

--mostra o funcionário que tem o nome Catarina
SELECT IdFuncionario, Nome, Sobrenome 
FROM Funcionarios 
WHERE Nome = 'Catarina';

--mostra o nome completo dos funcionários
SELECT IdFuncionario, CONCAT (Nome,' ',Sobrenome) AS [Nome Completo], 
DataNascimento FROM Funcionarios;

--lista todos os funcionários de forma ordenada
SELECT IdFuncionario, Nome, Sobrenome, DataNascimento 
FROM Funcionarios 
ORDER BY Nome DESC;