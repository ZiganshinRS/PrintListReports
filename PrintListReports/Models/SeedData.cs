using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace PrintListReports.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Reports.Any())
            {
                context.Reports.AddRange(
                    new Report
                    {
                        Name = "Отчёт 1",
                        Description = "Описание для отчёта 1"
                    },
                    new Report
                    {
                        Name = "Отчёт 2",
                        Description = "Описание для отчёта 2"
                    },
                    new Report
                    {
                        Name = "Отчёт 3",
                        Description = "Описание для отчёта 3"
                    },
                    new Report
                    {
                        Name = "Отчёт 4",
                        Description = "Описание для отчёта 4"
                    },
                    new Report
                    {
                        Name = "Отчёт 5",
                        Description = "Описание для отчёта 5"
                    },
                    new Report
                    {
                        Name = "Отчёт 6",
                        Description = "Описание для отчёта 6"
                    },
                    new Report
                    {
                        Name = "Отчёт 7",
                        Description = "Описание для отчёта 7"
                    },
                    new Report
                    {
                        Name = "Отчёт 8",
                        Description = "Описание для отчёта 8"
                    },
                    new Report
                    {
                        Name = "Отчёт 9",
                        Description = "Описание для отчёта 9"
                    },
                    new Report
                    {
                        Name = "Отчёт 10",
                        Description = "Описание для отчёта 10"
                    },
                    new Report
                    {
                        Name = "Отчёт 11",
                        Description = "Описание для отчёта 11"
                    },
                    new Report
                    {
                        Name = "Отчёт 12",
                        Description = "Описание для отчёта 12"
                    });
                context.SaveChanges();
            }
        }
    }
}
