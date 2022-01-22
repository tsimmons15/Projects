using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCheck.RandomStuff
{
    public class Bank
    {
        public Bank(BankSettings config)
        {
            if (config == null)
            {
                throw new ArgumentNullException(nameof(config));
            }

            AccountNumber = config.AccountNumber;
            Name = config.Name;
        }

        public Guid AccountNumber { get; protected set; }
        public string Name { get; protected set; }
    }

    public class BankSettings
    {
        public Guid AccountNumber { get; set; }
        public string Name { get; set; }
    }
}
