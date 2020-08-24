using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrintListReports.Infrastructure;
using PrintListReports.Models;
using PrintListReports.Models.ViewModels;

namespace PrintListReports.Controllers
{
    public class ScriptController : Controller
    {
        private IReportRepository repository;
        public ScriptController(IReportRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index(string returnUrl)
        {
            return View(new ScriptIndexViewModel
            {
                ReturnUrl = returnUrl
            });
        }
        public RedirectToActionResult OutExcel(int reportId, string returnUrl)
        {
            Report report = repository.Reports.FirstOrDefault(p => p.ReportID == reportId);
            if (report != null)
            {
                // выводим данные в Excel
                // script.GoExcel(report,....)
            }
            return RedirectToAction("Index", new { returnUrl });
        }
    }
}