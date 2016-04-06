using Microsoft.AspNet.Mvc;


namespace Angular2WebApiDemo.Controllers
{
    public class PartialController : Controller
    {
        public IActionResult Message() => PartialView();

        public IActionResult Numbers() => PartialView();
    }
}