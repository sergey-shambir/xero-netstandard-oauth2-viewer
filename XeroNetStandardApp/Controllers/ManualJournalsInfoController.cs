using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xero.NetStandard.OAuth2.Model.Accounting;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Config;
using Microsoft.Extensions.Options;

namespace XeroNetStandardApp.Controllers
{
    public class ManualJournalsInfo : ApiAccessorController<AccountingApi>
    {
        public ManualJournalsInfo(IOptions<XeroConfiguration> xeroConfig) : base(xeroConfig) { }

        // GET: /ManualJournalsInfo/
        public async Task<IActionResult> Index()
        {
            var response = await Api.GetManualJournalsAsync(XeroToken.AccessToken, TenantId, page: 1, pageSize: 100, order: "UpdatedDateUTC DESC");

            return View(response._ManualJournals);
        }
    }
}