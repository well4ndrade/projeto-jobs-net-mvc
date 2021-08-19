using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projeto_jobs_net_mvc.Models;
using projeto_jobs_net_mvc.Servicos;

namespace projeto_jobs_net_mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // INDEX PARA VAGAS

        public async Task<IActionResult> Index()
        {
            ViewBag.Vagas = await VagaApiService.GetVagas();
            return View();
            
        }

        // INDEX PARA USUÁRIOS

        // public async Task<IActionResult> Index()
        // {
        //     ViewBag.Usuarios = await UsuarioApiService.GetUsuarios();
        //     return View();
            
        // }

        // INDEX PARA ENDEREÇOS

        // public async Task<IActionResult> Index()
        // {
        //     ViewBag.Enderecos = await EnderecoApiService.GetEnderecos();
        //     return View();
            
        // }

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
}
