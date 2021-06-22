--inlock DQL

USE inlock_games_manha
GO

SELECT * FROM Usuario
GO

SELECT * FROM Estudio
GO

SELECT * FROM Jogo
GO

SELECT		j.nomeJogo AS Nome, E.nomeEstudio AS Estudio FROM Jogo AS J
INNER JOIN	Estudio AS E
ON			J.idEstudio = J.idEstudio
GO

SELECT		E.nomeEstudio AS Estudio, J.nomeJogo AS Jogo FROM Estudio AS E
LEFT JOIN	Jogo AS J
ON			E.idEstudio = J.idEstudio
GO

SELECT		titulo [Permissao], email Email, senha Senha FROM Usuario U
INNER JOIN	TipoUsuario T
ON			U.idTipoUsuario = T.idTipoUsuario
WHERE		email = 'admin@admin.com' AND senha = 'admin'
GO

SELECT		idJogo, nomeJogo [Nome do Jogo] FROM Jogo
WHERE		idJogo = '2'
GO

SELECT		idEstudio, nomeEstudio Nome FROM Estudio
WHERE		idEstudio = '3'
GO