using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class JSONBankApi:IBankInterface
    {
        public bool ExecuteTransaction(TransferTransaction transaction)
        {

            var json = $$"""" 
                        {
                            ""FromIban"":""{{transaction.FromIban}}"",
                            ""ToIban"":""{{transaction.ToIban}}"",
                            ""Amount"":""{{transaction.Amount:C2}}""
                        }
                        """";

            Console.WriteLine($"{GetType().Name} worked");
            return true;
                
        }
    }
}
