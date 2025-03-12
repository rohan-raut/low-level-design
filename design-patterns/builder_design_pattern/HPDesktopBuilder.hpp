#ifndef HPDESKTOPBUILDER_H
#define HPDESKTOPBUILDER_H

#include "DesktopBuilder.hpp"

class HPDesktopBuilder: public DesktopBuilder{
    void buildMonitor();
    void buildKeyboard();
    void buildMouse();
    void buildSpeaker();
    void buildRam();
    void buildProcessor();
    void buildMotherboard();
};


#endif