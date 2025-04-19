using System;

public static class GirlMath
{
    public static float deg2rad(float degree)
    {
        return degree * (float)(Math.PI / 180);
    }

    public static float rad2deg(float radian)
    {
        return radian * (float)(180 / Math.PI);
    }

    public static double deg2rad(double degree)
    {
        return degree * (Math.PI / 180);
    }

    public static double rad2deg(double radian)
    {
        return radian * (180 / Math.PI);
    }
}
