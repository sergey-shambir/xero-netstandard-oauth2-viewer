using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xero.NetStandard.OAuth2.Model.Accounting;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Config;
using Microsoft.Extensions.Options;

namespace XeroNetStandardApp.Controllers
{
    public class QuotesInfo : ApiAccessorController<AccountingApi>
    {
        public QuotesInfo(IOptions<XeroConfiguration> xeroConfig) : base(xeroConfig) { }

        // GET: /QuotesInfo/
        public async Task<IActionResult> Index()
        {
            var response = await Api.GetQuotesAsync(XeroToken.AccessToken, TenantId, page: 1, order: "UpdatedDateUTC DESC");

            return View(response._Quotes);
        }
    }
}