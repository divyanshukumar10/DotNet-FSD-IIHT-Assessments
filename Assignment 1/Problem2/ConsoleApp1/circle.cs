using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Circle
{
    protected double radius;

    public Circle()
    {
        Radius = 0.00;
    }

    public Circle(double rad)
    {
        radius = rad;
    }

    public double Radius
    {
        get
        {
            return radius;
        }

        set
        {
            radius = value;
        }
    }

    public double Area { get { return radius * radius * Math.PI; } }
    public double Diameter { get { return radius * 2; } }
    public double Circumferemce
    {
        get { return Diameter * Math.PI; }
    }
}