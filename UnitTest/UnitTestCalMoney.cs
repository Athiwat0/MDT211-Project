namespace testFinal;

public class UnitTestCalMoney
{
    [Fact]
    public void TestCalM()
    {
        double Adult = 2;
        double Child = 4;
        double Baby = 6;
        double Price = 100;
        double TestCalculate = CalMoney.CalM(Adult,Child,Baby,Price);
        
        Assert.Equal(TestCalculate,560);

    }
    [Fact]
    public void TestNotEqualCalM()
    {
        double Adult = 2;
        double Child = 4;
        double Baby = 6;
        double Price = 100;
        double TestCalculate = CalMoney.CalM(Adult,Child,Baby,Price);
        
        Assert.NotEqual(TestCalculate,567);

    }

}