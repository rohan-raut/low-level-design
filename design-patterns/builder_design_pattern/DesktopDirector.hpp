#ifndef DESKTOPDIRECTOR_H
#define DESKTOPDIRECTOR_H

#include "DesktopBuilder.hpp"

class DesktopDirector{
    private:
    DesktopBuilder* desktopBuilder;

    public:
    DesktopDirector(DesktopBuilder* pDesktopBuilder){
        desktopBuilder = pDesktopBuilder;
    }

    Desktop* buildDesktop(){
        desktopBuilder->buildKeyboard();
        desktopBuilder->buildMonitor();
        desktopBuilder->buildMotherboard();
        desktopBuilder->buildMouse();
        desktopBuilder->buildProcessor();
        desktopBuilder->buildRam();
        desktopBuilder->buildSpeaker();

        return desktopBuilder->getDesktop();
    }

    Desktop* getDesktop(){
        return desktopBuilder->getDesktop();
    }
};

#endif