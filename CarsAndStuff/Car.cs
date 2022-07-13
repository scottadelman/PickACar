using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndStuff;

internal class Car
{
    public Car()
    {

    }

    public Car(string make, string model, int year, string trim)
    {
        Make = make;
        Model = model;
        Year = year;
        Trim = trim;
    }   

    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Trim { get; set; }


    public void PrintCarInfo()
    {
        Console.WriteLine($"Your Car is a {Year} {Make} {Model} {Trim}");
    }
}

