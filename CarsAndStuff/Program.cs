using CarsAndStuff;

var car1 = new Car();
car1.Make = "Toyota";
car1.Model = "4Runner";
car1.Year = 2020;
car1.Trim = "TRD Offroad-Premium";

var car2 = new Car();
car2.Make = "Hummer";
car2.Model = "H1";
car2.Year = 2006;

Console.WriteLine("Would you like a hummer or a 4runner?");
var answer = Console.ReadLine();

if (answer == "4runner")
{
    car1.PrintCarInfo();
}
else if (answer == "hummer")
    {
        car2.PrintCarInfo();
    }
else 
    {
        Console.WriteLine("I dont have that car, leave my dealership now!");
    }