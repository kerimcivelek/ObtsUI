using ObtsUI.Shared.Dto.Dashboard;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ObtsUI.Shared.Abstract
{
  public interface IDashBoardService
    {
        Task<DashboardTotalDayDto> TotalDashboardInfoDay(int CompanyId);
        Task<DashboardTotalMonthDto> TotalDashboardInfoMonth(int CompanyId);
        Task<DashboardListDto[]> OperataionTypeReport(int CompanyId);
        Task<DashboardListDto[]> ProductByCategoryReport(int CompanyId);

        Task<DashboardListDto[]> OperataionTypeReportSelectedDate(int CompanyId, string StartDate, string EndDate);
        Task<DashboardListDto[]> ProductByCategoryReportSelectedDate(int CompanyId, string StartDate, string EndDate);
    }
}
