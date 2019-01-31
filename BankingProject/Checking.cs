using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class Checking : Account
    {
        //data---
        private int NextCheckNbr { get; set; } = 1; //different than id, because each checking acct have own checknbr

        public int GetNextCheckNbr()
        {
            return NextCheckNbr;
        }

        public override string Print()
        {
            return base.Print() + $", Next Check Number = {NextCheckNbr}";
        }

        //constructors---
        public Checking(string NewDescription) : base(NewDescription)
        { }

        public Checking() : this(null)
        { }
    }
}
