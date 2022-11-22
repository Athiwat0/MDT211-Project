class Flight
{
    private double Price;
    private string Country;
    private double Time;

    public Flight(double Price,string Country,double Time)
    {
        this.Price = Price;
        this.Country = Country;
        this.Time = Time;
    }
    public double GetPrice()
    {
        return this.Price;
    }
    public string GetCountry()
    {
        return this.Country;
    }
    public double GetTime()
    {
        return this.Time;
    }
    
}