#include <iostream>
#include <cmath>

class Circle {
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

    double fasele_az_markaz(double px, double py) 
    {
        return std::sqrt((px - x) * (px - x) + (py - y) * (py - y));
    }

    bool isInside(double px, double py) 
    {
        return fasele_az_markaz(px, py) <= radius;
    }

    void etelaat() 
    {
        std::cout << "markaz: (" << x << ", " << y << ")" << std::endl;
        std::cout << "shoa: " << radius << std::endl;
        std::cout << "mohit: " << mohit() << std::endl;
        std::cout << "masahat: " << masahat() << std::endl;
    }
};

int main() 
{
    Circle circle1(2.0, 3.0, 5.0);
    circle1.etelaat();
    double px = 4.0, py = 6.0;
    double distance = circle1.fasele_az_markaz(px, py);
    std::cout << "fasele az markaz: " << distance << std::endl;
    
    if (circle1.isInside(px, py)) {
        std::cout << "inside the circle" << std::endl;
    } else {
        std::cout << "out of circle" << std::endl;
    }
    
    return 0;
}
