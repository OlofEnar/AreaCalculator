//Olof Maleki Nordin
//Labb 5 - Grunderna OOP
//.NET23 OOP

namespace GrundernaOOP
{
    //Abstract class for the shapes, rectangle and triangle
    //share lenght & height, and all share pi.
    public abstract class Shape
    {
        public float _pi = 3.141f;
        int _length;
        int _height;

        public int Length { get; set; }
        public int Height { get; set; }

    }

    //Circle class
    public class Circle : Shape
    {
        int _radius { get; set; }

        //Constructor
        public Circle(int radius)
        {
            _radius = radius;
        }

        //Method for calculating the circle area
        public float GetArea()
        {
            float area = 0;

            area = _radius * _radius * _pi;

            return area;
        }
    }

    //Rectangle class
    public class Rectangle : Shape
    {
        //Constructor
        public Rectangle(int length, int height)
        {
            Length = length;
            Height = height;
        }

        //Method for calculating the rectangle area
        public float GetArea()
        {
            float area = 0;

            area = Length * Height;

            return area;
        }
    }

    //Triangle class
    public class Triangle : Shape
    {
        //Constructor
        public Triangle(int length, int height)
        {
            Length = length;
            Height = height;
        }

        //Method for calculating the triangle area
        public float GetArea()
        {
            float area = 0;

            area = (Length * Height) / 2;

            return area;
        }
    }
}