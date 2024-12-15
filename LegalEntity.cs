using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_movies_
{
    public abstract class LegalEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public BankAccount BankAccount { get; set; }
        public string TaxId { get; set; }

        protected LegalEntity()
        {
        }

        protected LegalEntity(string name, string address, BankAccount bankAccount, string taxId)
        {
            Name = name;
            Address = address;
            BankAccount = bankAccount;
            TaxId = taxId;
        }

        
    }
}
