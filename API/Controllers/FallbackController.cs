using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class FallbackController : Controller // Contains view support for html files
    {
        public IActionResult Index()
        {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "index.html"), "text/HTML");
        }
    }
}