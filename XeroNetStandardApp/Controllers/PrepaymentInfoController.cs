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
    public class PrepaymentInfo : ApiAccessorController<AccountingApi>
    {
        public PrepaymentInfo(IOptions<XeroConfiguration> xeroConfig) : base(xeroConfig) { }

        // GET: /PrepaymentInfo/
        public async Task<IActionResult> Index()
        {
            var response = await Api.GetPrepaymentsAsync(XeroToken.AccessToken, TenantId, pageSize: 100, page: 1, order: "UpdatedDateUTC DESC");

            return View(response._Prepayments);
        }
    }
}