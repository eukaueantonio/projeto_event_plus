using projeto_event_plus.Domains;

namespace projeto_event_plus.Interfaces
{
    public interface ITiposUsuariosRepository
    {
        void Cadastrar(TiposUsuarios tiposUsuarios);
        List<TiposUsuarios> Listar();
        void Deletar (Guid id);
        void Atualizar(Guid id);
        TiposUsuarios BuscarPorId(Guid id);
    }
}
