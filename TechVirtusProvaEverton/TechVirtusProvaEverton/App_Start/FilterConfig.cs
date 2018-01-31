using System.Web;
using System.Web.Mvc;
using TechVirtusProvaEverton.Filtros;

namespace TechVirtusProvaEverton
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new AutorizacaoFilterAttribute());
            
        }
    }
}
