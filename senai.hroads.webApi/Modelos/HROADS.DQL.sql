--DQL

USE SENAI_HROADS_MANHA;

--pra ver se alterou corretamente o nome do personagem de Fer8 para Fer7
SELECT Nome FROM Personagem;

--para ver se alterou corretamente o nome da classe de necromante para necromancer
SELECT Nome FROM  Classe;

--selecionar todos os personagens
SELECT* FROM  Personagem;

--selecionar todas as classes
SELECT * FROM  Classe;

--Selecionar somente o nome das classes
SELECT Nome FROM  Classe;

--Selecionar todas as habilidades
SELECT * FROM  Habilidade;

--Realizar a contagem de quantas habilidades estão cadastradas
SELECT COUNT(idHabilidade) FROM  Habilidade;

--Selecionar somente os id’s das habilidades classificando-os por ordem crescente
SELECT idHabilidade FROM  Habilidade;

--Selecionar todos os tipos de habilidades
SELECT Tipo FROM  TipoHabilidade;

--Selecionar todas as habilidades e a quais tipos de habilidades elas fazem parte
SELECT Nome AS Habilidades, Tipo AS Tipos  
FROM  Habilidade AS H
INNER JOIN TipoHabilidade AS TH
ON H.idHabilidade = TH.idTipoHabilidade;

--Selecionar todos os personagens e suas respectivas classes
SELECT P.Nome AS Personagem, C.Nome AS Classe
FROM  Personagem AS P
INNER JOIN Classe AS C
ON P.idClasse = C.idClasse;

--Selecionar todos os personagens e as classes (mesmo que elas não tenham correspondência em personagens)
SELECT P.Nome AS Personagens, C.Nome AS Classe
FROM Personagem AS P
RIGHT JOIN Classe AS C
ON P.idClasse = C.idClasse;

--Selecionar todas as classes e suas respectivas habilidades
SELECT C.Nome AS Classe, H.Nome AS Habilidade
FROM Classe AS C
left join ClasseHabilidade AS CH
ON C.idClasse = CH.idClasse
LEFT JOIN Habilidade AS H
ON CH.idHabilidade = H.idHabilidade;

--Selecionar todas as habilidades e suas classes (somente as que possuem correspondência);
SELECT H.Nome AS Habilidades, C.Nome AS Classe
FROM Habilidade AS H
inner join ClasseHabilidade AS CH
ON H.idHabilidade = CH.idHabilidade
inner join Classe AS C
ON CH.idClasse = C.idClasse;

--Selecionar todas as habilidades e suas classes (mesmo que elas não tenham correspondência)
SELECT H.Nome AS Habilidades, C.Nome AS Classes
FROM Habilidade AS H
left join ClasseHabilidade AS CH
ON H.idHabilidade = CH.idHabilidade
right join Classe AS C
ON CH.idClasse = C.idClasse;