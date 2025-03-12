#include <iostream>
#include "DellDesktopBuilder.hpp"
#include "HPDesktopBuilder.hpp"
#include "DesktopDirector.hpp"

using namespace std;


int main()
{
    HPDesktopBuilder* hpDesktopBuilder = new HPDesktopBuilder();
    DellDesktopBuilder* dellDesktopBuilder = new DellDesktopBuilder();

    DesktopDirector* hpDirector = new DesktopDirector(hpDesktopBuilder);
    DesktopDirector* dellDirector = new DesktopDirector(dellDesktopBuilder);

    Desktop* hpDesktop = hpDirector->buildDesktop();
    Desktop* dellDesktop = dellDirector->buildDesktop();

    hpDesktop->showSpec();
    dellDesktop->showSpec();

    
    return 0;
}