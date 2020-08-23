using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PrintListReports.Models;
using PrintListReports.Models.ViewModels;

namespace PrintListReports.Controllers
{
    public class ScriptController : Controller
    {
        private IReportRepository repository;
        private Script script;
        public ScriptController(IReportRepository repo, Script scriptService)
        {
            repository = repo;
            script = scriptService;
        }
        public ViewResult Index(string returnUrl)
        {
            return View(new ScriptIndexViewModel
            {
                Script = script,
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