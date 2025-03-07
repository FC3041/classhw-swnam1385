#include <iostream>
#include <windows.h>

using namespace std;

class KeepTime 
{
private:
    DWORD start_time;
    string task_name;
public:
    KeepTime(const string& name) : task_name(name) 
    {
        start_time = GetTickCount();
    }
    ~KeepTime() 
    {
        DWORD end_time = GetTickCount();
        cout << " " << task_name << "zaman separi shodeh " << (end_time - start_time) << " ms" << endl;
    }
};

void wait(DWORD interval) 
{
    DWORD startTime = GetTickCount();
    while(GetTickCount() < (startTime + interval)) {}
}

void someTask() 
{
    KeepTime t(" ");
    for (volatile int i = 0; i < 100000000; ++i);
}

int main() 
{
    someTask();


    return 0;
}
