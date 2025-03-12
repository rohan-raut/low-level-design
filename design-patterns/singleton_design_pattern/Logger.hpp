#ifndef LOGGER_H
#define LOGGER_H

#include <iostream>
#include <mutex>
using namespace std;

class Logger
{
private:
    static Logger *loggerInstance;
    static mutex mtx;
    Logger();
    Logger(const Logger &);           // copy constructor
    Logger operator=(const Logger &); // cpp specific

public:
    static Logger* getLogger();
    void logMessage(string msg);
};

#endif