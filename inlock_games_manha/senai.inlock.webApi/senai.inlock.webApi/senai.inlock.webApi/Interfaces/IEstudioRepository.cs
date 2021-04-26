using senai.inlock.webApi_.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi_.Interfaces
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
