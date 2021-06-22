--DML

USE M_Peoples
GO

--insere os nomes e sobrenomes dos funcionários
INSERT INTO		Funcionarios (nome, sobrenome)
VALUES			('Catarina', 'Strada')
				,('Tadeu', 'Vitelli')
GO


--atualiza o valor da coluna data de nascimento
UPDATE Funcionarios SET DataNascimento = '1993-03-17';

SELECT * FROM Funcionarios;