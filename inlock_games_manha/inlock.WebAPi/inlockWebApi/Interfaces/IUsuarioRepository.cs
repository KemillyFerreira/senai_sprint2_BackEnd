using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inlock_games_manha.Interfaces
{
    interface IUsuarioRepository
    {
        UsuarioDomain BuscarPorEmailSenha(string email, string senha);
    }
}
