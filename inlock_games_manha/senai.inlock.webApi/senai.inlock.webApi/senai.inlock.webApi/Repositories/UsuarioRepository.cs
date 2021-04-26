using senai.inlock.webApi_.Domains;
using senai.inlock.webApi_.Interfaces;
using System;
using System.Data.SqlClient;

namespace senai.inlock.webApi_.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string stringConexao = "Data Source=KEMILLY; initial catalog=inlock_games_manha; user Id=KEMILLY\unicor; pwd=!KSF2021";

        public UsuarioDomain BuscarPorEmailSenha(string email, string senha)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelect = "SELECT idUSuario, email, senha, idTipoUsuario FROM Usuario WHERE email = @email AND senha = @senha;";

                using (SqlCommand cmd = new SqlCommand(querySelect, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        UsuarioDomain usuarioBuscado = new UsuarioDomain
                        {
                            idUsuario       = Convert.ToInt32(rdr["idUsuario"]),
                            email           = rdr["email"].ToString(),
                            senha           = rdr["senha"].ToString(),
                            idTipoUsuario   = Convert.ToInt32(rdr["idTipoUsuario"])
                        };

                        return usuarioBuscado;

                    }

                    return null;
                }
            }
        }
    }
}
