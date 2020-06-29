using System;
public class Client
{
    public static void Main()
    {
        IShapes shape=new Circle{radius=4};
        shape.GetArea();

        shape=new Rectangle{Length=5.3, Width=4};
        shape.GetArea();

        shape=new Square{a=5};
        shape.GetArea();
    }
}