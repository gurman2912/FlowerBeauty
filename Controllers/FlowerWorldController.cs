using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace FlowerBeauty.Controllers
{
    public class FlowerWorldController : Controller
    {
        //GET: /FlowerWorld
        /*public string Index()
        {
            return "This is my default action....";
        }*/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /FlowerWorld/Welcome/ 

        /*public string Welcome()
        {
            return "This is the Welcome action method...";
        }*/
        /* public string Welcome(string name, int ID = 1)
         {
             return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
         }*/

        //add IActionResult method for getting welcome massage with name and numtime parameter
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
