using FactoryDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        // client code

        Console.WriteLine("Enter the type of Vehicle: ");
        string? vehicleType = Console.ReadLine();

        IVehicle? vehicle = VehicleFactory.GetVehicle(vehicleType);

        if(vehicle != null)
        {
            vehicle.Deliver();
        }
    }
}

/*
 * Factory Method takes care of object creation for client. There is no need for client to write big if-else ladder for different vehicle Types.
 * The owner of the Vehicle Factory will take care of the creation and adding new vehicles in the library.
 * 
 * If there is a new requirement of new Vehicle type (Car) then there is no need to change the code from client side.
 * 
 * 
 */