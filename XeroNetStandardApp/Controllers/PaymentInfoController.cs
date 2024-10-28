using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xero.NetStandard.OAuth2.Model.Accounting;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Config;
using Microsoft.Extensions.Options;

namespace XeroNetStandardApp.Controllers
{
    public class PaymentInfo : ApiAccessorController<AccountingApi>
    {
        public PaymentInfo(IOptions<XeroConfiguration> xeroConfig) : base(xeroConfig) { }

        // GET: /PaymentInfo/
        public async Task<IActionResult> Index()
        {
            var response = await Api.GetPaymentsAsync(XeroToken.AccessToken, TenantId, pageSize: 100, page: 1, order: "UpdatedDateUTC DESC");

            return View(response._Payments);
        }
    }
}