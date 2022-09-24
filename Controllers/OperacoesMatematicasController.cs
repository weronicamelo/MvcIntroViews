using Microsoft.AspNetCore.Mvc;

namespace MvcIntroViews.Controllers;

public class OperacoesMatematicasController : Controller
{
    public IActionResult Somar()
    {
        return View();
    }

    public IActionResult Subtrair()
    {
        return View();
    }

    public IActionResult Multiplicar()
    {
        return View();
    }

    public IActionResult Dividir()
    {
        return View();
    }

    public IActionResult ResultadoSoma([FromForm] double n1, [FromForm] double n2)
    {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Resultado = n1 + n2;

        return View();
    }

    public IActionResult ResultadoSubtracao([FromForm] double n1, [FromForm] double n2)
    {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Resultado = n1 - n2;

        return View();
    }

    public IActionResult ResultadoMultiplicacao([FromForm] double n1, [FromForm] double n2)
    {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Resultado = n1 * n2;

        return View();
    }

    public IActionResult ResultadoDivisao([FromForm] double n1, [FromForm] double n2)
    {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Resultado = n1 / n2;

        return View();
    }
}