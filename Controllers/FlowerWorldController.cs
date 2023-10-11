using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace FlowerBeauty.Controllers
{
    public class FlowerWorldController : Controller
    {
        //GET: /FlowerWorld
        public string Index()
        {
            return "This is my default action....";
        }
    }
}
