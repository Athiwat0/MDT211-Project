class Flight
{
    private string Price;
    private string Country;
    private string Time;

    public Flight(string Price,string Country,string Time)
    {
        this.Price = Price;
        this.Country = Country;
        this.Time = Time;
    }
    public string GetPrice()
    {
        return this.Price;
    }
    public string GetCountry()
    {
        return this.Country;
    }
    public string GetTime()
    {
        return this.Time;
    }
    
}