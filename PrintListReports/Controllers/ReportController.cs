using Microsoft.AspNetCore.Mvc;
using PrintListReports.Models;
using System.Linq;
using PrintListReports.Models.ViewModels;

namespace PrintListReports.Controllers
{
    public class ReportController : Controller
    {
        private IReportRepository repository;
        public int PageSize = 5;
        public ReportController(IReportRepository repo)
        {
            repository = repo; ;
        }
        public ViewResult List(int reportPage = 1) 
            => View(new ReportsListViewModel
            {
                Reports = repository.Reports
                    .OrderBy(p => p.ReportID)
                    .Skip((reportPage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = reportPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Reports.Count()
                }
            });
    }
}
