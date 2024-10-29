using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xero.NetStandard.OAuth2.Model.Accounting;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Config;
using Microsoft.Extensions.Options;

namespace XeroNetStandardApp.Controllers
{
    public class EmployeesInfo : ApiAccessorController<AccountingApi>
    {

        public EmployeesInfo(IOptions<XeroConfiguration> xeroConfig) : base(xeroConfig) { }

        // GET: /EmployeesInfo/
        public async Task<IActionResult> Index()
        {
            var response = await Api.GetEmployeesAsync(XeroToken.AccessToken, TenantId, order: "UpdatedDateUTC DESC");

            return View(response._Employees);
        }
    }
}