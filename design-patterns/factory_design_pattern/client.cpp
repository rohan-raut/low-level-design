#include <iostream>
#include "vehicle_factory.hpp"

using namespace std;

int main()
{

    string vehicleType;
    cin>>vehicleType;

    Vehicle* vehicle = VehicleFactory::getVehicle(vehicleType);

    if(vehicle != nullptr){
        vehicle->createVehicle();
    }
    
    
    return 0;
}