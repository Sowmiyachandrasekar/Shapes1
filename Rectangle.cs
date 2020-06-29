using System;
public class Rectangle : IShapes
{
    public double Length{get; set;}
    public double Width{get; set;}
    public void GetArea()
    {
        Console.WriteLine("The area of Rectangle is " +(Length*Width));
    }
    
}