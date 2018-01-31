using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechVirtusProvaEverton.DAO;
using TechVirtusProvaEverton.Filtros;
using TechVirtusProvaEverton.Models;

namespace TechVirtusProvaEverton.Controllers
{
    [AutorizacaoFilter]
    public class TipoServicoController : Controller
    {
      
        // GET: TipoServico
       [Route("tiposServicos",Name ="todosServ")]
        public ActionResult Index()
        {
            TipoServicoDAO dao = new TipoServicoDAO();
            IList<TipoServico> tipo=dao.Lista();
            ViewBag.TipoServico = tipo;
            return View();
        }
        [Route("formularioServico",Name ="formularioServ")]
        public ActionResult Formulario()
        {
            ViewBag.Tela = "Cadastro Novo Serviço";
            TipoServico tipo = new TipoServico();
            return View("Formulario",tipo);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Adiciona(TipoServico tipo)
        {
            
            if (ModelState.IsValid)
            {
                TipoServicoDAO dao = new TipoServicoDAO();
                if(tipo.Id>0)
                {
                    dao.Atualizar(tipo);
                                        
                    
                }
                if(tipo.Id==0)
                {
                    dao.Adicionar(tipo);
                    
                }
                return RedirectToRoute("todosServ");
            }
            else
            {

                ModelState.AddModelError("tipoServico.Invalido", "Lamentamos a incoviniencia, por favor verifique novamente as informações digitadas algo está invalido, obrigado..");
                
            }
             tipo = new TipoServico();
            return View("Formulario",tipo);

        }
        [Route("atualizaTipoServico/{id}", Name = "AtualizaTipoServ")]
        public ActionResult Edita(int id)
        {

            TipoServicoDAO dao = new TipoServicoDAO();
            TipoServico tipo = new TipoServico();
            tipo = dao.BuscarPorId(id);
            ViewBag.Tela = "Atualizando Serviço";

            return View("Formulario",tipo);
        }
        [Route("removeTipoServico/{id}", Name = "RemoveTipoServ")]
        public ActionResult Remove(int id)
        {
            TipoServicoDAO dao = new TipoServicoDAO();
            TipoServico tipo=dao.BuscarPorId(id);
            dao.Remover(tipo);

            return RedirectToRoute("todosServ");
        }
        [Route("tiposServicos/{id}", Name = "VisualizaServicos")]
        public ActionResult Vizualiza(int id)
        {
            TipoServicoDAO dao = new TipoServicoDAO();
            TipoServico tipo = new TipoServico();
            tipo = dao.BuscarPorId(id);

            ViewBag.TipoServico = tipo;

            return View();
        }
       
    }
}