using System;
public class Square : IShapes
{
    public double a{get; set;}
    public void GetArea()
    { 
        Console.WriteLine("The area of the Square is "+ (a * a));
    }  
}