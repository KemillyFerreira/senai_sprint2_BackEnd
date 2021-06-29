--inlock DML

USE inlock_games_manha
GO

INSERT INTO		Estudio (nomeEstudio)
VALUES			('Blizzard')
				,('Rockstar Studios')
				,('Square Enix')
GO

INSERT INTO		Jogo(nomeJogo, descricao, dataLancamento, valor, idEstudio)
VALUES			('Diablo', 'É um jogo que contém bastante ação e é viciante, seja você um novato ou um fã', '15/5/2012', 99, 1)
				,('Red Dead Redemption 2', 'Jogo eletrônico de ação-aventura western', '26/10/2018', 120, 2)
GO

INSERT INTO		TipoUsuario(titulo)
VALUES			('Admistrador')
				,('Cliente')
GO

INSERT INTO		Usuario(email, senha, idTipoUsuario)
VALUES			('admin@admin.com', 'admin', 1)
				,('cliente@cliente.com', 'cliente', 2)
GO