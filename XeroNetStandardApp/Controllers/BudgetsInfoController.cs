using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xero.NetStandard.OAuth2.Model.Accounting;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Config;
using Microsoft.Extensions.Options;

namespace XeroNetStandardApp.Controllers
{
    public class BudgetsInfo : ApiAccessorController<AccountingApi>
    {
        public BudgetsInfo(IOptions<XeroConfiguration> xeroConfig) : base(xeroConfig) { }

        // GET: /BudgetsInfo/
        public async Task<IActionResult> Index()
        {
            var response = await Api.GetBudgetsAsync(XeroToken.AccessToken, TenantId);

            return View(response._Budgets);
        }
    }
}