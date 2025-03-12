#include <iostream>
#include "Logger.hpp"
#include <thread>

using namespace std;

/*
1. for singleton design pattern make constructor as private so it cannot be accessed by client
to make multiple objects. 
2. Make the logger instance as static.
3. Add lock while create the logger instance.
*/

void user1(){
    Logger* logger1 = Logger::getLogger();
    logger1->logMessage("user1 log");
}

void user2(){
    Logger* logger2 = Logger::getLogger();
    logger2->logMessage("user2 log");
}

int main()
{
    
    thread th1(user1);
    thread th2(user2);

    th1.join();
    th2.join();
        
    
    return 0;
}