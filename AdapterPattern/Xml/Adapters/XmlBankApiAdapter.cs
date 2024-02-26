using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Xml.Adapters
{
    public class XmlBankApiAdapter : IBankInterface
    {
        private readonly XMLBankAPi xmlBankApi;

        public XmlBankApiAdapter()
        {
            xmlBankApi = new();
        }

        public bool ExecuteTransaction(TransferTransaction transaction)
        {
            return xmlBankApi.ExecuteTransaction(transaction);
        }
    }
}
