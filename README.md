# GirlMath

What is girlmath? girlmath is a single static class you simple put as a submodule in your Godot game project which then provides a myriad of math functions I don't want to deal with :D

## Functions!

```
# takes a degree variable and converts it to a radian, can take either float or double, returns same type
float deg2rad(float degree)
double deg2rad(double degree)
# takes a radian variable and converts it to a degree, can take either float or double, returns same type
float rad2deg(float radian)
double rad2deg(double radian)
```

## Install

To add to a C# Godot 4.x project, though we only supprot 4.3
```
git submodule add -b main https://github.com/GayFreaks/GirlMath
```

And to update, which you may want to at some point you run in the root of your project and then push the new binary file which represents the git repo
```
git submodule update --remote
```