﻿using senai.inlock.webApi_.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi_.Interfaces
{
    interface IJogoRepository
    {
        List<JogoDomain> ListarTodos();

        JogoDomain BuscarPorId(int id);

        void Deletar(int id);

        void AtualizarIdUrl(int id, JogoDomain jogo);

        void Cadastrar(JogoDomain novojogo);
    }
}
