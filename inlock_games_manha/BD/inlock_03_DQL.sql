--inlock DQL

USE inlock_games_manha
GO

SELECT * FROM Usu�rio
GO

SELECT * FROM Estudio
GO

SELECT * FROM Jogo
GO

SELECT		j.nomeJogo AS Nome, E.nomeEstudio AS Estudio FROM Jogo AS J
INNER JOIN	Estudio AS E
ON			J.idEstuddio = J.idEstuddio
GO

SELECT		E.nomeEstudio AS Estudio, J.nomeJogo AS Jogo FROM Estudio AS E
LEFT JOIN	Jogo AS J
ON			E.idEstudio = J.idEstuddio
GO

SELECT		t�tulo [Permiss�o], email Email, senha Senha FROM Usu�rio U
INNER JOIN	TipoUsu�rio T
ON			U.idTipoUsu�rio = T.idTipoUsu�rio
WHERE		email = 'admin@admin.com' AND senha = 'admin'
GO

SELECT		idJogo, nomeJogo [Nome do Jogo] FROM Jogo
WHERE		idJogo = '2'
GO

SELECT		idEstudio, nomeEstudio Nome FROM Estudio
WHERE		idEstudio = '3'
GO