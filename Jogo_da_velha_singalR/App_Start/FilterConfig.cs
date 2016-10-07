using System.Web;
using System.Web.Mvc;

namespace Jogo_da_velha_singalR
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
