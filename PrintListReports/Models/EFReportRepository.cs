using System.Collections.Generic;
using System.Linq;

namespace PrintListReports.Models
{
    public class EFReportRepository : IReportRepository
    {
        private ApplicationDbContext context;
        public EFReportRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Report> Reports => context.Reports;
    }
}
