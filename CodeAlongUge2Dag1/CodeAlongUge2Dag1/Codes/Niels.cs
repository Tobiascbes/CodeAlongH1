using CodeAlongUge2Dag1.EnumEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongUge2Dag1.Codes;

internal class Niels
{
    #region properties
    public string FirstName { get; set; }
    public string LastName { get; set; }

    private string _middleName;
    #endregion
    public Niels(string firstName, string middleName, string lastName)
    {
     
        FirstName = firstName;
        SetMiddleName(middleName);
        LastName = lastName;
        NielsCar = EnumCars.Audi;
    }

    public Niels(string firstName, string lastName)
    {

    }
    private void SetMiddleName(string middleName)
    {
        _middleName = middleName;
    }

    public string GetMiddleName()
    {
        return _middleName;
    }
    public void ShowText()
    {
        Console.WriteLine($"Hello {FirstName} {LastName}!");
    }
    public string ShowText2()
    {
        return $"Hello {FirstName} {_middleName} {LastName}!";
    }

    public EnumCars NielsCar { get; set; }
}
