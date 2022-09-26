using Microsoft.AspNetCore.Mvc;

namespace CalculadoraMvc.Controllers;

public class CalculadoraController : Controller
{
    public IActionResult Calcular()
    {
        return View();
    } 
    
    public IActionResult Resultado([FromForm] double n1, [FromForm] double n2, [FromForm] string operacao)
    {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Operacao = operacao;
        
        switch(operacao)
        {
            case "Soma":
                ViewBag.Titulo = "Soma";
                ViewBag.Resultado = $"O resultado de {ViewBag.N1} + {ViewBag.N2} é {ViewBag.N1 + ViewBag.N2}";
                break;
        
            case "Subtração": 
                ViewBag.Titulo = "Subtração";
                ViewBag.Resultado = $"O resultado de {ViewBag.N1} - {ViewBag.N2} é {ViewBag.N1 - ViewBag.N2}";
                break;
            
            case "Multiplicação":
                ViewBag.Titulo = "Multiplicação";
                ViewBag.Resultado = $"O resultado de {ViewBag.N1} * {ViewBag.N2} é {ViewBag.N1 * ViewBag.N2}";
                break;
            
            case "Divisão":
                ViewBag.Titulo = "Divisão";
                ViewBag.Resultado = $"O resultado de {ViewBag.N1} ÷ {ViewBag.N2} é {ViewBag.N1 / ViewBag.N2}";
                break;

            default:
                ViewBag.Titulo = "Operação inválida.";
                ViewBag.Resultado = "Escolha outra operação...";
                break;
        }

        return View();
    }
}