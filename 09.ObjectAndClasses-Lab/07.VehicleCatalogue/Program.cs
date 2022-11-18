using _07.VehicleCatalogue;

string command = Console.ReadLine();

Catalog catalog = new Catalog()
{
    Cars = new List<Car>(),
    Trucks = new List<Truck>()
};

while (command != "end")
{
    string[] currCommand = command.Split("/", StringSplitOptions.RemoveEmptyEntries);

    string type = currCommand[0];
    string brand = currCommand[1];
    string model = currCommand[2];
    
    if (type == "Car")
    {
        int horsePower = int.Parse(currCommand[3]);

        Car newCar = new Car()
        {
            Brand = brand,
            Model = model,
            HorsePower = horsePower
        };

        catalog.Cars.Add(newCar);
    }
    else if (type == "Truck")
    {
        int weight = int.Parse(currCommand[3]);

        Truck newTruck = new Truck()
        {
            Brand = brand,
            Model = model,
            Weight = weight
        };

        catalog.Trucks.Add(newTruck);
    }

    command = Console.ReadLine();
}

List<Car> orderedCars = catalog.Cars.OrderBy(x => x.Brand).ToList();
List<Truck> orderedTrucks = catalog.Trucks.OrderBy(x => x.Brand).ToList();

if (orderedCars.Count > 0)
{
    Console.WriteLine("Cars:");

    foreach (Car car in orderedCars)
    {
        Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
    }
}

if (orderedTrucks.Count > 0)
{
    Console.WriteLine("Trucks:");

    foreach (Truck truck in orderedTrucks)
    {
        Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
    }
}


