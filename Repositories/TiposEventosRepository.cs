using projeto_event_plus.Contexts;
using projeto_event_plus.Domains;
using projeto_event_plus.Interfaces;

namespace projeto_event_plus.Repositories
{
    
    public class TiposEventosRepository : ITiposEventosRepository
    
    
    {
        private readonly Event_Context _context;
        public TiposEventosRepository(Event_Context context)
        {
            _context = context;
        }
        public void Atualizar(Guid id, TiposEventos tiposEventos)
        {
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TiposEventos BuscarPorId(Guid id, TiposEventos tiposEventos)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(TiposEventos tiposEventos)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<TiposEventos> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
