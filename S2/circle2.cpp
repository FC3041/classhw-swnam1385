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

    double getCircumference() 
    {
        return 2 * M_PI * radius;
    }
    double getArea() 
    {
        return M_PI * radius * radius;
    }

    double distanceFromCenter(double px, double py) 
    {
        return std::sqrt((px - x) * (px - x) + (py - y) * (py - y));
    }

    bool isInside(double px, double py) 
    {
        return distanceFromCenter(px, py) <= radius;
    }

    void displayInfo() 
    {
        std::cout << "markaz: (" << x << ", " << y << ")" << std::endl;
        std::cout << "shoa: " << radius << std::endl;
        std::cout << "mohit: " << getCircumference() << std::endl;
        std::cout << "masahat: " << getArea() << std::endl;
    }
};

int main() 
{
    Circle circle1(2.0, 3.0, 5.0);
    circle1.displayInfo();
    double px = 4.0, py = 6.0;
    double distance = circle1.distanceFromCenter(px, py);
    std::cout << "fasele az markaz: " << distance << std::endl;
    
    if (circle1.isInside(px, py)) {
        std::cout << "inside the circle" << std::endl;
    } else {
        std::cout << "out of circle" << std::endl;
    }
    
    return 0;
}
