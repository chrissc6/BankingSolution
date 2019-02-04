using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class Customer : IPrintable
    {
        public string Name { get; set; }

        public string Print()
        {
            return $"Customer name is:{Name}";
        }

        public Customer(string name)
        {
            Name = name;
        }
    }
}
