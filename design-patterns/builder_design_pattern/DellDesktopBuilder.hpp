#ifndef DELLDESKTOPBUILDER_H
#define DELLDESKTOPBUILDER_H

#include "DesktopBuilder.hpp"

class DellDesktopBuilder: public DesktopBuilder{
    void buildMonitor();
    void buildKeyboard();
    void buildMouse();
    void buildSpeaker();
    void buildRam();
    void buildProcessor();
    void buildMotherboard();
};


#endif