using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Class1: Interface1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Value1 { get; set; } = 1;

        public int Value2 { get; set; } = 2;

        private int Value3 { get; set; } = 2;

        protected int Value4 { get; set; } = 2;


        private protected int Value5 { get; set; } = 2;

        internal int Value6 { get; set; }

        protected internal int Value7 { get; set; }

        public List<string> Tags { get; set; }

        

    }
}
