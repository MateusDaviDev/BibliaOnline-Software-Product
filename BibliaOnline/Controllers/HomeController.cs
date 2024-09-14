using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BibliaOnline.Models;
using BibliaOnline.Services;

namespace BibliaOnline.Controllers;

public class HomeController : Controller
{
    private readonly IBibliaService _biblia;

    public HomeController(IBibliaService biblia)
    {
        _biblia = biblia ;
    }

    [HttpGet("/")]
    public async Task<IActionResult> Index()
    {
        
        return View(await _biblia.GetRondomVerse());
    }

    public async Task<IActionResult> Books()
    {
        return View(await _biblia.GetBooks());
    }

    
    
    public async Task<IActionResult> Book(string livro,string capitulos,string capitulo)
    {
        ViewBag.capitulo = capitulo;
        ViewBag.Livro = livro;
        ViewBag.Capitulos = Convert.ToInt32(capitulos);
        return View(await _biblia.GetBook(livro,capitulos,capitulo));
    }

   
    public IActionResult Sobre()
    {
        return View();
    }


 
}