using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class XMLBankAPi:IBankInterface
    {
        public bool ExecuteTransaction(TransferTransaction transaction)
        {

            var xml = $"""
                    <TransferTransaction>
                    <FromIBAN>{transaction.FromIban} </FromIBAN>
                    <ToIBAN>{transaction.ToIban}</TOIBAN>
                    <Amount>{transaction.Amount: C2} </Amount>
                    </TransferTransaction>
                    """;

            Console.WriteLine($"{GetType().Name} worked");
            return true;
                
        }
    }
}
