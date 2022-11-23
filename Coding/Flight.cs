class Flight
{
    private string Country;
    private double TimeOut;
    private double TimeIn;
    private double Price;

    public Flight(string Country,double TimeOut,double TimeIn,double Price)
    {
        this.Country = Country;
        this.TimeOut = TimeOut;
        this.TimeIn = TimeIn;
        this.Price = Price;
    }
    public double GetPrice()
    {
        return this.Price;
    }
    public string GetCountry()
    {
        return this.Country;
    }
    public double GetTimeOut()
    {
        return this.TimeOut;
    }
    public double GetTimeIn()
    {
        return this.TimeIn;
    }
    
}