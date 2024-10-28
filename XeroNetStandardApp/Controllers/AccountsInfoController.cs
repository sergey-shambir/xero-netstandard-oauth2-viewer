using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xero.NetStandard.OAuth2.Model.Accounting;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Config;
using Microsoft.Extensions.Options;

namespace XeroNetStandardApp.Controllers
{
    public class AccountsInfo : ApiAccessorController<AccountingApi>
    {

        public AccountsInfo(IOptions<XeroConfiguration> xeroConfig) : base(xeroConfig) { }

        // GET: /AccountsInfo/
        public async Task<IActionResult> Index()
        {
            var response = await Api.GetAccountsAsync(XeroToken.AccessToken, TenantId, where: "Type=\"BANK\"");

            return View(response._Accounts);
        }
    }
}