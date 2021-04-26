--inlock DML

USE inlock_games_manha
GO

INSERT INTO		Estudio (nomeEstudio)
VALUES			('Blizzard')
				,('Rockstar Studios')
				,('Square Enix')
GO

INSERT INTO		Jogo(nomeJogo, descrição, dataLançamento,valor, idEstuddio)
VALUES			('Diablo', 'É um jogo que contém bastante ação e é viciante, seja você um novato ou um fã.', '15/05/2012', 99, 1)
				,('Red Dead Redemption 2',	'Jogo eletrônico de ação-aventura western', '26/10/2018', 120, 2)
GO

INSERT INTO		TipoUsuário(título)
VALUES			('Admistrador')
				,('Cliente')
GO

INSERT INTO		Usuário(email, senha, idTipoUsuário)
VALUES			('admin@admin.com', 'admin', 1)
				,('cliente@cliente.com', 'cliente', 2)
GO