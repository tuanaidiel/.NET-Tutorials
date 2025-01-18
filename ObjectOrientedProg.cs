class Car
{
    public string brand;
}

class Program
{
    static void Main()
    {
        Car car1 = new Car();
        car1.brand = "mercedes";

        Car car2 = new Car();
        car2.brand = "bmw";
        
        System.Console.WriteLine(car1.brand);
        System.Console.WriteLine(car2.brand);
    }
}