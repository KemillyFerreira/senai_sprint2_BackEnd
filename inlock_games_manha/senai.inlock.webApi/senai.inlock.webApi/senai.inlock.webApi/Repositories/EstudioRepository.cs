using senai.inlock.webApi_.Domains;
using senai.inlock.webApi_.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace senai.inlock.webApi_.Repositories
{
    public class EstudioRepository : IEstudioRepository
    {
        /// <summary>
        /// String de conexão com o banco de dados que recebe os parâmetros
        /// </summary>
        private string stringConexao = "Data Source=DESKTOP-9269FK6; initial catalog=inlock_games_manha; user Id=sa; pwd=!KSF2021";


        /// <summary>
        /// atualiza um estudio existente
        /// </summary>
        /// <param name="id"> id do estudio que sera atualizado </param>
        /// <param name="jogo">ojbeto que sera atualizado </param>
        public void AtualizarIdUrl(int id, EstudioDomain jogo)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryUpdateIdUrl = "UPDATE Estudio SET NomeEstudio = @NomeEstudio WHERE IdEstudio = @IdEstudio";

                using (SqlCommand cmd = new SqlCommand(queryUpdateIdUrl, con))
                {
                    cmd.Parameters.AddWithValue("@NomeEstudio", jogo.nomeEstudio);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public EstudioDomain BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// cadastra um novo estudio
        /// </summary>
        /// <param name="novoEstudio"></param>
        public void Cadastrar(EstudioDomain novoEstudio)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryInsert = "INSERT INTO Estudio(NomeEstudio) VALUES(@NomeEstudio)";
                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@NomeEstudio", novoEstudio.nomeEstudio);

                    //abre a conexão com o banco de dados
                    con.Open();

                    //executa a query
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// deleta um estudio existente
        /// </summary>
        /// <param name="id"></param>
        public void DeletarEstudio(int id)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryDelete = "DELETE FROM Estudio WHERE IdEstudio = @IdEstudio";

                using (SqlCommand cmd = new SqlCommand(queryDelete,con))
                {
                    cmd.Parameters.AddWithValue("@IdEstudio", id);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }

        }

        public List<EstudioDomain> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
