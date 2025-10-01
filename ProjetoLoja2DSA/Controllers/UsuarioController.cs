//IMPORTA AS BIBLIOTECAS QUE SERÃO UTILIZADAS NO PROJETO
using Microsoft.AspNetCore.Mvc;
using ProjetoLoja2DSA.Controllers;
using ProjetoLoja2DSA.Repositorio;
//DEFINE O NOME E ONDE A CLASSE USUARIOCONTROLLER ESTÁ LOCALIZADA
//NAMESPACE AJUDA A ORGANIZAR O CÓDIGO E EVITAR CONFLITOS.
namespace ProjetoLoja2DSA.Controllers
{
    //CLASSE USUARIOCONTROLLER QUE ESTÁ HERDANDO DA CLASSE PAI CONTROLLER
    public class UsuarioController : Controller
    {
        //DECLARA A VARIÁVEL PRIVADA E SOMENTE LEITURA DO TIPO USUARIOREPOSITORIO
        //INSTANCIA O USUARIOCONTROLLER PARA SER ATRIBUÍDO NO CONSTRUTOR E INTERAJIR COM OS DADOS
        private readonly UsuarioRepositorio _usuarioRepositorio;

        //DEFINE O CONSTRUTOR DA CLASSE USUARIOCONTROLLER
        //RECEBE A INSTANCIA DE USUARIOREPOSITORIO COM PARAMETROS
        public UsuarioController(UsuarioRepositorio usuarioRepositorio)
        {
             //O CONSTRUTOR É CHAMADO QUANDO UMA NOVA INSTANCIA É CRIADA
            _usuarioRepositorio = usuarioRepositorio;
        }
        
        
        
        //INTERFACE QUE REPRESENTA O RESULTADO DA PÁGINA
        public IActionResult Index()
        {
            return View();
        }
    }
}
