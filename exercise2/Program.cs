using exercise2;

IDriveable newMotorbike = new Motorbike() { Name= "Honda"};
IDriveable newCar = new Car() { Name = "BMW" };
IDriveable newBus = new Bus() { Name = "Volvo" };

newMotorbike.TurnRight(); // because it is non static method we use  a object.method

Motorbike.TestDrive(newMotorbike); // Here with static method we can use a className.method
Car.TestDrive(newCar);
Bus.TestDrive(newBus);

