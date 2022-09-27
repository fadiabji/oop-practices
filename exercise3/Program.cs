using exercise3;

Motorbike newMotorbike = new Motorbike() { Name= "Honda MotorBike"};
Car newCar = new Car() { Name = "BMW Car" };
Bus newBus = new Bus() { Name = "Volvo Bus" };

System.Console.WriteLine("First call Gas : ");
newMotorbike.Gas();
newCar.Gas();
newBus.Gas();
System.Console.WriteLine("\n");

// Edit the speed variable in the constructar in each class to 155 for Motorbik and Car and 115 to Bus to see the check specifications.
System.Console.WriteLine("Second call Gas : ");
newMotorbike.Gas();
newCar.Gas();
newBus.Gas();
System.Console.WriteLine("\n");

System.Console.WriteLine("First call Break : ");
newMotorbike.Break();
newCar.Break();
newBus.Break();
System.Console.WriteLine("\n");

System.Console.WriteLine("Second call Break : ");
newMotorbike.Break();
newCar.Break();
newBus.Break();
System.Console.WriteLine("\n");


// Making sure that the speed don't go less than 0
System.Console.WriteLine("Third call Break : ");
newMotorbike.Break();
newCar.Break();
newBus.Break();
System.Console.WriteLine("\n");