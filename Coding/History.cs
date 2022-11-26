class History
{
    private string country;
    private double timeOut;
    private double timeIn;
    private double calculateF;
    private double Adult;
    private double Child;
    private double Baby;

    public History(string country,double timeOut,double timeIn,double calculateF,double Adult,double Child,double Baby)
    {
        this.country = country;
        this.timeOut = timeOut;
        this.timeIn = timeIn;
        this.calculateF = calculateF;
        this.Adult = Adult;
        this.Child = Child;
        this.Baby = Baby;
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
    public double GetPrice()
    {
        return this.calculateF;
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