using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Cylinder : Circle
{
    public double Height { get; set; }

    public Cylinder(double baseRadius = 0.00, double height = 0.00)
    {
        radius = baseRadius;
        Height = height;
    }

    public double LateralArea
    {
        get
        {
            return Circumferemce * Height;
        }
    }

    public double Volume
    {
        get
        {
            return Area * Height;
        }
    }
}