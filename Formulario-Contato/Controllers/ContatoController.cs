using Microsoft.AspNetCore.Mvc;

namespace Formulario_Contato.Controllers
{
    
    public class ContatoController : Controller 
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        // Alterado o último parâmetro de "message" para "mensagem"
        public IActionResult Enviar(string nome, string email, string assunto, string mensagem)
        {
            ViewBag.MensagemSucesso = $"Obrigado {nome}! Sua mensagem sobre '{assunto}' foi recebida.";
            return View("Index");
        }
    }
}