using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    /* public string Index()
    {
        return "This is my default action...";
    } */
    /* response razor view template  */
    public IActionResult Index()
    {
        return View();
    }
    // GET: /HelloWorld/Welcome/ 
// Requires using System.Text.Encodings.Web;
    /* public string Welcome(string name, int numTimes = 1, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}, path Id : {ID}");
    } */
     public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
    public string Test2(string name, int ID=1) {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }
}