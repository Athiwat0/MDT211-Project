public class History
{
    private string ID;
    private string country;
    private double timeOut;
    private double timeIn;
    private double totalprice;
    private double Adult;
    private double Child;
    private double Baby;

    public History(string ID,string country,double timeOut,double timeIn,double totalprice,double Adult,double Child,double Baby)
    {
        this.ID = ID;
        this.country = country;
        this.timeOut = timeOut;
        this.timeIn = timeIn;
        this.totalprice = totalprice;
        this.Adult = Adult;
        this.Child = Child;
        this.Baby = Baby;
    }
    public string GetID()
    {
        return this.ID;
    }
    public string GetCountry()
    {
        return this.country;
    }
    public double GetTimeOut()
    {
        return this.timeOut;
    }
    public double GetTimeIn()
    {
        return this.timeIn;
    }
    public double GetTotalPrice()
    {
        return this.totalprice;
    }
    public double GetAdult()
    {
        return this.Adult;
    }
    public double GetChild()
    {
        return this.Child;
    }
    public double GetBaby()
    {
        return this.Baby;
    }

}