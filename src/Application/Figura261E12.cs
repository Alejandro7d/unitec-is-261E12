namespace Application;

public class Figura261E12
{
    public static double Perimetro(double lado)
    {
        return lado + lado + lado + lado;
    }
    public static double Area(double d, double D)
    {
        return (d*D)/2;
    }
    public static double Volumen(double Area, double altura)
    {
        return Area * altura; 
    }
}