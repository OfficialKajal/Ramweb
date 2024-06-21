using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

public class HomeController : Controller
{
    public IActionResult Index()
    {
       

        return View();
    }

    
}
