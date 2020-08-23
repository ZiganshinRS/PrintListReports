using System.Collections.Generic;
using PrintListReports.Models;

namespace PrintListReports.Models.ViewModels
{
    public class ReportsListViewModel
    {
        public IEnumerable<Report> Reports { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
