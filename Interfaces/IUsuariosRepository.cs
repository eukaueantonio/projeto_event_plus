using projeto_event_plus.Domains;

namespace projeto_event_plus.Interfaces
{
    public interface IUsuariosRepository
    {
        void Cadastrar(Usuarios usuarios);
        Usuarios BuscarPorId(Guid id);
        Usuarios BuscarPorEmailESenha(string Email, string Senha);

    }
}
