--inlock DML

USE inlock_games_manha
GO

INSERT INTO		Estudio (nomeEstudio)
VALUES			('Blizzard')
				,('Rockstar Studios')
				,('Square Enix')
GO

INSERT INTO		Jogo(nomeJogo, descricao, dataLancamento, valor, idEstudio)
VALUES			('Diablo', '� um jogo que cont�m bastante a��o e � viciante, seja voc� um novato ou um f�', '5/15/2012', 99, 1)
				,('Red Dead Redemption 2', 'Jogo eletr�nico de a��o-aventura western', '10/26/2018', 120, 2)
GO

INSERT INTO		TipoUsuario(titulo)
VALUES			('Admistrador')
				,('Cliente')
GO

INSERT INTO		Usuario(email, senha, idTipoUsuario)
VALUES			('admin@admin.com', 'admin', 1)
				,('cliente@cliente.com', 'cliente', 2)
GO