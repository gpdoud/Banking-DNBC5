using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject {
    class Checking : Account {

        private int NextCheckNbr { get; set; } = 1;

        public override string Print() {
            return base.Print() + $", NextCheckNbr={NextCheckNbr}";
        }

        public int GetNextCheckNbr() {
            return NextCheckNbr;
        }

        public Checking(string NewDescription) : base(NewDescription) {

        }
        public Checking() : this(null) {

        }
    }
}
