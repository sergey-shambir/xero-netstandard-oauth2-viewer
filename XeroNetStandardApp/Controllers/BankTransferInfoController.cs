using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Config;
using Microsoft.Extensions.Options;


namespace XeroNetStandardApp.Controllers
{
    public class BankTransfersInfo : ApiAccessorController<AccountingApi>
    {

        public BankTransfersInfo(IOptions<XeroConfiguration> xeroConfig) : base(xeroConfig) { }

        // GET: /BankTransfersInfo/
        public async Task<IActionResult> Index()
        {
            var response = await Api.GetBankTransfersAsync(XeroToken.AccessToken, TenantId, order: "CreatedDateUTC DESC");

            return View(response._BankTransfers);
        }
    }
}