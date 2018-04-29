using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(); // Renvoie une reponse HTML au navigateur
            // Renvie La vue Index.cshtml
        }

        // GET : /Helloworld

        //public string Index()
        //{
        //    return "This is my default action..";
        //}

        //
        //// GET/: /HelloWorld/Welcome
        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is {numTimes}");
        //}

        ////// GET/: /HelloWorld/Welcome
        //// http://localhost:50386/HelloWorld/Welcome/41?name=Axel
        //// Hello Axel, ID:41
        //public string Welcome(string name, int ID = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID:{ID}");
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="numTimes"></param>
        /// <returns>IActionResult : Vue</returns>
        public IActionResult  Welcome(string name, int numTimes=1)
        {
            ViewData["Message"] = $"Hello {name}";
            ViewData["Numtimes"] = numTimes;
            return View();

        }



    }
}
