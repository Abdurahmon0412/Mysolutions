
using Practice12_1;

List<Car> cars = new List<Car>();

cars.Add(new Car("Accord", "Honda"));
cars.Add(new Car("Camry", "Toyota"));
cars.Add(new Car("Civic", "Honda"));
cars.Add(new Car("Accord", "Honda"));
cars.Add(new Car("Elantra", "Hyundai"));
cars.Add(new Car("Accord", "Honda"));
cars.Add(new Car("Sonata", "Hyundai"));
cars.Add(new Car("Elantra", "Hyundai"));
cars.Add(new Car("Fusion", "Ford"));
cars.Add(new Car("Malibu", "Chevrolet"));
foreach(Car car in cars)
{
    Console.WriteLine($"{ car.Name} {car.Brand}");

}
Dictionary<Car,int> cars1 = new Dictionary<Car,int>();

foreach(Car car in cars)
{
    if(!cars1.ContainsKey(car))
        cars1.Add(car, 1);
    else
    {
        cars1[car]++;
    }
}
Console.WriteLine();
foreach (var car in cars1)
{
    if(car.Value > 1)
    {
        Console.WriteLine(car.Key.Name  + car.Key.Name + ": " + car.Value);
    }
    else
    {
    }
}


