using System;
public class Circle : IShapes
{
    public double radius{get; set;}
    public void GetArea()
    {
        Console.WriteLine("The area of Circle is " + (Math.PI*radius*radius));
    }
}