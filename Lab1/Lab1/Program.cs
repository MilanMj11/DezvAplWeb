// See https://aka.ms/new-console-template for more information
using Lab1;

Console.WriteLine("Hello, World!");

var a = new object[] { 1, 2, 3 };
var b = new object[] {"a", "b", "c"};


for (int i = 0; i < a.Length; i++)
{
    Console.WriteLine(a[i]);
}

foreach(string i in b)
{
    Console.WriteLine(i);
}

var classObject1 = new Class1();
classObject1.FirstName = "FirstName 1";
classObject1.LastName = "LastName 1";

Console.WriteLine(classObject1.CompleteName);
Console.WriteLine(classObject1.ToString());
classObject1.Method1();
//Console.WriteLine()