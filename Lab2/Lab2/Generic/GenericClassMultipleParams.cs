using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Generic
{
    internal class GenericClassMultipleParams<Tkey, Tvalue>
    {
        public Tkey? Key { get; set; }
        public Tvalue Value { get; set; } = default;
    }
}
