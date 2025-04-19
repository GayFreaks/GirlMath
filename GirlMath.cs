using System;

namespace GirlMath;

public class GirlMath
{
    public float deg2rad(float degree)
    {
        return (float)degree * (Math.PI / 180);
    }

    public float rad2deg(float radian)
    {
        return (float)radian * (180 / Math.PI);
    }

    public double deg2rad(double degree)
    {
        return (double)degree * (Math.PI / 180);
    }

    public double rad2deg(double radian)
    {
        return (double)radian * (180 / Math.PI);
    }
}
