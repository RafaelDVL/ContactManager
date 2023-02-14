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

        public bool Apagar(int id)
        {
            ContatoModel contatoold = GetById(id);
            if (contatoold == null) throw new Exception("Ocorreu um erro ao tentar encontrar.");
            _bancoContext.Contatos.Remove(contatoold);
            _bancoContext.SaveChanges();
            return true;
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoold = GetById(contato.Id);
            if(contatoold == null) throw new Exception("Ocorreu um erro ao tentar salvar a informação.");
            
            contatoold.Nome = contato.Nome;
            contatoold.Email = contato.Email;
            contatoold.Telefone= contato.Telefone;

            _bancoContext.Contatos.Update(contatoold);
            _bancoContext.SaveChanges();
            return contatoold;
        }

        public List<ContatoModel> GetAll()
        {
            return _bancoContext.Contatos.ToList();
        }

        public ContatoModel GetById(int id)
        {
            return _bancoContext.Contatos.Find(id);
            
        }
    }
}
