public class CalMoney
{
    public static double CalM(double Adult,double Child,double Baby,double Price)
    {
        double calculate = (Adult * Price) + (Child * (Price * 0.75)) + (Baby * (Price * 0.1));
        return calculate;
    }
 
}