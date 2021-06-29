using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inlock_games_manha.Interfaces
{
    interface IEstudioRepository
    {
       

        List<EstudioDomain> ListarTodos();

        EstudioDomain BuscarPorId(int id);

        void Deletar(int id);

        void AtualizarIdUrl(int id, EstudioDomain jogo);
     
        void Cadastrar(EstudioDomain novoJogo);
    }
}
