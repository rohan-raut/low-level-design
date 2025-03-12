#include "vehicle_factory.hpp"

Vehicle* VehicleFactory::getVehicle(string vehicleType){
    Vehicle* vehicle = nullptr;

    if(vehicleType == "Car"){
        vehicle = new Car();
    }
    else if(vehicleType == "Bike"){
        vehicle = new Bike();
    }
    else{
        cout<<"No matching vehicle."<<endl;
    }

    return vehicle;
}
