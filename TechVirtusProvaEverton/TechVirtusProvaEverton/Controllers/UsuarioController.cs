using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechVirtusProvaEverton.Models;
using TechVirtusProvaEverton.DAO;
using TechVirtusProvaEverton.Filtros;

namespace TechVirtusProvaEverton.Controllers
{
    [AutorizacaoFilter]
    public class UsuarioController : Controller
    {
        
        
        private IList<Usuario> usuarios;

        // GET: Usuario
        [Route("usuarios",Name ="todosUsuarios")]
        public ActionResult Index()
        {
            usuarios = new List<Usuario>();
            UsuariosDAO dao = new UsuariosDAO();
            usuarios = dao.Lista();
            
            return View(usuarios);
        }
        public ActionResult Login()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]        
        public ActionResult Acesso(Usuario usuario)
        {
            if(ModelState.IsValid)
            {
                UsuariosDAO dao = new UsuariosDAO();
                Usuario temp = new Usuario();

                

                temp = dao.Busca(usuario.Login,usuario.Senha);                
                usuario = temp;
                
                if(usuario!=null)
                {
                    PerfilDAO usuarioLogou = new PerfilDAO();
                    Session["usuarioLogado"] = usuario;
                    
                    

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    usuarios = new List<Usuario>();
                    dao = new UsuariosDAO();
                    usuarios = dao.Lista();
                    ViewBag.Usuario = usuarios;
                    return View("Login");
                }
                
            }
            else
            {
                usuarios = new List<Usuario>();
                UsuariosDAO dao = new UsuariosDAO();
                usuarios = dao.Lista();
                ViewBag.Usuario = usuarios;
                return View("Login");

            }
        }
        [Route("atualizaUsuario/{id}",Name ="Atualiza")]
        public ActionResult Edita(int id)
        {
            UsuariosDAO dao = new UsuariosDAO();
             Usuario usuario=dao.BuscaPorId(id);
            TipoPessoaDAO daoPessoa = new TipoPessoaDAO();
            IList<TipoPessoa> tipos = new List<TipoPessoa>();
            
            

            tipos= daoPessoa.Lista();                        
            ViewBag.TipoPessoa = tipos;
            ViewBag.Usuario = usuario;            
            ViewBag.Tela = "Atualizando Usuário";
            return View(usuario);
        }
        [Route("removeUsuario/{id}",Name ="RemoveProduto")]
        public ActionResult Remove(int id)
        {
            UsuariosDAO dao = new UsuariosDAO();
            Usuario usuario = dao.BuscaPorId(id);
            dao.Remover(usuario);
            return RedirectToRoute("todosUsuarios");
        }
        [Route("formularioUsuario",Name ="formulario")]
        public ActionResult Formulario()
        {
            Usuario usuario = new Usuario();
            TipoPessoaDAO daoPessoa = new TipoPessoaDAO();
            IList<TipoPessoa> tipos = new List<TipoPessoa>();
            tipos = daoPessoa.Lista();
            ViewBag.TipoPessoa = tipos;
            //viewbag usuario serve para comparação com a viewBag Tipo pessoa no combobox
            ViewBag.Usuario = usuario;
            ViewBag.Tela = "Cadastro Novo Usuário";
            return View("Edita",usuario);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Adiciona(Usuario usuario)
        {

            string valor = ViewBag.Perfil;
            if (ModelState.IsValid)
            {
                UsuariosDAO dao = new UsuariosDAO();
                if (usuario.Id > 0)
                {
                    dao.Atualiza(usuario);
                    
                }
                if (usuario.Id == 0)
                {
                    dao.Adicionar(usuario);
                    
                }
                return RedirectToRoute("todosUsuarios");
            }
            else
            {
                usuario = new Usuario();
                TipoPessoaDAO dao = new TipoPessoaDAO();
                IList<TipoPessoa> tipo = new List<TipoPessoa>();
                    tipo=dao.Lista();
                ViewBag.TipoPessoa = tipo;
                ViewBag.Usuario = usuario;
                
                ModelState.AddModelError("usuario.Nome", "*Campo Nome Obrigatório");
                ModelState.AddModelError("usuario.Email", "*Campo E-mail Obrigatório");

                


                return View("Edita",usuario);
            }
        }
        [Route("usuarios/{id}", Name = "VisualizaUsuario")]
        public ActionResult Vizualiza(int id)
        {
            UsuariosDAO dao = new UsuariosDAO();
            Usuario usuario = new Usuario();
            usuario= dao.BuscaPorId(id);
            ViewBag.Usuario = usuario;

            return View();
        }
        public ActionResult Lembrete()
        {
            
            return View();
        }
        
        public ActionResult Logout()
        {
            Session["logado"] = "";
            return RedirectToAction("Login","Usuario");
        }
        
    }
}