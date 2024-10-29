using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xero.NetStandard.OAuth2.Model.Accounting;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Config;
using Microsoft.Extensions.Options;

namespace XeroNetStandardApp.Controllers
{
    public class LinkedTransactionsInfo : ApiAccessorController<AccountingApi>
    {
        public LinkedTransactionsInfo(IOptions<XeroConfiguration> xeroConfig) : base(xeroConfig) { }

        // GET: /LinkedTransactionsInfo/
        public async Task<IActionResult> Index()
        {
            var response = await Api.GetLinkedTransactionsAsync(XeroToken.AccessToken, TenantId, page: 1);

            return View(response._LinkedTransactions);
        }
    }
}