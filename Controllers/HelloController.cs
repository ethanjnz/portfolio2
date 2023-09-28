using Microsoft.AspNetCore.Mvc;
namespace firstWeb.Controllers;

public class HelloController : Controller
{
    [HttpGet("")]
    public ViewResult Index()
    {
        return View("Index");
    }

    [HttpGet("projects")]
    public string Projects()
    {
        return "These are my projects";
    }

    [HttpGet("contact")]
    public string Contact()
    {
        return "This is my Contact";
    }

}