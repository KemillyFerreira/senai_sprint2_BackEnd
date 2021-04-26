using senai.inlock.webApi_.Domains;
using senai.inlock.webApi_.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace senai.inlock.webApi_.Repositories
{   
    public class JogoRepository : IJogoRepository
    {
       /// <sumary>
       /// string de conexão com o banco de dados que recebe os parâmetros
       /// Data Source = nome do servidor
       /// initial catalog = nome do banco de dados
       /// user Id w pwd = autenticação do usuário do SQL Server
       /// </sumary>
        
        private string stringConexao = "Data Source=KEMILLY; initial catalog=inlock_games_manha; user Id=KEMILLY\unicor; pwd=!KSF2021";

        public void AtualizarIdUrl(int id, JogoDomain jogo)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryUpdate = "UPDATE Jogo SET nomeJogo = @Nome, descricao = @Desc, dataLancamento = @Data, valor = @Valor, idEstudio = @Estudio WHERE idJogo = @ID";

                using (SqlCommand cmd = new SqlCommand(queryUpdate, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Nome", jogo.nome);
                    cmd.Parameters.AddWithValue("@Desc", jogo.descricao);
                    cmd.Parameters.AddWithValue("@Data", jogo.dataLancamento);
                    cmd.Parameters.AddWithValue("@Valor", jogo.valor);
                    cmd.Parameters.AddWithValue("@Estudio", jogo.idEstudio);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public JogoDomain BuscarPorId(int id)
        {
             using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelect = "SELECT * FROM Jogo WHERE idJogo = @ID";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelect, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        JogoDomain jogoBuscado = new JogoDomain
                        {
                            idJogo = Convert.ToInt32(rdr["idJogo"]),
                            nome = rdr["nomeJogo"].ToString(),
                            descricao = rdr["descricao"].ToString(),
                            dataLancamento = rdr["dataLancamento"].ToString(),
                            valor = Convert.ToInt32(rdr["dataLancamento"]),
                            idEstudio = Convert.ToInt32(rdr["idEstudio"])
                        };

                        return jogoBuscado;
                    }

                    return null;
                }
            }
        }

        public void Cadastrar(JogoDomain novoJogo)
        {
             using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryCadastrar = "INSERT INTO Jogos(nomeJogo, descricao, dataLancamento, valor, idEstudio) VALUES(@Nome, @Desc, @Data, @Valor, @IdEstudio)";

                using (SqlCommand cmd = new SqlCommand(queryCadastrar, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", novoJogo.nome);
                    cmd.Parameters.AddWithValue("@Desc", novoJogo.descricao);
                    cmd.Parameters.AddWithValue("@Data", novoJogo.dataLancamento);
                    cmd.Parameters.AddWithValue("@Valor", novoJogo.valor);
                    cmd.Parameters.AddWithValue("@IdEstudio", novoJogo.idEstudio);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Deletar(int id)
        {
            using(SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryDelete = "DELETE FROM Jogo WHEERE idJogo = @ID";

                using (SqlCommand cmd = new SqlCommand(queryDelete))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }

        }

        /// <summary>
        /// este método lista todos os jogos
        /// </summary>
        /// <returns>uma lista de jogos</returns>
        public List<JogoDomain> ListarTodos()
        {
            // cria uma lista chamada listaJogo onde serão armazenados os dados
            List<JogoDomain> listaJogo = new List<JogoDomain>();

            // declara a SqlConnection con passando a string de conexão como parâmetro
            using(SqlConnection con = new SqlConnection(stringConexao))
            {
                // declara a instrução a ser executada
                string querySelectAll= "SELECT * FROM Jogo";
                
                // abre a conexão com o banco de dados
                con.Open();

                // declara a SqlDataReader rdr para percorrer a tabela do banco de dados
                SqlDataReader rdr;

                using (SqlCommand cmd= new SqlCommand(querySelectAll, con))
                {
                    //executa a query e armazena dados no rdr
                    rdr = cmd.ExecuteReader();
                    
                    //enquanto houver registro para serem lidos no rdr, o laço se repete
                    while (rdr.Read())
                    {
                        // instancia um objeto Jogo do tipo JogoDomain
                        JogoDomain jogo = new JogoDomain()
                        {
                            idJogo = Convert.ToInt32(rdr["idJogo"]),
                            nome = rdr["nomeJogo"].ToString(),
                            descricao = rdr["descricao"].ToString(),
                            dataLancamento = rdr["dataLancamento"].ToString(),
                            valor = Convert.ToInt32(rdr["dataLancamento"]),
                            idEstudio= Convert.ToInt32(rdr["idEstudio"])
                        };

                        // adiciona o objeto jogo a lista de listaJogo
                        listaJogo.Add(jogo);
                    }
                }
            }
            // retorna a lista de jogos
            return listaJogo;
        }
    }
}
