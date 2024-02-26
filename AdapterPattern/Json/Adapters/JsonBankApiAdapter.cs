using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Json.Adapters
{
    public class JsonBankApiAdapter : IBankInterface
    {
        private readonly JSONBankApi jsonBankApi;

        public JsonBankApiAdapter()
        {
            jsonBankApi = new JSONBankApi();
        }

        public bool ExecuteTransaction(TransferTransaction transaction)
        {
            return jsonBankApi.ExecuteTransaction(transaction);
        }
    }
}
