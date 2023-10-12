using Lab2.Generic;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

Console.WriteLine("Hello, World!");

/// Generic
/// 

GenericClass<string> genericClassWithString = new()
{
    Value = "abc"
};

GenericClass<int> genericClassWithInt = new()
{
    Value = 123
};

Console.WriteLine(genericClassWithString.Value);
Console.WriteLine(genericClassWithInt.Value);

GenericClassMultipleParams<int, string> genericMulti = new()
{
    Key = 456,
    Value = "Value: 456"
};


string objectSerialized = JsonConvert.SerializeObject(genericMulti);
Console.WriteLine(objectSerialized);

Tuple<int, string, string> tupleExample = new Tuple<int, string, string>(1, "ABC", "value 1");
var tupleExample2 = Tuple.Create(2, "bdc", "value 2");
Tuple<int, string, string, int> tupleExample3 = new(3, "ddd", "value 3,8", 8); /// 8 maxim values;

int sum(int a,int b,int c = 10)
{
    return a + b + c;
}

Console.WriteLine(sum(1, 2));
Console.WriteLine(sum(1, 2, 3));

/// ref

void sumWithRef(int a,int b,ref int c)
{
    c = a + b;
}

int num = 2;
sumWithRef(4, 5, ref num);
Console.WriteLine(num);

// out
void sumWithOut(int a,int b,out int c)
{
    c = a + b;
}

int c;
sumWithOut(4, 4, out c);
Console.WriteLine(c);

var objectWithNoClass = new { Title = "abc", Size = 23 };
dynamic student = new { LastName = "Student Last Name 1", Grupa = "24" };