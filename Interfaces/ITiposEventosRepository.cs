﻿using projeto_event_plus.Domains;

namespace projeto_event_plus.Interfaces
{
    public interface ITiposEventosRepository
    {
        //cadastrar
        void Cadastrar (TiposEventos tiposEventos);

        //deletar
        void Deletar (Guid id);

        //listar
        List<TiposEventos> Listar();


        //BuscarPorId
        TiposEventos BuscarPorId(Guid id, TiposEventos tiposEventos);

        //atualizar
        void Atualizar (Guid id, TiposEventos tiposEventos);

    }
}
