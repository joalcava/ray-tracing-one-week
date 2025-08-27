public class Point : Vec3;

public class Color : Vec3;

public class Vec3
{
    private double[] e;

    public Vec3()
    {
        e = new double[3] { 0, 0, 0 };
    }

    public Vec3(double e0, double e1, double e2)
    {
        e = new double[3] { e0, e1, e2 };
    }

    double x() => e[0];

    double y() => e[1];

    double z() => e[2];

    public double this[int i] => e[i];

    // public static Vec3 operator -(Fraction operand) => operand;
}
