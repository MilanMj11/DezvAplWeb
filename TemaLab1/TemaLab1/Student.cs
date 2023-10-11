using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaLab1
{
    internal class Student
    {
        public string nume;
        public string prenume;
        public int varsta;
        public int grupa;
        public double nota;

        public List<Materie> materii;

        public override string ToString()
        {
            string Afis_materii = "";
            foreach(var mat in materii)
            {
                Afis_materii = Afis_materii + mat.ToString() + "\n";
            }
            return $"Nume: {nume}, Prenume: {prenume}, Varsta: {varsta}, Grupa: {grupa}, Nota: {nota}\n" +
                   $"Materii: \n{Afis_materii}";
        }
        public Student(string nume, string prenume, int varsta, int grupa, double nota, List<Materie> materii)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.varsta = varsta;
            this.grupa = grupa;
            this.nota = nota;
            this.materii = materii;
        }
    }
}
