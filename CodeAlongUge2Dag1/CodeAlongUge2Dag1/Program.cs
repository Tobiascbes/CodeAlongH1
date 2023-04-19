using CodeAlongUge2Dag1.Codes;
using CodeAlongUge2Dag1.EnumEx;

//Niels niels = new Niels("Niels", "Elsborg", "Olesen");
//Niels niels = new("Niels", "Elsborg", "Olesen");
var niels = new Niels("Niels", "Elsborg", "Olesen");
Niels niels2 = new Niels("Neils", "Olesen");


//Enum
Console.WriteLine("Angiv din bil mærke:");
string inputText = Console.ReadLine();
if(inputText == EnumCars.Audi.ToString())
{

}

Console.WriteLine($"Min bil: {EnumCars.Audi.ToString()}");
Console.WriteLine($"Niels bil: {niels.NielsCar.ToString()}");

string returnValue = niels.ShowText2();
Console.WriteLine(returnValue);