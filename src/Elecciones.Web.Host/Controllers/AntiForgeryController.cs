using Microsoft.AspNetCore.Antiforgery;
using Elecciones.Controllers;

namespace Elecciones.Web.Host.Controllers
{
    public class AntiForgeryController : EleccionesControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
