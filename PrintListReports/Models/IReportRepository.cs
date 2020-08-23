using System.Linq;

namespace PrintListReports.Models
{
    public interface IReportRepository
    {
        IQueryable<Report> Reports { get; }
    }
}
