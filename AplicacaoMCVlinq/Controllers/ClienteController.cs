using AplicacaoMVCLinq.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoMVCLinq.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetClientes()
        {
            List<Clientes> listaClientes = new List<Clientes>();

            Clientes c1 = new Clientes(1, "Alice", "alice@example.com", "1234-5678", new DateOnly(2000, 6, 1));
            listaClientes.Add(c1);
            Clientes c2 = new Clientes(2, "Bob", "bob@example.com", "2345-6789", new DateOnly(2001, 10, 06));
            listaClientes.Add(c2);
            Clientes c3 = new Clientes(3, "Charlie", "charlie@example.com", "3456-7890", new DateOnly(1999, 01, 30));
            listaClientes.Add(c3);
            Clientes c4 = new Clientes(4, "Eve", "eve@example.com", "3456-7890", new DateOnly(1999, 01, 30));
            listaClientes.Add(c4);
            Clientes c5 = new Clientes(5, "David", "david@example.com", "4567-8901", new DateOnly(2000, 12, 15));
            listaClientes.Add(c5);

            return View(listaClientes);
        }
    }
}
