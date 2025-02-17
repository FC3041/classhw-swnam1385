#include <iostream>
#include <cmath>

class Circle 
{
private:
    double x, y; 
    double radius;

public:

    Circle(double xCoord, double yCoord, double r) {
        x = xCoord;
        y = yCoord;
        radius = r;
    }

    double mohit() 
    {
        return 2 * M_PI * radius;
    }

    double masahat() 
    {
        return M_PI * radius * radius;
    }

    void displayInfo() 
    {
        std::cout << "markaz: (" << x << ", " << y << ")" << std::endl;
        std::cout << "shoaa: " << radius << std::endl;
        std::cout << "mohit: " << mohit() << std::endl;
        std::cout << "masaht: " << masahat() << std::endl;
    }
};

int main() 
{
    Circle circle1(2.0, 3.0, 5.0);
    circle1.displayInfo();
    
    return 0;
}
