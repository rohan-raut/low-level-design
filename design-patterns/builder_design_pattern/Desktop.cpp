#include "Desktop.hpp"

void Desktop::setKeyboard(string pKeyboard){
    keyboard = pKeyboard;
}

void Desktop::setMonitor(string pMonitor){
    monitor = pMonitor;
}

void Desktop::setMotherboard(string pMotherboard){
    motherboard = pMotherboard;
}

void Desktop::setMouse(string pMouse){
    mouse = pMouse;
}

void Desktop::setProcessor(string pProcessor){
    processor = pProcessor;
}

void Desktop::setRam(string pRam){
    ram = pRam;
}

void Desktop::setSpeaker(string pSpeaker){
    speaker = pSpeaker;
}

void Desktop::showSpec(){
    cout<<"----------------------"<<endl;
    cout<<"Monitor: "<<monitor<<endl;
    cout<<"Keyboard: "<<keyboard<<endl;
    cout<<"Mouse: "<<mouse<<endl;
    cout<<"Speaker: "<<speaker<<endl;
    cout<<"RAM: "<<ram<<endl;
    cout<<"Processor: "<<processor<<endl;
    cout<<"Motherboard: "<<motherboard<<endl;
    cout<<"----------------------"<<endl;
}