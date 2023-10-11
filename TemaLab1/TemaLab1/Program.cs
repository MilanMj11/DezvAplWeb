using System.Collections.Specialized;
using TemaLab1;

Console.WriteLine("Hello, World!");


var materie1 = new Materie("Algebra", "2 ore", 35);
var materie2 = new Materie("Probabilitati", "3 ore", 40);
var materie3 = new Materie("Programare Functionala", "2 ore", 38);
var materie4 = new Materie("Sisteme de Operare", "4 ore", 42);
var materie5 = new Materie("Baze de Date", "2 ore", 34);
var materie6 = new Materie("Geometrie", "1 ora", 30);

List<Materie> lista1 = new List<Materie> { materie1, materie2, materie3 };
List<Materie> lista2 = new List<Materie> { materie3, materie2, materie4 };
List<Materie> lista3 = new List<Materie> { materie3, materie5, materie4, materie6 };
List<Materie> lista4 = new List<Materie> { materie1, materie3, materie5, materie6 };

var student1 = new Student("Mihai", "Dragos",19,234,9.2,lista1);
var student2 = new Student("Pop", "Alexandru", 20, 331, 8.7, lista2);
var student3 = new Student("Popescu", "Adrian", 19, 232, 7.9, lista3);
var student4 = new Student("Pricop", "Robert", 18, 133, 9.4, lista4);

List<Student> studenti = new List<Student> { student1, student2, student3, student4 };

for(int i = 0; i < 4; i++)
{
    Console.WriteLine(studenti[i]);
}
