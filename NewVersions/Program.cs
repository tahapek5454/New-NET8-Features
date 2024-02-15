#region using
using NewVersions;
using System.ComponentModel;

using Peronals = System.Collections.Generic.List<NewVersions.Personal>;
using Customer = System.ValueTuple<int, string>;

using System.Diagnostics.CodeAnalysis;
using NewVersions.InterfaceExample;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Collections.Frozen;
using System.Xml.Linq;
#endregion


#region 01-) Primary Constructors
MyClass myClass = new MyClass(5);

Console.WriteLine(myClass.Sayi);
#endregion

#region 02-) Collection Expressions
// c# 12 oncesi
List<User> users = new List<User>();
// veya
var users2 = new List<User>();
// veya
List<User> user = new();

// c# 12 sonrasi
List<User> newUsers = [
        new User()
        {
            Name = "Taha"
        }
    ];

Console.WriteLine(newUsers.FirstOrDefault().Name);


// C# 12 öncesinde
string[] statusCodes = new string[] { "SUCCESS", "WARNING", "DANGER" };

// C# 12 ile
string[] statusCodes2 = ["SUCCESS", "WARNING", "DANGER"];



#endregion

#region 03-) Varsayılan Lambda Parametreleri

var getFullName = (string firstName, string lastName) => string.Join(" ", firstName, lastName);
var fullName1 = getFullName("Taha", "");
var fullName2 = getFullName("Taha", "Pek");

var getFullName2 = (string firstName, string lastName = "") => string.Join(" ", firstName, lastName);
var fullName11 = getFullName2("Taha"); // lastName parametresi isteğe bağlı
var fullName22 = getFullName2("Taha", "Pek");

Console.WriteLine(fullName11);

#endregion

#region 04-) Takma Ad Atamaları

Peronals peronals = [
    new Personal()
    {
        Name = "Taha",
        Age = 1
    }
];

Customer customer = (1, "Taha");

var (customerNumber, customerName) = customer;

Console.WriteLine(customerNumber);
Console.WriteLine(customerName);

#endregion

#region 05-) Experimental Attribute

[Experimental("Feature01")]
void DeleteDatabase()
{
    Console.WriteLine("Veri Tabanı Silindi.");
}

#pragma warning disable Feature01
DeleteDatabase();
#pragma warning restore Feature01

// DeleteDatabase();

#endregion

#region 06-) Inline Diziler: Performansı Artıran Yenilik


var myInlineArray = new MyInlineArray<int>();

for (int i = 0; i < 5; i++)
{
    myInlineArray[i] = i;
}

foreach (var inline in myInlineArray)
{
    Console.WriteLine(inline);
}

#endregion

#region 07-) Raw String Literals

var id = 1;
var firstName = "Taha";
var lastName = "Pek";

var json = $$"""
    {
        "id": "{{id}}",
        "firstName": "{{firstName}}",
        "lastName": "{{lastName}}"
    }
""";

Console.WriteLine(json);

#endregion

#region 08-) Interceptors: Yenilikçi ve Deneysel Bir Yaklaşım
var e = new Example();
e.Method1();
e.Method2();
#endregion

#region 09-) Ref Readonly Parameter

Console.WriteLine("ref readonly Parametre");
int sayi = 1;
ShowAndIncerase(ref sayi);
Console.WriteLine($"{sayi}");

void ShowAndIncerase(ref readonly int number)
{
    Console.WriteLine(number);
    // number++;
}

#endregion

#region 10-) Random.Shared
Console.WriteLine("Random.Shared");

int[] arrays = new int[] { 1, 3, 4, 56, 7, 89, 5, 4, 2, 34, 65, 4 };

var randomNumbers = Random.Shared.GetItems(arrays, 4);
randomNumbers.ToList().ForEach(p => Console.Write(" " + p));

Console.WriteLine();

// Random Forest, Logistic Regression, Naive Bayes -> Asiri Ogrenmeyi Engeller
Random.Shared.Shuffle(arrays);

arrays.ToList().ForEach(p => Console.Write(" " + p));

Console.WriteLine();
#endregion

#region 11-) System.Text.Json’da Perfomans İyileştirmesi Ve Yeni Özellikler:
//// .NET 8 ile birlikte System.Text.Json’da Perfomans artışı ve yeni birçok özellik dahil edildi.
//// Bu da frameworkun NewtonSoft Json kutuphanesine olan bağımlığını ortadan kaldırdı.
Console.WriteLine("System.Text.Json’da Perfomans İyileştirmesi Ve Yeni Özellikler");

//// Interface Hierarchies

IDerived derived = new DerivedImplementation()
{
    Base = 0,
    Drived = 1
};

var text = JsonSerializer.Serialize(derived);

Console.WriteLine(text);

// New Json Node API Methods

JsonNode node1 = JsonNode.Parse(text);
JsonNode node2 = JsonNode.Parse(text);

Console.WriteLine(JsonNode.DeepEquals(node1, node2));

#endregion

#region 12-) Streaming Deserialization

// IAsyncEnumarable

#endregion

#region 13-) System.Collection.Frozen

Console.WriteLine("System.Collection.Frozen");

//Amaç Hızlı Okuma (bir kere yazılır ve bir daha değişmez)

Dictionary<int, string> dict = new Dictionary<int, string>();
dict.Add(1, "Taha");
dict.Add(2, "Pek");

FrozenDictionary<int, string> frozenDict = dict.ToFrozenDictionary();

List<int> list = [1, 2, 3];
FrozenSet<int> frozenSet = list.ToFrozenSet();

string value = "";
frozenDict.TryGetValue(1, out value);
Console.WriteLine(value);

Console.WriteLine(frozenSet.First());

#endregion

#region 14-) String.IndexOfAny
// O(1) Time Complexity
string test = "Doğuş Teknoloji";
var sequence = test.IndexOfAny(['u']);
Console.WriteLine(sequence);
#endregion

#region 15-) LINQ Sorgularının Performansı
// performans artmistir.
// %35
#endregion

#region 16-) Keyed Service | Dependency Injection
// Web Projesinde
#endregion

#region 17-) Short-Circuit Routing
// Web Projesinde
#endregion

#region 18-) IExceptionHandler
// web projesinde
#endregion

#region 19-) Minimal API Ahead of Time(AOT) Compilation Template
// web projesinde
#endregion

#region 20-) Interface With Body
IMailService mailService = new MailService();
mailService.SendMail();
IMailService.StaticMethod();
#endregion

#region 21-) Switch Expression

string WhatIsType(ShapeTypes type)
{
    var name = type switch
    {
        ShapeTypes.Kare => "Kare",
        ShapeTypes.Daire => "Daire",
        ShapeTypes.Ucgen => "Ucgen",
        _ => ""
    };

    return name;
}

Console.WriteLine(WhatIsType(ShapeTypes.Kare));

#endregion

#region 22-) Is Keyword Not Pattern

// Önce C#9
string name = null;
if (!(name is null)) { }

// Sonra
if (name is not null) { }

#endregion

#region 23-) Property Region

//Personal personal = new()
//{
//    Name = "Taha",
//    Age = 21
//};

Personal personal = null;

if (personal is { Name: "Taha", Age: 21 })
{
    Console.WriteLine("Esit Evet");
}
else
{
    Console.WriteLine("Esit Değil");
}

#endregion

#region 24-) Nameof

Console.WriteLine("nameOf");

var myNameOf = new NameOf();

var y = myNameOf.StringLength("asdas");

NameOf.NameOfExamples();

var method = myNameOf.GetType().GetMethod("StringLength");
var c = method.GetCustomAttributes(true);
var attribute = (DescriptionAttribute)c[0];
Console.WriteLine(attribute == null ? "null" : attribute.Description);

#endregion








