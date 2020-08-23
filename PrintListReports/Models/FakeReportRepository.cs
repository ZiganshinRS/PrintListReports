using System.Collections.Generic;
using System.Linq;

namespace PrintListReports.Models
{
    public class FakeReportRepository : IReportRepository
    {
        public IQueryable<Report> Reports => new List<Report>
        {
            new Report { Name = "Отчёт 1" },
            new Report { Name = "Отчёт 2" },
            new Report { Name = "Отчёт 3" }
        }.AsQueryable<Report>();
    }
}
