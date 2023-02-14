using ContactManager.Models;
using ContactManager.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ContactManager.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepository _contatoRepository;

        public ContatoController(IContatoRepository contatoRepository)
        {
            _contatoRepository= contatoRepository;
        }

        public IActionResult Index()
        {
            List<ContatoModel> listContatos = _contatoRepository.GetAll();
            return View(listContatos);
        }

        public IActionResult CriarContato()
        {
            return View();
        }

        public IActionResult EditarContato(int id)
        {
            ContatoModel contato = _contatoRepository.GetById(id);
            return View(contato);
        }

        public IActionResult ApagarContato(int id)
        {
            ContatoModel contato = _contatoRepository.GetById(id);
            return View(contato);
        }

        public IActionResult Apagar(int id)
        {
            _contatoRepository.Apagar(id);
            return RedirectToAction("index");
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRepository.Adicionar(contato);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(ContatoModel contato)
        {
            ContatoModel contatoModel = _contatoRepository.Atualizar(contato);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public List<ContatoModel> GetAll()
        {
            return _contatoRepository.GetAll();
        }
    }
}
