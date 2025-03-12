#include "Logger.hpp"

Logger *Logger::loggerInstance = nullptr;
mutex Logger::mtx;

Logger::Logger()
{
    cout << "Logger instance created" << endl;
}

Logger* Logger::getLogger()
{
    // double check because lock operations are costly
    if (loggerInstance == nullptr)
    {
        mtx.lock();
        if (loggerInstance == nullptr)
        {
            loggerInstance = new Logger();
        }
        mtx.unlock();
    }

    return loggerInstance;
}

void Logger::logMessage(string msg)
{
    cout << msg << endl;
}