using ContactManager.Models;

namespace ContactManager.Repositories
{
    public interface IContatoRepository
    {   

        ContatoModel GetById(int id);
        List<ContatoModel> GetAll();
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);

        bool Apagar(int id);
    }
}
