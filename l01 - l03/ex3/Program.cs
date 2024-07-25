namespace ex3;

class Program
{
    static void Main(string[] args)
    {
        Car v1 = new Car("Toyota", "Corolla", 2020, 4, "Sedan");
        Car.DisplayInfo(v1);

        Motorcycle v2 = new Motorcycle("Honda", "CBR600RR", 2019, 2.2);
        Motorcycle.DisplayInfo(v2);

        Car.Drive(v1);
        Motorcycle.Ride(v2);
    }
}
