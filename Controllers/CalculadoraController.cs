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
        
        switch(operacao)
        {
            case "Soma":
                ViewBag.Titulo = "Soma";
                ViewBag.Operacao = "+";
                ViewBag.Resultado = n1 + n2;
                break;
        
            case "Subtração": 
                ViewBag.Titulo = "Subtração";
                ViewBag.Operacao = "-";
                ViewBag.Resultado = n1-n2;
                break;
            
            case "Multiplicação":
                ViewBag.Titulo = "Multiplicação";
                ViewBag.Operacao = "*";
                ViewBag.Resultado = n1*n2;
                break;
            
            case "Divisão":
                ViewBag.Titulo = "Divisão";
                ViewBag.Operacao = "÷";
                ViewBag.Resultado = n1/n2;
                break;

            default:
                ViewBag.Titulo = "Operação inválida.";
                ViewBag.Resultado = "Escolha outra operação...";
                break;
        }

        return View();
    }
}
