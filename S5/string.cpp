#include <iostream>
#include <vector>
#include <string>
using namespace std;


class String
{
    public:
        string str1;
        string str2;
};

void size(int x) {
    cout << "Size of int: " << sizeof(int) << endl;
}

void c_str()
{
    std::string str = "Hello, world!";
    const char* c_str = str.c_str();
    std::cout << c_str << std::endl;
}

void append() 
{
    string str1("Hello World! ");
    string str2("GeeksforGeeks");
    str1.append(str2);
    cout << str1 << endl;
}

void assign(string str1, string str2)
{
    str1.assign(str2);
    cout << "After assign() : ";
    cout << str1;
 
}
int main()
{
    string str1("ali"); 
    string str2; 
    str2.assign("mozhdeh");
    cout << str1.c_str() << ":" << str1.size() << endl; 
    str1.append(" + ");
    str1.append(str2); 
    str1.append("\n");
    cout << str1.c_str() << endl;
    return 0;
}
