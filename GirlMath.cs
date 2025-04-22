using System;

public static class GirlMath
{
    /// <Summary>
    /// If supplied a float degree value it will return a float radian value
    /// </Summary>
    public static float deg2rad(float degree)
    {
        return degree * (float)(Math.PI / 180);
    }

    /// <Summary>
    /// If supplied a float radian value it will return a float degree value
    /// </Summary>
    public static float rad2deg(float radian)
    {
        return radian * (float)(180 / Math.PI);
    }

    /// <Summary>
    /// If supplied a double degree value it will return a double radian value
    /// </Summary>
    public static double deg2rad(double degree)
    {
        return degree * (Math.PI / 180);
    }

    /// <Summary>
    /// If supplied a double radian value it will return a float degree value
    /// </Summary>
    public static double rad2deg(double radian)
    {
        return radian * (180 / Math.PI);
    }
}
