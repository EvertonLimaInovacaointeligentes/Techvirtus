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
    public class EmpresaController : Controller
    {
        
        private IList<Empresa> empresas;
        // GET: Empresa
        [Route("empresas",Name ="todasEmpresas")]
        public ActionResult Index()
        {
            empresas = new List<Empresa>();                
            EmpresaDAO dao = new EmpresaDAO();
            empresas = dao.Lista();
            
            return View(empresas);
            
        }
        [Route("formularioEmpresa",Name ="formularioEmp")]    
        
        public ActionResult Formulario()
        {
            ViewBag.Tela = "Cadastro Empresa";
            Empresa empresa = new Empresa();

            TipoServicoDAO daoTipo=new TipoServicoDAO();
            
            return View("Formulario", empresa);
        }
        [Route("atualizaEmpresa/{id}",Name ="AtualizaEmp")]
        public ActionResult Edita(int id)
        {
            EmpresaDAO dao = new EmpresaDAO();
            Empresa empresa = dao.BuscaEmpresaId(id);          
            ViewBag.Tela = "Atualizando Usuário";
            return View("Formulario",empresa);
        }
        [Route("removeEmpresa/{id}",Name ="RemoveEmp")]
        public ActionResult Remove(int id)
        {
            EmpresaDAO dao = new EmpresaDAO();
            Empresa empresa = dao.BuscaEmpresaId(id);
            dao.Remover(empresa);
            return RedirectToRoute("todasEmpresas"); ;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Adicionar(Empresa empresa)
        {
            
            if(ModelState.IsValid)
            {
                EmpresaDAO dao = new EmpresaDAO();
                if(empresa.Id>0)
                {
                    dao.Atualizar(empresa);
                }
                if(empresa.Id==0)
                {
                    dao.Adicionar(empresa);
                }
                return RedirectToRoute("todasEmpresas");
            }
            else
            {
              
                ModelState.AddModelError("Dados.Invalidos", "Lamentamos a incoviniencia, por favor verifique novamente as informações digitadas algo está invalido, obrigado..");
                return View("Formulario", empresa);
            }
                                    
        }
        [Route("empresas/{id}", Name = "VisualizaEmpresas")]
        public ActionResult Vizualiza(int id)
        {
            EmpresaDAO dao = new EmpresaDAO();
            Empresa empresa = new Empresa();
            empresa = dao.BuscaEmpresaId(id);

            ViewBag.Empresa = empresa;

            return View();
        }
        
    }
    
}