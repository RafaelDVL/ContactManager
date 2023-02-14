using ContactManager.Models;

namespace ContactManager.Repositories
{
    public interface IContatoRepository
    {

        List<ContatoModel> GetAll();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
