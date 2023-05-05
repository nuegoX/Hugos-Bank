using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugos_Bank
{
    internal class Transaction
    {
        DateTime dateTime;
        float Amount;
        String ReceiverAccount;
        String SenderAccount;

        public Transaction(DateTime dateTime, float Amount, String ReceiverAccount, String SenderAccount) {
            this.dateTime = dateTime;
            this.Amount = Amount;
            this.ReceiverAccount = ReceiverAccount;
            this.SenderAccount = SenderAccount;
        }
    }
}
