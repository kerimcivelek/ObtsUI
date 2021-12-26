using ObtsUI.Shared.Abstract;
using ObtsUI.Shared.Dto.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ObtsUI.Client.Services
{
    public class DashBoardService : IDashBoardService
    {
        private HttpClient _httpClient;
        public DashBoardService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public Task<DashboardListDto[]> OperataionTypeReport(int CompanyId)
        {
            return _httpClient.GetFromJsonAsync<DashboardListDto[]>("DashBoards/operataiontypereport?CompanyId=" + CompanyId);
        }

     

        public Task<DashboardListDto[]> ProductByCategoryReport(int CompanyId)
        {
            return _httpClient.GetFromJsonAsync<DashboardListDto[]>("DashBoards/productbycategoryreport?CompanyId=" + CompanyId);
        }

     
        public Task<DashboardTotalDayDto> TotalDashboardInfoDay(int CompanyId)
        {
            return _httpClient.GetFromJsonAsync<DashboardTotalDayDto>("DashBoards/dailydashboard?CompanyId=" + CompanyId);
        }

        public Task<DashboardTotalMonthDto> TotalDashboardInfoMonth(int CompanyId)
        {
            return _httpClient.GetFromJsonAsync<DashboardTotalMonthDto>("DashBoards/monthlydashboard?CompanyId=" + CompanyId);
        }

        public Task<DashboardListDto[]> ProductByCategoryReportSelectedDate(int CompanyId, string StartDate, string EndDate)
        {
            return _httpClient.GetFromJsonAsync<DashboardListDto[]>("DashBoards/productbycategoryreportselecteddate?CompanyId=" + CompanyId + "&StartDate="+StartDate+ "&EndDate="+EndDate);
        }
        public Task<DashboardListDto[]> OperataionTypeReportSelectedDate(int CompanyId, string StartDate, string EndDate)
        {
            return _httpClient.GetFromJsonAsync<DashboardListDto[]>("DashBoards/operataiontypereportselecteddate?CompanyId=" + CompanyId + "&StartDate=" + StartDate + "&EndDate=" + EndDate);
        }
    }
}
