using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xero.NetStandard.OAuth2.Model.Accounting;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Config;
using Microsoft.Extensions.Options;

namespace XeroNetStandardApp.Controllers
{
    public class PurchaseOrdersInfo : ApiAccessorController<AccountingApi>
    {

        public PurchaseOrdersInfo(IOptions<XeroConfiguration> xeroConfig) : base(xeroConfig) { }

        // GET: /PurchaseOrdersInfo/
        public async Task<IActionResult> Index()
        {
            var response = await Api.GetPurchaseOrdersAsync(XeroToken.AccessToken, TenantId, page: 1, pageSize: 100, order: "UpdatedDateUTC DESC");

            return View(response._PurchaseOrders);
        }
    }
}