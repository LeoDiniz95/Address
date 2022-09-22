using Microsoft.AspNetCore.Mvc;
using Address.General;

namespace Address.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        [HttpPost]
        public GeneralResult GetAddress(string cep)
        {
            GetAddress getAddress = new GetAddress();
            return getAddress.GetAdress(cep);
        }
    }
}
