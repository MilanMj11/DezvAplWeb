using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaLab1
{
    internal class Materie
    {
        public string titlu;
        public string durata;
        public int nr_credite;

        public override string ToString()
        {
            return $"Titlu: {titlu}, Durata: {durata}, Numar Credite: {nr_credite}";
        }
        public Materie(string titlu, string durata, int nr_credite)
        {
            this.titlu = titlu;
            this.durata = durata;
            this.nr_credite = nr_credite;
        }
    }
}
