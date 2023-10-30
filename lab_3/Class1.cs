using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab_3
{
    internal class Class1
    {
    }
}
class Rectangle :
    def init (self, side1, side2):
        self.side1 = side1
        self.side2 = side2

    def CalculateArea(self):
        return self.side1 * self.side2

    def CalculatePerimeter(self):
        return 2 * (self.side1 + self.side2)

    @property
    def Area(self):
        return self.CalculateArea()

    @property
    def Perimeter(self):
        return self.CalculatePerimeter()

# Отримання вводу від користувача
side1 = float(input("Введіть довжину першої сторони прямокутника: "))
side2 = float(input("Введіть довжину другої сторони прямокутника: "))

# Створення об'єкта Rectangle
rectangle = Rectangle(side1, side2)

# Виведення результатів
print("Площа прямокутника:", rectangle.Area)
print("Периметр прямокутника:", rectangle.Perimeter)
    class Point :
    def __init__(self, x, y, name):
        self.x = x
        self.y = y
        self.name = name

    @property
    def Name(self):
        return self.name

    @property
    def X(self):
        return self.x

    @property
    def Y(self):
        return self.y

class Figure :
    def __init__(self, *points):
        self.points = list(points)

    def GetSideLength(self, A, B):
        return ((B.X - A.X) * *2 + (B.Y - A.Y) * *2) * *0.5

    def CalculatePerimeter(self):
        perimeter = 0
        num_points = len(self.points)
        for i in range(num_points):
            perimeter += self.GetSideLength(self.points[i], self.points[(i + 1) % num_points])
        return perimeter

# Створення точок
point1 = Point(0, 0, "A")
point2 = Point(0, 2, "B")
point3 = Point(2, 2, "C")
point4 = Point(2, 0, "D")

# Створення багатокутника
figure = Figure(point1, point2, point3, point4)

# Виведення назви та периметра багатокутника
print("Назва багатокутника:", [point.Name for point in figure.points])
    print("Периметр багатокутника:", figure.CalculatePerimeter())
