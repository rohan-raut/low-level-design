#include "HPDesktopBuilder.hpp"

void HPDesktopBuilder::buildMonitor(){
    desktop->setMonitor("HP Monitor");
}

void HPDesktopBuilder::buildKeyboard(){
    desktop->setKeyboard("HP Keyboard");
}

void HPDesktopBuilder::buildMouse(){
    desktop->setMouse("HP Mouse");
}

void HPDesktopBuilder::buildSpeaker(){
    desktop->setSpeaker("HP Speaker");
}

void HPDesktopBuilder::buildRam(){
    desktop->setRam("HP RAM");
}

void HPDesktopBuilder::buildProcessor(){
    desktop->setProcessor("HP Processor");
}

void HPDesktopBuilder::buildMotherboard(){
    desktop->setMotherboard("HP Motherboard");
}