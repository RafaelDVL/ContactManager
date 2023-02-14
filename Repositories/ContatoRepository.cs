using ContactManager.Data;
using ContactManager.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ContactManager.Repositories
{
    public class ContatoRepository: IContatoRepository
    {
        private BancoContext _bancoContext;

        public ContatoRepository(BancoContext bancoContext) {
            _bancoContext = bancoContext;
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public List<ContatoModel> GetAll()
        {
            return _bancoContext.Contatos.ToList();
        }
    }
}
