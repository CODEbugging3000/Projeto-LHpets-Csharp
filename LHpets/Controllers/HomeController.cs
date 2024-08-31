using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHpets.Models;

namespace LHpets.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //Intances of clients
        Cliente cliente1 = new Cliente(1, "Gustavo", "123.456.789-81", "jGnXf@example.com", "Bolt");
        Cliente cliente2 = new Cliente(2, "Gabriel", "123.192.789-12", "sadf@example.com", "Tóto");
        Cliente cliente3 = new Cliente(3, "Mario", "123.456.129-34", "ff2q@example.com", "Pretin");
        Cliente cliente4 = new Cliente(4, "Maria", "123.554.289-39", "afhjy@example.com", "Paçoca");
        Cliente cliente5 = new Cliente(5, "Otavio", "123.126.739-00", "asdf2@example.com", "Auau");

        //lista de clientes
        List<Cliente> clientes = new List<Cliente>();
        clientes.Add(cliente1);
        clientes.Add(cliente2);
        clientes.Add(cliente3);
        clientes.Add(cliente4);
        clientes.Add(cliente5);

        ViewBag.clientes = clientes;
        
        //Intances of fornecedores
        Fornecedor fornecedor1 = new Fornecedor(1, "Fornecimento1", "12.456.789/0001-38", "jGnXf@example.com");
        Fornecedor fornecedor2 = new Fornecedor(2, "Fornecimento2", "12.456.789/0001-38", "sadf@example.com");
        Fornecedor fornecedor3 = new Fornecedor(3, "Fornecimento3", "12.456.789/0001-38", "ff2q@example.com");
        Fornecedor fornecedor4 = new Fornecedor(4, "Fornecimento4", "12.456.789/0001-38", "afhjy@example.com");
        Fornecedor fornecedor5 = new Fornecedor(5, "Fornecimento5", "12.456.789/0001-38", "asdf2@example.com");
        
        //lista de fornecedores
        List<Fornecedor> fornecedores = new List<Fornecedor>();
        fornecedores.Add(fornecedor1);
        fornecedores.Add(fornecedor2);
        fornecedores.Add(fornecedor3);
        fornecedores.Add(fornecedor4);
        fornecedores.Add(fornecedor5);
        
        ViewBag.fornecedores = fornecedores;

        return View();
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
