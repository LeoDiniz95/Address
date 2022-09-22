using Correios.Net;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Runtime.ConstrainedExecution;

namespace Address.General
{
    public class GetAddress
    {
        [HttpGet]
        public GeneralResult GetAdress(string cep)
        {
            GeneralResult result = new GeneralResult();

            try
            {
                var endereco = SearchZip.GetAddress(cep.Replace(".","").Replace("-",""));
                result.Data = endereco;
            }
            catch(Exception ex)
            {
                result.AddError(ex.Message);
            }

            return result;
        }
    }
}
