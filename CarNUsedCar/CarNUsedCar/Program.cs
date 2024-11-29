// See https://aka.ms/new-console-template for more information
using CarNUsedCar;

Console.WriteLine("Welcome to Grant Chirpus’ Used Car Emporium!");

Car.carList = new List<Car>()
{
    new ("Honda", "CRV", 2024, 34000.00),
    new ("Toyota", "4Runner", 2024, 62000.00),
    new ("Dodge", "Charger", 2023, 32000.00),
    new UsedCar("Ford", "Focus", 2013, 20000.00, 100000),
    new UsedCar("Chevy", "Cruze", 2013, 20000.00, 150000),
    new UsedCar("Dodge", "Charger", 2013, 20000.00, 120000),
};

bool runProgram = true;
while (runProgram)
{
    DisplayMenu();

    int menuChoice = -1;
    while (menuChoice <= -1 || menuChoice > Car.carList.Count + 2)
    {

        Console.Write($"Choose a menu option. 1 - {Car.carList.Count + 2}: ");

        while (int.TryParse(Console.ReadLine(), out menuChoice) == false)
        {
            Console.WriteLine("Incorrect Format");
        }
    }

    // buying car
    if (menuChoice < Car.carList.Count +1)
    {
        Car carChoice = Car.carList[menuChoice - 1];
        if (BuyCar(carChoice) == true)
        {
            Car.carList.Remove(carChoice);
            Console.WriteLine("Our finance team will reach out to you shortly");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Feel free to keep looking around");
        }
    }
    //adding car
    else if (menuChoice == Car.carList.Count + 1)
    {
        Car newCar = AddCar();
        Car.carList.Add(newCar);
    }
    //quitting
    //else if (menuChoice == Car.carList.Count + 2)
    else
    {
        Console.WriteLine("Goodbye!");
        runProgram = false;
    }
}


static bool BuyCar(Car car)
{

    Console.WriteLine("Would you like to buy this car? y/n");

    Console.Write($"{car}: ");
    string buyChoice = Console.ReadLine();
    if (buyChoice == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

static Car AddCar()
{
    //pretend these are all validated
    Console.Write("What is the car's make? ");
    string make = Console.ReadLine();
    Console.Write("What is the car's model? ");
    string model = Console.ReadLine();
    Console.Write("What is the car's year? ");
    int year = int.Parse(Console.ReadLine());
    Console.Write("What is the car's price? ");
    double price = double.Parse(Console.ReadLine());

    Console.Write("Is the car used? y/n ");
    string used = Console.ReadLine();
    if (used == "y")
    {
        Console.Write("What is the used car's mileage? ");
        double mileage = double.Parse(Console.ReadLine());

        return new UsedCar(make, model, year, price, mileage);
    }
    else
    {
        return new Car(make, model, year, price);
    }
}

static void DisplayMenu()
{
    for (int i = 0; i < Car.carList.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {Car.carList[i]}");
    }
    Console.WriteLine($"{Car.carList.Count + 1}. Add Car");
    Console.WriteLine($"{Car.carList.Count + 2}. Quit");
    Console.WriteLine();
}

Console.WriteLine("Press any key to quit.");
Console.ReadKey();