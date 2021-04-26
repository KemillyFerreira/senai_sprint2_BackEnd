--DML

USE SENAI_HROADS_MANHA;

INSERT INTO TipoHabilidade	(Tipo)
VALUES						('Ataque')
						   ,('Defesa')
						   ,('Cura')
						   ,('Magia');

INSERT INTO Habilidade(Nome, TipoHabilidade)
VALUES					('LancaMortal', 1)
					   ,('EscudoSupremo', 2)
					   ,('RecuperarVida', 3);

INSERT INTO Classe(Nome)
VALUES			  ('Barbaro')
				 ,('Cruzado')
				 ,('CacadoraDeDem')
				 ,('Monge')
				 ,('Necromante')
				 ,('Feiticeiro')
				 ,('Arcanista');

INSERT INTO ClasseHabilidade(idClasse, idHabilidade)
VALUES						(1, 1)
						   ,(1, 2)
						   ,(4, 2)
						   ,(4, 3)
						   ,(7, null);

INSERT INTO Personagem(Nome, Classe, idClasse,VidaMax, ManaMax, DataAtualizaçao, DataCriacao)
VALUES				  ('DeuBug', 'Barbaro', 1, 100, 80, '02/03/2021', '18/01/2019')
					 ,('BitBug', 'Monge', 4, 70, 100, '02/03/2021', '17/03/2016')
					 ,('Fer8', 'Arcanista', 7, 75, 60, '02/03/2021', '18/03/2018');

UPDATE Personagem
SET Nome = 'Fer7'
WHERE idPersonagem = 3;

UPDATE Classe
SET Nome = 'Necromancer'
WHERE idClasse = 5;

UPDATE Classe
SET Nome = 'CacadoraDeDem.'
WHERE idClasse = 3;