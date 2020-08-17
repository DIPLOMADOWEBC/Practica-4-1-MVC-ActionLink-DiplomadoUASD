using System.Web;
using System.Web.Mvc;

namespace Practica_4_1_MVC_ActionLink_DiplomadoUASD
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
