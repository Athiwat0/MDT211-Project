namespace testFinal;

public class UnitTestFlight
{
    Flight mockNewFlight = new Flight("Korea", 12.00 , 17.00 , 11111.11);

    [Fact]
    public void TestCreateNewFlight() 
    {
        Assert.IsType<Flight>(mockNewFlight);
    }

    [Fact]
    public void TestEqualGetCountry() 
    {
        Assert.Equal(mockNewFlight.GetCountry(), "Korea");
    }
   [Fact]
    public void TestNotEqualGetCountry() 
    {
        Assert.NotEqual(mockNewFlight.GetCountry(), "Japan");
    }


    [Fact]
    public void TestEqualGetTimeOut() 
    {
        Assert.Equal(mockNewFlight.GetTimeOut(), 12.00);
    }
    [Fact]
    public void TestNotEqualGetTimeOut() 
    {
        Assert.NotEqual(mockNewFlight.GetTimeOut(), 15.00);
    }

    [Fact]
    public void TestEqualGetTimeIn() 
    {
        Assert.Equal(mockNewFlight.GetTimeIn(), 17.00);
    }
    [Fact]
    public void TestNotEqualGetTimeIn() 
    {
        Assert.NotEqual(mockNewFlight.GetTimeIn(), 20.00);
    }

    [Fact]
    public void TestEqualGetPrice() 
    {
        Assert.Equal(mockNewFlight.GetPrice(), 11111.11);
    }
    [Fact]
    public void TestNotEqualGetPrice() 
    {
        Assert.NotEqual(mockNewFlight.GetPrice(), 22222.22);
    }  
    
}