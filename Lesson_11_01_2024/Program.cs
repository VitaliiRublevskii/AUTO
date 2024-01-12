

using System.Security.AccessControl;
using Lesson_11_01_2024;

List<string> auto = new List<string> { "AUDI", "Honda", "LEXUS", "BMW", "Volkwagen", 
    "Mersedes", "Toyota", "Ferrari", "Infinity", "KIA", "Acura", "Alfa Romeo"};

var res = auto.FindAll(x => x.Contains('a') || x.Contains('A'));
foreach (var item in res)
    Console.Write($"{item}, ");



Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


Auto auto1 = new Auto("Audi", "Q7", 3, "полный", "автомат");
Auto auto2 = new Auto("Audi", "A8", 3, "полный", "автомат");
Auto auto3 = new Auto("BMW", "M8 Gran Coupe", 4, "полный", "автомат");
Auto auto4 = new Auto("BMW", "5 Series", 2, "задний", "автомат");
Auto auto5 = new Auto("Lexus", "RX", 2, "полный", "автомат");

List<Auto> autos = new List<Auto>();
autos.Add(auto1);
autos.Add(auto2);
autos.Add(auto3);
autos.Add(auto4);
autos.Add(auto5);

foreach (var item in autos)
    item.CarShow();
Console.WriteLine(  );
Console.WriteLine(  );

var res1 = autos.FindAll(x => x.CarBrend.Contains('a') || x.CarBrend.Contains('A'));

foreach (var item in res1)
    item.CarShow();



