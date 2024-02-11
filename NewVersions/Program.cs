#region using
using NewVersions;
using System.ComponentModel;
using Peronals = System.Collections.Generic.List<NewVersions.Personal>;
using Customer = System.ValueTuple<int, string>;
using System.Diagnostics.CodeAnalysis;
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
        new User ()
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

//DeleteDatabase();

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

#region Interceptors: Yenilikçi ve Deneysel Bir Yaklaşım

#endregion

#region Nameof

var myNameOf = new NameOf();

var y = myNameOf.StringLength("asdas");

NameOf.NameOfExamples();

var method = myNameOf.GetType().GetMethod("StringLength");
var c = method.GetCustomAttributes(true);
var attribute = (DescriptionAttribute)c[0];
Console.WriteLine(attribute == null ? "null" : attribute.Description);

#endregion

#region  Random.Shared
int[] arrays = new int[]{ 1, 3, 4, 56, 7, 89, 5, 4, 2, 34, 65, 4 };

var randomNumbers = Random.Shared.GetItems(arrays, 4);
randomNumbers.ToList().ForEach(p => Console.WriteLine(p));

Random.Shared.Shuffle(arrays);

arrays.ToList().ForEach(p => Console.Write(" "+p));

Console.WriteLine();
#endregion

#region Keyed Service | Dependency Injection
// Web Projesinde
#endregion

#region Short-Circuit Routing
// Web Projesinde
#endregion

#region IExceptionHandler
// web projesinde
#endregion

#region Minimal API Ahead of Time(AOT) Compilation Template
// web projesinde
#endregion

#region LİNQ Sorgularının Performansı
// performans artmistir.
#endregion

#region System.Text.Json’da Perfomans İyileştirmesi:
// Perofrmans Artis
#endregion

#region ref readonly Parametre
// Arastirmali
#endregion


// Arastir Bunlar Ne Zaman Geldi.

#region Interface With Body
IMailService mailService = new MailService();
mailService.SendMail();
IMailService.StaticMethod();
#endregion

#region Readonly Struct
var rectangele = new MyStruct(5, 4);
Console.WriteLine(rectangele);
#endregion

#region Switch Expression

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

