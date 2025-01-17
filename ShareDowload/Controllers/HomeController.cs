using Microsoft.AspNetCore.Mvc;
using ShareDowload.Models;
using System.Diagnostics;

namespace ShareDowload.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        // Método para realizar o download do arquivo
        //public FileResult Download()
        //{
        //    byte[] fileBytes = System.IO.File.ReadAllBytes(@"C:\Users\fqcintra\Documents\Comunicação(BD - CONTRATOS).csv");
        //    string fileName = "myfile.csv";
        //    return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        //}
        public IActionResult DownloadFile()
        {

            byte[] fileBytes = System.IO.File.ReadAllBytes(@"C:\Users\fqcintra\Documents\Comunicação(BD - CONTRATOS).csv");
            string fileName = "myfile.csv";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
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
}
