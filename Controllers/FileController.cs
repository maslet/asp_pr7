using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace usov_402_pr7.Controllers
{
    public class FileController : Controller
    {
        [HttpGet]
        public IActionResult DownloadFile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DownloadFile(string firstName, string lastName, string fileName)
        {
            var content = $"Ім'я: {firstName}\nПрізвище: {lastName}";
            return File(Encoding.UTF8.GetBytes(content), "text/plain", $"{fileName}.txt");
        }
    }
}