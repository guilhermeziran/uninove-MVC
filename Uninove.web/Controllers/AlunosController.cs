using Microsoft.AspNetCore.Mvc;
public class AlunosController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Nome = "Guilherme";
        ViewBag.Curso = "ADS";
        ViewBag.Semestre = "Primeiro-Semestre";
        return View();
    }

    public IActionResult Detalhes(int id)
    {
        ViewBag.Alunoid = id;
        return View();
    }
}